using System;
using System.Collections.Generic;
using System.Reflection;
using ModSettings;
using UnityEngine;

namespace TldHacks;

// 菜单控件的公共入口:鼠标悬停说明。
//   key = TldHacksSettings 字段名,用来查说明文字。传 null 表示不需要说明。
internal static class Ui
{
    internal static float Scale = 1f;
    internal static GUIStyle TipStyle;

    private static bool _inView;
    internal static bool InView => _inView;
    private static Vector2 _mouseWin;
    private static string _key, _label;
    private static string _hoverKey;
    private static float _hoverSince;
    private static string _tipKey;
    private static GUIContent _tipContent;
    private static float _tipW, _tipH;

    private const float TIP_DELAY = 0.35f;
    private const float TIP_MAX_W = 340f;

    // DrawContents 在 BeginScrollView 之前调用。滚动区外(标题栏/状态栏)不算悬停,
    //   否则滚出视野的那些行在内容坐标里会被误判命中。
    internal static void Begin(Rect viewport)
    {
        var e = Event.current;
        _mouseWin = e.mousePosition;
        _inView = viewport.Contains(_mouseWin);
        _key = null;
        _cards.Clear();
    }

    internal static void Hover(string key, Rect r, string label = null)
    {
        if (key == null || !_inView) return;
        if (r.Contains(Event.current.mousePosition)) { _key = key; _label = label; }
    }

    internal static bool Toggle(string key, Rect r, bool value, string label)
        => Toggle(key, r, value, label, ToggleStyle ?? GUI.skin.toggle);   // skin.toggle 就是 ToggleStyle,省两次 IL2CPP 取值

    internal static bool Toggle(string key, Rect r, bool value, string label, GUIStyle style)
    {
        Hover(key, r, label);
        return GUI.Toggle(r, value, label, style);
    }

    internal static bool Button(string key, Rect r, string label, GUIStyle style = null)
    {
        Hover(key, r, label);
        return style == null ? GUI.Button(r, label) : GUI.Button(r, label, style);
    }

    internal static float Slider(string key, Rect r, float value, float min, float max)
    {
        Hover(key, new Rect(r.x, r.y - 8f * Scale, r.width, r.height + 16f * Scale));
        return SliderRaw(r, value, min, max);
    }

    internal static Texture2D LineTex, TrackTex, FillTex;
    internal static GUIStyle SliderStyle, ThumbStyle, ToggleStyle;

    // 细轨道 + 已填充段 + 圆形滑块。轨道自己画,IMGUI 的滑条样式只负责滑块和拖动。
    internal static float SliderRaw(Rect r, float value, float min, float max)
    {
        if (SliderStyle == null || ThumbStyle == null) return GUI.HorizontalSlider(r, value, min, max);
        if (Event.current.type == EventType.Repaint && TrackTex != null)
        {
            float th = Mathf.Max(2f, Mathf.Round(4f * Scale));
            float ty = r.y + (r.height - th) * 0.5f;
            GUI.DrawTexture(new Rect(r.x, ty, r.width, th), TrackTex);
            float tw = ThumbStyle.fixedWidth;
            float frac = max > min ? Mathf.Clamp01((value - min) / (max - min)) : 0f;
            if (FillTex != null) GUI.DrawTexture(new Rect(r.x, ty, frac * (r.width - tw) + tw * 0.5f, th), FillTex);
        }
        return GUI.HorizontalSlider(r, value, min, max, SliderStyle, ThumbStyle);
    }

    // DrawContents 在 EndScrollView 之后调用,画在窗口坐标里。
    internal static void EndAndDrawTip(float winW, float winH)
    {
        var e = Event.current;
        if (e.type != EventType.Repaint) return;

        if (_key != _hoverKey) { _hoverKey = _key; _hoverSince = Time.unscaledTime; }
        if (_hoverKey == null || Time.unscaledTime - _hoverSince < TIP_DELAY) return;
        if (TipStyle == null) return;

        if (_tipKey != _hoverKey)
        {
            _tipKey = _hoverKey;
            string text = Lookup(_hoverKey, _label);
            _tipContent = string.IsNullOrEmpty(text) ? null : new GUIContent(text);
            if (_tipContent != null)
            {
                float maxW = TIP_MAX_W * Scale;
                var size = TipStyle.CalcSize(_tipContent);
                // 宽度正好等于单行宽时 IMGUI 会把末尾的字挤到第二行(中文句号不许打头,会连前一个字一起挤),
                //   而高度只算了一行 → 最后几个字被裁掉。多给几像素。
                _tipW = Mathf.Min(Mathf.Ceil(size.x) + 6f * Scale, maxW);
                try { _tipH = TipStyle.CalcHeight(_tipContent, _tipW); }
                catch
                {
                    float padH = TipStyle.padding.horizontal, padV = TipStyle.padding.vertical;
                    // 按词换行每行末尾会空出一截,按 12% 损耗估行数,宁可多一行也别裁字
                    float lines = size.x < _tipW ? 1f
                        : Mathf.Ceil((size.x - padH) * 1.12f / Mathf.Max(1f, _tipW - padH));
                    _tipH = (size.y - padV) * lines * 1.15f + padV;
                }
            }
        }
        if (_tipContent == null) return;

        float x = _mouseWin.x + 16f * Scale, y = _mouseWin.y + 20f * Scale;
        if (x + _tipW > winW - 4f) x = Mathf.Max(4f, _mouseWin.x - _tipW - 8f * Scale);
        if (y + _tipH > winH - 4f) y = Mathf.Max(4f, _mouseWin.y - _tipH - 8f * Scale);
        GUI.Label(new Rect(x, y, _tipW, _tipH), _tipContent, TipStyle);
    }

    internal static void OnScaleChanged() => _tipKey = null;

    // ———————————— 卡片 ————————————
    // 每个分组画成一块面板:粗体标题 + 细分隔线。Menu.R 把每个矩形报给 Track,卡片关闭时记下内容底边;
    //   背景要先于内容画,所以用上一次记下的高度。关闭时机:同一横向范围开新卡片,或 EndCards。
    internal const float CARD_PAD = 10f, CARD_HEAD = 30f, CARD_ADV = 40f;
    internal const float DIM = 0.4f;
    private const float HEAD_TOG_W = 56f;
    internal static GUIStyle CardStyle, TitleStyle, BadgeStyle;
    internal static int CardScope;
    private static float _cardAlpha = 1f;

    private struct OpenCard { public float X, W, Top, Bottom; public int Scope; public string Title; }
    private static readonly List<OpenCard> _cards = new List<OpenCard>(4);
    private static readonly Dictionary<(int, string), float> _cardH = new Dictionary<(int, string), float>();

    internal static bool Tracking => _cards.Count > 0;

    private static Rect S(float x, float y, float w, float h) => new Rect(x * Scale, y * Scale, w * Scale, h * Scale);

    internal static float Card(float x, float y, float w, string title, string badge = null)
    {
        Head(x, y, w, title, badge, 0f);
        return y + CARD_ADV;
    }

    // 带总开关的卡片:开关在标题栏右侧,关着时卡片内容变暗(仍可调)
    internal static float Card(float x, float y, float w, string title, string key, ref bool on, ref bool changed, string badge = null)
    {
        Head(x, y, w, title, badge, HEAD_TOG_W + 6f);
        var r = S(x + w - CARD_PAD - HEAD_TOG_W, y + 4f, HEAD_TOG_W, CARD_HEAD - 8f);
        Hover(key, r);
        bool b = GUI.Toggle(r, on, I18n.T("启用", "On"), ToggleStyle ?? GUI.skin.toggle);
        if (b != on) { on = b; changed = true; }
        if (!on) { _cardAlpha = DIM; GUI.color = new Color(1f, 1f, 1f, DIM); }
        return y + CARD_ADV;
    }

    // 依赖某个开关的行:开关关着时变暗。Dim(false) 恢复到卡片自身的亮度。
    internal static void Dim(bool off) => GUI.color = new Color(1f, 1f, 1f, off ? DIM : _cardAlpha);

    private static void Head(float x, float y, float w, string title, string badge, float right)
    {
        CloseCards(x, w);
        _cardAlpha = 1f;
        GUI.color = Color.white;
        if (CardStyle != null && _cardH.TryGetValue((CardScope, title), out float h))
            GUI.Box(S(x, y, w, h), "", CardStyle);
        GUI.Label(S(x + CARD_PAD, y + 4f, w - 2f * CARD_PAD - right, CARD_HEAD - 8f), title, TitleStyle ?? GUI.skin.label);
        if (LineTex != null) GUI.DrawTexture(S(x + CARD_PAD, y + CARD_HEAD + 2f, w - 2f * CARD_PAD, 1f), LineTex);
        if (badge != null)
        {
            var br = S(x + w * 0.4f, y + 4f, w * 0.6f - CARD_PAD - right, CARD_HEAD - 8f);
            GUI.Label(br, badge, BadgeStyle ?? GUI.skin.label);
            Hover("Hotkey", br);
        }
        _cards.Add(new OpenCard { X = x, W = w, Top = y, Bottom = y + CARD_HEAD, Scope = CardScope, Title = title });
    }

    internal static void Track(float x, float y, float h)
    {
        for (int i = 0; i < _cards.Count; i++)
        {
            var c = _cards[i];
            if (x >= c.X && x < c.X + c.W && y + h > c.Bottom) { c.Bottom = y + h; _cards[i] = c; }
        }
    }

    // 几列底边差不到一行时拉齐;差一行以上就不拉,免得卡片底下撑出一截空框
    private const float ALIGN_MAX = 32f;

    private static void Align(ref OpenCard c, float bottom)
    {
        float gap = bottom - c.Bottom;
        if (gap > 0f && gap <= Mathf.Min(ALIGN_MAX, 0.5f * (c.Bottom - c.Top))) c.Bottom = bottom;
    }

    // 一块横跨几列的卡片会同时关掉上面几列的卡片,那是一排结束
    private static void CloseCards(float x, float w)
    {
        float bottom = 0f;
        int n = 0;
        for (int i = 0; i < _cards.Count; i++)
        {
            var c = _cards[i];
            if (x < c.X + c.W && c.X < x + w) { bottom = Mathf.Max(bottom, c.Bottom); n++; }
        }
        for (int i = _cards.Count - 1; i >= 0; i--)
        {
            var c = _cards[i];
            if (x < c.X + c.W && c.X < x + w)
            {
                if (n > 1) Align(ref c, bottom);
                Save(c);
                _cards.RemoveAt(i);
            }
        }
    }

    // 这时还开着的就是每列最后一块卡片
    internal static void EndCards()
    {
        float bottom = 0f;
        for (int i = 0; i < _cards.Count; i++) bottom = Mathf.Max(bottom, _cards[i].Bottom);
        for (int i = 0; i < _cards.Count; i++) { var c = _cards[i]; Align(ref c, bottom); Save(c); }
        _cards.Clear();
        _cardAlpha = 1f;
        GUI.color = Color.white;
    }

    private static void Save(OpenCard c) => _cardH[(c.Scope, c.Title)] = c.Bottom - c.Top + CARD_PAD;

    // ———————————— 说明文字 ————————————
    // 顺序:本文件的补充表 > Settings 的 [Description](中文)/ ModSettingsEnData(英文)。
    //   补充表只收菜单里标签太短、或原说明里有代码名的开关。
    private static Dictionary<string, string> _zh, _en;

    private static string Lookup(string key, string label)
    {
        if (_zh == null) BuildTables();
        bool en = I18n.IsEnglish;
        if (Extra.TryGetValue(key, out var pair)) return en ? pair[1] : pair[0];
        var d = en ? _en : _zh;
        if (d.TryGetValue(key, out var t)) return t;
        if (key.EndsWith("Decay") || key == "ClothingDecayRate")
            return en ? "Wear rate multiplier for this item type. 1.0 is vanilla. 0 stops wear. 2.0 is two times faster. General is multiplied with it."
                      : "这类物品的损耗速度倍率。1.0 为原版,0 为不损耗,2.0 为两倍快。会再乘上通用衰减。";
        return null;
    }

    private static void BuildTables()
    {
        _zh = new Dictionary<string, string>();
        _en = new Dictionary<string, string>();
        try
        {
            foreach (var f in typeof(TldHacksSettings).GetFields(BindingFlags.Public | BindingFlags.Instance))
            {
                var da = f.GetCustomAttribute<DescriptionAttribute>();
                if (da != null && !string.IsNullOrEmpty(da.Description)) _zh[f.Name] = da.Description;
            }
            var arr = ModSettingsEnData.Descriptions;
            for (int i = 0; i + 1 < arr.Length; i += 2)
                if (!string.IsNullOrEmpty(arr[i + 1])) _en[arr[i]] = arr[i + 1];
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[Menu] tooltip table: {ex.Message}"); }
    }

    private static readonly Dictionary<string, string[]> Extra = new()
    {
        ["Hotkey"] = new[] { "当前绑定的热键。在 ModSettings 里改键。", "The key that is set now. Change it in ModSettings." },
        ["SpeedTweaksEnabled"] = new[] { "关闭后蹲行、步行、冲刺都按原版速度。体力的三项不受这个开关影响。", "When off, crouch, walk and sprint use vanilla speed. The three stamina values do not use this switch." },
        ["SpeedMultiplier"] = new[] { "整个游戏按这个倍率运行,时间、动物和天气一起变快或变慢。1.0x 是原版。", "The whole game runs at this rate. Time, animals and weather all go faster or slower. 1.0x is vanilla." },
        ["Act_GrabNow"] = new[] { "马上把半径内的物品收进背包。开着(不捡丢物)时,自己丢在地上的东西不会被收走。", "Puts all items within the radius into your backpack now. When Skip Own Drops is on, items that you dropped stay on the ground." },
        ["Stack_AddComponent"] = new[] { "给咖啡、茶、胡萝卜、土豆等物品加上堆叠功能。具体物品在 ModSettings 里设置。", "Makes items such as coffee, tea, carrots and potatoes stack. Set the item list in ModSettings." },
        ["Act_HarvestCarcasses"] = new[] { "把当前地图上所有动物尸体的肉、皮、内脏全部收进背包,重量和状态按原版算。任务尸体不碰,不管超重。只管当前已加载的场景,采集时再点一次停。", "Puts the meat, hide and guts of all animal carcasses on this map into your backpack. Weight and condition follow the game rules. Mission carcasses are not touched. Weight is not checked. Only the loaded scene is used. Click again to stop." },
        ["Act_HarvestPlants"] = new[] { "把当前地图上所有能采的植物采完收进背包,和手动采集一样。只管当前已加载的场景,采集时再点一次停。", "Harvests all plants on this map into your backpack, the same as a manual harvest. Only the loaded scene is used. Click again to stop." },
        ["Act_ClearMap"] =new[] { "把当前地图上所有散落物品和容器里的东西全部收进背包,点两次才开始,收的时候再点一次停。只收当前已加载的场景,室内要进去再点。尸体、保险箱、上锁的容器都收,不管超重。你自己放进箱子或丢在地上的东西不收(进过你背包的都算),任务物品和任务容器也不收,任务物品用右边的按钮。", "Moves all loose items and container contents on this map to your backpack. Click twice to start. Click again to stop. Only the loaded scene is cleared, so go inside a building to clear it. Corpses, safes and locked containers are included. Weight is not checked. Items that you put in a container or drop are not taken. This includes all items that were in your backpack before. Mission items and mission containers are not taken. Use the button on the right for mission items." },
        ["Act_ClearMapMission"] = new[] { "慎用,可能产生 bug!把当前地图上的任务物品和任务容器里的东西收进背包,点两次才开始。你自己放进去的东西不收。容器不会标成已搜刮,之后还要自己打开一次,让任务照常推进。", "Use with care. This can cause bugs! Moves mission items and mission container contents on this map to your backpack. Items that you put in a container are not taken. Click twice to start. Containers stay unsearched, so open them once yourself to let the mission continue." },
        ["Act_TalesFinish"] = new[] { "生存模式专用,要装外域传说 DLC。把三个外域传说任务一次做完:六座发射塔全部修好通电,隐藏地堡和补给点全部显示出来,任务道具发进背包,任务门打开,徽章和专长照常解锁。地堡里的物资不发,留在原地自己去拿。点两次才开始,开始前自动备份当前存档,大约要一分钟,期间可以照常走动、切图。还没加载的地图要走进去才会显示出来。结束时任务状态会写进日志,搜 [Tales]。", "Survival only. Needs the Far Territory DLC. Finishes all three Tales at once. All six transmitters are repaired and switched on. All hidden bunkers and caches are uncovered. Tale items go into your backpack. Tale doors are unlocked. Badges and feats unlock as usual. Bunker loot stays where it is, so go and get it. Click twice to start. The current save is backed up first. Maps that are not loaded update when you go there." },
        ["Act_TalesRewards"] = new[] { "把三个外域传说任务路线上固定能拿到的装备发进背包,箱子里随机刷的不算。Tale 1:手持短波,Alpha 地堡的手电和睡袋,Gamma 地堡抽屉里的 6 发步枪子弹,Omega 地堡的优质冬季外套、面罩、3 支应急兴奋剂和烹饪书。Tale 2:选矿厂的呼吸面罩和 6 个滤罐、断线钳、2 个长效手电和木工工具,矿洞里的矿工裤、2 捆现金、金块和两盒子弹。Tale 3:Omega 隐藏房间的战术夹克、保安队长证件、鲁迪格的手表,工头避难所的三盒胶卷。另外按任务主题加送:战术手套、羽绒睡袋、矿工头盔夹克和靴子、探洞者煤油灯、工头工具腰带、相机、保温杯。背包里已经够数的不再发,不管超重。", "Puts the fixed gear from the three Tales into your backpack. Random container loot is not included. Tale 1: handheld shortwave, flashlight and bedroll from Bunker Alpha, 6 rifle rounds from Bunker Gamma, and the quality winter coat, balaclava, 3 emergency stims and cooking book from Bunker Omega. Tale 2: respirator with 6 canisters, bolt cutters, 2 long-lasting flashlights and woodworking tools from the concentrator, and miner's pants, 2 cash bundles, a gold nugget and two ammo boxes from the mine. Tale 3: tactical jacket, security chief ID and Rudiger's watch from the hidden room in Bunker Omega, and three film boxes from the foreman's refuge. Extra items that match the Tales are also added: tactical gloves, down bedroll, miner's helmet, jacket and boots, spelunker's lamp, foreman's tool belt, camera and insulated flask. Items that you already have enough of are skipped. Weight is not checked." },
        ["Act_ClearAfflictions"] = new[] { "立即治好身上所有伤病,如扭伤、失温、食物中毒、感染、流血、美洲狮撕裂伤、化学中毒、毒雾、窒息。之后几秒内会再清一次,防止其他 mod 又加回来。", "Cures all afflictions now, for example sprains, hypothermia, food poisoning, infection, bleeding, cougar lacerations, chemical poisoning, toxic fog and suffocation. It clears again for a few seconds, so other mods cannot add them back." },
        ["Act_RepairHeld"] = new[] { "手上拿着的物品恢复到 100% 状态。", "Sets the item in your hands to 100% condition." },
        ["Act_RepairBag"] = new[] { "背包里的所有物品恢复到 100% 状态,包括衣物和食物。", "Sets all items in your inventory to 100% condition. This includes clothing and food." },
        ["Act_RestoreAll"] = new[] { "背包和当前场景地上的所有物品恢复到 100% 状态。", "Sets all items in your inventory and on the ground in this scene to 100% condition." },
        ["Act_UnlockFeats"] = new[] { "所有勋章进度直接完成。勋章记录在游戏档案里,所有存档共用,解锁后不能撤回。", "Completes all feats now. Feats are saved in your game profile and all saves share them. You cannot undo this." },
        ["GodMode"] = new[] { "生命值不会下降,不会死亡,也不会得上伤病。", "Health does not decrease. You cannot die or get afflictions." },
        ["NoFallDamage"] = new[] { "从高处落下不受伤。", "Falls cause no damage." },
        ["ImmuneAnimalDamage"] = new[] { "狼、熊、美洲狮的攻击不造成伤害,也不会被美洲狮扑出撕裂伤。", "Wolf, bear and cougar attacks cause no damage. Cougar attacks cause no lacerations." },
        ["ClearDeathPenalty"] = new[] { "自动治愈死里逃生后留下的虚弱状态。", "Cures the Cheated Death affliction automatically." },
        ["NoFrostbiteRisk"] = new[] { "不会得冻伤。", "You do not get frostbite." },
        ["WellFedBuff"] = new[] { "一直保持吃饱的加成。", "Keeps the Well Fed bonus active." },
        ["FreezingBuff"] = new[] { "一直保持喝热饮后的暖身加成。", "Keeps the warm-up bonus from hot drinks active." },
        ["FatigueBuff"] = new[] { "一直保持喝咖啡后的提神加成。", "Keeps the energy bonus from coffee active." },
        ["StackingEnabled"] = new[] { "背包里相同的物品合成一格显示,右下角显示数量。", "Shows identical items in one inventory cell with a count." },
        ["InfiniteDurability"] = new[] { "物品和衣物不掉耐久。", "Items and clothing do not lose condition." },
        ["NoWetClothes"] = new[] { "衣物不会变湿。", "Clothing does not get wet." },
        ["LampFuelNoDrain"] = new[] { "油灯不消耗燃油。", "The lantern uses no fuel." },
        ["Train_NoBreak"] = new[] { "火车各部件不掉状态,已经坏了的直接修满,锅炉不会爆炸。", "Train parts do not lose condition. Damaged parts are repaired to full. The boiler does not explode." },
        ["Train_KeepHighGear"] = new[] { "锅炉点着时蒸汽压力一直满,二档一直能用,不会掉速。刹车和下车仍然会回空挡。", "Steam pressure stays full while the boiler is lit, so second gear always works at full speed. The brake and leaving the train still set neutral." },
        ["Train_FullFuel"] = new[] { "火车的鲸油和水一直是满的。", "The train whale oil and water tanks stay full." },
        ["Heater_NoFuel"] = new[] { "鲸油取暖器点着时油量不减。离线补时间也不扣油。", "The whale oil heater does not use oil when it is on. It also does not use oil for the time that passes while you are away." },
        ["Heater_FuelMult"] = new[] { "鲸油取暖器耗油的倍数。原版三档每小时 0.25、0.5、0.75 升,1 是原版,0.5 就是烧一半的油。开了不耗油时这项不起作用。", "Multiplies the oil that the whale oil heater uses. The three vanilla settings use 0.25, 0.5 and 0.75 L per hour. 1 is vanilla. This has no effect when Heater Uses No Oil is on." },
        ["OilCan_WhaleMaxL"] = new[] { "一个鲸油罐最多装多少升。0 是原版 5 升。往罐里倒油和合并都按这个上限,已经超过上限的罐子不会被减少。", "The maximum litres in one whale oil can. 0 is the vanilla 5 L. Filling and merging use this limit. A can that already holds more keeps its oil." },
        ["OilCan_KeroseneMaxL"] = new[] { "一个装煤油的油桶最多装多少升,原版生锈油桶和其他 mod 加的煤油壶都算。0 是原版(生锈油桶 4 升)。往桶里倒油和合并都按这个上限,已经超过上限的桶不会被减少。", "The maximum litres in one kerosene jerrycan. This includes the vanilla rusty jerrycan and kerosene cans from other mods. 0 is vanilla (4 L for the rusty jerrycan). Filling and merging use this limit. A can that already holds more keeps its oil." },
        ["OilCan_MergeWhale"] = new[] { "把背包里所有鲸油罐的油集中倒进尽量少的罐子,每罐倒到上限为止,倒空的罐子消失。", "Pours the oil from all whale oil cans in the backpack into as few cans as possible. Each can fills up to the limit. Empty cans are removed." },
        ["OilCan_MergeKerosene"] = new[] { "把背包里所有油桶的煤油集中倒进尽量少的桶,每桶倒到上限为止,倒空的桶照原版规则消失。", "Pours the kerosene from all kerosene jerrycans in the backpack into as few cans as possible. Each can fills up to the limit. Empty cans are removed, as in the base game." },
        ["Heater_TempBonus"] = new[] { "鲸油取暖器每一档额外加的温度。原版三档是 10、20、30 度,0 是原版。拖动后正在烧的取暖器马上生效。", "Adds this many degrees to each heater setting. The three vanilla settings give 10, 20 and 30 °C. 0 is vanilla. A heater that is on changes immediately." },
        ["FlaskNoHeatLoss"] = new[] { "保温瓶里的饮品不会变凉。", "Drinks in the flask do not cool down." },
        ["FlaskInfiniteVol"] = new[] { "保温瓶没有容量上限。", "The flask has no capacity limit." },
        ["FlaskAnyItem"] = new[] { "保温瓶可以装所有饮品。", "The flask accepts all drinks." },
        ["BlockAutoPickupOwnDrops"] = new[] { "自己丢在地上或右键放下的东西不会被自动捡回,一键搜刮也会跳过它们。", "Items that you drop or place are not picked up again automatically. Grab All also skips them." },
        ["InstantKillAnimals"] = new[] { "一次攻击就能杀死动物。", "One hit kills an animal." },
        ["FreezeAnimals"] = new[] { "动物停在原地不动。", "Animals stop moving." },
        ["Stealth"] = new[] { "动物看到你就逃跑。", "Animals run away from you." },
        ["ThinIceNoBreak"] = new[] { "薄冰不会破裂。", "Thin ice does not break." },
        ["FireTemp300"] = new[] { "篝火温度固定为 300℃。", "Fires stay at 300 °C." },
        ["FireNeverDie"] = new[] { "篝火不会熄灭。", "Fires do not burn out." },
        ["QuickFire"] = new[] { "生火一定成功。", "Fire starting always succeeds." },
        ["QuickFishing"] = new[] { "钓鱼一定能钓到。", "Fishing always succeeds." },
        ["QuickCook"] = new[] { "烹饪立即完成,也不会烤焦。", "Cooking completes at once and food does not burn." },
        ["DropCook"] = new[] { "生肉生鱼丢在点着的火堆或炉子旁边 2 米内,按原版烹饪时间等够了就自己变成热的熟肉,不会烤焦。捡起来或火灭了就重新计时。", "Drop raw meat or fish within 2 m of a burning fire or stove. It becomes hot cooked food after the normal cooking time and does not burn. The timer restarts if you pick it up or the fire goes out." },
        ["NoBurn"] = new[] { "食物熟了以后不会烤焦,烹饪时间不变。", "Cooked food does not burn. Cooking time does not change." },
        ["QuickSearch"] = new[] { "搜刮容器和尸体不用等待。", "Searching containers and bodies has no wait." },
        ["QuickHarvest"] = new[] { "在猎物尸体上割肉、剥皮立即完成。", "Harvesting a carcass completes at once." },
        ["QuickBreakDown"] = new[] { "拆解物品立即完成。", "Breaking down items completes at once." },
        ["QuickEvolve"] = new[] { "风干、腌制等需要等待的加工立即完成。", "Curing and drying complete at once." },
        ["QuickClimb"] = new[] { "爬绳速度变为 5 倍。", "Rope climbing is 5 times faster." },
        ["QuickAction"] = new[] { "采集尸体、修理、拆解时直接完成,不用按住按钮。修理必定成功。", "Harvesting, repairs and breaking down finish at once. You do not have to hold the button. Repairs always succeed." },
        ["FreeCraft"] = new[] { "制作不消耗材料。", "Crafting uses no materials." },
        ["QuickCraft"] = new[] { "制作几乎立即完成。", "Crafting completes almost at once." },
        ["FreeRepair"] = new[] { "修理不需要材料,也不损耗工具。", "Repairs need no materials and do not wear the tool." },
        ["IgnoreLock"] = new[] { "上锁的门和容器可以直接打开。", "Locked doors and containers open directly." },
        ["QuickOpenContainer"] = new[] { "打开容器不用等待。", "Containers open with no wait." },
        ["UnlockSafes"] = new[] { "保险箱、上锁的门和柜子直接解锁。", "Safes, locked doors and lockers unlock directly." },
        ["InfiniteContainer"] = new[] { "容器没有容量上限,打开容器时生效。关掉后,已经打开过的容器要重新进入场景才恢复原来的容量。", "Containers have no capacity limit. This applies when you open a container. After you turn it off, containers that you opened stay unlimited until you enter the scene again." },
        ["InfiniteAmmo"] = new[] { "开枪不消耗弹药。", "Shots use no ammunition." },
        ["NoJam"] = new[] { "枪不会卡壳。", "Guns do not jam." },
        ["NoRecoil"] = new[] { "开枪没有后坐力。", "Guns have no recoil." },
        ["SuperAccuracy"] = new[] { "子弹散布归零并关闭瞄准晃动,子弹沿准星射出。后坐力另由无后坐力控制。", "Bullets have no spread and aim sway is off, so every shot leaves along the crosshair. Recoil is set by No Recoil." },
        ["NoAimStamina"] = new[] { "瞄准时不消耗体力。", "Aiming uses no stamina." },
        ["QoL_SleepAnywhere"] = new[] { "没有睡袋和床也能睡觉,恢复效果按下面的倍率打折。", "You can sleep without a bedroll or bed. The values below reduce the recovery." },
        ["QoL_SleepInterrupt"] = new[] { "睡觉时生命值低于阈值会自动醒来。", "You wake up when health drops below the threshold during sleep." },
        ["QoL_AutoSurveyUnlock"] = new[] { "恶劣天气下也能自动绘图。", "Auto mapping also works in bad weather." },
        ["World_SprainkleAnkleEnabled"] = new[] { "关闭后脚踝扭伤会立即痊愈。", "When off, ankle sprains heal at once." },
        ["World_SprainkleWristEnabled"] = new[] { "关闭后手腕扭伤会立即痊愈。", "When off, wrist sprains heal at once." },
        ["SpaceFinish_BreakDown"] = new[] { "拆解时按空格立即完成。", "Press Space to finish a break down at once." },
        ["SpaceFinish_Harvest"] = new[] { "采集尸体时按空格立即完成。", "Press Space to finish harvesting at once." },
        ["SpaceFinish_Craft"] = new[] { "制作时按空格立即完成。", "Press Space to finish crafting at once." },
        ["SpaceFinish_Repair"] = new[] { "修理时按空格立即完成。", "Press Space to finish a repair at once." },
        ["TraderUnlimitedList"] = new[] { "一次交易最多能选的商品数提高到 64 样。", "You can select up to 64 exchanges in one trade." },
        ["TraderMaxTrust"] = new[] { "商人信任值直接加满。对应的商品和对话照原版解锁。开着时信任条拖不动。", "Sets the trader trust to the maximum. The trades and conversations for that trust unlock as in the base game. You cannot move the trust slider while this is on." },
        ["TraderUnlockModeItems"] = new[] { "原版商人按难度过滤商品,入侵者和悲惨模式里斧子、步枪、精工箭这类物品永远不进清单,信任满了也一样。打开后不再按难度过滤,玩家已经有同款就不卖这条照原版。换到的物品扔在地上不会消失。开关后要等下次极光,或者点刷新商品,清单才会变。", "In the base game, the trader filters items by difficulty. On Interloper and Misery, items such as hatchets, rifles and manufactured arrows never appear, even at full trust. When this is on, the trader does not filter by difficulty. The trader still does not offer an item that you already have. Items that you get do not disappear when you drop them. The list changes after the next aurora or after you click Refresh Goods." },
        ["TraderInstantExchange"] = new[] { "商人要的东西不用交,关上交换箱就直接完成交易,不用再联系商人,也不用等商人回来。", "The items that the trader asks for count as delivered. The trade completes when you close the exchange box. You do not have to call the trader again or wait for the trader to come back." },
        ["TraderAlwaysAvailable"] = new[] { "随时都能用无线电联系商人,交易完成后也不用等商人回来。联系太频繁照样扣信任,这条照原版。", "You can call the trader on the radio at any time. You do not have to wait for the trader to come back after a trade. Too many calls still remove trust, as in the base game." },
        ["CougarInstantActivate"] = new[] { "新存档一开始就激活美洲狮。", "Activates the cougar at the start of a new save." },
        ["TT_ShowTraderTrust"] = new[] { "使用商人无线电时在屏幕底部显示信任值。", "Shows the trader trust at the bottom of the screen when you use the trader radio." },
        ["QoL_MapTextOutlineEnabled"] = new[] { "按下面选的样式修改地图文字的颜色和描边。", "Changes the color and outline of map text to the style below." },
        ["QoL_NoSaveOnSprain"] = new[] { "扭伤时游戏不自动存档。", "The game does not autosave when you get a sprain." },
        ["QoL_WakeUpCall"] = new[] { "睡觉时可以在暂停菜单里选择醒来。", "You can wake up from the pause menu while you sleep." },
        ["QoL_AuroraSense"] = new[] { "睡觉时极光出现会叫醒你。", "Wakes you up when an aurora starts while you sleep." },
        ["QoL_ShowTimeSleep"] = new[] { "睡觉和消磨时间时显示当前时间。", "Shows the current time while you sleep or pass time." },
        ["QoL_NoPitchBlack"] = new[] { "睡觉时屏幕不会全黑。", "The screen does not go fully black while you sleep." },
        ["TT_PauseOnRadial"] = new[] { "打开轮盘菜单时游戏时间变慢。", "Slows game time while the radial menu is open." },
        ["TT_DroppedOrientation"] = new[] { "丢在地上的步枪竖着放。", "Dropped rifles stand upright." },
        ["TT_FallDeathGoat"] = new[] { "有些悬崖设有碰到即死的区域。开启后不会立即死亡,改按下落高度计算伤害。坠落伤害/米只在开启时生效。", "Some cliffs have instant death areas. When on, you take fall damage by height and do not die at once. Fall Dmg/m applies only when this is on." },
        ["TT_CapFeelsEnabled"] = new[] { "室外体感温度限制在下面设定的范围内。", "Keeps the outdoor feels-like temperature in the range below." },
        ["TT_RespawnPlants"] = new[] { "采过的植物按下面的天数重新长出。", "Harvested plants grow back after the number of days below." },
        ["TT_ExtendedFOV"] = new[] { "游戏设置里的视野滑块范围扩展到 30-150。", "Extends the FOV slider in the game settings to 30-150." },
        ["UT_RockCacheIndoors"] = new[] { "岩石贮藏处可以放在室内。", "You can place rock caches indoors." },
        ["UT_GlowingDecals"] = new[] { "喷漆标记在黑暗中发光。", "Spray paint marks glow in the dark." },
        ["UT_TravoisOverrideMovement"] = new[] { "雪橇可以拖进平时不让进的区域。", "You can pull the travois into areas that usually block it." },
        ["UT_TravoisOverrideInteraction"] = new[] { "拖着雪橇时也能和物体互动。", "You can interact with objects while you pull the travois." },
        ["Spawner_Splitter"] = new[] { "按住上下拖,调整快速传送和物品生成器各占多高。传送列表里用滚轮翻。", "Hold and drag up or down to change the height of Quick Teleport and Item Spawner. Use the mouse wheel to scroll the teleport list." },
        ["UT_ToiletWaterPotable"] = new[] { "马桶里的水可以直接喝,不用烧开。", "Toilet water is safe to drink. You do not have to boil it." },
        ["UT_ConsistantDressingWeight"] = new[] { "老人须地衣绷带的重量统一为 0.03 kg。", "Sets the weight of Old Man's Beard dressings to 0.03 kg." },
        ["UT_RemoveHeadacheDebuff"] = new[] { "桃子派、玫瑰果派、水果粥、桃子煎饼吃完不再头疼。", "Peach pie, rose hip pie, fruit porridge and peach pancakes no longer cause a headache." },
        ["UT_RandomizedItemRotation"] = new[] { "丢下的物品朝向随机。", "Dropped items get a random direction." },
        ["WeatherLock"] = new[] { "保持当前天气不变。点左边的天气按钮会自动开启。关闭后天气恢复正常变化,重启游戏也会关闭。", "Keeps the current weather. A weather button on the left turns this on. When off, the weather changes normally. It also turns off when you restart the game." },
        ["World_BowRepair"] = new[] { "弓可以修理。修理方式和材料在下面的弓参数里选。进入新场景后生效。", "You can repair bows. Select the method and material in Bow Params below. This applies after you enter a new scene." },
        ["World_BowRepairDLC"] = new[] { "运动弓、木弓、灌木弓也可以修理。", "You can also repair the Sport, Woodwright and Bushcraft bows." },
        ["BowMode"] = new[] { "手修用背包里的材料直接修,铣床要到铣床旁修,都可就是两种都行。", "By Hand repairs the bow from the inventory. Mill needs a milling machine. Both allows the two methods." },
        ["BowModeDLC"] = new[] { "手修用背包里的材料直接修,铣床要到铣床旁修,都可就是两种都行。要先开启 DLC弓启用。", "By Hand repairs the bow from the inventory. Mill needs a milling machine. Both allows the two methods. Turn on DLC Bows first." },
        ["BowMat"] = new[] { "修一次用掉的材料数量。", "Sets the quantity of material that one repair uses." },
        ["World_CaffeinatedSodas"] = new[] { "喝汽水会像喝咖啡一样减少疲劳。进入新场景后生效。", "Sodas reduce fatigue like coffee. This applies after you enter a new scene." },
        ["SodaOn"] = new[] { "这种汽水是否减少疲劳。", "Sets whether this soda reduces fatigue." },
        ["SodaPct"] = new[] { "喝下后立即减少的疲劳百分比。", "The fatigue percentage that one soda removes at once." },
        ["SodaDur"] = new[] { "提神效果持续的分钟数(游戏内时间)。", "The duration of the effect in game minutes." },
        // 物品刷出页按 prefab 名取说明
        ["GEAR_TechnicalBackpack"] = new[] { "原版高科技背包。穿上后提高负重上限。", "The vanilla Technical Backpack. Wear it to carry more weight." },
        ["GEAR_SatchelM"] = new[] { "CampingTools 模组的巡游者背包,装在配饰栏。穿上后负重上限加 30 kg。", "Satchel from the CampingTools mod. It goes in the accessory slot. Wear it to carry 30 kg more." },
        ["Feat_Enable"] = new[] { "勾上就是当前存档启用这个勋章,立即生效,随存档保存。没解锁的会先解锁。", "Select to use this feat in the current save. It applies at once and stays in the save. A locked feat is unlocked first." },
        ["Feat_EnableAll"] = new[] { "当前存档启用全部 13 个勋章。", "Use all 13 feats in the current save." },
        ["Feat_DisableAll"] = new[] { "当前存档取消全部勋章,解锁进度不受影响。", "Remove all feats from the current save. Unlock progress does not change." },
        ["Feat_Bonus"] = new[] { "勋章启用后的加成数值。拖动后立即生效,所有存档通用。", "Sets the bonus that the feat gives when it is in use. It applies at once to all saves." },
        ["Feat_BonusReset"] = new[] { "所有加成数值改回原版。", "Sets all bonus values back to vanilla." },
        ["DeerMeatMultMin"] = new[] { "新打的鹿在下限和上限之间随机取一个出肉倍率。原版鹿出肉 6-9 kg,真实鹿约 18-25 kg。熊、驼鹿等不受影响。", "Each new deer gets a random meat multiplier between Min and Max. A vanilla deer gives 6-9 kg. A real deer gives about 18-25 kg. Bear, moose and other animals do not change." },
        ["DeerMeatMultMax"] = new[] { "新打的鹿在下限和上限之间随机取一个出肉倍率。已有的鹿尸体不变。", "Each new deer gets a random meat multiplier between Min and Max. Carcasses that exist now do not change." },
        ["AlwaysWarm"] = new[] { "体温一直保持满值,不会失温。", "Your body temperature stays full. You do not freeze." },
        ["NoHunger"] = new[] { "饱食度不会下降。", "You do not get hungry." },
        ["NoThirst"] = new[] { "不会口渴。", "You do not get thirsty." },
        ["NoFatigue"] = new[] { "不会疲劳。", "You do not get tired." },
        ["NoSprainRisk"] = new[] { "不会扭伤脚踝和手腕。", "You do not sprain an ankle or wrist." },
        ["NoSuffocating"] = new[] { "不会窒息。", "You do not suffocate." },
        ["GeneralDecay"] = new[] { "所有物品损耗速度的总倍率,和各类别倍率相乘。1.0 为原版,0 为不损耗。", "Total wear rate for all items. It is multiplied with each item type rate. 1.0 is vanilla. 0 stops wear." },
        ["DecayBeforePickup"] = new[] { "还没捡起的物品在世界里的损耗倍率。", "Wear rate of items that you did not pick up yet." },
        ["OnUseDecay"] = new[] { "使用枪、弓、工具、磨刀石等物品时的损耗倍率。", "Wear rate when you use guns, bows, tools, whetstones and similar items." },
        ["Craft_MoreCookingSlots"] = new[] { "壁炉、油桶火和烤架上可以同时放更多锅。下面三项分别控制这三种火。", "Fireplaces, fire barrels and grills get more cooking slots. The three options below control each type." },
        ["Craft_MoreSlots_Fireplace"] = new[] { "壁炉烹饪位 2 个变 3 个。要先开启额外烹饪位。", "Fireplace cooking slots go from 2 to 3. Turn on More Slots first." },
        ["Craft_MoreSlots_Barrel"] = new[] { "油桶火烹饪位 2 个变 4 个。要先开启额外烹饪位。", "Fire barrel cooking slots go from 2 to 4. Turn on More Slots first." },
        ["Craft_MoreSlots_Grill"] = new[] { "烤架烹饪位 2 个变 4 个。要先开启额外烹饪位。", "Grill cooking slots go from 2 to 4. Turn on More Slots first." },
        ["CrosshairAlpha"] = new[] { "准星的不透明度。0 为完全透明,1 为不透明。", "Crosshair opacity. 0 is fully clear. 1 is solid." },
        ["CrosshairStone"] = new[] { "拿石头准备投掷时显示准星。", "Shows the crosshair when you aim a stone." },
        ["CrosshairRifle"] = new[] { "步枪瞄准时显示准星。", "Shows the crosshair when you aim a rifle." },
        ["CrosshairBow"] = new[] { "弓瞄准时显示准星。", "Shows the crosshair when you aim a bow." },
        ["CrosshairAlways"] = new[] { "不瞄准也一直显示准星。", "Shows the crosshair at all times, also when you do not aim." },
        ["WalkSpeed"] = new[] { "步行速度倍率。1.0 为原版。", "Walk speed multiplier. 1.0 is vanilla." },
        ["SprintSpeed"] = new[] { "冲刺速度倍率。1.0 为原版。", "Sprint speed multiplier. 1.0 is vanilla." },
        ["CrouchSpeed"] = new[] { "蹲行速度倍率。1.0 为原版。", "Crouch speed multiplier. 1.0 is vanilla." },
        ["StaminaDrain"] = new[] { "冲刺时体力消耗速度。1.0 为原版,越小越省体力。", "Stamina use when you sprint. 1.0 is vanilla. A lower value uses less stamina." },
        ["StaminaRecharge"] = new[] { "体力恢复速度。1.0 为原版,越大恢复越快。", "Stamina recovery rate. 1.0 is vanilla. A higher value recovers faster." },
        ["TimeScale1"] = new[] { "按第一个时间加速热键后的游戏速度倍数。", "Game speed when you press the first time speed-up hotkey." },
        ["TimeScale2"] = new[] { "按第二个时间加速热键后的游戏速度倍数。", "Game speed when you press the second time speed-up hotkey." },
        ["TT_EatingSpeedMult"] = new[] { "吃喝和砸开罐头的速度倍率。1.0 为原版,2.0 为两倍快。", "Speed of eating, drinking and smashing cans open. 1.0 is vanilla. 2.0 is two times faster." },
        ["TT_BreakdownSpeedMult"] = new[] { "拆解动作的速度倍率。1.0 为原版,2.0 为两倍快。", "Speed of breaking down items. 1.0 is vanilla. 2.0 is two times faster." },
        ["TT_ReadingSpeedMult"] = new[] { "阅读研究的速度倍率。1.0 为原版,2.0 为两倍快。", "Speed of reading research books. 1.0 is vanilla. 2.0 is two times faster." },
        ["TT_PlantRespawnDays"] = new[] { "采过的植物过多少天重新长出。", "The number of days before a harvested plant grows back." },
        ["TorchMinCondition"] = new[] { "从火堆里取出的火把最低品质。", "Lowest condition of a torch that you take from a fire." },
        ["TorchMaxCondition"] = new[] { "从火堆里取出的火把最高品质。", "Highest condition of a torch that you take from a fire." },
        ["VehicleFreeLookYaw"] = new[] { "车内自由视角能向左右转动的最大角度。", "Largest left and right angle for free look in a vehicle." },
        ["VehicleFreeLookPitch"] = new[] { "车内自由视角能向上下转动的最大角度。", "Largest up and down angle for free look in a vehicle." },
        ["QoL_AutoSurvey"] = new[] { "每隔一段时间自动把周围画到地图上,不用炭笔。天气差时要开无视天气限制。", "Draws the area around you on the map at intervals. You do not need charcoal. In bad weather, turn on Ignore Weather." },
        ["QoL_AutoSurveyDelay"] = new[] { "两次自动绘图的间隔,越小越频繁。", "Interval between two automatic map updates. A lower value updates more often." },
        ["QoL_AutoSurveyRange"] = new[] { "自动绘图的范围倍率,1.0 约为 20 米。", "Range multiplier for automatic mapping. 1.0 is about 20 m." },
        ["MapM_Enabled"] = new[] { "地图管理总开关。管下面的箭头、绘图范围、地堡这些设置。Mods 里还留着独立的 MapManager.dll 时这里不生效,要先删掉它。", "Turns the map settings below on or off. If MapManager.dll is still in the Mods folder, these settings do not work. Remove that file first." },
        ["MapM_PlayerArrow"] = new[] { "打开地图时用红色箭头标出你的位置。", "Shows your position on the map as a red arrow." },
        ["MapM_CenterOnPlayer"] = new[] { "打开地图时自动移到你所在的位置。", "Moves the map to your position when you open it." },
        ["MapM_SurveyRange"] = new[] { "所有开图的范围倍率,1.0 为原版。木炭绘图、自动绘图、宝丽来和地堡热键都按这个放大。", "Multiplies the area of all map reveals. 1.0 is the original value. Charcoal, auto survey, polaroids and the bunker key all use it." },
        ["MapM_SurveyTime"] = new[] { "用木炭绘图花掉的游戏时间倍率,1.0 为原版,越小越快。改完换个场景才对新木炭生效。", "Multiplies the game time that charcoal mapping takes. 1.0 is the original value. A lower value is faster. The change applies after you change scene." },
        ["MapM_UnlockSurvey"] = new[] { "晚上、下雪、起雾的时候也能用木炭绘图。", "Lets you map with charcoal at night and in bad weather." },
        ["MapM_RevealVista"] = new[] { "绘图时把范围内的远景点也标到地图上。", "Marks vista points in the mapped area on the map." },
        ["MapM_VistaNoPolaroid"] = new[] { "到了远景点没有对应的宝丽来照片时,自动放一张进背包和收藏,绘图效果和带着照片一样。", "At a vista point, you get its polaroid if you do not have it. The polaroid goes into your backpack and your collection." },
        ["MapM_CorpseOnMap"] = new[] { "你打死的动物(包括流血而死的)会显示在地图上。", "Animals that you kill show on the map. This includes animals that bleed out." },
        ["MapM_HideHarvested"] = new[] { "一片植物采完以后,地图上对应的图标自动消失。", "Removes the map icon of a plant group after you harvest all of it." },
        ["CE_SnareSure"] = new[] { "陷阱每次判定都抓到兔子,也不会坏。", "Each snare check catches a rabbit. The snare does not break." },
        ["CE_SnareInstant"] = new[] { "陷阱放下后马上判定一次,不用等几个小时。没抓到就照原版的间隔再等。要先开陷阱必中。", "The snare checks once right after you set it. If it catches nothing, it waits the normal time. Turn on Sure Snares first." },
        ["CE_LootNoEmpty"] = new[] { "容器生成东西时不会是空的,至少一件。只对还没打开过的容器有效。", "Containers always get at least one item. This works only on containers that you have not opened." },
        ["CE_LootLowerTier"] = new[] { "容器里的东西按低一档难度的表生成,比如入侵者按潜行者,厄难按入侵者。只对还没打开过的容器有效。", "Containers get loot from the next easier level. For example, Interloper uses Stalker loot. This works only on containers that you have not opened." },
        ["CE_AuroraRefill"] = new[] { "极光夜关上一个搜空的容器,它会重新生成一次东西。每次极光每个容器只刷一次,尸体和任务容器不刷。", "During an aurora, an empty container gets new loot when you close it. Each container refills one time for each aurora. Bodies and mission containers do not refill." },
        ["CE_IceHoleNoFreeze"] = new[] { "钓鱼的冰洞不会重新结冰,已经冻上的打开就解冻。", "Fishing holes do not freeze again. A frozen hole opens when you use it." },
        ["CE_NoMisery"] = new[] { "厄难难度的体质衰弱、心神不宁、风湿关节、冰冷刺骨、胃酸过多、残破身躯不再挂上。已经有的用清除所有负面清掉。", "Misery afflictions do not start. To remove the ones you have, use Clear All Afflictions." },
        ["CE_NoDeath"] = new[] { "血量快归零时救回来。血量回到三成,清掉负面,饿、渴、冷补到不再掉血,存档不删。", "When your condition is about to reach zero, you survive. Condition goes back to 30%. Afflictions clear. Hunger, thirst and cold go to a safe level. The save is kept." },
        ["CE_StruggleWin"] = new[] { "被狼或美洲狮扑倒时挣脱进度一直是满的,马上脱身。扑倒期间不掉血,熊和驼鹿的攻击也不留后续负面。", "When a wolf or cougar attacks, the struggle bar stays full and you get free at once. You take no damage during a struggle. Bear and moose attacks leave no afflictions." },
        ["CE_NoStun"] = new[] { "被扑倒以后不躺地、不头晕、不掉东西。", "After a struggle, you do not lie on the ground, get dazed or drop items." },
        ["CE_NoSlide"] = new[] { "陡坡也能直接走上去,不往下滑,坡上不减速。", "You can walk up steep slopes. You do not slide down or slow down on slopes." },
        ["CE_TraderCheap"] = new[] { "交易一直用便宜价的清单,原版要信任很高才有。", "The trader always uses the low prices. Normally you need high trust for them." },
        ["CE_AuroraLightSteady"] = new[] { "极光夜通电的灯稳定全亮,不忽明忽暗。", "During an aurora, powered lights stay fully on and do not flicker." },
        ["CE_AuroraMute"] = new[] { "极光夜那阵嗡嗡的环境声不再播放。", "The aurora hum does not play." },
        ["CE_TraderRefresh"] = new[] { "重新抽一遍商人这次能换的东西。要先联系过商人。", "Roll the trader goods again. You must contact the trader first." },
        ["MapM_FillEmptyBunkers"] = new[] { "每个地堡都换成完整版,A 到 F 六种布局随机,先各出一个再重复。哪个难度、新档旧档都管用,下次进区域生效。同一个存档每次读档结果一样。关掉后重启游戏恢复原版。", "Each bunker becomes a full bunker of a random type, A to F. Each type comes once before a type repeats. This works on all difficulties, new saves and old saves. The change starts when you next enter the region. The result stays the same each time you load the save. To get the original bunkers back, turn this off and restart the game." },
        ["MapM_InterloperBunker"] = new[] { "游戏 2.60 起九个区域各有一个固定地堡入口,任何难度都在,这个开关已经没有作用。入侵者和厄难的地堡进去基本是空的,要物资请开完整地堡。", "Since game 2.60, each of the nine regions has one fixed bunker entrance on all difficulties. This switch does nothing now. On Interloper and Misery the bunkers are almost empty inside. To get supplies, turn on Full Bunkers." },
        ["Coll_Enabled"] = new[] { "打开地图时标出当前区域的石堆、纸条和拍立得,左上角显示还剩几个没收。室内的标在进门的位置(空心图标)。带问号的是随机刷新的几个可能位置,到了那个区域会自动只留真刷出来的那个。", "Marks the cairns, notes and polaroids of the shown region on the map. The top left shows how many you did not find yet. Items inside buildings show at the door with a hollow icon. A question mark shows a possible random spawn point. In that region, only the real spawn point stays on the map." },
        ["Coll_Cairn"] = new[] { "标出石堆(三角)。", "Marks cairns with a triangle." },
        ["Coll_Note"] = new[] { "标出纸条和日志(方块)。", "Marks notes and logs with a square." },
        ["Coll_Polaroid"] = new[] { "标出拍立得照片(圆点),也就是游戏里的宝丽来。", "Marks polaroids with a circle." },
        ["Coll_ShowCollected"] = new[] { "收过的也标出来,颜色变暗。默认只标没收过的。", "Also marks the items that you collected, in a dark color. By default, only the items that you did not collect show." },
        ["QoL_MapTextOutline"] = new[] { "地图上地名文字的颜色和描边。点一下换下一种,打开的地图马上跟着变。要先打开地图描边。", "Sets the color and outline of the place names on the map. Click to go to the next style. The open map changes at once. Turn on Map Outline first." },
        ["QoL_SleepFatigueRecovery"] = new[] { "随地睡觉时疲劳恢复速度。1.0 为原版床铺的速度。", "Fatigue recovery when you sleep without a bed. 1.0 is the same as a bed." },
        ["QoL_SleepConditionRecovery"] = new[] { "随地睡觉时生命值恢复速度。1.0 为原版床铺的速度。", "Health recovery when you sleep without a bed. 1.0 is the same as a bed." },
        ["QoL_SleepFreezingScale"] = new[] { "随地睡觉时失温的速度倍率。0 为睡觉时不会失温。", "Freezing rate when you sleep without a bed. 0 stops freezing during sleep." },
        ["QoL_SleepInterruptThreshold"] = new[] { "生命值低于这个比例时自动醒来。", "You wake up when health drops below this fraction." },
        ["World_SprainkleSlopeMin"] = new[] { "坡度大于这个角度才可能扭伤。", "A sprain can occur only on slopes steeper than this angle." },
        ["World_SprainkleBaseChanceMoving"] = new[] { "在陡坡上移动时的基础扭伤概率。", "Base sprain chance when you move on a steep slope." },
        ["World_SprainkleEncumberChance"] = new[] { "超重时额外增加的扭伤概率。", "Added sprain chance when you are over the weight limit." },
        ["World_SprainkleExhaustionChance"] = new[] { "疲劳时额外增加的扭伤概率。", "Added sprain chance when you are tired." },
        ["World_SprainkleSprintChance"] = new[] { "冲刺时额外增加的扭伤概率。", "Added sprain chance when you sprint." },
    };
}

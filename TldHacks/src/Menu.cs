using System;
using System.Collections.Generic;
using Il2Cpp;
using UnityEngine;

namespace TldHacks;

// Cursor 风格暗色 IMGUI。全部用 GUI.Xxx(Rect,..) 不用 GUILayout(被 strip)。
// Rect 通过 R(x,y,w,h) 乘 _scale。
internal static class Menu
{
    public static bool Open;

    private static float W = 1280f;
    private static float H = 760f;
    // v7.6:内容宽度必须留出 scrollview 左右边距(OUTER_PAD*2)+ 竖向滚动条(16px)+ 4px 余量,
    //   否则 3 列栅格右缘(= ContentW)会超出滚动内容矩形(= W - OUTER_PAD*2 - 16),
    //   最右列被 viewport 硬裁掉且没有横向滚动条能拉到(拉伸窗口只会等比放大裁切,治标不治本)。
    internal static float ContentW => W - OUTER_PAD * 2f - 20f;
    // v8.0 W_MIN 600 → 1040:600 宽下 MenuTweaks 的三列(COL_W3=(ContentW-30)/3=173)
    //   比标签列 LBL_W 还窄,COL_SLD_W3 算出负数 → 滑条 Rect 宽度为负,整行画不出来。
    //   窄屏的正确做法是调 MenuScale(0.6x 时 1040 宽只占屏幕 624px),不是压 W ——
    //   W 是"排版宽度",scale 是"屏幕占地",两者混用才是之前 4K/小屏都别扭的根因。
    private const float W_MIN = 1040f, W_MAX = 2400f;
    private const float H_MIN = 400f, H_MAX = 1200f;
    private static float _measuredMainH = 800f;
    private static float _measuredSpawnerH = 800f;
    private static float _measuredTweaksH = 400f;
    private static float _measuredRecipeH = 400f;
    private static float _measuredSaveH = 800f;
    private static readonly Func<float, float, float, float, Rect> RFunc = R;
    // v8.0 ScrollView 视口高度,由 DrawContents 每帧算好(tab 一行/两行会改变它)。
    //   Spawner 的动态行数要按这个算,原先写死 H-130 在两行 tab 下会多算一行 → 最后一行被裁。
    private static float _viewH = 630f;
    private static Vector2 _mainScroll;
    private static Vector2 _teleScroll;
    private static bool _splitDragging;
    private static float _splitStartMouseY, _splitStartH;
    private static Rect _window = new Rect(30f, 30f, W, H);
    private const int WindowId = 0x71D4_AC;

    private static float _scale = 1f;

    private static bool _prevCursorVisible;
    private static CursorLockMode _prevCursorLock;
    private static bool _cursorSaved;


    // Spawner + presets
    private static int _selectedCategory = 0;
    private static int _page = 0;
    // v2.7.55: PageSize 改成动态,按 UI 框可用高度自适应(cols 固定 3)
    private static int _pageSize = 18;
    private static int _pageRows = 6;
    private static int _quantity = 1;
    private static readonly int[] QuantityPresets = { 1, 5, 10, 50, 100 };
    private static readonly float[] SpeedPresets = { 0.5f, 1f, 2f, 5f };
    private static readonly int[] HourPresets = { 8, 12, 18, 22 };
    private static readonly string[] HourLabelsZh = { "晨8", "午12", "暮18", "夜22" };
    private static readonly string[] HourLabelsEn = { "8am", "Noon", "6pm", "10pm" };
    private static string[] HourLabels => I18n.IsEnglish ? HourLabelsEn : HourLabelsZh;
    // 修正映射:WeatherStage enum 实际值 DenseFog=0/LightSnow=1/HeavySnow=2/PartlyCloudy=3/Clear=4/Cloudy=5
    //                              LightFog=6/Blizzard=7/ClearAurora=8/ToxicFog=9/ElectrostaticFog=10
    private static readonly int[] WeatherStages = { 4, 3, 5, 1, 2, 7, 6, 0, 8, 9, 10 };
    private static readonly string[] WeatherLabelsZh = { "晴", "局部多云", "多云", "小雪", "大雪", "暴风雪", "薄雾", "浓雾", "极光", "毒雾", "电磁雾" };
    private static readonly string[] WeatherLabelsEn = { "Clear", "Partly", "Cloudy", "Lt Snow", "Hvy Snow", "Blizzard", "Mist", "Fog", "Aurora", "Toxic", "EM Fog" };
    private static string[] WeatherLabels => I18n.IsEnglish ? WeatherLabelsEn : WeatherLabelsZh;
    private static List<ItemEntry> _filtered = new List<ItemEntry>();
    private static int _lastCat = -1;
    private static bool _namesResolved;
    // v9.0 物品搜索:拼音首字母 / 全拼 / 英文名。_lastSearch 用来判断要不要重算 _filtered
    private static string _search = "";
    private static string _lastSearch = "";
    private static bool _searchFocused;      // 搜索框有焦点(自己管,见 UpdateSearchInput)
    private static string _searchShown = "";    // 框里显示的串(带光标),只在变化时重建
    private static string _searchShownFor;
    private static bool _searchShownCaret;
    private static bool _searchTyping;       // 上一帧的焦点态,用来只在翻转时动玩家控制
    private static bool _searchLockedInput;  // 玩家控制是我们锁的
    private static bool _searchBoxBroken;    // 画搜索框抛过异常 → 停掉它,别连累整张卡片

    // 搜索框在收字时,ModMain 里直接读 Input.GetKey 的热键(时间加速 F/E、飞行、搜刮、空格完成)要让路。
    //   玩家控制锁只拦得住游戏自己的输入,拦不住这些。
    internal static bool CapturingKeys => Open && _searchFocused;

    private static bool _worldSodaExpanded = false;   // v7.2 从 MenuTweaks 挪来:汽水参数折叠态(现属「食谱 & 食物」tab)
#if !STORY_EDITION
    private static float _recipeRetryAt;
    private static float _recipeCheckAt;
#endif

    // v8.3 标题栏版本号从 ModMain.VERSION 取,不再手写。拼好存成静态串,标题栏在每帧路径上,不能每帧拼字符串。
    private static readonly string TitleMain = $"TldHacks v{ModMain.VERSION}";
    private const string MetaZh = "本软件完全免费  |  作者 AKUL  |  最新版本 & 交流群 563092033";
    private const string MetaEn = "Free software  |  Author AKUL  |  Updates & QQ group 563092033";

    // v6.6 GC 优化:缓存每帧都渲染的字符串,仅在值变化时重建
    private static string _cachedStatusBar = "";
    private static string _cachedPosText = "";
    private static string _cachedLastAction = "";

    private static string _cachedScurvyLabel = "";
    private static float  _cachedVitC = -1f;
    private static string _cachedScurvyStatus = "";

    private static readonly string[] SpeedPresetLabels = { "0.5x", "1.0x", "2.0x", "5.0x" };

    // Spawner tab: 预计算 QuantityPreset 标签 + 当前数量标签缓存
    private static readonly string[] QuantityPresetLabels = { "×1", "×5", "×10", "×50", "×100" };
    private static string _cachedQtyLabel = "Now: 1";
    private static string _cachedQtyLabelZh = "当前: 1";
    private static int    _cachedQtyValue = 1;
    private static string _cachedSpawnBtnLabel = "+×1";
    private static string _cachedPageInfo = "";
    private static int    _cachedPageNum = -1;
    private static int    _cachedTotalPages = -1;
    private static int    _cachedFilteredCount = -1;

    // 标签页
    private static readonly string[] TabsZh = { "主页", "存档修改", "物品 & 传送", "人物 & 操作", "装备 & 衰减", "世界 & 饮食", "地图 & 界面" };
    private static readonly string[] TabsEn = { "Main", "Save Edits", "Items & Teleport", "Character & Controls", "Gear & Decay", "World & Food", "Map & UI" };
    private static string[] Tabs => I18n.IsEnglish ? TabsEn : TabsZh;
    private static int _activeTab = 0;

    private static Rect R(float x, float y, float w, float h)
    {
        if (Ui.Tracking) Ui.Track(x, y, h);
        return new Rect(x * _scale, y * _scale, w * _scale, h * _scale);
    }

    // Cursor Ink 配色
    private static readonly Color CursorBG = new Color32(0x1E, 0x1F, 0x22, 0xFF);
    private static readonly Color CursorPanel = new Color32(0x2B, 0x2D, 0x31, 0xFF);
    private static readonly Color CursorPanelHi = new Color32(0x35, 0x37, 0x3C, 0xFF);
    private static readonly Color CursorAccent = new Color32(0x59, 0x9C, 0xFF, 0xFF);
    private static readonly Color CursorAccentDim = new Color(0.35f, 0.61f, 1f, 0.25f);
    // 开着的开关字色。CursorAccent 在亮面板上只有 4.3:1,这个是 4.9:1
    private static readonly Color CursorAccentText = new Color32(0x6A, 0xA8, 0xFF, 0xFF);
    private static readonly Color CursorText = new Color32(0xF2, 0xF3, 0xF5, 0xFF);
    private static readonly Color CursorTextMuted = new Color32(0x9B, 0xA1, 0xAB, 0xFF);
    private static readonly Color CursorDanger = new Color32(0xFA, 0x79, 0x70, 0xFF);

    // 栅格与 MenuTweaks 共用:三列卡片,列内两个开关并排
    private const float OUTER_PAD = 16f;
    private const float ROW_H = 26f;
    private const float ROW_ADV = 30f;
    private const float SECTION_END_ADV = 20f;
    private const float PAD = Ui.CARD_PAD;
    private static float TOG_W => MenuTweaks.HALF_W;
    private static float TOG2_OFF => MenuTweaks.HALF_OFF;
    private static float TOG_WIDE => MenuTweaks.COL_W3;

    private static bool _stylesReady;
    // v7.7 上次构建样式态时的 _scale;!= 当前值才重建(见 InitStyles)
    private static float _styledScale = -1f;
    private static Texture2D _bgTex;
    private static Texture2D _transparentTex;
    private static Texture2D _panelTex;
    private static Texture2D _panelHiTex;
    private static Texture2D _accentTex;
    private static Texture2D _accentDimTex;
    private static Texture2D _dangerTex;
    private static Texture2D _tipTex;
    private static Texture2D _cardTex;
    private static Texture2D _lineTex, _trackTex, _thumbTex, _thumbHotTex, _outlineTex, _outlineHotTex;
    private static Texture2D _scrollTrackTex, _scrollThumbTex, _scrollThumbHotTex, _winTex;
    private static Texture2D _toggleOnTex;
    private static GUIStyle _tabStyle, _tabActiveStyle, _expanderStyle, _metaStyle;
    private static GUIStyle _sliderStyle, _thumbStyle, _vScrollStyle, _vScrollThumbStyle;
    private static float _titleW = 120f;
    private static IntPtr _skinPtr;
    private static GUIStyle _cardStyle;
    private static GUIStyle _windowStyle;
    private static GUIStyle _labelStyle;
    private static GUIStyle _mutedLabelStyle;
    private static GUIStyle _valueLabelStyle;   // 滑条右侧数值:右对齐 muted,让数值列对齐成栏
    private static GUIStyle _titleStyle;
    private static GUIStyle _sectionStyle;
    private static GUIStyle _sectionTitleStyle;
    private static GUIStyle _buttonStyle;
    private static GUIStyle _buttonActiveStyle;
    private static GUIStyle _buttonDangerStyle;
    private static GUIStyle _buttonConfirmStyle;   // 点两次才执行的按钮在等第二下时用,红底深字
    private static GUIStyle _toggleStyle;
    private static GUIStyle _statusStyle;
    private static GUIStyle _rowLabelStyle;       // v4.0 物品生成器行 Label 垂直居中,与按钮基线对齐
    private static GUIStyle _searchFieldStyle, _searchFieldHotStyle;   // v9.0 物品搜索框(自己画的,聚焦换描边)
    private static GUIStyle _tipStyle;

    private static Texture2D Tex(Color color)
    {
        var tex = new Texture2D(1, 1);
        // v2.7.73 场景切换/uConsole 开启后 UI 变透明 —— Unity 把没挂树的 Texture2D 当可回收资源清掉,
        //   残留的 GUIStyle.background 指向 dead texture → 渲染透明。HideAndDontSave 锁死生命周期
        tex.hideFlags = HideFlags.HideAndDontSave;
        tex.SetPixel(0, 0, color);
        tex.Apply();
        return tex;
    }

    private static GUIStyleState State(Texture2D bg, Color text)
        => new GUIStyleState { background = bg, textColor = text };

    // 悬停说明底图:1px 描边 + 深色底
    private static Texture2D FrameTex(Color edge, Color fill)
    {
        var tex = new Texture2D(3, 3);
        tex.hideFlags = HideFlags.HideAndDontSave;
        tex.filterMode = FilterMode.Point;
        tex.wrapMode = TextureWrapMode.Clamp;
        for (int y = 0; y < 3; y++)
            for (int x = 0; x < 3; x++)
                tex.SetPixel(x, y, x == 1 && y == 1 ? fill : edge);
        tex.Apply();
        return tex;
    }

    // 圆形滑块:边缘 1px 抗锯齿,双线性缩放
    private static Texture2D CircleTex(int size, Color c)
    {
        var tex = new Texture2D(size, size, TextureFormat.RGBA32, false);
        tex.hideFlags = HideFlags.HideAndDontSave;
        tex.filterMode = FilterMode.Bilinear;
        tex.wrapMode = TextureWrapMode.Clamp;
        float r = size * 0.5f;
        for (int y = 0; y < size; y++)
            for (int x = 0; x < size; x++)
            {
                float dx = x + 0.5f - r, dy = y + 0.5f - r;
                float a = Mathf.Clamp01(r - Mathf.Sqrt(dx * dx + dy * dy));
                tex.SetPixel(x, y, new Color(c.r, c.g, c.b, c.a * a));
            }
        tex.Apply();
        return tex;
    }

    // 开着的开关底图:左边 bar 列是强调色,最后一列是面板色。样式的 border.left = bar,
    //   画的时候只拉伸最后一列,所以蓝条宽度不随按钮宽度变
    private static Texture2D BarTex(int bar, Color edge, Color fill)
    {
        var tex = new Texture2D(bar + 1, 1, TextureFormat.RGBA32, false);
        tex.hideFlags = HideFlags.HideAndDontSave;
        tex.filterMode = FilterMode.Point;
        tex.wrapMode = TextureWrapMode.Clamp;
        for (int x = 0; x <= bar; x++) tex.SetPixel(x, 0, x < bar ? edge : fill);
        tex.Apply();
        return tex;
    }

    private static void InitStyles()
    {
        // v2.7.73 兜底:即使加了 HideAndDontSave,某些 Il2Cpp 下的 texture 仍可能失效。
        //   Unity 的 == null 对 destroyed Object 返回 true,触发重建
        if (_stylesReady && _bgTex == null) _stylesReady = false;

        if (!_stylesReady)
        {
            _bgTex = Tex(CursorBG);
            _transparentTex = Tex(new Color(0f, 0f, 0f, 0f));
            _panelTex = Tex(CursorPanel);
            _panelHiTex = Tex(CursorPanelHi);
            _accentTex = Tex(CursorAccent);
            _accentDimTex = Tex(CursorAccentDim);
            _dangerTex = Tex(CursorDanger);
            _tipTex = FrameTex(new Color32(0x59, 0x5D, 0x66, 0xFF), new Color32(0x16, 0x17, 0x1A, 0xF8));
            _cardTex = FrameTex(new Color32(0x34, 0x37, 0x3C, 0xFF), new Color32(0x25, 0x27, 0x2B, 0xFF));
            _lineTex = Tex(new Color32(0x34, 0x37, 0x3C, 0xFF));
            _trackTex = Tex(new Color32(0x3A, 0x3D, 0x43, 0xFF));
            _thumbTex = CircleTex(24, new Color32(0xD5, 0xD8, 0xDD, 0xFF));
            _thumbHotTex = CircleTex(24, Color.white);
            _outlineTex = FrameTex(new Color32(0x4A, 0x4E, 0x57, 0xFF), new Color32(0x25, 0x27, 0x2B, 0xFF));
            _outlineHotTex = FrameTex(CursorAccent, CursorPanel);
            _scrollTrackTex = Tex(new Color32(0x25, 0x27, 0x2B, 0xFF));
            _scrollThumbTex = Tex(new Color32(0x4A, 0x4E, 0x57, 0xFF));
            _scrollThumbHotTex = Tex(new Color32(0x5E, 0x63, 0x6D, 0xFF));
            _winTex = FrameTex(new Color32(0x34, 0x37, 0x3C, 0xFF), CursorBG);
            _cardStyle = new GUIStyle(GUI.skin.box);
            _tabStyle = new GUIStyle(GUI.skin.button);
            _tabActiveStyle = new GUIStyle(GUI.skin.button);
            _expanderStyle = new GUIStyle(GUI.skin.button);
            _metaStyle = new GUIStyle(GUI.skin.label);
            // 复制时保留 name:滚动条靠 name + "thumb" 在 skin 里找滑块样式
            _sliderStyle = new GUIStyle(GUI.skin.horizontalSlider);
            _thumbStyle = new GUIStyle(GUI.skin.horizontalSliderThumb);
            _vScrollStyle = new GUIStyle(GUI.skin.verticalScrollbar);
            _vScrollThumbStyle = new GUIStyle(GUI.skin.verticalScrollbarThumb);
            _skinPtr = IntPtr.Zero;

            _windowStyle = new GUIStyle(GUI.skin.window);
            _labelStyle = new GUIStyle(GUI.skin.label);
            _mutedLabelStyle = new GUIStyle(GUI.skin.label);
            _valueLabelStyle = new GUIStyle(GUI.skin.label);
            _titleStyle = new GUIStyle(GUI.skin.label);
            _sectionStyle = new GUIStyle(GUI.skin.box);
            _sectionTitleStyle = new GUIStyle(GUI.skin.label);
            _buttonStyle = new GUIStyle(GUI.skin.button);
            _buttonActiveStyle = new GUIStyle(GUI.skin.button);
            _buttonDangerStyle = new GUIStyle(GUI.skin.button);
            _buttonConfirmStyle = new GUIStyle(GUI.skin.button);
            _toggleStyle = new GUIStyle(GUI.skin.button);
            _statusStyle = new GUIStyle(GUI.skin.label);
            _rowLabelStyle = new GUIStyle(GUI.skin.label);
            _searchFieldStyle = new GUIStyle(GUI.skin.box);
            _searchFieldHotStyle = new GUIStyle(GUI.skin.box);
            _tipStyle = new GUIStyle(GUI.skin.label);
            _stylesReady = true;
            _styledScale = -1f;   // 强制下面的样式态重建一次
        }

        // v7.7 性能修:下面这段(State/RectOffset 构造)原先在 _stylesReady 守卫之外,
        //   每个 IMGUI pass 都重跑一次 = 每次 60 个 GUIStyleState + 21 个 RectOffset = 81 个
        //   带原生句柄的托管包装对象。菜单开着时 120 pass/s ≈ 9700 对象/秒的 Gen0 压力。
        //   这段的输入只有 _scale 和编译期常量颜色/纹理,所以按 _scale 缓存即完全等价。
        //   缩放改变(x1.7 按钮)或纹理失效时才重建。
        if (_styledScale != _scale)
        {
        _styledScale = _scale;

        int body = Mathf.Max(10, Mathf.RoundToInt(12f * _scale));
        int h1 = Mathf.Max(12, Mathf.RoundToInt(15f * _scale));
        int h2 = Mathf.Max(11, Mathf.RoundToInt(13f * _scale));

        _windowStyle.normal = State(_winTex, CursorText);
        _windowStyle.hover = State(_winTex, CursorText);
        _windowStyle.active = State(_winTex, CursorText);
        _windowStyle.focused = State(_winTex, CursorText);
        _windowStyle.onNormal = State(_winTex, CursorText);
        _windowStyle.onHover = State(_winTex, CursorText);
        _windowStyle.onActive = State(_winTex, CursorText);
        _windowStyle.onFocused = State(_winTex, CursorText);
        _windowStyle.padding = new RectOffset(0, 0, 0, 0);
        _windowStyle.border = new RectOffset(1, 1, 1, 1);
        _windowStyle.margin = new RectOffset(0, 0, 0, 0);
        _windowStyle.overflow = new RectOffset(0, 0, 0, 0);
        _windowStyle.contentOffset = Vector2.zero;
        _windowStyle.fontSize = h1;

        // 标签上下居中,和同一行的滑条、按钮、数值对齐
        ConfigureLabel(_labelStyle, body, CursorText);
        _labelStyle.alignment = TextAnchor.MiddleLeft;
        ConfigureLabel(_mutedLabelStyle, body, CursorTextMuted);
        _mutedLabelStyle.alignment = TextAnchor.MiddleLeft;
        ConfigureLabel(_valueLabelStyle, body, CursorTextMuted);
        _valueLabelStyle.alignment = TextAnchor.MiddleRight;
        ConfigureLabel(_titleStyle, h1, CursorText);
        _titleStyle.fontStyle = FontStyle.Bold;
        _titleStyle.alignment = TextAnchor.MiddleLeft;
        _titleStyle.wordWrap = false;
        _titleStyle.clipping = TextClipping.Overflow;
        ConfigureLabel(_metaStyle, body, CursorTextMuted);
        _metaStyle.alignment = TextAnchor.MiddleLeft;
        _metaStyle.wordWrap = false;
        ConfigureLabel(_sectionTitleStyle, h2, CursorText);
        _sectionTitleStyle.fontStyle = FontStyle.Bold;
        _sectionTitleStyle.alignment = TextAnchor.MiddleLeft;
        ConfigureLabel(_statusStyle, body, CursorTextMuted);
        ConfigureLabel(_rowLabelStyle, body, CursorText);
        _rowLabelStyle.alignment = TextAnchor.MiddleLeft;

        // 搜索框:和按钮一样的 1px 描边底图,聚焦那版描边转蓝
        ConfigureBox(_searchFieldStyle, _outlineTex, CursorText);
        ConfigureBox(_searchFieldHotStyle, _outlineHotTex, CursorText);

        ConfigureBox(_sectionStyle, _panelTex, CursorText);
        ConfigureBox(_cardStyle, _cardTex, CursorText);
        ConfigureButton(_buttonStyle, _outlineTex, CursorText, body);
        _buttonStyle.hover = State(_outlineHotTex, CursorText);
        _buttonStyle.active = State(_accentDimTex, CursorText);
        // 选中档位和待确认按钮用深色字:白字在蓝底上只有 2.5:1、红底上 2.4:1,深色字是 6.0 和 6.3
        ConfigureButton(_buttonActiveStyle, _accentTex, CursorBG, body);
        ConfigureButton(_buttonDangerStyle, _dangerTex, CursorText, body);
        ConfigureButton(_buttonConfirmStyle, _dangerTex, CursorBG, body);
        // 开关:开着亮面板蓝字,左边再加一道蓝条,转成灰度也分得清开关;关着暗一档的底配灰字
        ConfigureButton(_toggleStyle, _panelTex, CursorTextMuted, body);
        int bar = Mathf.Max(2, Mathf.RoundToInt(3f * _scale));
        if (_toggleOnTex == null || _toggleOnTex.width != bar + 1)
        {
            if (_toggleOnTex != null) UnityEngine.Object.Destroy(_toggleOnTex);
            _toggleOnTex = BarTex(bar, CursorAccent, CursorPanelHi);
        }
        // 其他状态的底图都是 1x1 纯色,border 改大了照样铺满
        _toggleStyle.border = new RectOffset(bar, 0, 0, 0);
        _toggleStyle.onNormal = State(_toggleOnTex, CursorAccentText);
        _toggleStyle.onHover = State(_toggleOnTex, CursorAccentText);
        _toggleStyle.onActive = State(_accentDimTex, CursorText);
        _toggleStyle.onFocused = State(_toggleOnTex, CursorAccentText);

        // 标签页:未选中只有灰字,悬停和选中垫一层面板色,选中项下方再画蓝色下划线(见 DrawContents)
        ConfigureButton(_tabStyle, null, CursorTextMuted, body);
        _tabStyle.hover = State(_panelTex, CursorText);
        _tabStyle.active = State(_panelHiTex, CursorText);
        ConfigureButton(_tabActiveStyle, _panelTex, CursorText, body);
        _tabActiveStyle.hover = State(_panelTex, CursorText);
        _tabActiveStyle.active = State(_panelTex, CursorText);

        // 折叠行:无底色,悬停时整行提亮;箭头由 MenuTweaks.Expander 画在右端
        ConfigureButton(_expanderStyle, null, CursorTextMuted, body);
        _expanderStyle.alignment = TextAnchor.MiddleLeft;
        _expanderStyle.padding = new RectOffset(6, 6, 0, 0);
        _expanderStyle.hover = State(_panelHiTex, CursorText);
        _expanderStyle.active = State(_panelHiTex, CursorText);

        // 滑条:轨道和填充段由 Ui.SliderRaw 画,样式本身不画底图
        _sliderStyle.normal = State(null, CursorText);
        _sliderStyle.hover = State(null, CursorText);
        _sliderStyle.active = State(null, CursorText);
        _sliderStyle.focused = State(null, CursorText);
        _sliderStyle.border = new RectOffset(0, 0, 0, 0);
        _sliderStyle.padding = new RectOffset(0, 0, 0, 0);
        _sliderStyle.margin = new RectOffset(0, 0, 0, 0);
        _sliderStyle.overflow = new RectOffset(0, 0, 0, 0);
        _sliderStyle.fixedWidth = 0f;
        _sliderStyle.fixedHeight = 0f;
        _thumbStyle.normal = State(_thumbTex, CursorText);
        _thumbStyle.hover = State(_thumbHotTex, CursorText);
        _thumbStyle.active = State(_thumbHotTex, CursorText);
        _thumbStyle.focused = State(_thumbTex, CursorText);
        _thumbStyle.border = new RectOffset(0, 0, 0, 0);
        _thumbStyle.padding = new RectOffset(0, 0, 0, 0);
        _thumbStyle.margin = new RectOffset(0, 0, 0, 0);
        _thumbStyle.overflow = new RectOffset(0, 0, 0, 0);
        _thumbStyle.fixedWidth = Mathf.Round(12f * _scale);
        _thumbStyle.fixedHeight = 0f;

        // 竖滚动条:8px 细条贴在 16px 槽位右侧。BeginScrollView 让出 fixedWidth + margin.left,
        //   两者相加必须 ≤ 16 * _scale,否则内容矩形比可视宽度宽,会冒出横向滚动条。
        int sbW = Mathf.Max(4, Mathf.RoundToInt(8f * _scale));
        int sbGap = Mathf.Max(0, Mathf.FloorToInt(16f * _scale) - sbW);
        _vScrollStyle.normal = State(_scrollTrackTex, CursorText);
        _vScrollStyle.hover = State(_scrollTrackTex, CursorText);
        _vScrollStyle.active = State(_scrollTrackTex, CursorText);
        _vScrollStyle.focused = State(_scrollTrackTex, CursorText);
        _vScrollStyle.border = new RectOffset(0, 0, 0, 0);
        _vScrollStyle.padding = new RectOffset(1, 1, 0, 0);
        _vScrollStyle.margin = new RectOffset(sbGap, 0, 0, 0);
        _vScrollStyle.overflow = new RectOffset(0, 0, 0, 0);
        _vScrollStyle.fixedWidth = sbW;
        _vScrollStyle.fixedHeight = 0f;
        int thumbMin = Mathf.RoundToInt(10f * _scale);
        _vScrollThumbStyle.normal = State(_scrollThumbTex, CursorText);
        _vScrollThumbStyle.hover = State(_scrollThumbHotTex, CursorText);
        _vScrollThumbStyle.active = State(_scrollThumbHotTex, CursorText);
        _vScrollThumbStyle.focused = State(_scrollThumbTex, CursorText);
        _vScrollThumbStyle.border = new RectOffset(0, 0, 0, 0);
        _vScrollThumbStyle.padding = new RectOffset(0, 0, thumbMin, thumbMin);
        _vScrollThumbStyle.margin = new RectOffset(0, 0, 0, 0);
        _vScrollThumbStyle.overflow = new RectOffset(0, 0, 0, 0);
        _vScrollThumbStyle.fixedWidth = 0f;
        _vScrollThumbStyle.fixedHeight = 0f;

        try { _titleW = Mathf.Max(110f, _titleStyle.CalcSize(new GUIContent(TitleMain)).x / _scale + 8f); }
        catch { _titleW = 140f; }

        ConfigureLabel(_tipStyle, body, CursorText);
        _tipStyle.wordWrap = true;
        _tipStyle.alignment = TextAnchor.UpperLeft;
        _tipStyle.normal = State(_tipTex, CursorText);
        _tipStyle.border = new RectOffset(1, 1, 1, 1);
        _tipStyle.padding = new RectOffset(Mathf.RoundToInt(8f * _scale), Mathf.RoundToInt(8f * _scale),
                                           Mathf.RoundToInt(6f * _scale), Mathf.RoundToInt(6f * _scale));
        Ui.Scale = _scale;
        Ui.TipStyle = _tipStyle;
        Ui.OnScaleChanged();
        }   // end if (_styledScale != _scale)

        // GUISkin 的每个 setter 都会重建一遍样式字典(Apply → BuildStyleCache),所以只在 skin 换了、
        //   或者别的 mod 改过 skin.button 时才重新赋值。下面 MenuTweaks / Ui 的是纯引用赋值,每次跑。
        var skin = GUI.skin;
        if (skin == null) return;
        var curBtn = skin.button;
        if (skin.Pointer != _skinPtr || curBtn == null || curBtn.Pointer != _buttonStyle.Pointer)
        {
            skin.window = _windowStyle;
            skin.label = _labelStyle;
            skin.box = _sectionStyle;
            skin.button = _buttonStyle;
            skin.toggle = _toggleStyle;
            skin.verticalScrollbar = _vScrollStyle;
            skin.verticalScrollbarThumb = _vScrollThumbStyle;
            _skinPtr = skin.Pointer;
        }

        MenuTweaks.AccentBar = _buttonActiveStyle;
        MenuTweaks.LabelStyle = _labelStyle;
        MenuTweaks.MutedLabel = _mutedLabelStyle;
        MenuTweaks.ValueLabel = _valueLabelStyle;
        MenuTweaks.ToggleStyle = _toggleStyle;
        MenuTweaks.ExpanderStyle = _expanderStyle;
        Ui.CardStyle = _cardStyle;
        Ui.TitleStyle = _sectionTitleStyle;
        Ui.BadgeStyle = _valueLabelStyle;
        Ui.ToggleStyle = _toggleStyle;
        Ui.LineTex = _lineTex;
        Ui.TrackTex = _trackTex;
        Ui.FillTex = _accentTex;
        Ui.SliderStyle = _sliderStyle;
        Ui.ThumbStyle = _thumbStyle;
    }

    private static void ConfigureLabel(GUIStyle style, int size, Color color)
    {
        style.fontSize = size;
        style.normal = State(null, color);
        style.hover = State(null, color);
        style.active = State(null, color);
        style.focused = State(null, color);
        style.padding = new RectOffset(6, 6, 0, 0);
    }

    private static void ConfigureBox(GUIStyle style, Texture2D bg, Color text)
    {
        style.normal = State(bg, text);
        style.hover = State(bg, text);
        style.active = State(bg, text);
        style.focused = State(bg, text);
        style.border = new RectOffset(1, 1, 1, 1);
        style.padding = new RectOffset(0, 0, 0, 0);
    }

    private static void ConfigureButton(GUIStyle style, Texture2D bg, Color text, int size)
    {
        style.fontSize = size;
        style.normal = State(bg, text);
        bool solid = bg == _accentTex || bg == _dangerTex;
        style.hover = State(solid ? bg : _accentDimTex, solid ? text : CursorText);
        style.active = State(solid ? bg : _accentDimTex, solid ? text : CursorText);
        style.focused = State(bg, text);
        style.padding = new RectOffset(8, 8, 0, 0);
        style.border = new RectOffset(1, 1, 1, 1);
    }

    private static bool CBtn(float x, float y, float w, float h, string text, bool active = false, bool danger = false)
        => GUI.Button(R(x, y, w, h), text, danger ? _buttonDangerStyle : active ? _buttonActiveStyle : _buttonStyle);

    private static bool CTog(float x, float y, float w, float h, bool value, string text)
        => Ui.Toggle(null, R(x, y, w, h), value, text, _toggleStyle);

    private static void CLabel(float x, float y, float w, float h, string text, bool muted = false)
        => GUI.Label(R(x, y, w, h), text, muted ? _mutedLabelStyle : _labelStyle);

    private static void Divider(float x, float y, float w)
        => GUI.Box(R(x, y, w, 1f), "", _buttonStyle);

    public static void Toggle() { if (Open) Close(); else OpenMenu(); }

    private static void OpenMenu()
    {
        if (!_cursorSaved)
        {
            _prevCursorVisible = Cursor.visible;
            _prevCursorLock = Cursor.lockState;
            _cursorSaved = true;
        }
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        // v2.7.83:从 Settings 恢复窗口位置
        var s = ModMain.Settings;
        if (s != null)
        {
            _window.x = s.MenuX;
            _window.y = s.MenuY;
            ClampWin();
        }
        Open = true;
        _pausedByMenu = TryOpenPauseMenu();
    }

    // 不暂停的话鼠标被视角抢走,修改器点不了,玩家原先都是先按 ESC 再开。这里替他按。
    private static bool _pausedByMenu;

    private static bool TryOpenPauseMenu()
    {
#if !STORY_EDITION
        if (ModMain.Settings == null || !ModMain.Settings.MenuPauseGame) return false;
        try
        {
            if (GameManager.IsMainMenuActive() || GameManager.m_IsPaused || !InputManager.CanInvokePauseMenu()) return false;
            var p = InterfaceManager.GetPanel<Panel_PauseMenu>();
            if (p == null || p.isActiveAndEnabled) return false;
            p.Enable(true);
            return true;
        }
        catch (System.Exception ex) { ModMain.Log?.Warning($"[Menu] open pause menu: {ex.Message}"); }
#endif
        return false;
    }

    private static void ClosePauseMenu()
    {
        try
        {
            var p = InterfaceManager.GetPanel<Panel_PauseMenu>();
            if (p != null && p.isActiveAndEnabled) p.OnDone();
        }
        catch (System.Exception ex) { ModMain.Log?.Warning($"[Menu] close pause menu: {ex.Message}"); }
    }

    // v8.0 把整个窗口按住在屏幕内。原先只夹 (0, Screen.w-120)/(0, Screen.h-60):那是"至少留 120x60
    //   在屏幕上"的写法,于是窗口右/下大半可以被拖出屏幕 —— 底部状态栏和右下角 resize 手柄一起没了,
    //   再想改回尺寸只能去 json。Draw() 里的 fitScale 已经保证 w/h 不超过屏幕,所以这里总能夹住。
    private static void ClampWin()
    {
        _window.x = Mathf.Clamp(_window.x, 0f, Mathf.Max(0f, Screen.width - _window.width));
        _window.y = Mathf.Clamp(_window.y, 0f, Mathf.Max(0f, Screen.height - _window.height));
    }

    private static void Close()
    {
        // v2.7.83:关闭时保存窗口位置 + 缩放
        var s = ModMain.Settings;
        if (s != null)
        {
            s.MenuX = _window.x;
            s.MenuY = _window.y;
            // v8.0 删掉 s.MenuScale = _scale 的回写:Draw() 现在会为了不超出屏幕临时压低 _scale,
            //   回写会把这个压缩值当成用户意图存下来(在小屏上开一次菜单,4K 屏上就永久变小)。
            //   缩放的唯一权威来源是 s.MenuScale 本身(标题栏 +/- 直接改它)。
            // v7.7 关菜单是最后的确定时机(玩家可能紧接着退游戏)→ 立即落盘,
            //   顺带把绘制期间累积的所有延迟写一并 flush 掉。
            s.RequestSave();
            s.FlushPendingSave();
        }
        _resizing = false;
        _searchFocused = false;   // 不清的话重开菜单马上又锁住玩家控制,WASD 还会打进框里
        Open = false;
        if (_pausedByMenu) { _pausedByMenu = false; ClosePauseMenu(); }
        if (_cursorSaved)
        {
            Cursor.visible = _prevCursorVisible;
            Cursor.lockState = _prevCursorLock;
            _cursorSaved = false;
        }
    }

    private static float _prevWinX, _prevWinY;
    private static int _saveCooldown = 0; // 拖动停止后延迟保存,避免每帧写磁盘
    // v2.7.94:自定义拖动(屏幕坐标驱动,鼠标出界仍能拖)
    private static bool _dragging = false;
    private static Vector2 _dragStartScreenMouse;
    private static float _dragStartWinX, _dragStartWinY;
    // v2.7.91:窗口尺寸拖拽(宽高独立)
    private static bool _resizing = false;
    private static Vector2 _resizeStartMouse;
    private static Vector2 _resizeStartScreenMouse;
    private static float _resizeStartW, _resizeStartH;
    private enum ResizeEdge { None, Right, Bottom, Corner }
    private static ResizeEdge _resizeEdge = ResizeEdge.None;

    public static void Draw()
    {
        if (!Open)
        {
            // 焦点还在搜索框里就被关掉了(热键关菜单),把玩家控制放回去
            if (_searchTyping) SyncSearchInputLock(false);
            return;
        }

        var s = ModMain.Settings;
        if (s != null)
        {
            // v8.0 首次运行按屏幕高度定一次缩放,之后完全听玩家的(见 Settings.MenuAutoScaled)。
            if (!s.MenuAutoScaled)
            {
                s.MenuAutoScaled = true;
                // 只在玩家没动过缩放时才自动定(MenuScale 仍是默认 1.0)。
                //   老用户升上来时 MenuAutoScaled 字段不存在 → false,如果不看这个条件,
                //   就会把人家在 4K 上手调好的 x2.0 / x1.5 当成"没设过"给覆盖掉。
                if (Screen.height > 0 && Mathf.Approximately(s.MenuScale, 1f))
                {
                    // 以 1080p 为 1.0 基准,按 0.1 档取整。4K(2160) → 2.0,1440p → 1.3。
                    float auto = Mathf.Clamp(Mathf.Round(Screen.height / 1080f * 10f) / 10f, 0.6f, 3.0f);
                    s.MenuScale = auto;
                    ModMain.Log?.Msg($"[Menu] 首次运行:屏幕 {Screen.width}x{Screen.height} → 菜单缩放 x{auto:F1}");
                }
                s.RequestSave();
            }
            _scale = Mathf.Clamp(s.MenuScale, 0.6f, 3.0f);
            W = Mathf.Clamp(s.MenuWidth, W_MIN, W_MAX);
            H = Mathf.Clamp(s.MenuHeight, H_MIN, H_MAX);
        }
        // v8.0 4K/1080P 适配:窗口再大也不能超出屏幕。W_MAX*3.0 = 7200px,原先直接画到屏幕外,
        //   连右下角的 resize 手柄都抓不到 → 用户只能去改 json 才能救回来。
        //   这里只压"生效缩放",不写回 s.MenuScale(见 Close():不再回写,否则用户设的值会被压死)。
        float fitScale = Mathf.Min((Screen.width - 16f) / W, (Screen.height - 16f) / H);
        if (fitScale > 0f && fitScale < _scale) _scale = fitScale;

        _window.width = W * _scale;
        _window.height = H * _scale;
        ClampWin();

        InitStyles();

        // v2.7.94:自定义拖动(屏幕坐标驱动,鼠标出界仍能丝滑拖动)
        if (_dragging)
        {
            Vector2 screenMouse = Input.mousePosition;
            screenMouse.y = Screen.height - screenMouse.y;
            _window.x = _dragStartWinX + (screenMouse.x - _dragStartScreenMouse.x);
            _window.y = _dragStartWinY + (screenMouse.y - _dragStartScreenMouse.y);
            ClampWin();
            if (!Input.GetMouseButton(0)) _dragging = false;
        }

        // resize 用 Input.mousePosition(屏幕坐标,不受窗口裁剪)驱动,
        // 鼠标跑出窗口边界也能丝滑拖拽
        if (_resizing)
        {
            Vector2 screenMouse = Input.mousePosition;
            screenMouse.y = Screen.height - screenMouse.y;
            float dx = (screenMouse.x - _resizeStartScreenMouse.x) / _scale;
            float dy = (screenMouse.y - _resizeStartScreenMouse.y) / _scale;
            if (_resizeEdge == ResizeEdge.Right || _resizeEdge == ResizeEdge.Corner)
                W = Mathf.Clamp(_resizeStartW + dx, W_MIN, W_MAX);
            if (_resizeEdge == ResizeEdge.Bottom || _resizeEdge == ResizeEdge.Corner)
                H = Mathf.Clamp(_resizeStartH + dy, H_MIN, H_MAX);
            _window.width = W * _scale;
            _window.height = H * _scale;
            ClampWin();
            if (!Input.GetMouseButton(0))
            {
                _resizing = false;
                _resizeEdge = ResizeEdge.None;
                W = Mathf.Round(W / 10f) * 10f;
                H = Mathf.Round(H / 10f) * 10f;
                if (s != null) { s.MenuWidth = W; s.MenuHeight = H; s.RequestSave(); }
            }
        }

        _window = GUI.Window(WindowId, _window, (GUI.WindowFunction)DrawContents, "");

        SyncSearchInputLock(_activeTab == 2 && _searchFocused);

        // v2.7.83:检测拖动 → 延迟保存(位置稳定 30 帧后才写磁盘)
        if (s != null)
        {
            if (Mathf.Abs(_window.x - _prevWinX) > 0.5f || Mathf.Abs(_window.y - _prevWinY) > 0.5f)
            {
                _prevWinX = _window.x;
                _prevWinY = _window.y;
                _saveCooldown = 30; // 位置还在变,重置计时器
            }
            else if (_saveCooldown > 0 && --_saveCooldown == 0)
            {
                // 位置稳定 30 帧(0.5s),写一次磁盘
                s.MenuX = _window.x;
                s.MenuY = _window.y;
                s.RequestSave();
            }
        }
    }

    // v2.7.5:基准字号降到 13pt(原 16 在 1.8x 时 29px 超过 22*1.8=39.6 的行距,section 重叠 toggle)
    // 13 * 1.8 = 23.4px,行距 39.6px,明显够 —— 4K 大缩放下也不再挤。
    private static void ApplyFontScale()
    {
        try
        {
            int fs = Mathf.Max(10, Mathf.RoundToInt(13f * _scale));
            var sk = GUI.skin;
            if (sk == null) return;
            if (sk.label != null) sk.label.fontSize = fs;
            if (sk.button != null) sk.button.fontSize = fs;
            if (sk.toggle != null) sk.toggle.fontSize = fs;
            if (sk.box != null) sk.box.fontSize = fs;
            if (sk.window != null) sk.window.fontSize = fs;
            if (sk.textField != null) sk.textField.fontSize = fs;
        }
        catch { }
    }

    private static void DrawContents(int id)
    {
        var s = ModMain.Settings;
        if (s == null)
        {
            GUI.Label(R(10f, 30f, W - 20f, 20f), I18n.T("配置未初始化。", "Settings not initialized."));
            return;
        }

        // 窗口里任何一次点击都先收掉搜索框焦点,点在框里时 DrawItemSearchBox 会在同一个事件里重新设回。
        //   只靠框自己判断不够:框上面的传送按钮会先 Use() 掉 MouseDown,框就看不到这次点击,焦点和锁会带着跨场景。
        var ev0 = Event.current;
        if (ev0 != null && ev0.type == EventType.MouseDown) _searchFocused = false;

        GUI.Box(R(0f, 0f, W, H), "", _windowStyle);
        GUI.Label(R(16f, 8f, _titleW, 24f), TitleMain, _titleStyle);
        GUI.Label(R(16f + _titleW + 4f, 8f, Mathf.Max(0f, W - 172f - _titleW), 24f), I18n.T(MetaZh, MetaEn), _metaStyle);
        GUI.Label(R(16f, 30f, W - 170f, 18f),
            I18n.T("鼠标停在选项上可查看说明", "Hold the mouse on an option to see its description."), _mutedLabelStyle);

        // 标题栏右侧:scale - / x1.0 / + / Close (v2.7.83 统一间距 4px)
        // 先取 min(设置值, 生效值) 再减:屏幕装不下时 _scale 被 fitScale 压过,
        //   直接减 s.MenuScale 会先把那段"看不见的水位"一格格放完(点好几下界面纹丝不动),
        //   这和上面 + 到顶空转是同一个毛病。
        if (CBtn(W - 148f, 8f, 28f, 24f, "-"))
        { s.MenuScale = Mathf.Max(0.6f, Mathf.Min(s.MenuScale, _scale) - 0.1f); s.RequestSave(); }
        // label 居中在 - 和 + 之间
        var prevAlign = _mutedLabelStyle.alignment;
        _mutedLabelStyle.alignment = UnityEngine.TextAnchor.MiddleCenter;
        // v8.0 显示"实际生效"的缩放而不是设置值:超出屏幕时 Draw() 会压 _scale,
        //   原先照着 s.MenuScale 显示 → 4K 以下的屏上一直点 + 数字照涨但界面纹丝不动,像坏了。
        GUI.Label(R(W - 120f, 8f, 32f, 24f), $"x{_scale:F1}", _mutedLabelStyle);
        _mutedLabelStyle.alignment = prevAlign;
        // 到顶就不再累加:上限是 3.0,或者屏幕已经装不下(_scale 被 fitScale 压过)。
        //   否则 s.MenuScale 会一路涨到 3.0 存进 json,换台大屏才发现菜单突然巨大。
        bool canGrow = s.MenuScale < 3.0f && _scale >= s.MenuScale - 0.01f;
        if (CBtn(W - 88f, 8f, 28f, 24f, "+") && canGrow)
        { s.MenuScale = Mathf.Min(3.0f, s.MenuScale + 0.1f); s.RequestSave(); }
        if (CBtn(W - 56f, 8f, 44f, 24f, I18n.T("关闭", "Close"), false, true)) Close();

        // 标签页
        // TAB_MIN = 放得下最长标签所需的按钮宽度。最长的是英文 "Character & Controls"(20 字符,
        //   13pt 下约 130px)+ 按钮左右 padding(12px)≈ 142px,取 146。
        //   7 个 tab 在默认宽 1280 下每个约 173px 一行;拉到最窄 1040 时折成两行。
        const float TAB_MIN = 146f;
        // 判据必须和下面算 tabW 的式子一致(都要减掉 6px 间距),否则会挑 1 行却给出比
        //   TAB_MIN 还小的按钮,最长标签仍然被 IMGUI 截成 "Items & Telep..."。
        int tabRows = (ContentW + 6f) / Tabs.Length - 6f >= TAB_MIN ? 1 : 2;
        int tabPerRow = (Tabs.Length + tabRows - 1) / tabRows;
        float tabW = Mathf.Min(190f, (ContentW + 6f) / tabPerRow - 6f);
        for (int i = 0; i < Tabs.Length; i++)
        {
            float tx = 16f + (i % tabPerRow) * (tabW + 6f);
            float ty = 52f + (i / tabPerRow) * 32f;
            bool act = i == _activeTab;
            // v8.0 换 tab 归零滚动位置。原先沿用上一个 tab 的偏移:从「人物&生存」(1176px 要滚)
            //   切到「光火&制作」(464px 一屏放得下)会开在半空;而 tabs 3-7 共用 _measuredTweaksH,
            //   切换那一帧拿的是上个 tab 的高度 → 滚动条还会闪一下错的长度。
            if (GUI.Button(R(tx, ty, tabW, 28f), Tabs[i], act ? _tabActiveStyle : _tabStyle) && !act)
            {
                _activeTab = i;
                _mainScroll = Vector2.zero;
                _measuredTweaksH = 400f;
                _searchFocused = false;   // 搜索框跟着 tab 走,别把输入锁留在别的 tab 上
            }
            if (act) GUI.DrawTexture(R(tx, ty + 26f, tabW, 2f), _accentTex);
        }
        GUI.DrawTexture(R(16f, 52f + (tabRows - 1) * 32f + 28f, ContentW, 1f), _lineTex);

        // ScrollView viewport:顶部 title/tab 下到 底部状态栏上
        // v8.0 tab 分两行时内容区整体下移一行(32px),否则第二行 tab 会被 ScrollView 盖住。
        float tabBottom = 52f + tabRows * 32f + 8f;
        float viewH = H - tabBottom - 36f;
        _viewH = viewH;
        Rect viewport = R(OUTER_PAD, tabBottom, W - OUTER_PAD * 2f, viewH);
        float measuredH = _activeTab == 0 ? _measuredMainH + 20f
            : _activeTab == 1 ? _measuredSaveH + 20f
            : _activeTab == 2 ? _measuredSpawnerH + 20f
            : _activeTab == 5 ? _measuredRecipeH + 20f
            : _measuredTweaksH + 20f;
        bool needScroll = measuredH > viewH + 4f;
        float ch = needScroll ? measuredH : viewH - 2f;
        Rect content  = R(0f, 0f, W - OUTER_PAD * 2f - (needScroll ? 16f : 0f), ch);
        if (!needScroll) _mainScroll = Vector2.zero;
        Ui.Begin(viewport);
        Ui.CardScope = _activeTab;
        _mainScroll = GUI.BeginScrollView(viewport, _mainScroll, content, false, needScroll);

        switch (_activeTab)
        {
            case 0: _measuredMainH = DrawMainTab(s); break;
            case 1: _measuredSaveH = DrawSaveTab(s); break;
            case 2: _measuredSpawnerH = DrawSpawnerTab(s); break;
            case 3: _measuredTweaksH = MenuTweaks.DrawCharacterAndQoLTab(RFunc, s); break;
            case 4: _measuredTweaksH = MenuTweaks.DrawGearTab(RFunc, s); break;
            case 5: _measuredRecipeH = DrawWorldTab(s); break;
            case 6: _measuredTweaksH = MenuTweaks.DrawMapUiTab(RFunc, s); break;
        }
        Ui.EndCards();

        GUI.EndScrollView();

        // 底部状态栏(在 scroll 区外,始终显示)
        // v6.6 GC: 仅在 PositionText/LastActionLog 变化时重建字符串
        {
            var pt = CheatState.PositionText;
            var la = CheatState.LastActionLog;
            if (pt != _cachedPosText || la != _cachedLastAction)
            {
                _cachedPosText   = pt;
                _cachedLastAction = la;
                _cachedStatusBar = $"Pos: {(string.IsNullOrEmpty(pt) ? "-" : pt)}   |   Last: {la}";
            }
        }
        GUI.DrawTexture(R(1f, H - 34f, W - 2f, 1f), _lineTex);
        GUI.Label(R(16f, H - 28f, W - 200f, 22f), _cachedStatusBar, _statusStyle);
        GUI.Label(R(W - 130f, H - 28f, 120f, 22f), I18n.T("↘ 拖拽缩放", "↘ Drag resize"), _mutedLabelStyle);

        // v2.7.91:边缘+角落拖拽调整宽高(宽边缘便于抓取)
        {
            const float edgeW = 20f;
            var e = Event.current;
            float winW = W * _scale, winH = H * _scale;

            if (e.type == EventType.MouseDown && !_resizing)
            {
                bool onRight = e.mousePosition.x >= winW - edgeW && e.mousePosition.y > 50f;
                bool onBottom = e.mousePosition.y >= winH - edgeW;
                if (onRight || onBottom)
                {
                    _resizing = true;
                    _resizeStartMouse = e.mousePosition;
                    var sm = Input.mousePosition;
                    _resizeStartScreenMouse = new Vector2(sm.x, Screen.height - sm.y);
                    _resizeStartW = W;
                    _resizeStartH = H;
                    _resizeEdge = (onRight && onBottom) ? ResizeEdge.Corner
                                : onRight ? ResizeEdge.Right : ResizeEdge.Bottom;
                    e.Use();
                }
            }
            // 视觉:右下角 resize 手柄 + 右边缘/底边缘高亮线
            if (!_resizing)
            {
                GUI.color = new Color(1f, 1f, 1f, 0.15f);
                GUI.DrawTexture(R(W - 3f, 50f, 3f, H - 84f), Texture2D.whiteTexture);
                GUI.DrawTexture(R(0f, H - 3f, W, 3f), Texture2D.whiteTexture);
            }
            else
            {
                GUI.color = new Color(0.4f, 0.7f, 1f, 0.6f);
                if (_resizeEdge == ResizeEdge.Right || _resizeEdge == ResizeEdge.Corner)
                    GUI.DrawTexture(R(W - 3f, 50f, 3f, H - 84f), Texture2D.whiteTexture);
                if (_resizeEdge == ResizeEdge.Bottom || _resizeEdge == ResizeEdge.Corner)
                    GUI.DrawTexture(R(0f, H - 3f, W, 3f), Texture2D.whiteTexture);
            }
            float gx = W - 18f, gy = H - 18f;
            GUI.color = _resizing ? new Color(0.4f, 0.7f, 1f, 0.9f) : new Color(1f, 1f, 1f, 0.4f);
            for (int i = 0; i < 3; i++)
            {
                float o = i * 6f;
                GUI.DrawTexture(R(gx + o, gy + 14f - o, 3f, 3f), Texture2D.whiteTexture);
                GUI.DrawTexture(R(gx + 3f + o, gy + 11f - o, 3f, 3f), Texture2D.whiteTexture);
            }
            GUI.color = Color.white;
        }

        // v2.7.94:自定义拖动启动(标题栏区域点击启动,实际拖动在 Draw() 用屏幕坐标驱动)
        {
            var e = Event.current;
            if (e.type == EventType.MouseDown && !_dragging && !_resizing)
            {
                float mx = e.mousePosition.x / _scale;
                float my = e.mousePosition.y / _scale;
                if (mx < W - 220f && my < 44f)
                {
                    _dragging = true;
                    var sm = Input.mousePosition;
                    _dragStartScreenMouse = new Vector2(sm.x, Screen.height - sm.y);
                    _dragStartWinX = _window.x;
                    _dragStartWinY = _window.y;
                    e.Use();
                }
            }
        }

        if (!_resizing && !_dragging) Ui.EndAndDrawTip(W * _scale, H * _scale);
    }

    // ————————————— Tab 1:主 cheat 面板 —————————————
    // v9.0 三列卡片栅格,列宽随窗口变化;每行两个开关各占半列(TOG_W / TOG2_OFF)
    //   地图/天气/时间 合并到一个 "世界时钟" section
    //   Settings 字段一律保留,兼容旧存档
    private static float DrawMainTab(TldHacksSettings s)
    {
        float c1 = MenuTweaks.ColX(0), c2 = MenuTweaks.ColX(1), c3 = MenuTweaks.ColX(2);
        float y1 = 6f, y2 = 6f, y3 = 6f;

        // ═════════ 列 1:玩家状态 ═════════
        y1 = Section(c1, y1, I18n.T("生存", "Survival"));
        bool god   = Ui.Toggle("GodMode", R(c1,            y1, TOG_W, ROW_H), s.GodMode,          I18n.T(" 无敌模式", " God Mode"));
        bool nfall = Ui.Toggle("NoFallDamage", R(c1 + TOG2_OFF, y1, TOG_W, ROW_H), s.NoFallDamage,     I18n.T(" 无坠落伤害", " No Fall Dmg"));
        y1 += ROW_ADV;
        bool nspr  = Ui.Toggle("NoSprainRisk", R(c1,            y1, TOG_W, ROW_H), s.NoSprainRisk,     I18n.T(" 免扭伤风险", " No Sprain Risk"));
        bool immA  = Ui.Toggle("ImmuneAnimalDamage", R(c1 + TOG2_OFF, y1, TOG_W, ROW_H), s.ImmuneAnimalDamage,I18n.T(" 免动物伤害", " No Animal Dmg"));
        y1 += ROW_ADV;
        bool nsuf  = Ui.Toggle("NoSuffocating", R(c1,            y1, TOG_W, ROW_H), s.NoSuffocating,    I18n.T(" 不会窒息", " No Suffocate"));
        bool cdp   = Ui.Toggle("ClearDeathPenalty", R(c1 + TOG2_OFF, y1, TOG_W, ROW_H), s.ClearDeathPenalty, I18n.T(" 免死亡惩罚", " Clr Death Pen."));
        y1 += ROW_ADV + SECTION_END_ADV;
        if (god != s.GodMode || nfall != s.NoFallDamage || nspr != s.NoSprainRisk
            || immA != s.ImmuneAnimalDamage || nsuf != s.NoSuffocating || cdp != s.ClearDeathPenalty)
        {
            s.GodMode = god; s.NoFallDamage = nfall; s.NoSprainRisk = nspr;
            s.ImmuneAnimalDamage = immA; s.NoSuffocating = nsuf; s.ClearDeathPenalty = cdp;
            // v3.0.4r4: GodMode 隐含 NoFallDamage + NoSprainRisk
            CheatState.GodMode = god;
            CheatState.NoFallDamage = nfall || god;
            CheatState.NoSprainRisk = nspr || god;
            CheatState.ImmuneAnimalDamage = immA; CheatState.NoSuffocating = nsuf; CheatState.ClearDeathPenalty = cdp;
            s.RequestSave();
        }

        y1 = Section(c1, y1, I18n.T("温饱", "Food & Warmth"));
        bool warm  = Ui.Toggle("AlwaysWarm", R(c1,            y1, TOG_W, ROW_H), s.AlwaysWarm, I18n.T(" 始终温暖", " Always Warm"));
        bool nhun  = Ui.Toggle("NoHunger", R(c1 + TOG2_OFF, y1, TOG_W, ROW_H), s.NoHunger,   I18n.T(" 无饥饿", " No Hunger"));
        y1 += ROW_ADV;
        bool nthir = Ui.Toggle("NoThirst", R(c1,            y1, TOG_W, ROW_H), s.NoThirst,   I18n.T(" 无口渴", " No Thirst"));
        bool nfat  = Ui.Toggle("NoFatigue", R(c1 + TOG2_OFF, y1, TOG_W, ROW_H), s.NoFatigue,  I18n.T(" 无疲劳", " No Fatigue"));
        y1 += ROW_ADV;
        bool ista  = Ui.Toggle("InfiniteStamina", R(c1, y1, TOG_W, ROW_H), s.InfiniteStamina, I18n.T(" 无限体力", " Infinite Stamina"));
        y1 += ROW_ADV + SECTION_END_ADV;
        if (warm != s.AlwaysWarm || nhun != s.NoHunger || nthir != s.NoThirst || nfat != s.NoFatigue
            || ista != s.InfiniteStamina)
        {
            s.AlwaysWarm = warm; s.NoHunger = nhun; s.NoThirst = nthir; s.NoFatigue = nfat;
            s.InfiniteStamina = ista;
            CheatState.AlwaysWarm = warm;
            CheatState.NoHunger = nhun; CheatState.NoThirst = nthir; CheatState.NoFatigue = nfat;
            CheatState.InfiniteStamina = ista;
            s.RequestSave();
        }

        // —— Buff / 增益(CT 复刻)——
        y1 = Section(c1, y1, I18n.T("增益", "Buffs"));
        bool nfrost = Ui.Toggle("NoFrostbiteRisk", R(c1,            y1, TOG_W, ROW_H), s.NoFrostbiteRisk, I18n.T(" 免疫冻伤", " No Frostbite"));
        bool wfbuf  = Ui.Toggle("WellFedBuff", R(c1 + TOG2_OFF, y1, TOG_W, ROW_H), s.WellFedBuff,     I18n.T(" 吃得饱饱", " Well Fed"));
        y1 += ROW_ADV;
        bool fzbuf  = Ui.Toggle("FreezingBuff", R(c1,            y1, TOG_W, ROW_H), s.FreezingBuff,    I18n.T(" 加热", " Warming Buff"));
        bool ftbuf  = Ui.Toggle("FatigueBuff", R(c1 + TOG2_OFF, y1, TOG_W, ROW_H), s.FatigueBuff,     I18n.T(" 疲劳减缓", " Less Fatigue"));
        y1 += ROW_ADV;
        // 坏血病状态显示(只读信息)
        // v6.6 GC: 仅在 VitaminC/Status 变化时重建格式化字符串
        // 注:ScurvyManager.GetVitaminCNormalized() 返回 0..1 比例,Threshold 也是 1f,直接显示百分比更直观
        ScurvyViewer.Poll();
        if (ScurvyViewer.VitaminC != _cachedVitC || ScurvyViewer.Status != _cachedScurvyStatus)
        {
            _cachedVitC = ScurvyViewer.VitaminC;
            _cachedScurvyStatus = ScurvyViewer.Status;
            float pct = Mathf.Clamp01(ScurvyViewer.VitaminC) * 100f;
            _cachedScurvyLabel = I18n.IsEnglish
                ? $"  Scurvy: {ScurvyViewer.Status}  VitC={pct:F0}%"
                : $"  坏血病: {ScurvyViewer.Status}  维C={pct:F0}%";
        }
        CLabel(c1, y1, TOG_WIDE, ROW_H, _cachedScurvyLabel, true);
        y1 += ROW_ADV + SECTION_END_ADV;
        if (nfrost != s.NoFrostbiteRisk || wfbuf != s.WellFedBuff
            || fzbuf != s.FreezingBuff || ftbuf != s.FatigueBuff)
        {
            if (s.WellFedBuff && !wfbuf) Cheats.ClearWellFedBuff();
            if (s.FatigueBuff && !ftbuf) Cheats.ClearFatigueBuff();
            s.NoFrostbiteRisk = nfrost; s.WellFedBuff = wfbuf;
            s.FreezingBuff = fzbuf; s.FatigueBuff = ftbuf;
            CheatState.NoFrostbiteRisk = nfrost; CheatState.WellFedBuff = wfbuf;
            CheatState.FreezingBuff = fzbuf; CheatState.FatigueBuff = ftbuf;
            s.RequestSave();
        }

#if !STORY_EDITION
        bool ceChanged = false;
        y1 = MenuTweaks.CardDeathStruggle(RFunc, s, c1, y1, ref ceChanged);
        if (ceChanged) s.RequestSave();
#endif

        // 一键搜刮放左列,三列高度接近
        y1 = Section(c1, y1, I18n.T("一键搜刮", "Grab All Nearby"), I18n.T($"热键 {s.GrabAllKey}", $"Key {s.GrabAllKey}"));
        float grabR = MenuTweaks.DrawSliderCol3(RFunc, c1, y1, I18n.T("半径(米)", "Radius (m)"), s.GrabAllRadius, 1f, 50f, "F0", key: "GrabAllRadius");
        if (Mathf.Abs(grabR - s.GrabAllRadius) > 0.01f) { s.GrabAllRadius = grabR; s.RequestSave(); }
        y1 += ROW_ADV;
        bool grabNotify = Ui.Toggle("GrabAllNotify", R(c1, y1, TOG_W, ROW_H), s.GrabAllNotify,
            I18n.T(" 逐件确认", " Confirm Each"));
        if (grabNotify != s.GrabAllNotify) { s.GrabAllNotify = grabNotify; s.RequestSave(); }
        if (Ui.Button("Act_GrabNow", R(c1 + TOG2_OFF, y1, TOG_W, ROW_H), I18n.T("立即搜刮", "Grab Now")))
            GrabAll.Trigger(s.GrabAllRadius, s.GrabAllNotify);
#if !STORY_EDITION && !EP5_EDITION
        y1 += ROW_ADV;
        bool harvesting = MapHarvest.Active;
        if (Ui.Button("Act_HarvestCarcasses", R(c1, y1, TOG_W, ROW_H), harvesting ? I18n.T("停止采集", "Stop") : I18n.T("采集全图尸体", "All Carcasses")))
            MapHarvest.Trigger(false);
        if (Ui.Button("Act_HarvestPlants", R(c1 + TOG2_OFF, y1, TOG_W, ROW_H), harvesting ? I18n.T("停止采集", "Stop") : I18n.T("采集全图植物", "All Plants")))
            MapHarvest.Trigger(true);
#endif
        y1 += ROW_ADV + SECTION_END_ADV;

        // ═════════ 列 2:世界 & 环境 & 一次性 ═════════
        y2 = Section(c2, y2, I18n.T("动物", "Animals"));
        bool kill    = Ui.Toggle("InstantKillAnimals", R(c2,            y2, TOG_W, ROW_H), s.InstantKillAnimals, I18n.T(" 一击必杀", " One Hit Kill"));
        bool frz     = Ui.Toggle("FreezeAnimals", R(c2 + TOG2_OFF, y2, TOG_W, ROW_H), s.FreezeAnimals,      I18n.T(" 冻结动物", " Freeze Animals"));
        y2 += ROW_ADV;
        bool stealth = Ui.Toggle("Stealth", R(c2,            y2, TOG_W, ROW_H), s.Stealth,            I18n.T(" 动物逃离", " Animals Flee"));
        bool tinv    = Ui.Toggle("TrueInvisible", R(c2 + TOG2_OFF, y2, TOG_W, ROW_H), s.TrueInvisible,      I18n.T(" 完全隐形", " Full Invisible"));
        y2 += ROW_ADV + SECTION_END_ADV;
        if (kill != s.InstantKillAnimals || frz != s.FreezeAnimals || stealth != s.Stealth || tinv != s.TrueInvisible)
        {
            s.InstantKillAnimals = kill; s.FreezeAnimals = frz; s.Stealth = stealth; s.TrueInvisible = tinv;
            CheatState.InstantKillAnimals = kill; CheatState.FreezeAnimals = frz;
            CheatState.Stealth = stealth; CheatState.TrueInvisible = tinv;
            s.RequestSave();
        }

        string[] spawnCmds = { "spawn_wolf", "spawn_bear", "spawn_cougar", "spawn_moose", "spawn_doe", "spawn_stag", "spawn_rabbit", "spawn_ptarmigan" };
        string[] spawnLbls = I18n.IsEnglish
            ? new[] { "Wolf", "Bear", "Cougar", "Moose", "Doe", "Buck", "Rabbit", "Ptarmigan" }
            : new[] { "狼", "熊", "美洲狮", "驼鹿", "母鹿", "雄鹿", "兔", "松鸡" };
        float spW = (TOG_WIDE - 12f) / 4f;
        for (int i = 0; i < spawnCmds.Length; i++)
        {
            int col = i % 4, row = i / 4;
            if (GUI.Button(R(c2 + col * (spW + 4f), y2 + row * ROW_ADV, spW, ROW_H), spawnLbls[i]))
                ConsoleBridge.Run(spawnCmds[i]);
        }
        y2 += ROW_ADV * 2 + SECTION_END_ADV;

        y2 = Section(c2, y2, I18n.T("环境 / 篝火", "Environment / Fire"));
        bool ice  = Ui.Toggle("ThinIceNoBreak", R(c2,            y2, TOG_W, ROW_H), s.ThinIceNoBreak, I18n.T(" 冰面不破", " Thin Ice Safe"));
        bool ftmp = Ui.Toggle("FireTemp300", R(c2 + TOG2_OFF, y2, TOG_W, ROW_H), s.FireTemp300,    I18n.T(" 篝火 300℃", " Fire 300°C"));
        y2 += ROW_ADV;
        bool fnev = Ui.Toggle("FireNeverDie", R(c2,            y2, TOG_W, ROW_H), s.FireNeverDie,   I18n.T(" 篝火永不熄灭", " Fire Never Dies"));
        bool fany = Ui.Toggle("FireAnywhere", R(c2 + TOG2_OFF, y2, TOG_W, ROW_H), s.FireAnywhere,   I18n.T(" 随意生火", " Fire Anywhere"));
        y2 += ROW_ADV;
        bool ffue = Ui.Toggle("FreeFireFuel", R(c2,            y2, TOG_W, ROW_H), s.FreeFireFuel,   I18n.T(" 材料不减", " Free Fuel"));
        bool ftrch= Ui.Toggle("TorchFullValue", R(c2 + TOG2_OFF, y2, TOG_W, ROW_H), s.TorchFullValue, I18n.T(" 火把满值", " Torch Full"));
        y2 += ROW_ADV;
        bool qf   = Ui.Toggle("QuickFire", R(c2,            y2, TOG_W, ROW_H), s.QuickFire,      I18n.T(" 生火必成功", " 100% Fire"));
        bool qfish= Ui.Toggle("QuickFishing", R(c2 + TOG2_OFF, y2, TOG_W, ROW_H), s.QuickFishing,   I18n.T(" 钓鱼必成功", " 100% Fish"));
        y2 += ROW_ADV;
        float fmbh = MenuTweaks.DrawSliderCol3(RFunc, c2, y2, I18n.T("燃烧上限(h)", "Max Burn (h)"), s.FireMaxBurnHours, 12f, 1000f, "F0", key: "FireMaxBurnHours");
        if (fmbh != s.FireMaxBurnHours) { s.FireMaxBurnHours = fmbh; CheatState.FireMaxBurnHours = fmbh; s.RequestSave(); }
        y2 += ROW_ADV + SECTION_END_ADV;
        if (ice != s.ThinIceNoBreak || ftmp != s.FireTemp300 || fnev != s.FireNeverDie
            || fany != s.FireAnywhere || ffue != s.FreeFireFuel || ftrch != s.TorchFullValue
            || qf != s.QuickFire || qfish != s.QuickFishing)
        {
            s.ThinIceNoBreak = ice; s.FireTemp300 = ftmp; s.FireNeverDie = fnev;
            s.FireAnywhere = fany; s.FreeFireFuel = ffue; s.TorchFullValue = ftrch;
            s.QuickFire = qf; s.QuickFishing = qfish;
            CheatState.ThinIceNoBreak = ice; CheatState.FireTemp300 = ftmp; CheatState.FireNeverDie = fnev;
            CheatState.FireAnywhere = fany; CheatState.FreeFireFuel = ffue; CheatState.TorchFullValue = ftrch;
            CheatState.QuickFire = qf; CheatState.QuickFishing = qfish;
            s.RequestSave();
        }

        // 世界时钟 — 地图 + 天气(3行) + 时间(1行)合并一块
        y2 = Section(c2, y2, I18n.T("地图 / 天气 / 时间", "Map / Weather / Time"));
#if STORY_GUARD
        // 剧情版:地图双击传送同样属"传送",按用户决策禁用(全开地图保留)。
        // 天气分级 / 锁天气 / 时间跳跃都是"脚本化时间天气",可跳过或卡死任务触发,
        // 且这几个是一次性按钮(非 CheatState 门控),只能靠灰显拦住点击。全开地图保留(830 行)。
        bool _clockBlocked = StoryGuard.InStory;
        if (_clockBlocked) GUI.enabled = false;
#endif
        bool mtp = Ui.Toggle("MapClickTP", R(c2, y2, TOG_W, ROW_H), s.MapClickTP, I18n.T(" 地图双击传送", " Map Click TP"));
        // v7.7 补 RequestSave:这个开关原先改了不落盘,重启游戏后被 JSON 里的旧值覆盖
        if (mtp != s.MapClickTP) { s.MapClickTP = mtp; CheatState.MapClickTP = mtp; s.RequestSave(); }
        bool wLock = Ui.Toggle("WeatherLock", R(c2 + TOG2_OFF, y2, TOG_W, ROW_H), CheatState.WeatherLocked,
            I18n.T(" 锁定天气", " Lock Weather"), MenuTweaks.ToggleStyle ?? GUI.skin.toggle);
        if (wLock != CheatState.WeatherLocked) CheatState.WeatherLocked = wLock;
        y2 += ROW_ADV + 6f;
        // 天气 / 时间 / 游戏速度三块都是左侧行标签 + 4 列,列上下对齐
        const float rowLblW = 64f;
        float rowBtnX = c2 + rowLblW, rowBtnW = TOG_WIDE - rowLblW;
        const int wPer = 4;
        float wW = (rowBtnW - 4f * (wPer - 1)) / wPer;
        CLabel(c2, y2, rowLblW, ROW_H, I18n.T("天气", "Weather"), true);
        for (int i = 0; i < WeatherStages.Length; i++)
        {
            if (i > 0 && i % wPer == 0) y2 += ROW_ADV;
            if (GUI.Button(R(rowBtnX + (i % wPer) * (wW + 4f), y2, wW, ROW_H), WeatherLabels[i])) Cheats.SetWeatherStage(WeatherStages[i]);
        }
        y2 += ROW_ADV + 6f;
        CLabel(c2, y2, rowLblW, ROW_H, I18n.T("时间", "Time"), true);
        float hW = (rowBtnW - 4f * (HourPresets.Length - 1)) / HourPresets.Length;
        for (int i = 0; i < HourPresets.Length; i++)
        {
            if (GUI.Button(R(rowBtnX + i * (hW + 4f), y2, hW, ROW_H), HourLabels[i])) Cheats.SetTimeOfDay(HourPresets[i]);
        }
#if STORY_GUARD
        if (_clockBlocked) GUI.enabled = true;
#endif
        y2 += ROW_ADV;
        Ui.Hover("SpeedMultiplier", R(c2, y2, rowLblW, ROW_H));
        CLabel(c2, y2, rowLblW, ROW_H, I18n.T("游戏速度", "Speed"), true);
        float spdW = (rowBtnW - 4f * (SpeedPresets.Length - 1)) / SpeedPresets.Length;
        for (int spi = 0; spi < SpeedPresets.Length; spi++)
        {
            float sp = SpeedPresets[spi];
            bool active = Mathf.Abs(s.SpeedMultiplier - sp) < 0.01f;
            if (CBtn(rowBtnX + spi * (spdW + 4f), y2, spdW, ROW_H, SpeedPresetLabels[spi], active))
            { s.SpeedMultiplier = sp; CheatState.SpeedMultiplier = sp; s.RequestSave(); }
        }
        y2 += ROW_ADV + SECTION_END_ADV;

        // ═════════ 列 3:物品 & 武器 ═════════
        y3 = Section(c3, y3, I18n.T("快速操作", "Quick Actions"));
        bool qcook = Ui.Toggle("QuickCook", R(c3,            y3, TOG_W, ROW_H), s.QuickCook,      I18n.T(" 快速烹饪", " Instant Cook"));
        bool nbrn  = Ui.Toggle("NoBurn", R(c3 + TOG2_OFF, y3, TOG_W, ROW_H), s.NoBurn,         I18n.T(" 防止烤焦", " No Burn"));
        y3 += ROW_ADV;
        bool qsrch = Ui.Toggle("QuickSearch", R(c3,            y3, TOG_W, ROW_H), s.QuickSearch,    I18n.T(" 快速搜刮", " Instant Loot"));
        bool qhv   = Ui.Toggle("QuickHarvest", R(c3 + TOG2_OFF, y3, TOG_W, ROW_H), s.QuickHarvest,   I18n.T(" 快速割肉", " Instant Harvest"));
        y3 += ROW_ADV;
        bool qbd   = Ui.Toggle("QuickBreakDown", R(c3,            y3, TOG_W, ROW_H), s.QuickBreakDown, I18n.T(" 快速拆解", " Quick Break"));
        bool qev   = Ui.Toggle("QuickEvolve", R(c3 + TOG2_OFF, y3, TOG_W, ROW_H), s.QuickEvolve,    I18n.T(" 快速风干", " Quick Cure"));
        y3 += ROW_ADV;
        bool qcl   = Ui.Toggle("QuickClimb", R(c3,            y3, TOG_W, ROW_H), s.QuickClimb,     I18n.T(" 快速爬绳", " Fast Climb"));
        // 原名"操作自动加速":管采集植物 / 割肉切块 / 修理 / 长按类交互的进度,开着就立刻完成
        bool qa    = Ui.Toggle("QuickAction", R(c3 + TOG2_OFF, y3, TOG_W, ROW_H), s.QuickAction,    I18n.T(" 操作加速", " Auto Speed-up"));
        y3 += ROW_ADV + SECTION_END_ADV;
        if (qcook != s.QuickCook || nbrn != s.NoBurn || qsrch != s.QuickSearch || qhv != s.QuickHarvest
            || qbd != s.QuickBreakDown || qev != s.QuickEvolve || qcl != s.QuickClimb
            || qa != s.QuickAction)
        {
            s.QuickCook = qcook; s.NoBurn = nbrn; s.QuickSearch = qsrch; s.QuickHarvest = qhv;
            s.QuickBreakDown = qbd; s.QuickEvolve = qev; s.QuickClimb = qcl;
            s.QuickAction = qa;
            CheatState.QuickCook = qcook; CheatState.NoBurn = nbrn;
            CheatState.QuickSearch = qsrch; CheatState.QuickHarvest = qhv;
            CheatState.QuickBreakDown = qbd; CheatState.QuickEvolve = qev;
            CheatState.QuickClimb = qcl; CheatState.QuickAction = qa;
            s.RequestSave();
        }

        // —— 制作 & 修理(操作类,与快速操作语义同源) ——
        y3 = Section(c3, y3, I18n.T("制作 & 修理", "Crafting & Repair"));
        bool fc = Ui.Toggle("FreeCraft", R(c3,            y3, TOG_W, ROW_H), s.FreeCraft,  I18n.T(" 免费制作", " Free Craft"));
        bool qk = Ui.Toggle("QuickCraft", R(c3 + TOG2_OFF, y3, TOG_W, ROW_H), s.QuickCraft, I18n.T(" 快速制作", " Quick Craft"));
        y3 += ROW_ADV;
        bool fr = Ui.Toggle("FreeRepair", R(c3,            y3, TOG_W, ROW_H), s.FreeRepair, I18n.T(" 免费修理", " Free Repair"));
        // v9.0 从「物资 & 世界」挪来:它改的是蓝图的制作地点要求,和这一组语义一致
        bool ca = Ui.Toggle("Craft_Anywhere", R(c3 + TOG2_OFF, y3, TOG_W, ROW_H), s.Craft_Anywhere, I18n.T(" 随地制作", " Craft Anywhere"));
        y3 += ROW_ADV + SECTION_END_ADV;
        if (fc != s.FreeCraft || qk != s.QuickCraft || fr != s.FreeRepair || ca != s.Craft_Anywhere)
        {
            s.FreeCraft = fc; s.QuickCraft = qk; s.FreeRepair = fr; s.Craft_Anywhere = ca;
            CheatState.FreeCraft = fc; CheatState.QuickCraft = qk; CheatState.FreeRepair = fr;
            CheatState.Craft_Anywhere = ca;
            s.RequestSave();
        }

        // —— 锁 & 容器 ——
        y3 = Section(c3, y3, I18n.T("锁 & 容器", "Locks & Containers"));
        bool lok  = Ui.Toggle("IgnoreLock", R(c3,            y3, TOG_W, ROW_H), s.IgnoreLock,         I18n.T(" 忽略上锁", " Ignore Locks"));
        bool qc   = Ui.Toggle("QuickOpenContainer", R(c3 + TOG2_OFF, y3, TOG_W, ROW_H), s.QuickOpenContainer, I18n.T(" 秒开容器", " Quick Open"));
        y3 += ROW_ADV;
        bool usaf = Ui.Toggle("UnlockSafes", R(c3,            y3, TOG_W, ROW_H), s.UnlockSafes,        I18n.T(" 解锁保箱", " Unlock Safes"));
        bool tbag = Ui.Toggle("TechBackpack", R(c3 + TOG2_OFF, y3, TOG_W, ROW_H), s.TechBackpack,       I18n.T(" 背包负重", " Carry Cap"));
        y3 += ROW_ADV;
        float tbagKg = s.TechBackpackKg;
        if (tbag)
        {
            tbagKg = MenuTweaks.DrawSliderCol3(RFunc, c3, y3, I18n.T("上限(kg)", "Max (kg)"), s.TechBackpackKg, 10f, 10000f, "F0", key: "TechBackpackKg");
            y3 += ROW_ADV;
        }
        bool infCon = Ui.Toggle("InfiniteContainer", R(c3, y3, TOG_W, ROW_H), s.InfiniteContainer, I18n.T(" 容器无限", " Inf. Container"));
        y3 += ROW_ADV + SECTION_END_ADV;
        if (lok != s.IgnoreLock || qc != s.QuickOpenContainer || usaf != s.UnlockSafes
            || tbag != s.TechBackpack || infCon != s.InfiniteContainer || tbagKg != s.TechBackpackKg)
        {
            bool wasOn = s.TechBackpack;
            s.IgnoreLock = lok; s.QuickOpenContainer = qc; s.UnlockSafes = usaf;
            s.TechBackpack = tbag; s.InfiniteContainer = infCon; s.TechBackpackKg = tbagKg;
            CheatState.IgnoreLock = lok; CheatState.QuickOpenContainer = qc; CheatState.UnlockSafes = usaf;
            CheatState.TechBackpack = tbag; CheatState.InfiniteContainer = infCon; CheatState.TechBackpackKg = tbagKg;
            if (wasOn && !tbag) EncumberVanilla.Reset();
            s.RequestSave();
        }

        // v2.7.91 "武器 & 瞄准"
        y3 = Section(c3, y3, I18n.T("武器 & 瞄准", "Weapons & Aiming"));
        bool amm  = Ui.Toggle("InfiniteAmmo", R(c3,            y3, TOG_W, ROW_H), s.InfiniteAmmo,   I18n.T(" 无限弹药", " Infinite Ammo"));
        bool jam  = Ui.Toggle("NoJam", R(c3 + TOG2_OFF, y3, TOG_W, ROW_H), s.NoJam,          I18n.T(" 永不卡壳", " No Jam"));
        y3 += ROW_ADV;
        bool rec  = Ui.Toggle("NoRecoil", R(c3,            y3, TOG_W, ROW_H), s.NoRecoil,       I18n.T(" 无后坐力", " No Recoil"));
        bool nstam= Ui.Toggle("NoAimStamina", R(c3 + TOG2_OFF, y3, TOG_W, ROW_H), s.NoAimStamina,   I18n.T(" 瞄准不耗体力", " No Aim Stamina"));
        y3 += ROW_ADV;
        bool sway = Ui.Toggle("NoAimSway", R(c3,            y3, TOG_W, ROW_H), s.NoAimSway,      I18n.T(" 稳定瞄准", " Steady Aim"));
        bool magic= Ui.Toggle("MagicBullet", R(c3 + TOG2_OFF, y3, TOG_W, ROW_H), s.MagicBullet,    I18n.T(" 魔法子弹", " Magic Bullet"));
        y3 += ROW_ADV;
        bool sacc = Ui.Toggle("SuperAccuracy", R(c3, y3, TOG_W, ROW_H), s.SuperAccuracy, I18n.T(" 超级精准", " Super Accuracy"));
        y3 += ROW_ADV + SECTION_END_ADV;
        if (amm != s.InfiniteAmmo || jam != s.NoJam || rec != s.NoRecoil || sacc != s.SuperAccuracy
            || sway != s.NoAimSway || nstam != s.NoAimStamina || magic != s.MagicBullet)
        {
            s.InfiniteAmmo = amm; s.NoJam = jam; s.NoRecoil = rec; s.SuperAccuracy = sacc;
            s.NoAimSway = sway; s.NoAimStamina = nstam; s.MagicBullet = magic;
            CheatState.InfiniteAmmo = amm; CheatState.NoJam = jam; CheatState.NoRecoil = rec; CheatState.SuperAccuracy = sacc;
            CheatState.NoAimSway = sway; CheatState.NoAimStamina = nstam;
            CheatStateESP.MagicBullet = magic;
            s.RequestSave();
        }

        return Mathf.Max(y1, Mathf.Max(y2, y3));
    }

    // ————————————— Tab:存档修改 —————————————
    // 点一次就完事的操作和存档数据都在这页,主页只留常开常关的开关。
    // c1 技能 / 一次性操作 / 清图 & 任务 | c2+c3 食谱、勋章(都横跨两列)
    private static float DrawSaveTab(TldHacksSettings s)
    {
        float c1 = MenuTweaks.ColX(0), c2 = MenuTweaks.ColX(1), c3 = MenuTweaks.ColX(2);
        float y1 = 6f, y3 = 6f;
        bool changed = false;

        y1 = Section(c1, y1, I18n.T("技能", "Skills"));
        if (GUI.Button(R(c1, y1, TOG_WIDE, ROW_H), I18n.T("全部满级", "All Max")))
            Skills.SetAllMax();
        y1 += ROW_ADV;
        // 按钮组 144px 贴右边,标签占剩下的宽度
        float sb = c1 + TOG_WIDE - 144f;
        void SkillRow(string label, Skill sk, string id)
        {
            GUI.Label (R(c1 + 4f,     y1, sb - c1 - 8f, ROW_H), label);
            // v7.1 逐级 - / Lv N / + ,保留"满"
            if (GUI.Button(R(sb,      y1, 26f,  ROW_H), "-")) Skills.StepTier(sk, -1, id);
            var _prevA = _mutedLabelStyle.alignment;
            _mutedLabelStyle.alignment = UnityEngine.TextAnchor.MiddleCenter;
            GUI.Label (R(sb + 28f,    y1, 40f,  ROW_H), "Lv " + Skills.GetTierNumber(sk), _mutedLabelStyle);
            _mutedLabelStyle.alignment = _prevA;
            if (GUI.Button(R(sb + 70f,  y1, 26f, ROW_H), "+")) Skills.StepTier(sk, +1, id);
            if (GUI.Button(R(sb + 100f, y1, 44f, ROW_H), I18n.T("满", "Max"))) Skills.SetMax(sk, id);
            y1 += ROW_ADV;
        }
        var sm = GameManager.GetSkillsManager();
        for (int i = 0; i < Skills.All.Length; i++)
        {
            var (lbl, lblEn, t) = Skills.All[i];
            Skill sk = null;
            try { sk = sm?.GetSkill(t); } catch { }
            SkillRow(I18n.T(lbl, lblEn), sk, t.ToString());
        }
        Skills.RefreshCustom();
        foreach (var (lbl, lblEn, sk) in Skills.Custom) SkillRow(I18n.T(lbl, lblEn), sk, lblEn);
        y1 += SECTION_END_ADV;

        y1 = Section(c1, y1, I18n.T("一次性操作", "One-shot Actions"));
        if (Ui.Button("Act_ClearAfflictions", R(c1,            y1, TOG_W, ROW_H), I18n.T("清除所有负面", "Clear Afflictions"))) Cheats.ClearAllAfflictions();
        if (Ui.Button("Act_RepairHeld",       R(c1 + TOG2_OFF, y1, TOG_W, ROW_H), I18n.T("修复手持", "Repair Held")))            Cheats.RepairItemInHands();
        y1 += ROW_ADV;
        if (Ui.Button("Act_RepairBag",        R(c1,            y1, TOG_W, ROW_H), I18n.T("修复背包", "Repair Inventory")))       QuickActions.RepairAllInventory();
        if (Ui.Button("Act_RestoreAll",       R(c1 + TOG2_OFF, y1, TOG_W, ROW_H), I18n.T("恢复全部耐久", "Restore Durability"))) Cheats.RestoreAllSceneGear();
        y1 += ROW_ADV;
        if (Ui.Button("Act_UnlockFeats",      R(c1,            y1, TOG_W, ROW_H), I18n.T("一键解锁勋章", "Unlock Feats")))       Feats.UnlockAllFeats();
        if (Ui.Button("Act_RevealMap",        R(c1 + TOG2_OFF, y1, TOG_W, ROW_H), I18n.T("全开地图", "Reveal Map")))           Cheats.RevealFullMap();
#if !STORY_EDITION
        y1 += ROW_ADV;
        if (Ui.Button("Act_RestoreLives",     R(c1,            y1, TOG_W, ROW_H), I18n.T("恢复火堆", "Restore Campfires")))  Cheats.RestoreLives();
#endif
        y1 += ROW_ADV + SECTION_END_ADV;

#if !STORY_EDITION
        y1 = Section(c1, y1, I18n.T("清图 & 任务", "Map Clear & Tales"));
        // 点两次才执行的按钮:等第二下的 4 秒里按钮变红、换成确认字样
        string confirm = I18n.T("再点一次确认", "Click to confirm");
        bool armMap = MapClear.IsArmed(false), armMis = MapClear.IsArmed(true);
        if (Ui.Button("Act_ClearMap", R(c1, y1, TOG_W, ROW_H), armMap ? confirm : I18n.T("一键清图", "Clear Map"),
                armMap ? _buttonConfirmStyle : null))
            MapClear.Trigger(false);
        if (Ui.Button("Act_ClearMapMission", R(c1 + TOG2_OFF, y1, TOG_W, ROW_H), armMis ? confirm : I18n.T("清任务物品", "Mission Items"),
                armMis ? _buttonConfirmStyle : null))
            MapClear.Trigger(true);
        y1 += ROW_ADV;
        bool armTales = TalesComplete.IsArmed();
        if (Ui.Button("Act_TalesFinish", R(c1, y1, TOG_W, ROW_H), armTales ? confirm : I18n.T("完成DLC任务", "Finish DLC Tales"),
                armTales ? _buttonConfirmStyle : null))
            TalesComplete.Trigger();
        if (Ui.Button("Act_TalesRewards", R(c1 + TOG2_OFF, y1, TOG_W, ROW_H), I18n.T("任务奖励", "Tale Rewards")))
            TalesComplete.GiveRewards();
        y1 += ROW_ADV + SECTION_END_ADV;
#endif

#if !STORY_EDITION
        // 2.24 无 Il2CppTLD.Cooking,整个食谱系统(Recipes/RecipeNameZh)已排除
        y3 = MenuTweaks.SectionCol(RFunc, c2, y3, c3 - c2 + MenuTweaks.COL_W3, I18n.T("食谱 (含 DLC)", "Recipes (incl. DLC)"));
        if (GUI.Button(R(c2, y3, MenuTweaks.HALF_W, ROW_H), I18n.T("全部解锁", "Unlock All")))
            Recipes.UnlockAll();
        if (GUI.Button(R(c2 + MenuTweaks.HALF_OFF, y3, MenuTweaks.HALF_W, ROW_H), I18n.T("刷新列表", "Refresh")))
            Recipes.Refresh();
        y3 += ROW_ADV;

        var rs = Recipes.All;
        // 进 tab 时自动拉取;没进存档时每 2 秒重试一次,不刷日志
        if (rs.Count == 0 && Time.unscaledTime >= _recipeRetryAt)
        {
            _recipeRetryAt = Time.unscaledTime + 2f;
            Recipes.Refresh(true);
            rs = Recipes.All;
        }
        // 切场景后缓存条目会被销毁,每秒查一次,发现就整表重拉
        if (rs.Count > 0 && Time.unscaledTime >= _recipeCheckAt)
        {
            _recipeCheckAt = Time.unscaledTime + 1f;
            if (Recipes.HasDestroyed()) { Recipes.Refresh(true); rs = Recipes.All; }
        }
        if (rs.Count == 0)
        {
            GUI.Label(R(c2, y3, MenuTweaks.COL_W3, ROW_H),
                I18n.T("进入存档后才能看到食谱", "Load a save to see the recipes"), _mutedLabelStyle);
            y3 += ROW_ADV;
        }
        else
        {
            const float btnW = 80f;
            float nameW = MenuTweaks.COL_W3 - btnW - 6f;
            int rows = (rs.Count + 1) / 2;
            for (int i = 0; i < rs.Count; i++)
            {
                var rd = rs[i];
                float cx = i < rows ? c2 : c3;
                float ry = y3 + (i % rows) * ROW_ADV;
                float bx = cx + MenuTweaks.COL_W3 - btnW;
                GUI.Label(R(cx, ry, nameW, ROW_H), Recipes.NameAt(i), _rowLabelStyle);
                if (Recipes.IsUnlocked(rd))
                {
                    var prevA = _mutedLabelStyle.alignment;
                    _mutedLabelStyle.alignment = TextAnchor.MiddleCenter;
                    GUI.Label(R(bx, ry, btnW, ROW_H), I18n.T("已解锁", "Unlocked"), _mutedLabelStyle);
                    _mutedLabelStyle.alignment = prevA;
                }
                else if (GUI.Button(R(bx, ry, btnW, ROW_H), I18n.T("解锁", "Unlock")))
                    Recipes.Unlock(rd);
            }
            y3 += rows * ROW_ADV;
        }
        y3 += SECTION_END_ADV;
#endif

#if !STORY_EDITION && !EP5_EDITION
        y3 = DrawFeats(s, c2, c3, y3, ref changed);
#endif
        if (changed) s.RequestSave();
        return Mathf.Max(y1, y3);
    }

    // ————————————— Tab:世界 & 饮食 —————————————
    // c1 汽水/鹿肉出肉量/野外 | c2 商人&美洲狮/容器&极光 | c3 高级微调/烹饪位
    private static float DrawWorldTab(TldHacksSettings s)
    {
        float c1 = MenuTweaks.ColX(0), c2 = MenuTweaks.ColX(1), c3 = MenuTweaks.ColX(2);
        float y = 6f, y2 = 6f, y3 = 6f;
        bool changed = false;
        bool b;
        float v;

        // ═══ 含咖啡因汽水(原在装备&世界,v7.2 挪到本页) ═══
        y = MenuTweaks.SectionCol(RFunc, c1, y, MenuTweaks.COL_W3, I18n.T("含咖啡因汽水", "Caffeinated Sodas"),
            "World_CaffeinatedSodas", ref s.World_CaffeinatedSodas, ref changed);
        _worldSodaExpanded = MenuTweaks.Expander(RFunc, c1, y, _worldSodaExpanded, "汽水参数", "Soda Params");
        y += ROW_ADV;
        if (_worldSodaExpanded)
        {
            y = SodaRows(c1, y, I18n.T(" 橙味", " Orange"), ref s.World_SodaOrangeEnabled,
                         ref s.World_SodaOrangeInitial, ref s.World_SodaOrangeDuration, ref changed);
            y = SodaRows(c1, y, I18n.T(" 尖峰苏打", " Summit"), ref s.World_SodaSummitEnabled,
                         ref s.World_SodaSummitInitial, ref s.World_SodaSummitDuration, ref changed);
            y = SodaRows(c1, y, I18n.T(" 葡萄味", " Grape"), ref s.World_SodaGrapeEnabled,
                         ref s.World_SodaGrapeInitial, ref s.World_SodaGrapeDuration, ref changed);
        }
        y += SECTION_END_ADV;

        // ═══ 狩猎·出肉量(原在装备&世界 c3,v7.5 挪到本页) ═══
        y = MenuTweaks.SectionCol(RFunc, c1, y, MenuTweaks.COL_W3, I18n.T("鹿肉出肉量", "Deer Meat Yield"));
        v = MenuTweaks.DrawSliderCol3(RFunc, c1, y, I18n.T("倍率下限", "Mult Min"), s.DeerMeatMultMin, 0f, 5f, "F2", key: "DeerMeatMultMin");
        if (v != s.DeerMeatMultMin) { s.DeerMeatMultMin = v; MeatState.DeerMin = v; changed = true; }
        y += ROW_ADV;
        v = MenuTweaks.DrawSliderCol3(RFunc, c1, y, I18n.T("倍率上限", "Mult Max"), s.DeerMeatMultMax, 0f, 5f, "F2", key: "DeerMeatMultMax");
        if (v != s.DeerMeatMultMax) { s.DeerMeatMultMax = v; MeatState.DeerMax = v; changed = true; }
        y += ROW_ADV + SECTION_END_ADV;

#if !STORY_EDITION
        y = MenuTweaks.CardOutdoors(RFunc, s, c1, y, ref changed);
#endif
        y2 = MenuTweaks.CardTrader(RFunc, s, c2, y2, ref changed);
#if !STORY_EDITION
        y2 = MenuTweaks.CardContainersAurora(RFunc, s, c2, y2, ref changed);
#endif
        y3 = MenuTweaks.CardAdvanced(RFunc, s, c3, y3, ref changed);

        y3 = MenuTweaks.SectionCol(RFunc, c3, y3, MenuTweaks.COL_W3, I18n.T("烹饪位扩展", "Cooking Slots"),
            "Craft_MoreCookingSlots", ref s.Craft_MoreCookingSlots, ref changed);
        float tw = MenuTweaks.THIRD_W, to = MenuTweaks.THIRD_OFF;
        b = Ui.Toggle("Craft_MoreSlots_Fireplace", R(c3, y3, tw, ROW_H), s.Craft_MoreSlots_Fireplace,
            I18n.T(" 壁炉", " Fireplace"), MenuTweaks.ToggleStyle ?? GUI.skin.toggle);
        if (b != s.Craft_MoreSlots_Fireplace) { s.Craft_MoreSlots_Fireplace = b; changed = true; }
        b = Ui.Toggle("Craft_MoreSlots_Barrel", R(c3 + to, y3, tw, ROW_H), s.Craft_MoreSlots_Barrel,
            I18n.T(" 油桶", " Barrel"), MenuTweaks.ToggleStyle ?? GUI.skin.toggle);
        if (b != s.Craft_MoreSlots_Barrel) { s.Craft_MoreSlots_Barrel = b; changed = true; }
        b = Ui.Toggle("Craft_MoreSlots_Grill", R(c3 + 2f * to, y3, tw, ROW_H), s.Craft_MoreSlots_Grill,
            I18n.T(" 烤架", " Grill"), MenuTweaks.ToggleStyle ?? GUI.skin.toggle);
        if (b != s.Craft_MoreSlots_Grill) { s.Craft_MoreSlots_Grill = b; changed = true; }
        y3 += ROW_ADV + SECTION_END_ADV;

        if (changed) s.RequestSave();
        return Mathf.Max(y, Mathf.Max(y2, y3));
    }

#if !STORY_EDITION && !EP5_EDITION
    private static bool _featBonusExpanded;

    // 勋章:当前存档逐个启用 + 加成数值。启用状态直接读存档里的列表,不进 TldHacks.json
    // 紧跟在食谱下面,同样横跨第 2、3 列
    private static float DrawFeats(TldHacksSettings s, float xa, float xb, float y, ref bool changed)
    {
        float hw = MenuTweaks.HALF_W, ho = MenuTweaks.HALF_OFF, cw = MenuTweaks.COL_W3;
        y = MenuTweaks.SectionCol(RFunc, xa, y, xb - xa + cw, I18n.T("勋章 (当前存档)", "Feats (This Save)"));
        bool all = Ui.Toggle("Feat_AllAtNewGame", R(xa, y, cw, ROW_H), s.Feat_AllAtNewGame,
            I18n.T(" 新档勋章槽位选满", " Fill All Feat Slots in New Game"));
        if (all != s.Feat_AllAtNewGame) { s.Feat_AllAtNewGame = all; changed = true; }

        if (!FeatsSandbox.Ready())
        {
            GUI.Label(R(xb, y, cw, ROW_H),
                I18n.T("进入存档后才能开关勋章", "Load a save to set the feats"), _mutedLabelStyle);
            return y + ROW_ADV + SECTION_END_ADV;
        }

        if (Ui.Button("Feat_EnableAll", R(xb, y, hw, ROW_H), I18n.T("全部启用", "Enable All"))) FeatsSandbox.SetAll(true);
        if (Ui.Button("Feat_DisableAll", R(xb + ho, y, hw, ROW_H), I18n.T("全部取消", "Disable All"))) FeatsSandbox.SetAll(false);
        y += ROW_ADV;

        // 一行四个:第 2 列两个、第 3 列两个
        var types = FeatsSandbox.Types;
        float[] xs = { xa, xa + ho, xb, xb + ho };
        for (int i = 0; i < types.Length; i++)
        {
            bool on = FeatsSandbox.IsEnabled(types[i]);
            bool nv = Ui.Toggle("Feat_Enable", R(xs[i % 4], y, hw, ROW_H), on, " " + FeatsSandbox.NameAt(i));
            if (nv != on) FeatsSandbox.SetEnabled(types[i], nv);
            if (i % 4 == 3 || i == types.Length - 1) y += ROW_ADV;
        }

        _featBonusExpanded = MenuTweaks.Expander(RFunc, xa, y, _featBonusExpanded, "加成数值", "Bonus Values");
        if (_featBonusExpanded &&
            Ui.Button("Feat_BonusReset", R(xb, y, cw, ROW_H), I18n.T("恢复原版数值", "Restore Vanilla Values")))
        {
            FeatsSandbox.ResetAll(s);
            changed = true;
        }
        y += ROW_ADV;
        if (_featBonusExpanded)
        {
            // 同一个勋章的滑条排在一起,整组放进当前较矮的那一列
            var ps = FeatsSandbox.Params;
            float ya = y, yb = y;
            for (int i = 0; i < ps.Length; )
            {
                int ti = Array.IndexOf(types, ps[i].Type);
                bool left = ya <= yb;
                float x = left ? xa : xb, yy = left ? ya : yb;
                GUI.Label(R(x, yy, cw, ROW_H), FeatsSandbox.NameAt(ti), _rowLabelStyle);
                yy += ROW_ADV;
                for (; i < ps.Length && ps[i].Type == types[ti]; i++)
                {
                    var p = ps[i];
                    float cur = FeatsSandbox.Shown(p, s);
                    float v = MenuTweaks.DrawSliderCol3(RFunc, x, yy, I18n.T(p.Zh, p.En), cur, p.Min, p.Max, p.Fmt, key: "Feat_Bonus");
                    if (p.IsInt) v = Mathf.Round(v);
                    if (v != cur) { FeatsSandbox.PutSetting(p, s, v); FeatsSandbox.ApplyOne(p, s); changed = true; }
                    yy += ROW_ADV;
                }
                if (left) ya = yy; else yb = yy;
            }
            y = Mathf.Max(ya, yb);
        }
        return y + SECTION_END_ADV;
    }
#endif

    // ————————————— Tab 2:物品刷出 + 传送 —————————————
    // v2.7.28 重排:15 个传送目的地改 5 列 × 3 行;Item Spawner 2 列 × 3 行(6/页)→ 3 列 × 6 行(18/页)
    private static float DrawSpawnerTab(TldHacksSettings s)
    {
        float y = 6f;
        // v8.0 本 tab 原先用 W-20 / W-30 / W-40 当可用宽度,但 ScrollView 的内容矩形只有
        //   W - OUTER_PAD*2 - 16 ≈ W-48。于是类别 tab 行、分割线、物品 4 列的最右边一直被
        //   viewport 裁掉一截(窗口越窄越明显,且没有横向滚动条能拉出来)。
        //   统一改成 aw = ContentW - 10(留出本 tab 自己的 10px 左缩进)。
        float aw = ContentW - 2f * PAD;

        y = SectionWide(y, I18n.IsEnglish
            ? $"Quick Teleport ({Teleport.Destinations.Count})"
            : $"快速传送 ({Teleport.Destinations.Count} 个目的地)");
#if STORY_GUARD
        // 剧情版:跨场景传送会软锁剧情 / 写坏脚本存档,按用户决策禁用整组目的地按钮。
        bool _tpBlocked = StoryGuard.InStory;
        if (_tpBlocked) GUI.enabled = false;
#endif
        // 目的地放进内层滚动区,滚轮翻;可见高度由下面的分割栏拖动决定
        int teleCols = aw >= 950f ? 5 : aw >= 640f ? 3 : 2;
        float fullH = ROW_ADV * ((Teleport.Destinations.Count + teleCols - 1) / teleCols);
        float teleH = Mathf.Clamp(s.SpawnerTeleportH, ROW_ADV, Mathf.Max(ROW_ADV, fullH));
        bool teleBar = fullH > teleH + 1f;
        float teleCW = aw - (teleBar ? 16f : 0f);
        float teleW = teleCW / teleCols;
        _teleScroll = GUI.BeginScrollView(R(10f, y, aw, teleH), _teleScroll,
            new Rect(0f, 0f, teleCW * _scale, fullH * _scale), false, teleBar);
        for (int i = 0; i < Teleport.Destinations.Count; i++)
        {
            var d = Teleport.Destinations[i];
            float tx = (i % teleCols) * teleW;
            float ty = (i / teleCols) * ROW_ADV;
            // 内层坐标不走 R():R 会按外层坐标去撑卡片高度
            if (GUI.Button(new Rect(tx * _scale, ty * _scale, (teleW - 4f) * _scale, ROW_H * _scale), $"→ {d.DisplayLabel}"))
                Teleport.TravelTo(d);
        }
        GUI.EndScrollView();
        y += teleH + SECTION_END_ADV;
#if STORY_GUARD
        if (_tpBlocked) GUI.enabled = true;   // 位置控制按钮(打印坐标等)不受影响
#endif

        // 位置控制行 —— v2.7.55 "打印位置到 log" 按钮:在 Latest.log 留 [POS-MARK],mod 作者可回读坐标
        if (GUI.Button(R(10f, y, 160f, ROW_H), I18n.T("控制台坐标", "uConsole pos")))    ConsoleBridge.Run("pos");
        if (GUI.Button(R(180f, y, 160f, ROW_H), I18n.T("刷新位置显示", "Refresh Pos")))   Cheats.UpdatePlayerPosition();
        if (GUI.Button(R(350f, y, 200f, ROW_H), I18n.T("★ 打印坐标到 log", "★ Print Pos to Log"))) Cheats.PrintPositionToLog();
        GUI.Label(R(560f, y, Mathf.Max(80f, aw - 550f), ROW_H),
            I18n.IsEnglish
                ? $"Current: {(string.IsNullOrEmpty(CheatState.PositionText) ? "(none)" : CheatState.PositionText)}"
                : $"当前:{(string.IsNullOrEmpty(CheatState.PositionText) ? "(未获取)" : CheatState.PositionText)}",
            _rowLabelStyle);
        DrawTeleportSplitter(s, y + ROW_H + Ui.CARD_PAD, y + ROW_ADV + SECTION_END_ADV, fullH);
        y += ROW_ADV + SECTION_END_ADV;

        float headY = y;   // 搜索框画在这张卡片的标题栏右端,不占内容行
        y = SectionWide(y, I18n.IsEnglish
            ? $"Item Spawner ({ItemDatabase.All.Count + ItemDatabaseMod.All.Count + Furniture.Count} items)"
            : $"物品生成器 ({ItemDatabase.All.Count + ItemDatabaseMod.All.Count + Furniture.Count} 条)");
        DrawItemSearchBox(headY);

        // 类别 tabs (全 9 个平铺)
        float catW = aw / ItemDatabase.Categories.Length;
        for (int i = 0; i < ItemDatabase.Categories.Length; i++)
        {
            string lbl = ItemDatabase.DisplayCategory(i);
            if (CBtn(10f + i * catW, y, catW - 2f, ROW_H, lbl, i == _selectedCategory))
            {
                if (_selectedCategory != i) { _selectedCategory = i; _page = 0; }
            }
        }
        y += ROW_ADV + SECTION_END_ADV;

        // 数量预设 (v6.6: 预缓存标签,零运行时 alloc)
        GUI.Label(R(10f, y, 60f, ROW_H), I18n.T("数量:", "Qty:"), _rowLabelStyle);
        float bx = 70f;
        for (int i = 0; i < QuantityPresets.Length; i++)
        {
            if (CBtn(bx, y, 70f, ROW_H, QuantityPresetLabels[i], _quantity == QuantityPresets[i])) _quantity = QuantityPresets[i];
            bx += 75f;
        }
        // 数量标签:仅在 _quantity 变化时重建
        if (_quantity != _cachedQtyValue)
        {
            _cachedQtyValue    = _quantity;
            _cachedQtyLabel    = $"Now: {_quantity}";
            _cachedQtyLabelZh  = $"当前: {_quantity}";
            _cachedSpawnBtnLabel = $"+×{_quantity}";
        }
        GUI.Label(R(bx + 10f, y, 140f, ROW_H), I18n.IsEnglish ? _cachedQtyLabel : _cachedQtyLabelZh, _rowLabelStyle);
        y += ROW_ADV + SECTION_END_ADV;

        if (_lastCat != _selectedCategory || _lastSearch != _search) { RebuildFilter(); _lastCat = _selectedCategory; }
        // 搜出空结果是正常状态,不能走这条兜底重算 —— 否则每帧全库重扫
        else if (_filtered.Count == 0 && _search.Length == 0 && (ItemDatabase.All.Count + ItemDatabaseMod.All.Count) > 0) { RebuildFilter(); }

        const int cols = 4;
        float availH = _viewH - y - ROW_ADV * 2f - SECTION_END_ADV - 10f;
        _pageRows = Mathf.Max(4, (int)(availH / ROW_ADV));
        _pageSize = _pageRows * cols;

        int totalPages = Mathf.Max(1, (_filtered.Count + _pageSize - 1) / _pageSize);
        _page = Mathf.Clamp(_page, 0, totalPages - 1);
        int start = _page * _pageSize;
        int end = Mathf.Min(start + _pageSize, _filtered.Count);

        float colW = aw / cols;
        float btnW = 56f;
        var spawnBtnLabel = _cachedSpawnBtnLabel; // 局部引用,避免每次 static 读
        var rowStyle = _rowLabelStyle ?? GUI.skin.label;
        for (int idx = start; idx < end; idx++)
        {
            int i = idx - start;
            int col = i % cols, row = i / cols;
            float x = 10f + col * colW;
            float yy = y + row * ROW_ADV;
            var e = _filtered[idx];
            // 说明按 prefab 名查 MenuUi 的补充表,没写说明的物品不弹提示
            Ui.Hover(e.PrefabName, R(x, yy, colW - 8f, ROW_H));
            if (GUI.Button(R(x, yy, btnW, ROW_H), spawnBtnLabel))
            {
                if (e.Category == "家具") Furniture.Spawn(e, _quantity);
                else Cheats.SpawnItem(e.PrefabName, _quantity);
            }
            // v6.6 GC: 利用 ItemEntry 上预缓存的显示名+卡路里标签(见 RebuildFilter)
            GUI.Label(R(x + btnW + 6f, yy, colW - btnW - 14f, ROW_H),
                I18n.IsEnglish ? (e.DisplayLabelEn ?? e.NameEn ?? e.Name) : (e.DisplayLabelZh ?? e.NameZh ?? e.Name),
                rowStyle);
        }
        y += ROW_ADV * _pageRows + SECTION_END_ADV;

        // 分页控制(右对齐,跟随窗口宽度) — v6.6: 仅在页/总页/总数变化时重建
        if (_page != _cachedPageNum || totalPages != _cachedTotalPages || _filtered.Count != _cachedFilteredCount)
        {
            _cachedPageNum      = _page;
            _cachedTotalPages   = totalPages;
            _cachedFilteredCount = _filtered.Count;
            _cachedPageInfo = I18n.IsEnglish
                ? $"Page {_page + 1}/{totalPages}   Total {_filtered.Count}   /page {_pageSize}"
                : $"页 {_page + 1}/{totalPages}   共 {_filtered.Count} 个   每页 {_pageSize}";
        }
        float pw = aw + PAD;
        if (GUI.Button(R(10f, y, 100f, ROW_H), I18n.T("◀ 上一页", "◀ Prev"))) { if (_page > 0) { _page--; _cachedPageNum = -1; } }
        GUI.Label(R(120f, y, Mathf.Min(400f, pw - 400f), ROW_H), _cachedPageInfo, _rowLabelStyle);
        if (GUI.Button(R(pw - 280f, y, 100f, ROW_H), I18n.T("下一页 ▶", "Next ▶"))) { if (_page < totalPages - 1) { _page++; _cachedPageNum = -1; } }
        if (GUI.Button(R(pw - 170f, y, 80f, ROW_H), I18n.T("⏮ 首页", "⏮ First")))   { _page = 0; _cachedPageNum = -1; }
        if (GUI.Button(R(pw - 80f, y, 80f, ROW_H), I18n.T("末页 ⏭", "Last ⏭")))    { _page = totalPages - 1; _cachedPageNum = -1; }
        return y + ROW_ADV + SECTION_END_ADV;
    }

    // 两张卡片之间那道缝就是分割栏。拖动按屏幕坐标算,鼠标拖出窗口也跟得上。
    private static void DrawTeleportSplitter(TldHacksSettings s, float top, float bottom, float fullH)
    {
        var hit = new Rect(0f, (top - 2f) * _scale, ContentW * _scale, (bottom - top + 4f) * _scale);
        var e = Event.current;
        float screenY = Screen.height - Input.mousePosition.y;
        if (!_splitDragging && e.type == EventType.MouseDown && e.button == 0 && hit.Contains(e.mousePosition))
        {
            _splitDragging = true;
            _splitStartMouseY = screenY;
            _splitStartH = Mathf.Clamp(s.SpawnerTeleportH, ROW_ADV, Mathf.Max(ROW_ADV, fullH));
            e.Use();
        }
        if (_splitDragging)
        {
            if (!Input.GetMouseButton(0)) { _splitDragging = false; s.RequestSave(); }
            else s.SpawnerTeleportH = Mathf.Clamp(_splitStartH + (screenY - _splitStartMouseY) / _scale, ROW_ADV, Mathf.Max(ROW_ADV, fullH));
        }
        Ui.Hover("Spawner_Splitter", hit);

        bool hot = _splitDragging || hit.Contains(e.mousePosition);
        float mid = (top + bottom) * 0.5f;
        if (!hot) GUI.color = new Color(1f, 1f, 1f, 0.35f);
        float gx = ContentW * 0.5f - 24f;
        for (int i = 0; i < 2; i++)
            GUI.DrawTexture(new Rect(gx * _scale, (mid - 3f + i * 4f) * _scale, 48f * _scale, 2f * _scale), hot ? _accentTex : Texture2D.whiteTexture);
        GUI.color = Color.white;
    }

    // 搜索框 + 清空按钮,贴在"物品生成器"卡片标题栏的右端。
    // 支持拼音首字母(xs)、完整拼音(xiangshi)、英文原名(acorn),匹配逻辑见 PinyinSearch。
    private static void DrawItemSearchBox(float headY)
    {
        if (_searchBoxBroken) return;
        try
        {
            const float boxW = 240f, clearW = 24f;
            float ty = headY + 4f, th = Ui.CARD_HEAD - 8f;
            float cx = ContentW - PAD - clearW;
            float bx = cx - 4f - boxW;

            // 这个框是自己画的,不走 IMGUI 的文本框。两条路都试过、都不通:
            //   GUI.SetNextControlName / FocusControl 的 unstrip 实现走 ReadOnlySpan,
            //     Il2CppSystem 里没生成 GetPinnableReference → MissingMethodException;
            //   GUI.TextField 本身 "Method unstripping failed",拿不到方法体。
            // 所以:框和文字自己画,焦点自己管(点进来算聚焦),键盘在 UpdateSearchInput 里
            // 从 Input.inputString 收(OnGUI 一帧跑好几遍,收键盘必须放每帧一次的地方)。
            var rect = R(bx, ty, boxW, th);
            var ev = Event.current;
            if (ev != null && ev.type == EventType.MouseDown) _searchFocused = rect.Contains(ev.mousePosition);
            GUI.Box(rect, "", _searchFocused ? _searchFieldHotStyle : _searchFieldStyle);

            if (_search.Length == 0 && !_searchFocused)
            {
                var prev = _mutedLabelStyle.alignment;
                _mutedLabelStyle.alignment = TextAnchor.MiddleLeft;
                GUI.Label(rect, I18n.T("搜索(首字母 / 全拼 / 英文)", "Search (pinyin or English)"), _mutedLabelStyle);
                _mutedLabelStyle.alignment = prev;
            }
            else
            {
                // 光标每秒闪两次,靠缓存避免每帧拼字符串
                bool caretOn = _searchFocused && ((int)(Time.realtimeSinceStartup * 2f) & 1) == 0;
                if (_searchShownFor != _search || _searchShownCaret != caretOn)
                {
                    _searchShownFor = _search;
                    _searchShownCaret = caretOn;
                    _searchShown = caretOn ? _search + "|" : _search;
                }
                GUI.Label(rect, _searchShown, _rowLabelStyle);
            }

            if (CBtn(cx, ty, clearW, th, "×") && _search.Length > 0) { _search = ""; _page = 0; }
        }
        catch (Exception ex)
        {
            // 搜索框再出什么意外也不许连累物品列表:停掉框、清掉筛选条件
            _searchBoxBroken = true;
            _search = "";
            _searchFocused = false;
            ModMain.Log?.Warning($"[Spawner] 搜索框已停用:{ex.Message}");
        }
    }

    // 搜索框获得焦点期间锁住玩家控制:不锁的话拼音里的 w/a/s/d、i、m 会同时被游戏
    // 当成移动键和开面板键。只在 Normal 状态下锁,恢复时也只认 Locked,免得抢开车/攀爬的状态。
    // 搜索框收键盘。必须由 ModMain.OnUpdate 每帧调一次:OnGUI 一帧会跑好几遍(Layout / Repaint /
    // 事件各一遍),放在那边同一个按键会被吃好几次。Input.inputString 里退格是 '\b'、回车是 '\n'。
    internal static void UpdateSearchInput()
    {
        if (!Open || !_searchFocused) return;

        // 点到菜单窗口外面就收掉焦点,否则玩家控制会一直锁着(窗口外的点击进不到窗口函数)
        if (Input.GetMouseButtonDown(0))
        {
            var m = Input.mousePosition;
            if (!_window.Contains(new Vector2(m.x, Screen.height - m.y))) { _searchFocused = false; return; }
        }
        if (Input.GetKeyDown(KeyCode.Escape)) { _searchFocused = false; return; }

        string typed = Input.inputString;
        if (string.IsNullOrEmpty(typed)) return;
        string s = _search ?? "";
        for (int i = 0; i < typed.Length; i++)
        {
            char c = typed[i];
            if (c == '\b') { if (s.Length > 0) s = s.Substring(0, s.Length - 1); continue; }
            if (c == '\n' || c == '\r') { _searchFocused = false; continue; }
            if (c >= ' ' && c < (char)127 && s.Length < 32) s += c;
        }
        if (s != _search) { _search = s; _page = 0; }
    }

    // 只在焦点翻转的那一帧碰游戏,别在每帧路径上调 IL2Cpp。
    private static void SyncSearchInputLock(bool typing)
    {
        if (typing == _searchTyping) return;
        _searchTyping = typing;
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null) { _searchLockedInput = false; return; }
            if (typing)
            {
                if (pm.GetControlMode() != PlayerControlMode.Normal) return;
                pm.SetControlMode(PlayerControlMode.Locked);
                _searchLockedInput = true;
            }
            else
            {
                if (_searchLockedInput && pm.GetControlMode() == PlayerControlMode.Locked)
                    pm.SetControlMode(PlayerControlMode.Normal);
                _searchLockedInput = false;
            }
        }
        catch { _searchLockedInput = false; }
    }

    private static float SodaRows(float x, float y, string name, ref bool on, ref float pct, ref int dur, ref bool changed)
    {
        float w = MenuTweaks.COL_TOG_W3;
        const float togW = 110f, valW = 44f;
        bool b = Ui.Toggle("SodaOn", R(x, y, togW, ROW_H), on, name);
        if (b != on) { on = b; changed = true; }
        float v = Ui.Slider("SodaPct", R(x + togW + 8f, y + 8f, w - togW - valW - 12f, 12f), pct, 1f, 15f);
        GUI.Label(R(x + w - valW, y, valW, ROW_H), v.ToString("0'%'"), _valueLabelStyle);
        if (v != pct) { pct = v; changed = true; }
        y += ROW_ADV;
        int d = MenuTweaks.DrawChoiceCol3(RFunc, x, y, I18n.T("  持续(分钟)", "  Minutes"), dur, MenuTweaks.SodaMinutes, "SodaDur");
        if (d != dur) { dur = d; changed = true; }
        return y + ROW_ADV;
    }

    private static float Section(float x, float y, string title, string badge = null)
        => Ui.Card(x - PAD, y, MenuTweaks.COL_W3 + 2f * PAD, title, badge);

    // 整行宽的卡片,内容从 x = PAD 开始,可用宽度 ContentW - 2*PAD
    private static float SectionWide(float y, string title)
        => Ui.Card(0f, y, ContentW, title);

    private static bool HasChineseChar(string s)
    {
        if (string.IsNullOrEmpty(s)) return false;
        foreach (char c in s) if (c >= 0x4E00 && c <= 0x9FFF) return true;
        return false;
    }

    private static string PrefabToEn(string prefab)
    {
        if (string.IsNullOrEmpty(prefab)) return prefab;
        string s = prefab.StartsWith("GEAR_") ? prefab.Substring(5) : prefab;
        var sb = new System.Text.StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c == '_') { sb.Append(' '); continue; }
            if (i > 0 && char.IsUpper(c) && !char.IsUpper(s[i - 1]) && s[i - 1] != ' ') sb.Append(' ');
            sb.Append(c);
        }
        return sb.ToString();
    }

    private static void ResolveDisplayNames()
    {
        if (_namesResolved) return;
        _namesResolved = true;
        try
        {
            void Resolve(System.Collections.Generic.List<ItemEntry> list, bool isMod)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var e = list[i];
                    e.IsMod = isMod;
                    e.NameZh = e.Name;                        // 硬编码默认中文
                    e.NameEn = PrefabToEn(e.PrefabName);      // 驼峰拆分作英文兜底
                    try
                    {
                        if (e.PrefabName == "GEAR_RandomCerealBox") { e.IsValid = false; continue; }
#if STORY_EDITION
                        // 2.24 的 StoryShim 会真的实例化物品,拿来取显示名会往场景里塞上千件。剧情版只用清单里的名字。
                        if (isMod) { e.NameZh += " (mod)"; e.NameEn += " (mod)"; }
#else
                        var gi = GearPrefab.Load(e.PrefabName);
                        if (gi == null) { e.IsValid = false; continue; }
                        string dn = gi.GetDisplayNameWithoutConditionForInventoryInterfaces();
                        // 游戏数据里香蒲植株套用了高科技背包的名字 key,取到的是"高科技背包",保留清单里的名字
                        if (e.PrefabName == "GEAR_CattailPlant") dn = null;
                        if (!string.IsNullOrEmpty(dn) && dn != e.PrefabName)
                        {
                            if (HasChineseChar(dn)) e.NameZh = dn;
                            else e.NameEn = dn;
                        }
                        if (isMod) { e.NameZh += " (mod)"; e.NameEn += " (mod)"; }
#endif
                    }
                    catch { e.IsValid = false; }
                }
            }
            // 先把实际装了的 mod 物品扫出来补进清单,再一起解析名字 + 校验 prefab 是否真的存在
            ItemDiscovery.Run();
            Resolve(ItemDatabase.All, false);
            Resolve(ItemDatabaseMod.All, true);
            Furniture.ResolveNames();
            // 清单里 prefab 名写错的条目会在这里变成 IsValid=false 后静默消失,界面上看不出来,
            // 所以把两份清单各有几条没解析出来记到日志,改完清单一条 grep 就能核对。
            int badV = 0, badM = 0;
            var badNames = new System.Text.StringBuilder();
            var badVNames = new System.Text.StringBuilder();
            for (int i = 0; i < ItemDatabase.All.Count; i++)
                if (!ItemDatabase.All[i].IsValid) { badV++; badVNames.Append(ItemDatabase.All[i].PrefabName).Append(' '); }
            for (int i = 0; i < ItemDatabaseMod.All.Count; i++)
            {
                if (ItemDatabaseMod.All[i].IsValid) continue;
                badM++;
                if (badM <= 60) badNames.Append(ItemDatabaseMod.All[i].PrefabName).Append(' ');
            }
            ModMain.Log?.Msg($"[Spawner] 名称解析完成:原版 {ItemDatabase.All.Count - badV}/{ItemDatabase.All.Count} 可用,"
                + $"mod {ItemDatabaseMod.All.Count - badM}/{ItemDatabaseMod.All.Count} 可用(失效 {badV + badM} 条)");
            if (badV > 0) ModMain.Log?.Msg($"[Spawner] 原版清单里加载不到的 prefab:{badVNames}");
            if (badM > 0) ModMain.Log?.Msg($"[Spawner] mod 清单里加载不到的 prefab:{badNames}");
        }
        catch (System.Exception ex) { ModMain.Log?.Warning($"[ResolveNames] {ex.Message}"); }
    }

    private static void RebuildFilter()
    {
        ResolveDisplayNames();
        _filtered.Clear();
        string cat = ItemDatabase.Categories[_selectedCategory];
        _lastSearch = _search;
        string q = (_search ?? "").Trim().ToLowerInvariant();
        string qc = q.Replace(" ", "");

        for (int i = 0; i < ItemDatabase.All.Count; i++)
        {
            var e = ItemDatabase.All[i];
            if (!e.IsValid) continue;
            if (_selectedCategory != 0 && e.Category != cat) continue;
            if (q.Length > 0 && !PinyinSearch.Match(e, q, qc)) continue;
            BuildDisplayLabels(e);
            _filtered.Add(e);
        }
        for (int i = 0; i < ItemDatabaseMod.All.Count; i++)
        {
            var e = ItemDatabaseMod.All[i];
            if (!e.IsValid) continue;
            if (_selectedCategory != 0 && e.Category != cat) continue;
            if (q.Length > 0 && !PinyinSearch.Match(e, q, qc)) continue;
            BuildDisplayLabels(e);
            _filtered.Add(e);
        }
#if !STORY_EDITION && !EP5_EDITION
        // 家具七百多条,"全部"栏只在搜索时带上,免得把普通物品挤到后面几十页
        if (cat == "家具" || (_selectedCategory == 0 && q.Length > 0))
            foreach (var list in new[] { FurnitureDatabase.Carryables, FurnitureDatabase.Native })
                foreach (var e in list)
                {
                    if (q.Length > 0 && !PinyinSearch.Match(e, q, qc)) continue;
                    BuildDisplayLabels(e);
                    _filtered.Add(e);
                }
#endif
        // 分页缓存失效
        _cachedPageNum = -1;
    }

    // v6.6 GC: 预计算带卡路里后缀的显示名,供 Spawner UI 每帧直接读取
    private static void BuildDisplayLabels(ItemEntry e)
    {
        string suffix = e.Calories > 0 ? $" {e.Calories}k" : "";
        string baseZh = e.NameZh ?? e.Name;
        string baseEn = e.NameEn ?? e.Name;
        e.DisplayLabelZh = suffix.Length > 0 ? baseZh + suffix : baseZh;
        e.DisplayLabelEn = suffix.Length > 0 ? baseEn + suffix : baseEn;
    }
}

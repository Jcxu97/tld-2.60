using System;
using UnityEngine;

namespace TldHacks;

// 会在几页之间挪动的卡片。每张卡画在 x 列、从 y 开始,返回画完后的 y。
internal static partial class MenuTweaks
{
    internal static float CardMiscQoL(Func<float, float, float, float, Rect> R, TldHacksSettings s, float x, float y, ref bool changed)
    {
        float subTogW = HALF_W, xSub = x + HALF_OFF;
        y = SectionCol(R, x, y, COL_W3, I18n.T("其他便利功能", "Misc QoL"));
        bool skipI  = Ui.Toggle("SkipIntro", R(x, y, subTogW, ROW_H), s.SkipIntro, I18n.T(" 跳过片头", " Skip Intro"), ToggleStyle ?? GUI.skin.toggle);
        bool noSave = Ui.Toggle("QoL_NoSaveOnSprain", R(xSub, y, subTogW, ROW_H), s.QoL_NoSaveOnSprain, I18n.T(" 扭伤不存", " No Save Sprain"), ToggleStyle ?? GUI.skin.toggle);
        if (skipI != s.SkipIntro) { s.SkipIntro = skipI; changed = true; }
        if (noSave != s.QoL_NoSaveOnSprain) { s.QoL_NoSaveOnSprain = noSave; changed = true; }
        y += ROW_ADV;
        bool noFallSpr = Ui.Toggle("QoL_NoSaveOnSprainFalls", R(x,    y, subTogW, ROW_H), s.QoL_NoSaveOnSprainFalls, I18n.T(" 含坠扭伤", " Include Falls"), ToggleStyle ?? GUI.skin.toggle);
#if STORY_GUARD
        // 剧情版:埋葬尸体挂 SaveGameSystem.Save/LoadSceneData,写持久场景存档 → 禁用灰显。
        bool _buryBlocked = StoryGuard.InStory;
        if (_buryBlocked) GUI.enabled = false;
#endif
        bool bury      = Ui.Toggle("QoL_BuryCorpses", R(xSub, y, subTogW, ROW_H), s.QoL_BuryCorpses,         I18n.T(" 埋葬尸体", " Bury Corpses"), ToggleStyle ?? GUI.skin.toggle);
#if STORY_GUARD
        if (_buryBlocked) GUI.enabled = true;
#endif
        if (noFallSpr != s.QoL_NoSaveOnSprainFalls) { s.QoL_NoSaveOnSprainFalls = noFallSpr; changed = true; }
        if (bury != s.QoL_BuryCorpses) { s.QoL_BuryCorpses = bury; changed = true; }
        y += ROW_ADV;
        bool wakeUp = Ui.Toggle("QoL_WakeUpCall", R(x,    y, subTogW, ROW_H), s.QoL_WakeUpCall,  I18n.T(" 睡眠中可醒", " Wake Option"), ToggleStyle ?? GUI.skin.toggle);
        bool aurora = Ui.Toggle("QoL_AuroraSense", R(xSub, y, subTogW, ROW_H), s.QoL_AuroraSense, I18n.T(" 极光时叫醒", " Aurora Wake"), ToggleStyle ?? GUI.skin.toggle);
        if (wakeUp != s.QoL_WakeUpCall) { s.QoL_WakeUpCall = wakeUp; changed = true; }
        if (aurora != s.QoL_AuroraSense) { s.QoL_AuroraSense = aurora; changed = true; }
        y += ROW_ADV;
        bool showT = Ui.Toggle("QoL_ShowTimeSleep", R(x,    y, subTogW, ROW_H), s.QoL_ShowTimeSleep, I18n.T(" 睡眠显示时间", " Sleep Clock"), ToggleStyle ?? GUI.skin.toggle);
        bool noPB  = Ui.Toggle("QoL_NoPitchBlack", R(xSub, y, subTogW, ROW_H), s.QoL_NoPitchBlack,  I18n.T(" 不要纯黑", " No Pitch Black"), ToggleStyle ?? GUI.skin.toggle);
        if (showT != s.QoL_ShowTimeSleep) { s.QoL_ShowTimeSleep = showT; changed = true; }
        if (noPB != s.QoL_NoPitchBlack) { s.QoL_NoPitchBlack = noPB; changed = true; }
        y += ROW_ADV + SECTION_END_ADV;
        return y;
    }

    internal static float CardTrader(Func<float, float, float, float, Rect> R, TldHacksSettings s, float x, float y, ref bool changed)
    {
        float subTogW = HALF_W, xSub = x + HALF_OFF;
#if !STORY_EDITION
        bool b;
#endif
        y = SectionCol(R, x, y, COL_W3, I18n.T("商人 & 美洲狮", "Trader & Cougar"));
#if STORY_GUARD
        // 剧情版:整套无线电商人 + 美洲狮到货是沙盒专属系统,剧情里目标对象不存在。
        // 灰显整段(仍可见,便于用户理解为何禁用),StoryGuard 已在后台强制清零对应开关。
        bool _traderBlocked = StoryGuard.InStory;
        if (_traderBlocked) GUI.enabled = false;
#endif
        bool tul = Ui.Toggle("TraderUnlimitedList", R(x,    y, subTogW, ROW_H), s.TraderUnlimitedList,   I18n.T(" 交易扩充", " More Trades"), ToggleStyle ?? GUI.skin.toggle);
        bool tmt = Ui.Toggle("TraderMaxTrust", R(xSub, y, subTogW, ROW_H), s.TraderMaxTrust,       I18n.T(" 信任满值", " Max Trust"), ToggleStyle ?? GUI.skin.toggle);
        y += ROW_ADV;
        bool tix = Ui.Toggle("TraderInstantExchange", R(x,    y, subTogW, ROW_H), s.TraderInstantExchange, I18n.T(" 即时交易", " Instant Trade"), ToggleStyle ?? GUI.skin.toggle);
        bool taa = Ui.Toggle("TraderAlwaysAvailable", R(xSub, y, subTogW, ROW_H), s.TraderAlwaysAvailable, I18n.T(" 商人常驻", " Always Online"), ToggleStyle ?? GUI.skin.toggle);
        y += ROW_ADV;
        bool cia = Ui.Toggle("CougarInstantActivate", R(x,    y, subTogW, ROW_H), s.CougarInstantActivate, I18n.T(" 召唤美洲狮", " Spawn Cougar"), ToggleStyle ?? GUI.skin.toggle);
        bool stt = Ui.Toggle("TT_ShowTraderTrust", R(xSub, y, subTogW, ROW_H), s.TT_ShowTraderTrust,   I18n.T(" 显示信任度", " Show Trust"), ToggleStyle ?? GUI.skin.toggle);
        y += ROW_ADV;
        bool tum = Ui.Toggle("TraderUnlockModeItems", R(x, y, COL_TOG_W3, ROW_H), s.TraderUnlockModeItems, I18n.T(" 解锁原版限制", " Remove Vanilla Limits"), ToggleStyle ?? GUI.skin.toggle);
        if (tum != s.TraderUnlockModeItems) { s.TraderUnlockModeItems = tum; CheatState.TraderUnlockModeItems = tum; changed = true; }
        y += ROW_ADV;
#if !STORY_EDITION
        b = Ui.Toggle("CE_TraderCheap", R(x, y, subTogW, ROW_H), s.CE_TraderCheap, I18n.T(" 商人打折", " Discount"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.CE_TraderCheap) { s.CE_TraderCheap = b; changed = true; }
        Ui.Hover("CE_TraderRefresh", R(xSub, y, subTogW, ROW_H));
        if (GUI.Button(R(xSub, y, subTogW, ROW_H), I18n.T("刷新商品", "Refresh Goods"))) CeX.RefreshTrader();
        y += ROW_ADV;
#endif
        float td = DrawSliderCol3(R, x, y, I18n.T("到来(天)", "Arrival"), s.TraderArrivalDays, 1f, 40f, "F0", key: "TraderArrivalDays");
        if ((int)td != (int)s.TraderArrivalDays) { s.TraderArrivalDays = (int)td; changed = true; }
        y += ROW_ADV;
        int curTrust = 0;
        float trustMin = 0f, trustMax = 500f;
#if !STORY_EDITION
        // 2.24 无商人系统(GameManager.GetTraderManager 不存在);StoryGuard 已强制关掉整组
        // 商人开关,这里滑条读不到值就固定显示 0,UI 结构保持一致不动。
        try
        {
            var tm2 = Il2Cpp.GameManager.GetTraderManager();
            if (tm2?.m_CurrentState != null)
            {
                curTrust = tm2.m_CurrentState.m_CurrentTrust;
                trustMin = tm2.m_MinTrustLevel; trustMax = tm2.m_MaxTrustLevel;
                // 信任满值一打开就拉满,不等下次打开交易清单,滑条也立刻跟着变
                if (tmt && curTrust < tm2.m_MaxTrustLevel)
                {
                    TraderTrust.HealOnce(tm2);
                    TraderTrust.Set(tm2, tm2.m_MaxTrustLevel);
                    curTrust = tm2.m_CurrentState.m_CurrentTrust;
                }
            }
        }
        catch { }
#endif
        // 信任满值开着时滑条拖不动,不然拖下去下次打开交易清单又被拉回满值
        bool guiWas = GUI.enabled;
        if (tmt) GUI.enabled = false;
        float trustSlider = DrawSliderCol3(R, x, y, I18n.T("信任值", "Trust"), curTrust, trustMin, trustMax, "F0");
        GUI.enabled = guiWas;
        if (!tmt && (int)trustSlider != curTrust)
        {
            // 历史最高只升不降、升上去时补对应的解锁,都照原版(见 TraderTrust)
#if !STORY_EDITION
            try
            {
                var tm2 = Il2Cpp.GameManager.GetTraderManager();
                if (tm2?.m_CurrentState != null) { TraderTrust.HealOnce(tm2); TraderTrust.Set(tm2, (int)trustSlider); }
            }
            catch { }
#endif
        }
        y += ROW_ADV + SECTION_END_ADV;
        if (tul != s.TraderUnlimitedList || tmt != s.TraderMaxTrust
            || tix != s.TraderInstantExchange || taa != s.TraderAlwaysAvailable
            || cia != s.CougarInstantActivate || stt != s.TT_ShowTraderTrust)
        {
            s.TraderUnlimitedList = tul; s.TraderMaxTrust = tmt;
            s.TraderInstantExchange = tix; s.TraderAlwaysAvailable = taa;
            s.CougarInstantActivate = cia; s.TT_ShowTraderTrust = stt;
            CheatState.TraderUnlimitedList = tul; CheatState.TraderMaxTrust = tmt;
            CheatState.TraderInstantExchange = tix; CheatState.TraderAlwaysAvailable = taa;
            CheatState.CougarInstantActivate = cia; CheatState.TT_ShowTraderTrust = stt;
            changed = true;
        }
#if STORY_GUARD
        if (_traderBlocked) GUI.enabled = true;   // 恢复,勿影响后续控件
#endif
        return y;
    }

    internal static float CardAdvanced(Func<float, float, float, float, Rect> R, TldHacksSettings s, float x, float y, ref bool changed)
    {
        float subTogW = HALF_W, xSub = x + HALF_OFF;
        float v;
        y = SectionCol(R, x, y, COL_W3, I18n.T("高级微调", "Advanced Tweaks"));
        bool pauseRad = Ui.Toggle("TT_PauseOnRadial", R(x,    y, subTogW, ROW_H), s.TT_PauseOnRadial, I18n.T(" 开轮盘减速", " Radial Slowmo"), ToggleStyle ?? GUI.skin.toggle);
        bool dropOri  = Ui.Toggle("TT_DroppedOrientation", R(xSub, y, subTogW, ROW_H), s.TT_DroppedOrientation, I18n.T(" 步枪落地竖放", " Rifle Upright"), ToggleStyle ?? GUI.skin.toggle);
        if (pauseRad != s.TT_PauseOnRadial) { s.TT_PauseOnRadial = pauseRad; CheatState.TT_PauseOnRadial = pauseRad; changed = true; }
        if (dropOri != s.TT_DroppedOrientation) { s.TT_DroppedOrientation = dropOri; CheatState.TT_DroppedOrientation = dropOri; changed = true; }
        y += ROW_ADV;

        bool deathGoat = Ui.Toggle("TT_FallDeathGoat", R(x, y, COL_TOG_W3, ROW_H), s.TT_FallDeathGoat, I18n.T(" 无视坠落即死墙", " Ignore Fall Death Walls"), ToggleStyle ?? GUI.skin.toggle);
        if (deathGoat != s.TT_FallDeathGoat) { s.TT_FallDeathGoat = deathGoat; CheatState.TT_FallDeathGoat = deathGoat; changed = true; }
        y += ROW_ADV;
        v = DrawSliderCol3(R, x, y, I18n.T("坠落伤害/米", "Fall Dmg/m"), (float)s.TT_FallDamageMult, 1f, 12f, "F0", key: "TT_FallDamageMult");
        if ((int)v != s.TT_FallDamageMult) { s.TT_FallDamageMult = (int)v; changed = true; }
        y += ROW_ADV;

        bool capFeels = Ui.Toggle("TT_CapFeelsEnabled", R(x, y, COL_TOG_W3, ROW_H), s.TT_CapFeelsEnabled, I18n.T(" 限制体感温度", " Cap Feels-Like Temp"), ToggleStyle ?? GUI.skin.toggle);
        if (capFeels != s.TT_CapFeelsEnabled) { s.TT_CapFeelsEnabled = capFeels; CheatState.TT_CapFeelsEnabled = capFeels; changed = true; }
        y += ROW_ADV;
        Ui.Dim(!s.TT_CapFeelsEnabled);
        v = DrawSliderCol3(R, x, y, I18n.T("体感上限(℃)", "High Cap(℃)"), (float)s.TT_CapFeelsHigh, -10f, 50f, "F0", key: "TT_CapFeelsHigh");
        if ((int)v != s.TT_CapFeelsHigh) { s.TT_CapFeelsHigh = (int)v; changed = true; }
        y += ROW_ADV;
        v = DrawSliderCol3(R, x, y, I18n.T("体感下限(℃)", "Low Cap(℃)"), (float)s.TT_CapFeelsLow, -50f, 10f, "F0", key: "TT_CapFeelsLow");
        if ((int)v != s.TT_CapFeelsLow) { s.TT_CapFeelsLow = (int)v; changed = true; }
        Ui.Dim(false);
        y += ROW_ADV;

#if STORY_GUARD
        // 剧情版:植物重生挂 SaveGameSystem.Save/LoadSceneData,写持久场景存档 → 禁用灰显。
        bool _respawnBlocked = StoryGuard.InStory;
        if (_respawnBlocked) GUI.enabled = false;
#endif
        bool respawn = Ui.Toggle("TT_RespawnPlants", R(x, y, COL_TOG_W3, ROW_H), s.TT_RespawnPlants, I18n.T(" 植物重生", " Respawn Plants"), ToggleStyle ?? GUI.skin.toggle);
#if STORY_GUARD
        if (_respawnBlocked) GUI.enabled = true;
#endif
        if (respawn != s.TT_RespawnPlants) { s.TT_RespawnPlants = respawn; CheatState.TT_RespawnPlants = respawn; changed = true; }
        y += ROW_ADV;
        Ui.Dim(!s.TT_RespawnPlants);
        v = DrawSliderCol3(R, x, y, I18n.T("重生天数", "Respawn Days"), (float)s.TT_PlantRespawnDays, 1f, 365f, "F0", key: "TT_PlantRespawnDays");
        if ((int)v != s.TT_PlantRespawnDays) { s.TT_PlantRespawnDays = (int)v; changed = true; }
        Ui.Dim(false);
        y += ROW_ADV + SECTION_END_ADV;
        return y;
    }

    internal static float CardTorch(Func<float, float, float, float, Rect> R, TldHacksSettings s, float x, float y, ref bool changed)
    {
        float subTogW = HALF_W, xSub = x + HALF_OFF;
        float v;
        y = SectionCol(R, x, y, COL_W3, I18n.T("火把 & 手电", "Torch & Flashlight"));
        v = DrawSliderCol3(R, x, y, I18n.T("燃烧时间(分)", "Burn Time"), s.TorchBurnMinutes, 1f, 2880f, "F0", key: "TorchBurnMinutes");
        if (v != s.TorchBurnMinutes) { s.TorchBurnMinutes = v; changed = true; }
        y += ROW_ADV;
        v = DrawSliderCol3(R, x, y, I18n.T("最小状态", "Min Cond"), s.TorchMinCondition, 0f, 1f, "F2", key: "TorchMinCondition");
        if (v != s.TorchMinCondition) { s.TorchMinCondition = v; changed = true; }
        y += ROW_ADV;
        v = DrawSliderCol3(R, x, y, I18n.T("最大状态", "Max Cond"), s.TorchMaxCondition, 0f, 1f, "F2", key: "TorchMaxCondition");
        if (v != s.TorchMaxCondition) { s.TorchMaxCondition = v; changed = true; }
        y += ROW_ADV;
        bool dtlc = Ui.Toggle("DisableTorchLeftClick", R(x,    y, subTogW, ROW_H), s.DisableTorchLeftClick, I18n.T(" 锁火把键", " Lock Torch"), ToggleStyle ?? GUI.skin.toggle);
        bool flashInf = Ui.Toggle("UT_FlashInfiniteBattery", R(xSub, y, subTogW, ROW_H), s.UT_FlashInfiniteBattery, I18n.T(" 手电无限电", " Inf. Battery"), ToggleStyle ?? GUI.skin.toggle);
        if (dtlc != s.DisableTorchLeftClick) { s.DisableTorchLeftClick = dtlc; CheatState.DisableTorchLeftClick = dtlc; changed = true; }
        if (flashInf != s.UT_FlashInfiniteBattery) { s.UT_FlashInfiniteBattery = flashInf; changed = true; }
        y += ROW_ADV + SECTION_END_ADV;
        return y;
    }

    internal static float CardLamp(Func<float, float, float, float, Rect> R, TldHacksSettings s, float x, float y, ref bool changed)
    {
        float subTogW = HALF_W, xSub = x + HALF_OFF;
        float v;
        y = SectionCol(R, x, y, COL_W3, I18n.T("煤油灯", "Kerosene Lamp"));
        // 油灯不耗从主页挪来;开着时下面的消耗倍率不起作用
        bool lamp = Ui.Toggle("LampFuelNoDrain", R(x, y, COL_TOG_W3, ROW_H), s.LampFuelNoDrain, I18n.T(" 油灯不耗", " Lamp No Drain"), ToggleStyle ?? GUI.skin.toggle);
        if (lamp != s.LampFuelNoDrain) { s.LampFuelNoDrain = lamp; CheatState.LampFuelNoDrain = lamp; changed = true; }
        y += ROW_ADV;
        v = DrawSliderCol3(R, x, y, I18n.T("放置消耗", "Placed"), s.LampPlacedBurnMult, 0f, 2f, "F2", key: "LampPlacedBurnMult");
        if (v != s.LampPlacedBurnMult) { s.LampPlacedBurnMult = v; changed = true; }
        y += ROW_ADV;
        v = DrawSliderCol3(R, x, y, I18n.T("手持消耗", "Held"), s.LampHeldBurnMult, 0f, 2f, "F2", key: "LampHeldBurnMult");
        if (v != s.LampHeldBurnMult) { s.LampHeldBurnMult = v; changed = true; }
        y += ROW_ADV;
        v = DrawSliderCol3(R, x, y, I18n.T("开启耗损%", "TurnOn"), s.LampTurnOnDecay, 0f, 2f, "F2", key: "LampTurnOnDecay");
        if (v != s.LampTurnOnDecay) { s.LampTurnOnDecay = v; changed = true; }
        y += ROW_ADV;
        v = DrawSliderCol3(R, x, y, I18n.T("持续耗损%/h", "OverTime"), s.LampOverTimeDecay, 0f, 1f, "F2", key: "LampOverTimeDecay");
        if (v != s.LampOverTimeDecay) { s.LampOverTimeDecay = v; changed = true; }
        y += ROW_ADV;
        v = DrawSliderCol3(R, x, y, I18n.T("惩罚阈值HP%", "Penalty"), (float)s.LampConditionThreshold, 0f, 100f, "F0", key: "LampConditionThreshold");
        if ((int)v != s.LampConditionThreshold) { s.LampConditionThreshold = (int)v; changed = true; }
        y += ROW_ADV;
        v = DrawSliderCol3(R, x, y, I18n.T("最大惩罚%", "MaxPenalty"), (float)s.LampMaxPenalty, 0f, 200f, "F0", key: "LampMaxPenalty");
        if ((int)v != s.LampMaxPenalty) { s.LampMaxPenalty = (int)v; changed = true; }
        y += ROW_ADV;
        v = DrawSliderCol3(R, x, y, I18n.T("光照范围", "Light Range"), s.LampRangeMultiplier, 0.5f, 5f, "F2", key: "LampRangeMultiplier");
        if (v != s.LampRangeMultiplier) { s.LampRangeMultiplier = v; changed = true; }
        y += ROW_ADV;
        bool lmute = Ui.Toggle("LampMute", R(x,    y, subTogW, ROW_H), s.LampMute, I18n.T(" 放置静音", " Mute Placed"), ToggleStyle ?? GUI.skin.toggle);
        bool dllc = Ui.Toggle("DisableLampLeftClick", R(xSub, y, subTogW, ROW_H), s.DisableLampLeftClick, I18n.T(" 锁油灯键", " Lock Lamp"), ToggleStyle ?? GUI.skin.toggle);
        if (lmute != s.LampMute) { s.LampMute = lmute; CheatState.LampMute = lmute; changed = true; }
        if (dllc != s.DisableLampLeftClick) { s.DisableLampLeftClick = dllc; CheatState.DisableLampLeftClick = dllc; changed = true; }
        y += ROW_ADV + SECTION_END_ADV;
        return y;
    }

#if !EP5_EDITION && !STORY_EDITION
    internal static float CardSteamTrain(Func<float, float, float, float, Rect> R, TldHacksSettings s, float x, float y, ref bool changed)
    {
        float subTogW = HALF_W, xSub = x + HALF_OFF;
        y = SectionCol(R, x, y, COL_W3, I18n.T("蒸汽火车", "Steam Train"));
        bool noBreak = Ui.Toggle("Train_NoBreak", R(x,    y, subTogW, ROW_H), s.Train_NoBreak, I18n.T(" 火车不坏", " No Break"), ToggleStyle ?? GUI.skin.toggle);
        bool gear    = Ui.Toggle("Train_KeepHighGear", R(xSub, y, subTogW, ROW_H), s.Train_KeepHighGear, I18n.T(" 保持二档", " Keep Gear 2"), ToggleStyle ?? GUI.skin.toggle);
        if (noBreak != s.Train_NoBreak) { s.Train_NoBreak = noBreak; changed = true; }
        if (gear != s.Train_KeepHighGear) { s.Train_KeepHighGear = gear; changed = true; }
        y += ROW_ADV;
        bool fuel = Ui.Toggle("Train_FullFuel", R(x, y, COL_TOG_W3, ROW_H), s.Train_FullFuel, I18n.T(" 燃料和水一直满", " Full Fuel & Water"), ToggleStyle ?? GUI.skin.toggle);
        if (fuel != s.Train_FullFuel) { s.Train_FullFuel = fuel; changed = true; }
        y += ROW_ADV;
        bool hnf = Ui.Toggle("Heater_NoFuel", R(x, y, COL_TOG_W3, ROW_H), s.Heater_NoFuel, I18n.T(" 鲸油取暖器不耗油", " Heater Uses No Oil"), ToggleStyle ?? GUI.skin.toggle);
        if (hnf != s.Heater_NoFuel) { s.Heater_NoFuel = hnf; changed = true; }
        y += ROW_ADV;
        float hm = DrawSliderCol3(R, x, y, I18n.T("取暖器耗油", "Heater Oil"), s.Heater_FuelMult, 0.1f, 5f, "F1", key: "Heater_FuelMult");
        hm = Mathf.Round(hm * 10f) / 10f;
        if (hm != s.Heater_FuelMult) { s.Heater_FuelMult = hm; changed = true; }
        y += ROW_ADV;
        float ht = DrawSliderCol3(R, x, y, I18n.T("取暖器加温", "Heater +°C"), s.Heater_TempBonus, 0f, 50f, "F0", key: "Heater_TempBonus");
        ht = Mathf.Round(ht);
        if (ht != s.Heater_TempBonus) { s.Heater_TempBonus = ht; changed = true; }
        y += ROW_ADV;
        float wl = Mathf.Round(DrawSliderCol3(R, x, y, I18n.T("鲸油罐上限", "Oil Can L"), s.OilCan_WhaleMaxL, 0f, 2000f, "F0", key: "OilCan_WhaleMaxL") / 5f) * 5f;
        if (wl != s.OilCan_WhaleMaxL) { s.OilCan_WhaleMaxL = wl; changed = true; OilCans.ApplyToInventory(); }
        y += ROW_ADV;
        float kl = Mathf.Round(DrawSliderCol3(R, x, y, I18n.T("油桶上限", "Jerrycan L"), s.OilCan_KeroseneMaxL, 0f, 2000f, "F0", key: "OilCan_KeroseneMaxL") / 5f) * 5f;
        if (kl != s.OilCan_KeroseneMaxL) { s.OilCan_KeroseneMaxL = kl; changed = true; OilCans.ApplyToInventory(); }
        y += ROW_ADV;
        Ui.Hover("OilCan_MergeWhale", R(x, y, subTogW, ROW_H));
        if (GUI.Button(R(x, y, subTogW, ROW_H), I18n.T("合并鲸油罐", "Merge Oil Cans"))) OilCans.Merge(OilCans.Kind.WhaleOil);
        Ui.Hover("OilCan_MergeKerosene", R(xSub, y, subTogW, ROW_H));
        if (GUI.Button(R(xSub, y, subTogW, ROW_H), I18n.T("合并油桶", "Merge Jerrycans"))) OilCans.Merge(OilCans.Kind.Kerosene);
        y += ROW_ADV + SECTION_END_ADV;
        return y;
    }
#endif

    internal static float CardMiscToggles(Func<float, float, float, float, Rect> R, TldHacksSettings s, float x, float y, ref bool changed)
    {
        float subTogW = HALF_W, xSub = x + HALF_OFF;
        bool b;
        y = SectionCol(R, x, y, COL_W3, I18n.T("杂项开关", "Misc Toggles"));
        b = Ui.Toggle("UT_BreathVisibility", R(x,    y, subTogW, ROW_H), s.UT_BreathVisibility,    I18n.T(" 哈气特效", " Breath"), ToggleStyle ?? GUI.skin.toggle);
        bool bb = Ui.Toggle("UT_FeatProgressInCustom", R(xSub, y, subTogW, ROW_H), s.UT_FeatProgressInCustom, I18n.T(" 难度徽章", " Feat Custom"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.UT_BreathVisibility) { s.UT_BreathVisibility = b; changed = true; }
        if (bb != s.UT_FeatProgressInCustom) { s.UT_FeatProgressInCustom = bb; changed = true; }
        y += ROW_ADV;
        b  = Ui.Toggle("UT_RandomizedItemRotation", R(x,    y, subTogW, ROW_H), s.UT_RandomizedItemRotation, I18n.T(" 随机朝向", " Random Rot"), ToggleStyle ?? GUI.skin.toggle);
        bb = Ui.Toggle("UT_RevolverImprovements", R(xSub, y, subTogW, ROW_H), s.UT_RevolverImprovements,   I18n.T(" 左轮可走", " Revolver Walk"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.UT_RandomizedItemRotation) { s.UT_RandomizedItemRotation = b; changed = true; }
        if (bb != s.UT_RevolverImprovements) { s.UT_RevolverImprovements = bb; changed = true; }
        y += ROW_ADV;
        b  = Ui.Toggle("UT_RemoveHeadacheDebuff", R(x,    y, subTogW, ROW_H), s.UT_RemoveHeadacheDebuff, I18n.T(" 免甜点疼", " No Pie Ache"), ToggleStyle ?? GUI.skin.toggle);
        bb = Ui.Toggle("UT_RockCacheIndoors", R(xSub, y, subTogW, ROW_H), s.UT_RockCacheIndoors,     I18n.T(" 室内贮石", " Indoor Rocks"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.UT_RemoveHeadacheDebuff) { s.UT_RemoveHeadacheDebuff = b; changed = true; }
        if (bb != s.UT_RockCacheIndoors) { s.UT_RockCacheIndoors = bb; changed = true; }
        y += ROW_ADV;
        b  = Ui.Toggle("UT_GlowingDecals", R(x,    y, subTogW, ROW_H), s.UT_GlowingDecals,             I18n.T(" 高亮喷漆", " Glow Decals"), ToggleStyle ?? GUI.skin.toggle);
        bb = Ui.Toggle("UT_TravoisOverrideMovement", R(xSub, y, subTogW, ROW_H), s.UT_TravoisOverrideMovement,   I18n.T(" 雪橇可动", " Travois Move"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.UT_GlowingDecals) { s.UT_GlowingDecals = b; changed = true; }
        if (bb != s.UT_TravoisOverrideMovement) { s.UT_TravoisOverrideMovement = bb; changed = true; }
        y += ROW_ADV;
        b  = Ui.Toggle("UT_TravoisOverrideInteraction", R(x,    y, subTogW, ROW_H), s.UT_TravoisOverrideInteraction, I18n.T(" 雪橇可拿", " Travois Int"), ToggleStyle ?? GUI.skin.toggle);
        bb = Ui.Toggle("UT_ToiletWaterPotable", R(xSub, y, subTogW, ROW_H), s.UT_ToiletWaterPotable,         I18n.T(" 马桶可饮", " Toilet Potable"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.UT_TravoisOverrideInteraction) { s.UT_TravoisOverrideInteraction = b; changed = true; }
        if (bb != s.UT_ToiletWaterPotable) { s.UT_ToiletWaterPotable = bb; changed = true; }
        y += ROW_ADV;
        // v9.0 搬运猎物 / 搬运全部 挪到「人物 & 操作」单独成块,极光点火补到这一行右格
        b  = Ui.Toggle("UT_ConsistantDressingWeight", R(x,    y, subTogW, ROW_H), s.UT_ConsistantDressingWeight, I18n.T(" 绷带统重", " Bandage Weight"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.UT_ConsistantDressingWeight) { s.UT_ConsistantDressingWeight = b; changed = true; }
#if STORY_GUARD
        // 剧情版:极光点火挂 MissionServicesManager 任务注册 → 禁用灰显
        bool _worldBlocked = StoryGuard.InStory;
        if (_worldBlocked) GUI.enabled = false;
#endif
        bb = Ui.Toggle("World_ElectricTorch", R(xSub, y, subTogW, ROW_H), s.World_ElectricTorch, I18n.T(" 极光点火", " Aurora Torch"), ToggleStyle ?? GUI.skin.toggle);
#if STORY_GUARD
        if (_worldBlocked) GUI.enabled = true;
#endif
        if (bb != s.World_ElectricTorch) { s.World_ElectricTorch = bb; CheatState.World_ElectricTorch = bb; changed = true; }
        y += ROW_ADV + SECTION_END_ADV;
        return y;
    }
}

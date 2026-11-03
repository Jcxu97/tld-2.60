// StoryGuard.cs — 剧情模式(Wintermute)适配层。
//
// 整个文件仅在 STORY_EDITION 编译符号下参与编译:
//   • 沙盒版 (TldHacks.dll)  → 无 STORY_EDITION → 本文件为空,IL 零贡献,DLL 字节不变。
//   • 剧情版 (TldHacksStory.dll) → 定义 STORY_EDITION → 本层生效。
//
// 设计:剧情下把"沙盒专属 / 会破坏线性进度或存档"的开关强制清零,靠已有的
//   DynamicPatch.Reconcile() 自然卸载对应 patch(见 [[reference_bg3_update_mod_workflow]] 之外
//   的 TldHacks DynamicPatch 方法论)。一次性动作(跨场景传送)在入口处直接拦截。
//
// 分类依据:剧情安全性分类 workflow(29 agent,对抗验证)最终 BLOCK 清单 +
//   用户锁定决策(沙盒专属→禁用灰显;传送→禁用,飞行→保留)。
#if STORY_GUARD
using Il2Cpp;

namespace TldHacks;

internal static class StoryGuard
{
    // 当前是否处于 Wintermute 剧情存档。GameManager.IsStoryMode() 是公开静态 bool,
    // 主菜单/沙盒返回 false,剧情存档返回 true。异常兜底 false(按沙盒放行,绝不误伤)。
    internal static bool InStory
    {
        get
        {
            try { return GameManager.IsStoryMode(); }
            catch { return false; }
        }
    }

    // 在 SyncStateFromSettings() 末尾调用(init + 每 30 帧)。
    // 剧情下强制清掉被 BLOCK 的持久开关 —— 下一次 Reconcile(每 300 帧)据此卸载 patch。
    // Enforce 频率(30帧)是 Reconcile(300帧)的 10 倍,patch 无法在两次 Reconcile 之间偷偷 latch 住。
    //
    // V1.0 取"最保守"边界(用户不做实测 → 宁可多禁):
    //   凡是会 [写存档场景数据 / 挂任务注册 / 操纵任务物品 / 脚本化时间或天气 / 跨区传送]
    //   的开关一律清零。只留纯个人增益(无敌/无需求/耐久/秒采集制作/瞄准/技能/地图全开/飞行)。
    //
    // BLOCK 明细:
    //   商人整套(信任/交易/常驻/清单/显示信任)+ 美洲狮召唤            —— 沙盒专属系统,剧情里对象不存在
    //   地图双击传送 + 跨区传送(TravelTo 入口拦)                     —— 跨场景传送破坏线性剧情
    //   天气分级/锁天气 + 时间跳跃                                    —— 脚本化时间天气可跳过/卡死任务触发
    //   极光点火(挂 MissionServicesManager)                          —— 触碰任务对象注册
    //   埋葬尸体 / 植物重生(挂 SaveGameSystem.Save/LoadSceneData)     —— 写持久场景存档
    //   搬运猎物(改 BodyHarvest 持久态)                              —— 改场景持久状态
    //   任意丢弃(可丢任务物品)                                      —— 丢弃剧情物品 = 死锁风险
    // 保留 SAFE:飞行(CFly)、全开地图、全部生存增益(无敌/无饥渴/耐久/秒采集/秒制作/技能满级 等)。
    private static bool _wasInStory;

    internal static void Enforce()
    {
        bool inStory = InStory;
        // 刚进剧情存档的这一轮就 Reconcile:下面清掉的开关对应的 patch 当场卸,别等下一个 300 帧周期
        if (inStory && !_wasInStory) TldHacksSettings.MarkPatchDirty();
        _wasInStory = inStory;
        if (!inStory) return;
        // — 商人 & 美洲狮(沙盒专属)—
        CheatState.TraderUnlimitedList   = false;
        CheatState.TraderMaxTrust        = false;
        CheatState.TraderUnlockModeItems = false;
        CheatState.TraderInstantExchange = false;
        CheatState.TraderAlwaysAvailable = false;
        CheatState.TT_ShowTraderTrust    = false;
        CheatState.CougarInstantActivate = false;
        // — 传送 —
        CheatState.MapClickTP            = false;
        // — 时间 / 天气脚本化 —
        CheatState.WeatherLocked         = false;
        // — 任务注册 / 存档场景写入 —
        CheatState.World_ElectricTorch   = false;
        CheatState.QoL_BuryCorpses       = false;
        CheatState.TT_RespawnPlants      = false;
        // — 场景持久态 —
        CheatState.World_CarcassMoving   = false;
        CheatState.World_CarcassMovingAll = false;
        // — 任务物品死锁风险 —
        CheatState.DroppableUndroppables = false;
        // — 2.24 缺 API,功能无法实现(patch 类已在编译期排除,这里同步关掉开关避免 UI 误导)—
#if STORY_EDITION
        CheatState.Craft_MoreCookingSlots = false;
#endif
    }
}
#endif

using ModSettings;
using UnityEngine;

namespace MoreBunkers;

// 英文版文字在 SettingsEn.cs,游戏语言是英文时建面板换上去
internal class Settings : JsonModSettings
{
    [Section("更多地堡")]

    [Name("启用新地堡")]
    [Description("新增三个地堡:工匠地堡在神秘湖,囤货地堡在沿海公路,雇佣兵地堡在废弃机场。TldHacks 的快速传送里有这三个地堡。")]
    public bool Enabled = true;

    [Name("入侵者和厄难也生成")]
    [Description("关掉以后,入侵者和厄难难度下不出现新地堡。")]
    public bool OnHardModes = true;

    [Name("物资多少")]
    [Description("吃的、水、弹药、药、燃料和材料的数量,架子上摆的也算。朝圣者给全量,囤货地堡够一个人过半年;旅行者一半,潜行者三分之一,入侵者约五分之一,厄难约十二分之一;自定义难度按潜行者。衣服、工具、武器、书在入侵者每件七成五机会留下,厄难四成,其他难度全留。只在新档第一次进地堡时生效,已经布置过的地堡不变。")]
    [Choice("跟随游戏难度", "朝圣者", "旅行者", "潜行者", "入侵者", "厄难")]
    public int Amount = 0;

    [Name("位置提示键")]
    [Description("按一下,屏幕上提示这个存档的三个新地堡分别在哪张图、哪个地点旁边。")]
    public KeyCode InfoKey = KeyCode.Home;

    protected override void OnConfirm()
    {
        base.OnConfirm();
        ModMain.OnSettingsChanged();
    }
}

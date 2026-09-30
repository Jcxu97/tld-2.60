using ModSettings;
using UnityEngine;

namespace TraderMoving;

internal class Settings : JsonModSettings
{
    [Section("搬运无线电")]

    [Name("启用搬运无线电")]
    [Description("对着交易者无线电按搬运键抱起来,走到别处放下。放下后仍可召唤商人、正常交易。")]
    public bool EnableRadio = true;

    [Name("启用搬运交易箱")]
    [Description("同样可以搬走交易箱。默认关闭:交易箱是取回已提交物品的唯一入口,搬错了有丢装备的风险。")]
    public bool EnableExchangeBox = false;

    [Section("操作")]

    [Name("选中键")]
    [Description("对着无线电或交易箱按此键选中,然后点右键收进背包。装了 SCPlus 时走它的背包体系(和搬壁炉一样);没装则改为抱着走。")]
    public KeyCode CarryKey = KeyCode.Y;

    [Name("诊断键")]
    [Description("按此键把当前状态(无线电在哪、背包里有什么、各字段真值)写进 MelonLoader 日志。出问题时按一下,把日志给开发者。")]
    public KeyCode DiagnoseKey = KeyCode.F9;

    [Section("负重")]

    [Name("无线电重量(公斤)")]
    [Description("抱着无线电时额外增加的负重,影响体力和热量消耗。")]
    [Slider(0f, 40f, 41)]
    public float RadioWeight = 6f;

    [Name("交易箱重量(公斤)")]
    [Description("抱着交易箱时额外增加的负重。")]
    [Slider(0f, 40f, 41)]
    public float BoxWeight = 10f;

    [Name("允许受伤时搬运")]
    [Description("关闭时,扭伤脚踝/手腕或断肋骨期间不能搬运(和搬运猎物的规则一致)。")]
    public bool AllowCarryWhileInjured = false;

    [Section("安全")]

    [Name("交易进行中禁止搬运")]
    [Description("强烈建议保持开启。交易进行中搬走无线电或箱子,已提交的物品可能永久卡在存档里拿不回来。关闭此项则只弹警告不阻止。")]
    public bool BlockDuringActiveTrade = true;

    protected override void OnConfirm()
    {
        base.OnConfirm();
        ModMain.Log?.Msg($"[TraderMoving] 设置已更新: radio={EnableRadio} box={EnableExchangeBox} key={CarryKey} guard={BlockDuringActiveTrade}");
    }
}

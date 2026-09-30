using ModSettings;
using UnityEngine;

namespace TraderMoving;

internal class Settings : JsonModSettings
{
    [Section("搬运")]

    [Name("启用搬运无线电")]
    [Description("看着商人无线电按选中键,再点右键抱起来,走到哪放到哪。放回原来那间屋子里就是原版无线电;放在别处是随身无线电,能下单、完成交易,没有语音对话。")]
    public bool EnableRadio = true;

    [Name("启用搬运交易箱")]
    [Description("交易箱也能抱走,放在任何地方都行,读档后还在。放好以后商人的货都送到这个箱子。")]
    public bool EnableExchangeBox = true;

    [Name("选中键")]
    [Description("看着无线电或交易箱按一下选中,再点右键抱起。看着随身无线电选中后再按一下是呼叫商人。抱着东西时按这个键或右键放下。")]
    public KeyCode CarryKey = KeyCode.Y;

    [Name("诊断键")]
    [Description("把无线电和交易箱现在在哪、交易状态写进 MelonLoader 日志。出问题时按一下,把日志发给作者。")]
    public KeyCode DiagnoseKey = KeyCode.F9;

    [Section("负重")]

    [Name("无线电重量(公斤)")]
    [Description("抱着无线电时多算的负重,影响体力和热量消耗。")]
    [Slider(0f, 40f, 41)]
    public float RadioWeight = 6f;

    [Name("交易箱重量(公斤)")]
    [Description("抱着交易箱时多算的负重。")]
    [Slider(0f, 40f, 41)]
    public float BoxWeight = 10f;

    [Name("受伤时也能搬")]
    [Description("关闭时,扭伤脚踝、扭伤手腕或断了肋骨就不能搬。")]
    public bool AllowCarryWhileInjured = false;

    [Section("交易")]

    [Name("货送到我搬的交易箱")]
    [Description("开着时,不管在哪台无线电下单,商人都把货送到你搬过的那个交易箱。")]
    public bool DeliverToMovedBox = true;

    [Name("随身无线电不用等极光")]
    [Description("原版要等极光无线电才有电。开了以后随身无线电随时能呼叫商人。TldHacks 开了商人常驻时也不用等。")]
    public bool PortableRadioAlwaysOn = false;

    [Name("箱里有货时禁止搬交易箱")]
    [Description("交易箱里已经放了货、或者奖励还没拿走时不让搬,免得东西拿不回来。建议一直开着。")]
    public bool BlockDuringActiveTrade = true;

    [Section("还原")]

    [Name("放回原处")]
    [Description("打开后点确认,无线电和交易箱都回到原版位置,你放的那两样会消失。只影响当前存档,下次存档时生效。")]
    public bool ResetAll = false;

    protected override void OnConfirm()
    {
        bool doReset = ResetAll;
        ResetAll = false;
        base.OnConfirm();
        if (doReset)
        {
            World.ResetAll();
            try { RefreshGUI(); } catch { }
        }
        ModMain.Log?.Msg($"[TraderMoving] 设置已更新: radio={EnableRadio} box={EnableExchangeBox} key={CarryKey} deliver={DeliverToMovedBox} alwaysOn={PortableRadioAlwaysOn} guard={BlockDuringActiveTrade}");
    }
}

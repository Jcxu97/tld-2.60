using ModSettings;
using UnityEngine;

namespace HutDoorTorch;

internal class Settings : JsonModSettings
{
    [Section("壁挂火把")]

    [Name("倾斜角度")]
    [Description("火把从墙面往外斜出来的角度,0 是贴墙竖直,90 是水平伸出。改了以后新做和读档后的火把生效。")]
    [Slider(0f, 80f, 17)]
    public float TiltDegrees = 35f;

    [Name("火光亮度")]
    [Description("1 是原版火把烧旺时的亮度。")]
    [Slider(0.2f, 2f, 19)]
    public float LightIntensity = 1f;

    [Name("火光闪烁")]
    [Description("火光明暗跳动的幅度,0 是不闪。打开下面的原版跳动时不起作用。")]
    [Slider(0f, 0.5f, 11)]
    public float Flicker = 0.1f;

    [Name("原版跳动")]
    [Description("像手里的原版火把那样,每 0.2 秒在最暗和最亮之间随机跳一次(室内 3 到 5,室外 0.8 到 1.6)。关掉时一直按最亮的值,只做上面那种轻微闪烁。")]
    public bool VanillaFlicker = false;

    [Section("钓鱼小屋门")]

    [Name("关门挡风")]
    [Description("关上门时屋里不进风,开门恢复。")]
    public bool DoorBlocksWind = true;

    [Name("开门方向反过来")]
    [Description("门往里开碰到东西时打开这个。")]
    public bool DoorOpensInward = false;
}

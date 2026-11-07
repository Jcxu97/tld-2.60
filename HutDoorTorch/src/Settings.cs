using ModSettings;
using UnityEngine;

namespace HutDoorTorch;

internal class Settings : JsonModSettings
{
    [Section("壁挂火把")]

    [Name("挂火把键")]
    [Description("背包里有壁挂火把时按一下,看着墙会出现虚影,左键挂上,右键取消。")]
    public KeyCode PlaceKey = KeyCode.H;

    [Name("倾斜角度")]
    [Description("火把从墙面往外斜出来的角度,0 是贴墙竖直,90 是水平伸出。")]
    [Slider(0f, 80f, 17)]
    public float TiltDegrees = 35f;

    [Name("火光亮度")]
    [Slider(0.2f, 3f, 29)]
    public float LightIntensity = 1.2f;

    [Section("钓鱼小屋门")]

    [Name("关门挡风")]
    [Description("关上门时屋里不进风,开门恢复。")]
    public bool DoorBlocksWind = true;

    [Name("开门方向反过来")]
    [Description("门往里开碰到东西时打开这个。")]
    public bool DoorOpensInward = false;
}

using System.Reflection;
using Il2Cpp;
using Il2CppVLB;
using ModSettings;
using UnityEngine;

namespace SCPlus;

internal class SCPSettings : JsonModSettings
{
	[Section("通用设置")]
	[Name("隐藏左上角安全屋图标")]
	[Description("隐藏安全屋自定义图标，默认：仅在自定义操作时显示")]
	[Choice(new string[] { "始终显示", "仅在自定义操作时显示", "始终隐藏" })]
	public int hideIcon = 1;

	[Name("工作台互动方式")]
	[Description("维持原始的工作台互动方式，即游戏更新自定义全屋模式之前，鼠标右键可拆解，默认=是")]
	public bool altWorkbenchInteraction = true;

	[Name("重量估算")]
	[Description("根据装饰物的材质和模型体积进行重量估算，可能产生非预期结果。默认=是")]
	public bool doWeightCalculation = true;

	[Name("重量倍数")]
	[Description("可根据喜好调整重量近似值（在获得新物品或游戏重启后更新），默认值=1")]
	[Slider(0.1f, 2f, 20)]
	public float autoWeightMultiplier = 1f;

	[Section("高亮轮廓")]
	[Name("可见性")]
	[Description("高亮轮廓显示时机\n\n为确保设置生效，请重新进入自定义模式进行应用")]
	[Choice(new string[] { "保持默认", "靠近玩家时", "鼠标对准时", "禁用" })]
	public int outlineVisibility;

	[Name("可视距离")]
	[Description("基于距离的高亮轮廓可见性。较低值会使轮廓在靠近物体时更容易显示，感觉像是撞到东西时会发光")]
	[Slider(0f, 16f, 33)]
	public float outlineDistance = 3f;

	[Name("色调")]
	[Description("默认=0.61")]
	[Slider(0f, 1f, 101, NumberFormat = "{0:0.00}")]
	public float outlineHue = 0.61f;

	[Name("透明度")]
	[Description("默认=0.15")]
	[Slider(0f, 1f, 21, NumberFormat = "{0:0.00}")]
	public float outlineAlpha = 0.15f;

	[Name("粗细程度")]
	[Description("默认=4")]
	[Slider(0f, 20f, 21)]
	public float outlineThickness = 4f;

	[Section("开发者模式")]
	[Name("启用开发者查看模式")]
	[Description("按Y键后，对准目标使用shift + 鼠标右键进入物品查看模式，使用箭头方向键调整位置，使用加号和减号键进行缩放，按下0键截图并显示物品名称。\n截图自动保存在mods/SCPlus文件夹下")]
	public bool devInspect;

	[Name("调试")]
	[Description("将调试信息发送到控制台")]
	public bool debugLog;

	[Name("加载间隔")]
	[Description("即帧跳过设置，较低的值会导致卡顿更少，但耗时更长；较高的值会导致卡顿更多，但耗时更短。\n\n在加载过程中不要退出或进入过渡状态")]
	[Slider(2f, 100f)]
	public int carryableProcessingInterval = 10;

	[Section("作弊")]
	[Name("复制功能")]
	[Description("设置热键，鼠标对准目标按下热键可复制装饰物品")]
	public KeyCode dupeKey;

	[Name("右键摆放移动装饰物免负重")]
	[Description("自定义安全屋模式下，鼠标右键在摆放或移动装饰物时，系统不计算其重量，不会影响到你的移动速度")]
	public bool ignorePlaceWeight;

	[Name("全局重量调节系数")]
	[Description("重量系数调整后，游戏不会立即把所有现有物品的重量都按新系数重新计算一遍。会在你获得新物品，或者游戏重启后生效更新")]
	[Slider(0f, 1f, 11)]
	public float globalWeightModifier = 1f;

	protected override void OnChange(FieldInfo field, object oldValue, object newValue)
	{
		if (field.Name == "outlineHue")
		{
			Settings.hueSliderThumb.color = Utility.outlineColor.HueAdjust((float)newValue);
		}
		if (field.Name == "outlineVisibility")
		{
			Settings.ShowDistance((int)newValue == 1);
			Settings.ShowOutline((int)newValue != 3);
		}
	}

	protected override void OnConfirm()
	{
		base.OnConfirm();
		SafehouseManager safehouseManager = GameManager.GetSafehouseManager();
		safehouseManager.m_OutlineColor = Utility.outlineColor.HueAdjust(Settings.options.outlineHue).AlphaAdjust(Settings.options.outlineAlpha);
		safehouseManager.m_OnHoverColor = Utility.outlineColor.HueAdjust(Settings.options.outlineHue);
		safehouseManager.m_OnHoverPropertyBlock.SetColor("_Color", safehouseManager.m_OnHoverColor);
		safehouseManager.m_OutlineThickness = Settings.options.outlineThickness;
		safehouseManager.DisableOutlineRendering();
		safehouseManager.EnableOutlineRendering();
		if (!GameManager.GetSafehouseManager().IsCustomizing())
		{
			return;
		}
		SCPlusDecorationDetector component;
		if (Settings.options.outlineVisibility == 1)
		{
			SCPlusDecorationDetector orAddComponent = GameManager.GetPlayerTransform().gameObject.GetOrAddComponent<SCPlusDecorationDetector>();
			if (orAddComponent.cc != null)
			{
				orAddComponent.cc.radius = Settings.options.outlineDistance;
			}
		}
		else if (GameManager.GetPlayerTransform().TryGetComponent<SCPlusDecorationDetector>(out component))
		{
			Object.Destroy(component);
		}
	}
}

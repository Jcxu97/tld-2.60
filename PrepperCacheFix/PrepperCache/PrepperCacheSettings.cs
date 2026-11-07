using System.Reflection;
using Il2Cpp;
using ModSettings;
using UnityEngine;

namespace PrepperCache;

internal class PrepperCacheSettings : JsonModSettings
{
	[Section("通用设置")]
	[Name("启用记录地堡分布数据")]
	[Description("启用/禁用地堡分布数据记录到 mods / PrepperCache 文件")]
	public bool enablePrepperCacheDataCapture;

	[Name("手动查看地堡快捷键")]
	[Description("按下该键手动查看当前存档的地堡分布")]
	public KeyCode captureKey = (KeyCode)260;

	[Name("启用HUD提示信息")]
	[Description("启用/禁用在屏幕中央显示地堡位置提示")]
	public bool enablePrepperCacheHUDDisplay;

	[Name("地堡分布提示显示时长")]
	[Description("地堡分布信息在屏幕中央显示的秒数")]
	[Slider(0f, 30f)]
	public int hudDisplayDuration = 10;

	[Name("启用世界地图标注")]
	[Description("启用/禁用在世界地图上标注地堡位置")]
	public bool enablePrepperCacheWorldMapDisplay = true;

	protected override void OnChange(FieldInfo field, object oldValue, object newValue)
	{
	}

	protected override void OnConfirm()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		base.OnConfirm();
		Settings.enablePrepperCacheDataCapture = enablePrepperCacheDataCapture;
		Settings.enablePrepperCacheHUDDisplay = enablePrepperCacheHUDDisplay;
		Settings.hudDisplayDuration = hudDisplayDuration;
		Settings.enablePrepperCacheWorldMapDisplay = enablePrepperCacheWorldMapDisplay;
		PrepperCacheMain.previousPosition = ((Component)GameManager.GetVpFPSPlayer()).transform.position;
	}
}

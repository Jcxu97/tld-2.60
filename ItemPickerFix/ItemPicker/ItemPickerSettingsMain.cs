using ModSettings;
using UnityEngine;

namespace ItemPicker;

internal class ItemPickerSettingsMain : JsonModSettings
{
	[Section("热键绑定")]
	[Name("自动拾取")]
	[Description("半径范围内自动拾取")]
	public KeyCode buttonPickSticks = (KeyCode)308;

	[Section("常用设置")]
	[Name("拾取物")]
	[Description("选择你要拾取的对象，树枝，石块或者树枝和石块同时拾取")]
	[Choice(new string[] { "树枝", "石块", "树枝和石块" })]
	public int pickupChoice = 2;

	[Name("拾取半径")]
	[Description("以玩家为中心设置拾取半径，半径范围内的物品会自动拾取")]
	[Slider(0f, 25f)]
	public float pickupRadius = 2f;

	[Name("自动拾取卡路里消耗")]
	[Description("拾取一根树枝或一块石头的卡路里消耗 (拾取1个以上的卡路里消耗额外增加)")]
	[Slider(0f, 25f)]
	public int calorieCost = 5;

	[Name("启用自定义物品拾取菜单")]
	[Description("可自定义设置你要拾取的物品(注意:有些物品未必有效)，在MODS文件夹下有个StickPickCustomList.txt文件，可自己添加要拾取的物品代码")]
	public bool pickUpAdditionalItems;

	[Section("其他")]
	[Name("树枝和石块拾取时跳过物品查看")]
	[Description("树枝和石块手动拾取时跳过物品查看，自动入库")]
	public bool skipInspect;

	[Name("拾取任何物品都跳过物品查看")]
	[Description("任何物品在手动拾取时都跳过物品查看(警告:为测试，不一定对所有物品都有效)")]
	public bool skipInspectAll;

	protected override void OnConfirm()
	{
		base.OnConfirm();
		ItemPickerMain.loadCustomItemList();
	}
}

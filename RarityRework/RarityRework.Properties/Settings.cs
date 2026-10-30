using System.Reflection;
using RarityRework.Utilities;
using ModSettings;

namespace RarityRework.Properties;

internal class Settings : JsonModSettings
{
	[Name("随机词条模式")]
	[Description("开启后衣物、武器和工具逐件随机档位、材质和词条；关闭时按固定分档表显示。游戏内切换后需重新读档才完全生效，已掷出的词条不会丢失")]
	public bool randomAffixes;

	[Name("自定义颜色")]
	[Description("开启后可以自定义每个档位的颜色")]
	public bool customColours;

	[Section("普通")]
	[Name("红色")]
	public float commonRed = 0.6f;

	[Name("绿色")]
	public float commonGreen = 0.6f;

	[Name("蓝色")]
	public float commonBlue = 0.6f;

	[Section("优秀")]
	[Name("红色")]
	public float uncommonRed = 0.3f;

	[Name("绿色")]
	public float uncommonGreen = 0.7f;

	[Name("蓝色")]
	public float uncommonBlue;

	[Section("精良")]
	[Name("红色")]
	public float rareRed;

	[Name("绿色")]
	public float rareGreen = 0.6f;

	[Name("蓝色")]
	public float rareBlue = 0.9f;

	[Section("史诗")]
	[Name("红色")]
	public float epicRed = 0.7f;

	[Name("绿色")]
	public float epicGreen = 0.3f;

	[Name("蓝色")]
	public float epicBlue = 0.9f;

	[Section("传说")]
	[Name("红色")]
	public float legendaryRed = 0.9f;

	[Name("绿色")]
	public float legendaryGreen = 0.5f;

	[Name("蓝色")]
	public float legendaryBlue = 0.2f;

	[Section("神话")]
	[Name("红色")]
	public float mythicRed = 0.9f;

	[Name("绿色")]
	public float mythicGreen = 0.15f;

	[Name("蓝色")]
	public float mythicBlue = 0.15f;

	internal static Settings Instance { get; }

	protected override void OnChange(FieldInfo field, object oldValue, object newValue)
	{
		RefreshFields();
	}

	internal static void OnLoad()
	{
		Instance.AddToModSettings("物品稀有度重制 v1.0.0");
		Instance.RefreshFields();
		Instance.RefreshGUI();
	}

	private void RefreshFields()
	{
		SettingsUtilities.UpdateFieldVisibilities(customColours);
	}

	static Settings()
	{
		Instance = new Settings();
	}
}

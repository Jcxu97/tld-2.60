using System.Reflection;
using ItemRarities.Utilities;
using ModSettings;

namespace ItemRarities.Properties;

internal class Settings : JsonModSettings
{
	[Name("自定义颜色")]
	[Description("启用该功能后，您可以自定义每种稀有度的颜色")]
	public bool customColours;

	[Section("Lv1")]
	[Name("红色")]
	public float commonRed = 0.6f;

	[Name("绿色")]
	public float commonGreen = 0.6f;

	[Name("蓝色")]
	public float commonBlue = 0.6f;

	[Section("Lv2")]
	[Name("红色")]
	public float uncommonRed = 0.3f;

	[Name("绿色")]
	public float uncommonGreen = 0.7f;

	[Name("蓝色")]
	public float uncommonBlue;

	[Section("Lv3")]
	[Name("红色")]
	public float rareRed;

	[Name("绿色")]
	public float rareGreen = 0.6f;

	[Name("蓝色")]
	public float rareBlue = 0.9f;

	[Section("Lv4")]
	[Name("红色")]
	public float epicRed = 0.7f;

	[Name("绿色")]
	public float epicGreen = 0.3f;

	[Name("蓝色")]
	public float epicBlue = 0.9f;

	[Section("Lv5")]
	[Name("红色")]
	public float legendaryRed = 0.9f;

	[Name("绿色")]
	public float legendaryGreen = 0.5f;

	[Name("蓝色")]
	public float legendaryBlue = 0.2f;

	[Section("Lv6")]
	[Name("红色")]
	public float mythicRed = 0.8f;

	[Name("绿色")]
	public float mythicGreen = 0.7f;

	[Name("蓝色")]
	public float mythicBlue = 0.3f;

	internal static Settings Instance { get; }

	protected override void OnChange(FieldInfo field, object oldValue, object newValue)
	{
		RefreshFields();
	}

	internal static void OnLoad()
	{
		Instance.AddToModSettings("物品品阶分类v2.0.5");
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

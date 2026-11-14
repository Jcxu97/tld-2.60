using System.Reflection;
using RarityRework.Utilities;
using ModSettings;

namespace RarityRework.Properties;

internal class Settings : JsonModSettings
{
	[Name("随机词条模式")]
	[Description("开启后衣物、武器和工具逐件随机档位、材质和词条；关闭时按固定分档表显示。游戏内切换后需重新读档才完全生效，已掷出的词条不会丢失")]
	public bool randomAffixes;

	[Section("随机档位概率")]
	[Name("普通")]
	[Description("新掷出的物品落到这一档的权重。拉到 0 就不出这一档，六档按比例分摊，加起来不用等于 100。已经掷过的物品不变")]
	[Slider(0f, 100f, 201)]
	public float weightCommon = 45f;

	[Name("优秀")]
	[Description("同上，拉到 0 就不出这一档")]
	[Slider(0f, 100f, 201)]
	public float weightUncommon = 28f;

	[Name("精良")]
	[Description("同上，拉到 0 就不出这一档。原本就是史诗以上的物品最低给精良，这条不受影响")]
	[Slider(0f, 100f, 201)]
	public float weightRare = 15f;

	[Name("史诗")]
	[Description("同上，拉到 0 就不出这一档")]
	[Slider(0f, 100f, 201)]
	public float weightEpic = 8f;

	[Name("传说")]
	[Description("同上，拉到 0 就不出这一档")]
	[Slider(0f, 100f, 201)]
	public float weightLegendary = 3.5f;

	[Name("神话")]
	[Description("同上，拉到 0 就不出这一档")]
	[Slider(0f, 100f, 201)]
	public float weightMythic = 0.5f;

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
		Instance.AddToModSettings("物品稀有度重制 v1.2.0");
		Instance.RefreshFields();
		Instance.RefreshGUI();
	}

	private void RefreshFields()
	{
		SettingsUtilities.UpdateFieldVisibilities(customColours);
		foreach (string f in WeightFields)
		{
			SetFieldVisible(f, randomAffixes);
		}
	}

	private static readonly string[] WeightFields = { "weightCommon", "weightUncommon", "weightRare", "weightEpic", "weightLegendary", "weightMythic" };

	// Index 1..6 matches Rarities.
	internal float[] TierWeights()
	{
		return new[] { 0f, weightCommon, weightUncommon, weightRare, weightEpic, weightLegendary, weightMythic };
	}

	static Settings()
	{
		Instance = new Settings();
	}
}

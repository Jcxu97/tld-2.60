using RarityRework.Properties;

namespace RarityRework.Utilities;

internal static class SettingsUtilities
{
	internal static void UpdateFieldVisibilities(bool visible)
	{
		Settings.Instance.SetFieldVisible("commonRed", visible);
		Settings.Instance.SetFieldVisible("commonGreen", visible);
		Settings.Instance.SetFieldVisible("commonBlue", visible);
		Settings.Instance.SetFieldVisible("uncommonRed", visible);
		Settings.Instance.SetFieldVisible("uncommonGreen", visible);
		Settings.Instance.SetFieldVisible("uncommonBlue", visible);
		Settings.Instance.SetFieldVisible("rareRed", visible);
		Settings.Instance.SetFieldVisible("rareGreen", visible);
		Settings.Instance.SetFieldVisible("rareBlue", visible);
		Settings.Instance.SetFieldVisible("epicRed", visible);
		Settings.Instance.SetFieldVisible("epicGreen", visible);
		Settings.Instance.SetFieldVisible("epicBlue", visible);
		Settings.Instance.SetFieldVisible("legendaryRed", visible);
		Settings.Instance.SetFieldVisible("legendaryGreen", visible);
		Settings.Instance.SetFieldVisible("legendaryBlue", visible);
		Settings.Instance.SetFieldVisible("mythicRed", visible);
		Settings.Instance.SetFieldVisible("mythicGreen", visible);
		Settings.Instance.SetFieldVisible("mythicBlue", visible);
	}
}

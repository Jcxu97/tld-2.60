namespace ItemPicker;

internal static class Settings
{
	public static ItemPickerSettingsMain options;

	public static void OnLoad()
	{
		options = new ItemPickerSettingsMain();
		options.AddToModSettings("树枝和石块自动拾取v1.0");
		ItemPickerMain.loadCustomItemList();
	}
}

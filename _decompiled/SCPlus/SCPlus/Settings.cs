using Il2Cpp;

namespace SCPlus;

internal static class Settings
{
	public static UISprite hueSliderThumb;

	public static SCPSettings options;

	public static void OnLoad()
	{
		options = new SCPSettings();
		options.AddToModSettings("定义安全屋强化辅助v1.9.4");
	}

	public static void OnInitialize()
	{
		hueSliderThumb = InterfaceManager.GetPanel<Panel_OptionsMenu>().transform.Find("Pages/ModSettings/GameObject/ScrollPanel/Offset/Mod settings grid (Safehouse Customization Plus)/Custom Setting (Hue)/Slider_FOV/Slider_Options/Thumb").GetComponent<UISprite>();
		hueSliderThumb.color = Utility.outlineColor.HueAdjust(options.outlineHue);
		ShowDistance(options.outlineVisibility == 1);
		ShowOutline(options.outlineVisibility != 3);
	}

	internal static void ShowDistance(bool visible)
	{
		options.SetFieldVisible("outlineDistance", visible);
	}

	internal static void ShowOutline(bool visible)
	{
		options.SetFieldVisible("outlineHue", visible);
		options.SetFieldVisible("outlineAlpha", visible);
		options.SetFieldVisible("outlineThickness", visible);
	}
}

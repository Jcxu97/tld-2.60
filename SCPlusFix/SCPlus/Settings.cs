using Il2Cpp;
using UnityEngine;

namespace SCPlusPP;

internal static class Settings
{
	public static UISprite hueSliderThumb;

	public static SCPSettings options;

	public static void OnLoad()
	{
		options = new SCPSettings();
		options.AddToModSettings(SettingsEn.ChineseTab);
	}

	public static void OnInitialize()
	{
		// ModSettings names UI nodes after the localized title and field name
		Transform thumb = InterfaceManager.GetPanel<Panel_OptionsMenu>().transform.Find($"Pages/ModSettings/GameObject/ScrollPanel/Offset/Mod settings grid ({SettingsEn.TabTitle})/Custom Setting ({SettingsEn.HueName})/Slider_FOV/Slider_Options/Thumb");
		if (thumb != null)
		{
			hueSliderThumb = thumb.GetComponent<UISprite>();
			hueSliderThumb.color = Utility.outlineColor.HueAdjust(options.outlineHue);
		}
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

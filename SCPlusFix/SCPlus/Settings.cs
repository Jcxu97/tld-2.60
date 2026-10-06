using Il2Cpp;
using UnityEngine;

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
		// ModSettings names UI nodes after the localized title and field name
		Transform thumb = InterfaceManager.GetPanel<Panel_OptionsMenu>().transform.Find("Pages/ModSettings/GameObject/ScrollPanel/Offset/Mod settings grid (定义安全屋强化辅助v1.9.4)/Custom Setting (色调)/Slider_FOV/Slider_Options/Thumb");
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

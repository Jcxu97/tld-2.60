using Il2Cpp;
using UnityEngine;
using static Il2Cpp.UILabel;
using static Il2Cpp.NGUIText;

namespace ItemRarities.Utilities;

internal static class UILabelExtensions
{
	internal static UILabel SetupGameObjectWithUILabel(string gameObjectName, Transform parent, bool worldPositionStays, bool inspectLabel = false, float posX = 0f, float posY = 0f, float posZ = 0f)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject(gameObjectName);
		UILabel val2 = val.AddComponent<UILabel>();
		val.transform.SetParent(parent, worldPositionStays);
		val.transform.localPosition = new Vector3(posX, posY, posZ);
		SetupUILabel(val2, string.Empty, (FontStyle)0, (Crispness)2, (Alignment)(inspectLabel ? 1 : 2), (Overflow)2, multiLine: true, inspectLabel ? 2 : 0, inspectLabel ? 14 : 18, Color.clear, capsLock: true);
		return val2;
	}

	private static void SetupUILabel(UILabel label, string text, FontStyle fontStyle, Crispness crispness, Alignment alignment, Overflow overflow, bool multiLine, int depth, int fontSize, Color color, bool capsLock)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		label.text = text;
		label.ambigiousFont = (Object)(object)GameManager.GetFontManager().GetUIFontForCharacterSet(FontManager.m_CurrentCharacterSet);
		label.bitmapFont = GameManager.GetFontManager().GetUIFontForCharacterSet(FontManager.m_CurrentCharacterSet);
		label.font = GameManager.GetFontManager().GetUIFontForCharacterSet(FontManager.m_CurrentCharacterSet);
		label.fontStyle = fontStyle;
		label.keepCrispWhenShrunk = crispness;
		label.alignment = alignment;
		label.overflowMethod = overflow;
		label.multiLine = multiLine;
		((UIWidget)label).depth = depth;
		label.fontSize = fontSize;
		((UIWidget)label).color = color;
		label.capsLock = capsLock;
	}
}

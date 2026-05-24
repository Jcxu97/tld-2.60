using System;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.IntBackedUnit;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000271")]
public class RadialMenuArm : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400164C")]
	[FieldOffset(Offset = "0x20")]
	private Panel_ActionsRadial m_ActionsRadial;

	[SerializeField]
	[Token(Token = "0x400164D")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_PickWater> m_PickWater;

	[Token(Token = "0x400164E")]
	[FieldOffset(Offset = "0x30")]
	public UISprite m_BG;

	[Token(Token = "0x400164F")]
	[FieldOffset(Offset = "0x38")]
	public UISprite m_Sprite;

	[Token(Token = "0x4001650")]
	[FieldOffset(Offset = "0x40")]
	public UISprite m_GlowSprite;

	[Token(Token = "0x4001651")]
	[FieldOffset(Offset = "0x48")]
	public UITexture m_Texture;

	[Token(Token = "0x4001652")]
	[FieldOffset(Offset = "0x50")]
	public Animator m_NewItemHighlightAnim;

	[Token(Token = "0x4001653")]
	[FieldOffset(Offset = "0x58")]
	public bool m_IsCenterButton;

	[Token(Token = "0x4001654")]
	[FieldOffset(Offset = "0x60")]
	public UILabel m_CenterLabel;

	[Token(Token = "0x4001655")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_StackLabel;

	[Token(Token = "0x4001656")]
	[FieldOffset(Offset = "0x70")]
	public Color m_CenterLabelColorNormal;

	[Token(Token = "0x4001657")]
	[FieldOffset(Offset = "0x80")]
	public Color m_CenterLabelColorHover;

	[Token(Token = "0x4001658")]
	[FieldOffset(Offset = "0x90")]
	public bool m_RadialArmEnabled;

	[Token(Token = "0x4001659")]
	[FieldOffset(Offset = "0x98")]
	public UISprite m_NotificationSprite;

	[Token(Token = "0x400165A")]
	[FieldOffset(Offset = "0xA0")]
	private Action m_Callback;

	[Token(Token = "0x400165B")]
	[FieldOffset(Offset = "0xA8")]
	private Panel_ActionsRadial.RadialGearDelegate m_GearCallback;

	[Token(Token = "0x400165C")]
	[FieldOffset(Offset = "0xB0")]
	private Panel_ActionsRadial.RadialInfo m_RadialInfo;

	[Token(Token = "0x400165D")]
	[FieldOffset(Offset = "0xB8")]
	private GearItem m_GearItem;

	[Token(Token = "0x400165E")]
	[FieldOffset(Offset = "0xC0")]
	private string m_NameWhenHoveredOver;

	[Token(Token = "0x400165F")]
	[FieldOffset(Offset = "0xC8")]
	private bool m_IsGreyedOut;

	[Token(Token = "0x4001660")]
	[FieldOffset(Offset = "0xD0")]
	private AK.Wwise.Event m_Audio;

	[Token(Token = "0x4001661")]
	[FieldOffset(Offset = "0xD8")]
	private bool m_IsHoveredOver;

	[Token(Token = "0x600155A")]
	[Address(RVA = "0x502310", Offset = "0x501110", Length = "0x8")]
	public Panel_ActionsRadial.RadialInfo GetRadialInfo()
	{
		return null;
	}

	[Token(Token = "0x600155B")]
	[Address(RVA = "0x69DE60", Offset = "0x69CC60", Length = "0x3DF")]
	public void SetEnabled(bool shouldEnable)
	{
	}

	[Token(Token = "0x600155C")]
	[Address(RVA = "0x69E240", Offset = "0x69D040", Length = "0x48B")]
	public void SetHoverColor(bool isHovering)
	{
	}

	[Token(Token = "0x600155D")]
	[Address(RVA = "0x69E6D0", Offset = "0x69D4D0", Length = "0x777")]
	public void SetRadialInfo(Panel_ActionsRadial.RadialInfo radialInfo, Action callback, bool greyOut = false, bool showHighlight = false)
	{
	}

	[Token(Token = "0x600155E")]
	[Address(RVA = "0x69EE50", Offset = "0x69DC50", Length = "0x48E")]
	public void SetRadialInfoGear(Panel_ActionsRadial.RadialGearDelegate callback, GearItem gi)
	{
	}

	[Token(Token = "0x600155F")]
	[Address(RVA = "0x69F2E0", Offset = "0x69E0E0", Length = "0x90")]
	public void OverrideSpriteWithGearIcon(string textureName, bool greyOut, string hoverNameID)
	{
	}

	[Token(Token = "0x6001560")]
	[Address(RVA = "0x69F370", Offset = "0x69E170", Length = "0x39F")]
	public void OverrideSpriteWithGearIcon(Texture2D texture, bool greyOut, string hoverNameID)
	{
	}

	[Token(Token = "0x6001561")]
	[Address(RVA = "0x69F710", Offset = "0x69E510", Length = "0x18E")]
	public void OverrideSpriteWithGearIcon(GearItem gi, Panel_ActionsRadial.RadialGearDelegate callback, bool greyOut, string hoverNameID)
	{
	}

	[Token(Token = "0x6001562")]
	[Address(RVA = "0x69F8A0", Offset = "0x69E6A0", Length = "0xAC")]
	public void OverrideHoverText(string overrideID)
	{
	}

	[Token(Token = "0x6001563")]
	[Address(RVA = "0x69F950", Offset = "0x69E750", Length = "0x8")]
	public bool IsHoveredOver()
	{
		return false;
	}

	[Token(Token = "0x6001564")]
	[Address(RVA = "0x502640", Offset = "0x501440", Length = "0x8")]
	public string GetHoverText()
	{
		return null;
	}

	[Token(Token = "0x6001565")]
	[Address(RVA = "0x502320", Offset = "0x501120", Length = "0x8")]
	public GearItem GetGearItem()
	{
		return null;
	}

	[Token(Token = "0x6001566")]
	[Address(RVA = "0x69F960", Offset = "0x69E760", Length = "0xAD")]
	public bool IsEmpty()
	{
		return false;
	}

	[Token(Token = "0x6001567")]
	[Address(RVA = "0x69FA10", Offset = "0x69E810", Length = "0xCE")]
	public bool IsBackButton()
	{
		return false;
	}

	[Token(Token = "0x6001568")]
	[Address(RVA = "0x69FAE0", Offset = "0x69E8E0", Length = "0x38F")]
	public void DoCallbackAction(bool ignoreConfirmPopup = false)
	{
	}

	[Token(Token = "0x6001569")]
	[Address(RVA = "0x69FE70", Offset = "0x69EC70", Length = "0x3BD")]
	public void DoAltClickAction()
	{
	}

	[Token(Token = "0x600156A")]
	[Address(RVA = "0x6A0230", Offset = "0x69F030", Length = "0x467")]
	private bool GetWaterPlacementValues(out GameObject prefab, out ItemLiquidVolume volume)
	{
		prefab = null;
		volume = default(ItemLiquidVolume);
		return false;
	}

	[Token(Token = "0x600156B")]
	[Address(RVA = "0x6A06A0", Offset = "0x69F4A0", Length = "0x200")]
	private GameObject CreateWaterPlacement()
	{
		return null;
	}

	[Token(Token = "0x600156C")]
	[Address(RVA = "0x6A08B0", Offset = "0x69F6B0", Length = "0x58")]
	private Color GetRadialIconColor(Panel_ActionsRadial.RadialInfo radialInfo)
	{
		return default(Color);
	}

	[Token(Token = "0x600156D")]
	[Address(RVA = "0x6A0910", Offset = "0x69F710", Length = "0x3A5")]
	private void UpdateStackLabel()
	{
	}

	[Token(Token = "0x600156E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public RadialMenuArm()
	{
	}
}

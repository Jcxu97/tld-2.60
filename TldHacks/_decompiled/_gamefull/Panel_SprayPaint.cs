using System;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20006D0")]
public class Panel_SprayPaint : Panel_AutoReferenced
{
	[Serializable]
	[Token(Token = "0x20006D1")]
	public struct ShapeInfo
	{
		[Token(Token = "0x40048B9")]
		[FieldOffset(Offset = "0x0")]
		public ProjectileType ProjectileType;

		[Token(Token = "0x40048BA")]
		[FieldOffset(Offset = "0x8")]
		public LocalizedString m_Label;

		[Token(Token = "0x40048BB")]
		[FieldOffset(Offset = "0x10")]
		public Texture m_ShapeIcon;

		[Token(Token = "0x40048BC")]
		[FieldOffset(Offset = "0x18")]
		public bool m_AddedToMap;

		[Token(Token = "0x40048BD")]
		[FieldOffset(Offset = "0x19")]
		public bool m_OnlyAllowedOneOfType;
	}

	[Token(Token = "0x20006D2")]
	public class SprayPaintPanelSaveData
	{
		[Token(Token = "0x40048BE")]
		[FieldOffset(Offset = "0x10")]
		public ProjectileType m_LastSelectedShape;

		[Token(Token = "0x40048BF")]
		[FieldOffset(Offset = "0x14")]
		public bool m_CanShowBanishmentGlyph;

		[Token(Token = "0x6003C0F")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SprayPaintPanelSaveData()
		{
		}
	}

	[Token(Token = "0x40048AD")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x40048AE")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_ShapeNotMappedMessage;

	[Token(Token = "0x40048AF")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_CannotPlaceMoreThanOneMessage;

	[SerializeField]
	[Token(Token = "0x40048B0")]
	[FieldOffset(Offset = "0x48")]
	private ShapeInfo[] m_Shapes;

	[SerializeField]
	[Token(Token = "0x40048B1")]
	[FieldOffset(Offset = "0x50")]
	private ShapeInfo[] m_NowhereToHideEventShapes;

	[SerializeField]
	[Token(Token = "0x40048B2")]
	[FieldOffset(Offset = "0x58")]
	private GridUI m_ShapeGridUI;

	[SerializeField]
	[Token(Token = "0x40048B3")]
	[FieldOffset(Offset = "0x60")]
	private ProjectileType m_LastSelectedShape;

	[Token(Token = "0x40048B4")]
	[FieldOffset(Offset = "0x68")]
	public GameObject[] m_MouseButtons;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40048B5")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x40048B6")]
	[FieldOffset(Offset = "0x78")]
	private GearItem m_SprayPaintCanToUse;

	[Token(Token = "0x40048B7")]
	private static SprayPaintPanelSaveData m_SprayPaintPanelSaveData;

	[Token(Token = "0x40048B8")]
	[FieldOffset(Offset = "0x80")]
	private bool m_CanShowBanishmentGlyph;

	[Token(Token = "0x6003BF1")]
	[Address(RVA = "0xB42190", Offset = "0xB40F90", Length = "0x89")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003BF2")]
	[Address(RVA = "0xB70570", Offset = "0xB6F370", Length = "0x103")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6003BF3")]
	[Address(RVA = "0xB70680", Offset = "0xB6F480", Length = "0x96")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6003BF4")]
	[Address(RVA = "0xB70720", Offset = "0xB6F520", Length = "0xA8")]
	public void OnButtonCancel()
	{
	}

	[Token(Token = "0x6003BF5")]
	[Address(RVA = "0xB707D0", Offset = "0xB6F5D0", Length = "0x81")]
	public bool CanPlaceDecalOnMap(ProjectileType projectile)
	{
		return false;
	}

	[Token(Token = "0x6003BF6")]
	[Address(RVA = "0xB70860", Offset = "0xB6F660", Length = "0x86")]
	public bool IsOnlyAllowedOneOfType(ProjectileType projectile)
	{
		return false;
	}

	[Token(Token = "0x6003BF7")]
	[Address(RVA = "0xB708F0", Offset = "0xB6F6F0", Length = "0x9F")]
	public bool IsAlreadyPlacedInWorld(ProjectileType projectile)
	{
		return false;
	}

	[Token(Token = "0x6003BF8")]
	[Address(RVA = "0xB70990", Offset = "0xB6F790", Length = "0xC7")]
	public bool DoesShapeLocIDExist(string locName)
	{
		return false;
	}

	[Token(Token = "0x6003BF9")]
	[Address(RVA = "0xB70A60", Offset = "0xB6F860", Length = "0x99")]
	public string GetShapeLocNameID(ProjectileType projectile)
	{
		return null;
	}

	[Token(Token = "0x6003BFA")]
	[Address(RVA = "0xB70B00", Offset = "0xB6F900", Length = "0x6F")]
	public ProjectileType GetSelectedDecalShape()
	{
		return default(ProjectileType);
	}

	[Token(Token = "0x6003BFB")]
	[Address(RVA = "0xB70B70", Offset = "0xB6F970", Length = "0x119")]
	public void OnButtonConfirm()
	{
	}

	[Token(Token = "0x6003BFC")]
	[Address(RVA = "0xB70C90", Offset = "0xB6FA90", Length = "0xEE")]
	private void ReturnToGame()
	{
	}

	[Token(Token = "0x6003BFD")]
	[Address(RVA = "0xB70D80", Offset = "0xB6FB80", Length = "0x22")]
	public void OnButtonScrollLeft()
	{
	}

	[Token(Token = "0x6003BFE")]
	[Address(RVA = "0xB70DB0", Offset = "0xB6FBB0", Length = "0x91")]
	public void OnButtonScrollRight()
	{
	}

	[Token(Token = "0x6003BFF")]
	[Address(RVA = "0xB70E50", Offset = "0xB6FC50", Length = "0x1D")]
	public void Reset()
	{
	}

	[Token(Token = "0x6003C00")]
	[Address(RVA = "0xB70E70", Offset = "0xB6FC70", Length = "0x1D")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003C01")]
	[Address(RVA = "0xB70E90", Offset = "0xB6FC90", Length = "0x80E")]
	public void Enable(bool enable, GearItem sprayPaintCan, bool bypassScreen)
	{
	}

	[Token(Token = "0x6003C02")]
	[Address(RVA = "0xB716A0", Offset = "0xB704A0", Length = "0x7B")]
	public void OnControllerScheme(bool isController)
	{
	}

	[Token(Token = "0x6003C03")]
	[Address(RVA = "0xB71720", Offset = "0xB70520", Length = "0x23")]
	public void SetShowBanishmentGlyph(bool show)
	{
	}

	[Token(Token = "0x6003C04")]
	[Address(RVA = "0x644520", Offset = "0x643320", Length = "0x8")]
	public bool CanShowBanishmentGlyph()
	{
		return false;
	}

	[Token(Token = "0x6003C05")]
	[Address(RVA = "0xB71750", Offset = "0xB70550", Length = "0x51")]
	private bool IsValidSelection()
	{
		return false;
	}

	[Token(Token = "0x6003C06")]
	[Address(RVA = "0xB0C3B0", Offset = "0xB0B1B0", Length = "0x7")]
	private bool IsUsingNowhereToHideShapes()
	{
		return false;
	}

	[Token(Token = "0x6003C07")]
	[Address(RVA = "0xB717B0", Offset = "0xB705B0", Length = "0x28")]
	private ShapeInfo[] GetShapes()
	{
		return null;
	}

	[Token(Token = "0x6003C08")]
	[Address(RVA = "0xB717E0", Offset = "0xB705E0", Length = "0x367")]
	private void Update()
	{
	}

	[Token(Token = "0x6003C09")]
	[Address(RVA = "0xB71B50", Offset = "0xB70950", Length = "0x1CA")]
	private void MaybeShowShapeWillNotShowOnMapWarning(int selectedIndex)
	{
	}

	[Token(Token = "0x6003C0A")]
	[Address(RVA = "0xB71D20", Offset = "0xB70B20", Length = "0x1CB")]
	private void MaybeShowCannotPlaceMoreThanOneWarning(int selectedIndex)
	{
	}

	[Token(Token = "0x6003C0B")]
	[Address(RVA = "0xB71EF0", Offset = "0xB70CF0", Length = "0x171")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6003C0C")]
	[Address(RVA = "0xB72070", Offset = "0xB70E70", Length = "0x6E")]
	private void UpdateControls()
	{
	}

	[Token(Token = "0x6003C0D")]
	[Address(RVA = "0xB720E0", Offset = "0xB70EE0", Length = "0xCA")]
	public Panel_SprayPaint()
	{
	}
}

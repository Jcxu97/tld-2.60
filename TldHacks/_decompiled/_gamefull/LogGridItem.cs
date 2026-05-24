using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000258")]
public class LogGridItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400152F")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Log> m_Log;

	[Token(Token = "0x4001530")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget m_WidgetParent;

	[Token(Token = "0x4001531")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_LabelCenter;

	[Token(Token = "0x4001532")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_LabelTopLeft;

	[Token(Token = "0x4001533")]
	[FieldOffset(Offset = "0x40")]
	public UITexture m_TextureCenter;

	[Token(Token = "0x4001534")]
	[FieldOffset(Offset = "0x48")]
	public UITexture m_PhotoTexture;

	[Token(Token = "0x4001535")]
	[FieldOffset(Offset = "0x50")]
	public UISprite m_SpriteTopLeft;

	[Token(Token = "0x4001536")]
	[FieldOffset(Offset = "0x58")]
	public TweenScale m_TweenScale;

	[Token(Token = "0x4001537")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_NotificationFlag;

	[Token(Token = "0x4001538")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsSelected;

	[Token(Token = "0x4001539")]
	[FieldOffset(Offset = "0x6C")]
	private int m_EntryNum;

	[Token(Token = "0x400153A")]
	[FieldOffset(Offset = "0x70")]
	private GearItem m_GearItem;

	[Token(Token = "0x60014B0")]
	[Address(RVA = "0x691790", Offset = "0x690590", Length = "0xA")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x60014B1")]
	[Address(RVA = "0x6917A0", Offset = "0x6905A0", Length = "0x84")]
	public void OnClick()
	{
	}

	[Token(Token = "0x60014B2")]
	[Address(RVA = "0x691830", Offset = "0x690630", Length = "0x132")]
	public void SetSelected()
	{
	}

	[Token(Token = "0x60014B3")]
	[Address(RVA = "0x691970", Offset = "0x690770", Length = "0xFB")]
	public void SetupAsDayEntry(int entryNum, bool hasNotes)
	{
	}

	[Token(Token = "0x60014B4")]
	[Address(RVA = "0x691A70", Offset = "0x690870", Length = "0x181")]
	public void SetupAsCollectionEntry(int entryNum, string textureName, int entryDisplayNum)
	{
	}

	[Token(Token = "0x60014B5")]
	[Address(RVA = "0x691C00", Offset = "0x690A00", Length = "0x180")]
	public void SetupAsCollectibleEntry(int entryNum, GearItem gearItem)
	{
	}

	[Token(Token = "0x60014B6")]
	[Address(RVA = "0x691D90", Offset = "0x690B90", Length = "0x1BB")]
	public void SetupAsPhoto(int entryNum, PhotoManager.PhotoInfo photoInfo, Texture photoBackground)
	{
	}

	[Token(Token = "0x60014B7")]
	[Address(RVA = "0x691F50", Offset = "0x690D50", Length = "0x2A")]
	public void HideAll()
	{
	}

	[Token(Token = "0x60014B8")]
	[Address(RVA = "0x4C3B90", Offset = "0x4C2990", Length = "0x5")]
	public bool IsSelected()
	{
		return false;
	}

	[Token(Token = "0x60014B9")]
	[Address(RVA = "0x502690", Offset = "0x501490", Length = "0x5")]
	public GearItem GetGearItem()
	{
		return null;
	}

	[Token(Token = "0x60014BA")]
	[Address(RVA = "0x691F80", Offset = "0x690D80", Length = "0x5")]
	public void DeselectItem()
	{
	}

	[Token(Token = "0x60014BB")]
	[Address(RVA = "0x691F90", Offset = "0x690D90", Length = "0x20E")]
	private void SetPhotoTextureEnabled(bool enabled)
	{
	}

	[Token(Token = "0x60014BC")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LogGridItem()
	{
	}
}

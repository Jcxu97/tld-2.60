using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200027D")]
public class StartFireSelectionRow : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40016B2")]
	[FieldOffset(Offset = "0x20")]
	private Panel_FireStart m_FireStart;

	[Token(Token = "0x40016B3")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_LabelName;

	[Token(Token = "0x40016B4")]
	[FieldOffset(Offset = "0x30")]
	public UITexture m_TextureGear;

	[Token(Token = "0x40016B5")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_LabelLiquid;

	[Token(Token = "0x40016B6")]
	[FieldOffset(Offset = "0x40")]
	public string m_NoToolSpriteName;

	[Token(Token = "0x40016B7")]
	[FieldOffset(Offset = "0x48")]
	public Color m_NoToolSpriteColor;

	[Token(Token = "0x40016B8")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 m_NoToolSpriteSizeModifier;

	[Token(Token = "0x40016B9")]
	[FieldOffset(Offset = "0x68")]
	public UISprite m_BackgroundOnSelected;

	[Token(Token = "0x40016BA")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_ButtonIncrease;

	[Token(Token = "0x40016BB")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_ButtonDecrease;

	[Token(Token = "0x40016BC")]
	[FieldOffset(Offset = "0x80")]
	public UILabel m_LabelItemCount;

	[Token(Token = "0x40016BD")]
	[FieldOffset(Offset = "0x88")]
	private GearItem m_GearItem;

	[Token(Token = "0x60015B5")]
	[Address(RVA = "0x6A6D10", Offset = "0x6A5B10", Length = "0x97")]
	private void Awake()
	{
	}

	[Token(Token = "0x60015B6")]
	[Address(RVA = "0x6A6DB0", Offset = "0x6A5BB0", Length = "0xA42")]
	private void Update()
	{
	}

	[Token(Token = "0x60015B7")]
	[Address(RVA = "0x6A7800", Offset = "0x6A6600", Length = "0x1C2")]
	public void SetGearItem(FireStarterItem fsi)
	{
	}

	[Token(Token = "0x60015B8")]
	[Address(RVA = "0x6A79D0", Offset = "0x6A67D0", Length = "0x1C2")]
	public void SetGearItem(FuelSourceItem fsi)
	{
	}

	[Token(Token = "0x60015B9")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public StartFireSelectionRow()
	{
	}
}

using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20001FD")]
public class AlmanacGridItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4001206")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Log> m_Log;

	[Token(Token = "0x4001207")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_BlizzardSprite;

	[Token(Token = "0x4001208")]
	[FieldOffset(Offset = "0x30")]
	public UISprite m_RedXSprite;

	[Token(Token = "0x4001209")]
	[FieldOffset(Offset = "0x38")]
	public UISprite m_BorderSprite;

	[Token(Token = "0x400120A")]
	[FieldOffset(Offset = "0x40")]
	public UISprite m_FillSprite;

	[Token(Token = "0x400120B")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_DayLabel;

	[Token(Token = "0x400120C")]
	[FieldOffset(Offset = "0x50")]
	public UILabel m_CatLabel;

	[Token(Token = "0x400120D")]
	[FieldOffset(Offset = "0x58")]
	public UILabel m_ChanceLabel;

	[Token(Token = "0x400120E")]
	[FieldOffset(Offset = "0x60")]
	public float m_ScaleCurrentDay;

	[Token(Token = "0x400120F")]
	[FieldOffset(Offset = "0x64")]
	public float m_ScaleOtherDays;

	[Token(Token = "0x4001210")]
	[FieldOffset(Offset = "0x68")]
	private Color m_BlizzardSpriteOrigColor;

	[Token(Token = "0x600120E")]
	[Address(RVA = "0x647B10", Offset = "0x646910", Length = "0x22")]
	private void Awake()
	{
	}

	[Token(Token = "0x600120F")]
	[Address(RVA = "0x647B40", Offset = "0x646940", Length = "0x65C")]
	public void SetUpGridItem(int dayNumber)
	{
	}

	[Token(Token = "0x6001210")]
	[Address(RVA = "0x6481A0", Offset = "0x646FA0", Length = "0x9E")]
	public bool IsNonBlizzardDay()
	{
		return false;
	}

	[Token(Token = "0x6001211")]
	[Address(RVA = "0x648240", Offset = "0x647040", Length = "0x34C")]
	public void ShowFalseBlizzard(int dayNumber)
	{
	}

	[Token(Token = "0x6001212")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AlmanacGridItem()
	{
	}
}

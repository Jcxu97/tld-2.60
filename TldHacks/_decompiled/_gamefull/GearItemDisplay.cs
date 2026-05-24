using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200023C")]
public class GearItemDisplay : MonoBehaviour
{
	[Token(Token = "0x200023D")]
	public delegate void OnClicked(int index);

	[Token(Token = "0x40013CF")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_Available;

	[Token(Token = "0x40013D0")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_Background;

	[Token(Token = "0x40013D1")]
	[FieldOffset(Offset = "0x30")]
	public UIButton m_Button;

	[Token(Token = "0x40013D2")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_DisplayName;

	[Token(Token = "0x40013D3")]
	[FieldOffset(Offset = "0x40")]
	public UITexture m_Icon;

	[Token(Token = "0x40013D4")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget m_Root;

	[Token(Token = "0x40013D5")]
	[FieldOffset(Offset = "0x50")]
	public UISprite m_Unavailable;

	[Token(Token = "0x40013D6")]
	[FieldOffset(Offset = "0x58")]
	public Color m_Disabled;

	[Token(Token = "0x40013D7")]
	[FieldOffset(Offset = "0x68")]
	public Color m_Normal;

	[Token(Token = "0x40013D8")]
	[FieldOffset(Offset = "0x78")]
	public Color m_Selected;

	[NonSerialized]
	[Token(Token = "0x40013D9")]
	[FieldOffset(Offset = "0x88")]
	public int m_Index;

	[NonSerialized]
	[Token(Token = "0x40013DA")]
	[FieldOffset(Offset = "0x90")]
	public OnClicked m_ClickedDelegate;

	[Token(Token = "0x60013BE")]
	[Address(RVA = "0x676170", Offset = "0x674F70", Length = "0x188")]
	public void Clear()
	{
	}

	[Token(Token = "0x60013BF")]
	[Address(RVA = "0x676300", Offset = "0x675100", Length = "0x1F")]
	public void OnButtonClicked()
	{
	}

	[Token(Token = "0x60013C0")]
	[Address(RVA = "0x676320", Offset = "0x675120", Length = "0x25F")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x60013C1")]
	[Address(RVA = "0x676580", Offset = "0x675380", Length = "0x2D1")]
	public void Setup(GearItem gi)
	{
	}

	[Token(Token = "0x60013C2")]
	[Address(RVA = "0x676860", Offset = "0x675660", Length = "0x4D")]
	public GearItemDisplay()
	{
	}
}

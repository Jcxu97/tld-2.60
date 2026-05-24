using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200020E")]
public class ButtonLegendItem : MonoBehaviour
{
	[Token(Token = "0x400128C")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_Sprite;

	[Token(Token = "0x400128D")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_Label;

	[Token(Token = "0x400128E")]
	[FieldOffset(Offset = "0x30")]
	private string m_LocalizationKey;

	[Token(Token = "0x400128F")]
	[FieldOffset(Offset = "0x38")]
	private int m_Priority;

	[Token(Token = "0x4001290")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_Localize;

	[Token(Token = "0x4001291")]
	[FieldOffset(Offset = "0x40")]
	private string m_Language;

	[Token(Token = "0x600128B")]
	[Address(RVA = "0x6541A0", Offset = "0x652FA0", Length = "0x3B1")]
	public bool Setup(string localizationKey, string iconName, UIAtlas atlas, int priority, bool localize)
	{
		return false;
	}

	[Token(Token = "0x600128C")]
	[Address(RVA = "0x654560", Offset = "0x653360", Length = "0x2E")]
	public int CompareTo(ButtonLegendItem b)
	{
		return 0;
	}

	[Token(Token = "0x600128D")]
	[Address(RVA = "0x654590", Offset = "0x653390", Length = "0x42")]
	public void SetDepth(int depth)
	{
	}

	[Token(Token = "0x600128E")]
	[Address(RVA = "0x6545E0", Offset = "0x6533E0", Length = "0x1D")]
	public int GetDepth()
	{
		return 0;
	}

	[Token(Token = "0x600128F")]
	[Address(RVA = "0x654600", Offset = "0x653400", Length = "0x9B")]
	private void OnLocalize()
	{
	}

	[Token(Token = "0x6001290")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ButtonLegendItem()
	{
	}
}

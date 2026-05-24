using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200022D")]
public class MultiLabelCreditElement : CreditElement
{
	[SerializeField]
	[Token(Token = "0x400135E")]
	[FieldOffset(Offset = "0x28")]
	private UILabel[] m_Labels;

	[Token(Token = "0x6001365")]
	[Address(RVA = "0x669930", Offset = "0x668730", Length = "0x1B")]
	public override bool IsContentValid(string[] content, Panel_Credits panel)
	{
		return false;
	}

	[Token(Token = "0x6001366")]
	[Address(RVA = "0x669950", Offset = "0x668750", Length = "0x235")]
	public override void Populate(string[] content, Panel_Credits panel)
	{
	}

	[Token(Token = "0x6001367")]
	[Address(RVA = "0x669B90", Offset = "0x668990", Length = "0x19A")]
	public override Vector2 GetSize()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001368")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MultiLabelCreditElement()
	{
	}
}

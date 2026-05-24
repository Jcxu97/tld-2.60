using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200022E")]
public class SimpleCreditElement : CreditElement
{
	[SerializeField]
	[Token(Token = "0x400135F")]
	[FieldOffset(Offset = "0x28")]
	private UILabel m_Label;

	[Token(Token = "0x6001369")]
	[Address(RVA = "0x669D30", Offset = "0x668B30", Length = "0x133")]
	public override Vector2 GetSize()
	{
		return default(Vector2);
	}

	[Token(Token = "0x600136A")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public override bool IsContentValid(string[] content, Panel_Credits panel)
	{
		return false;
	}

	[Token(Token = "0x600136B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public override void Populate(string[] content, Panel_Credits panel)
	{
	}

	[Token(Token = "0x600136C")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SimpleCreditElement()
	{
	}
}

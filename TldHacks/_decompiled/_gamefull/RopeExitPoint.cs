using Cpp2ILInjected;
using TLD.Interactions;
using UnityEngine;

[Token(Token = "0x20005AF")]
public class RopeExitPoint : BaseInteraction
{
	[Token(Token = "0x400348C")]
	[FieldOffset(Offset = "0x40")]
	public Rope m_Rope;

	[Token(Token = "0x400348D")]
	[FieldOffset(Offset = "0x48")]
	public Transform m_ExitPoint;

	[Token(Token = "0x6002C09")]
	[Address(RVA = "0x92BA00", Offset = "0x92A800", Length = "0x68")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x6002C0A")]
	[Address(RVA = "0x8EC770", Offset = "0x8EB570", Length = "0x7")]
	public RopeExitPoint()
	{
	}
}

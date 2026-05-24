using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200080C")]
public class VariantIndex : StateMachineBehaviour
{
	[Token(Token = "0x200080D")]
	public enum Type
	{
		[Token(Token = "0x400553F")]
		Random,
		[Token(Token = "0x4005540")]
		ConsecuativeNegative,
		[Token(Token = "0x4005541")]
		ConsecuativePositive
	}

	[Token(Token = "0x400553A")]
	[FieldOffset(Offset = "0x18")]
	public int m_MaxIndex;

	[Token(Token = "0x400553B")]
	[FieldOffset(Offset = "0x20")]
	public string m_IntParam;

	[Token(Token = "0x400553C")]
	public static int m_LastIndex;

	[Token(Token = "0x400553D")]
	[FieldOffset(Offset = "0x28")]
	public Type m_Type;

	[Token(Token = "0x6004B3D")]
	[Address(RVA = "0xD50360", Offset = "0xD4F160", Length = "0xCC")]
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
	{
	}

	[Token(Token = "0x6004B3E")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public VariantIndex()
	{
	}
}

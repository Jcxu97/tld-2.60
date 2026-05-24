using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007FA")]
public class AnimationEventStack
{
	[Token(Token = "0x40054E5")]
	[FieldOffset(Offset = "0x10")]
	public string m_Name;

	[Token(Token = "0x40054E6")]
	[FieldOffset(Offset = "0x18")]
	public int m_NameHash;

	[Token(Token = "0x40054E7")]
	[FieldOffset(Offset = "0x1C")]
	public AnimatorControllerParameterType m_Type;

	[Token(Token = "0x40054E8")]
	[FieldOffset(Offset = "0x20")]
	public RuntimeAnimatorController m_Target;

	[Token(Token = "0x40054E9")]
	[FieldOffset(Offset = "0x28")]
	public int m_Top;

	[Token(Token = "0x40054EA")]
	[FieldOffset(Offset = "0x30")]
	public AnimationEventValue[] m_Stack;

	[Token(Token = "0x6004AEE")]
	[Address(RVA = "0xD48810", Offset = "0xD47610", Length = "0x182")]
	public AnimationEventStack(string name, AnimatorControllerParameterType type, RuntimeAnimatorController target)
	{
	}

	[Token(Token = "0x6004AEF")]
	[Address(RVA = "0xD489A0", Offset = "0xD477A0", Length = "0x41")]
	public void Push(AnimationEventValue value)
	{
	}

	[Token(Token = "0x6004AF0")]
	[Address(RVA = "0xD489F0", Offset = "0xD477F0", Length = "0x44")]
	public AnimationEventValue Pop()
	{
		return default(AnimationEventValue);
	}

	[Token(Token = "0x6004AF1")]
	[Address(RVA = "0xD48A40", Offset = "0xD47840", Length = "0x8")]
	public void Reset()
	{
	}
}

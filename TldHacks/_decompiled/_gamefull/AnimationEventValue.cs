using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20007F9")]
public struct AnimationEventValue
{
	[Token(Token = "0x40054E1")]
	[FieldOffset(Offset = "0x0")]
	public AnimatorControllerParameterType m_Type;

	[Token(Token = "0x40054E2")]
	[FieldOffset(Offset = "0x4")]
	public bool m_Bool;

	[Token(Token = "0x40054E3")]
	[FieldOffset(Offset = "0x8")]
	public int m_Int;

	[Token(Token = "0x40054E4")]
	[FieldOffset(Offset = "0xC")]
	public float m_Float;
}

using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000196")]
public class AnimationStateRef
{
	[Token(Token = "0x4000E9E")]
	[FieldOffset(Offset = "0x10")]
	public RuntimeAnimatorController m_Target;

	[Token(Token = "0x4000E9F")]
	[FieldOffset(Offset = "0x18")]
	public string m_StateName;

	[Token(Token = "0x6000F3D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public AnimationStateRef()
	{
	}
}

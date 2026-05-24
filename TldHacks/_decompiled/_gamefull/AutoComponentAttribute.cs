using System;
using Cpp2ILInjected;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field)]
[Token(Token = "0x20009AC")]
public class AutoComponentAttribute : Attribute
{
	[Token(Token = "0x4006305")]
	[FieldOffset(Offset = "0x10")]
	private ComponentRequirement m_Requirement;

	[Token(Token = "0x600561D")]
	[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
	public AutoComponentAttribute(ComponentRequirement requirement)
	{
	}

	[Token(Token = "0x600561E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void ApplyBinding(Component target, bool useHierarchy = false)
	{
	}
}

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000027")]
public class Vector3OrTransformArray
{
	[Token(Token = "0x4000228")]
	public static readonly string[] choices;

	[Token(Token = "0x4000229")]
	public static readonly int vector3Selected;

	[Token(Token = "0x400022A")]
	public static readonly int transformSelected;

	[Token(Token = "0x400022B")]
	public static readonly int iTweenPathSelected;

	[Token(Token = "0x400022C")]
	[FieldOffset(Offset = "0x10")]
	public int selected;

	[Token(Token = "0x400022D")]
	[FieldOffset(Offset = "0x18")]
	public Vector3[] vectorArray;

	[Token(Token = "0x400022E")]
	[FieldOffset(Offset = "0x20")]
	public Transform[] transformArray;

	[Token(Token = "0x400022F")]
	[FieldOffset(Offset = "0x28")]
	public string pathName;

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Vector3OrTransformArray()
	{
	}
}

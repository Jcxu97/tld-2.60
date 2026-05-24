using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000026")]
public class Vector3OrTransform
{
	[Token(Token = "0x4000222")]
	public static readonly string[] choices;

	[Token(Token = "0x4000223")]
	public static readonly int vector3Selected;

	[Token(Token = "0x4000224")]
	public static readonly int transformSelected;

	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x10")]
	public int selected;

	[Token(Token = "0x4000226")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 vector;

	[Token(Token = "0x4000227")]
	[FieldOffset(Offset = "0x20")]
	public Transform transform;

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Vector3OrTransform()
	{
	}
}

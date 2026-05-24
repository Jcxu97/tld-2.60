using System;
using Cpp2ILInjected;
using UnityEngine;

namespace ProCore.Decals;

[Serializable]
[Token(Token = "0x200150A")]
public class Decal
{
	[Token(Token = "0x400983E")]
	private static Vector3 DefaultRotation;

	[Token(Token = "0x400983F")]
	private static Vector3 DefaultScale;

	[Token(Token = "0x4009840")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4009841")]
	[FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x4009842")]
	[FieldOffset(Offset = "0x20")]
	public bool isPacked;

	[Token(Token = "0x4009843")]
	[FieldOffset(Offset = "0x28")]
	public string materialId;

	[Token(Token = "0x4009844")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 rotation;

	[Token(Token = "0x4009845")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 scale;

	[Token(Token = "0x4009846")]
	[FieldOffset(Offset = "0x48")]
	public Rect atlasRect;

	[Token(Token = "0x4009847")]
	[FieldOffset(Offset = "0x58")]
	public int orgGroup;

	[Token(Token = "0x4009848")]
	[FieldOffset(Offset = "0x5C")]
	public int orgIndex;

	[Token(Token = "0x4009849")]
	[FieldOffset(Offset = "0x60")]
	public int atlasGroup;

	[Token(Token = "0x400984A")]
	[FieldOffset(Offset = "0x64")]
	public int atlasIndex;

	[Token(Token = "0x400984B")]
	[FieldOffset(Offset = "0x68")]
	public Placement rotationPlacement;

	[Token(Token = "0x400984C")]
	[FieldOffset(Offset = "0x6C")]
	public Placement scalePlacement;

	[Token(Token = "0x400984D")]
	[FieldOffset(Offset = "0x70")]
	public Texture2D texture;

	[Token(Token = "0x6008506")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Decal()
	{
	}

	[Token(Token = "0x6008507")]
	[Address(RVA = "0x126F3A0", Offset = "0x126E1A0", Length = "0x1BB")]
	public Decal(Texture2D img)
	{
	}

	[Token(Token = "0x6008508")]
	[Address(RVA = "0x126F560", Offset = "0x126E360", Length = "0x1A3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008509")]
	[Address(RVA = "0x126F710", Offset = "0x126E510", Length = "0x96A")]
	public static bool Deserialize(string txt, out Decal decal)
	{
		decal = null;
		return false;
	}

	[Token(Token = "0x600850A")]
	[Address(RVA = "0x1270080", Offset = "0x126EE80", Length = "0x657")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600850B")]
	[Address(RVA = "0x12706E0", Offset = "0x126F4E0", Length = "0x2F7")]
	private static bool Vec3WithString(string str, ref Vector3 vec3)
	{
		return false;
	}

	[Token(Token = "0x600850C")]
	[Address(RVA = "0x12709E0", Offset = "0x126F7E0", Length = "0x38C")]
	private static bool Vec4WithString(string str, ref Vector4 vec4)
	{
		return false;
	}

	[Token(Token = "0x600850D")]
	[Address(RVA = "0x1270D70", Offset = "0x126FB70", Length = "0x1A")]
	private static Rect Vec4ToRect(Vector4 v)
	{
		return default(Rect);
	}
}

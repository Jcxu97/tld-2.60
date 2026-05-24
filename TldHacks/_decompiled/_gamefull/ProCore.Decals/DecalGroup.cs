using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace ProCore.Decals;

[Serializable]
[Token(Token = "0x200150B")]
public class DecalGroup
{
	[Token(Token = "0x400984E")]
	public const int MAX_ATLAS_SIZE_DEFAULT = 4096;

	[Token(Token = "0x400984F")]
	public const int ATLAS_PADDING_DEFAULT = 4;

	[Token(Token = "0x4009850")]
	[FieldOffset(Offset = "0x10")]
	public List<Decal> decals;

	[Token(Token = "0x4009851")]
	[FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x4009852")]
	[FieldOffset(Offset = "0x20")]
	public Shader shader;

	[Token(Token = "0x4009853")]
	[FieldOffset(Offset = "0x28")]
	public bool isPacked;

	[Token(Token = "0x4009854")]
	[FieldOffset(Offset = "0x30")]
	public Material material;

	[Token(Token = "0x4009855")]
	[FieldOffset(Offset = "0x38")]
	public Material fullscreenDecalMaterial;

	[Token(Token = "0x4009856")]
	[FieldOffset(Offset = "0x40")]
	public int maxAtlasSize;

	[Token(Token = "0x4009857")]
	[FieldOffset(Offset = "0x44")]
	public int padding;

	[Token(Token = "0x600850F")]
	[Address(RVA = "0x1270E30", Offset = "0x126FC30", Length = "0x1D4")]
	public DecalGroup(string name, List<Decal> decals, bool isPacked, Shader shader, Material material, int maxAtlasSize, int padding, Material fullscreenDecalMaterial)
	{
	}

	[Token(Token = "0x6008510")]
	[Address(RVA = "0x1271010", Offset = "0x126FE10", Length = "0x25F")]
	public bool ContainsTexture(Texture2D tex)
	{
		return false;
	}
}

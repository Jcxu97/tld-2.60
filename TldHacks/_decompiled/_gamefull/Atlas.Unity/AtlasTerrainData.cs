using Cpp2ILInjected;
using UnityEngine;

namespace Atlas.Unity;

[Token(Token = "0x2000D0B")]
public class AtlasTerrainData
{
	[Token(Token = "0x1700070F")]
	[field: Token(Token = "0x4008138")]
	[field: FieldOffset(Offset = "0x10")]
	public Transform parent
	{
		[Token(Token = "0x60066FE")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get;
		[Token(Token = "0x60066FF")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000710")]
	[field: Token(Token = "0x4008139")]
	[field: FieldOffset(Offset = "0x18")]
	public Vector3 size
	{
		[Token(Token = "0x6006700")]
		[Address(RVA = "0x1037C60", Offset = "0x1036A60", Length = "0x13")]
		get;
		[Token(Token = "0x6006701")]
		[Address(RVA = "0x1037C80", Offset = "0x1036A80", Length = "0x10")]
		private set;
	}

	[Token(Token = "0x17000711")]
	[field: Token(Token = "0x400813A")]
	[field: FieldOffset(Offset = "0x24")]
	public int tilesX
	{
		[Token(Token = "0x6006702")]
		[Address(RVA = "0x4AA8A0", Offset = "0x4A96A0", Length = "0x4")]
		get;
		[Token(Token = "0x6006703")]
		[Address(RVA = "0x4AA8B0", Offset = "0x4A96B0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x17000712")]
	[field: Token(Token = "0x400813B")]
	[field: FieldOffset(Offset = "0x28")]
	public int tilesZ
	{
		[Token(Token = "0x6006704")]
		[Address(RVA = "0x4588A0", Offset = "0x4576A0", Length = "0x4")]
		get;
		[Token(Token = "0x6006705")]
		[Address(RVA = "0x92FF10", Offset = "0x92ED10", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x17000713")]
	[field: Token(Token = "0x400813C")]
	[field: FieldOffset(Offset = "0x2C")]
	public Vector3 tileSize
	{
		[Token(Token = "0x6006706")]
		[Address(RVA = "0xE3B900", Offset = "0xE3A700", Length = "0x13")]
		get;
		[Token(Token = "0x6006707")]
		[Address(RVA = "0x1037C90", Offset = "0x1036A90", Length = "0x10")]
		private set;
	}

	[Token(Token = "0x6006708")]
	[Address(RVA = "0x1037CA0", Offset = "0x1036AA0", Length = "0x1E3")]
	public AtlasTerrainData(Transform parent, Vector3 size, Vector2Int tiles)
	{
	}
}

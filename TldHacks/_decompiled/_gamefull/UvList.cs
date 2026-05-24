using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A5C")]
public class UvList : ScriptableObject
{
	[Token(Token = "0x4006756")]
	[FieldOffset(Offset = "0x18")]
	public Rect[] m_Uvs;

	[Token(Token = "0x4006757")]
	[FieldOffset(Offset = "0x20")]
	public string[] m_TexNames;

	[Token(Token = "0x4006758")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, Vector4> m_Dict;

	[Token(Token = "0x6005AB2")]
	[Address(RVA = "0xF1C3F0", Offset = "0xF1B1F0", Length = "0x245")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6005AB3")]
	[Address(RVA = "0xF1C640", Offset = "0xF1B440", Length = "0xA9")]
	public Vector4 GetUvs(string texName)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6005AB4")]
	[Address(RVA = "0xF1C6F0", Offset = "0xF1B4F0", Length = "0x78")]
	public bool HasUvs(string texName)
	{
		return false;
	}

	[Token(Token = "0x6005AB5")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public UvList()
	{
	}
}

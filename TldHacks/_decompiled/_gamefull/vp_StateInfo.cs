using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x200001F")]
public class vp_StateInfo
{
	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x10")]
	public string TypeName;

	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x18")]
	public string Name;

	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x20")]
	public TextAsset TextAsset;

	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0x28")]
	public vp_ComponentPreset Preset;

	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0x30")]
	public bool Enabled;

	[Token(Token = "0x4000216")]
	[FieldOffset(Offset = "0x31")]
	public bool Allowed;

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x57A890", Offset = "0x579690", Length = "0x10F")]
	public vp_StateInfo(string typeName, string name = "New State", string path = null, TextAsset asset = null)
	{
	}
}

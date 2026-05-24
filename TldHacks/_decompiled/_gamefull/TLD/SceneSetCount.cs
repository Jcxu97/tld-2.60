using System;
using Cpp2ILInjected;
using TLD.Scenes;

namespace TLD;

[Serializable]
[Token(Token = "0x200133D")]
public class SceneSetCount
{
	[Token(Token = "0x4008DEF")]
	[FieldOffset(Offset = "0x10")]
	public SceneSet m_SceneSet;

	[Token(Token = "0x4008DF0")]
	[FieldOffset(Offset = "0x18")]
	public int m_TopLevelIcons;

	[Token(Token = "0x4008DF1")]
	[FieldOffset(Offset = "0x1C")]
	public int m_LocationTriggers;

	[Token(Token = "0x6007B55")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SceneSetCount()
	{
	}
}

using System;
using Cpp2ILInjected;

namespace TLD.Placement;

[Serializable]
[Token(Token = "0x2001378")]
public class PlaceableInfoSaveData
{
	[Token(Token = "0x4008F31")]
	[FieldOffset(Offset = "0x10")]
	public SerializationFlags m_Flags;

	[Token(Token = "0x4008F32")]
	[FieldOffset(Offset = "0x18")]
	public string m_Guid;

	[Token(Token = "0x4008F33")]
	[FieldOffset(Offset = "0x20")]
	public PlaceableSaveData m_Serialized;

	[Token(Token = "0x4008F34")]
	[FieldOffset(Offset = "0x28")]
	public PlacementState m_State;

	[Token(Token = "0x6007C5B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlaceableInfoSaveData()
	{
	}
}

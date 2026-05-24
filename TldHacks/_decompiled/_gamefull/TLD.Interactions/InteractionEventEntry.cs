using System;
using Cpp2ILInjected;

namespace TLD.Interactions;

[Serializable]
[Token(Token = "0x20013A4")]
public class InteractionEventEntry
{
	[Token(Token = "0x4008FF8")]
	[FieldOffset(Offset = "0x10")]
	public InteractionEventType m_EventType;

	[Token(Token = "0x4008FF9")]
	[FieldOffset(Offset = "0x18")]
	public InteractionEvent m_Event;

	[Token(Token = "0x6007D68")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public InteractionEventEntry()
	{
	}
}

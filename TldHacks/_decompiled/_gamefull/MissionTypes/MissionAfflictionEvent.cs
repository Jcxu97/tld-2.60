using Cpp2ILInjected;

namespace MissionTypes;

[Token(Token = "0x2000D4A")]
public class MissionAfflictionEvent
{
	[Token(Token = "0x400834C")]
	[FieldOffset(Offset = "0x10")]
	public MissionObjectIdentifier m_MissionObjectIdentifier;

	[Token(Token = "0x400834D")]
	[FieldOffset(Offset = "0x18")]
	public AfflictionType m_AfflictionType;

	[Token(Token = "0x400834E")]
	[FieldOffset(Offset = "0x1C")]
	public AfflictionEventType m_EventType;

	[Token(Token = "0x400834F")]
	public const string AFFLICTION_EVENT_NAME = "AfflictionEvent";

	[Token(Token = "0x600680E")]
	[Address(RVA = "0x105EDC0", Offset = "0x105DBC0", Length = "0x63")]
	public MissionAfflictionEvent(MissionObjectIdentifier moi, AfflictionType afflictionType, AfflictionEventType eventType)
	{
	}
}

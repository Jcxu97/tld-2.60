using Cpp2ILInjected;

[Token(Token = "0x2000836")]
public class ObjectInTriggerInfo
{
	[Token(Token = "0x4005627")]
	[FieldOffset(Offset = "0x10")]
	public bool m_IsPlayer;

	[Token(Token = "0x4005628")]
	[FieldOffset(Offset = "0x18")]
	public MissionObjectIdentifier m_MissionObjectIdentifier;

	[Token(Token = "0x4005629")]
	[FieldOffset(Offset = "0x20")]
	public MissionTrigger m_TriggerComponent;

	[Token(Token = "0x6004C64")]
	[Address(RVA = "0xD6F2E0", Offset = "0xD6E0E0", Length = "0x13E")]
	public ObjectInTriggerInfo(MissionObjectIdentifier moi, MissionTrigger trigger)
	{
	}
}

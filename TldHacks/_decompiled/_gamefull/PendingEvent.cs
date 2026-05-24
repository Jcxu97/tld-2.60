using Cpp2ILInjected;
using ParadoxNotion;

[Token(Token = "0x200082C")]
public class PendingEvent
{
	[Token(Token = "0x40055C5")]
	[FieldOffset(Offset = "0x10")]
	public EventData m_Event;

	[Token(Token = "0x40055C6")]
	[FieldOffset(Offset = "0x18")]
	public string m_MissionId;

	[Token(Token = "0x6004BD2")]
	[Address(RVA = "0x409520", Offset = "0x408320", Length = "0xAA")]
	public PendingEvent(EventData ev, string missionId)
	{
	}
}

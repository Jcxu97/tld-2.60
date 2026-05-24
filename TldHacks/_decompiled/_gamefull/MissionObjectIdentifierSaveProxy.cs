using Cpp2ILInjected;

[Token(Token = "0x2000825")]
public class MissionObjectIdentifierSaveProxy
{
	[Token(Token = "0x40055A1")]
	[FieldOffset(Offset = "0x10")]
	public string m_Id;

	[Token(Token = "0x40055A2")]
	[FieldOffset(Offset = "0x18")]
	public MissionObjectClass m_ObjectClass;

	[Token(Token = "0x40055A3")]
	[FieldOffset(Offset = "0x20")]
	public string m_ActivityTags;

	[Token(Token = "0x40055A4")]
	[FieldOffset(Offset = "0x28")]
	public bool m_DestroyAfterMission;

	[Token(Token = "0x6004BA5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public MissionObjectIdentifierSaveProxy()
	{
	}
}

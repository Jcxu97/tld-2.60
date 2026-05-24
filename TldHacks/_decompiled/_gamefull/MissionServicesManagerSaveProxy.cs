using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x200082E")]
public class MissionServicesManagerSaveProxy
{
	[Token(Token = "0x40055CC")]
	[FieldOffset(Offset = "0x10")]
	public string m_SerializedGlobalBlackboard;

	[Token(Token = "0x40055CD")]
	[FieldOffset(Offset = "0x18")]
	public readonly List<string> m_SerializedMissions;

	[Token(Token = "0x40055CE")]
	[FieldOffset(Offset = "0x20")]
	public readonly List<string> m_SerializedConcurrentGraphs;

	[Token(Token = "0x40055CF")]
	[FieldOffset(Offset = "0x28")]
	public readonly List<string> m_SerializedTimers;

	[Token(Token = "0x40055D0")]
	[FieldOffset(Offset = "0x30")]
	public string m_VisibleMissionTimer;

	[Token(Token = "0x40055D1")]
	[FieldOffset(Offset = "0x38")]
	public readonly List<string> m_MissionObjectFilterTags;

	[Token(Token = "0x40055D2")]
	[FieldOffset(Offset = "0x40")]
	public readonly List<string> m_CustomManagedObjects;

	[Token(Token = "0x40055D3")]
	[FieldOffset(Offset = "0x48")]
	public readonly List<CustomManagedObjectState> m_CustomManagedObjectStates;

	[Token(Token = "0x6004BD4")]
	[Address(RVA = "0xD5BF10", Offset = "0xD5AD10", Length = "0x319")]
	public MissionServicesManagerSaveProxy()
	{
	}
}

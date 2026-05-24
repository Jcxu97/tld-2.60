using Cpp2ILInjected;

[Token(Token = "0x2000878")]
public class NeedTrackerSaveData
{
	[Token(Token = "0x40057AA")]
	[FieldOffset(Offset = "0x10")]
	public NeedPrefabSaveData[] m_NeedPrefabsActive;

	[Token(Token = "0x40057AB")]
	[FieldOffset(Offset = "0x18")]
	public string m_NPCTrustID;

	[Token(Token = "0x40057AC")]
	[FieldOffset(Offset = "0x20")]
	public bool m_HasBeenInteractedWith;

	[Token(Token = "0x40057AD")]
	[FieldOffset(Offset = "0x21")]
	public bool m_NoTrustDecayUntilPlayerInteraction;

	[Token(Token = "0x6004D97")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public NeedTrackerSaveData()
	{
	}
}

using Cpp2ILInjected;

[Token(Token = "0x200087D")]
public class UnlockableTrackerSaveData
{
	[Token(Token = "0x40057C1")]
	[FieldOffset(Offset = "0x10")]
	public UnlockablePrefabSaveData[] m_UnlockablePrefabsActive;

	[Token(Token = "0x40057C2")]
	[FieldOffset(Offset = "0x18")]
	public string m_NPCTrustID;

	[Token(Token = "0x6004DB4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public UnlockableTrackerSaveData()
	{
	}
}

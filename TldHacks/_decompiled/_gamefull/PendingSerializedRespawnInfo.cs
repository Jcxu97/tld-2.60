using Cpp2ILInjected;

[Token(Token = "0x2000183")]
public class PendingSerializedRespawnInfo
{
	[Token(Token = "0x4000DF9")]
	[FieldOffset(Offset = "0x10")]
	public SpawnDataProxy m_SaveData;

	[Token(Token = "0x4000DFA")]
	[FieldOffset(Offset = "0x18")]
	public int m_TrySpawnCount;

	[Token(Token = "0x6000EC8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PendingSerializedRespawnInfo()
	{
	}
}

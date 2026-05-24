using Cpp2ILInjected;

[Token(Token = "0x2000955")]
internal class SnowfallRecord
{
	[Token(Token = "0x4006096")]
	private static SnowfallRecordSaveDataProxy m_SnowfallRecordSaveDataProxy;

	[Token(Token = "0x4006097")]
	[FieldOffset(Offset = "0x10")]
	public float m_CurrentSnowDepth;

	[Token(Token = "0x4006098")]
	[FieldOffset(Offset = "0x14")]
	public float m_OutOfSceneRateScalar;

	[Token(Token = "0x600546D")]
	[Address(RVA = "0xE7F730", Offset = "0xE7E530", Length = "0xD")]
	public SnowfallRecord(string sceneName, float outOfSceneRateScalar)
	{
	}

	[Token(Token = "0x600546E")]
	[Address(RVA = "0xE7F740", Offset = "0xE7E540", Length = "0xDF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600546F")]
	[Address(RVA = "0xE7F820", Offset = "0xE7E620", Length = "0x8C")]
	public void Deserialize(string text)
	{
	}
}

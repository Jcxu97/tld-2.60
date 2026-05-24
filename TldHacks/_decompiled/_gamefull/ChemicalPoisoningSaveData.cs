using Cpp2ILInjected;

[Token(Token = "0x200050B")]
public struct ChemicalPoisoningSaveData
{
	[Token(Token = "0x4002E3F")]
	[FieldOffset(Offset = "0x0")]
	public float[] m_Afflictions;

	[Token(Token = "0x4002E40")]
	[FieldOffset(Offset = "0x8")]
	public float m_Toxicity;
}

using Cpp2ILInjected;

[Token(Token = "0x2000783")]
public struct MapDetailStateData
{
	[Token(Token = "0x4005088")]
	[FieldOffset(Offset = "0x0")]
	public bool m_IsUnlocked;

	[Token(Token = "0x4005089")]
	[FieldOffset(Offset = "0x1")]
	public bool m_IsDiscovered;

	[Token(Token = "0x400508A")]
	[FieldOffset(Offset = "0x2")]
	public bool m_IsSurveyed;

	[Token(Token = "0x6004677")]
	[Address(RVA = "0xCA7060", Offset = "0xCA5E60", Length = "0xB")]
	public MapDetailStateData(bool isUnlocked, bool isDiscovered, bool isSurveyed)
	{
		m_IsUnlocked = false;
		m_IsDiscovered = false;
		m_IsSurveyed = false;
	}
}

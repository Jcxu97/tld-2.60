using Cpp2ILInjected;

[Token(Token = "0x2000750")]
public class GearSaveData
{
	[Token(Token = "0x4004E31")]
	[FieldOffset(Offset = "0x10")]
	public string m_PrefabName;

	[Token(Token = "0x4004E32")]
	[FieldOffset(Offset = "0x18")]
	public string m_SearializedGear;

	[Token(Token = "0x600434E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public GearSaveData()
	{
	}
}

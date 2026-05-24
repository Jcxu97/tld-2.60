using Cpp2ILInjected;
using TLD.IntBackedUnit;

[Token(Token = "0x2000526")]
public class NPCAfflictionSavedData
{
	[Token(Token = "0x4002F6B")]
	[FieldOffset(Offset = "0x10")]
	public bool m_Remedy1Complete;

	[Token(Token = "0x4002F6C")]
	[FieldOffset(Offset = "0x11")]
	public bool m_Remedy2Complete;

	[Token(Token = "0x4002F6D")]
	[FieldOffset(Offset = "0x12")]
	public bool m_AlternateRemedy1Complete;

	[Token(Token = "0x4002F6E")]
	[FieldOffset(Offset = "0x13")]
	public bool m_AlternateRemedy2Complete;

	[Token(Token = "0x4002F6F")]
	[FieldOffset(Offset = "0x18")]
	public ItemLiquidVolume m_WaterLiters;

	[Token(Token = "0x4002F70")]
	[FieldOffset(Offset = "0x20")]
	public float m_RestHours;

	[Token(Token = "0x4002F71")]
	[FieldOffset(Offset = "0x28")]
	public string m_AfflictionName;

	[Token(Token = "0x4002F72")]
	[FieldOffset(Offset = "0x30")]
	public AfflictionType m_AfflictionType;

	[Token(Token = "0x4002F73")]
	[FieldOffset(Offset = "0x34")]
	public AfflictionBodyArea m_Location;

	[Token(Token = "0x4002F74")]
	[FieldOffset(Offset = "0x38")]
	public string m_CauseLocId;

	[Token(Token = "0x6002751")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public NPCAfflictionSavedData()
	{
	}
}

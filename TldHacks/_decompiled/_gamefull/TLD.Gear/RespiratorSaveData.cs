using Cpp2ILInjected;

namespace TLD.Gear;

[Token(Token = "0x2001432")]
public class RespiratorSaveData
{
	[Token(Token = "0x400933F")]
	[FieldOffset(Offset = "0x10")]
	public GearItemSaveDataProxy AttachedCanister;

	[Token(Token = "0x4009340")]
	[FieldOffset(Offset = "0x18")]
	public bool IsEquippedInstance;

	[Token(Token = "0x4009341")]
	[FieldOffset(Offset = "0x20")]
	public string PostAnimCanisterPDID;

	[Token(Token = "0x60080D7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public RespiratorSaveData()
	{
	}
}

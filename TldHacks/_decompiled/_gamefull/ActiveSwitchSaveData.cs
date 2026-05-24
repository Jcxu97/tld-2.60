using Cpp2ILInjected;

[Token(Token = "0x20009EB")]
public class ActiveSwitchSaveData
{
	[Token(Token = "0x400651C")]
	[FieldOffset(Offset = "0x10")]
	public int m_ActiveStateIndex;

	[Token(Token = "0x400651D")]
	[FieldOffset(Offset = "0x18")]
	public string m_Guid;

	[Token(Token = "0x6005774")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ActiveSwitchSaveData()
	{
	}
}

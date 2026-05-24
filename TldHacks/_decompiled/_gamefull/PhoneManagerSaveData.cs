using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000793")]
public class PhoneManagerSaveData
{
	[Token(Token = "0x40050F4")]
	[FieldOffset(Offset = "0x10")]
	public List<DialogueSequenceProgressionInfo> m_ListDialogueSequenceInfo;

	[Token(Token = "0x40050F5")]
	[FieldOffset(Offset = "0x18")]
	public List<PhoneSaveDataInfo> m_ListPhoneSaveDataInfo;

	[Token(Token = "0x60046B4")]
	[Address(RVA = "0xCAF7C0", Offset = "0xCAE5C0", Length = "0x9F")]
	public void Reset()
	{
	}

	[Token(Token = "0x60046B5")]
	[Address(RVA = "0xCAF860", Offset = "0xCAE660", Length = "0x159")]
	public PhoneManagerSaveData()
	{
	}
}

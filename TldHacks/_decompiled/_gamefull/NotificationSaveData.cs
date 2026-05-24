using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x200078E")]
public class NotificationSaveData
{
	[Token(Token = "0x40050DE")]
	[FieldOffset(Offset = "0x10")]
	public List<NotificationFlagInfo> m_NotificationFlagInfo;

	[Token(Token = "0x6004696")]
	[Address(RVA = "0xCAB7B0", Offset = "0xCAA5B0", Length = "0xAD")]
	public NotificationSaveData()
	{
	}
}

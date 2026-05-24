using System;
using Cpp2ILInjected;

[Token(Token = "0x20001FA")]
public class ActionPickerItemData
{
	[Token(Token = "0x40011E9")]
	[FieldOffset(Offset = "0x10")]
	public string m_SpriteName;

	[Token(Token = "0x40011EA")]
	[FieldOffset(Offset = "0x18")]
	public string m_LocID;

	[Token(Token = "0x40011EB")]
	[FieldOffset(Offset = "0x20")]
	public Action m_Callback;

	[Token(Token = "0x60011FF")]
	[Address(RVA = "0x646370", Offset = "0x645170", Length = "0x114")]
	public ActionPickerItemData(string spriteName, string locID, Action callback)
	{
	}
}

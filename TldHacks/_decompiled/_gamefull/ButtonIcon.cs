using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x200020D")]
public class ButtonIcon
{
	[Token(Token = "0x4001289")]
	[FieldOffset(Offset = "0x10")]
	public string m_ButtonName;

	[Token(Token = "0x400128A")]
	[FieldOffset(Offset = "0x18")]
	public string m_IconName;

	[Token(Token = "0x400128B")]
	[FieldOffset(Offset = "0x20")]
	public UIAtlas m_Atlas;

	[Token(Token = "0x600128A")]
	[Address(RVA = "0x409520", Offset = "0x408320", Length = "0xAA")]
	public ButtonIcon(string name, string icon)
	{
	}
}

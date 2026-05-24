using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20002B1")]
public class FramedPhotoState
{
	[Token(Token = "0x40017EE")]
	[FieldOffset(Offset = "0x10")]
	public string m_GUID;

	[Token(Token = "0x40017EF")]
	[FieldOffset(Offset = "0x18")]
	public string m_PhotoID;

	[Token(Token = "0x60016EC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FramedPhotoState()
	{
	}
}

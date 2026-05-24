using Cpp2ILInjected;

[Token(Token = "0x2000693")]
public class DetailSurveyPosition
{
	[Token(Token = "0x400448E")]
	[FieldOffset(Offset = "0x10")]
	public int x;

	[Token(Token = "0x400448F")]
	[FieldOffset(Offset = "0x14")]
	public int y;

	[Token(Token = "0x4004490")]
	[FieldOffset(Offset = "0x18")]
	public int h;

	[Token(Token = "0x4004491")]
	[FieldOffset(Offset = "0x1C")]
	public int r;

	[Token(Token = "0x4004492")]
	[FieldOffset(Offset = "0x20")]
	public float m_Time;

	[Token(Token = "0x600381F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public DetailSurveyPosition()
	{
	}
}

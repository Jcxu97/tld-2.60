using Cpp2ILInjected;

[Token(Token = "0x2000122")]
public class UISDAtlas : UIAtlas
{
	[Token(Token = "0x4000900")]
	[FieldOffset(Offset = "0x68")]
	public float m_ReductionFactor;

	[Token(Token = "0x6000AA0")]
	[Address(RVA = "0x5C4C40", Offset = "0x5C3A40", Length = "0x7")]
	public UISDAtlas()
	{
	}
}

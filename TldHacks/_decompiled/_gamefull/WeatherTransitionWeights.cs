using Cpp2ILInjected;

[Token(Token = "0x200032E")]
public class WeatherTransitionWeights
{
	[Token(Token = "0x4001C69")]
	[FieldOffset(Offset = "0x10")]
	private readonly int[] m_Weights;

	[Token(Token = "0x170001FD")]
	public int Length
	{
		[Token(Token = "0x6001A1D")]
		[Address(RVA = "0x7494C0", Offset = "0x7482C0", Length = "0x1A")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170001FE")]
	public int this[WeatherSelectionWeight stage]
	{
		[Token(Token = "0x6001A1E")]
		[Address(RVA = "0x7494E0", Offset = "0x7482E0", Length = "0x2B")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001A1F")]
		[Address(RVA = "0x749510", Offset = "0x748310", Length = "0x2B")]
		set
		{
		}
	}

	[Token(Token = "0x170001FF")]
	public int this[int index]
	{
		[Token(Token = "0x6001A20")]
		[Address(RVA = "0x7494E0", Offset = "0x7482E0", Length = "0x2B")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6001A21")]
	[Address(RVA = "0x749540", Offset = "0x748340", Length = "0x7A")]
	public void Apply(WeatherTransitionWeights customWeights)
	{
	}

	[Token(Token = "0x6001A22")]
	[Address(RVA = "0x7495C0", Offset = "0x7483C0", Length = "0x2E4")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001A23")]
	[Address(RVA = "0x7498B0", Offset = "0x7486B0", Length = "0x87")]
	public WeatherTransitionWeights()
	{
	}
}

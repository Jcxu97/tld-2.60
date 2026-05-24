using Cpp2ILInjected;
using TLD.Stats;

[Token(Token = "0x20006D5")]
public abstract class StatsView
{
	[Token(Token = "0x6003C1C")]
	[Address(RVA = "0xB73BA0", Offset = "0xB729A0", Length = "0x3FD")]
	public string GetFormattedValue(StatInfo.Format format, float value)
	{
		return null;
	}

	[Token(Token = "0x6003C1D")]
	[Address(RVA = "0xB73FA0", Offset = "0xB72DA0", Length = "0x4B3")]
	public string GetFormattedTitle(string locId)
	{
		return null;
	}

	[Token(Token = "0x6003C1E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected StatsView()
	{
	}
}

using Cpp2ILInjected;
using TLD.Logging;

[Token(Token = "0x20007B4")]
public static class PlayerRichPresenceManager
{
	[Token(Token = "0x4005308")]
	public static readonly LogFilter s_LogFilter;

	[Token(Token = "0x4005309")]
	private static IRichPresenceProvider s_RichPresenceProvider;

	[Token(Token = "0x6004934")]
	[Address(RVA = "0xD16280", Offset = "0xD15080", Length = "0x157")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6004935")]
	[Address(RVA = "0xD163E0", Offset = "0xD151E0", Length = "0xA4")]
	public static void Update()
	{
	}

	[Token(Token = "0x6004936")]
	[Address(RVA = "0xD16490", Offset = "0xD15290", Length = "0x11B")]
	public static void Shutdown()
	{
	}

	[Token(Token = "0x6004937")]
	[Address(RVA = "0xD165B0", Offset = "0xD153B0", Length = "0x113")]
	public static void SetLocalizationKeys(RichPresenceLocInfo[] locKeys)
	{
	}

	[Token(Token = "0x6004938")]
	[Address(RVA = "0xD166D0", Offset = "0xD154D0", Length = "0x35")]
	private static IRichPresenceProvider AllocatePresenceProvider()
	{
		return null;
	}
}

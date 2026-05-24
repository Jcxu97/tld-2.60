using Cpp2ILInjected;

[Token(Token = "0x200090B")]
public class SteamRichPresenceProvider : RichPresenceLocalizedProviderBase
{
	[Token(Token = "0x4005E6F")]
	private const string SteamDisplayKeyName = "steam_display";

	[Token(Token = "0x4005E70")]
	private const string StatusKeyName = "#Status";

	[Token(Token = "0x4005E71")]
	private const string StatusVariableName = "status_value";

	[Token(Token = "0x6005281")]
	[Address(RVA = "0xE49D50", Offset = "0xE48B50", Length = "0x96")]
	protected override bool IsUserSignedOn()
	{
		return false;
	}

	[Token(Token = "0x6005282")]
	[Address(RVA = "0xE49DF0", Offset = "0xE48BF0", Length = "0x2F4")]
	protected override void ChangePresence()
	{
	}

	[Token(Token = "0x6005283")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SteamRichPresenceProvider()
	{
	}
}

using Cpp2ILInjected;

namespace TLD.Switch;

[Token(Token = "0x2001356")]
public static class SwitchNotificationHandler
{
	[Token(Token = "0x17000A51")]
	public static bool IsDocked
	{
		[Token(Token = "0x6007B94")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000A52")]
	public static bool IsBoosted
	{
		[Token(Token = "0x6007B95")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}
}

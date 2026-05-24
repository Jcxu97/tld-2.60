using Cpp2ILInjected;

[Token(Token = "0x2000297")]
public static class CameraDebugMode
{
	[Token(Token = "0x2000298")]
	public enum Mode
	{
		[Token(Token = "0x400176F")]
		Off,
		[Token(Token = "0x4001770")]
		Fly,
		[Token(Token = "0x4001771")]
		Lock
	}

	[Token(Token = "0x400176D")]
	public static Mode s_Mode;

	[Token(Token = "0x170001CE")]
	public static bool IsEnabled
	{
		[Token(Token = "0x6001646")]
		[Address(RVA = "0x6B6690", Offset = "0x6B5490", Length = "0x3E")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170001CF")]
	public static bool IsFly
	{
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x6B66D0", Offset = "0x6B54D0", Length = "0x3E")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170001D0")]
	public static bool IsLock
	{
		[Token(Token = "0x6001648")]
		[Address(RVA = "0x6B6710", Offset = "0x6B5510", Length = "0x3E")]
		get
		{
			return false;
		}
	}
}

using Cpp2ILInjected;

[Token(Token = "0x2000A97")]
public class uConsoleCommandFile
{
	[Token(Token = "0x4006842")]
	private static bool m_ProcessedMainConfigFile;

	[Token(Token = "0x4006843")]
	private static string[] m_PendingScriptCommands;

	[Token(Token = "0x4006844")]
	private static float m_ApplyScriptCommandsTime;

	[Token(Token = "0x4006845")]
	private static int m_ScriptCommandIndex;

	[Token(Token = "0x4006846")]
	private static string s_LastPathConfigFile;

	[Token(Token = "0x6005BF6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6005BF7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void DoFrame()
	{
	}

	[Token(Token = "0x6005BF8")]
	[Address(RVA = "0xF356A0", Offset = "0xF344A0", Length = "0x219")]
	public static void RegisterPendingCommands(string[] commandLines)
	{
	}

	[Token(Token = "0x6005BF9")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private static void ReadConfigFile(string filename)
	{
	}

	[Token(Token = "0x6005BFA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private static void ProcessScriptCommands()
	{
	}

	[Token(Token = "0x6005BFB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public uConsoleCommandFile()
	{
	}
}

using Cpp2ILInjected;

[Token(Token = "0x2000A9C")]
public class uConsoleInput
{
	[Token(Token = "0x4006855")]
	public static bool m_ForceSubmit;

	[Token(Token = "0x4006856")]
	public static bool m_ForceAutoComplete;

	[Token(Token = "0x4006857")]
	public static bool m_ForceRecallUp;

	[Token(Token = "0x4006858")]
	public static bool m_ForceRecallDown;

	[Token(Token = "0x4006859")]
	public static bool m_ForceScrollLogUp;

	[Token(Token = "0x400685A")]
	public static bool m_ForceScrollLogDown;

	[Token(Token = "0x400685B")]
	public static char[] m_DelimterChars;

	[Token(Token = "0x400685C")]
	private static int m_LastHistoryIndexRecalled;

	[Token(Token = "0x400685D")]
	private static float m_TimeRecallUpPressed;

	[Token(Token = "0x400685E")]
	private static float m_TimeRecallDownPressed;

	[Token(Token = "0x400685F")]
	private static float m_TimeScrollUpPressed;

	[Token(Token = "0x4006860")]
	private static float m_TimeScrollDownPressed;

	[Token(Token = "0x4006861")]
	private static float m_CommandRepeatTimeSeconds;

	[Token(Token = "0x6005C29")]
	[Address(RVA = "0xF38DC0", Offset = "0xF37BC0", Length = "0x57")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6005C2A")]
	[Address(RVA = "0xF38E20", Offset = "0xF37C20", Length = "0x1FD")]
	public static void DoFrame()
	{
	}

	[Token(Token = "0x6005C2B")]
	[Address(RVA = "0xF39020", Offset = "0xF37E20", Length = "0x118")]
	private static void SubmitCommand()
	{
	}

	[Token(Token = "0x6005C2C")]
	[Address(RVA = "0xF39140", Offset = "0xF37F40", Length = "0x24B")]
	private static void AutoComplete()
	{
	}

	[Token(Token = "0x6005C2D")]
	[Address(RVA = "0xF39390", Offset = "0xF38190", Length = "0x1C8")]
	private static void RecallCommandUp()
	{
	}

	[Token(Token = "0x6005C2E")]
	[Address(RVA = "0xF39560", Offset = "0xF38360", Length = "0x1BA")]
	private static void RecallCommandDown()
	{
	}

	[Token(Token = "0x6005C2F")]
	[Address(RVA = "0xF39720", Offset = "0xF38520", Length = "0x3E1")]
	private static void ProcessActivationInput()
	{
	}

	[Token(Token = "0x6005C30")]
	[Address(RVA = "0xF39B10", Offset = "0xF38910", Length = "0x21B")]
	private static void ProcessSubmitInput()
	{
	}

	[Token(Token = "0x6005C31")]
	[Address(RVA = "0xF39D30", Offset = "0xF38B30", Length = "0x115")]
	private static void ProcessAutoCompleteInput()
	{
	}

	[Token(Token = "0x6005C32")]
	[Address(RVA = "0xF39E50", Offset = "0xF38C50", Length = "0x5AA")]
	private static void ProcessHistoryInput()
	{
	}

	[Token(Token = "0x6005C33")]
	[Address(RVA = "0xF3A400", Offset = "0xF39200", Length = "0x942")]
	private static void ProcessLogInput()
	{
	}

	[Token(Token = "0x6005C34")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public uConsoleInput()
	{
	}
}

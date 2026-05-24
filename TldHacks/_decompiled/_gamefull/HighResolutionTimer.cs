using Cpp2ILInjected;

[Token(Token = "0x2000300")]
public class HighResolutionTimer
{
	[Token(Token = "0x2000301")]
	private class HighResolutionTimerSaveDataProxy
	{
		[Token(Token = "0x4001A83")]
		[FieldOffset(Offset = "0x10")]
		public ulong m_ElapsedTime;

		[Token(Token = "0x60018C9")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public HighResolutionTimerSaveDataProxy()
		{
		}
	}

	[Token(Token = "0x4001A7B")]
	private const double SECOND_IN_MILLISECONDS = 1000.0;

	[Token(Token = "0x4001A7C")]
	private const double MINUTE_IN_MILLISECONDS = 60000.0;

	[Token(Token = "0x4001A7D")]
	private const double HOUR_IN_MILLISECONDS = 3600000.0;

	[Token(Token = "0x4001A7E")]
	private const double DAY_IN_MILLISECONDS = 86400000.0;

	[Token(Token = "0x4001A7F")]
	[FieldOffset(Offset = "0x10")]
	private ulong m_ElapsedTime;

	[Token(Token = "0x4001A80")]
	[FieldOffset(Offset = "0x18")]
	private ulong m_StartTime;

	[Token(Token = "0x4001A81")]
	[FieldOffset(Offset = "0x20")]
	private bool m_IsRunning;

	[Token(Token = "0x4001A82")]
	private static HighResolutionTimerSaveDataProxy s_TimerSaveDataProxy;

	[Token(Token = "0x60018AF")]
	[Address(RVA = "0x6F5BA0", Offset = "0x6F49A0", Length = "0x4A")]
	public static HighResolutionTimer FromMilliseconds(ulong milliseconds)
	{
		return null;
	}

	[Token(Token = "0x60018B0")]
	[Address(RVA = "0x6F5BF0", Offset = "0x6F49F0", Length = "0xB6")]
	public static HighResolutionTimer FromSeconds(double seconds)
	{
		return null;
	}

	[Token(Token = "0x60018B1")]
	[Address(RVA = "0x6F5CB0", Offset = "0x6F4AB0", Length = "0xB6")]
	public static HighResolutionTimer FromMinutes(double minutes)
	{
		return null;
	}

	[Token(Token = "0x60018B2")]
	[Address(RVA = "0x6F5D70", Offset = "0x6F4B70", Length = "0xB6")]
	public static HighResolutionTimer FromHours(double hours)
	{
		return null;
	}

	[Token(Token = "0x60018B3")]
	[Address(RVA = "0x6F5E30", Offset = "0x6F4C30", Length = "0xB6")]
	public static HighResolutionTimer FromDays(double days)
	{
		return null;
	}

	[Token(Token = "0x60018B4")]
	[Address(RVA = "0x6F5EF0", Offset = "0x6F4CF0", Length = "0x6C")]
	public void Start()
	{
	}

	[Token(Token = "0x60018B5")]
	[Address(RVA = "0x6F5F60", Offset = "0x6F4D60", Length = "0x24")]
	public void Stop()
	{
	}

	[Token(Token = "0x60018B6")]
	[Address(RVA = "0x6F5F90", Offset = "0x6F4D90", Length = "0x78")]
	public void Restart()
	{
	}

	[Token(Token = "0x60018B7")]
	[Address(RVA = "0x6283C0", Offset = "0x6271C0", Length = "0x8")]
	public bool IsPaused()
	{
		return false;
	}

	[Token(Token = "0x60018B8")]
	[Address(RVA = "0x6F6010", Offset = "0x6F4E10", Length = "0x86")]
	public ulong GetElapsedMilliseconds()
	{
		return 0uL;
	}

	[Token(Token = "0x60018B9")]
	[Address(RVA = "0x6F60A0", Offset = "0x6F4EA0", Length = "0x92")]
	public float GetElapsedSeconds()
	{
		return 0f;
	}

	[Token(Token = "0x60018BA")]
	[Address(RVA = "0x6F6140", Offset = "0x6F4F40", Length = "0x92")]
	public float GetElapsedMinutes()
	{
		return 0f;
	}

	[Token(Token = "0x60018BB")]
	[Address(RVA = "0x6F61E0", Offset = "0x6F4FE0", Length = "0x92")]
	public float GetElapsedHours()
	{
		return 0f;
	}

	[Token(Token = "0x60018BC")]
	[Address(RVA = "0x6F6280", Offset = "0x6F5080", Length = "0x92")]
	public float GetElapsedDays()
	{
		return 0f;
	}

	[Token(Token = "0x60018BD")]
	[Address(RVA = "0x6F6320", Offset = "0x6F5120", Length = "0xF0")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60018BE")]
	[Address(RVA = "0x6F6420", Offset = "0x6F5220", Length = "0x8E")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60018BF")]
	[Address(RVA = "0x6F64B0", Offset = "0x6F52B0", Length = "0x34")]
	public static double MillisecondsToSeconds(ulong milliseconds)
	{
		return 0.0;
	}

	[Token(Token = "0x60018C0")]
	[Address(RVA = "0x6F64F0", Offset = "0x6F52F0", Length = "0x34")]
	public static double MilliSecondsToMinutes(ulong milliseconds)
	{
		return 0.0;
	}

	[Token(Token = "0x60018C1")]
	[Address(RVA = "0x6F6530", Offset = "0x6F5330", Length = "0x34")]
	public static double MillisecondsToHours(ulong milliseconds)
	{
		return 0.0;
	}

	[Token(Token = "0x60018C2")]
	[Address(RVA = "0x6F6570", Offset = "0x6F5370", Length = "0x34")]
	public static double MillisecondsToDays(ulong milliseconds)
	{
		return 0.0;
	}

	[Token(Token = "0x60018C3")]
	[Address(RVA = "0x6F65B0", Offset = "0x6F53B0", Length = "0x47")]
	public static ulong SecondsToMilliseconds(double seconds)
	{
		return 0uL;
	}

	[Token(Token = "0x60018C4")]
	[Address(RVA = "0x6F6600", Offset = "0x6F5400", Length = "0x47")]
	public static ulong MinutesToMilliseconds(double minutes)
	{
		return 0uL;
	}

	[Token(Token = "0x60018C5")]
	[Address(RVA = "0x6F6650", Offset = "0x6F5450", Length = "0x47")]
	public static ulong HoursToMilliseconds(double hours)
	{
		return 0uL;
	}

	[Token(Token = "0x60018C6")]
	[Address(RVA = "0x6F66A0", Offset = "0x6F54A0", Length = "0x47")]
	public static ulong DaysToMilliseconds(double days)
	{
		return 0uL;
	}

	[Token(Token = "0x60018C7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public HighResolutionTimer()
	{
	}
}

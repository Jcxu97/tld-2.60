using System;
using Cpp2ILInjected;

[Token(Token = "0x2000834")]
public class MissionTimer
{
	[Flags]
	[Token(Token = "0x2000835")]
	public enum MissionTimerOptions
	{
		[Token(Token = "0x4005621")]
		None = 0,
		[Token(Token = "0x4005622")]
		Realtime = 1,
		[Token(Token = "0x4005623")]
		AccountsForLoadingTime = 2,
		[Token(Token = "0x4005624")]
		Countdown = 4,
		[Token(Token = "0x4005625")]
		ShowOnHud = 8,
		[Token(Token = "0x4005626")]
		RemoveOnExpire = 0x10
	}

	[Token(Token = "0x400560B")]
	private const float HOURS_TO_SECONDS_SCALAR = 3600f;

	[Token(Token = "0x400560C")]
	private const float SECONDS_TO_HOURS_SCALAR = 0.00027777778f;

	[Token(Token = "0x400560D")]
	private const float SECONDS_PER_TICK = 1E-07f;

	[Token(Token = "0x400560E")]
	private static MissionTimerSaveProxy m_MissionTimerSaveProxy;

	[Token(Token = "0x400560F")]
	[FieldOffset(Offset = "0x10")]
	private DateTime m_TimerStartTime;

	[Token(Token = "0x4005610")]
	[FieldOffset(Offset = "0x18")]
	private Panel_Loading m_Loading;

	[Token(Token = "0x4005611")]
	public const string TIMER_DATE_FORMAT = "yyyy-mm-dd H:mm:ss";

	[Token(Token = "0x4005612")]
	[FieldOffset(Offset = "0x20")]
	public MissionManagerBase m_MissionManager;

	[Token(Token = "0x4005613")]
	[FieldOffset(Offset = "0x28")]
	public MissionServicesManager m_MainMissionManager;

	[Token(Token = "0x4005614")]
	[FieldOffset(Offset = "0x30")]
	public string m_Name;

	[Token(Token = "0x4005615")]
	[FieldOffset(Offset = "0x38")]
	public MissionTimerType m_Type;

	[Token(Token = "0x4005616")]
	[FieldOffset(Offset = "0x3C")]
	public bool m_IsRealtime;

	[Token(Token = "0x4005617")]
	[FieldOffset(Offset = "0x40")]
	public float m_Duration;

	[Token(Token = "0x4005618")]
	[FieldOffset(Offset = "0x44")]
	public float m_BaseTime;

	[Token(Token = "0x4005619")]
	[FieldOffset(Offset = "0x48")]
	public bool m_ShowOnHUD;

	[Token(Token = "0x400561A")]
	[FieldOffset(Offset = "0x50")]
	public string m_EventOnExpire;

	[Token(Token = "0x400561B")]
	[FieldOffset(Offset = "0x58")]
	public bool m_RemoveOnExpire;

	[Token(Token = "0x400561C")]
	[FieldOffset(Offset = "0x59")]
	private bool m_ExpireHandled;

	[Token(Token = "0x400561D")]
	[FieldOffset(Offset = "0x5C")]
	private float m_ElapsedFromSave;

	[Token(Token = "0x400561E")]
	[FieldOffset(Offset = "0x60")]
	private bool m_AccountsForLoadingTime;

	[Token(Token = "0x400561F")]
	public static bool s_Debug;

	[Token(Token = "0x17000351")]
	public float Time
	{
		[Token(Token = "0x6004C58")]
		[Address(RVA = "0xD6E380", Offset = "0xD6D180", Length = "0x45")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000352")]
	public float ElapsedTime
	{
		[Token(Token = "0x6004C59")]
		[Address(RVA = "0xD6E3D0", Offset = "0xD6D1D0", Length = "0xED")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x6004C56")]
	[Address(RVA = "0xD6E000", Offset = "0xD6CE00", Length = "0x16E")]
	public MissionTimer(MissionServicesManager mainMissionManager, MissionManagerBase manager, string name)
	{
	}

	[Token(Token = "0x6004C57")]
	[Address(RVA = "0xD6E170", Offset = "0xD6CF70", Length = "0x204")]
	public void Initialize(MissionTimerType type, float duration, string eventOnExpire, MissionTimerOptions timerOptions)
	{
	}

	[Token(Token = "0x6004C5A")]
	[Address(RVA = "0xD6E4C0", Offset = "0xD6D2C0", Length = "0x355")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004C5B")]
	[Address(RVA = "0xD6E820", Offset = "0xD6D620", Length = "0x197")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004C5C")]
	[Address(RVA = "0xD6E9C0", Offset = "0xD6D7C0", Length = "0xE3")]
	public void PostDeserialize()
	{
	}

	[Token(Token = "0x6004C5D")]
	[Address(RVA = "0xD6EAB0", Offset = "0xD6D8B0", Length = "0x174")]
	public bool Update()
	{
		return false;
	}

	[Token(Token = "0x6004C5E")]
	[Address(RVA = "0xD6EC30", Offset = "0xD6DA30", Length = "0x32")]
	public void PostExpireEvent()
	{
	}

	[Token(Token = "0x6004C5F")]
	[Address(RVA = "0xD6EC70", Offset = "0xD6DA70", Length = "0x94")]
	private float GetAllSecondsElapsedSinceTimerStarted()
	{
		return 0f;
	}

	[Token(Token = "0x6004C60")]
	[Address(RVA = "0xD6ED10", Offset = "0xD6DB10", Length = "0x78")]
	public string GetTimerTypeString()
	{
		return null;
	}

	[Token(Token = "0x6004C61")]
	[Address(RVA = "0xD6ED90", Offset = "0xD6DB90", Length = "0x266")]
	public string GetDebugString()
	{
		return null;
	}

	[Token(Token = "0x6004C62")]
	[Address(RVA = "0xD6F000", Offset = "0xD6DE00", Length = "0x22E")]
	public static string GetDebugText()
	{
		return null;
	}
}

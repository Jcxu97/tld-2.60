using Cpp2ILInjected;

[Token(Token = "0x2000833")]
public class MissionTimerSaveProxy
{
	[Token(Token = "0x4005601")]
	[FieldOffset(Offset = "0x10")]
	public MissionTimerType m_Type;

	[Token(Token = "0x4005602")]
	[FieldOffset(Offset = "0x14")]
	public bool m_IsRealtime;

	[Token(Token = "0x4005603")]
	[FieldOffset(Offset = "0x15")]
	public bool m_ShowOnHUD;

	[Token(Token = "0x4005604")]
	[FieldOffset(Offset = "0x18")]
	public float m_Duration;

	[Token(Token = "0x4005605")]
	[FieldOffset(Offset = "0x20")]
	public string m_EventOnExpire;

	[Token(Token = "0x4005606")]
	[FieldOffset(Offset = "0x28")]
	public bool m_RemoveOnExpire;

	[Token(Token = "0x4005607")]
	[FieldOffset(Offset = "0x29")]
	public bool m_ExpireHandled;

	[Token(Token = "0x4005608")]
	[FieldOffset(Offset = "0x2C")]
	public float m_ElapsedTime;

	[Token(Token = "0x4005609")]
	[FieldOffset(Offset = "0x30")]
	public bool m_AccountsForLoadingTime;

	[Token(Token = "0x400560A")]
	[FieldOffset(Offset = "0x38")]
	public string m_StartingTime;

	[Token(Token = "0x6004C55")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public MissionTimerSaveProxy()
	{
	}
}

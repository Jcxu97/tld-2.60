using Cpp2ILInjected;

[Token(Token = "0x200070F")]
public class AuroraManagerSaveDataProxy
{
	[Token(Token = "0x4004B01")]
	[FieldOffset(Offset = "0x10")]
	public bool m_ForceDisable;

	[Token(Token = "0x4004B02")]
	[FieldOffset(Offset = "0x11")]
	public bool m_ForceAuroraNextOpportunity;

	[Token(Token = "0x4004B03")]
	[FieldOffset(Offset = "0x12")]
	public bool m_ForceAuroraEarlyWindowAllowed;

	[Token(Token = "0x4004B04")]
	[FieldOffset(Offset = "0x13")]
	public bool m_ForceAuroraLateWindowAllowed;

	[Token(Token = "0x4004B05")]
	[FieldOffset(Offset = "0x14")]
	public float m_ForceAuroraDurationOverride;

	[Token(Token = "0x4004B06")]
	[FieldOffset(Offset = "0x18")]
	public bool m_IsDoingForceAurora;

	[Token(Token = "0x4004B07")]
	[FieldOffset(Offset = "0x19")]
	public bool m_HasForcedAuroraStarted;

	[Token(Token = "0x4004B08")]
	[FieldOffset(Offset = "0x1C")]
	public int m_NumAurorasForSave;

	[Token(Token = "0x4004B09")]
	[FieldOffset(Offset = "0x20")]
	public float m_LastAuroraDays;

	[Token(Token = "0x6003DDF")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public AuroraManagerSaveDataProxy()
	{
	}
}

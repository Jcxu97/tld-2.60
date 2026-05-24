using Cpp2ILInjected;

[Token(Token = "0x20008B1")]
public class PlayerClimbRopeProxy
{
	[Token(Token = "0x4005A4B")]
	[FieldOffset(Offset = "0x10")]
	public string m_RopeGuid;

	[Token(Token = "0x4005A4C")]
	[FieldOffset(Offset = "0x18")]
	public float m_SplineT;

	[Token(Token = "0x4005A4D")]
	[FieldOffset(Offset = "0x1C")]
	public float m_NoStaminaTimerSeconds;

	[Token(Token = "0x4005A4E")]
	[FieldOffset(Offset = "0x20")]
	public float m_NextSlipRollSeconds;

	[Token(Token = "0x4005A4F")]
	[FieldOffset(Offset = "0x24")]
	public float m_NextSlipChance;

	[Token(Token = "0x4005A50")]
	[FieldOffset(Offset = "0x28")]
	public float m_NextFallChance;

	[Token(Token = "0x6004FE5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayerClimbRopeProxy()
	{
	}
}

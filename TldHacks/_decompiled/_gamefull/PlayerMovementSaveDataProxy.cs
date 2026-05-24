using Cpp2ILInjected;

[Token(Token = "0x20008BD")]
public class PlayerMovementSaveDataProxy
{
	[Token(Token = "0x4005B26")]
	[FieldOffset(Offset = "0x10")]
	public float m_SprintStamina;

	[Token(Token = "0x4005B27")]
	[FieldOffset(Offset = "0x14")]
	public PlayerMovement.ForcedMovement m_ForcedMovement;

	[Token(Token = "0x4005B28")]
	[FieldOffset(Offset = "0x18")]
	public bool m_ForceNoSprain;

	[Token(Token = "0x4005B29")]
	[FieldOffset(Offset = "0x19")]
	public bool m_IsCrouching;

	[Token(Token = "0x6005046")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayerMovementSaveDataProxy()
	{
	}
}

using Cpp2ILInjected;

[Token(Token = "0x2000A0B")]
public struct FPSCounterEvent
{
	[Token(Token = "0x40065D9")]
	[FieldOffset(Offset = "0x0")]
	public float m_FPS;

	[Token(Token = "0x40065DA")]
	[FieldOffset(Offset = "0x8")]
	public long m_AllocatedMemory;

	[Token(Token = "0x40065DB")]
	[FieldOffset(Offset = "0x10")]
	public long m_ReservedMemory;

	[Token(Token = "0x40065DC")]
	[FieldOffset(Offset = "0x18")]
	public long m_GraphicsMemory;

	[Token(Token = "0x40065DD")]
	[FieldOffset(Offset = "0x20")]
	public ulong m_TextureMemory;

	[Token(Token = "0x40065DE")]
	[FieldOffset(Offset = "0x28")]
	public double m_CPUTimeMs;

	[Token(Token = "0x40065DF")]
	[FieldOffset(Offset = "0x30")]
	public double m_GPUTimeMs;

	[Token(Token = "0x40065E0")]
	[FieldOffset(Offset = "0x38")]
	public int m_Resolution;
}

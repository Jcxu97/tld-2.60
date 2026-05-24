using Cpp2ILInjected;

[Token(Token = "0x2000913")]
public struct SaveGameOperationData
{
	[Token(Token = "0x4005E91")]
	[FieldOffset(Offset = "0x0")]
	public string m_Name;

	[Token(Token = "0x4005E92")]
	[FieldOffset(Offset = "0x8")]
	public string m_Data;

	[Token(Token = "0x4005E93")]
	[FieldOffset(Offset = "0x10")]
	public string m_DisplayName;

	[Token(Token = "0x4005E94")]
	[FieldOffset(Offset = "0x18")]
	public SaveGameOperationType m_SaveGameOperationType;

	[Token(Token = "0x4005E95")]
	[FieldOffset(Offset = "0x1C")]
	public float m_ElapsedAsyncSeconds;
}

using Cpp2ILInjected;

[Token(Token = "0x2000772")]
public struct IndoorWardData
{
	[Token(Token = "0x4004FD9")]
	[FieldOffset(Offset = "0x0")]
	public string m_Scene;

	[Token(Token = "0x4004FDA")]
	[FieldOffset(Offset = "0x8")]
	public string m_SceneGuid;

	[Token(Token = "0x4004FDB")]
	[FieldOffset(Offset = "0x10")]
	public string m_ExitPoint;

	[Token(Token = "0x4004FDC")]
	[FieldOffset(Offset = "0x18")]
	public string m_Guid;

	[Token(Token = "0x4004FDD")]
	[FieldOffset(Offset = "0x20")]
	public float m_Radius;

	[Token(Token = "0x4004FDE")]
	[FieldOffset(Offset = "0x24")]
	public float m_LifetimeHours;

	[Token(Token = "0x4004FDF")]
	[FieldOffset(Offset = "0x28")]
	public float m_HoursAtCreateTime;
}

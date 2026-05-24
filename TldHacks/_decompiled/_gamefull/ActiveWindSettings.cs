using Cpp2ILInjected;

[Token(Token = "0x2000333")]
public class ActiveWindSettings
{
	[Token(Token = "0x4001C8B")]
	[FieldOffset(Offset = "0x10")]
	public float m_Angle;

	[Token(Token = "0x4001C8C")]
	[FieldOffset(Offset = "0x14")]
	public float m_Velocity;

	[Token(Token = "0x4001C8D")]
	[FieldOffset(Offset = "0x18")]
	public float m_Gustiness;

	[Token(Token = "0x4001C8E")]
	[FieldOffset(Offset = "0x1C")]
	public float m_LateralBluster;

	[Token(Token = "0x4001C8F")]
	[FieldOffset(Offset = "0x20")]
	public float m_VerticalBluster;

	[Token(Token = "0x6001A26")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ActiveWindSettings()
	{
	}

	[Token(Token = "0x6001A27")]
	[Address(RVA = "0x749940", Offset = "0x748740", Length = "0x1DD")]
	public ActiveWindSettings(WindSettings ws, float angle = -1f)
	{
	}

	[Token(Token = "0x6001A28")]
	[Address(RVA = "0x749B20", Offset = "0x748920", Length = "0x31")]
	public ActiveWindSettings(ActiveWindSettings other)
	{
	}

	[Token(Token = "0x6001A29")]
	[Address(RVA = "0x749B60", Offset = "0x748960", Length = "0x17D")]
	public void SetBlended(ActiveWindSettings a, ActiveWindSettings b, float blend)
	{
	}
}

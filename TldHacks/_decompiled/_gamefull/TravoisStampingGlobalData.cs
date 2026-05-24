using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000408")]
internal class TravoisStampingGlobalData
{
	[Token(Token = "0x40024A1")]
	[FieldOffset(Offset = "0x10")]
	public RenderTexture m_StampingTarget0;

	[Token(Token = "0x40024A2")]
	[FieldOffset(Offset = "0x18")]
	public RenderTexture m_StampingTarget1;

	[Token(Token = "0x40024A3")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 m_StampingWorldPreviousOffset;

	[Token(Token = "0x40024A4")]
	[FieldOffset(Offset = "0x2C")]
	public float m_PreviousSnowDepth;

	[Token(Token = "0x40024A5")]
	[FieldOffset(Offset = "0x30")]
	public string m_PreviousOutdoorSceneName;

	[Token(Token = "0x40024A6")]
	[FieldOffset(Offset = "0x38")]
	public float m_GameHoursTimestamp;

	[Token(Token = "0x6001EB8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public TravoisStampingGlobalData()
	{
	}
}

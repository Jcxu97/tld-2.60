using Cpp2ILInjected;

[Token(Token = "0x20004A5")]
public class GunItemSaveDataProxy
{
	[Token(Token = "0x4002ADE")]
	[FieldOffset(Offset = "0x10")]
	public int m_RoundsInClipProxy;

	[Token(Token = "0x4002ADF")]
	[FieldOffset(Offset = "0x14")]
	public bool m_IsJammed;

	[Token(Token = "0x4002AE0")]
	[FieldOffset(Offset = "0x18")]
	public int[] m_Clip;

	[Token(Token = "0x4002AE1")]
	[FieldOffset(Offset = "0x20")]
	public int m_SpentCasingsInClip;

	[Token(Token = "0x4002AE2")]
	[FieldOffset(Offset = "0x24")]
	public int m_SelectedAmmoIndex;

	[Token(Token = "0x600236A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public GunItemSaveDataProxy()
	{
	}
}

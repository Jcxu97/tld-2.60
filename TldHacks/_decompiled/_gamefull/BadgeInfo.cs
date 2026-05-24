using Cpp2ILInjected;
using UnityEngine.AddressableAssets;

[Token(Token = "0x200060A")]
public class BadgeInfo
{
	[Token(Token = "0x4003854")]
	[FieldOffset(Offset = "0x10")]
	public AssetReferenceTexture2D m_Sprite;

	[Token(Token = "0x4003855")]
	[FieldOffset(Offset = "0x18")]
	public string m_NameLocID;

	[Token(Token = "0x4003856")]
	[FieldOffset(Offset = "0x20")]
	public string m_Desc;

	[Token(Token = "0x4003857")]
	[FieldOffset(Offset = "0x28")]
	public bool m_Unlocked;

	[Token(Token = "0x4003858")]
	[FieldOffset(Offset = "0x2C")]
	public float m_NormalizedProgress;

	[Token(Token = "0x4003859")]
	[FieldOffset(Offset = "0x30")]
	public string m_Benefit;

	[Token(Token = "0x6002F37")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BadgeInfo()
	{
	}
}

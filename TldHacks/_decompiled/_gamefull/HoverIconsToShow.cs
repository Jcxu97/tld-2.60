using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000588")]
public class HoverIconsToShow : MonoBehaviour
{
	[Token(Token = "0x2000589")]
	public enum HoverIcons
	{
		[Token(Token = "0x40032F4")]
		Firestarting,
		[Token(Token = "0x40032F5")]
		Food,
		[Token(Token = "0x40032F6")]
		RawMaterial,
		[Token(Token = "0x40032F7")]
		Tool,
		[Token(Token = "0x40032F8")]
		Clothing,
		[Token(Token = "0x40032F9")]
		FirstAid,
		[Token(Token = "0x40032FA")]
		Locked
	}

	[Token(Token = "0x40032F2")]
	[FieldOffset(Offset = "0x20")]
	public HoverIcons[] m_HoverIcons;

	[Token(Token = "0x6002AAA")]
	[Address(RVA = "0x9086C0", Offset = "0x9074C0", Length = "0xB4")]
	public static string GetSpriteNameForHoverIcon(HoverIcons hoverIcon)
	{
		return null;
	}

	[Token(Token = "0x6002AAB")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public HoverIconsToShow()
	{
	}
}

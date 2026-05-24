using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu(null)]
[Token(Token = "0x20006E0")]
public class PopupBase : Panel_Base
{
	[Token(Token = "0x400495A")]
	private static List<PopupBase> s_PopupList;

	[Token(Token = "0x6003C9C")]
	[Address(RVA = "0xB820F0", Offset = "0xB80EF0", Length = "0xC7")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003C9D")]
	[Address(RVA = "0xB821C0", Offset = "0xB80FC0", Length = "0x82")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003C9E")]
	[Address(RVA = "0xB82250", Offset = "0xB81050", Length = "0x169")]
	private void Update()
	{
	}

	[Token(Token = "0x6003C9F")]
	[Address(RVA = "0xB823C0", Offset = "0xB811C0", Length = "0x2AB")]
	public static void Quit()
	{
	}

	[Token(Token = "0x6003CA0")]
	[Address(RVA = "0xB82670", Offset = "0xB81470", Length = "0x75")]
	public static bool IsPopupActive()
	{
		return false;
	}

	[Token(Token = "0x6003CA1")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[Token(Token = "0x6003CA2")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PopupBase()
	{
	}
}

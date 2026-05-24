using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200024F")]
public class HoverWidgetControl : MonoBehaviour
{
	[Token(Token = "0x4001481")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget m_WidgetToEnableOnHover;

	[Token(Token = "0x6001448")]
	[Address(RVA = "0x681680", Offset = "0x680480", Length = "0x20")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001449")]
	[Address(RVA = "0x6816B0", Offset = "0x6804B0", Length = "0x1E")]
	private void OnHover(bool isHovering)
	{
	}

	[Token(Token = "0x600144A")]
	[Address(RVA = "0x681680", Offset = "0x680480", Length = "0x20")]
	private void OnDragOut()
	{
	}

	[Token(Token = "0x600144B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public HoverWidgetControl()
	{
	}
}

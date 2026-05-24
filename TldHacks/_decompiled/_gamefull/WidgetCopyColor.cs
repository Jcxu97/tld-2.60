using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(UIWidget))]
[Token(Token = "0x2000296")]
public class WidgetCopyColor : MonoBehaviour
{
	[Token(Token = "0x400176B")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget m_WidgetToCopy;

	[Token(Token = "0x400176C")]
	[FieldOffset(Offset = "0x28")]
	private UIWidget m_Widget;

	[Token(Token = "0x6001642")]
	[Address(RVA = "0x6B6320", Offset = "0x6B5120", Length = "0x8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001643")]
	[Address(RVA = "0x6B63B0", Offset = "0x6B51B0", Length = "0xD4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001644")]
	[Address(RVA = "0x6B6490", Offset = "0x6B5290", Length = "0x1F9")]
	private void Update()
	{
	}

	[Token(Token = "0x6001645")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public WidgetCopyColor()
	{
	}
}

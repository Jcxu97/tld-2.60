using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Button Keys (Legacy)")]
[Token(Token = "0x2000065")]
public class UIButtonKeys : UIKeyNavigation
{
	[Token(Token = "0x40003BB")]
	[FieldOffset(Offset = "0xB8")]
	public UIButtonKeys selectOnClick;

	[Token(Token = "0x40003BC")]
	[FieldOffset(Offset = "0xC0")]
	public UIButtonKeys selectOnUp;

	[Token(Token = "0x40003BD")]
	[FieldOffset(Offset = "0xC8")]
	public UIButtonKeys selectOnDown;

	[Token(Token = "0x40003BE")]
	[FieldOffset(Offset = "0xD0")]
	public UIButtonKeys selectOnLeft;

	[Token(Token = "0x40003BF")]
	[FieldOffset(Offset = "0xD8")]
	public UIButtonKeys selectOnRight;

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0xA277A0", Offset = "0xA265A0", Length = "0x1F")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0xA277C0", Offset = "0xA265C0", Length = "0xA2C")]
	public void Upgrade()
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0xA281F0", Offset = "0xA26FF0", Length = "0x79")]
	public UIButtonKeys()
	{
	}
}

using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Key Binding")]
[Token(Token = "0x2000080")]
public class UIKeyBinding : MonoBehaviour
{
	[Token(Token = "0x2000081")]
	public enum Action
	{
		[Token(Token = "0x4000476")]
		PressAndClick,
		[Token(Token = "0x4000477")]
		Select,
		[Token(Token = "0x4000478")]
		All
	}

	[Token(Token = "0x2000082")]
	public enum Modifier
	{
		[Token(Token = "0x400047A")]
		Any,
		[Token(Token = "0x400047B")]
		Shift,
		[Token(Token = "0x400047C")]
		Control,
		[Token(Token = "0x400047D")]
		Alt,
		[Token(Token = "0x400047E")]
		None
	}

	[Token(Token = "0x400046F")]
	[FieldOffset(Offset = "0x20")]
	public KeyCode keyCode;

	[Token(Token = "0x4000470")]
	[FieldOffset(Offset = "0x24")]
	public Modifier modifier;

	[Token(Token = "0x4000471")]
	[FieldOffset(Offset = "0x28")]
	public Action action;

	[Token(Token = "0x4000472")]
	[FieldOffset(Offset = "0x2C")]
	private bool mIgnoreUp;

	[Token(Token = "0x4000473")]
	[FieldOffset(Offset = "0x2D")]
	private bool mIsInput;

	[Token(Token = "0x4000474")]
	[FieldOffset(Offset = "0x2E")]
	private bool mPress;

	[Token(Token = "0x600046C")]
	[Address(RVA = "0xA3CC80", Offset = "0xA3BA80", Length = "0x1E6")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0xA3CE70", Offset = "0xA3BC70", Length = "0x7C")]
	protected virtual void OnSubmit()
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0xA3CEF0", Offset = "0xA3BCF0", Length = "0x149")]
	protected virtual bool IsModifierActive()
	{
		return false;
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0xA3D040", Offset = "0xA3BE40", Length = "0x337")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0xA3D380", Offset = "0xA3C180", Length = "0x9B")]
	protected virtual void OnBindingPress(bool pressed)
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0xA3D420", Offset = "0xA3C220", Length = "0xD6")]
	protected virtual void OnBindingClick()
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UIKeyBinding()
	{
	}
}

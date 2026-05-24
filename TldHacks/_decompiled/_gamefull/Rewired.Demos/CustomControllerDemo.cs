using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[Token(Token = "0x2000C44")]
public class CustomControllerDemo : MonoBehaviour
{
	[Token(Token = "0x4007CBE")]
	[FieldOffset(Offset = "0x20")]
	public int playerId;

	[Token(Token = "0x4007CBF")]
	[FieldOffset(Offset = "0x28")]
	public string controllerTag;

	[Token(Token = "0x4007CC0")]
	[FieldOffset(Offset = "0x30")]
	public bool useUpdateCallbacks;

	[Token(Token = "0x4007CC1")]
	[FieldOffset(Offset = "0x34")]
	private int buttonCount;

	[Token(Token = "0x4007CC2")]
	[FieldOffset(Offset = "0x38")]
	private int axisCount;

	[Token(Token = "0x4007CC3")]
	[FieldOffset(Offset = "0x40")]
	private float[] axisValues;

	[Token(Token = "0x4007CC4")]
	[FieldOffset(Offset = "0x48")]
	private bool[] buttonValues;

	[Token(Token = "0x4007CC5")]
	[FieldOffset(Offset = "0x50")]
	private TouchJoystickExample[] joysticks;

	[Token(Token = "0x4007CC6")]
	[FieldOffset(Offset = "0x58")]
	private TouchButtonExample[] buttons;

	[Token(Token = "0x4007CC7")]
	[FieldOffset(Offset = "0x60")]
	private CustomController controller;

	[NonSerialized]
	[Token(Token = "0x4007CC8")]
	[FieldOffset(Offset = "0x68")]
	private bool initialized;

	[Token(Token = "0x6006366")]
	[Address(RVA = "0xFCD6A0", Offset = "0xFCC4A0", Length = "0xA5")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006367")]
	[Address(RVA = "0xFCD750", Offset = "0xFCC550", Length = "0x728")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6006368")]
	[Address(RVA = "0xFCDE80", Offset = "0xFCCC80", Length = "0xA4")]
	private void Update()
	{
	}

	[Token(Token = "0x6006369")]
	[Address(RVA = "0xFCDF30", Offset = "0xFCCD30", Length = "0x159")]
	private void OnInputSourceUpdate()
	{
	}

	[Token(Token = "0x600636A")]
	[Address(RVA = "0xFCE090", Offset = "0xFCCE90", Length = "0xA9")]
	private void GetSourceAxisValues()
	{
	}

	[Token(Token = "0x600636B")]
	[Address(RVA = "0xFCE140", Offset = "0xFCCF40", Length = "0x70")]
	private void GetSourceButtonValues()
	{
	}

	[Token(Token = "0x600636C")]
	[Address(RVA = "0xFCE1C0", Offset = "0xFCCFC0", Length = "0x221")]
	private void SetControllerAxisValues()
	{
	}

	[Token(Token = "0x600636D")]
	[Address(RVA = "0xFCE3F0", Offset = "0xFCD1F0", Length = "0x21B")]
	private void SetControllerButtonValues()
	{
	}

	[Token(Token = "0x600636E")]
	[Address(RVA = "0xFCE610", Offset = "0xFCD410", Length = "0x37")]
	private float GetAxisValueCallback(int index)
	{
		return 0f;
	}

	[Token(Token = "0x600636F")]
	[Address(RVA = "0xFCE650", Offset = "0xFCD450", Length = "0x38")]
	private bool GetButtonValueCallback(int index)
	{
		return false;
	}

	[Token(Token = "0x6006370")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CustomControllerDemo()
	{
	}
}

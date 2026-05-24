using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[Token(Token = "0x2000C4C")]
public class FallbackJoystickIdentificationDemo : MonoBehaviour
{
	[Token(Token = "0x4007CEF")]
	private const float windowWidth = 250f;

	[Token(Token = "0x4007CF0")]
	private const float windowHeight = 250f;

	[Token(Token = "0x4007CF1")]
	private const float inputDelay = 1f;

	[Token(Token = "0x4007CF2")]
	[FieldOffset(Offset = "0x20")]
	private bool identifyRequired;

	[Token(Token = "0x4007CF3")]
	[FieldOffset(Offset = "0x28")]
	private Queue<Joystick> joysticksToIdentify;

	[Token(Token = "0x4007CF4")]
	[FieldOffset(Offset = "0x30")]
	private float nextInputAllowedTime;

	[Token(Token = "0x4007CF5")]
	[FieldOffset(Offset = "0x38")]
	private GUIStyle style;

	[Token(Token = "0x600639E")]
	[Address(RVA = "0xFD2610", Offset = "0xFD1410", Length = "0x10C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600639F")]
	[Address(RVA = "0xFD2720", Offset = "0xFD1520", Length = "0x7")]
	private void JoystickConnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x60063A0")]
	[Address(RVA = "0xFD2720", Offset = "0xFD1520", Length = "0x7")]
	private void JoystickDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x60063A1")]
	[Address(RVA = "0xFD2730", Offset = "0xFD1530", Length = "0x290")]
	public void IdentifyAllJoysticks()
	{
	}

	[Token(Token = "0x60063A2")]
	[Address(RVA = "0xFD29D0", Offset = "0xFD17D0", Length = "0x58")]
	private void SetInputDelay()
	{
	}

	[Token(Token = "0x60063A3")]
	[Address(RVA = "0xFD2A30", Offset = "0xFD1830", Length = "0x295")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60063A4")]
	[Address(RVA = "0xFD2CD0", Offset = "0xFD1AD0", Length = "0x26B")]
	private void DrawDialogWindow(int windowId)
	{
	}

	[Token(Token = "0x60063A5")]
	[Address(RVA = "0xFD2F40", Offset = "0xFD1D40", Length = "0x5C")]
	private void Reset()
	{
	}

	[Token(Token = "0x60063A6")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FallbackJoystickIdentificationDemo()
	{
	}
}

using Cpp2ILInjected;
using Rewired.ControllerExtensions;
using Rewired.Interfaces;

namespace Rewired.Demos.CustomPlatform;

[Token(Token = "0x2000C69")]
public sealed class MyPlatformControllerExtension : CustomControllerExtension, IControllerVibrator
{
	[Token(Token = "0x2000C6A")]
	private class Source : IControllerExtensionSource
	{
		[Token(Token = "0x4007D95")]
		[FieldOffset(Offset = "0x10")]
		public readonly MyPlatformInputSource.Joystick sourceJoystick;

		[Token(Token = "0x6006441")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		public Source(MyPlatformInputSource.Joystick sourceJoystick)
		{
		}
	}

	[Token(Token = "0x170006BA")]
	public int vibrationMotorCount
	{
		[Token(Token = "0x600643A")]
		[Address(RVA = "0x901E60", Offset = "0x900C60", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6006437")]
	[Address(RVA = "0xFE35B0", Offset = "0xFE23B0", Length = "0xA9")]
	public MyPlatformControllerExtension(MyPlatformInputSource.Joystick sourceJoystick)
		: base((IControllerExtensionSource)null)
	{
	}

	[Token(Token = "0x6006438")]
	[Address(RVA = "0xFE3660", Offset = "0xFE2460", Length = "0x81")]
	private MyPlatformControllerExtension(MyPlatformControllerExtension other)
		: base((IControllerExtensionSource)null)
	{
	}

	[Token(Token = "0x6006439")]
	[Address(RVA = "0xFE36F0", Offset = "0xFE24F0", Length = "0xB4")]
	public override Controller.Extension ShallowCopy()
	{
		return null;
	}

	[Token(Token = "0x600643B")]
	[Address(RVA = "0xFE37B0", Offset = "0xFE25B0", Length = "0x226")]
	public void SetVibration(int motorIndex, float motorLevel)
	{
	}

	[Token(Token = "0x600643C")]
	[Address(RVA = "0xFE39E0", Offset = "0xFE27E0", Length = "0xC0")]
	public void SetVibration(int motorIndex, float motorLevel, float duration)
	{
	}

	[Token(Token = "0x600643D")]
	[Address(RVA = "0xFE3AB0", Offset = "0xFE28B0", Length = "0xBF")]
	public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
	{
	}

	[Token(Token = "0x600643E")]
	[Address(RVA = "0xFE3B70", Offset = "0xFE2970", Length = "0xCF")]
	public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors)
	{
	}

	[Token(Token = "0x600643F")]
	[Address(RVA = "0xFE3C40", Offset = "0xFE2A40", Length = "0x84")]
	public float GetVibration(int motorIndex)
	{
		return 0f;
	}

	[Token(Token = "0x6006440")]
	[Address(RVA = "0xFE3CD0", Offset = "0xFE2AD0", Length = "0xF5")]
	public void StopVibration()
	{
	}
}

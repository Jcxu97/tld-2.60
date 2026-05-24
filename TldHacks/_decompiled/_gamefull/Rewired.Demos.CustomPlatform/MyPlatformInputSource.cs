using System.Collections.Generic;
using Cpp2ILInjected;
using Rewired.Interfaces;
using Rewired.Platforms.Custom;

namespace Rewired.Demos.CustomPlatform;

[Token(Token = "0x2000C70")]
public sealed class MyPlatformInputSource : CustomPlatformInputSource
{
	[Token(Token = "0x2000C71")]
	public new sealed class Joystick : CustomPlatformInputSource.Joystick, IControllerVibrator
	{
		[Token(Token = "0x4007D9F")]
		[FieldOffset(Offset = "0x90")]
		private UnityInputJoystickSource.Joystick _sourceJoystick;

		[Token(Token = "0x170006BC")]
		public UnityInputJoystickSource.Joystick sourceJoystick
		{
			[Token(Token = "0x6006455")]
			[Address(RVA = "0x40DA00", Offset = "0x40C800", Length = "0x8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006BD")]
		public int vibrationMotorCount
		{
			[Token(Token = "0x6006458")]
			[Address(RVA = "0xFE51D0", Offset = "0xFE3FD0", Length = "0x1D")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x6006456")]
		[Address(RVA = "0xFE4D20", Offset = "0xFE3B20", Length = "0x1DD")]
		public Joystick(UnityInputJoystickSource.Joystick sourceJoystick)
			: base(null, 0L, 0, 0)
		{
		}

		[Token(Token = "0x6006457")]
		[Address(RVA = "0xFE4F00", Offset = "0xFE3D00", Length = "0x2C2")]
		public override void Update()
		{
		}

		[Token(Token = "0x6006459")]
		[Address(RVA = "0xFE51F0", Offset = "0xFE3FF0", Length = "0x1AE")]
		public void SetVibration(int motorIndex, float motorLevel)
		{
		}

		[Token(Token = "0x600645A")]
		[Address(RVA = "0xFE53A0", Offset = "0xFE41A0", Length = "0x27")]
		public void SetVibration(int motorIndex, float motorLevel, float duration)
		{
		}

		[Token(Token = "0x600645B")]
		[Address(RVA = "0xFE53D0", Offset = "0xFE41D0", Length = "0x27")]
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
		{
		}

		[Token(Token = "0x600645C")]
		[Address(RVA = "0xFE5400", Offset = "0xFE4200", Length = "0x30")]
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors)
		{
		}

		[Token(Token = "0x600645D")]
		[Address(RVA = "0xFE5440", Offset = "0xFE4240", Length = "0x1B")]
		public float GetVibration(int motorIndex)
		{
			return 0f;
		}

		[Token(Token = "0x600645E")]
		[Address(RVA = "0xFE5460", Offset = "0xFE4260", Length = "0x83")]
		public void StopVibration()
		{
		}
	}

	[Token(Token = "0x4007D9C")]
	[FieldOffset(Offset = "0x68")]
	private UnityInputJoystickSource _joystickInputSource;

	[Token(Token = "0x4007D9D")]
	[FieldOffset(Offset = "0x70")]
	private bool _initialized;

	[Token(Token = "0x4007D9E")]
	[FieldOffset(Offset = "0x71")]
	private bool _disposed;

	[Token(Token = "0x170006BB")]
	public override bool isReady
	{
		[Token(Token = "0x600644D")]
		[Address(RVA = "0x664EB0", Offset = "0x663CB0", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x600644E")]
	[Address(RVA = "0xFE4010", Offset = "0xFE2E10", Length = "0x269")]
	public MyPlatformInputSource(CustomPlatformConfigVars configVars)
		: base(null, null)
	{
	}

	[Token(Token = "0x600644F")]
	[Address(RVA = "0xFE4280", Offset = "0xFE3080", Length = "0xB")]
	protected override void OnInitialize()
	{
	}

	[Token(Token = "0x6006450")]
	[Address(RVA = "0xFE4290", Offset = "0xFE3090", Length = "0xAB")]
	public override void Update()
	{
	}

	[Token(Token = "0x6006451")]
	[Address(RVA = "0xFE4340", Offset = "0xFE3140", Length = "0x800")]
	private void MonitorDeviceChanges()
	{
	}

	[Token(Token = "0x6006452")]
	[Address(RVA = "0xFE4B50", Offset = "0xFE3950", Length = "0x1D")]
	protected override void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x6006453")]
	[Address(RVA = "0xFE4B70", Offset = "0xFE3970", Length = "0xEB")]
	private static bool ContainsJoystickBySystemId(IList<CustomInputSource.Joystick> joysticks, long systemId)
	{
		return false;
	}

	[Token(Token = "0x6006454")]
	[Address(RVA = "0xFE4C60", Offset = "0xFE3A60", Length = "0xB1")]
	private static bool ContainsSystemJoystickBySystemId(IList<UnityInputJoystickSource.Joystick> systemJoysticks, long systemId)
	{
		return false;
	}
}

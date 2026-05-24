using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Cpp2ILInjected;
using Rewired.Interfaces;

namespace Rewired.Demos.CustomPlatform;

[Token(Token = "0x2000C74")]
public class UnityInputJoystickSource
{
	[Token(Token = "0x2000C75")]
	public class Joystick : IControllerVibrator
	{
		[Token(Token = "0x4007DA7")]
		private const int maxJoysticks = 8;

		[Token(Token = "0x4007DA8")]
		private const int maxAxes = 10;

		[Token(Token = "0x4007DA9")]
		private const int maxButtons = 20;

		[Token(Token = "0x4007DAA")]
		[FieldOffset(Offset = "0x10")]
		public readonly long systemId;

		[Token(Token = "0x4007DAB")]
		[FieldOffset(Offset = "0x18")]
		public readonly string deviceName;

		[Token(Token = "0x4007DAC")]
		[FieldOffset(Offset = "0x20")]
		public Guid deviceInstanceGuid;

		[Token(Token = "0x4007DAD")]
		[FieldOffset(Offset = "0x30")]
		public readonly int axisCount;

		[Token(Token = "0x4007DAE")]
		[FieldOffset(Offset = "0x34")]
		public readonly int buttonCount;

		[Token(Token = "0x4007DAF")]
		[FieldOffset(Offset = "0x38")]
		public MyPlatformControllerIdentifier identifier;

		[Token(Token = "0x4007DB0")]
		[FieldOffset(Offset = "0x40")]
		public readonly bool[] buttonValues;

		[Token(Token = "0x4007DB1")]
		[FieldOffset(Offset = "0x48")]
		public readonly float[] axisValues;

		[Token(Token = "0x4007DB2")]
		[FieldOffset(Offset = "0x50")]
		public int unityIndex;

		[Token(Token = "0x170006BF")]
		[field: Token(Token = "0x4007DB3")]
		[field: FieldOffset(Offset = "0x54")]
		public int vibrationMotorCount
		{
			[Token(Token = "0x600646F")]
			[Address(RVA = "0x667470", Offset = "0x666270", Length = "0x4")]
			get;
			[Token(Token = "0x6006470")]
			[Address(RVA = "0xFE71B0", Offset = "0xFE5FB0", Length = "0x4")]
			set;
		}

		[Token(Token = "0x600646C")]
		[Address(RVA = "0xFE6ED0", Offset = "0xFE5CD0", Length = "0x194")]
		public Joystick(long systemId, string deviceName, int axisCount, int buttonCount)
		{
		}

		[Token(Token = "0x600646D")]
		[Address(RVA = "0xFE7070", Offset = "0xFE5E70", Length = "0x71")]
		public bool GetButtonValue(int index)
		{
			return false;
		}

		[Token(Token = "0x600646E")]
		[Address(RVA = "0xFE70F0", Offset = "0xFE5EF0", Length = "0xBC")]
		public float GetAxisValue(int index)
		{
			return 0f;
		}

		[Token(Token = "0x6006471")]
		[Address(RVA = "0xFE71C0", Offset = "0xFE5FC0", Length = "0x1A1")]
		public void SetVibration(int motorIndex, float motorLevel)
		{
		}

		[Token(Token = "0x6006472")]
		[Address(RVA = "0xFE7370", Offset = "0xFE6170", Length = "0x233")]
		public void SetVibration(int motorIndex, float motorLevel, float duration)
		{
		}

		[Token(Token = "0x6006473")]
		[Address(RVA = "0xFE75B0", Offset = "0xFE63B0", Length = "0x23A")]
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
		{
		}

		[Token(Token = "0x6006474")]
		[Address(RVA = "0xFE77F0", Offset = "0xFE65F0", Length = "0x2C0")]
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors)
		{
		}

		[Token(Token = "0x6006475")]
		[Address(RVA = "0x699F10", Offset = "0x698D10", Length = "0x4")]
		public float GetVibration(int motorIndex)
		{
			return 0f;
		}

		[Token(Token = "0x6006476")]
		[Address(RVA = "0xFE7AC0", Offset = "0xFE68C0", Length = "0x75")]
		public void StopVibration()
		{
		}
	}

	[Token(Token = "0x4007DA1")]
	private const float joystickCheckInterval = 1f;

	[Token(Token = "0x4007DA2")]
	private static int systemIdCounter;

	[Token(Token = "0x4007DA3")]
	[FieldOffset(Offset = "0x10")]
	private string[] _unityJoysticks;

	[Token(Token = "0x4007DA4")]
	[FieldOffset(Offset = "0x18")]
	private double _nextJoystickCheckTime;

	[Token(Token = "0x4007DA5")]
	[FieldOffset(Offset = "0x20")]
	private List<Joystick> _joysticks;

	[Token(Token = "0x4007DA6")]
	[FieldOffset(Offset = "0x28")]
	private ReadOnlyCollection<Joystick> _joysticks_readOnly;

	[Token(Token = "0x6006466")]
	[Address(RVA = "0xFE6400", Offset = "0xFE5200", Length = "0x22C")]
	public UnityInputJoystickSource()
	{
	}

	[Token(Token = "0x6006467")]
	[Address(RVA = "0xFE6630", Offset = "0xFE5430", Length = "0x91")]
	public void Update()
	{
	}

	[Token(Token = "0x6006468")]
	[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
	public IList<Joystick> GetJoysticks()
	{
		return null;
	}

	[Token(Token = "0x6006469")]
	[Address(RVA = "0xFE6630", Offset = "0xFE5430", Length = "0x91")]
	private void CheckForJoystickChanges()
	{
	}

	[Token(Token = "0x600646A")]
	[Address(RVA = "0xFE66D0", Offset = "0xFE54D0", Length = "0x1AB")]
	private bool DidJoysticksChange()
	{
		return false;
	}

	[Token(Token = "0x600646B")]
	[Address(RVA = "0xFE6880", Offset = "0xFE5680", Length = "0x64B")]
	private void RefreshJoysticks()
	{
	}
}

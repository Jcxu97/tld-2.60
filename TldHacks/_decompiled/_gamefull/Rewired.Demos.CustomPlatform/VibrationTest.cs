using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos.CustomPlatform;

[Token(Token = "0x2000C76")]
public class VibrationTest : MonoBehaviour
{
	[Token(Token = "0x4007DB4")]
	[FieldOffset(Offset = "0x20")]
	public int playerId;

	[Token(Token = "0x4007DB5")]
	[FieldOffset(Offset = "0x24")]
	public float vibrationIncrement;

	[Token(Token = "0x4007DB6")]
	[FieldOffset(Offset = "0x28")]
	private float[] motors;

	[Token(Token = "0x4007DB7")]
	private static readonly string[] action_motors;

	[Token(Token = "0x4007DB8")]
	private static readonly string action_stop;

	[Token(Token = "0x170006C0")]
	private Player player
	{
		[Token(Token = "0x6006477")]
		[Address(RVA = "0xFE7B40", Offset = "0xFE6940", Length = "0x63")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006478")]
	[Address(RVA = "0xFE7BB0", Offset = "0xFE69B0", Length = "0x36B")]
	private void Update()
	{
	}

	[Token(Token = "0x6006479")]
	[Address(RVA = "0xFE7F20", Offset = "0xFE6D20", Length = "0x89")]
	private void StopVibration()
	{
	}

	[Token(Token = "0x600647A")]
	[Address(RVA = "0xFE7FB0", Offset = "0xFE6DB0", Length = "0xD0")]
	private void SetVibration(int motorIndex, float value)
	{
	}

	[Token(Token = "0x600647B")]
	[Address(RVA = "0xFE8090", Offset = "0xFE6E90", Length = "0xC5")]
	public VibrationTest()
	{
	}
}

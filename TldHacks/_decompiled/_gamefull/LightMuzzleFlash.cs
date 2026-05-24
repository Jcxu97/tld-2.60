using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(Light))]
[Token(Token = "0x20003C5")]
public class LightMuzzleFlash : MonoBehaviour
{
	[Token(Token = "0x40021F2")]
	[FieldOffset(Offset = "0x20")]
	public float duration;

	[Token(Token = "0x40021F3")]
	[FieldOffset(Offset = "0x24")]
	public float intensity;

	[Token(Token = "0x40021F4")]
	[FieldOffset(Offset = "0x28")]
	public float radius;

	[Token(Token = "0x40021F5")]
	[FieldOffset(Offset = "0x2C")]
	private float durTimer;

	[Token(Token = "0x6001D86")]
	[Address(RVA = "0x7A5450", Offset = "0x7A4250", Length = "0x93")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D87")]
	[Address(RVA = "0x7A54F0", Offset = "0x7A42F0", Length = "0x198")]
	private void Update()
	{
	}

	[Token(Token = "0x6001D88")]
	[Address(RVA = "0x7A5690", Offset = "0x7A4490", Length = "0x8")]
	public void Shoot()
	{
	}

	[Token(Token = "0x6001D89")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LightMuzzleFlash()
	{
	}
}

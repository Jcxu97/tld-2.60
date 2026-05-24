using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(Light))]
[Token(Token = "0x20003C2")]
public class LightFadeFire : MonoBehaviour
{
	[Token(Token = "0x40021D9")]
	[FieldOffset(Offset = "0x20")]
	public Fire sourceFire;

	[Token(Token = "0x40021DA")]
	[FieldOffset(Offset = "0x28")]
	public bool startOff;

	[Token(Token = "0x40021DB")]
	[FieldOffset(Offset = "0x29")]
	public bool useFireIgnitionFirst;

	[Token(Token = "0x40021DC")]
	[FieldOffset(Offset = "0x2A")]
	public bool autoSwitchAfterIngnition;

	[Token(Token = "0x40021DD")]
	[FieldOffset(Offset = "0x2C")]
	public float fullOnMinutes;

	[Token(Token = "0x40021DE")]
	[FieldOffset(Offset = "0x30")]
	public float fullOffMinutes;

	[Token(Token = "0x40021DF")]
	[FieldOffset(Offset = "0x34")]
	private float originalBrightness;

	[Token(Token = "0x40021E0")]
	[FieldOffset(Offset = "0x38")]
	private float maxTimeSec;

	[Token(Token = "0x40021E1")]
	[FieldOffset(Offset = "0x3C")]
	private float minTimeSec;

	[Token(Token = "0x40021E2")]
	[FieldOffset(Offset = "0x40")]
	private float ignitionDuration;

	[Token(Token = "0x40021E3")]
	[FieldOffset(Offset = "0x44")]
	private float fireTime;

	[Token(Token = "0x40021E4")]
	[FieldOffset(Offset = "0x48")]
	private float fadeTimeNormalized;

	[Token(Token = "0x40021E5")]
	[FieldOffset(Offset = "0x4C")]
	private float fadeTimeDifference;

	[Token(Token = "0x40021E6")]
	[FieldOffset(Offset = "0x50")]
	private float fadeTimeStep;

	[Token(Token = "0x40021E7")]
	[FieldOffset(Offset = "0x58")]
	private Light m_Light;

	[Token(Token = "0x6001D7C")]
	[Address(RVA = "0x7A4990", Offset = "0x7A3790", Length = "0x4D")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D7D")]
	[Address(RVA = "0x7A49E0", Offset = "0x7A37E0", Length = "0x40F")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001D7E")]
	[Address(RVA = "0x7A4DF0", Offset = "0x7A3BF0", Length = "0x21")]
	public void SetNewMaxTime(float newMax)
	{
	}

	[Token(Token = "0x6001D7F")]
	[Address(RVA = "0x77CC30", Offset = "0x77BA30", Length = "0x50")]
	public LightFadeFire()
	{
	}
}

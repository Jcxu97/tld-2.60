using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009E1")]
public class UniStorm : MonoBehaviour
{
	[ExecuteInEditMode]
	[Token(Token = "0x4006443")]
	[FieldOffset(Offset = "0x20")]
	public float flashLength;

	[Token(Token = "0x4006444")]
	[FieldOffset(Offset = "0x24")]
	public float lightningStrikeOdds;

	[Token(Token = "0x4006445")]
	[FieldOffset(Offset = "0x28")]
	public float minIntensity;

	[Token(Token = "0x4006446")]
	[FieldOffset(Offset = "0x2C")]
	public float maxIntensity;

	[Token(Token = "0x4006447")]
	[FieldOffset(Offset = "0x30")]
	public float minRotationAmount;

	[Token(Token = "0x4006448")]
	[FieldOffset(Offset = "0x34")]
	public float maxRotationAmount;

	[Token(Token = "0x4006449")]
	[FieldOffset(Offset = "0x38")]
	public float minRotationAmountX;

	[Token(Token = "0x400644A")]
	[FieldOffset(Offset = "0x3C")]
	public float maxRotationAmountX;

	[Token(Token = "0x400644B")]
	[FieldOffset(Offset = "0x40")]
	public float minRotationAmountZ;

	[Token(Token = "0x400644C")]
	[FieldOffset(Offset = "0x44")]
	public float maxRotationAmountZ;

	[Token(Token = "0x400644D")]
	[FieldOffset(Offset = "0x48")]
	public GameObject lightningBolt1;

	[Token(Token = "0x400644E")]
	[FieldOffset(Offset = "0x50")]
	public GameObject lightningBolt2;

	[Token(Token = "0x400644F")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip[] lightningSound;

	[Token(Token = "0x4006450")]
	[FieldOffset(Offset = "0x60")]
	private int lastTime;

	[Token(Token = "0x4006451")]
	[FieldOffset(Offset = "0x64")]
	private float random;

	[Token(Token = "0x600570C")]
	[Address(RVA = "0xEC8AE0", Offset = "0xEC78E0", Length = "0x5B")]
	public void Start()
	{
	}

	[Token(Token = "0x600570D")]
	[Address(RVA = "0xEC8B40", Offset = "0xEC7940", Length = "0x7A7")]
	public void Update()
	{
	}

	[Token(Token = "0x600570E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UniStorm()
	{
	}
}

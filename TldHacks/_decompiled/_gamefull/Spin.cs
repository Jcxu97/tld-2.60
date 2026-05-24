using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Spin")]
[Token(Token = "0x2000057")]
public class Spin : MonoBehaviour
{
	[Token(Token = "0x4000374")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 rotationsPerSecond;

	[Token(Token = "0x4000375")]
	[FieldOffset(Offset = "0x2C")]
	public bool ignoreTimeScale;

	[Token(Token = "0x4000376")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody mRb;

	[Token(Token = "0x4000377")]
	[FieldOffset(Offset = "0x38")]
	private Transform mTrans;

	[Token(Token = "0x600037F")]
	[Address(RVA = "0xA20480", Offset = "0xA1F280", Length = "0xF9")]
	private void Start()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0xA20580", Offset = "0xA1F380", Length = "0x157")]
	private void Update()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xA206E0", Offset = "0xA1F4E0", Length = "0x114")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0xA20800", Offset = "0xA1F600", Length = "0x43F")]
	public void ApplyDelta(float delta)
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xA20C40", Offset = "0xA1FA40", Length = "0x6B")]
	public Spin()
	{
	}
}

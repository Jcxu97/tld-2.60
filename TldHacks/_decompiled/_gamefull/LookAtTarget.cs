using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Look At Target")]
[Token(Token = "0x2000052")]
public class LookAtTarget : MonoBehaviour
{
	[Token(Token = "0x4000365")]
	[FieldOffset(Offset = "0x20")]
	public int level;

	[Token(Token = "0x4000366")]
	[FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x4000367")]
	[FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x4000368")]
	[FieldOffset(Offset = "0x38")]
	private Transform mTrans;

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x690320", Offset = "0x68F120", Length = "0x57")]
	private void Start()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0xA1E4F0", Offset = "0xA1D2F0", Length = "0x533")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xA1EA30", Offset = "0xA1D830", Length = "0x4A")]
	public LookAtTarget()
	{
	}
}

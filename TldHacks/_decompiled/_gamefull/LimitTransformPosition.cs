using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000256")]
public class LimitTransformPosition : MonoBehaviour
{
	[Token(Token = "0x4001519")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 m_LimitsX;

	[Token(Token = "0x400151A")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 m_LimitsY;

	[Token(Token = "0x400151B")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 m_LimitsZ;

	[Token(Token = "0x400151C")]
	[FieldOffset(Offset = "0x38")]
	private Transform m_Transform;

	[Token(Token = "0x400151D")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 m_TransformPosCache;

	[Token(Token = "0x60014A3")]
	[Address(RVA = "0x690320", Offset = "0x68F120", Length = "0x57")]
	private void Start()
	{
	}

	[Token(Token = "0x60014A4")]
	[Address(RVA = "0x690380", Offset = "0x68F180", Length = "0x5D5")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60014A5")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LimitTransformPosition()
	{
	}
}

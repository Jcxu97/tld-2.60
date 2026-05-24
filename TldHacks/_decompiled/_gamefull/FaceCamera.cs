using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000388")]
public class FaceCamera : MonoBehaviour
{
	[Token(Token = "0x4001F9D")]
	[FieldOffset(Offset = "0x20")]
	public bool m_FaceCamera;

	[Token(Token = "0x4001F9E")]
	[FieldOffset(Offset = "0x21")]
	public bool m_YAxisOnly;

	[Token(Token = "0x4001F9F")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 m_OrientationOffset;

	[Token(Token = "0x4001FA0")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_TargetPosition;

	[Token(Token = "0x6001C50")]
	[Address(RVA = "0x77D790", Offset = "0x77C590", Length = "0x60E")]
	private void Update()
	{
	}

	[Token(Token = "0x6001C51")]
	[Address(RVA = "0x6A2880", Offset = "0x6A1680", Length = "0x47")]
	public FaceCamera()
	{
	}
}

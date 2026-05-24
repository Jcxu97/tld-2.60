using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000415")]
public class Wiggle : MonoBehaviour
{
	[Header("Position")]
	[Token(Token = "0x40024CE")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 m_PositionHeightScale;

	[Token(Token = "0x40024CF")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 m_PositionNoiseScale;

	[Header("Scale")]
	[Token(Token = "0x40024D0")]
	[FieldOffset(Offset = "0x38")]
	public bool m_UniformScaleBasedOnX;

	[Token(Token = "0x40024D1")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 m_ScaleHeightScale;

	[Token(Token = "0x40024D2")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 m_ScaleNoiseScale;

	[Header("Rotation")]
	[Token(Token = "0x40024D3")]
	[FieldOffset(Offset = "0x54")]
	public Vector3 m_RotationHeightScale;

	[Token(Token = "0x40024D4")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 m_RotationNoiseScale;

	[Token(Token = "0x40024D5")]
	[FieldOffset(Offset = "0x6C")]
	private float m_Seed;

	[Token(Token = "0x40024D6")]
	[FieldOffset(Offset = "0x70")]
	private float m_SeededTime;

	[Token(Token = "0x40024D7")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 m_PositionPerlinValues;

	[Token(Token = "0x40024D8")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 m_ScalePerlinValues;

	[Token(Token = "0x40024D9")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 m_RotationPerlinValues;

	[Token(Token = "0x40024DA")]
	[FieldOffset(Offset = "0x98")]
	private Vector3 m_PositionOriginal;

	[Token(Token = "0x40024DB")]
	[FieldOffset(Offset = "0xA4")]
	private Vector3 m_ScaleOriginal;

	[Token(Token = "0x40024DC")]
	[FieldOffset(Offset = "0xB0")]
	private Vector3 m_RotationOriginal;

	[Token(Token = "0x6001EDB")]
	[Address(RVA = "0x7CE0F0", Offset = "0x7CCEF0", Length = "0x4EA")]
	public void Start()
	{
	}

	[Token(Token = "0x6001EDC")]
	[Address(RVA = "0x7CE5E0", Offset = "0x7CD3E0", Length = "0xA58")]
	public void Update()
	{
	}

	[Token(Token = "0x6001EDD")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Wiggle()
	{
	}
}

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000406")]
public class TransformAtNight : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400246B")]
	[FieldOffset(Offset = "0x20")]
	private bool m_ReverseToD;

	[Header("Position")]
	[SerializeField]
	[Token(Token = "0x400246C")]
	[FieldOffset(Offset = "0x21")]
	private bool m_AdjustPosition;

	[SerializeField]
	[Token(Token = "0x400246D")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 m_Position;

	[Token(Token = "0x400246E")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_OriginalPosition;

	[Header("Rotation")]
	[SerializeField]
	[Token(Token = "0x400246F")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_AdjustRotation;

	[SerializeField]
	[Token(Token = "0x4002470")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 m_Rotation;

	[Token(Token = "0x4002471")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 m_OriginalRotation;

	[Header("Scale")]
	[SerializeField]
	[Token(Token = "0x4002472")]
	[FieldOffset(Offset = "0x58")]
	private bool m_AdjustScale;

	[SerializeField]
	[Token(Token = "0x4002473")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 m_Scale;

	[Token(Token = "0x4002474")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 m_OriginalScale;

	[Token(Token = "0x4002475")]
	[FieldOffset(Offset = "0x74")]
	private float m_NightPercentage;

	[Token(Token = "0x6001EAA")]
	[Address(RVA = "0x7C8550", Offset = "0x7C7350", Length = "0x1BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6001EAB")]
	[Address(RVA = "0x7C8710", Offset = "0x7C7510", Length = "0x7C")]
	private void Update()
	{
	}

	[Token(Token = "0x6001EAC")]
	[Address(RVA = "0x7C8790", Offset = "0x7C7590", Length = "0x370")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001EAD")]
	[Address(RVA = "0x7C8B10", Offset = "0x7C7910", Length = "0x103")]
	public TransformAtNight()
	{
	}
}

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000372")]
public class CheatTowardsCamera : MonoBehaviour
{
	[Token(Token = "0x4001E9B")]
	[FieldOffset(Offset = "0x20")]
	public float m_CheatDistance;

	[Token(Token = "0x4001E9C")]
	[FieldOffset(Offset = "0x24")]
	private float m_DisplacementSpeed;

	[Token(Token = "0x4001E9D")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 m_LastPosition;

	[Token(Token = "0x6001BEE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6001BEF")]
	[Address(RVA = "0x76DE30", Offset = "0x76CC30", Length = "0x3D6")]
	private void Update()
	{
	}

	[Token(Token = "0x6001BF0")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CheatTowardsCamera()
	{
	}
}

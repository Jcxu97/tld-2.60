using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[Token(Token = "0x200038A")]
public class FastCloth : MonoBehaviour
{
	[Token(Token = "0x4001FA4")]
	[FieldOffset(Offset = "0x20")]
	public FastClothData m_ClothData;

	[SerializeField]
	[Token(Token = "0x4001FA5")]
	[FieldOffset(Offset = "0x28")]
	private MeshRenderer m_Renderer;

	[SerializeField]
	[Token(Token = "0x4001FA6")]
	[FieldOffset(Offset = "0x30")]
	private MeshFilter m_MeshFilter;

	[Token(Token = "0x6001C56")]
	[Address(RVA = "0x77E0A0", Offset = "0x77CEA0", Length = "0x16B")]
	private void Start()
	{
	}

	[Token(Token = "0x6001C57")]
	[Address(RVA = "0x77E210", Offset = "0x77D010", Length = "0x1D1")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001C58")]
	[Address(RVA = "0x77E3F0", Offset = "0x77D1F0", Length = "0x3AA")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6001C59")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FastCloth()
	{
	}
}

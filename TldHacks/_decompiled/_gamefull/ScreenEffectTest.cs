using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003F6")]
public class ScreenEffectTest : MonoBehaviour
{
	[Token(Token = "0x4002386")]
	[FieldOffset(Offset = "0x20")]
	private Mesh m_Mesh;

	[Token(Token = "0x4002387")]
	[FieldOffset(Offset = "0x28")]
	public Material m_Material;

	[Token(Token = "0x4002388")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 m_AnimRate;

	[Token(Token = "0x4002389")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 m_MaxDisplacement;

	[Token(Token = "0x400238A")]
	[FieldOffset(Offset = "0x40")]
	private Material m_CustomMaterial;

	[Token(Token = "0x6001E62")]
	[Address(RVA = "0x7BC5A0", Offset = "0x7BB3A0", Length = "0xD3E")]
	private void Start()
	{
	}

	[Token(Token = "0x6001E63")]
	[Address(RVA = "0x7BD2E0", Offset = "0x7BC0E0", Length = "0x177")]
	private void Update()
	{
	}

	[Token(Token = "0x6001E64")]
	[Address(RVA = "0x7BD460", Offset = "0x7BC260", Length = "0x38E")]
	private void OnRenderObject()
	{
	}

	[Token(Token = "0x6001E65")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ScreenEffectTest()
	{
	}
}

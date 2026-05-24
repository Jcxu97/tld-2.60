using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20002EB")]
public class ActivatedTerrainMaterial : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40019A0")]
	[FieldOffset(Offset = "0x20")]
	private ActivatedMaterialProperties m_MaterialProperties;

	[SerializeField]
	[Token(Token = "0x40019A1")]
	[FieldOffset(Offset = "0x28")]
	private Terrain m_Terrain;

	[Token(Token = "0x40019A2")]
	[FieldOffset(Offset = "0x30")]
	private Material m_OriginalMaterial;

	[Token(Token = "0x40019A3")]
	[FieldOffset(Offset = "0x38")]
	private Material m_Material;

	[Token(Token = "0x600184E")]
	[Address(RVA = "0x6E5150", Offset = "0x6E3F50", Length = "0x218")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600184F")]
	[Address(RVA = "0x6E5370", Offset = "0x6E4170", Length = "0x2C3")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001850")]
	[Address(RVA = "0x6E5640", Offset = "0x6E4440", Length = "0xFD")]
	public void ActivateMaterialProperties(bool isActive)
	{
	}

	[Token(Token = "0x6001851")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ActivatedTerrainMaterial()
	{
	}
}

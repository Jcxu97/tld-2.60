using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[Token(Token = "0x200038D")]
public class FireMesh : MonoBehaviour
{
	[Token(Token = "0x4001FBA")]
	[FieldOffset(Offset = "0x20")]
	public Mesh m_MeshToBurn;

	[Header("Particles")]
	[Tooltip("Smoothly transition from nothing to embers to a full-on inferno")]
	[Range(0f, 100f)]
	[Token(Token = "0x4001FBB")]
	[FieldOffset(Offset = "0x28")]
	public float m_Intensity;

	[Tooltip("Increase for larger meshes, decrease for smaller")]
	[Range(0f, 300f)]
	[Token(Token = "0x4001FBC")]
	[FieldOffset(Offset = "0x2C")]
	public float m_Coverage;

	[Tooltip("Shifts particles to slightly inside or outside the mesh")]
	[Range(-1f, 1f)]
	[Token(Token = "0x4001FBD")]
	[FieldOffset(Offset = "0x30")]
	public float m_SpriteExpansion;

	[Header("FX objects")]
	[Token(Token = "0x4001FBE")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_CoverageParticles;

	[Token(Token = "0x4001FBF")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_SmokeParticles;

	[Token(Token = "0x4001FC0")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_SparkParticles;

	[Token(Token = "0x4001FC1")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_SpriteParticles;

	[Token(Token = "0x4001FC2")]
	[FieldOffset(Offset = "0x58")]
	private ParticleSystem m_SpriteParticlesPS;

	[Token(Token = "0x6001C64")]
	[Address(RVA = "0x77FEA0", Offset = "0x77ECA0", Length = "0x1F")]
	private void Start()
	{
	}

	[Token(Token = "0x6001C65")]
	[Address(RVA = "0x77FEC0", Offset = "0x77ECC0", Length = "0x184")]
	private void StartFire()
	{
	}

	[Token(Token = "0x6001C66")]
	[Address(RVA = "0x780050", Offset = "0x77EE50", Length = "0x17D")]
	private void SetEmissionRate(GameObject ps, float newRate)
	{
	}

	[Token(Token = "0x6001C67")]
	[Address(RVA = "0x7801D0", Offset = "0x77EFD0", Length = "0x16E")]
	private void SetMesh(ParticleSystem ps, Mesh newMesh)
	{
	}

	[Token(Token = "0x6001C68")]
	[Address(RVA = "0x780340", Offset = "0x77F140", Length = "0x107")]
	private void SetSize(GameObject ps, float newSize)
	{
	}

	[Token(Token = "0x6001C69")]
	[Address(RVA = "0x780450", Offset = "0x77F250", Length = "0x326")]
	private void UpdateRatesAndSizes()
	{
	}

	[Token(Token = "0x6001C6A")]
	[Address(RVA = "0x780780", Offset = "0x77F580", Length = "0x6B")]
	private void Update()
	{
	}

	[Token(Token = "0x6001C6B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FireMesh()
	{
	}
}

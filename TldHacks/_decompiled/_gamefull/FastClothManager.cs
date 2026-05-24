using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200038C")]
public class FastClothManager : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4001FAE")]
	[FieldOffset(Offset = "0x20")]
	private float m_MaxWindSpeed;

	[SerializeField]
	[Token(Token = "0x4001FAF")]
	[FieldOffset(Offset = "0x24")]
	private float m_WindSpeedChangeDamping;

	[Token(Token = "0x4001FB0")]
	[FieldOffset(Offset = "0x28")]
	private Vector4 m_WindInfo;

	[Token(Token = "0x4001FB1")]
	[FieldOffset(Offset = "0x38")]
	private List<MeshRenderer> m_Renderers;

	[Token(Token = "0x4001FB2")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<MeshRenderer, MeshFilter> m_RenderersToMeshFilters;

	[Token(Token = "0x4001FB3")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<Mesh, MaterialPropertyBlock> m_MeshPropertyBlocks;

	[Token(Token = "0x4001FB4")]
	[FieldOffset(Offset = "0x50")]
	private MaterialPropertyBlock m_PlacementPropertyBlock;

	[Token(Token = "0x4001FB5")]
	[FieldOffset(Offset = "0x58")]
	private readonly int m_ClothWindInfoID;

	[Token(Token = "0x4001FB6")]
	[FieldOffset(Offset = "0x5C")]
	private readonly int m_ClothBlendShapeMidVertexID;

	[Token(Token = "0x4001FB7")]
	[FieldOffset(Offset = "0x60")]
	private readonly int m_ClothBlendShapeMidNormalID;

	[Token(Token = "0x4001FB8")]
	[FieldOffset(Offset = "0x64")]
	private readonly int m_ClothBlendShapeEndVertexID;

	[Token(Token = "0x4001FB9")]
	[FieldOffset(Offset = "0x68")]
	private readonly int m_ClothBlendShapeEndNormalID;

	[Token(Token = "0x6001C5E")]
	[Address(RVA = "0x77EA60", Offset = "0x77D860", Length = "0x274")]
	public bool TryCacheClothMeshData(FastClothData clothData)
	{
		return false;
	}

	[Token(Token = "0x6001C5F")]
	[Address(RVA = "0x77ECE0", Offset = "0x77DAE0", Length = "0x1FE")]
	public void RegisterRenderer(MeshRenderer renderer, MeshFilter meshFilter)
	{
	}

	[Token(Token = "0x6001C60")]
	[Address(RVA = "0x77EEE0", Offset = "0x77DCE0", Length = "0x189")]
	public void UnRegisterRenderer(MeshRenderer renderer)
	{
	}

	[Token(Token = "0x6001C61")]
	[Address(RVA = "0x77F070", Offset = "0x77DE70", Length = "0x945")]
	private void Update()
	{
	}

	[Token(Token = "0x6001C62")]
	[Address(RVA = "0x77F9C0", Offset = "0x77E7C0", Length = "0x1EB")]
	private void CopyPropertyBlockValues(MaterialPropertyBlock fromBlock, MaterialPropertyBlock toBlock)
	{
	}

	[Token(Token = "0x6001C63")]
	[Address(RVA = "0x77FBB0", Offset = "0x77E9B0", Length = "0x2E6")]
	public FastClothManager()
	{
	}
}

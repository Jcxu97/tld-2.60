using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000956")]
public class SnowImprintCustom : MonoBehaviour
{
	[Token(Token = "0x4006099")]
	[FieldOffset(Offset = "0x20")]
	public bool m_RefreshMaterialOnUpdate;

	[Token(Token = "0x400609A")]
	[FieldOffset(Offset = "0x28")]
	public string m_SurfaceTag;

	[Token(Token = "0x400609B")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 m_Dimensions;

	[Token(Token = "0x400609C")]
	[FieldOffset(Offset = "0x38")]
	public MinMax m_BoundsHeight;

	[Token(Token = "0x400609D")]
	[FieldOffset(Offset = "0x40")]
	public float m_InsetDepth;

	[Token(Token = "0x400609E")]
	[FieldOffset(Offset = "0x44")]
	public float m_InsetPower;

	[Token(Token = "0x400609F")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 m_NormalStep;

	[Token(Token = "0x40060A0")]
	[FieldOffset(Offset = "0x54")]
	public float m_DrawDistance;

	[Token(Token = "0x40060A1")]
	[FieldOffset(Offset = "0x58")]
	public float m_ShadeByZ;

	[Token(Token = "0x40060A2")]
	[FieldOffset(Offset = "0x5C")]
	public float m_ShadeByZBand;

	[Token(Token = "0x40060A3")]
	[FieldOffset(Offset = "0x60")]
	public float m_ShadeByZPower;

	[Token(Token = "0x40060A4")]
	[FieldOffset(Offset = "0x64")]
	public bool m_CastShadows;

	[Token(Token = "0x40060A5")]
	[FieldOffset(Offset = "0x65")]
	public bool m_ReceiveShadows;

	[Token(Token = "0x40060A6")]
	[FieldOffset(Offset = "0x68")]
	public Mesh m_FinalPassMesh;

	[Token(Token = "0x40060A7")]
	[FieldOffset(Offset = "0x70")]
	public Mesh m_DepthResetMesh;

	[Token(Token = "0x40060A8")]
	[FieldOffset(Offset = "0x78")]
	public Material m_DepthResetMaterial;

	[Token(Token = "0x40060A9")]
	[FieldOffset(Offset = "0x80")]
	public Vector2 m_DepthResetTiltMinMax;

	[Token(Token = "0x40060AA")]
	[FieldOffset(Offset = "0x88")]
	public Vector3 m_DepthResetOffsetMin;

	[Token(Token = "0x40060AB")]
	[FieldOffset(Offset = "0x94")]
	public Vector3 m_DepthResetOffsetMax;

	[Token(Token = "0x40060AC")]
	[FieldOffset(Offset = "0xA0")]
	public Material m_ImprintMaterial;

	[Token(Token = "0x40060AD")]
	[FieldOffset(Offset = "0xA8")]
	public Shader m_ImprintExteriorShader;

	[Token(Token = "0x40060AE")]
	[FieldOffset(Offset = "0xB0")]
	public Shader m_ImprintInteriorShader;

	[Token(Token = "0x40060AF")]
	[FieldOffset(Offset = "0xB8")]
	public Vector3 m_ImprintSize;

	[Token(Token = "0x40060B1")]
	[FieldOffset(Offset = "0xD0")]
	private Vector3 m_MinPos;

	[Token(Token = "0x40060B2")]
	[FieldOffset(Offset = "0xDC")]
	private Vector3 m_MaxPos;

	[Token(Token = "0x40060B3")]
	[FieldOffset(Offset = "0xE8")]
	private Vector3[] m_HermiteCoefficients;

	[Token(Token = "0x40060B4")]
	[FieldOffset(Offset = "0xF0")]
	private int[] m_CoeffIds;

	[Token(Token = "0x40060B5")]
	[FieldOffset(Offset = "0xF8")]
	private int m_NormalStepId;

	[Token(Token = "0x40060B6")]
	[FieldOffset(Offset = "0xFC")]
	private int m_ShadeByZId;

	[Token(Token = "0x40060B7")]
	[FieldOffset(Offset = "0x100")]
	private int m_MaxInsetId;

	[Token(Token = "0x40060B8")]
	[FieldOffset(Offset = "0x104")]
	private int m_InsetPowId;

	[Token(Token = "0x40060B9")]
	[FieldOffset(Offset = "0x108")]
	private int m_FadeDistanceId;

	[Token(Token = "0x40060BA")]
	[FieldOffset(Offset = "0x10C")]
	private int m_VisibleDistanceId;

	[Token(Token = "0x40060BB")]
	[FieldOffset(Offset = "0x110")]
	private Bounds m_LocalBounds;

	[Token(Token = "0x40060BC")]
	[FieldOffset(Offset = "0x128")]
	private Transform m_CachedTransform;

	[Token(Token = "0x40060BD")]
	[FieldOffset(Offset = "0x130")]
	private MaterialPropertyBlock m_MaterialPropertyBlock1;

	[Token(Token = "0x14000017")]
	public event Action<MaterialPropertyBlock> m_OnPropertyBlockUpdated
	{
		[CompilerGenerated]
		[Token(Token = "0x6005471")]
		[Address(RVA = "0xE7F960", Offset = "0xE7E760", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6005472")]
		[Address(RVA = "0xE7FAD0", Offset = "0xE7E8D0", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x6005473")]
	[Address(RVA = "0xE7FC40", Offset = "0xE7EA40", Length = "0x386")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005474")]
	[Address(RVA = "0xE7FFD0", Offset = "0xE7EDD0", Length = "0x7")]
	private void Start()
	{
	}

	[Token(Token = "0x6005475")]
	[Address(RVA = "0xE7FFE0", Offset = "0xE7EDE0", Length = "0x886")]
	public void Reposition()
	{
	}

	[Token(Token = "0x6005476")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Update()
	{
	}

	[Token(Token = "0x6005477")]
	[Address(RVA = "0xE80870", Offset = "0xE7F670", Length = "0xB8F")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6005478")]
	[Address(RVA = "0xE81400", Offset = "0xE80200", Length = "0xC8A")]
	private void BuildMaterialPropertyBlocks()
	{
	}

	[Token(Token = "0x6005479")]
	[Address(RVA = "0xE82090", Offset = "0xE80E90", Length = "0x38")]
	public void SetInterior(bool interior)
	{
	}

	[Token(Token = "0x600547A")]
	[Address(RVA = "0xE820D0", Offset = "0xE80ED0", Length = "0x185")]
	public SnowImprintCustom()
	{
	}
}

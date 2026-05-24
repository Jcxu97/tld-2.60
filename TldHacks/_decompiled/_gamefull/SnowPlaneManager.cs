using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x20009DC")]
public class SnowPlaneManager : MonoBehaviour
{
	[Token(Token = "0x40063FD")]
	[FieldOffset(Offset = "0x20")]
	public float m_UV_XY_Scalar;

	[Token(Token = "0x40063FE")]
	[FieldOffset(Offset = "0x24")]
	public float m_UV_Z_Scalar;

	[Token(Token = "0x40063FF")]
	[FieldOffset(Offset = "0x28")]
	public float m_YawAngleToBaseUVScalar;

	[Token(Token = "0x4006400")]
	[FieldOffset(Offset = "0x2C")]
	public float m_PitchAngleToBaseUVScalar;

	[Token(Token = "0x4006401")]
	[FieldOffset(Offset = "0x30")]
	public float m_AngleToUVRangeScalar;

	[Token(Token = "0x4006402")]
	[FieldOffset(Offset = "0x34")]
	public float m_MaxTiltOffset;

	[Token(Token = "0x4006403")]
	[FieldOffset(Offset = "0x38")]
	public float[] m_LayerDepths;

	[Token(Token = "0x4006404")]
	[FieldOffset(Offset = "0x40")]
	public RenderTexture m_RenderTexture;

	[Token(Token = "0x4006405")]
	[FieldOffset(Offset = "0x48")]
	public SnowPlaneParticles m_Particles;

	[Token(Token = "0x4006406")]
	[FieldOffset(Offset = "0x50")]
	public MeshFilter m_MeshFilter;

	[Token(Token = "0x4006407")]
	[FieldOffset(Offset = "0x58")]
	public MeshRenderer m_MeshRenderer;

	[Token(Token = "0x4006408")]
	[FieldOffset(Offset = "0x60")]
	private Vector3[] m_Verts;

	[Token(Token = "0x4006409")]
	[FieldOffset(Offset = "0x68")]
	private Vector2[] m_Uvs;

	[Token(Token = "0x400640A")]
	[FieldOffset(Offset = "0x70")]
	private Color[] m_Colors;

	[Token(Token = "0x400640B")]
	[FieldOffset(Offset = "0x78")]
	private int[] m_Tris;

	[Token(Token = "0x400640C")]
	[FieldOffset(Offset = "0x80")]
	private int m_LayerCountSub;

	[Token(Token = "0x400640D")]
	[FieldOffset(Offset = "0x88")]
	private CommandBuffer m_CommandBuffer;

	[Token(Token = "0x400640E")]
	[FieldOffset(Offset = "0x90")]
	private ParticleSystemRenderer m_ParticleRenderer;

	[Token(Token = "0x400640F")]
	[FieldOffset(Offset = "0x98")]
	private Camera m_CurrentCamera;

	[Token(Token = "0x4006410")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_IsActive;

	[HideInInspector]
	[Token(Token = "0x4006411")]
	[FieldOffset(Offset = "0xA4")]
	public Color m_SnowColor;

	[Token(Token = "0x4006412")]
	private static Vector2[] m_CornerOffsets;

	[Token(Token = "0x17000381")]
	public bool IsEnabled
	{
		[Token(Token = "0x60056E3")]
		[Address(RVA = "0x657ED0", Offset = "0x656CD0", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60056E4")]
	[Address(RVA = "0xEC2A00", Offset = "0xEC1800", Length = "0x212")]
	private void Start()
	{
	}

	[Token(Token = "0x60056E5")]
	[Address(RVA = "0xEC2C20", Offset = "0xEC1A20", Length = "0x1B7")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60056E6")]
	[Address(RVA = "0xEC2DE0", Offset = "0xEC1BE0", Length = "0x5A")]
	public void Reset()
	{
	}

	[Token(Token = "0x60056E7")]
	[Address(RVA = "0xEC2E40", Offset = "0xEC1C40", Length = "0xB")]
	public void SetSnowColor(Color col)
	{
	}

	[Token(Token = "0x60056E8")]
	[Address(RVA = "0xEC2E50", Offset = "0xEC1C50", Length = "0x93F")]
	private void InitializeMesh()
	{
	}

	[Token(Token = "0x60056E9")]
	[Address(RVA = "0xEC3790", Offset = "0xEC2590", Length = "0x931")]
	private void UpdateMesh()
	{
	}

	[Token(Token = "0x60056EA")]
	[Address(RVA = "0xEC40D0", Offset = "0xEC2ED0", Length = "0x73C")]
	private void Update()
	{
	}

	[Token(Token = "0x60056EB")]
	[Address(RVA = "0xEC4830", Offset = "0xEC3630", Length = "0x4A")]
	private void SetComponentsActive(bool state)
	{
	}

	[Token(Token = "0x60056EC")]
	[Address(RVA = "0xEC4880", Offset = "0xEC3680", Length = "0x3A8")]
	private void OnRenderObject()
	{
	}

	[Token(Token = "0x60056ED")]
	[Address(RVA = "0xEC4C30", Offset = "0xEC3A30", Length = "0x146")]
	private void RemoveCommandBuffer()
	{
	}

	[Token(Token = "0x60056EE")]
	[Address(RVA = "0xEC4D80", Offset = "0xEC3B80", Length = "0x25B")]
	private void MaybeRefreshCameraForCommandBuffer()
	{
	}

	[Token(Token = "0x60056EF")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SnowPlaneManager()
	{
	}
}

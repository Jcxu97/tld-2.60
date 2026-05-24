using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200016B")]
public class Carrion : MonoBehaviour
{
	[Token(Token = "0x4000D35")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Prefab;

	[Token(Token = "0x4000D36")]
	[FieldOffset(Offset = "0x28")]
	public int m_MinFlockSize;

	[Token(Token = "0x4000D37")]
	[FieldOffset(Offset = "0x2C")]
	public int m_MaxFlockSize;

	[Token(Token = "0x4000D38")]
	[FieldOffset(Offset = "0x30")]
	public float m_LodDistance;

	[Token(Token = "0x4000D39")]
	[FieldOffset(Offset = "0x34")]
	public float m_FlyDistanceAboveTarget;

	[Token(Token = "0x4000D3A")]
	[FieldOffset(Offset = "0x38")]
	public string m_LoopAudio;

	[Token(Token = "0x4000D3B")]
	public static List<Carrion> m_CarrionObjects;

	[Token(Token = "0x4000D3C")]
	public static bool s_StaggeredUpdateEnabled;

	[Token(Token = "0x4000D3D")]
	[FieldOffset(Offset = "0x40")]
	private float m_FormationValidHeight;

	[Token(Token = "0x4000D3E")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_Instance;

	[Token(Token = "0x4000D3F")]
	private const float m_DisperseVerticalSpeed = 2f;

	[Token(Token = "0x4000D40")]
	[FieldOffset(Offset = "0x50")]
	private uint m_LoopAudioID;

	[Token(Token = "0x4000D41")]
	[FieldOffset(Offset = "0x54")]
	private bool m_ForceDisperse;

	[Token(Token = "0x4000D42")]
	[FieldOffset(Offset = "0x55")]
	private bool m_ShouldDisperse;

	[Token(Token = "0x4000D43")]
	[FieldOffset(Offset = "0x58")]
	private List<Carrion> m_NearbyCarrions;

	[Token(Token = "0x4000D44")]
	private static int s_CurrentIndex;

	[Token(Token = "0x4000D45")]
	private static int s_NumProcessPerFrame;

	[Token(Token = "0x4000D46")]
	[FieldOffset(Offset = "0x60")]
	private bool m_SkipPositionUpdateRequested;

	[Token(Token = "0x4000D47")]
	private const float CARRION_NO_OVERLAP_RADIUS = 30f;

	[Token(Token = "0x6000E10")]
	[Address(RVA = "0x5E5F60", Offset = "0x5E4D60", Length = "0xC4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000E11")]
	[Address(RVA = "0x5E6030", Offset = "0x5E4E30", Length = "0x82")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000E12")]
	[Address(RVA = "0x5E60C0", Offset = "0x5E4EC0", Length = "0x3AB")]
	public bool ShouldDisperseGlobal(float radius)
	{
		return false;
	}

	[Token(Token = "0x6000E13")]
	[Address(RVA = "0x5E6470", Offset = "0x5E5270", Length = "0x283")]
	private static void UpdateAllCarrionPositions()
	{
	}

	[Token(Token = "0x6000E14")]
	[Address(RVA = "0x5E6700", Offset = "0x5E5500", Length = "0x203")]
	public static void UpdateCarrions()
	{
	}

	[Token(Token = "0x6000E15")]
	[Address(RVA = "0x5E6910", Offset = "0x5E5710", Length = "0x10B")]
	private static void StaggeredUpdate()
	{
	}

	[Token(Token = "0x6000E16")]
	[Address(RVA = "0x5E6A20", Offset = "0x5E5820", Length = "0x81")]
	private static void UpdateAll()
	{
	}

	[Token(Token = "0x6000E17")]
	[Address(RVA = "0x5E6AB0", Offset = "0x5E58B0", Length = "0x1A5")]
	private static void StaggeredUpdateCarrions(int start, int endExclusive)
	{
	}

	[Token(Token = "0x6000E18")]
	[Address(RVA = "0x5E6C60", Offset = "0x5E5A60", Length = "0x3EC")]
	public void StaggeredUpdateCarrion()
	{
	}

	[Token(Token = "0x6000E19")]
	[Address(RVA = "0x5E7050", Offset = "0x5E5E50", Length = "0x958")]
	public void Create()
	{
	}

	[Token(Token = "0x6000E1A")]
	[Address(RVA = "0x5E79B0", Offset = "0x5E67B0", Length = "0x111")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6000E1B")]
	[Address(RVA = "0x5E7AD0", Offset = "0x5E68D0", Length = "0x4")]
	public void ForceDisperse(bool enable)
	{
	}

	[Token(Token = "0x6000E1C")]
	[Address(RVA = "0x5E7AE0", Offset = "0x5E68E0", Length = "0xCA")]
	public bool HasDispersed()
	{
		return false;
	}

	[Token(Token = "0x6000E1D")]
	[Address(RVA = "0x5E7BB0", Offset = "0x5E69B0", Length = "0xBA")]
	private bool IsTooDark()
	{
		return false;
	}

	[Token(Token = "0x6000E1E")]
	[Address(RVA = "0x5E7C70", Offset = "0x5E6A70", Length = "0xC0")]
	private bool ShouldDisperseLocal()
	{
		return false;
	}

	[Token(Token = "0x6000E1F")]
	[Address(RVA = "0x5E7D40", Offset = "0x5E6B40", Length = "0x9B9")]
	private void UpdatePosition()
	{
	}

	[Token(Token = "0x6000E20")]
	[Address(RVA = "0x5E8700", Offset = "0x5E7500", Length = "0xE3")]
	public Carrion()
	{
	}
}

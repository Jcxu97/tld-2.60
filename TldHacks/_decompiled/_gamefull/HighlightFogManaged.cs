using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003AF")]
public class HighlightFogManaged : MonoBehaviour
{
	[Token(Token = "0x40020EC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_FogQuad;

	[Token(Token = "0x40020ED")]
	[FieldOffset(Offset = "0x28")]
	public float m_NearVanish;

	[Token(Token = "0x40020EE")]
	[FieldOffset(Offset = "0x2C")]
	public float m_FadeDistance;

	[Token(Token = "0x40020EF")]
	[FieldOffset(Offset = "0x30")]
	public Color m_BaseColor;

	[Range(0f, 3f)]
	[Token(Token = "0x40020F0")]
	[FieldOffset(Offset = "0x40")]
	public float m_SoftEdgeFactor;

	[Token(Token = "0x40020F1")]
	[FieldOffset(Offset = "0x44")]
	public bool m_FadeAtNight;

	[Token(Token = "0x40020F2")]
	[FieldOffset(Offset = "0x45")]
	public bool m_FadeAtRightAngles;

	[Token(Token = "0x40020F3")]
	[FieldOffset(Offset = "0x46")]
	public bool m_LookAtPlayer;

	[Token(Token = "0x40020F4")]
	[FieldOffset(Offset = "0x48")]
	public Light m_LightDriver;

	[Token(Token = "0x40020F5")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 m_PlanePoint;

	[Token(Token = "0x40020F6")]
	[FieldOffset(Offset = "0x5C")]
	private float m_CurrentDistanceSqr;

	[Token(Token = "0x40020F7")]
	[FieldOffset(Offset = "0x60")]
	private Renderer m_Rend;

	[Token(Token = "0x40020F8")]
	[FieldOffset(Offset = "0x68")]
	private Color m_CurrentColor;

	[Token(Token = "0x40020F9")]
	[FieldOffset(Offset = "0x78")]
	private Plane m_Plane;

	[Token(Token = "0x40020FA")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 m_PlaneCalculator;

	[Token(Token = "0x40020FB")]
	[FieldOffset(Offset = "0x94")]
	private float m_TODMultiplier;

	[Token(Token = "0x40020FC")]
	[FieldOffset(Offset = "0x98")]
	private float m_LightDriverMax;

	[Token(Token = "0x40020FD")]
	[FieldOffset(Offset = "0x9C")]
	private float m_LightDriverMultiplier;

	[Token(Token = "0x40020FE")]
	[FieldOffset(Offset = "0xA0")]
	private float m_Angle;

	[Token(Token = "0x40020FF")]
	[FieldOffset(Offset = "0xA4")]
	private Vector3 m_Heading;

	[Token(Token = "0x4002100")]
	[FieldOffset(Offset = "0xB0")]
	private float m_AngleCos;

	[Token(Token = "0x4002101")]
	[FieldOffset(Offset = "0xB4")]
	private float m_DistanceMultiplier;

	[Token(Token = "0x4002102")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_Initialized;

	[Token(Token = "0x6001D18")]
	[Address(RVA = "0x794B00", Offset = "0x793900", Length = "0x148")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D19")]
	[Address(RVA = "0x794C50", Offset = "0x793A50", Length = "0x3FA")]
	private void UpdateAngles()
	{
	}

	[Token(Token = "0x6001D1A")]
	[Address(RVA = "0x795050", Offset = "0x793E50", Length = "0x149")]
	private void UpdateDrive()
	{
	}

	[Token(Token = "0x6001D1B")]
	[Address(RVA = "0x7951A0", Offset = "0x793FA0", Length = "0x2C1")]
	private void UpdateMaterial()
	{
	}

	[Token(Token = "0x6001D1C")]
	[Address(RVA = "0x795470", Offset = "0x794270", Length = "0x178")]
	public void ManualUpdate(float todMult, Vector3 heading)
	{
	}

	[Token(Token = "0x6001D1D")]
	[Address(RVA = "0x7955F0", Offset = "0x7943F0", Length = "0x3FA")]
	private void ManualUpdateAngles()
	{
	}

	[Token(Token = "0x6001D1E")]
	[Address(RVA = "0x7959F0", Offset = "0x7947F0", Length = "0x82")]
	public HighlightFogManaged()
	{
	}
}

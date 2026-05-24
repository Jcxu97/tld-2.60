using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003F3")]
public class Rainbow : MonoBehaviour
{
	[Token(Token = "0x4002367")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_RainbowQuad;

	[Token(Token = "0x4002368")]
	[FieldOffset(Offset = "0x28")]
	public float m_NearVanish;

	[Token(Token = "0x4002369")]
	[FieldOffset(Offset = "0x2C")]
	public float m_FadeDistance;

	[Token(Token = "0x400236A")]
	[FieldOffset(Offset = "0x30")]
	public Color m_BaseColor;

	[Range(0f, 3f)]
	[Token(Token = "0x400236B")]
	[FieldOffset(Offset = "0x40")]
	public float m_SoftEdgeFactor;

	[Token(Token = "0x400236C")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 m_PlanePoint;

	[Token(Token = "0x400236D")]
	[FieldOffset(Offset = "0x50")]
	private float m_CurrentDistance;

	[Token(Token = "0x400236E")]
	[FieldOffset(Offset = "0x58")]
	private Renderer m_Rend;

	[Token(Token = "0x400236F")]
	[FieldOffset(Offset = "0x60")]
	private Color m_CurrentColor;

	[Token(Token = "0x4002370")]
	[FieldOffset(Offset = "0x70")]
	private Plane m_Plane;

	[Token(Token = "0x4002371")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 m_PlaneCalculator;

	[Token(Token = "0x4002372")]
	[FieldOffset(Offset = "0x90")]
	private UniStormWeatherSystem m_UniStorm;

	[Token(Token = "0x4002373")]
	[FieldOffset(Offset = "0x98")]
	private float m_TargetOpacity;

	[Token(Token = "0x4002374")]
	[FieldOffset(Offset = "0x9C")]
	private float m_CurrentOpacity;

	[Token(Token = "0x6001E52")]
	[Address(RVA = "0x7BA0E0", Offset = "0x7B8EE0", Length = "0x1DE")]
	private void Start()
	{
	}

	[Token(Token = "0x6001E53")]
	[Address(RVA = "0x7BA2C0", Offset = "0x7B90C0", Length = "0xE76")]
	private void Update()
	{
	}

	[Token(Token = "0x6001E54")]
	[Address(RVA = "0x7BB140", Offset = "0x7B9F40", Length = "0x1A4")]
	private Vector3 ProjectPointOnPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 point)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001E55")]
	[Address(RVA = "0x7BB2F0", Offset = "0x7BA0F0", Length = "0x68")]
	public Rainbow()
	{
	}
}

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003BE")]
public class LightDancing : MonoBehaviour
{
	[Token(Token = "0x20003BF")]
	public enum movementShape
	{
		[Token(Token = "0x40021C5")]
		SPHERE,
		[Token(Token = "0x40021C6")]
		CUBE,
		[Token(Token = "0x40021C7")]
		CONE
	}

	[Tooltip("Radius of the sphere")]
	[Token(Token = "0x40021B4")]
	[FieldOffset(Offset = "0x20")]
	public float sphereRadius;

	[Tooltip("Cube X size")]
	[Token(Token = "0x40021B5")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 cube_xMinMax;

	[Tooltip("Cube Y size")]
	[Token(Token = "0x40021B6")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 cube_yMinMax;

	[Tooltip("Cube Z size")]
	[Token(Token = "0x40021B7")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 cube_zMinMax;

	[Tooltip("Cone height")]
	[Token(Token = "0x40021B8")]
	[FieldOffset(Offset = "0x3C")]
	public float coneHeight;

	[Tooltip("Cone base radius")]
	[Token(Token = "0x40021B9")]
	[FieldOffset(Offset = "0x40")]
	public float coneRadius;

	[Token(Token = "0x40021BA")]
	[FieldOffset(Offset = "0x44")]
	public float shiftRate;

	[Token(Token = "0x40021BB")]
	[FieldOffset(Offset = "0x48")]
	public float shadowRate;

	[Token(Token = "0x40021BC")]
	[FieldOffset(Offset = "0x4C")]
	public bool fadeShadows;

	[Tooltip("Sphere: random position within radius, maximum value.\nCube: random min max values.\nCone: Circle on the bottom, lerps up to a point.")]
	[Token(Token = "0x40021BD")]
	[FieldOffset(Offset = "0x50")]
	public movementShape moveShape;

	[Token(Token = "0x40021BE")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 originalPosition;

	[Token(Token = "0x40021BF")]
	[FieldOffset(Offset = "0x60")]
	private float shiftTimer;

	[Token(Token = "0x40021C0")]
	[FieldOffset(Offset = "0x64")]
	private float shadowTimer;

	[Token(Token = "0x40021C1")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 srcPos;

	[Token(Token = "0x40021C2")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 dstPos;

	[Token(Token = "0x40021C3")]
	[FieldOffset(Offset = "0x80")]
	private Light m_MyLight;

	[Token(Token = "0x6001D6F")]
	[Address(RVA = "0x7A15B0", Offset = "0x7A03B0", Length = "0x158")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001D70")]
	[Address(RVA = "0x7A1710", Offset = "0x7A0510", Length = "0x751")]
	private void Update()
	{
	}

	[Token(Token = "0x6001D71")]
	[Address(RVA = "0x7A1E70", Offset = "0x7A0C70", Length = "0x1848")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6001D72")]
	[Address(RVA = "0x7A36C0", Offset = "0x7A24C0", Length = "0x77")]
	public LightDancing()
	{
	}
}

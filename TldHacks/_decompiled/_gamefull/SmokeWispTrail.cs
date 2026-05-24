using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(TrailRenderer))]
[Token(Token = "0x20003FB")]
public class SmokeWispTrail : MonoBehaviour
{
	[Header("Gravity")]
	[SerializeField]
	[Token(Token = "0x40023C6")]
	[FieldOffset(Offset = "0x20")]
	private float m_Gravity;

	[Header("UV animation")]
	[SerializeField]
	[Token(Token = "0x40023C7")]
	[FieldOffset(Offset = "0x24")]
	private float m_UVOffsetSpeed;

	[SerializeField]
	[Token(Token = "0x40023C8")]
	[FieldOffset(Offset = "0x28")]
	private float m_UVOffsetSeed;

	[SerializeField]
	[Token(Token = "0x40023C9")]
	[FieldOffset(Offset = "0x2C")]
	private float m_Alpha1SpeedMultiplier;

	[SerializeField]
	[Token(Token = "0x40023CA")]
	[FieldOffset(Offset = "0x30")]
	private float m_Alpha2SpeedMultiplier;

	[SerializeField]
	[Token(Token = "0x40023CB")]
	[FieldOffset(Offset = "0x34")]
	private float m_DistortionSpeedMultiplier;

	[Token(Token = "0x40023CC")]
	[FieldOffset(Offset = "0x38")]
	private TrailRenderer m_TrailRenderer;

	[Token(Token = "0x40023CD")]
	[FieldOffset(Offset = "0x40")]
	private int m_VertCount;

	[Token(Token = "0x40023CE")]
	[FieldOffset(Offset = "0x48")]
	private Vector3[] m_VertPositions;

	[Token(Token = "0x40023CF")]
	[FieldOffset(Offset = "0x50")]
	private Material m_Material;

	[Token(Token = "0x40023D0")]
	[FieldOffset(Offset = "0x58")]
	private int m_UVOffsetID;

	[Token(Token = "0x40023D1")]
	[FieldOffset(Offset = "0x5C")]
	private Vector4 m_UVOffsets;

	[Token(Token = "0x6001E7E")]
	[Address(RVA = "0x7BFE30", Offset = "0x7BEC30", Length = "0x1C7")]
	public void Start()
	{
	}

	[Token(Token = "0x6001E7F")]
	[Address(RVA = "0x7C0000", Offset = "0x7BEE00", Length = "0x4FD")]
	public void Update()
	{
	}

	[Token(Token = "0x6001E80")]
	[Address(RVA = "0x7C0500", Offset = "0x7BF300", Length = "0x66")]
	public SmokeWispTrail()
	{
	}
}

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200019F")]
public class JiggleBone : MonoBehaviour
{
	[Token(Token = "0x4000ECF")]
	[FieldOffset(Offset = "0x20")]
	public bool debugMode;

	[Token(Token = "0x4000ED0")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 dynamicPos;

	[Token(Token = "0x4000ED1")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 boneAxis;

	[Token(Token = "0x4000ED2")]
	[FieldOffset(Offset = "0x3C")]
	public float targetDistance;

	[Token(Token = "0x4000ED3")]
	[FieldOffset(Offset = "0x40")]
	public float bStiffness;

	[Token(Token = "0x4000ED4")]
	[FieldOffset(Offset = "0x44")]
	public float bMass;

	[Token(Token = "0x4000ED5")]
	[FieldOffset(Offset = "0x48")]
	public float bDamping;

	[Token(Token = "0x4000ED6")]
	[FieldOffset(Offset = "0x4C")]
	public float bGravity;

	[Token(Token = "0x4000ED7")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 force;

	[Token(Token = "0x4000ED8")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 acc;

	[Token(Token = "0x4000ED9")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 vel;

	[Token(Token = "0x4000EDA")]
	[FieldOffset(Offset = "0x74")]
	public bool SquashAndStretch;

	[Token(Token = "0x4000EDB")]
	[FieldOffset(Offset = "0x78")]
	public float sideStretch;

	[Token(Token = "0x4000EDC")]
	[FieldOffset(Offset = "0x7C")]
	public float frontStretch;

	[Token(Token = "0x6000F68")]
	[Address(RVA = "0x612470", Offset = "0x611270", Length = "0x1ED")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000F69")]
	[Address(RVA = "0x612660", Offset = "0x611460", Length = "0xCFC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000F6A")]
	[Address(RVA = "0x613360", Offset = "0x612160", Length = "0xA5")]
	public JiggleBone()
	{
	}
}

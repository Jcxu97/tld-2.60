using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000354")]
public class AnimatedUVs : MonoBehaviour
{
	[Token(Token = "0x4001D61")]
	[FieldOffset(Offset = "0x20")]
	public int materialIndex;

	[Token(Token = "0x4001D62")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 uvAnimationRate;

	[Token(Token = "0x4001D63")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 m_uvRandomOffsetAmount;

	[Token(Token = "0x4001D64")]
	[FieldOffset(Offset = "0x34")]
	public float m_RandomSpeedAmount;

	[Token(Token = "0x4001D65")]
	[FieldOffset(Offset = "0x38")]
	public string textureName;

	[Header("Tracking")]
	[Token(Token = "0x4001D66")]
	[FieldOffset(Offset = "0x40")]
	public bool m_TrackXWithHead;

	[Token(Token = "0x4001D67")]
	[FieldOffset(Offset = "0x44")]
	public Vector2 m_AdjustedAnimationRate;

	[Token(Token = "0x4001D68")]
	[FieldOffset(Offset = "0x4C")]
	private Vector2 uvOffset;

	[Token(Token = "0x4001D69")]
	[FieldOffset(Offset = "0x58")]
	private Renderer m_Renderer;

	[Token(Token = "0x4001D6A")]
	[FieldOffset(Offset = "0x60")]
	private Material m_Material;

	[Token(Token = "0x4001D6B")]
	[FieldOffset(Offset = "0x68")]
	private float m_HeadDirection;

	[Token(Token = "0x4001D6C")]
	[FieldOffset(Offset = "0x6C")]
	private Vector2 m_CurRndOffset;

	[Token(Token = "0x4001D6D")]
	[FieldOffset(Offset = "0x74")]
	private float m_CurRndSpeed;

	[Token(Token = "0x6001B30")]
	[Address(RVA = "0x759890", Offset = "0x758690", Length = "0x297")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B31")]
	[Address(RVA = "0x759B30", Offset = "0x758930", Length = "0x1E2")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001B32")]
	[Address(RVA = "0x759D20", Offset = "0x758B20", Length = "0x107")]
	public AnimatedUVs()
	{
	}
}

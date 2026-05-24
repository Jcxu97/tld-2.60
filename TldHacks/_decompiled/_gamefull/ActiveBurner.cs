using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000350")]
public class ActiveBurner : MonoBehaviour
{
	[Token(Token = "0x4001D41")]
	[FieldOffset(Offset = "0x20")]
	public Fire m_Fire;

	[Token(Token = "0x4001D42")]
	[FieldOffset(Offset = "0x28")]
	public MinMax m_OpacityRange;

	[Token(Token = "0x4001D43")]
	[FieldOffset(Offset = "0x30")]
	public float m_WiggleEaseSpeed;

	[Token(Token = "0x4001D44")]
	[FieldOffset(Offset = "0x34")]
	public float m_WiggleIntervalSeconds;

	[Token(Token = "0x4001D45")]
	[FieldOffset(Offset = "0x38")]
	public bool m_AlwaysOn;

	[Token(Token = "0x4001D46")]
	[FieldOffset(Offset = "0x3C")]
	private float m_CurrentTime;

	[Token(Token = "0x4001D47")]
	[FieldOffset(Offset = "0x40")]
	private float m_TargetOpacity;

	[Token(Token = "0x4001D48")]
	[FieldOffset(Offset = "0x44")]
	private float m_CurrentStrength;

	[Token(Token = "0x4001D49")]
	[FieldOffset(Offset = "0x48")]
	private float m_PreviousStrength;

	[Token(Token = "0x4001D4A")]
	[FieldOffset(Offset = "0x50")]
	private Renderer m_Rend;

	[Token(Token = "0x4001D4B")]
	[FieldOffset(Offset = "0x58")]
	private Material[] m_Materials;

	[Token(Token = "0x4001D4C")]
	[FieldOffset(Offset = "0x60")]
	private Material m_Material;

	[Token(Token = "0x6001B23")]
	[Address(RVA = "0x7585A0", Offset = "0x7573A0", Length = "0x214")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B24")]
	[Address(RVA = "0x7587C0", Offset = "0x7575C0", Length = "0x312")]
	private void Update()
	{
	}

	[Token(Token = "0x6001B25")]
	[Address(RVA = "0x758AE0", Offset = "0x7578E0", Length = "0x58")]
	public ActiveBurner()
	{
	}
}

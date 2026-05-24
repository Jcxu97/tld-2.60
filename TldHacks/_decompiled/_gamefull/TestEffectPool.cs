using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20002E7")]
public class TestEffectPool : MonoBehaviour
{
	[Token(Token = "0x4001987")]
	[FieldOffset(Offset = "0x20")]
	public ArrowImpactEffectPool m_ArrowImpactEffectPool;

	[Token(Token = "0x4001988")]
	[FieldOffset(Offset = "0x28")]
	public BulletImpactEffectPool m_BulletImpactEffectPool;

	[Token(Token = "0x4001989")]
	[FieldOffset(Offset = "0x30")]
	private float m_time;

	[Token(Token = "0x400198A")]
	[FieldOffset(Offset = "0x38")]
	private EffectPool<ArrowImpactEffectType>.EffectHandle[] m_ArrowImpactEffects;

	[Token(Token = "0x400198B")]
	[FieldOffset(Offset = "0x40")]
	private int m_EffectIndex;

	[Token(Token = "0x6001841")]
	[Address(RVA = "0x6E3970", Offset = "0x6E2770", Length = "0x1B0")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001842")]
	[Address(RVA = "0x6E3B30", Offset = "0x6E2930", Length = "0xA2F")]
	public void Update()
	{
	}

	[Token(Token = "0x6001843")]
	[Address(RVA = "0x6E4560", Offset = "0x6E3360", Length = "0xC2")]
	public TestEffectPool()
	{
	}
}

using Cpp2ILInjected;
using UnityEngine;

namespace TLD.AI;

[Token(Token = "0x20014F6")]
public class AiPtarmigan : BaseAi
{
	[Token(Token = "0x4009775")]
	[FieldOffset(Offset = "0xA48")]
	public float m_CrouchDetectionRange;

	[Token(Token = "0x4009776")]
	[FieldOffset(Offset = "0xA4C")]
	public float m_VerticalFlyingSpeed;

	[Token(Token = "0x4009777")]
	[FieldOffset(Offset = "0xA50")]
	public float m_FlyingSpeed;

	[Token(Token = "0x4009778")]
	[FieldOffset(Offset = "0xA54")]
	public float m_FleeRunningTimeMin;

	[Token(Token = "0x4009779")]
	[FieldOffset(Offset = "0xA58")]
	public float m_FleeRunningTimeMax;

	[Token(Token = "0x400977A")]
	[FieldOffset(Offset = "0xA5C")]
	public float m_DespawnAltitude;

	[Token(Token = "0x400977B")]
	[FieldOffset(Offset = "0xA60")]
	private float m_Altitude;

	[Token(Token = "0x400977C")]
	[FieldOffset(Offset = "0xA64")]
	private bool m_IsFlying;

	[Token(Token = "0x400977D")]
	[FieldOffset(Offset = "0xA68")]
	private int m_AnimParameter_SetFlying;

	[Token(Token = "0x400977E")]
	[FieldOffset(Offset = "0xA6C")]
	private float m_RunningCountdown;

	[Token(Token = "0x400977F")]
	[FieldOffset(Offset = "0xA70")]
	private float m_AbsoluteDespawnAltitude;

	[Token(Token = "0x4009780")]
	[FieldOffset(Offset = "0xA74")]
	private float m_FallingSpeed;

	[Token(Token = "0x4009781")]
	private const float FALLING_FAILSAFE_HEIGHT = -1000f;

	[Token(Token = "0x4009782")]
	private const float TERMINAL_VELOCITY = -100f;

	[Token(Token = "0x600846E")]
	[Address(RVA = "0x125EA10", Offset = "0x125D810", Length = "0x4E")]
	public override void Start_Anim()
	{
	}

	[Token(Token = "0x600846F")]
	[Address(RVA = "0x125EA60", Offset = "0x125D860", Length = "0x36")]
	public override void EnterFlee()
	{
	}

	[Token(Token = "0x6008470")]
	[Address(RVA = "0x125EAA0", Offset = "0x125D8A0", Length = "0x2FB")]
	public override void ProcessFlee()
	{
	}

	[Token(Token = "0x6008471")]
	[Address(RVA = "0x125EDA0", Offset = "0x125DBA0", Length = "0x34E")]
	public override void ProcessDead()
	{
	}

	[Token(Token = "0x6008472")]
	[Address(RVA = "0x125F0F0", Offset = "0x125DEF0", Length = "0xB")]
	public override bool CanProjectileStick()
	{
		return false;
	}

	[Token(Token = "0x6008473")]
	[Address(RVA = "0x125F100", Offset = "0x125DF00", Length = "0xDA")]
	public override void MaybeFleeOrAttackFromProjectileHit(WeaponSource weapon)
	{
	}

	[Token(Token = "0x6008474")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool CanBleedOut()
	{
		return false;
	}

	[Token(Token = "0x6008475")]
	[Address(RVA = "0x125F1E0", Offset = "0x125DFE0", Length = "0x2D")]
	protected override float GetFleeSpeed()
	{
		return 0f;
	}

	[Token(Token = "0x6008476")]
	[Address(RVA = "0x125F210", Offset = "0x125E010", Length = "0x15F")]
	private void DespawnFlyingAnimal()
	{
	}

	[Token(Token = "0x6008477")]
	[Address(RVA = "0x125F370", Offset = "0x125E170", Length = "0x1F4")]
	private void SetFlying(bool enable)
	{
	}

	[Token(Token = "0x6008478")]
	[Address(RVA = "0x125F570", Offset = "0x125E370", Length = "0x6D3")]
	protected override void OrientCharacterControllerToGround()
	{
	}

	[Token(Token = "0x6008479")]
	[Address(RVA = "0x125FC50", Offset = "0x125EA50", Length = "0x5A5")]
	protected override float ComputeDistanceForTarget(Vector3 eyePos, AiTarget potentialTarget)
	{
		return 0f;
	}

	[Token(Token = "0x600847A")]
	[Address(RVA = "0x1260200", Offset = "0x125F000", Length = "0x8A")]
	public AiPtarmigan()
	{
	}
}

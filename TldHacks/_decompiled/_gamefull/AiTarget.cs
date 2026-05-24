using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000143")]
public class AiTarget : MonoBehaviour
{
	[Token(Token = "0x40009FE")]
	[FieldOffset(Offset = "0x20")]
	public float m_EyeOffset;

	[Token(Token = "0x40009FF")]
	[FieldOffset(Offset = "0x24")]
	public bool m_InstaKillNPC;

	[HideInInspector]
	[Token(Token = "0x4000A00")]
	[FieldOffset(Offset = "0x28")]
	public float m_HP;

	[HideInInspector]
	[Token(Token = "0x4000A01")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_Stalker;

	[HideInInspector]
	[Token(Token = "0x4000A02")]
	[FieldOffset(Offset = "0x38")]
	public BaseAi m_BaseAi;

	[HideInInspector]
	[Token(Token = "0x4000A03")]
	[FieldOffset(Offset = "0x40")]
	public NPC m_Npc;

	[HideInInspector]
	[Token(Token = "0x4000A04")]
	[FieldOffset(Offset = "0x48")]
	public BaseAi m_BaseAiTargetingMe;

	[NonSerialized]
	[Token(Token = "0x4000A05")]
	[FieldOffset(Offset = "0x50")]
	public bool m_IsEnabled;

	[Token(Token = "0x6000B66")]
	[Address(RVA = "0x5D4320", Offset = "0x5D3120", Length = "0x38D")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000B67")]
	[Address(RVA = "0x5D46B0", Offset = "0x5D34B0", Length = "0x5")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000B68")]
	[Address(RVA = "0x5D46C0", Offset = "0x5D34C0", Length = "0x5")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000B69")]
	[Address(RVA = "0x5D46D0", Offset = "0x5D34D0", Length = "0x1DA")]
	public void Update()
	{
	}

	[Token(Token = "0x6000B6A")]
	[Address(RVA = "0x5D48B0", Offset = "0x5D36B0", Length = "0x16E")]
	public bool IsPlayer()
	{
		return false;
	}

	[Token(Token = "0x6000B6B")]
	[Address(RVA = "0x5D4A20", Offset = "0x5D3820", Length = "0x7A")]
	public bool InSnowShelter()
	{
		return false;
	}

	[Token(Token = "0x6000B6C")]
	[Address(RVA = "0x5D4AA0", Offset = "0x5D38A0", Length = "0x1D5")]
	public bool IsBaseWolf()
	{
		return false;
	}

	[Token(Token = "0x6000B6D")]
	[Address(RVA = "0x5D4C80", Offset = "0x5D3A80", Length = "0x1D5")]
	public bool IsBear()
	{
		return false;
	}

	[Token(Token = "0x6000B6E")]
	[Address(RVA = "0x5D4E60", Offset = "0x5D3C60", Length = "0x1D5")]
	public bool IsMoose()
	{
		return false;
	}

	[Token(Token = "0x6000B6F")]
	[Address(RVA = "0x5D5040", Offset = "0x5D3E40", Length = "0x1D5")]
	public bool IsCougar()
	{
		return false;
	}

	[Token(Token = "0x6000B70")]
	[Address(RVA = "0x5D5220", Offset = "0x5D4020", Length = "0xCA")]
	public bool IsNpcSurvivor()
	{
		return false;
	}

	[Token(Token = "0x6000B71")]
	[Address(RVA = "0x5D52F0", Offset = "0x5D40F0", Length = "0x248")]
	public bool IsDead()
	{
		return false;
	}

	[Token(Token = "0x6000B72")]
	[Address(RVA = "0x5D5540", Offset = "0x5D4340", Length = "0xEF")]
	public bool IsAmbient()
	{
		return false;
	}

	[Token(Token = "0x6000B73")]
	[Address(RVA = "0x5D5630", Offset = "0x5D4430", Length = "0x22C")]
	public bool IsHostileTowards(BaseAi compareBaseAi)
	{
		return false;
	}

	[Token(Token = "0x6000B74")]
	[Address(RVA = "0x5D5860", Offset = "0x5D4660", Length = "0x1E1")]
	public bool IsVulnerable()
	{
		return false;
	}

	[Token(Token = "0x6000B75")]
	[Address(RVA = "0x5D5A50", Offset = "0x5D4850", Length = "0x2D6")]
	public void ApplyDamage(float damage, DamageSource damageSource, string collider)
	{
	}

	[Token(Token = "0x6000B76")]
	[Address(RVA = "0x5D5D30", Offset = "0x5D4B30", Length = "0x1A4")]
	public float Distance(Vector3 pos)
	{
		return 0f;
	}

	[Token(Token = "0x6000B77")]
	[Address(RVA = "0x5D5EE0", Offset = "0x5D4CE0", Length = "0x17B")]
	public float Dot(Vector3 pos, Vector3 forward)
	{
		return 0f;
	}

	[Token(Token = "0x6000B78")]
	[Address(RVA = "0x5D6060", Offset = "0x5D4E60", Length = "0x209")]
	public string GetName()
	{
		return null;
	}

	[Token(Token = "0x6000B79")]
	[Address(RVA = "0x5D6270", Offset = "0x5D5070", Length = "0x395")]
	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000B7A")]
	[Address(RVA = "0x5D6610", Offset = "0x5D5410", Length = "0x3E8")]
	public Vector3 GetEyePos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000B7B")]
	[Address(RVA = "0x5D6A00", Offset = "0x5D5800", Length = "0x1D5")]
	public bool EmitsTrackableSmell()
	{
		return false;
	}

	[Token(Token = "0x6000B7C")]
	[Address(RVA = "0x5D6BE0", Offset = "0x5D59E0", Length = "0x2CB")]
	public bool HoldingLitFlare(FlareType flareType)
	{
		return false;
	}

	[Token(Token = "0x6000B7D")]
	[Address(RVA = "0x5D6EB0", Offset = "0x5D5CB0", Length = "0x269")]
	public bool HoldingRaisedSpear()
	{
		return false;
	}

	[Token(Token = "0x6000B7E")]
	[Address(RVA = "0x5D7120", Offset = "0x5D5F20", Length = "0x276")]
	public bool HoldingLitTorch()
	{
		return false;
	}

	[Token(Token = "0x6000B7F")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AiTarget()
	{
	}
}

using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200090E")]
public class RumbleEffectManager : MonoBehaviour
{
	[Token(Token = "0x200090F")]
	public enum RumbleEffectType
	{
		[Token(Token = "0x4005E7F")]
		LandingAfterFall,
		[Token(Token = "0x4005E80")]
		ShootingRifle,
		[Token(Token = "0x4005E81")]
		BreakingDownObject,
		[Token(Token = "0x4005E82")]
		PlayerStruggle
	}

	[Serializable]
	[Token(Token = "0x2000910")]
	public class RumbleEffectDefinition
	{
		[Token(Token = "0x4005E83")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_PrefabObject;

		[Token(Token = "0x4005E84")]
		[FieldOffset(Offset = "0x18")]
		public RumbleEffectType m_EffectType;

		[Token(Token = "0x6005297")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public RumbleEffectDefinition()
		{
		}
	}

	[Token(Token = "0x4005E7B")]
	[FieldOffset(Offset = "0x20")]
	public RumbleEffectDefinition[] m_RumbleEffects;

	[Token(Token = "0x4005E7C")]
	private static Dictionary<RumbleEffectType, RumbleEffect> m_RumbleEffectsDict;

	[Token(Token = "0x4005E7D")]
	private static List<RumbleEffect> m_RumbleEffectList;

	[Token(Token = "0x600528E")]
	[Address(RVA = "0xE4A3D0", Offset = "0xE491D0", Length = "0x2BD")]
	public void LoadEffects()
	{
	}

	[Token(Token = "0x600528F")]
	[Address(RVA = "0xE4A690", Offset = "0xE49490", Length = "0x13A")]
	public void PlayEffect(RumbleEffect effect)
	{
	}

	[Token(Token = "0x6005290")]
	[Address(RVA = "0xE4A7D0", Offset = "0xE495D0", Length = "0x2A3")]
	public void PlayEffect(RumbleEffectType effectType)
	{
	}

	[Token(Token = "0x6005291")]
	[Address(RVA = "0xE4AA80", Offset = "0xE49880", Length = "0xFD")]
	public void StopEffect(RumbleEffect effect)
	{
	}

	[Token(Token = "0x6005292")]
	[Address(RVA = "0xE4AB80", Offset = "0xE49980", Length = "0xAF")]
	public void StopEffect(RumbleEffectType effectType)
	{
	}

	[Token(Token = "0x6005293")]
	[Address(RVA = "0xE4AC30", Offset = "0xE49A30", Length = "0x49C")]
	public void Update()
	{
	}

	[Token(Token = "0x6005294")]
	[Address(RVA = "0xE4B0D0", Offset = "0xE49ED0", Length = "0x2F6")]
	public void Reset()
	{
	}

	[Token(Token = "0x6005295")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public RumbleEffectManager()
	{
	}
}

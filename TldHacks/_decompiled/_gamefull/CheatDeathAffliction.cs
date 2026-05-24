using System;
using Cpp2ILInjected;
using TLD.Logging;
using UnityEngine;

[Token(Token = "0x2000509")]
public class CheatDeathAffliction : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200050A")]
	private class CheatDeathAfflictionModifier
	{
		[Range(-100f, 0f)]
		[Token(Token = "0x4002E3D")]
		[FieldOffset(Offset = "0x10")]
		public float m_PermanentMaxConditionModifier;

		[Range(-100f, 0f)]
		[Token(Token = "0x4002E3E")]
		[FieldOffset(Offset = "0x14")]
		public float m_TemporaryMaxConditionModifier;

		[Token(Token = "0x6002649")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public CheatDeathAfflictionModifier()
		{
		}
	}

	[Token(Token = "0x4002E3A")]
	private static readonly LogFilter s_LogFilter;

	[SerializeField]
	[Token(Token = "0x4002E3B")]
	[FieldOffset(Offset = "0x20")]
	private CheatDeathAfflictionModifier[] m_Modifiers;

	[Token(Token = "0x4002E3C")]
	[FieldOffset(Offset = "0x28")]
	private CheatDeathAfflictionState m_State;

	[Token(Token = "0x1700025F")]
	public bool HasAffliction
	{
		[Token(Token = "0x6002639")]
		[Address(RVA = "0x89EA70", Offset = "0x89D870", Length = "0x32")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000260")]
	public bool IsPermanent
	{
		[Token(Token = "0x600263A")]
		[Address(RVA = "0x89EAB0", Offset = "0x89D8B0", Length = "0x1B")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000261")]
	public float HoursRemaining
	{
		[Token(Token = "0x600263B")]
		[Address(RVA = "0x89EAD0", Offset = "0x89D8D0", Length = "0x1C")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000262")]
	public float MaxConditionModifier
	{
		[Token(Token = "0x600263C")]
		[Address(RVA = "0x89EAF0", Offset = "0x89D8F0", Length = "0x1C")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000263")]
	private string DisplayNameLocID
	{
		[Token(Token = "0x600263D")]
		[Address(RVA = "0x89EB10", Offset = "0x89D910", Length = "0x48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000264")]
	private string IconSpriteName
	{
		[Token(Token = "0x600263E")]
		[Address(RVA = "0x89EB60", Offset = "0x89D960", Length = "0x48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600263F")]
	[Address(RVA = "0x89EBB0", Offset = "0x89D9B0", Length = "0x22F")]
	public void Apply(float timeActive, int death, AfflictionOptions options = AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x6002640")]
	[Address(RVA = "0x89EDE0", Offset = "0x89DBE0", Length = "0x152")]
	public void Cure(AfflictionOptions options = AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x6002641")]
	[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
	public CheatDeathAfflictionState Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002642")]
	[Address(RVA = "0x89EF40", Offset = "0x89DD40", Length = "0x52")]
	public void Deserialize(CheatDeathAfflictionState afflictionState)
	{
	}

	[Token(Token = "0x6002643")]
	[Address(RVA = "0x89EFA0", Offset = "0x89DDA0", Length = "0x142")]
	private void Update()
	{
	}

	[Token(Token = "0x6002644")]
	[Address(RVA = "0x89F0F0", Offset = "0x89DEF0", Length = "0x3F")]
	public float GetTemporaryConditionModifierForDeath(int death)
	{
		return 0f;
	}

	[Token(Token = "0x6002645")]
	[Address(RVA = "0x89F130", Offset = "0x89DF30", Length = "0x3F")]
	public float GetPermanentConditionModifierForDeath(int death)
	{
		return 0f;
	}

	[Token(Token = "0x6002646")]
	[Address(RVA = "0x89F170", Offset = "0x89DF70", Length = "0xFB")]
	private bool TryGetModifiersForDeath(int death, out CheatDeathAfflictionModifier modifiers)
	{
		modifiers = null;
		return false;
	}

	[Token(Token = "0x6002647")]
	[Address(RVA = "0x89F270", Offset = "0x89E070", Length = "0xC2")]
	public CheatDeathAffliction()
	{
	}
}

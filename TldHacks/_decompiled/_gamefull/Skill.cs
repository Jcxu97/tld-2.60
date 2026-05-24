using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200093B")]
public class Skill : MonoBehaviour
{
	[Token(Token = "0x400602B")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x400602C")]
	[FieldOffset(Offset = "0x28")]
	public SkillType m_SkillType;

	[Token(Token = "0x400602D")]
	[FieldOffset(Offset = "0x30")]
	public int[] m_TierPoints;

	[Token(Token = "0x400602E")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString[] m_TierLocalizedBenefits;

	[Token(Token = "0x400602F")]
	[FieldOffset(Offset = "0x40")]
	public LocalizedString[] m_TierLocalizedDescriptions;

	[Header("UI")]
	[Token(Token = "0x4006030")]
	[FieldOffset(Offset = "0x48")]
	public string m_SkillImage;

	[Token(Token = "0x4006031")]
	[FieldOffset(Offset = "0x50")]
	public string m_SkillIcon;

	[Token(Token = "0x4006032")]
	[FieldOffset(Offset = "0x58")]
	public string m_SkillIconBackground;

	[Token(Token = "0x4006033")]
	[FieldOffset(Offset = "0x60")]
	private int m_CurrentPoints;

	[Token(Token = "0x1700037D")]
	public string m_DisplayName
	{
		[Token(Token = "0x60053D4")]
		[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60053D3")]
	[Address(RVA = "0xE77290", Offset = "0xE76090", Length = "0x69")]
	private void Start()
	{
	}

	[Token(Token = "0x60053D5")]
	[Address(RVA = "0xE77300", Offset = "0xE76100", Length = "0x35")]
	public int GetTierPoints(int index)
	{
		return 0;
	}

	[Token(Token = "0x60053D6")]
	[Address(RVA = "0xE77340", Offset = "0xE76140", Length = "0xBC")]
	public string GetCurrentTierName()
	{
		return null;
	}

	[Token(Token = "0x60053D7")]
	[Address(RVA = "0xE77400", Offset = "0xE76200", Length = "0xE1")]
	public string GetCurrentTierDescription()
	{
		return null;
	}

	[Token(Token = "0x60053D8")]
	[Address(RVA = "0xE774F0", Offset = "0xE762F0", Length = "0x82")]
	public string GetCurrentTierBenefits()
	{
		return null;
	}

	[Token(Token = "0x60053D9")]
	[Address(RVA = "0xE77580", Offset = "0xE76380", Length = "0x88")]
	public string GetTierDescription(int index)
	{
		return null;
	}

	[Token(Token = "0x60053DA")]
	[Address(RVA = "0xE77610", Offset = "0xE76410", Length = "0x88")]
	public virtual string GetTierBenefits(int index)
	{
		return null;
	}

	[Token(Token = "0x60053DB")]
	[Address(RVA = "0x8AE8C0", Offset = "0x8AD6C0", Length = "0x4")]
	public int GetPoints()
	{
		return 0;
	}

	[Token(Token = "0x60053DC")]
	[Address(RVA = "0xE776A0", Offset = "0xE764A0", Length = "0xA2")]
	public void SetPoints(int points, SkillsManager.PointAssignmentMode mode)
	{
	}

	[Token(Token = "0x60053DD")]
	[Address(RVA = "0xE77750", Offset = "0xE76550", Length = "0x30")]
	public void SetTier(int tier, SkillsManager.PointAssignmentMode mode)
	{
	}

	[Token(Token = "0x60053DE")]
	[Address(RVA = "0xE77790", Offset = "0xE76590", Length = "0x6F")]
	public float GetPointsAsPercent()
	{
		return 0f;
	}

	[Token(Token = "0x60053DF")]
	[Address(RVA = "0xE77800", Offset = "0xE76600", Length = "0x5C")]
	public float GetPointsAsNormalizedValue()
	{
		return 0f;
	}

	[Token(Token = "0x60053E0")]
	[Address(RVA = "0xE77860", Offset = "0xE76660", Length = "0x183")]
	public float GetProgressToNextLevelAsNormalizedValue(int addPoints)
	{
		return 0f;
	}

	[Token(Token = "0x60053E1")]
	[Address(RVA = "0xE779F0", Offset = "0xE767F0", Length = "0x26")]
	public int GetMaxPoints()
	{
		return 0;
	}

	[Token(Token = "0x60053E2")]
	[Address(RVA = "0xE77A20", Offset = "0xE76820", Length = "0xA5")]
	public void IncrementPoints(int increase, SkillsManager.PointAssignmentMode mode)
	{
	}

	[Token(Token = "0x60053E3")]
	[Address(RVA = "0xE77AD0", Offset = "0xE768D0", Length = "0x5E")]
	public int GetCurrentTierNumber()
	{
		return 0;
	}

	[Token(Token = "0x60053E4")]
	[Address(RVA = "0xE77B30", Offset = "0xE76930", Length = "0x1AF")]
	public Skill()
	{
	}
}

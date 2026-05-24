using Cpp2ILInjected;
using TLD.SaveState;
using UnityEngine;

[Token(Token = "0x200034A")]
public class Feat_NightWalker : Feat
{
	[Token(Token = "0x4001D2C")]
	public const BadgeInfoType BADGE = BadgeInfoType.Badge_NowhereToHide2020Badge1;

	[Header("Tuning")]
	[Range(0f, 10f)]
	[Token(Token = "0x4001D2D")]
	[FieldOffset(Offset = "0x68")]
	public float m_FatigueScaleDayMultiplier;

	[Range(0f, 10f)]
	[Token(Token = "0x4001D2E")]
	[FieldOffset(Offset = "0x6C")]
	public float m_FatigueScaleNightMultiplier;

	[Token(Token = "0x4001D2F")]
	[FieldOffset(Offset = "0x70")]
	private bool m_Unlocked;

	[Token(Token = "0x6001AF5")]
	[Address(RVA = "0x756320", Offset = "0x755120", Length = "0x25")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001AF6")]
	[Address(RVA = "0x756350", Offset = "0x755150", Length = "0x186")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6001AF7")]
	[Address(RVA = "0x7564E0", Offset = "0x7552E0", Length = "0x8E")]
	public float GetFatigueScale()
	{
		return 0f;
	}

	[Token(Token = "0x6001AF8")]
	[Address(RVA = "0x756570", Offset = "0x755370", Length = "0xB6")]
	public override bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6001AF9")]
	[Address(RVA = "0x752400", Offset = "0x751200", Length = "0x30")]
	public override float GetNormalizedProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6001AFA")]
	[Address(RVA = "0x756630", Offset = "0x755430", Length = "0x12C")]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[Token(Token = "0x6001AFB")]
	[Address(RVA = "0x756760", Offset = "0x755560", Length = "0x51")]
	public Feat_NightWalker()
	{
	}
}

using Cpp2ILInjected;
using TLD.Gear;
using TLD.IntBackedUnit;
using UnityEngine;

[Token(Token = "0x20004AD")]
public abstract class HarvestBase : MonoBehaviour
{
	[Token(Token = "0x4002B44")]
	[FieldOffset(Offset = "0x20")]
	public SkillType m_AppliedSkillType;

	[Token(Token = "0x4002B45")]
	[FieldOffset(Offset = "0x24")]
	public int m_DurationMinutes;

	[Token(Token = "0x4002B46")]
	[FieldOffset(Offset = "0x28")]
	public string m_Audio;

	[HideInInspector]
	[Token(Token = "0x4002B47")]
	[FieldOffset(Offset = "0x30")]
	public ToolsItem[] m_RequiredTools;

	[HideInInspector]
	[Token(Token = "0x4002B48")]
	[FieldOffset(Offset = "0x38")]
	public PowderType[] m_YieldPowder;

	[HideInInspector]
	[Token(Token = "0x4002B49")]
	[FieldOffset(Offset = "0x40")]
	public ItemWeight[] m_YieldPowderAmount;

	[Token(Token = "0x1700023A")]
	public abstract int YieldCount
	{
		[Token(Token = "0x60023D2")]
		get;
	}

	[Token(Token = "0x60023D3")]
	public abstract GearItem GetPrefab(int index);

	[Token(Token = "0x60023D4")]
	public abstract int GetAmount(int index);

	[Token(Token = "0x60023D5")]
	[Address(RVA = "0x85E480", Offset = "0x85D280", Length = "0x1E")]
	public bool RequiresTool()
	{
		return false;
	}

	[Token(Token = "0x60023D6")]
	[Address(RVA = "0x85E430", Offset = "0x85D230", Length = "0x4A")]
	protected HarvestBase()
	{
	}
}

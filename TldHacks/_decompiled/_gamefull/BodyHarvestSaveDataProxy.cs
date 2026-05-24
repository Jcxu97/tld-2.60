using Cpp2ILInjected;
using TLD.IntBackedUnit;

[Token(Token = "0x2000549")]
public class BodyHarvestSaveDataProxy
{
	[Token(Token = "0x40030B6")]
	[FieldOffset(Offset = "0x10")]
	public ItemWeight m_MeatAvailableKG;

	[Token(Token = "0x40030B7")]
	[FieldOffset(Offset = "0x18")]
	public int m_HideAvailableUnits;

	[Token(Token = "0x40030B8")]
	[FieldOffset(Offset = "0x1C")]
	public int m_GutAvailableUnits;

	[Token(Token = "0x40030B9")]
	[FieldOffset(Offset = "0x20")]
	public bool m_Frozen;

	[Token(Token = "0x40030BA")]
	[FieldOffset(Offset = "0x21")]
	public bool m_Ravaged;

	[Token(Token = "0x40030BB")]
	[FieldOffset(Offset = "0x24")]
	public float m_Condition;

	[Token(Token = "0x40030BC")]
	[FieldOffset(Offset = "0x28")]
	public bool m_RolledSpawnChance;

	[Token(Token = "0x40030BD")]
	[FieldOffset(Offset = "0x29")]
	public bool m_AllowDecay;

	[Token(Token = "0x40030BE")]
	[FieldOffset(Offset = "0x2C")]
	public float m_HoursPlayed;

	[Token(Token = "0x40030BF")]
	[FieldOffset(Offset = "0x30")]
	public float m_PercentFrozen;

	[Token(Token = "0x40030C0")]
	[FieldOffset(Offset = "0x34")]
	public float m_HoursRemainingOnCloseFire;

	[Token(Token = "0x40030C1")]
	[FieldOffset(Offset = "0x38")]
	public ItemWeight m_DecimationKGPerHour;

	[Token(Token = "0x40030C2")]
	[FieldOffset(Offset = "0x40")]
	public float m_DecimationHoursRemaining;

	[Token(Token = "0x40030C3")]
	[FieldOffset(Offset = "0x44")]
	public float m_QuarterDurationMinutes;

	[Token(Token = "0x40030C4")]
	[FieldOffset(Offset = "0x48")]
	public bool m_HasHarvested;

	[Token(Token = "0x40030C5")]
	[FieldOffset(Offset = "0x4C")]
	public float m_LastHarvestTimeHours;

	[Token(Token = "0x40030C6")]
	[FieldOffset(Offset = "0x50")]
	public float m_QuarterBagWasteMultiplier;

	[Token(Token = "0x40030C7")]
	[FieldOffset(Offset = "0x58")]
	public string m_MissionIdSerialized;

	[Token(Token = "0x40030C8")]
	[FieldOffset(Offset = "0x60")]
	public string m_BearHuntAiReduxSerialized;

	[Token(Token = "0x40030C9")]
	[FieldOffset(Offset = "0x68")]
	public BaseAi.DamageSide m_DamageSide;

	[Token(Token = "0x40030CA")]
	[FieldOffset(Offset = "0x6C")]
	public bool m_HaveBonusItemsBeenHarvested;

	[Token(Token = "0x6002878")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BodyHarvestSaveDataProxy()
	{
	}
}

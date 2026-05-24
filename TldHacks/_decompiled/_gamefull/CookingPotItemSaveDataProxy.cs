using Cpp2ILInjected;
using TLD.IntBackedUnit;

[Token(Token = "0x2000475")]
public class CookingPotItemSaveDataProxy
{
	[Token(Token = "0x4002847")]
	[FieldOffset(Offset = "0x10")]
	public string m_FireBeingUsedGUID;

	[Token(Token = "0x4002848")]
	[FieldOffset(Offset = "0x18")]
	public string m_GearItemBeingCookedGUID;

	[Token(Token = "0x4002849")]
	[FieldOffset(Offset = "0x20")]
	public float m_CookingElapsedHours;

	[Token(Token = "0x400284A")]
	[FieldOffset(Offset = "0x24")]
	public float m_GracePeriodElapsedHours;

	[Token(Token = "0x400284B")]
	[FieldOffset(Offset = "0x28")]
	public float m_FireBurningTimeTODHours;

	[Token(Token = "0x400284C")]
	[FieldOffset(Offset = "0x2C")]
	public float m_HoursPlayedWhenSerialized;

	[Token(Token = "0x400284D")]
	[FieldOffset(Offset = "0x30")]
	public ItemLiquidVolume m_LitersSnowBeingMelted;

	[Token(Token = "0x400284E")]
	[FieldOffset(Offset = "0x38")]
	public ItemLiquidVolume m_LitersWaterBeingBoiled;

	[Token(Token = "0x400284F")]
	[FieldOffset(Offset = "0x40")]
	public bool m_CanOnlyWarmUpFood;

	[Token(Token = "0x600217D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public CookingPotItemSaveDataProxy()
	{
	}
}

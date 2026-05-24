using Cpp2ILInjected;
using TLD.Gear;
using TLD.IntBackedUnit;
using UnityEngine;

[Token(Token = "0x200049B")]
public class GearItemSaveDataProxy
{
	[Token(Token = "0x4002A03")]
	[FieldOffset(Offset = "0x10")]
	public float m_HoursPlayed;

	[Token(Token = "0x4002A04")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 m_Position;

	[Token(Token = "0x4002A05")]
	[FieldOffset(Offset = "0x20")]
	public Quaternion m_Rotation;

	[Token(Token = "0x4002A06")]
	[FieldOffset(Offset = "0x30")]
	public int m_InstanceIDProxy;

	[Token(Token = "0x4002A07")]
	[FieldOffset(Offset = "0x34")]
	public float m_CurrentHPProxy;

	[Token(Token = "0x4002A08")]
	[FieldOffset(Offset = "0x38")]
	public float m_DecayAccumulator;

	[Token(Token = "0x4002A09")]
	[FieldOffset(Offset = "0x3C")]
	public float m_NormalizedCondition;

	[Token(Token = "0x4002A0A")]
	[FieldOffset(Offset = "0x40")]
	public bool m_BeenInPlayerInventoryProxy;

	[Token(Token = "0x4002A0B")]
	[FieldOffset(Offset = "0x41")]
	public bool m_BeenInContainerProxy;

	[Token(Token = "0x4002A0C")]
	[FieldOffset(Offset = "0x42")]
	public bool m_BeenInspectedProxy;

	[Token(Token = "0x4002A0D")]
	[FieldOffset(Offset = "0x43")]
	public bool m_ItemLootedProxy;

	[Token(Token = "0x4002A0E")]
	[FieldOffset(Offset = "0x44")]
	public bool m_HasBeenOwnedByPlayer;

	[Token(Token = "0x4002A0F")]
	[FieldOffset(Offset = "0x45")]
	public bool m_RolledSpawnChanceProxy;

	[Token(Token = "0x4002A10")]
	[FieldOffset(Offset = "0x46")]
	public bool m_WornOut;

	[Token(Token = "0x4002A11")]
	[FieldOffset(Offset = "0x48")]
	public string m_StackableItemSerialized;

	[Token(Token = "0x4002A12")]
	[FieldOffset(Offset = "0x50")]
	public string m_FoodItemSerialized;

	[Token(Token = "0x4002A13")]
	[FieldOffset(Offset = "0x58")]
	public string m_LiquidItemSerialized;

	[Token(Token = "0x4002A14")]
	[FieldOffset(Offset = "0x60")]
	public string m_FlareItemSerialized;

	[Token(Token = "0x4002A15")]
	[FieldOffset(Offset = "0x68")]
	public string m_FlashlightItemSerialized;

	[Token(Token = "0x4002A16")]
	[FieldOffset(Offset = "0x70")]
	public string m_KeroseneLampItemSerialized;

	[Token(Token = "0x4002A17")]
	[FieldOffset(Offset = "0x78")]
	public string m_ClothingItemSerialized;

	[Token(Token = "0x4002A18")]
	[FieldOffset(Offset = "0x80")]
	public string m_WeaponItemSerialized;

	[Token(Token = "0x4002A19")]
	[FieldOffset(Offset = "0x88")]
	public string m_WaterSupplySerialized;

	[Token(Token = "0x4002A1A")]
	[FieldOffset(Offset = "0x90")]
	public string m_BedSerialized;

	[Token(Token = "0x4002A1B")]
	[FieldOffset(Offset = "0x98")]
	public string m_SmashableItemSerialized;

	[Token(Token = "0x4002A1C")]
	[FieldOffset(Offset = "0xA0")]
	public string m_MatchesItemSerialized;

	[Token(Token = "0x4002A1D")]
	[FieldOffset(Offset = "0xA8")]
	public string m_SnareItemSerialized;

	[Token(Token = "0x4002A1E")]
	[FieldOffset(Offset = "0xB0")]
	public string m_InProgressItemSerialized;

	[Token(Token = "0x4002A1F")]
	[FieldOffset(Offset = "0xB8")]
	public string m_TorchItemSerialized;

	[Token(Token = "0x4002A20")]
	[FieldOffset(Offset = "0xC0")]
	public string m_CollectibleNoteSerialized;

	[Token(Token = "0x4002A21")]
	[FieldOffset(Offset = "0xC8")]
	public string m_EvolveItemSerialized;

	[Token(Token = "0x4002A22")]
	[FieldOffset(Offset = "0xD0")]
	public string m_ObjectGuidSerialized;

	[Token(Token = "0x4002A23")]
	[FieldOffset(Offset = "0xD8")]
	public string m_MissionObjectSerialized;

	[Token(Token = "0x4002A24")]
	[FieldOffset(Offset = "0xE0")]
	public string m_ResearchItemSerialized;

	[Token(Token = "0x4002A25")]
	[FieldOffset(Offset = "0xE8")]
	public ItemWeight m_WeightKG;

	[Token(Token = "0x4002A26")]
	[FieldOffset(Offset = "0xF0")]
	public bool m_HarvestedByPlayer;

	[Token(Token = "0x4002A27")]
	[FieldOffset(Offset = "0xF1")]
	public bool m_IsInSatchel;

	[Token(Token = "0x4002A28")]
	[FieldOffset(Offset = "0xF4")]
	public int m_SatchelIndex;

	[Token(Token = "0x4002A29")]
	[FieldOffset(Offset = "0xF8")]
	public string m_BodyHarvestSerialized;

	[Token(Token = "0x4002A2A")]
	[FieldOffset(Offset = "0x100")]
	public bool m_LockedInContainer;

	[Token(Token = "0x4002A2B")]
	[FieldOffset(Offset = "0x104")]
	public int m_GearItemSaveVersion;

	[Token(Token = "0x4002A2C")]
	[FieldOffset(Offset = "0x108")]
	public string m_CookingPotItemSerialized;

	[Token(Token = "0x4002A2D")]
	[FieldOffset(Offset = "0x110")]
	public string m_PlacePointGuidSerialized;

	[Token(Token = "0x4002A2E")]
	[FieldOffset(Offset = "0x118")]
	public string m_PlacePointNameSerialized;

	[Token(Token = "0x4002A2F")]
	[FieldOffset(Offset = "0x120")]
	public bool m_NonInteractive;

	[Token(Token = "0x4002A30")]
	[FieldOffset(Offset = "0x121")]
	public bool m_HasBeenEquippedAndUsed;

	[Token(Token = "0x4002A31")]
	[FieldOffset(Offset = "0x128")]
	public string m_InspectSerialized;

	[Token(Token = "0x4002A32")]
	[FieldOffset(Offset = "0x130")]
	public string m_RigidBodySerialized;

	[Token(Token = "0x4002A33")]
	[FieldOffset(Offset = "0x138")]
	public bool m_StoneItemThrown;

	[Token(Token = "0x4002A34")]
	[FieldOffset(Offset = "0x140")]
	public string m_PowderItemSerialized;

	[Token(Token = "0x4002A35")]
	[FieldOffset(Offset = "0x148")]
	public string m_MillableSerialized;

	[Token(Token = "0x4002A36")]
	[FieldOffset(Offset = "0x150")]
	public string m_SprayPaintCanSerialized;

	[Token(Token = "0x4002A37")]
	[FieldOffset(Offset = "0x158")]
	public string m_NoiseMakerSerialized;

	[Token(Token = "0x4002A38")]
	[FieldOffset(Offset = "0x160")]
	public string m_BowItemSerialized;

	[Token(Token = "0x4002A39")]
	[FieldOffset(Offset = "0x168")]
	public HandheldShortwaveSaveDataProxy m_HandheldshortwaveSerialized;

	[Token(Token = "0x4002A3A")]
	[FieldOffset(Offset = "0x170")]
	public InsulatedFlask.SaveData m_InsulatedFlaskSerialized;

	[Token(Token = "0x4002A3B")]
	[FieldOffset(Offset = "0x178")]
	public RespiratorSaveData m_RespiratorSerialized;

	[Token(Token = "0x4002A3C")]
	[FieldOffset(Offset = "0x180")]
	public HeatPadState m_HeatPadSerialized;

	[Token(Token = "0x6002293")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public GearItemSaveDataProxy()
	{
	}
}

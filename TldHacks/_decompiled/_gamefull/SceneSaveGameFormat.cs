using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Placement;

[Token(Token = "0x2000933")]
public class SceneSaveGameFormat
{
	[Token(Token = "0x4005FC6")]
	[FieldOffset(Offset = "0x10")]
	public int m_Version;

	[Token(Token = "0x4005FC7")]
	[FieldOffset(Offset = "0x18")]
	public string m_ContainerManagerSerialized;

	[Token(Token = "0x4005FC8")]
	[FieldOffset(Offset = "0x20")]
	public string m_GearManagerSerialized;

	[Token(Token = "0x4005FC9")]
	[FieldOffset(Offset = "0x28")]
	public string m_ArrowManagerSerialized;

	[Token(Token = "0x4005FCA")]
	[FieldOffset(Offset = "0x30")]
	public string m_FlareGunRoundManagerSerialized;

	[Token(Token = "0x4005FCB")]
	[FieldOffset(Offset = "0x38")]
	public string m_FireManagerSerialized;

	[Token(Token = "0x4005FCC")]
	[FieldOffset(Offset = "0x40")]
	public string m_MusicTriggersSerialized;

	[Token(Token = "0x4005FCD")]
	[FieldOffset(Offset = "0x48")]
	public string m_LoadSceneTriggersSerialized;

	[Token(Token = "0x4005FCE")]
	[FieldOffset(Offset = "0x50")]
	public string m_LoadSceneParentSerialized;

	[Token(Token = "0x4005FCF")]
	[FieldOffset(Offset = "0x58")]
	public string m_LocationLabelsSerialized;

	[Token(Token = "0x4005FD0")]
	[FieldOffset(Offset = "0x60")]
	public string m_RandomSpawnObjectManagerSerialized;

	[Token(Token = "0x4005FD1")]
	[FieldOffset(Offset = "0x68")]
	public string m_WaterSourceManagerSerialized;

	[Token(Token = "0x4005FD2")]
	[FieldOffset(Offset = "0x70")]
	public string m_BodyHarvestManagerSerialized;

	[Token(Token = "0x4005FD3")]
	[FieldOffset(Offset = "0x78")]
	public string m_SpawnRegionManagerSerialized;

	[Token(Token = "0x4005FD4")]
	[FieldOffset(Offset = "0x80")]
	public string m_DynamicDecalsManagerSerialized;

	[Token(Token = "0x4005FD5")]
	[FieldOffset(Offset = "0x88")]
	public string m_SceneMusicManagerSerialized;

	[Token(Token = "0x4005FD6")]
	[FieldOffset(Offset = "0x90")]
	public string m_IceFishingHolesSerialized;

	[Token(Token = "0x4005FD7")]
	[FieldOffset(Offset = "0x98")]
	public string m_HarvestablesSerialized;

	[Token(Token = "0x4005FD8")]
	[FieldOffset(Offset = "0xA0")]
	public string m_ReplaceMaterialsSerialized;

	[Token(Token = "0x4005FD9")]
	[FieldOffset(Offset = "0xA8")]
	public string m_OpenClosersSerialized;

	[Token(Token = "0x4005FDA")]
	[FieldOffset(Offset = "0xB0")]
	public string m_SwitchBoxSerialized;

	[Token(Token = "0x4005FDB")]
	[FieldOffset(Offset = "0xB8")]
	public string m_BreakDownObjectsSerialized;

	[Token(Token = "0x4005FDC")]
	[FieldOffset(Offset = "0xC0")]
	public string m_RadialObjectSpawnersSerialized;

	[Token(Token = "0x4005FDD")]
	[FieldOffset(Offset = "0xC8")]
	public string m_StickToGroundObjectsSerialized;

	[Token(Token = "0x4005FDE")]
	[FieldOffset(Offset = "0xD0")]
	public string m_GearSpawnInOldSavesGUIDs;

	[Token(Token = "0x4005FDF")]
	[FieldOffset(Offset = "0xD8")]
	public string m_RopeAnchorPointsSerialized;

	[Token(Token = "0x4005FE0")]
	[FieldOffset(Offset = "0xE0")]
	public string m_ChimneysSerialized;

	[Token(Token = "0x4005FE1")]
	[FieldOffset(Offset = "0xE8")]
	public string m_FootstepsSerialized;

	[Token(Token = "0x4005FE2")]
	[FieldOffset(Offset = "0xF0")]
	public string m_SnowShelterManagerSerialized;

	[Token(Token = "0x4005FE3")]
	[FieldOffset(Offset = "0xF8")]
	public string m_RockCacheSerialized;

	[Token(Token = "0x4005FE4")]
	[FieldOffset(Offset = "0x100")]
	public string m_BaseAiManagerSerialized;

	[Token(Token = "0x4005FE5")]
	[FieldOffset(Offset = "0x108")]
	public string m_ActiveSwitchesSerialized;

	[Token(Token = "0x4005FE6")]
	[FieldOffset(Offset = "0x110")]
	public string m_KeypadsSerialized;

	[Token(Token = "0x4005FE7")]
	[FieldOffset(Offset = "0x118")]
	public string m_TLDBehaviourTreeManagerSerialized;

	[Token(Token = "0x4005FE8")]
	[FieldOffset(Offset = "0x120")]
	public string m_BreakableIceSerialized;

	[Token(Token = "0x4005FE9")]
	[FieldOffset(Offset = "0x128")]
	public string m_AuroraFieldsSerialized;

	[Token(Token = "0x4005FEA")]
	[FieldOffset(Offset = "0x130")]
	public string m_QuarteringSiteCarrionSerialized;

	[Token(Token = "0x4005FEB")]
	[FieldOffset(Offset = "0x138")]
	public string m_BearHuntSerialized;

	[Token(Token = "0x4005FEC")]
	[FieldOffset(Offset = "0x140")]
	public string m_MapDetailManagerSerialized;

	[Token(Token = "0x4005FED")]
	[FieldOffset(Offset = "0x148")]
	public string m_BearEncountersSerialized;

	[Token(Token = "0x4005FEE")]
	[FieldOffset(Offset = "0x150")]
	public string m_DialogueModeRigFPSerialized;

	[Token(Token = "0x4005FEF")]
	[FieldOffset(Offset = "0x158")]
	public string m_ScriptLightSerialized;

	[Token(Token = "0x4005FF0")]
	[FieldOffset(Offset = "0x160")]
	public string m_PersistentControllerStateSerialized;

	[Token(Token = "0x4005FF1")]
	[FieldOffset(Offset = "0x168")]
	public string m_PackManagerSerialized;

	[Token(Token = "0x4005FF2")]
	[FieldOffset(Offset = "0x170")]
	public string m_AuroraElectrolizerControllerSerialized;

	[Token(Token = "0x4005FF3")]
	[FieldOffset(Offset = "0x178")]
	public string m_PrefabSpawnSerialized;

	[Token(Token = "0x4005FF4")]
	[FieldOffset(Offset = "0x180")]
	public string m_SpawnWildlife_TriggerSerialized;

	[Token(Token = "0x4005FF5")]
	[FieldOffset(Offset = "0x188")]
	public string m_NPCSerialized;

	[Token(Token = "0x4005FF6")]
	[FieldOffset(Offset = "0x190")]
	public string m_BedSerialized;

	[Token(Token = "0x4005FF7")]
	[FieldOffset(Offset = "0x198")]
	public string m_AnimatedInteractionSerialized;

	[Token(Token = "0x4005FF8")]
	[FieldOffset(Offset = "0x1A0")]
	public string m_TintMaterialsSerialized;

	[Token(Token = "0x4005FF9")]
	[FieldOffset(Offset = "0x1A8")]
	public string m_EntityWardSerialized;

	[Token(Token = "0x4005FFA")]
	[FieldOffset(Offset = "0x1B0")]
	public string m_SteamPipeValveSerialized;

	[Token(Token = "0x4005FFB")]
	[FieldOffset(Offset = "0x1B8")]
	public string m_SteamPipeSerialized;

	[Token(Token = "0x4005FFC")]
	[FieldOffset(Offset = "0x1C0")]
	public string m_ElevatorSerialized;

	[Token(Token = "0x4005FFD")]
	[FieldOffset(Offset = "0x1C8")]
	public string m_LightsourceSerialized;

	[Token(Token = "0x4005FFE")]
	[FieldOffset(Offset = "0x1D0")]
	public string m_WolfDenSerialized;

	[Token(Token = "0x4005FFF")]
	[FieldOffset(Offset = "0x1D8")]
	public string m_BigCarrySystemSceneSerialized;

	[Token(Token = "0x4006000")]
	[FieldOffset(Offset = "0x1E0")]
	public string m_GearItemInteractabilityControlSerialized;

	[Token(Token = "0x4006001")]
	[FieldOffset(Offset = "0x1E8")]
	public string m_SpawnGearVariantsSerialized;

	[Token(Token = "0x4006002")]
	[FieldOffset(Offset = "0x1F0")]
	public string m_CustomSpawnedItemManagerSerialized;

	[Token(Token = "0x4006003")]
	[FieldOffset(Offset = "0x1F8")]
	public string m_BeachcombingSpawnersSerialized;

	[Token(Token = "0x4006004")]
	[FieldOffset(Offset = "0x200")]
	public BrokenDecorationSaveData m_BrokenDecorationSaveData;

	[Token(Token = "0x4006005")]
	[FieldOffset(Offset = "0x208")]
	public List<PlaceableInfoSaveData> m_PlacementListSerialized;

	[Token(Token = "0x4006006")]
	[FieldOffset(Offset = "0x210")]
	public DecorationItemData m_DecorationItemData;

	[Token(Token = "0x4006007")]
	[FieldOffset(Offset = "0x218")]
	public List<CuringStorageState> m_CuringStorageSerialized;

	[Token(Token = "0x4006008")]
	[FieldOffset(Offset = "0x220")]
	public List<FramedPhotoState> m_FramedPhotoSerialized;

	[Token(Token = "0x4006009")]
	[FieldOffset(Offset = "0x228")]
	public JunkManagerSaveData m_JunkManagedSerialized;

	[Token(Token = "0x60053C8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SceneSaveGameFormat()
	{
	}
}

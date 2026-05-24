using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.IntBackedUnit;
using TLD.Logging;
using TLD.Scenes;
using TLD.UI.Generics;
using TLD.Utility;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Gameplay;

[Token(Token = "0x200147F")]
public class LifeAfterDeathManager : MonoBehaviour
{
	[Token(Token = "0x40094C3")]
	private const string POTABLE_WATER_SUPPLY_NAME = "GEAR_WaterSupplyPotable";

	[Token(Token = "0x40094C4")]
	private const string NONPOTABLE_WATER_SUPPLY_NAME = "GEAR_WaterSupplyNotPotable";

	[Token(Token = "0x40094C5")]
	public static readonly LogFilter s_LogFilter;

	[SerializeField]
	[Token(Token = "0x40094C6")]
	[FieldOffset(Offset = "0x20")]
	private List<AssetReferenceT<GearItemData>> m_ProtectedGearReferences;

	[Header("Respawn Timeline")]
	[SerializeField]
	[Token(Token = "0x40094C7")]
	[FieldOffset(Offset = "0x28")]
	private TimelinePlayback.TimelineInfo m_RespawnTimeline;

	[Header("Loading")]
	[SerializeField]
	[Token(Token = "0x40094C8")]
	[FieldOffset(Offset = "0x30")]
	private float m_LoadingScreenMinHoldTime;

	[SerializeField]
	[Token(Token = "0x40094C9")]
	[FieldOffset(Offset = "0x38")]
	private LocalizedString m_LoadingScreenText;

	[Header("Map Reveal")]
	[SerializeField]
	[SpriteAtlasIconName]
	[Token(Token = "0x40094CA")]
	[FieldOffset(Offset = "0x40")]
	private string m_MapElementSprite;

	[SerializeField]
	[Token(Token = "0x40094CB")]
	[FieldOffset(Offset = "0x48")]
	private LocalizedString m_MapElementName;

	[SerializeField]
	[Token(Token = "0x40094CC")]
	[FieldOffset(Offset = "0x50")]
	private float m_MapRevealRadius;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40094CD")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_Loading> m_Loading;

	[SerializeField]
	[Token(Token = "0x40094CE")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_Map> m_Map;

	[Token(Token = "0x40094CF")]
	public static bool s_EnableInNewGame;

	[Token(Token = "0x40094D0")]
	private static bool s_SaveAfterRespawn;

	[Token(Token = "0x40094D1")]
	public static string s_PlayerSaveName;

	[Token(Token = "0x40094D2")]
	[FieldOffset(Offset = "0x68")]
	private LifeAfterDeathTunables m_Tunables;

	[Token(Token = "0x40094D3")]
	[FieldOffset(Offset = "0x140")]
	private AsyncOperationHandle<IList<GearItemData>> m_ProtectedGearHandle;

	[Token(Token = "0x40094D4")]
	[FieldOffset(Offset = "0x158")]
	private IList<GearItemData> m_ProtectedGear;

	[Token(Token = "0x40094D5")]
	[FieldOffset(Offset = "0x160")]
	private readonly List<GearItem> m_RemovedItems;

	[Token(Token = "0x40094D6")]
	[FieldOffset(Offset = "0x168")]
	private ItemLiquidVolume m_PotableWater;

	[Token(Token = "0x40094D7")]
	[FieldOffset(Offset = "0x170")]
	private ItemLiquidVolume m_NonPotableWater;

	[Token(Token = "0x40094D8")]
	[FieldOffset(Offset = "0x178")]
	private readonly List<RecoveryCampState.RecoveryDecorationItem> m_DecorationItems;

	[Token(Token = "0x40094D9")]
	[FieldOffset(Offset = "0x180")]
	private string m_RespawnScene;

	[Token(Token = "0x40094DA")]
	[FieldOffset(Offset = "0x188")]
	private LifeAfterDeathState m_LifeAfterDeathState;

	[Token(Token = "0x40094DB")]
	[FieldOffset(Offset = "0x190")]
	private RecoveryCamp m_ActiveRecoveryCamp;

	[Token(Token = "0x40094DC")]
	[FieldOffset(Offset = "0x198")]
	private GearItem m_HeldItem;

	[Token(Token = "0x17000B4C")]
	public bool IsSystemEnabled
	{
		[Token(Token = "0x6008241")]
		[Address(RVA = "0x122DF40", Offset = "0x122CD40", Length = "0x2E")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000B4D")]
	public int LivesUsed
	{
		[Token(Token = "0x6008242")]
		[Address(RVA = "0x122DF70", Offset = "0x122CD70", Length = "0x1D")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000B4E")]
	public int TotalLives
	{
		[Token(Token = "0x6008243")]
		[Address(RVA = "0x937160", Offset = "0x935F60", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000B4F")]
	public float TemporaryCheatDeathDurationHours
	{
		[Token(Token = "0x6008244")]
		[Address(RVA = "0x122DF90", Offset = "0x122CD90", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000B50")]
	public string RecoveryCampScene
	{
		[Token(Token = "0x6008245")]
		[Address(RVA = "0x122DFA0", Offset = "0x122CDA0", Length = "0x27")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008246")]
	[Address(RVA = "0x122DFD0", Offset = "0x122CDD0", Length = "0x275")]
	private void Awake()
	{
	}

	[Token(Token = "0x6008247")]
	[Address(RVA = "0x122E250", Offset = "0x122D050", Length = "0x2A4")]
	private LifeAfterDeathTunables GetTunables()
	{
		return default(LifeAfterDeathTunables);
	}

	[Token(Token = "0x6008248")]
	[Address(RVA = "0x122E500", Offset = "0x122D300", Length = "0xFC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6008249")]
	[Address(RVA = "0x122E600", Offset = "0x122D400", Length = "0x52")]
	public void Deserialize(LifeAfterDeathState serializedState)
	{
	}

	[Token(Token = "0x600824A")]
	[Address(RVA = "0x122E660", Offset = "0x122D460", Length = "0x2DE")]
	public void DeserializePostSceneLoad()
	{
	}

	[Token(Token = "0x600824B")]
	[Address(RVA = "0x122E940", Offset = "0x122D740", Length = "0x190")]
	private void UpdateLastRegion(string currentScene)
	{
	}

	[Token(Token = "0x600824C")]
	[Address(RVA = "0x122EAE0", Offset = "0x122D8E0", Length = "0xC89")]
	private void DeserializeRecoveryCampsite(string currentScene)
	{
	}

	[Token(Token = "0x600824D")]
	[Address(RVA = "0x122F770", Offset = "0x122E570", Length = "0x132")]
	public LifeAfterDeathState Serialize()
	{
		return null;
	}

	[Token(Token = "0x600824E")]
	[Address(RVA = "0x122F8B0", Offset = "0x122E6B0", Length = "0x4DE")]
	private void Update()
	{
	}

	[Token(Token = "0x600824F")]
	[Address(RVA = "0x122FD90", Offset = "0x122EB90", Length = "0x9C")]
	private void PlayRespawnTimeline()
	{
	}

	[Token(Token = "0x6008250")]
	[Address(RVA = "0x122FE30", Offset = "0x122EC30", Length = "0xAA5")]
	public void PrepareLifeAfterDeath()
	{
	}

	[Token(Token = "0x6008251")]
	[Address(RVA = "0x12308E0", Offset = "0x122F6E0", Length = "0xABA")]
	public bool PerformRespawn(LifeAfterDeathSpawnPointType spawnPointType, bool permanentAffliction)
	{
		return false;
	}

	[Token(Token = "0x6008252")]
	[Address(RVA = "0x12313A0", Offset = "0x12301A0", Length = "0x29F")]
	private string FindRespawnScene(RegionSpecification lastRegion, LifeAfterDeathSpawnPointType spawnPointType)
	{
		return null;
	}

	[Token(Token = "0x6008253")]
	[Address(RVA = "0x1231640", Offset = "0x1230440", Length = "0x396")]
	private AsyncOperationHandle<RegionSpecification> FindLastRegion()
	{
		return default(AsyncOperationHandle<RegionSpecification>);
	}

	[Token(Token = "0x6008254")]
	[Address(RVA = "0x12319E0", Offset = "0x12307E0", Length = "0xA8")]
	private void MovePlayerToKnownGoodPosition()
	{
	}

	[Token(Token = "0x6008255")]
	[Address(RVA = "0x1231A90", Offset = "0x1230890", Length = "0x982")]
	private void HandlePlayerState(bool permanentAffliction, LifeAfterDeathTunables.RespawnPlayerState respawnPlayerState)
	{
	}

	[Token(Token = "0x6008256")]
	[Address(RVA = "0x1232420", Offset = "0x1231220", Length = "0xA6C")]
	private void HandlePlayerInventory(string recoveryScene)
	{
	}

	[Token(Token = "0x6008257")]
	[Address(RVA = "0x1232E90", Offset = "0x1231C90", Length = "0x29D")]
	private void DegradeWornClothing(float degradeFactor)
	{
	}

	[Token(Token = "0x6008258")]
	[Address(RVA = "0x1233130", Offset = "0x1231F30", Length = "0x2B4")]
	private void AddWaterToRecovery(LiquidQuality liquidQuality, ItemLiquidVolume liters)
	{
	}

	[Token(Token = "0x6008259")]
	[Address(RVA = "0x12333F0", Offset = "0x12321F0", Length = "0x804")]
	private void RemoveItemsFromInventory()
	{
	}

	[Token(Token = "0x600825A")]
	[Address(RVA = "0x1233C00", Offset = "0x1232A00", Length = "0x922")]
	private void ReturnKeptItemsToInventory(LifeAfterDeathTunables.RespawnInventory keptInventory)
	{
	}

	[Token(Token = "0x600825B")]
	[Address(RVA = "0x1234530", Offset = "0x1233330", Length = "0x239")]
	private bool IsValidKeptFirewood(GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x600825C")]
	[Address(RVA = "0x1234770", Offset = "0x1233570", Length = "0xABB")]
	private void DestroyRemovedItems(float itemsToDestroyFactor)
	{
	}

	[Token(Token = "0x600825D")]
	[Address(RVA = "0x1235230", Offset = "0x1234030", Length = "0x2DD")]
	private void HandlePlayerEnvironment(LifeAfterDeathTunables.RespawnEnvironment respawnEnvironment)
	{
	}

	[Token(Token = "0x600825E")]
	[Address(RVA = "0x1235510", Offset = "0x1234310", Length = "0x18F")]
	public LifeAfterDeathManager()
	{
	}
}

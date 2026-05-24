using System;
using System.Collections;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.BigCarry;
using TLD.GameplayTags;
using TLD.Gear;
using TLD.IntBackedUnit;
using TLD.Interactions;
using TLD.Logging;
using TLD.Placement;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x2000799")]
public class PlayerManager : MonoBehaviour
{
	[Token(Token = "0x200079A")]
	public class IngestedCarryCapacityBuff
	{
		[Token(Token = "0x4005247")]
		[FieldOffset(Offset = "0x10")]
		public float m_HoursRemaining;

		[Token(Token = "0x4005248")]
		[FieldOffset(Offset = "0x14")]
		public float m_HoursDuration;

		[Token(Token = "0x4005249")]
		[FieldOffset(Offset = "0x18")]
		public string m_BuffTypeLocId;

		[Token(Token = "0x400524A")]
		[FieldOffset(Offset = "0x20")]
		public CarryingCapacityBuff.BuffValues m_BuffValues;

		[Token(Token = "0x6004914")]
		[Address(RVA = "0xD14070", Offset = "0xD12E70", Length = "0x87")]
		public IngestedCarryCapacityBuff()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200079B")]
	private class ClothingRegionSwitchDefault
	{
		[Token(Token = "0x400524B")]
		[FieldOffset(Offset = "0x10")]
		public ClothingRegion m_Region;

		[Token(Token = "0x400524C")]
		[FieldOffset(Offset = "0x18")]
		public Switch m_Switch;

		[Token(Token = "0x6004915")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ClothingRegionSwitchDefault()
		{
		}
	}

	[Flags]
	[Token(Token = "0x200079C")]
	public enum InventoryInstantiateFlags
	{
		[Token(Token = "0x400524E")]
		None = 0,
		[Token(Token = "0x400524F")]
		EnableNotificationFlag = 1,
		[Token(Token = "0x4005250")]
		CraftInProgress = 2,
		[Token(Token = "0x4005251")]
		DoNotStack = 4,
		[Token(Token = "0x4005252")]
		CraftCompleted = 8,
		[Token(Token = "0x4005253")]
		DeserializePlaceable = 0x10
	}

	[Token(Token = "0x200079D")]
	public struct LookAtTargetForTime
	{
		[Token(Token = "0x4005254")]
		[FieldOffset(Offset = "0x0")]
		public float m_FrameTimeSeconds;

		[Token(Token = "0x4005255")]
		[FieldOffset(Offset = "0x4")]
		public bool m_ShouldRestoreCameraOrientation;

		[Token(Token = "0x4005256")]
		[FieldOffset(Offset = "0x8")]
		public float m_TimeRemaining;

		[Token(Token = "0x4005257")]
		[FieldOffset(Offset = "0xC")]
		public UITweener.Method m_TtweenInMethod;

		[Token(Token = "0x4005258")]
		[FieldOffset(Offset = "0x10")]
		public bool m_SteeperCurvesIn;

		[Token(Token = "0x4005259")]
		[FieldOffset(Offset = "0x14")]
		public UITweener.Method m_TweenOutMethod;

		[Token(Token = "0x400525A")]
		[FieldOffset(Offset = "0x18")]
		public bool m_SteeperCurvesOut;

		[Token(Token = "0x400525B")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion m_RestoreCameraOrientation;

		[Token(Token = "0x400525C")]
		[FieldOffset(Offset = "0x2C")]
		public Quaternion m_CameraTargetOrientation;

		[Token(Token = "0x400525D")]
		[FieldOffset(Offset = "0x3C")]
		public float m_BlendInTime;

		[Token(Token = "0x400525E")]
		[FieldOffset(Offset = "0x40")]
		public float m_BlendOutTime;

		[Token(Token = "0x6004916")]
		[Address(RVA = "0xD14100", Offset = "0xD12F00", Length = "0x241")]
		public void Update()
		{
		}

		[Token(Token = "0x6004917")]
		[Address(RVA = "0xD14350", Offset = "0xD13150", Length = "0x178")]
		private float TweenValue(float factor, UITweener.Method tweenMethod, bool steeperCurves)
		{
			return 0f;
		}

		[Token(Token = "0x6004918")]
		[Address(RVA = "0xD144D0", Offset = "0xD132D0", Length = "0x9A")]
		private float BounceLogic(float val)
		{
			return 0f;
		}
	}

	[Serializable]
	[Token(Token = "0x200079E")]
	public struct DecalColourInfo
	{
		[Token(Token = "0x400525F")]
		[FieldOffset(Offset = "0x0")]
		public DecalColour m_ColourType;

		[Token(Token = "0x4005260")]
		[FieldOffset(Offset = "0x4")]
		public Color m_Color;
	}

	[Token(Token = "0x200079F")]
	private struct DecorationItemPlacementInfo
	{
		[Token(Token = "0x4005261")]
		[FieldOffset(Offset = "0x0")]
		private readonly DecorationItem m_Item;

		[Token(Token = "0x4005262")]
		[FieldOffset(Offset = "0x8")]
		private readonly Transform m_ItemTransform;

		[Token(Token = "0x4005263")]
		[FieldOffset(Offset = "0x10")]
		private readonly DecorationItem m_ItemParent;

		[Token(Token = "0x4005264")]
		[FieldOffset(Offset = "0x18")]
		private Matrix4x4 m_RelativeTransform;

		[Token(Token = "0x17000339")]
		public DecorationItem Item
		{
			[Token(Token = "0x6004919")]
			[Address(RVA = "0xD14570", Offset = "0xD13370", Length = "0x4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700033A")]
		public Transform Transform
		{
			[Token(Token = "0x600491A")]
			[Address(RVA = "0xD14580", Offset = "0xD13380", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600491B")]
		[Address(RVA = "0xD14590", Offset = "0xD13390", Length = "0x191")]
		public DecorationItemPlacementInfo(DecorationItem item)
		{
			m_Item = null;
			m_ItemTransform = null;
			m_ItemParent = null;
			m_RelativeTransform = default(Matrix4x4);
		}

		[Token(Token = "0x600491C")]
		[Address(RVA = "0xD14730", Offset = "0xD13530", Length = "0x1A9")]
		public DecorationItemPlacementInfo(GearItem gearItem, DecorationItem itemParent)
		{
			m_Item = null;
			m_ItemTransform = null;
			m_ItemParent = null;
			m_RelativeTransform = default(Matrix4x4);
		}

		[Token(Token = "0x600491D")]
		[Address(RVA = "0xD148E0", Offset = "0xD136E0", Length = "0x4DF")]
		public void ApplyRelativeTransform()
		{
		}

		[Token(Token = "0x600491E")]
		[Address(RVA = "0xD14DC0", Offset = "0xD13BC0", Length = "0x5AF")]
		private static Matrix4x4 GetRelativeTransform(Transform parent, Transform child)
		{
			return default(Matrix4x4);
		}
	}

	[Token(Token = "0x20007A0")]
	private class WaitForCollisionOverlaps : IEnumerator
	{
		[Token(Token = "0x4005265")]
		[FieldOffset(Offset = "0x10")]
		private readonly PlayerManager m_PlayerManager;

		[Token(Token = "0x1700033B")]
		public object Current
		{
			[Token(Token = "0x6004922")]
			[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600491F")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		public WaitForCollisionOverlaps(PlayerManager playerManager)
		{
		}

		[Token(Token = "0x6004920")]
		[Address(RVA = "0xD15370", Offset = "0xD14170", Length = "0x9F8")]
		public bool MoveNext()
		{
			return false;
		}

		[Token(Token = "0x6004921")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public void Reset()
		{
		}
	}

	[Flags]
	[Token(Token = "0x20007A1")]
	public enum DropLitItemsOptions
	{
		[Token(Token = "0x4005267")]
		None = 0,
		[Token(Token = "0x4005268")]
		KeepItemInInventory = 1,
		[Token(Token = "0x4005269")]
		DeleteDroppedItemWhenTimelineEnds = 4
	}

	[Token(Token = "0x4005112")]
	private const string LOCID_BUFFLOSSHEADER = "GAMEPLAY_BuffLossHeader";

	[Token(Token = "0x4005113")]
	private const string LOCID_CARRYCAPACITYBUFF = "GAMEPLAY_CarryBuffType";

	[Token(Token = "0x4005114")]
	private const string LOCID_CARRYCAPACITYDEBUFF = "GAMEPLAY_CarryDebuffType";

	[Token(Token = "0x4005115")]
	[FieldOffset(Offset = "0x20")]
	private float m_FreezingRateScale;

	[Token(Token = "0x4005116")]
	[FieldOffset(Offset = "0x24")]
	private float m_PumpkinPieFreezingRateScale;

	[Token(Token = "0x4005117")]
	[FieldOffset(Offset = "0x28")]
	private float m_FatigueRateScale;

	[Token(Token = "0x4005118")]
	[FieldOffset(Offset = "0x2C")]
	private float m_ConditonPercentBonus;

	[Token(Token = "0x4005119")]
	[FieldOffset(Offset = "0x30")]
	private float m_IncreaseWolfFleePercentagePoints;

	[Token(Token = "0x400511A")]
	[FieldOffset(Offset = "0x34")]
	private float m_DecreaseWolfAttackChancePercentagePoints;

	[Token(Token = "0x400511B")]
	[FieldOffset(Offset = "0x38")]
	private float m_ConditionPerHourBonus;

	[Token(Token = "0x400511C")]
	[FieldOffset(Offset = "0x3C")]
	private float m_FatigueBuffHoursRemaining;

	[Token(Token = "0x400511D")]
	[FieldOffset(Offset = "0x40")]
	private float m_FatigueBuffHoursDuration;

	[Token(Token = "0x400511E")]
	[FieldOffset(Offset = "0x48")]
	private string m_FatigueBuffCauseLocID;

	[Token(Token = "0x400511F")]
	[FieldOffset(Offset = "0x50")]
	private float m_FreezingBuffHoursRemaining;

	[Token(Token = "0x4005120")]
	[FieldOffset(Offset = "0x54")]
	private float m_FreezingBuffHoursDuration;

	[Token(Token = "0x4005121")]
	[FieldOffset(Offset = "0x58")]
	private float m_ConditionRestBuffHoursRemaining;

	[Token(Token = "0x4005122")]
	[FieldOffset(Offset = "0x5C")]
	private float m_ConditionRestBuffHoursDuration;

	[Token(Token = "0x4005123")]
	[FieldOffset(Offset = "0x60")]
	private string m_ConditionRestBuffCauseLocID;

	[Token(Token = "0x4005124")]
	[FieldOffset(Offset = "0x68")]
	private float m_PumpkinPieBuffHoursRemaining;

	[Token(Token = "0x4005125")]
	[FieldOffset(Offset = "0x6C")]
	private float m_PumpkinPieBuffHoursDuration;

	[Token(Token = "0x4005126")]
	[FieldOffset(Offset = "0x70")]
	private float m_ConditionPerHourHoursRemaining;

	[Token(Token = "0x4005127")]
	[FieldOffset(Offset = "0x74")]
	private float m_ConditionPerHourHoursDuration;

	[Token(Token = "0x4005128")]
	[FieldOffset(Offset = "0x78")]
	private List<IngestedCarryCapacityBuff> m_IngestedCarryCapacityBuffList;

	[Token(Token = "0x4005129")]
	[FieldOffset(Offset = "0x80")]
	private float m_ClimbingBuffSprainOddsModifier;

	[Token(Token = "0x400512A")]
	[FieldOffset(Offset = "0x84")]
	private float m_ClimbingBuffStaminaPerSecondModifier;

	[Token(Token = "0x400512B")]
	[FieldOffset(Offset = "0x88")]
	private float m_ClimbingBuffWeakIceTimeSecondsModifier;

	[Token(Token = "0x400512C")]
	[FieldOffset(Offset = "0x90")]
	private CarryingCapacityBuff.BuffValues m_CarryingCapacityBuffValues;

	[Token(Token = "0x400512D")]
	[FieldOffset(Offset = "0x98")]
	private List<GearItem> m_WornCarryingCapacityGearItemList;

	[Token(Token = "0x400512E")]
	[FieldOffset(Offset = "0xA0")]
	private List<GearItem> m_SpecialCarryingCapacityGearItemList;

	[Token(Token = "0x400512F")]
	[FieldOffset(Offset = "0xA8")]
	public float m_WetnessPercentPerHourLightSnow;

	[Token(Token = "0x4005130")]
	[FieldOffset(Offset = "0xAC")]
	public float m_WetnessPercentPerHourHeavySnow;

	[Token(Token = "0x4005131")]
	[FieldOffset(Offset = "0xB0")]
	public float m_WetnessPercentPerHourBlizzard;

	[Token(Token = "0x4005132")]
	[FieldOffset(Offset = "0xB4")]
	public float m_ClothingWeightWhenWornModifier;

	[Header("Audio (Clothing)")]
	[SerializeField]
	[Token(Token = "0x4005133")]
	[FieldOffset(Offset = "0xB8")]
	private List<ClothingRegionSwitchDefault> m_RegionSwitchDefaults;

	[HideInInspector]
	[Token(Token = "0x4005134")]
	[FieldOffset(Offset = "0xC0")]
	public float m_WarmthBonusFromClothing;

	[HideInInspector]
	[Token(Token = "0x4005135")]
	[FieldOffset(Offset = "0xC4")]
	public float m_WindproofBonusFromClothing;

	[Token(Token = "0x4005136")]
	private const int MAX_CLOTHING_REGIONS = 8;

	[Token(Token = "0x4005137")]
	private const int MAX_CLOTHING_LAYERS = 4;

	[Token(Token = "0x4005138")]
	[FieldOffset(Offset = "0xC8")]
	private readonly GearItem[,] m_Clothing;

	[Token(Token = "0x4005139")]
	[FieldOffset(Offset = "0xD0")]
	private readonly uint[] m_LastSoundSwitchByRegion;

	[Token(Token = "0x400513A")]
	[FieldOffset(Offset = "0xD8")]
	private readonly List<GearItem> m_GearItemList;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x400513B")]
	[FieldOffset(Offset = "0xE0")]
	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	[SerializeField]
	[Token(Token = "0x400513C")]
	[FieldOffset(Offset = "0xE8")]
	private PanelReference<Panel_Actions> m_Actions;

	[SerializeField]
	[Token(Token = "0x400513D")]
	[FieldOffset(Offset = "0xF0")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[SerializeField]
	[Token(Token = "0x400513E")]
	[FieldOffset(Offset = "0xF8")]
	private PanelReference<Panel_Affliction> m_Affliction;

	[SerializeField]
	[Token(Token = "0x400513F")]
	[FieldOffset(Offset = "0x100")]
	private PanelReference<Panel_BreakDown> m_BreakDown;

	[SerializeField]
	[Token(Token = "0x4005140")]
	[FieldOffset(Offset = "0x108")]
	private PanelReference<Panel_BodyHarvest> m_BodyHarvest;

	[SerializeField]
	[Token(Token = "0x4005141")]
	[FieldOffset(Offset = "0x110")]
	private PanelReference<Panel_CanOpening> m_CanOpening;

	[SerializeField]
	[Token(Token = "0x4005142")]
	[FieldOffset(Offset = "0x118")]
	private PanelReference<Panel_FireStart> m_FireStart;

	[SerializeField]
	[Token(Token = "0x4005143")]
	[FieldOffset(Offset = "0x120")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4005144")]
	[FieldOffset(Offset = "0x128")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[SerializeField]
	[Token(Token = "0x4005145")]
	[FieldOffset(Offset = "0x130")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4005146")]
	[FieldOffset(Offset = "0x138")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[SerializeField]
	[Token(Token = "0x4005147")]
	[FieldOffset(Offset = "0x140")]
	private PanelReference<Panel_Inventory_Examine> m_InventoryExamine;

	[SerializeField]
	[Token(Token = "0x4005148")]
	[FieldOffset(Offset = "0x148")]
	private PanelReference<Panel_InsulatedFlask> m_InsulatedFlask;

	[SerializeField]
	[Token(Token = "0x4005149")]
	[FieldOffset(Offset = "0x150")]
	private PanelReference<Panel_Loading> m_Loading;

	[SerializeField]
	[Token(Token = "0x400514A")]
	[FieldOffset(Offset = "0x158")]
	private PanelReference<Panel_Map> m_Map;

	[SerializeField]
	[Token(Token = "0x400514B")]
	[FieldOffset(Offset = "0x160")]
	private PanelReference<Panel_PauseMenu> m_PauseMenu;

	[SerializeField]
	[Token(Token = "0x400514C")]
	[FieldOffset(Offset = "0x168")]
	private PanelReference<Panel_PickWater> m_PickWater;

	[SerializeField]
	[Token(Token = "0x400514D")]
	[FieldOffset(Offset = "0x170")]
	private PanelReference<Panel_SnowShelterBuild> m_SnowShelterBuild;

	[SerializeField]
	[Token(Token = "0x400514E")]
	[FieldOffset(Offset = "0x178")]
	private PanelReference<Panel_SnowShelterInteract> m_SnowShelterInteract;

	[SerializeField]
	[Token(Token = "0x400514F")]
	[FieldOffset(Offset = "0x180")]
	private PanelReference<Panel_SprayPaint> m_SprayPaint;

	[SerializeField]
	[Token(Token = "0x4005150")]
	[FieldOffset(Offset = "0x188")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[Space]
	[HideInInspector]
	[Token(Token = "0x4005151")]
	[FieldOffset(Offset = "0x190")]
	public bool m_StartGearApplied;

	[HideInInspector]
	[Token(Token = "0x4005152")]
	[FieldOffset(Offset = "0x194")]
	public Vector3 m_SaveGamePosition;

	[HideInInspector]
	[Token(Token = "0x4005153")]
	[FieldOffset(Offset = "0x1A0")]
	public Quaternion m_SaveGameRotation;

	[HideInInspector]
	[Token(Token = "0x4005154")]
	[FieldOffset(Offset = "0x1B0")]
	public IndoorSpaceTrigger m_IndoorSpaceTrigger;

	[HideInInspector]
	[Token(Token = "0x4005155")]
	[FieldOffset(Offset = "0x1B8")]
	public List<StealthZoneTrigger> m_StealthZoneTriggers;

	[HideInInspector]
	[Token(Token = "0x4005156")]
	[FieldOffset(Offset = "0x1C0")]
	public bool m_DoTeleportAfterSceneLoad;

	[HideInInspector]
	[Token(Token = "0x4005157")]
	[FieldOffset(Offset = "0x1C1")]
	public bool m_InRunMode;

	[HideInInspector]
	[Token(Token = "0x4005158")]
	[FieldOffset(Offset = "0x1C2")]
	public bool m_Ghost;

	[HideInInspector]
	[Token(Token = "0x4005159")]
	[FieldOffset(Offset = "0x1C3")]
	public bool m_God;

	[HideInInspector]
	[Token(Token = "0x400515A")]
	[FieldOffset(Offset = "0x1C8")]
	public StartGear m_StartGear;

	[HideInInspector]
	[Token(Token = "0x400515B")]
	[FieldOffset(Offset = "0x1D0")]
	public AiTarget m_AiTarget;

	[HideInInspector]
	[Token(Token = "0x400515C")]
	[FieldOffset(Offset = "0x1D8")]
	public bool m_SceneTransitionStarted;

	[HideInInspector]
	[Token(Token = "0x400515D")]
	[FieldOffset(Offset = "0x1E0")]
	public List<int> m_KnownCodes;

	[HideInInspector]
	[Token(Token = "0x400515E")]
	[FieldOffset(Offset = "0x1E8")]
	public SerializableBounds m_LimitCampfiresToBounds;

	[HideInInspector]
	[Token(Token = "0x400515F")]
	[FieldOffset(Offset = "0x1F0")]
	public bool m_AllowPanelInteraction;

	[NonSerialized]
	[Token(Token = "0x4005160")]
	[FieldOffset(Offset = "0x1F1")]
	public bool m_ForceAIFlee;

	[NonSerialized]
	[Token(Token = "0x4005161")]
	[FieldOffset(Offset = "0x1F2")]
	public bool m_SuspendConditionUpdate;

	[NonSerialized]
	[Token(Token = "0x4005162")]
	[FieldOffset(Offset = "0x1F3")]
	public bool m_ForceHideDiscoveryText;

	[NonSerialized]
	[Token(Token = "0x4005163")]
	[FieldOffset(Offset = "0x1F4")]
	public bool m_DisableAllSpeech;

	[Token(Token = "0x4005164")]
	public static VoicePersona m_VoicePersona;

	[Token(Token = "0x4005165")]
	[FieldOffset(Offset = "0x1F8")]
	public List<ActionsToBlock> m_ActionsToBlockInDarkness;

	[Token(Token = "0x4005166")]
	[FieldOffset(Offset = "0x200")]
	public GameplayTag m_BlockRandomWeatherTag;

	[NonSerialized]
	[Token(Token = "0x4005167")]
	[FieldOffset(Offset = "0x210")]
	public bool m_FreezeMovement;

	[Token(Token = "0x4005168")]
	[FieldOffset(Offset = "0x214")]
	public float m_ChanceToPlayContainerInspectVO;

	[Token(Token = "0x4005169")]
	public static string m_ForceSpawnPointName;

	[Token(Token = "0x400516A")]
	public static bool m_PlayerDebug;

	[Token(Token = "0x400516B")]
	private static List<PlayerSpawnPoints> m_PlayerSpawnPoints;

	[Token(Token = "0x400516C")]
	[FieldOffset(Offset = "0x218")]
	public string m_KnockdownVO;

	[Token(Token = "0x400516D")]
	[FieldOffset(Offset = "0x220")]
	public float m_DamageAmountThresholdToStopAutoWalk;

	[SerializeField]
	[Token(Token = "0x400516E")]
	[FieldOffset(Offset = "0x224")]
	private float m_PlacementDistanceFromPlayerCamera;

	[Token(Token = "0x400516F")]
	private const float INTERIOR_SPAWN_RAYCAST_DISTANCE = 50f;

	[Token(Token = "0x4005170")]
	private const int STICK_TO_GROUND_STEPS = 10;

	[Token(Token = "0x4005171")]
	[FieldOffset(Offset = "0x228")]
	private PlayerControlMode m_ControlMode;

	[Token(Token = "0x4005172")]
	[FieldOffset(Offset = "0x22C")]
	private bool m_FirstFrame;

	[Token(Token = "0x4005173")]
	[FieldOffset(Offset = "0x230")]
	private float m_SwayTime;

	[Token(Token = "0x4005174")]
	[FieldOffset(Offset = "0x234")]
	private float m_SwayDuration;

	[Token(Token = "0x4005175")]
	[FieldOffset(Offset = "0x238")]
	private float m_SwayAngle;

	[Token(Token = "0x4005176")]
	[FieldOffset(Offset = "0x23C")]
	private float m_SwayTotal;

	[Token(Token = "0x4005177")]
	[FieldOffset(Offset = "0x240")]
	private float m_TimeSinceYawChange;

	[Token(Token = "0x4005178")]
	[FieldOffset(Offset = "0x244")]
	private float m_SwayPreviousYaw;

	[Token(Token = "0x4005179")]
	[FieldOffset(Offset = "0x248")]
	private bool m_SwayRight;

	[Token(Token = "0x400517A")]
	[FieldOffset(Offset = "0x249")]
	private bool m_CheatsUsed;

	[Token(Token = "0x400517B")]
	[FieldOffset(Offset = "0x24C")]
	private float m_LastClosestPredatorDistanceSentToWise;

	[Token(Token = "0x400517C")]
	[FieldOffset(Offset = "0x250")]
	private float m_LastPlayerElevationSentToWise;

	[Token(Token = "0x400517D")]
	[FieldOffset(Offset = "0x254")]
	private int m_DelayedSpawnAudioCountdown;

	[Token(Token = "0x400517E")]
	[FieldOffset(Offset = "0x258")]
	private string m_DelayedSpawnAudio;

	[Token(Token = "0x400517F")]
	[FieldOffset(Offset = "0x260")]
	private bool m_SkipDelaySpawnAudio;

	[Token(Token = "0x4005180")]
	[FieldOffset(Offset = "0x268")]
	private string m_LastPlayerGroundMaterialTag;

	[Token(Token = "0x4005181")]
	[FieldOffset(Offset = "0x270")]
	private CramponsState m_LastPlayerCramponsState;

	[Token(Token = "0x4005182")]
	[FieldOffset(Offset = "0x274")]
	private bool m_LastPlayerCramponsStateValid;

	[Token(Token = "0x4005183")]
	[FieldOffset(Offset = "0x275")]
	private bool m_TeleportPending;

	[Token(Token = "0x4005184")]
	[FieldOffset(Offset = "0x278")]
	private Vector3 m_TeleportPendingPosition;

	[Token(Token = "0x4005185")]
	[FieldOffset(Offset = "0x284")]
	private Quaternion m_TeleportPendingRotation;

	[Token(Token = "0x4005186")]
	[FieldOffset(Offset = "0x294")]
	private bool m_RestorePlayerToClosestSnowShelter;

	[Token(Token = "0x4005187")]
	[FieldOffset(Offset = "0x298")]
	private Vector3 m_RestoreSnowShelterPos;

	[Token(Token = "0x4005188")]
	[FieldOffset(Offset = "0x2A4")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4005189")]
	[FieldOffset(Offset = "0x2A5")]
	private bool m_ShowUnknownTimeOfDay;

	[Token(Token = "0x400518A")]
	[FieldOffset(Offset = "0x2A6")]
	private bool m_CachedUnstow;

	[Token(Token = "0x400518B")]
	[FieldOffset(Offset = "0x2A7")]
	private bool m_StatusBarsLocked;

	[Token(Token = "0x400518C")]
	[FieldOffset(Offset = "0x2A8")]
	private Vector3 m_LastPlayerPosition;

	[Token(Token = "0x400518D")]
	[FieldOffset(Offset = "0x2B4")]
	private Vector2 m_LastPlayerAngle;

	[Token(Token = "0x4005190")]
	[FieldOffset(Offset = "0x2BE")]
	private bool m_NearPlaneOverridden;

	[Token(Token = "0x4005191")]
	[FieldOffset(Offset = "0x2C0")]
	private int m_StickPlayerToGroundDelay;

	[Token(Token = "0x4005192")]
	[FieldOffset(Offset = "0x2C4")]
	private SceneLoadSource m_SceneLoadSource;

	[Token(Token = "0x4005193")]
	[FieldOffset(Offset = "0x2C8")]
	private List<IndoorSpaceTrigger> m_IndoorSpaceTriggers;

	[Token(Token = "0x4005194")]
	private static PlayerManagerSaveDataProxy m_PlayerManagerSaveDataProxy;

	[Token(Token = "0x4005195")]
	private static readonly LogFilter s_LogFilterPlayerManager;

	[HideInInspector]
	[Token(Token = "0x4005196")]
	[FieldOffset(Offset = "0x2D0")]
	public bool m_DebugDamage;

	[HideInInspector]
	[Token(Token = "0x4005197")]
	[FieldOffset(Offset = "0x2D1")]
	public bool m_DebugProjectile;

	[HideInInspector]
	[Token(Token = "0x4005198")]
	[FieldOffset(Offset = "0x2D2")]
	public bool m_DebugPosition;

	[HideInInspector]
	[Token(Token = "0x4005199")]
	[FieldOffset(Offset = "0x2D3")]
	public bool m_DebugLookAt;

	[HideInInspector]
	[Token(Token = "0x400519A")]
	[FieldOffset(Offset = "0x2D4")]
	public bool m_DebugLookAtHighlight;

	[Token(Token = "0x400519B")]
	[FieldOffset(Offset = "0x2D8")]
	private float m_DebugPositionSecondsToNextLog;

	[Token(Token = "0x400519C")]
	public static float m_DebugPositionLogDefaultFrequencyInSeconds;

	[Token(Token = "0x400519D")]
	[FieldOffset(Offset = "0x2DC")]
	public float m_DebugPositionLogFrequencyInSeconds;

	[HideInInspector]
	[Token(Token = "0x400519E")]
	[FieldOffset(Offset = "0x2E0")]
	public bool m_InspectingFromHarvestable;

	[HideInInspector]
	[Token(Token = "0x400519F")]
	[FieldOffset(Offset = "0x2E1")]
	public bool m_ReadingNote;

	[Token(Token = "0x40051A0")]
	[FieldOffset(Offset = "0x2E4")]
	public Vector2 m_InspectModeMouseSensitivity;

	[Token(Token = "0x40051A1")]
	[FieldOffset(Offset = "0x2EC")]
	public Vector2 m_InspectModeControllerSensitivity;

	[Token(Token = "0x40051A2")]
	[FieldOffset(Offset = "0x2F4")]
	public float m_TimeBeforeStow;

	[Token(Token = "0x40051A3")]
	[FieldOffset(Offset = "0x2F8")]
	private bool m_StowTriggered;

	[Token(Token = "0x40051A4")]
	[FieldOffset(Offset = "0x300")]
	private GearItem m_Gear;

	[Token(Token = "0x40051A5")]
	[FieldOffset(Offset = "0x308")]
	private Container m_Container;

	[Token(Token = "0x40051A6")]
	[FieldOffset(Offset = "0x310")]
	private IceFishingHole m_IceFishingHole;

	[Token(Token = "0x40051A7")]
	[FieldOffset(Offset = "0x318")]
	private Harvestable m_Harvestable;

	[Token(Token = "0x40051A8")]
	[FieldOffset(Offset = "0x320")]
	private CookingPotItem m_CookingPotItem;

	[Token(Token = "0x40051A9")]
	[FieldOffset(Offset = "0x328")]
	private Inspect m_Inspect;

	[Token(Token = "0x40051AA")]
	[FieldOffset(Offset = "0x330")]
	private Vector3 m_RestorePos;

	[Token(Token = "0x40051AB")]
	[FieldOffset(Offset = "0x33C")]
	private Quaternion m_RestoreRot;

	[Token(Token = "0x40051AC")]
	[FieldOffset(Offset = "0x34C")]
	private ShadowCastingMode m_RestoreCastsShadows;

	[Token(Token = "0x40051AD")]
	[FieldOffset(Offset = "0x350")]
	private bool m_CanAddToInventory;

	[Token(Token = "0x40051AE")]
	[FieldOffset(Offset = "0x351")]
	private bool m_PlayedInspectModeVoiceOver;

	[Token(Token = "0x40051AF")]
	[FieldOffset(Offset = "0x352")]
	private bool m_SkipRestoreItemInHandsOnExit;

	[Token(Token = "0x40051B0")]
	[FieldOffset(Offset = "0x358")]
	private float[] m_InspectFadeAlphas;

	[Token(Token = "0x40051B1")]
	[FieldOffset(Offset = "0x360")]
	private float m_TimeInInspectMode;

	[Token(Token = "0x40051B2")]
	[FieldOffset(Offset = "0x364")]
	private float m_FadeInAlphaTimer;

	[Token(Token = "0x40051B3")]
	[FieldOffset(Offset = "0x368")]
	private float m_StoredFieldOfView;

	[Token(Token = "0x40051B4")]
	[FieldOffset(Offset = "0x370")]
	private vp_FPSWeapon m_StoredWeapon;

	[Token(Token = "0x40051B5")]
	[FieldOffset(Offset = "0x378")]
	private Transform m_CachedParent;

	[Token(Token = "0x40051B6")]
	[FieldOffset(Offset = "0x380")]
	private Vector3 m_OriginalLocalScale;

	[Token(Token = "0x40051B7")]
	[FieldOffset(Offset = "0x38C")]
	private bool m_InspectModeActive;

	[Token(Token = "0x40051B8")]
	[FieldOffset(Offset = "0x390")]
	private int m_NoInteractionDuringInspectFrameCounter;

	[Token(Token = "0x40051B9")]
	[FieldOffset(Offset = "0x398")]
	private CallbackDelegate m_Callback;

	[Token(Token = "0x40051BA")]
	[FieldOffset(Offset = "0x3A0")]
	private Quaternion m_GearItemRotationInInspectSpace;

	[Token(Token = "0x40051BB")]
	[FieldOffset(Offset = "0x3B0")]
	private Vector3 m_GearItemPositionInInspectSpace;

	[Token(Token = "0x40051BC")]
	private const string m_LeaveItLocId = "GAMEPLAY_LeaveIt";

	[Token(Token = "0x40051BD")]
	[FieldOffset(Offset = "0x3C0")]
	private ItemLiquidVolume m_CurrentLiquidVolume;

	[Token(Token = "0x40051BE")]
	[FieldOffset(Offset = "0x3C8")]
	private Action m_EquipAction;

	[Token(Token = "0x40051BF")]
	[FieldOffset(Offset = "0x3D0")]
	private Action m_SecondaryAction;

	[Token(Token = "0x40051C0")]
	[FieldOffset(Offset = "0x3D8")]
	private Action m_PickupAction;

	[Token(Token = "0x40051C1")]
	[FieldOffset(Offset = "0x3E0")]
	private Action m_PutBackAction;

	[Token(Token = "0x40051C2")]
	[FieldOffset(Offset = "0x3E8")]
	private List<GearItem> m_MaybeShowGearItemOnMapLaterList;

	[HideInInspector]
	[Token(Token = "0x40051C3")]
	[FieldOffset(Offset = "0x3F0")]
	public Vector3 m_LocationOfLastInteractHit;

	[Token(Token = "0x40051C6")]
	[FieldOffset(Offset = "0x410")]
	private List<IInteraction> m_InteractionResults;

	[Token(Token = "0x40051C7")]
	[FieldOffset(Offset = "0x418")]
	private bool m_IsForcedInteractionActive;

	[Token(Token = "0x40051C8")]
	[FieldOffset(Offset = "0x419")]
	private bool m_IsHoldInteractionActive;

	[Token(Token = "0x40051C9")]
	[FieldOffset(Offset = "0x41C")]
	private PlayerControlMode m_InteractionRestoreControlMode;

	[Token(Token = "0x40051CA")]
	[FieldOffset(Offset = "0x420")]
	private bool m_EquipLastItemInHandsAfterInteraction;

	[Token(Token = "0x40051CB")]
	[FieldOffset(Offset = "0x421")]
	private bool m_RaiseItemInHandsAfterInteraction;

	[Token(Token = "0x40051CC")]
	[FieldOffset(Offset = "0x422")]
	public bool m_ItemInHandsRestorePending;

	[Token(Token = "0x40051CD")]
	[FieldOffset(Offset = "0x423")]
	private bool m_PickupIsImmediate;

	[HideInInspector]
	[Token(Token = "0x40051CE")]
	[FieldOffset(Offset = "0x428")]
	public GearItem m_PickupGearItem;

	[Token(Token = "0x40051CF")]
	private const int MAX_SPHERECAST_HITS = 16;

	[Token(Token = "0x40051D0")]
	[FieldOffset(Offset = "0x430")]
	private RaycastHit[] m_SphereCastHits;

	[Token(Token = "0x40051D1")]
	[FieldOffset(Offset = "0x438")]
	private bool m_DoInteractionEndNextFrame;

	[Token(Token = "0x40051D2")]
	[FieldOffset(Offset = "0x440")]
	private List<MeshCollider> m_MeshColliders;

	[Token(Token = "0x40051D3")]
	[FieldOffset(Offset = "0x448")]
	private List<Transform> m_Transforms;

	[Token(Token = "0x40051D4")]
	[FieldOffset(Offset = "0x450")]
	private PlayerControlMode m_ControlModeAtTimeOfPickup;

	[Tooltip("If there's no stackable item component on a gear item, use this condition value as default")]
	[Token(Token = "0x40051D5")]
	[FieldOffset(Offset = "0x454")]
	public float m_FallbackStackConditionDifferenceConstaint;

	[HideInInspector]
	[Token(Token = "0x40051D6")]
	[FieldOffset(Offset = "0x458")]
	public GearItem m_LastUnequippedItem;

	[HideInInspector]
	[Token(Token = "0x40051D7")]
	[FieldOffset(Offset = "0x460")]
	public bool m_UsedItemFromFirstAidPanel;

	[Token(Token = "0x40051D8")]
	[FieldOffset(Offset = "0x461")]
	private bool m_ActionInProgress;

	[Token(Token = "0x40051D9")]
	private static readonly LogFilter s_LogFilter;

	[HideInInspector]
	[Token(Token = "0x40051DA")]
	[FieldOffset(Offset = "0x468")]
	private GearItem m_ItemInHandsInternal;

	[SerializeField]
	[Token(Token = "0x40051DB")]
	[FieldOffset(Offset = "0x470")]
	private string m_TreatmentSuccessAudio;

	[SerializeField]
	[Token(Token = "0x40051DC")]
	[FieldOffset(Offset = "0x478")]
	private string m_TreatmentFailedAudio;

	[SerializeField]
	[Token(Token = "0x40051DD")]
	[FieldOffset(Offset = "0x480")]
	private GameplayTag m_OralMedicationTag;

	[Token(Token = "0x40051DE")]
	[FieldOffset(Offset = "0x490")]
	private bool m_FoodPoisoningOnEatingComplete;

	[Token(Token = "0x40051DF")]
	[FieldOffset(Offset = "0x498")]
	private WaterSupply m_WaterSourceToDrinkFrom;

	[Token(Token = "0x40051E0")]
	[FieldOffset(Offset = "0x4A0")]
	private ItemLiquidVolume m_WaterToDrinkLiters;

	[Token(Token = "0x40051E1")]
	[FieldOffset(Offset = "0x4A8")]
	private float m_HealingOnFirstAidComplete;

	[Token(Token = "0x40051E2")]
	[FieldOffset(Offset = "0x4B0")]
	private FirstAidItem m_FirstAidItemUsed;

	[Token(Token = "0x40051E3")]
	[FieldOffset(Offset = "0x4B8")]
	private Affliction m_AfflictionSelected;

	[Token(Token = "0x40051E4")]
	[FieldOffset(Offset = "0x4D0")]
	private GearItem m_PurifyWaterItemUsed;

	[Token(Token = "0x40051E5")]
	[FieldOffset(Offset = "0x4D8")]
	private GearItem m_SmashableItemUsed;

	[Token(Token = "0x40051E6")]
	[FieldOffset(Offset = "0x4E0")]
	private GearItem m_FoodItemOpened;

	[Token(Token = "0x40051E7")]
	[FieldOffset(Offset = "0x4E8")]
	private GearItem m_FoodItemEaten;

	[Token(Token = "0x40051E8")]
	[FieldOffset(Offset = "0x4F0")]
	private GearItem m_EmergencyStimUsed;

	[Token(Token = "0x40051E9")]
	[FieldOffset(Offset = "0x4F8")]
	private GearItem m_HeatPadUsed;

	[Token(Token = "0x40051EA")]
	[FieldOffset(Offset = "0x500")]
	private float m_FoodItemEatenStartingCalories;

	[Token(Token = "0x40051EB")]
	[FieldOffset(Offset = "0x508")]
	private ItemWeight m_FoodItemEatenStartingWeight;

	[Token(Token = "0x40051EC")]
	[FieldOffset(Offset = "0x510")]
	private GearItem m_QueuedEquipItem;

	[Token(Token = "0x40051ED")]
	[FieldOffset(Offset = "0x518")]
	private bool m_HasSavedItemInHands;

	[Token(Token = "0x40051EE")]
	[FieldOffset(Offset = "0x519")]
	private bool m_RestoreSavedItemInHandsPending;

	[Token(Token = "0x40051EF")]
	[FieldOffset(Offset = "0x51C")]
	private Vector3 m_LastDropCheckPosition;

	[Token(Token = "0x40051F0")]
	[FieldOffset(Offset = "0x528")]
	private bool m_LastDropCheckResult;

	[Token(Token = "0x40051F1")]
	[FieldOffset(Offset = "0x530")]
	private Collider[] m_DropCheckColliders;

	[HideInInspector]
	[Token(Token = "0x40051F2")]
	[FieldOffset(Offset = "0x538")]
	public HeldItemRestriction m_HeldItemRestriction;

	[Token(Token = "0x40051F3")]
	[FieldOffset(Offset = "0x540")]
	private bool m_IsLookAtTargetForTimeActive;

	[Token(Token = "0x40051F4")]
	[FieldOffset(Offset = "0x544")]
	private LookAtTargetForTime m_LookAtTargetForTime;

	[SerializeField]
	[Token(Token = "0x40051F5")]
	[FieldOffset(Offset = "0x588")]
	private Color m_DecalPlacementValidColour;

	[SerializeField]
	[Token(Token = "0x40051F6")]
	[FieldOffset(Offset = "0x598")]
	private Color m_DecalPlacementValidInRangeOfTransitionColour;

	[SerializeField]
	[Token(Token = "0x40051F7")]
	[FieldOffset(Offset = "0x5A8")]
	private Color m_DecalPlacementInvalidColour;

	[SerializeField]
	[Token(Token = "0x40051F8")]
	[FieldOffset(Offset = "0x5B8")]
	private Color m_DecalPlacementOnTopOfAnotherColour;

	[SerializeField]
	[Token(Token = "0x40051F9")]
	[FieldOffset(Offset = "0x5C8")]
	private DecalColourInfo[] m_DecalColours;

	[SerializeField]
	[Token(Token = "0x40051FA")]
	[FieldOffset(Offset = "0x5D0")]
	private string m_StopPaintAudioID;

	[SerializeField]
	[Token(Token = "0x40051FB")]
	[FieldOffset(Offset = "0x5D8")]
	private string m_StopEraseAudioID;

	[Token(Token = "0x40051FC")]
	[FieldOffset(Offset = "0x5E0")]
	public float m_PlaceDecalRotationDegreesPerSecond;

	[Token(Token = "0x40051FD")]
	[FieldOffset(Offset = "0x5E4")]
	public float m_PlaceDecalMouseWheelRotationDegrees;

	[Token(Token = "0x40051FE")]
	[FieldOffset(Offset = "0x5E8")]
	private ProjectileType m_DecalToPlaceShape;

	[Token(Token = "0x40051FF")]
	[FieldOffset(Offset = "0x5EC")]
	private DecalColour m_DecalToPlaceColour;

	[Token(Token = "0x4005200")]
	[FieldOffset(Offset = "0x5F0")]
	private DecalProjectorInstance m_DecalToPlace;

	[Token(Token = "0x4005201")]
	[FieldOffset(Offset = "0x5F8")]
	private DecalProjectorInstance m_DecalToErase;

	[Token(Token = "0x4005202")]
	[FieldOffset(Offset = "0x600")]
	private DecalProjectorInstance m_CurrentOverlappingDecal;

	[Token(Token = "0x4005203")]
	[FieldOffset(Offset = "0x608")]
	private GearItem m_DecalPlacementGearItem;

	[NonSerialized]
	[Token(Token = "0x4005204")]
	[FieldOffset(Offset = "0x610")]
	public bool m_HasEverSprayPainted;

	[Token(Token = "0x4005205")]
	private const float WALL_PLACEMENT_OFFSET_DISTANCE = 0.01f;

	[Token(Token = "0x4005206")]
	[FieldOffset(Offset = "0x614")]
	public float m_DefaultPlacementDistance;

	[Token(Token = "0x4005207")]
	[FieldOffset(Offset = "0x618")]
	public float m_FarPlacementDistanceMultiplier;

	[Token(Token = "0x4005208")]
	[FieldOffset(Offset = "0x61C")]
	public float m_MaxSlopeDegreesForPlacement;

	[Token(Token = "0x4005209")]
	[FieldOffset(Offset = "0x620")]
	public float m_PlaceMeshRotationDegreesPerSecond;

	[Token(Token = "0x400520A")]
	[FieldOffset(Offset = "0x624")]
	public float m_PlaceMeshMouseWheelRotationDegrees;

	[Token(Token = "0x400520B")]
	[FieldOffset(Offset = "0x628")]
	public GameObject m_OscarPrefab;

	[SerializeField]
	[Range(0f, 45f)]
	[Token(Token = "0x400520C")]
	[FieldOffset(Offset = "0x630")]
	private float m_FloorUpAngleToleranceDegrees;

	[SerializeField]
	[Range(0f, 45f)]
	[Token(Token = "0x400520D")]
	[FieldOffset(Offset = "0x634")]
	private float m_WallUpAngleToleranceDegrees;

	[SerializeField]
	[Token(Token = "0x400520E")]
	[FieldOffset(Offset = "0x638")]
	private float m_BlockPlacementColliderBoxCastDistance;

	[Token(Token = "0x400520F")]
	[FieldOffset(Offset = "0x640")]
	private GameObject m_ObjectToPlace;

	[Token(Token = "0x4005210")]
	[FieldOffset(Offset = "0x648")]
	private readonly List<Collider> m_ObjectToPlaceColliders;

	[Token(Token = "0x4005211")]
	[FieldOffset(Offset = "0x650")]
	private readonly List<Renderer> m_ObjectToPlaceRenderers;

	[Token(Token = "0x4005212")]
	[FieldOffset(Offset = "0x658")]
	private readonly List<BoxCollider> m_ObjectToPlaceBoxColliders;

	[Token(Token = "0x4005213")]
	[FieldOffset(Offset = "0x660")]
	private readonly List<Collider> m_ObjectToPlaceIgnoreColliders;

	[Token(Token = "0x4005214")]
	[FieldOffset(Offset = "0x668")]
	private GearItem m_ObjectToPlaceGearItem;

	[Token(Token = "0x4005215")]
	[FieldOffset(Offset = "0x670")]
	private Campfire m_ObjectToPlaceCampfire;

	[Token(Token = "0x4005216")]
	[FieldOffset(Offset = "0x678")]
	private Bed m_ObjectToPlaceBed;

	[Token(Token = "0x4005217")]
	[FieldOffset(Offset = "0x680")]
	private SnowShelter m_ObjectToPlaceSnowShelter;

	[Token(Token = "0x4005218")]
	[FieldOffset(Offset = "0x688")]
	private RockCache m_ObjectToPlaceRockCache;

	[Token(Token = "0x4005219")]
	[FieldOffset(Offset = "0x690")]
	private RadialObjectSpawner m_ObjectToPlaceRadialSpawner;

	[Token(Token = "0x400521A")]
	[FieldOffset(Offset = "0x698")]
	private BigCarryItem m_ObjectToPlaceBigCarryItem;

	[Token(Token = "0x400521B")]
	[FieldOffset(Offset = "0x6A0")]
	private IceFishingHole m_ObjectToPlaceIceFishingHole;

	[Token(Token = "0x400521C")]
	[FieldOffset(Offset = "0x6A8")]
	private DecorationItem m_ObjectToPlaceDecorationItem;

	[Token(Token = "0x400521D")]
	[FieldOffset(Offset = "0x6B0")]
	private List<Collider> m_SafehouseIndoorSpaceTriggers;

	[Token(Token = "0x400521E")]
	[FieldOffset(Offset = "0x6B8")]
	private readonly List<DecorationItemPlacementInfo> m_DecorationItemChain;

	[Token(Token = "0x400521F")]
	[FieldOffset(Offset = "0x6C0")]
	private BoxCollider m_ProxyCollisionVolume;

	[Token(Token = "0x4005220")]
	[FieldOffset(Offset = "0x6C8")]
	private MaterialPropertyBlock m_ValidTintMaterialPropertyBlock;

	[Token(Token = "0x4005221")]
	[FieldOffset(Offset = "0x6D0")]
	private MaterialPropertyBlock m_InvalidTintMaterialPropertyBlock;

	[Token(Token = "0x4005222")]
	[FieldOffset(Offset = "0x6D8")]
	private MeshLocationCategory m_MeshLocationCategory;

	[Token(Token = "0x4005223")]
	[FieldOffset(Offset = "0x6DC")]
	private bool m_PendingMeshPlacement;

	[Token(Token = "0x4005224")]
	[FieldOffset(Offset = "0x6E0")]
	private float m_PendingMeshPlacementElapsedTime;

	[Token(Token = "0x4005225")]
	[FieldOffset(Offset = "0x6E4")]
	private float m_UnmodifiedPlacementDistance;

	[Token(Token = "0x4005226")]
	[FieldOffset(Offset = "0x6E8")]
	private float m_PlacementDistance;

	[Token(Token = "0x4005227")]
	[FieldOffset(Offset = "0x6EC")]
	private float m_PlacementDistanceFar;

	[Token(Token = "0x4005228")]
	[FieldOffset(Offset = "0x6F0")]
	private bool m_PlacedMesh;

	[Token(Token = "0x4005229")]
	[FieldOffset(Offset = "0x6F8")]
	private GearPlacePoint m_LastGearPlacePoint;

	[Token(Token = "0x400522A")]
	[FieldOffset(Offset = "0x700")]
	private Bed m_LastBed;

	[Token(Token = "0x400522B")]
	[FieldOffset(Offset = "0x708")]
	private string m_LastHitSurfaceTag;

	[Token(Token = "0x400522C")]
	[FieldOffset(Offset = "0x710")]
	private Transform m_RestoreParent;

	[Token(Token = "0x400522D")]
	[FieldOffset(Offset = "0x718")]
	private Vector3 m_RestorePosition;

	[Token(Token = "0x400522E")]
	[FieldOffset(Offset = "0x724")]
	private Quaternion m_RestoreRotation;

	[Token(Token = "0x400522F")]
	[FieldOffset(Offset = "0x734")]
	private int m_RestoreLayer;

	[Token(Token = "0x4005230")]
	[FieldOffset(Offset = "0x738")]
	private DecorationItem m_PossibleDecorationParent;

	[Token(Token = "0x4005231")]
	[FieldOffset(Offset = "0x740")]
	private Quaternion m_RotationInCameraSpace;

	[Token(Token = "0x4005232")]
	[FieldOffset(Offset = "0x750")]
	private bool m_SkipCancel;

	[Token(Token = "0x4005233")]
	[FieldOffset(Offset = "0x751")]
	private bool m_IsPlacingCookableOnCookingSlot;

	[Token(Token = "0x4005234")]
	[FieldOffset(Offset = "0x754")]
	private PlaceMeshFlags m_PlaceFlags;

	[Token(Token = "0x4005235")]
	[FieldOffset(Offset = "0x758")]
	private PlaceMeshRules m_PlaceRules;

	[Token(Token = "0x4005236")]
	private static float s_FloorPlacementNormalThreshold;

	[Token(Token = "0x4005237")]
	private static float s_WallPlacementNormalThreshold;

	[Token(Token = "0x4005238")]
	[FieldOffset(Offset = "0x760")]
	private BlockPlacement m_LastBlockedPlacement;

	[Token(Token = "0x4005239")]
	[FieldOffset(Offset = "0x768")]
	private float m_RotationAngle;

	[Token(Token = "0x400523A")]
	[FieldOffset(Offset = "0x76C")]
	private bool m_AlreadyPlaced;

	[Token(Token = "0x400523B")]
	[FieldOffset(Offset = "0x770")]
	private WaitForCollisionOverlaps m_WaitForCollisionOverlaps;

	[Token(Token = "0x400523C")]
	[FieldOffset(Offset = "0x778")]
	private Coroutine m_ActiveWaitForCollisionOverlaps;

	[Token(Token = "0x400523D")]
	[FieldOffset(Offset = "0x780")]
	private readonly List<Renderer> m_TintedRenderers;

	[Token(Token = "0x400523E")]
	private static int s_BuildingsLayer;

	[Token(Token = "0x400523F")]
	private static readonly Color s_DefaultMeshPlacementValidColour;

	[Token(Token = "0x4005240")]
	private static readonly Color s_DefaultMeshPlacementInvalidColour;

	[Token(Token = "0x4005241")]
	private static Color s_CurrentMeshPlacementValidColour;

	[Token(Token = "0x4005242")]
	private static Color s_CurrentMeshPlacementInvalidColour;

	[Token(Token = "0x4005243")]
	[FieldOffset(Offset = "0x788")]
	private GearItem m_ThrownItem;

	[Token(Token = "0x4005244")]
	[FieldOffset(Offset = "0x790")]
	public float m_ThrowForce;

	[Token(Token = "0x4005245")]
	[FieldOffset(Offset = "0x794")]
	public float m_ThrowTorque;

	[Token(Token = "0x4005246")]
	[FieldOffset(Offset = "0x798")]
	protected vp_Timer m_ThrowTimer;

	[Token(Token = "0x1700032F")]
	[field: Token(Token = "0x400518E")]
	[field: FieldOffset(Offset = "0x2BC")]
	public bool PlayerHasMoved
	{
		[Token(Token = "0x6004751")]
		[Address(RVA = "0xCB9630", Offset = "0xCB8430", Length = "0x8")]
		get;
		[Token(Token = "0x6004752")]
		[Address(RVA = "0xCB9640", Offset = "0xCB8440", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x17000330")]
	[field: Token(Token = "0x400518F")]
	[field: FieldOffset(Offset = "0x2BD")]
	public bool PlayerHasTurned
	{
		[Token(Token = "0x6004753")]
		[Address(RVA = "0xCB9650", Offset = "0xCB8450", Length = "0x8")]
		get;
		[Token(Token = "0x6004754")]
		[Address(RVA = "0xCB9660", Offset = "0xCB8460", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x17000331")]
	public int IndoorSpaceTriggerCount
	{
		[Token(Token = "0x6004755")]
		[Address(RVA = "0xCB9670", Offset = "0xCB8470", Length = "0x44")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000332")]
	[field: Token(Token = "0x40051C4")]
	[field: FieldOffset(Offset = "0x400")]
	public IInteraction ActiveInteraction
	{
		[Token(Token = "0x60047F2")]
		[Address(RVA = "0xCD1650", Offset = "0xCD0450", Length = "0x8")]
		get;
		[Token(Token = "0x60047F3")]
		[Address(RVA = "0xCD1660", Offset = "0xCD0460", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000333")]
	[field: Token(Token = "0x40051C5")]
	[field: FieldOffset(Offset = "0x408")]
	public bool IsInteractionNearCrosshair
	{
		[Token(Token = "0x60047F4")]
		[Address(RVA = "0xCD16C0", Offset = "0xCD04C0", Length = "0x8")]
		get;
		[Token(Token = "0x60047F5")]
		[Address(RVA = "0xCD16D0", Offset = "0xCD04D0", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x17000334")]
	public bool IsActionInProgress
	{
		[Token(Token = "0x6004821")]
		[Address(RVA = "0xCD8710", Offset = "0xCD7510", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6004822")]
		[Address(RVA = "0xCD8720", Offset = "0xCD7520", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000335")]
	public GearItem m_ItemInHands
	{
		[Token(Token = "0x6004823")]
		[Address(RVA = "0xCD8730", Offset = "0xCD7530", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004824")]
		[Address(RVA = "0xCD8740", Offset = "0xCD7540", Length = "0x561")]
		set
		{
		}
	}

	[Token(Token = "0x17000336")]
	public string LastHitSurfaceTag
	{
		[Token(Token = "0x600489A")]
		[Address(RVA = "0xCF0A10", Offset = "0xCEF810", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000337")]
	public static float FloorPlacementNormalThreshold
	{
		[Token(Token = "0x600489B")]
		[Address(RVA = "0xCF0A20", Offset = "0xCEF820", Length = "0x55")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000338")]
	public static float WallPlacementNormalThreshold
	{
		[Token(Token = "0x600489C")]
		[Address(RVA = "0xCF0A80", Offset = "0xCEF880", Length = "0x55")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x60046ED")]
	[Address(RVA = "0xCB1B60", Offset = "0xCB0960", Length = "0xAC")]
	public void ApplyPumpkinPieBuff(float instantPercentDecrease, float rateScale, float durationHours, float durationMaxHours)
	{
	}

	[Token(Token = "0x60046EE")]
	[Address(RVA = "0xCB1C10", Offset = "0xCB0A10", Length = "0xC9")]
	public void ApplyFreezingBuff(float instantPercentDecrease, float rateScale, float durationHours, float durationMaxHours)
	{
	}

	[Token(Token = "0x60046EF")]
	[Address(RVA = "0xCB1CE0", Offset = "0xCB0AE0", Length = "0x11D")]
	public void ApplyFatigueBuff(float instantPercentDecrease, float rateScale, float durationHours, string causeLocID, float durationMaxHours)
	{
	}

	[Token(Token = "0x60046F0")]
	[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
	public string GetFatigueBuffCauseLocID()
	{
		return null;
	}

	[Token(Token = "0x60046F1")]
	[Address(RVA = "0xCB1E00", Offset = "0xCB0C00", Length = "0x64")]
	public void ApplyConditionRestBuff(float percentBonus, float restHours, float durationMaxHours, string causeLocID)
	{
	}

	[Token(Token = "0x60046F2")]
	[Address(RVA = "0xCB1E70", Offset = "0xCB0C70", Length = "0x26")]
	public void ApplyConditionOverTimeBuff(float conditionPerHourBonus, float numHours, float durationMaxHours)
	{
	}

	[Token(Token = "0x60046F3")]
	[Address(RVA = "0xCB1EA0", Offset = "0xCB0CA0", Length = "0xB")]
	public void ApplyWolfIntimidationBuff(float increaseFleePercentagePoints, float decreaseAttackChancePercentagePoints)
	{
	}

	[Token(Token = "0x60046F4")]
	[Address(RVA = "0xCB1EB0", Offset = "0xCB0CB0", Length = "0x7")]
	public void RemoveWolfIntimidationBuff()
	{
	}

	[Token(Token = "0x60046F5")]
	[Address(RVA = "0xCB1EC0", Offset = "0xCB0CC0", Length = "0x7E")]
	public void ApplyCarryingCapacityBuff(CarryingCapacityBuff.BuffValues values)
	{
	}

	[Token(Token = "0x60046F6")]
	[Address(RVA = "0xCB1F40", Offset = "0xCB0D40", Length = "0x1CD")]
	public void ApplyIngestedCarryCapacityBuff(ItemWeight buff, float durationHours, string typeLocId)
	{
	}

	[Token(Token = "0x60046F7")]
	[Address(RVA = "0xCB2110", Offset = "0xCB0F10", Length = "0x262")]
	public bool HasSpecialCarryingCapacityGear(GearItemData gearItemData)
	{
		return false;
	}

	[Token(Token = "0x60046F8")]
	[Address(RVA = "0xCB2380", Offset = "0xCB1180", Length = "0x6B")]
	public void RemoveCarryingCapacityBuff()
	{
	}

	[Token(Token = "0x60046F9")]
	[Address(RVA = "0xCB23F0", Offset = "0xCB11F0", Length = "0x6C6")]
	public void UpdateCarryingBuff()
	{
	}

	[Token(Token = "0x60046FA")]
	[Address(RVA = "0xCB2AC0", Offset = "0xCB18C0", Length = "0x19A")]
	public bool HasIngestedCarryCapacityBuff()
	{
		return false;
	}

	[Token(Token = "0x60046FB")]
	[Address(RVA = "0xCB2C60", Offset = "0xCB1A60", Length = "0x19A")]
	public bool HasIngestedCarryCapacityDebuff()
	{
		return false;
	}

	[Token(Token = "0x60046FC")]
	[Address(RVA = "0xCB2E00", Offset = "0xCB1C00", Length = "0x3E")]
	public float GetIngestedCarryCapacityBuffDuration()
	{
		return 0f;
	}

	[Token(Token = "0x60046FD")]
	[Address(RVA = "0xCB2E40", Offset = "0xCB1C40", Length = "0x43")]
	public float GetIngestedCarryCapacityBuffDurationNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x60046FE")]
	[Address(RVA = "0xCB2E90", Offset = "0xCB1C90", Length = "0x3E")]
	public float GetIngestedCarryCapacityDebuffDuration()
	{
		return 0f;
	}

	[Token(Token = "0x60046FF")]
	[Address(RVA = "0xCB2ED0", Offset = "0xCB1CD0", Length = "0x43")]
	public float GetIngestedCarryCapacityDebuffDurationNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x6004700")]
	[Address(RVA = "0xCB2F20", Offset = "0xCB1D20", Length = "0x32E")]
	private void GetBestIngestedCarryCapacityBuffAndDebuff(out IngestedCarryCapacityBuff bestBuff, out IngestedCarryCapacityBuff bestDebuff)
	{
		bestBuff = null;
		bestDebuff = null;
	}

	[Token(Token = "0x6004701")]
	[Address(RVA = "0xCB3250", Offset = "0xCB2050", Length = "0x111")]
	private void MaybeApplyIngestedCarryCapacityBuffAndDebuff()
	{
	}

	[Token(Token = "0x6004702")]
	[Address(RVA = "0xCB3370", Offset = "0xCB2170", Length = "0x33E")]
	private void UpdateBuffDurations(Panel_HUD hud, float realtimeSeconds)
	{
	}

	[Token(Token = "0x6004703")]
	[Address(RVA = "0xCB36B0", Offset = "0xCB24B0", Length = "0x1F5")]
	private void UpdateIngestedCarryCapacityBuffs(Panel_HUD hud, float hoursDelta)
	{
	}

	[Token(Token = "0x6004704")]
	[Address(RVA = "0xCB38B0", Offset = "0xCB26B0", Length = "0x1BF")]
	public void UpdateConditonBuffDuration(float realtimeSeconds)
	{
	}

	[Token(Token = "0x6004705")]
	[Address(RVA = "0xCB3A70", Offset = "0xCB2870", Length = "0x54")]
	public bool IsPumpkinPieBuffActive()
	{
		return false;
	}

	[Token(Token = "0x6004706")]
	[Address(RVA = "0xCB3AD0", Offset = "0xCB28D0", Length = "0x7E")]
	public float GetFreezingRateScaleBuff()
	{
		return 0f;
	}

	[Token(Token = "0x6004707")]
	[Address(RVA = "0xCB3B50", Offset = "0xCB2950", Length = "0x1C")]
	public float GetFatigueRateScaleBuff()
	{
		return 0f;
	}

	[Token(Token = "0x6004708")]
	[Address(RVA = "0xCB3B70", Offset = "0xCB2970", Length = "0x13")]
	public float GetConditionPercentBonus()
	{
		return 0f;
	}

	[Token(Token = "0x6004709")]
	[Address(RVA = "0x5093E0", Offset = "0x5081E0", Length = "0x6")]
	public float GetWolfFleeIncreasePercentagePointsBuff()
	{
		return 0f;
	}

	[Token(Token = "0x600470A")]
	[Address(RVA = "0x509500", Offset = "0x508300", Length = "0x6")]
	public float GetWolfDecreaseAttackChancePercentagePointsBuff()
	{
		return 0f;
	}

	[Token(Token = "0x600470B")]
	[Address(RVA = "0xCB3B90", Offset = "0xCB2990", Length = "0x67")]
	public bool FreezingBuffActive()
	{
		return false;
	}

	[Token(Token = "0x600470C")]
	[Address(RVA = "0xCB3C00", Offset = "0xCB2A00", Length = "0xF")]
	public bool FatigueBuffActive()
	{
		return false;
	}

	[Token(Token = "0x600470D")]
	[Address(RVA = "0xCB3C10", Offset = "0xCB2A10", Length = "0x132")]
	public ItemWeight GetCarryCapacityKGBuff()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x600470E")]
	[Address(RVA = "0xCB3D50", Offset = "0xCB2B50", Length = "0x13")]
	public float GetConditionPerHourBonus()
	{
		return 0f;
	}

	[Token(Token = "0x600470F")]
	[Address(RVA = "0xCB3D70", Offset = "0xCB2B70", Length = "0x1D")]
	public void RemoveBuffsCONSOLE()
	{
	}

	[Token(Token = "0x6004710")]
	[Address(RVA = "0x86B4D0", Offset = "0x86A2D0", Length = "0x6")]
	public float GetFatigueBuffTimeRemainingHours()
	{
		return 0f;
	}

	[Token(Token = "0x6004711")]
	[Address(RVA = "0xCB3D90", Offset = "0xCB2B90", Length = "0x8")]
	public void ResetFatigueBuffTimeRemainingHours()
	{
	}

	[Token(Token = "0x6004712")]
	[Address(RVA = "0xCB3DA0", Offset = "0xCB2BA0", Length = "0x17")]
	public float GetFatigueBuffTimeRemainingNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x6004713")]
	[Address(RVA = "0x4B4350", Offset = "0x4B3150", Length = "0x6")]
	public float GetFreezingBuffTimeRemainingHours()
	{
		return 0f;
	}

	[Token(Token = "0x6004714")]
	[Address(RVA = "0xCB3DC0", Offset = "0xCB2BC0", Length = "0x17")]
	public float GetFreezingBuffTimeRemainingNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x6004715")]
	[Address(RVA = "0x5094E0", Offset = "0x5082E0", Length = "0x6")]
	public float GetConditionRestBuffTimeRemainingHours()
	{
		return 0f;
	}

	[Token(Token = "0x6004716")]
	[Address(RVA = "0xCB3DE0", Offset = "0xCB2BE0", Length = "0x17")]
	public float GetConditionRestBuffTimeRemainingNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x6004717")]
	[Address(RVA = "0xCB3E00", Offset = "0xCB2C00", Length = "0x46")]
	public string GetConditionRestBuffCauseLocID()
	{
		return null;
	}

	[Token(Token = "0x6004718")]
	[Address(RVA = "0x502590", Offset = "0x501390", Length = "0x6")]
	public float GetPumpkinPieBuffTimeRemainingHours()
	{
		return 0f;
	}

	[Token(Token = "0x6004719")]
	[Address(RVA = "0xCB3E50", Offset = "0xCB2C50", Length = "0x17")]
	public float GetPumpkinPieBuffTimeRemainingNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x600471A")]
	[Address(RVA = "0x561BD0", Offset = "0x5609D0", Length = "0x6")]
	public float GetConditionPerHourTimeRemainingHours()
	{
		return 0f;
	}

	[Token(Token = "0x600471B")]
	[Address(RVA = "0xCB3E70", Offset = "0xCB2C70", Length = "0x17")]
	public float GetConditionPerHourRemainingNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x600471C")]
	[Address(RVA = "0xCB3E90", Offset = "0xCB2C90", Length = "0x2E")]
	public void ApplyClimbingBuff(ClimbingBuff cb)
	{
	}

	[Token(Token = "0x600471D")]
	[Address(RVA = "0xCB3EC0", Offset = "0xCB2CC0", Length = "0x16")]
	public void RemoveClimbingBuff()
	{
	}

	[Token(Token = "0x600471E")]
	[Address(RVA = "0xCB3EE0", Offset = "0xCB2CE0", Length = "0x11F")]
	public void UpdateClimbingBuff()
	{
	}

	[Token(Token = "0x600471F")]
	[Address(RVA = "0xCB4000", Offset = "0xCB2E00", Length = "0x9")]
	public float GetClimbingBuffSprainOddsModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6004720")]
	[Address(RVA = "0x760E20", Offset = "0x75FC20", Length = "0x9")]
	public float GetClimbingBuffStaminaPerSecondModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6004721")]
	[Address(RVA = "0x760E30", Offset = "0x75FC30", Length = "0x9")]
	public float GetClimbingBuffWeakIceTimeSecondsModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6004722")]
	[Address(RVA = "0xCB4010", Offset = "0xCB2E10", Length = "0x6E")]
	public void ResetAllBuffsTimeRemaining()
	{
	}

	[Token(Token = "0x6004723")]
	[Address(RVA = "0xCB4080", Offset = "0xCB2E80", Length = "0x38")]
	public static int GetNumLayersForClothingRegion(ClothingRegion clothingRegion)
	{
		return 0;
	}

	[Token(Token = "0x6004724")]
	[Address(RVA = "0xCB40E0", Offset = "0xCB2EE0", Length = "0xDC")]
	public float GetWetnessIncreasePerHour()
	{
		return 0f;
	}

	[Token(Token = "0x6004725")]
	[Address(RVA = "0xCB41C0", Offset = "0xCB2FC0", Length = "0x478")]
	public void UpdateClothingWetness()
	{
	}

	[Token(Token = "0x6004726")]
	[Address(RVA = "0xCB4640", Offset = "0xCB3440", Length = "0x1CF")]
	public void UpdateBonusValuesFromWornClothing()
	{
	}

	[Token(Token = "0x6004727")]
	[Address(RVA = "0xCB4810", Offset = "0xCB3610", Length = "0x1A")]
	public void ApplyPercentDamageToWornClothingRegion(ClothingRegion region, float normalizedDamage)
	{
	}

	[Token(Token = "0x6004728")]
	[Address(RVA = "0xCB4830", Offset = "0xCB3630", Length = "0xE")]
	public void ApplyDamageToWornClothingRegion(ClothingRegion region, float damage, DamageReason damageReason = DamageReason.Unknown)
	{
	}

	[Token(Token = "0x6004729")]
	[Address(RVA = "0xCB4840", Offset = "0xCB3640", Length = "0x15D")]
	public bool GetWarnClothingCanBeDamaged()
	{
		return false;
	}

	[Token(Token = "0x600472A")]
	[Address(RVA = "0xCB49A0", Offset = "0xCB37A0", Length = "0x1EF")]
	public void ApplyPercentDamageToWornClothing(float normalizedDamage)
	{
	}

	[Token(Token = "0x600472B")]
	[Address(RVA = "0xCB4B90", Offset = "0xCB3990", Length = "0x202")]
	public void ApplyDamageToWornClothing(float damage, DamageReason damageReason = DamageReason.Unknown)
	{
	}

	[Token(Token = "0x600472C")]
	[Address(RVA = "0xCB4DA0", Offset = "0xCB3BA0", Length = "0x1A2")]
	public float GetWornClothingToughness()
	{
		return 0f;
	}

	[Token(Token = "0x600472D")]
	[Address(RVA = "0xCB4F50", Offset = "0xCB3D50", Length = "0x285")]
	public void TakeOffClothingItem(GearItem gi)
	{
	}

	[Token(Token = "0x600472E")]
	[Address(RVA = "0xCB51E0", Offset = "0xCB3FE0", Length = "0x44B")]
	public void PutOnClothingItem(GearItem gi, ClothingLayer layerToPutOn = ClothingLayer.NumLayers)
	{
	}

	[Token(Token = "0x600472F")]
	[Address(RVA = "0xCB5630", Offset = "0xCB4430", Length = "0x78")]
	public void MaybeUnlockResoluteOutfitterAchievement()
	{
	}

	[Token(Token = "0x6004730")]
	[Address(RVA = "0xCB56B0", Offset = "0xCB44B0", Length = "0x2AA")]
	public bool IsWearingClothingItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6004731")]
	[Address(RVA = "0xCB5960", Offset = "0xCB4760", Length = "0x1EA")]
	public bool IsWearingClothingName(string itemName)
	{
		return false;
	}

	[Token(Token = "0x6004732")]
	[Address(RVA = "0xCB5B50", Offset = "0xCB4950", Length = "0x2C8")]
	private bool UseClothingItem(GearItem gi, ClothingLayer layerToPutOn = ClothingLayer.NumLayers)
	{
		return false;
	}

	[Token(Token = "0x6004733")]
	[Address(RVA = "0xCB5E20", Offset = "0xCB4C20", Length = "0x32")]
	public bool HasFreeSlotForClothingItem(ClothingItem ci)
	{
		return false;
	}

	[Token(Token = "0x6004734")]
	[Address(RVA = "0xCB5E60", Offset = "0xCB4C60", Length = "0x151")]
	private ClothingLayer GetEmptyLayerForRegion(ClothingRegion region, ClothingLayer minLayer, ClothingLayer maxLayer)
	{
		return default(ClothingLayer);
	}

	[Token(Token = "0x6004735")]
	[Address(RVA = "0xCB5FC0", Offset = "0xCB4DC0", Length = "0x536")]
	public void OutputWornClothing()
	{
	}

	[Token(Token = "0x6004736")]
	[Address(RVA = "0xCB6500", Offset = "0xCB5300", Length = "0x212")]
	public GearItem GetWornWolfIntimidationClothing()
	{
		return null;
	}

	[Token(Token = "0x6004737")]
	[Address(RVA = "0xCB6720", Offset = "0xCB5520", Length = "0x212")]
	public GearItem GetWornCarryingCapacityBuffClothing()
	{
		return null;
	}

	[Token(Token = "0x6004738")]
	[Address(RVA = "0xCB6940", Offset = "0xCB5740", Length = "0x155")]
	public void GetAllWornCarryingCapacityBuffClothing(List<GearItem> carryingCapacityBuffs)
	{
	}

	[Token(Token = "0x6004739")]
	[Address(RVA = "0xCB6AA0", Offset = "0xCB58A0", Length = "0x2B5")]
	public void GetAllSpecialCarryingCapacityBuffItems(List<GearItem> carryingCapacityBuffs)
	{
	}

	[Token(Token = "0x600473A")]
	[Address(RVA = "0xCB6D60", Offset = "0xCB5B60", Length = "0x147")]
	public GearItem GetClimbingBuffClothing()
	{
		return null;
	}

	[Token(Token = "0x600473B")]
	[Address(RVA = "0xCB6EB0", Offset = "0xCB5CB0", Length = "0x1AA")]
	public float GetClothingSprintReduction()
	{
		return 0f;
	}

	[Token(Token = "0x600473C")]
	[Address(RVA = "0xCB7060", Offset = "0xCB5E60", Length = "0x1DC")]
	public int GetNumWetClothes()
	{
		return 0;
	}

	[Token(Token = "0x600473D")]
	[Address(RVA = "0xCB7240", Offset = "0xCB6040", Length = "0x43")]
	public GearItem GetClothingInSlot(ClothingRegion region, ClothingLayer layer)
	{
		return null;
	}

	[Token(Token = "0x600473E")]
	[Address(RVA = "0xCB7290", Offset = "0xCB6090", Length = "0xD8")]
	public bool HasFootwearOn()
	{
		return false;
	}

	[Token(Token = "0x600473F")]
	[Address(RVA = "0xCB7370", Offset = "0xCB6170", Length = "0x325")]
	public CramponsState GetCramponsState()
	{
		return default(CramponsState);
	}

	[Token(Token = "0x6004740")]
	[Address(RVA = "0xCB76A0", Offset = "0xCB64A0", Length = "0x3F0")]
	public float GetDamageReductionFromExteriorClothing()
	{
		return 0f;
	}

	[Token(Token = "0x6004741")]
	[Address(RVA = "0xCB7AA0", Offset = "0xCB68A0", Length = "0x336")]
	public float GetDamageReductionFromExteriorLegFeet()
	{
		return 0f;
	}

	[Token(Token = "0x6004742")]
	[Address(RVA = "0xCB7DE0", Offset = "0xCB6BE0", Length = "0x248")]
	public bool IsWearingPerfectClothesInAllSlots()
	{
		return false;
	}

	[Token(Token = "0x6004743")]
	[Address(RVA = "0xCB8050", Offset = "0xCB6E50", Length = "0x17B")]
	private float GetWornClothingRegionToughness(int regionIndex)
	{
		return 0f;
	}

	[Token(Token = "0x6004744")]
	[Address(RVA = "0xCB81D0", Offset = "0xCB6FD0", Length = "0x1DE")]
	private void ApplyPercentDamageToTopMostLayer(int regionIndex, float normalizedDamage, DamageReason damageReason = DamageReason.Unknown)
	{
	}

	[Token(Token = "0x6004745")]
	[Address(RVA = "0xCB83B0", Offset = "0xCB71B0", Length = "0x1CD")]
	private void ApplyDamageToTopMostLayer(int regionIndex, float damage, DamageReason damageReason = DamageReason.Unknown)
	{
	}

	[Token(Token = "0x6004746")]
	[Address(RVA = "0xCB8580", Offset = "0xCB7380", Length = "0x13A")]
	public GearItem GetTopLayerGear(ClothingRegion region)
	{
		return null;
	}

	[Token(Token = "0x6004747")]
	[Address(RVA = "0xCB86C0", Offset = "0xCB74C0", Length = "0x1A4")]
	public void GetAllClothingInRegion(ClothingRegion region, List<GearItem> gearItems)
	{
	}

	[Token(Token = "0x6004748")]
	[Address(RVA = "0xCB8870", Offset = "0xCB7670", Length = "0x24F")]
	public bool RegionHasFullFrozenInnerLayer(ClothingRegion region)
	{
		return false;
	}

	[Token(Token = "0x6004749")]
	[Address(RVA = "0xCB8AC0", Offset = "0xCB78C0", Length = "0x24F")]
	public bool RegionHasFullWetInnerLayer(ClothingRegion region)
	{
		return false;
	}

	[Token(Token = "0x600474A")]
	[Address(RVA = "0xCB8D10", Offset = "0xCB7B10", Length = "0x222")]
	public bool RegionHasNonFrozenClothing(ClothingRegion region)
	{
		return false;
	}

	[Token(Token = "0x600474B")]
	[Address(RVA = "0xCB8F40", Offset = "0xCB7D40", Length = "0x167")]
	public void MaybeSetPlayerFootwearSwitch()
	{
	}

	[Token(Token = "0x600474C")]
	[Address(RVA = "0xCB90B0", Offset = "0xCB7EB0", Length = "0x1D6")]
	private void MaybeSetSoundSwitch(ClothingRegion region)
	{
	}

	[Token(Token = "0x600474D")]
	[Address(RVA = "0xCB9290", Offset = "0xCB8090", Length = "0x2E")]
	private uint GetLastAudioSwitchForRegion(ClothingRegion region)
	{
		return 0u;
	}

	[Token(Token = "0x600474E")]
	[Address(RVA = "0xCB92C0", Offset = "0xCB80C0", Length = "0x2E")]
	private void SetLastAudioSwitchForRegion(ClothingRegion region, uint id)
	{
	}

	[Token(Token = "0x600474F")]
	[Address(RVA = "0xCB92F0", Offset = "0xCB80F0", Length = "0x26D")]
	private Switch GetAudioSwitchOfOuterLayer(ClothingRegion region)
	{
		return null;
	}

	[Token(Token = "0x6004750")]
	[Address(RVA = "0xCB9560", Offset = "0xCB8360", Length = "0xCB")]
	private void SetSoundSwitch(uint switchGroup, uint switchValue)
	{
	}

	[Token(Token = "0x6004756")]
	[Address(RVA = "0xCB96C0", Offset = "0xCB84C0", Length = "0x62")]
	private bool GetShouldApplyStartGear()
	{
		return false;
	}

	[Token(Token = "0x6004757")]
	[Address(RVA = "0xCB9730", Offset = "0xCB8530", Length = "0x8D")]
	public void Awake()
	{
	}

	[Token(Token = "0x6004758")]
	[Address(RVA = "0xCB97C0", Offset = "0xCB85C0", Length = "0x4A4")]
	public void Start()
	{
	}

	[Token(Token = "0x6004759")]
	[Address(RVA = "0xCB9C70", Offset = "0xCB8A70", Length = "0x161")]
	public void EnterIndoorSpaceTrigger(IndoorSpaceTrigger Trigger)
	{
	}

	[Token(Token = "0x600475A")]
	[Address(RVA = "0xCB9DE0", Offset = "0xCB8BE0", Length = "0x281")]
	public void ExitIndoorSpaceTrigger(IndoorSpaceTrigger Trigger)
	{
	}

	[Token(Token = "0x600475B")]
	[Address(RVA = "0xCBA070", Offset = "0xCB8E70", Length = "0x8")]
	public bool IsFirstFrame()
	{
		return false;
	}

	[Token(Token = "0x600475C")]
	[Address(RVA = "0xCBA080", Offset = "0xCB8E80", Length = "0xC")]
	public bool IsStickPlayerToGroundPending()
	{
		return false;
	}

	[Token(Token = "0x600475D")]
	[Address(RVA = "0xCBA090", Offset = "0xCB8E90", Length = "0x13")]
	public bool IsTeleportPending()
	{
		return false;
	}

	[Token(Token = "0x600475E")]
	[Address(RVA = "0xCBA0B0", Offset = "0xCB8EB0", Length = "0x438")]
	private void SpawnFirstPersonItems()
	{
	}

	[Token(Token = "0x600475F")]
	[Address(RVA = "0xCBA4F0", Offset = "0xCB92F0", Length = "0x65")]
	public void ResetStartGear()
	{
	}

	[Token(Token = "0x6004760")]
	[Address(RVA = "0xCBA560", Offset = "0xCB9360", Length = "0xE7C")]
	public void Update()
	{
	}

	[Token(Token = "0x6004761")]
	[Address(RVA = "0xCBB3E0", Offset = "0xCBA1E0", Length = "0xF77")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004762")]
	[Address(RVA = "0xCBC360", Offset = "0xCBB160", Length = "0x9D5")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004763")]
	[Address(RVA = "0xCBCD40", Offset = "0xCBBB40", Length = "0x8C")]
	public void DeserializePostSceneLoadFixup()
	{
	}

	[Token(Token = "0x6004764")]
	[Address(RVA = "0xCBCDD0", Offset = "0xCBBBD0", Length = "0x3D3")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6004765")]
	[Address(RVA = "0xCBD1B0", Offset = "0xCBBFB0", Length = "0x380")]
	public bool CanSnapPlayerBackToBounds(Collider fromCollider)
	{
		return false;
	}

	[Token(Token = "0x6004766")]
	[Address(RVA = "0xCBD540", Offset = "0xCBC340", Length = "0x389")]
	public void TeleportPlayer(Vector3 position, Quaternion rotation)
	{
	}

	[Token(Token = "0x6004767")]
	[Address(RVA = "0xCBD8D0", Offset = "0xCBC6D0", Length = "0x77")]
	public PlayerControlMode GetControlMode()
	{
		return default(PlayerControlMode);
	}

	[Token(Token = "0x6004768")]
	[Address(RVA = "0xCBD950", Offset = "0xCBC750", Length = "0x29F")]
	public void SetControlMode(PlayerControlMode mode)
	{
	}

	[Token(Token = "0x6004769")]
	[Address(RVA = "0xCBDBF0", Offset = "0xCBC9F0", Length = "0x39")]
	public bool ControlModeAllowsInterface()
	{
		return false;
	}

	[Token(Token = "0x600476A")]
	[Address(RVA = "0xCBDC30", Offset = "0xCBCA30", Length = "0x95")]
	public void ReturnToNormalControlMode(PlayerControlMode expectedCurrentMode = PlayerControlMode.Normal)
	{
	}

	[Token(Token = "0x600476B")]
	[Address(RVA = "0xCBDCD0", Offset = "0xCBCAD0", Length = "0x7")]
	public void SetStatusBarsLocked(bool isLocked)
	{
	}

	[Token(Token = "0x600476C")]
	[Address(RVA = "0xCBDCE0", Offset = "0xCBCAE0", Length = "0x8")]
	public bool IsStatusBarsLocked()
	{
		return false;
	}

	[Token(Token = "0x600476D")]
	[Address(RVA = "0xCBDCF0", Offset = "0xCBCAF0", Length = "0x16")]
	public bool PlayerIsDead()
	{
		return false;
	}

	[Token(Token = "0x600476E")]
	[Address(RVA = "0xCBDD10", Offset = "0xCBCB10", Length = "0x3CC")]
	public bool PlayerIsInvisibleToAi()
	{
		return false;
	}

	[Token(Token = "0x600476F")]
	[Address(RVA = "0xCBE0E0", Offset = "0xCBCEE0", Length = "0x47E")]
	public float CalculateModifiedCalorieBurnRate(float baseBurnRate)
	{
		return 0f;
	}

	[Token(Token = "0x6004770")]
	[Address(RVA = "0xCBE560", Offset = "0xCBD360", Length = "0x430")]
	public void UpdateCalorieBurnRate()
	{
	}

	[Token(Token = "0x6004771")]
	[Address(RVA = "0xCBE9A0", Offset = "0xCBD7A0", Length = "0x189")]
	public bool PlayerCantSprintBecauseOfInjury()
	{
		return false;
	}

	[Token(Token = "0x6004772")]
	[Address(RVA = "0xCBEB30", Offset = "0xCBD930", Length = "0x28C")]
	public bool PlayerCanSprint()
	{
		return false;
	}

	[Token(Token = "0x6004773")]
	[Address(RVA = "0xCBEDC0", Offset = "0xCBDBC0", Length = "0x55")]
	public bool PlayerIsSleeping()
	{
		return false;
	}

	[Token(Token = "0x6004774")]
	[Address(RVA = "0xCBEE20", Offset = "0xCBDC20", Length = "0x204")]
	public bool PlayerIsSprinting()
	{
		return false;
	}

	[Token(Token = "0x6004775")]
	[Address(RVA = "0xCBF030", Offset = "0xCBDE30", Length = "0x244")]
	public bool PlayerIsWalking()
	{
		return false;
	}

	[Token(Token = "0x6004776")]
	[Address(RVA = "0xCBF280", Offset = "0xCBE080", Length = "0x14B")]
	public bool PlayerIsCrouched()
	{
		return false;
	}

	[Token(Token = "0x6004777")]
	[Address(RVA = "0xCBF3D0", Offset = "0xCBE1D0", Length = "0x20E")]
	public bool PlayerIsZooming()
	{
		return false;
	}

	[Token(Token = "0x6004778")]
	[Address(RVA = "0xCBF5E0", Offset = "0xCBE3E0", Length = "0x71")]
	public bool PlayerIsBreakingDown()
	{
		return false;
	}

	[Token(Token = "0x6004779")]
	[Address(RVA = "0xCBF660", Offset = "0xCBE460", Length = "0x71")]
	public bool PlayerIsBuildingShelter()
	{
		return false;
	}

	[Token(Token = "0x600477A")]
	[Address(RVA = "0xCBF6E0", Offset = "0xCBE4E0", Length = "0x71")]
	public bool PlayerIsRepairingShelter()
	{
		return false;
	}

	[Token(Token = "0x600477B")]
	[Address(RVA = "0xCBF760", Offset = "0xCBE560", Length = "0x71")]
	public bool PlayerIsDismantlingShelter()
	{
		return false;
	}

	[Token(Token = "0x600477C")]
	[Address(RVA = "0xCBF7E0", Offset = "0xCBE5E0", Length = "0x74")]
	public bool PlayerIsHarvestingCarcass()
	{
		return false;
	}

	[Token(Token = "0x600477D")]
	[Address(RVA = "0xCBF860", Offset = "0xCBE660", Length = "0x16")]
	public bool PlayerIsClimbing()
	{
		return false;
	}

	[Token(Token = "0x600477E")]
	[Address(RVA = "0xCBF880", Offset = "0xCBE680", Length = "0x16")]
	public bool PlayerIsInElevator()
	{
		return false;
	}

	[Token(Token = "0x600477F")]
	[Address(RVA = "0xCBF8A0", Offset = "0xCBE6A0", Length = "0x4B1")]
	public bool PlayerIsSwingingFirstPersonItem()
	{
		return false;
	}

	[Token(Token = "0x6004780")]
	[Address(RVA = "0xCBFD60", Offset = "0xCBEB60", Length = "0x278")]
	public bool GetStickToGroundPosition(Vector3 testPos, out Vector3 groundPos)
	{
		groundPos = default(Vector3);
		return false;
	}

	[Token(Token = "0x6004781")]
	[Address(RVA = "0xCBFFE0", Offset = "0xCBEDE0", Length = "0x357")]
	public bool GetStickToGroundPositionAfterLoad(Vector3 testPos, out Vector3 groundPos)
	{
		groundPos = default(Vector3);
		return false;
	}

	[Token(Token = "0x6004782")]
	[Address(RVA = "0xCC0340", Offset = "0xCBF140", Length = "0x166")]
	public void StickPlayerToGround()
	{
	}

	[Token(Token = "0x6004783")]
	[Address(RVA = "0xCC04B0", Offset = "0xCBF2B0", Length = "0x166")]
	public void StickPlayerToGroundAfterLoad()
	{
	}

	[Token(Token = "0x6004784")]
	[Address(RVA = "0xCC0620", Offset = "0xCBF420", Length = "0xB")]
	public void ForceLockCamera()
	{
	}

	[Token(Token = "0x6004785")]
	[Address(RVA = "0xCC0630", Offset = "0xCBF430", Length = "0xB")]
	public void ForceRotateCamera()
	{
	}

	[Token(Token = "0x6004786")]
	[Address(RVA = "0xCC0640", Offset = "0xCBF440", Length = "0x2F2")]
	public void MaybeRotateCamera()
	{
	}

	[Token(Token = "0x6004787")]
	[Address(RVA = "0xCC0940", Offset = "0xCBF740", Length = "0x8")]
	public void OnPlayerCheat()
	{
	}

	[Token(Token = "0x6004788")]
	[Address(RVA = "0xCC0950", Offset = "0xCBF750", Length = "0x8")]
	public bool HasCheated()
	{
		return false;
	}

	[Token(Token = "0x6004789")]
	[Address(RVA = "0xCC0960", Offset = "0xCBF760", Length = "0x1BE")]
	public float GetZoomDamping()
	{
		return 0f;
	}

	[Token(Token = "0x600478A")]
	[Address(RVA = "0xCC0B20", Offset = "0xCBF920", Length = "0x129")]
	public bool InHibernationPreventionIndoorEnvironment()
	{
		return false;
	}

	[Token(Token = "0x600478B")]
	[Address(RVA = "0xCC0C50", Offset = "0xCBFA50", Length = "0xE9")]
	public bool IsCharacterControllerEnabled()
	{
		return false;
	}

	[Token(Token = "0x600478C")]
	[Address(RVA = "0xCC0D40", Offset = "0xCBFB40", Length = "0x240")]
	public void EnableCharacterController()
	{
	}

	[Token(Token = "0x600478D")]
	[Address(RVA = "0xCC0F90", Offset = "0xCBFD90", Length = "0x240")]
	public void DisableCharacterController()
	{
	}

	[Token(Token = "0x600478E")]
	[Address(RVA = "0xCC11E0", Offset = "0xCBFFE0", Length = "0x14F")]
	public static void AddSpawnPoints(PlayerSpawnPoints playerSpawnPoints)
	{
	}

	[Token(Token = "0x600478F")]
	[Address(RVA = "0xCC1330", Offset = "0xCC0130", Length = "0x83")]
	public static void RemoveSpawnPoints(PlayerSpawnPoints playerSpawnPoints)
	{
	}

	[Token(Token = "0x6004790")]
	[Address(RVA = "0xCC13C0", Offset = "0xCC01C0", Length = "0x7FC")]
	public static GameObject PickRandomSpawnPoint()
	{
		return null;
	}

	[Token(Token = "0x6004791")]
	[Address(RVA = "0xCC1BC0", Offset = "0xCC09C0", Length = "0x3AE")]
	private void UpdateHUDText(Panel_HUD hud)
	{
	}

	[Token(Token = "0x6004792")]
	[Address(RVA = "0xCC1F70", Offset = "0xCC0D70", Length = "0xD7C")]
	public bool GetTeleportTransformAfterSceneLoad(out Vector3 position, out Quaternion rotation)
	{
		position = default(Vector3);
		rotation = default(Quaternion);
		return false;
	}

	[Token(Token = "0x6004793")]
	[Address(RVA = "0xCC2CF0", Offset = "0xCC1AF0", Length = "0x9A4")]
	private SceneLoadSource TeleportPlayerAfterSceneLoad()
	{
		return default(SceneLoadSource);
	}

	[Token(Token = "0x6004794")]
	[Address(RVA = "0xCC36A0", Offset = "0xCC24A0", Length = "0xEE")]
	private void MaybePlayLandAudio()
	{
	}

	[Token(Token = "0x6004795")]
	[Address(RVA = "0xCC3790", Offset = "0xCC2590", Length = "0x22D")]
	public void OnLandFromFall(float fallFromHeight, float damageOverride)
	{
	}

	[Token(Token = "0x6004796")]
	[Address(RVA = "0xCC39C0", Offset = "0xCC27C0", Length = "0xC1")]
	public void OnTakeDamage(float condition, float given, float taken, DamageSource damageSource)
	{
	}

	[Token(Token = "0x6004797")]
	[Address(RVA = "0xCC3A90", Offset = "0xCC2890", Length = "0x11C")]
	public void MaybeSetPlayerGroundMaterialSwitch(string tag)
	{
	}

	[Token(Token = "0x6004798")]
	[Address(RVA = "0xCC3BB0", Offset = "0xCC29B0", Length = "0xC5")]
	private bool ShouldSaveGameAfterTeleport()
	{
		return false;
	}

	[Token(Token = "0x6004799")]
	[Address(RVA = "0xCC3C80", Offset = "0xCC2A80", Length = "0x253")]
	private bool ShouldForcePlayerSpawnToDefault()
	{
		return false;
	}

	[Token(Token = "0x600479A")]
	[Address(RVA = "0xCC3EE0", Offset = "0xCC2CE0", Length = "0x49C")]
	private void MaybeUpdateWiseWithClosestDistanceToPredator()
	{
	}

	[Token(Token = "0x600479B")]
	[Address(RVA = "0xCC4380", Offset = "0xCC3180", Length = "0x216")]
	private void MaybeUpdateWiseWithPlayerElevation()
	{
	}

	[Token(Token = "0x600479C")]
	[Address(RVA = "0xCC45A0", Offset = "0xCC33A0", Length = "0x71")]
	public void SkipDelaySpawnAudio()
	{
	}

	[Token(Token = "0x600479D")]
	[Address(RVA = "0xCC4620", Offset = "0xCC3420", Length = "0xFC")]
	private void MaybePlayDelayedSpawnAudio()
	{
	}

	[Token(Token = "0x600479E")]
	[Address(RVA = "0xCC4720", Offset = "0xCC3520", Length = "0x194")]
	private bool AllowInteractionWithObjects()
	{
		return false;
	}

	[Token(Token = "0x600479F")]
	[Address(RVA = "0xCC48C0", Offset = "0xCC36C0", Length = "0x2DB")]
	private void MaybeRepositionPlayerIfFellThroughWorld()
	{
	}

	[Token(Token = "0x60047A0")]
	[Address(RVA = "0xCC4BA0", Offset = "0xCC39A0", Length = "0x8")]
	public bool GetShowingUnknownTimeOfDay()
	{
		return false;
	}

	[Token(Token = "0x60047A1")]
	[Address(RVA = "0xCC4BB0", Offset = "0xCC39B0", Length = "0x7")]
	public void ShowUnknownTimeOfDay(bool showUnknownTimeOfDay)
	{
	}

	[Token(Token = "0x60047A2")]
	[Address(RVA = "0xCC4BC0", Offset = "0xCC39C0", Length = "0x138")]
	public void KnockedDownByAI(AiSubType aiSubType)
	{
	}

	[Token(Token = "0x60047A3")]
	[Address(RVA = "0xCC4D00", Offset = "0xCC3B00", Length = "0xD2")]
	public bool IsPlayerInStealthArea()
	{
		return false;
	}

	[Token(Token = "0x60047A4")]
	[Address(RVA = "0xCC4DE0", Offset = "0xCC3BE0", Length = "0xF6")]
	public bool PlayerIsStealthed()
	{
		return false;
	}

	[Token(Token = "0x60047A5")]
	[Address(RVA = "0xCC4EE0", Offset = "0xCC3CE0", Length = "0xDF")]
	public bool IsBeingTargettedByAI()
	{
		return false;
	}

	[Token(Token = "0x60047A6")]
	[Address(RVA = "0xCC4FC0", Offset = "0xCC3DC0", Length = "0x18C")]
	public bool IsHoldingWildlifeItem()
	{
		return false;
	}

	[Token(Token = "0x60047A7")]
	[Address(RVA = "0xCC5150", Offset = "0xCC3F50", Length = "0x1C9")]
	public bool CanStaminaAim()
	{
		return false;
	}

	[Token(Token = "0x60047A8")]
	[Address(RVA = "0xCC5320", Offset = "0xCC4120", Length = "0x2B8")]
	public bool IsStaminaAiming()
	{
		return false;
	}

	[Token(Token = "0x60047A9")]
	[Address(RVA = "0xCC55E0", Offset = "0xCC43E0", Length = "0x1CA")]
	public float GetStaminaAimPercent()
	{
		return 0f;
	}

	[Token(Token = "0x60047AA")]
	[Address(RVA = "0xCC57B0", Offset = "0xCC45B0", Length = "0x1EE")]
	public float GetStaminaAimDropThresholdPercent()
	{
		return 0f;
	}

	[Token(Token = "0x60047AB")]
	[Address(RVA = "0xCC59A0", Offset = "0xCC47A0", Length = "0xA")]
	public void OnPostDeserializeForEpisodeMigration()
	{
	}

	[Token(Token = "0x60047AC")]
	[Address(RVA = "0xCC59B0", Offset = "0xCC47B0", Length = "0x42A")]
	private void GroundCharacterInternal(Vector3 groundPos)
	{
	}

	[Token(Token = "0x60047AD")]
	[Address(RVA = "0xCC5DE0", Offset = "0xCC4BE0", Length = "0x227")]
	private void UpdateIfPlayerHasMoved()
	{
	}

	[Token(Token = "0x60047AE")]
	[Address(RVA = "0xCC6010", Offset = "0xCC4E10", Length = "0x18D")]
	private static CharacterController GetPlayerController()
	{
		return null;
	}

	[Token(Token = "0x60047AF")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void LogAiDamage(GameObject damageReceiver, float condition, float damageGiven, float damageTaken, float bleedOutMintues, DamageSource damageSource, string collider)
	{
	}

	[Token(Token = "0x60047B0")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void LogAiFleeFromItem(BaseAi ai, GearItem item, bool wasHit, float fleeChance, float roll, float distance, float fleeDistance)
	{
	}

	[Token(Token = "0x60047B1")]
	[Address(RVA = "0xCC61A0", Offset = "0xCC4FA0", Length = "0x12")]
	private bool RangedApproximate(float a, float b, float range)
	{
		return false;
	}

	[Token(Token = "0x60047B2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void LogPlayerDamage(float condition, float given, float taken, DamageSource damageSource)
	{
	}

	[Token(Token = "0x60047B3")]
	[Address(RVA = "0xCC61C0", Offset = "0xCC4FC0", Length = "0x1D")]
	public void EnableDebugPosition(bool enabled, float frequencyInSeconds)
	{
	}

	[Token(Token = "0x60047B4")]
	[Address(RVA = "0xCC61E0", Offset = "0xCC4FE0", Length = "0x3DF")]
	private void LogPlayerPosition()
	{
	}

	[Token(Token = "0x60047B5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void MaybeFlushPlayerDamage()
	{
	}

	[Token(Token = "0x60047B6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void FlushPlayerDamage()
	{
	}

	[Token(Token = "0x60047B7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void EnableDebugLookAt(bool enabled, bool useHighlight)
	{
	}

	[Token(Token = "0x60047B8")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public GameObject GetDebugLookAtLastObject()
	{
		return null;
	}

	[Token(Token = "0x60047B9")]
	[Address(RVA = "0xCC65C0", Offset = "0xCC53C0", Length = "0x31")]
	public string GetDebugLookAtDisplayName()
	{
		return null;
	}

	[Token(Token = "0x60047BA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void UpdateDebugLookAtObject()
	{
	}

	[Token(Token = "0x60047BB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void AssignDebugLookAtMaterialProperties(bool enabled, Renderer[] renderers)
	{
	}

	[Token(Token = "0x60047BC")]
	[Address(RVA = "0xCC6600", Offset = "0xCC5400", Length = "0x2CC")]
	private void InitInspectGearMode(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60047BD")]
	[Address(RVA = "0xCC68D0", Offset = "0xCC56D0", Length = "0x79")]
	public void EnterInspectGearModeWithCallback(GearItem gear, CallbackDelegate callback)
	{
	}

	[Token(Token = "0x60047BE")]
	[Address(RVA = "0xCC6950", Offset = "0xCC5750", Length = "0x25")]
	public void EnterInspectGearMode(GearItem gear)
	{
	}

	[Token(Token = "0x60047BF")]
	[Address(RVA = "0xCC6980", Offset = "0xCC5780", Length = "0x22")]
	public void EnterInspectGearModeFromContainer(GearItem gear, Container c)
	{
	}

	[Token(Token = "0x60047C0")]
	[Address(RVA = "0xCC69B0", Offset = "0xCC57B0", Length = "0x25")]
	public void EnterInspectGearModeFromFishingHole(GearItem gear, IceFishingHole hole)
	{
	}

	[Token(Token = "0x60047C1")]
	[Address(RVA = "0xCC69E0", Offset = "0xCC57E0", Length = "0x25")]
	public void EnterInspectGearModeFromHarvestable(GearItem gear, Harvestable h)
	{
	}

	[Token(Token = "0x60047C2")]
	[Address(RVA = "0xCC6A10", Offset = "0xCC5810", Length = "0x25")]
	public void EnterInspectGearModeFromCookingPot(GearItem gear, CookingPotItem pot)
	{
	}

	[Token(Token = "0x60047C3")]
	[Address(RVA = "0xCC6A40", Offset = "0xCC5840", Length = "0x52")]
	public void SetCallback(CallbackDelegate callback)
	{
	}

	[Token(Token = "0x60047C4")]
	[Address(RVA = "0xCC6AA0", Offset = "0xCC58A0", Length = "0x16A")]
	private void SaveGearItemTransformInInspectSpace(Transform t)
	{
	}

	[Token(Token = "0x60047C5")]
	[Address(RVA = "0xCC6C10", Offset = "0xCC5A10", Length = "0x73")]
	public void OnCollectibleNoteReadingClickBack()
	{
	}

	[Token(Token = "0x60047C6")]
	[Address(RVA = "0xCC6C90", Offset = "0xCC5A90", Length = "0x174")]
	public void RevealOnPolaroidDiscovery(GearItem gi)
	{
	}

	[Token(Token = "0x60047C7")]
	[Address(RVA = "0xCC6E10", Offset = "0xCC5C10", Length = "0x1E2")]
	public void MaybeRevealPolaroidDiscoveryOnClose()
	{
	}

	[Token(Token = "0x60047C8")]
	[Address(RVA = "0xCC7000", Offset = "0xCC5E00", Length = "0xED7")]
	public void ExitInspectGearMode(bool hardExit)
	{
	}

	[Token(Token = "0x60047C9")]
	[Address(RVA = "0xCC7EE0", Offset = "0xCC6CE0", Length = "0x1098")]
	private void EnterInspectGearMode(GearItem gear, Container c, IceFishingHole hole, Harvestable h, CookingPotItem pot)
	{
	}

	[Token(Token = "0x60047CA")]
	[Address(RVA = "0xCC8F80", Offset = "0xCC7D80", Length = "0xD40")]
	private void SetupCallbacksForGear()
	{
	}

	[Token(Token = "0x60047CB")]
	[Address(RVA = "0xCC9CD0", Offset = "0xCC8AD0", Length = "0xAF7")]
	private void UpdateInspectGear(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60047CC")]
	[Address(RVA = "0xCCA7D0", Offset = "0xCC95D0", Length = "0x52")]
	private void OnPutBackFromHarvestableInspection()
	{
	}

	[Token(Token = "0x60047CD")]
	[Address(RVA = "0xCCA830", Offset = "0xCC9630", Length = "0x7B")]
	private void OnPutBackFromIceFishingHoleInspection()
	{
	}

	[Token(Token = "0x60047CE")]
	[Address(RVA = "0xCCA8B0", Offset = "0xCC96B0", Length = "0x1D")]
	private void OnPutBackFromContainerInspection()
	{
	}

	[Token(Token = "0x60047CF")]
	[Address(RVA = "0xCCA8D0", Offset = "0xCC96D0", Length = "0x17A")]
	private void OnPickupFromStandardGearItemInspection()
	{
	}

	[Token(Token = "0x60047D0")]
	[Address(RVA = "0xCCAA50", Offset = "0xCC9850", Length = "0x2F5")]
	private void OnPickupFromCookingPotInspection()
	{
	}

	[Token(Token = "0x60047D1")]
	[Address(RVA = "0xCCAD50", Offset = "0xCC9B50", Length = "0x293")]
	private void OnPickupFromTravoisInspection()
	{
	}

	[Token(Token = "0x60047D2")]
	[Address(RVA = "0xCCAFF0", Offset = "0xCC9DF0", Length = "0x32")]
	private void OnPutBackFromTravoisInspection()
	{
	}

	[Token(Token = "0x60047D3")]
	[Address(RVA = "0xCCB030", Offset = "0xCC9E30", Length = "0x1D")]
	private void OnPickupFromContainerInspection()
	{
	}

	[Token(Token = "0x60047D4")]
	[Address(RVA = "0xCCB050", Offset = "0xCC9E50", Length = "0xA0")]
	private void OnEquipFromReadableNarrativeItemInspection()
	{
	}

	[Token(Token = "0x60047D5")]
	[Address(RVA = "0xCCB100", Offset = "0xCC9F00", Length = "0xFD")]
	private void OnEquipFromStandardGearItemInspection()
	{
	}

	[Token(Token = "0x60047D6")]
	[Address(RVA = "0xCCB200", Offset = "0xCCA000", Length = "0xBA")]
	private void OnEquipFromIncompleteBodyHarvestInspection()
	{
	}

	[Token(Token = "0x60047D7")]
	[Address(RVA = "0xCCB2C0", Offset = "0xCCA0C0", Length = "0xCD")]
	private void OnEquipFromIncompleteResearchItemInspection()
	{
	}

	[Token(Token = "0x60047D8")]
	[Address(RVA = "0xCCB390", Offset = "0xCCA190", Length = "0x136")]
	private void OnEquipFromDrinkableLiquidItemInspection()
	{
	}

	[Token(Token = "0x60047D9")]
	[Address(RVA = "0xCCB4D0", Offset = "0xCCA2D0", Length = "0x1C6")]
	private void OnEquipFromFoodItemInspection()
	{
	}

	[Token(Token = "0x60047DA")]
	[Address(RVA = "0xCCB6A0", Offset = "0xCCA4A0", Length = "0x45")]
	private void OnEquipFromCookingPotInspection()
	{
	}

	[Token(Token = "0x60047DB")]
	[Address(RVA = "0xCCB6F0", Offset = "0xCCA4F0", Length = "0x8")]
	public bool IsInspectModeActive()
	{
		return false;
	}

	[Token(Token = "0x60047DC")]
	[Address(RVA = "0xCCB700", Offset = "0xCCA500", Length = "0x8")]
	public GearItem GearItemBeingInspected()
	{
		return null;
	}

	[Token(Token = "0x60047DD")]
	[Address(RVA = "0xCCB710", Offset = "0xCCA510", Length = "0x53B")]
	public void RestoreTransformFromLastInspection(GearItem gi)
	{
	}

	[Token(Token = "0x60047DE")]
	[Address(RVA = "0xCCBC50", Offset = "0xCCAA50", Length = "0x328")]
	public static void MaybeEnableInspectModeMesh(GearItem gi)
	{
	}

	[Token(Token = "0x60047DF")]
	[Address(RVA = "0xCCBF80", Offset = "0xCCAD80", Length = "0x32D")]
	public static void MaybeDisableInspectModeMesh(GearItem gi)
	{
	}

	[Token(Token = "0x60047E0")]
	[Address(RVA = "0xCCC2B0", Offset = "0xCCB0B0", Length = "0x19F")]
	private void RestoreOriginalTransform(GearItem gi)
	{
	}

	[Token(Token = "0x60047E1")]
	[Address(RVA = "0xCCC450", Offset = "0xCCB250", Length = "0xF6")]
	private void SetGearTransformForInspection()
	{
	}

	[Token(Token = "0x60047E2")]
	[Address(RVA = "0xCCC550", Offset = "0xCCB350", Length = "0x77F")]
	private void UpdateGearTransformForInspection()
	{
	}

	[Token(Token = "0x60047E3")]
	[Address(RVA = "0xCCCCD0", Offset = "0xCCBAD0", Length = "0x53C")]
	private void SetActiveAllLabels(Panel_HUD hud, bool active)
	{
	}

	[Token(Token = "0x60047E4")]
	[Address(RVA = "0xCCD210", Offset = "0xCCC010", Length = "0x2D")]
	private void SetActiveInfoArea(Panel_HUD hud, bool showStandard)
	{
	}

	[Token(Token = "0x60047E5")]
	[Address(RVA = "0xCCD240", Offset = "0xCCC040", Length = "0x1DD")]
	private void NoteToggleReadMode(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60047E6")]
	[Address(RVA = "0xCCD420", Offset = "0xCCC220", Length = "0x2785")]
	private void InitLabelsForGear(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60047E7")]
	[Address(RVA = "0xCCFBB0", Offset = "0xCCE9B0", Length = "0x229")]
	private void MaybeReplaceGearItemForLabels()
	{
	}

	[Token(Token = "0x60047E8")]
	[Address(RVA = "0xCCFDE0", Offset = "0xCCEBE0", Length = "0x1A2")]
	private void FadeInLabels(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60047E9")]
	[Address(RVA = "0xCCFF90", Offset = "0xCCED90", Length = "0x6C2")]
	private void MaybePlayInspectModeVoiceOver()
	{
	}

	[Token(Token = "0x60047EA")]
	[Address(RVA = "0xCD0660", Offset = "0xCCF460", Length = "0x2B0")]
	private void PlayPutBackAudio()
	{
	}

	[Token(Token = "0x60047EB")]
	[Address(RVA = "0xCD0920", Offset = "0xCCF720", Length = "0xFE")]
	private void PlayStowAudio()
	{
	}

	[Token(Token = "0x60047EC")]
	[Address(RVA = "0xCD0A20", Offset = "0xCCF820", Length = "0xFA")]
	private void AttemptEquipGearItem()
	{
	}

	[Token(Token = "0x60047ED")]
	[Address(RVA = "0xCD0B20", Offset = "0xCCF920", Length = "0x1FF")]
	private void TransferGearFromInspectToContainer()
	{
	}

	[Token(Token = "0x60047EE")]
	[Address(RVA = "0xCD0D20", Offset = "0xCCFB20", Length = "0x293")]
	private void TransferGearFromContainerToInventory()
	{
	}

	[Token(Token = "0x60047EF")]
	[Address(RVA = "0xCD0FC0", Offset = "0xCCFDC0", Length = "0x2C2")]
	private bool CanPickup(Panel_HUD hud)
	{
		return false;
	}

	[Token(Token = "0x60047F0")]
	[Address(RVA = "0xCD1290", Offset = "0xCD0090", Length = "0x18D")]
	private bool ShouldContainerDisallowEquipAction()
	{
		return false;
	}

	[Token(Token = "0x60047F1")]
	[Address(RVA = "0xCD1420", Offset = "0xCD0220", Length = "0x227")]
	private void RefreshGamepadPrompts(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60047F6")]
	[Address(RVA = "0xCD16E0", Offset = "0xCD04E0", Length = "0x88")]
	public bool IsCancelableActionInProgress()
	{
		return false;
	}

	[Token(Token = "0x60047F7")]
	[Address(RVA = "0xCD1770", Offset = "0xCD0570", Length = "0x8")]
	public bool IsClickHoldActive()
	{
		return false;
	}

	[Token(Token = "0x60047F8")]
	[Address(RVA = "0xCD1780", Offset = "0xCD0580", Length = "0x8")]
	public void ClearRestoreItemInHandsAfterInteraction()
	{
	}

	[Token(Token = "0x60047F9")]
	[Address(RVA = "0xCD1790", Offset = "0xCD0590", Length = "0x8")]
	public bool WillRestoreItemInHandsAfterInteraction()
	{
		return false;
	}

	[Token(Token = "0x60047FA")]
	[Address(RVA = "0xCD17A0", Offset = "0xCD05A0", Length = "0x1DE")]
	public bool StowItem()
	{
		return false;
	}

	[Token(Token = "0x60047FB")]
	[Address(RVA = "0xCD1980", Offset = "0xCD0780", Length = "0x1F1")]
	public void ItemInHandsDuringInteractionStart()
	{
	}

	[Token(Token = "0x60047FC")]
	[Address(RVA = "0xCD1B80", Offset = "0xCD0980", Length = "0x8")]
	public void ItemInHandsDuringInteractionEnd()
	{
	}

	[Token(Token = "0x60047FD")]
	[Address(RVA = "0xCD1B90", Offset = "0xCD0990", Length = "0x8D")]
	private void DoDelayedInteractionEnd(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60047FE")]
	[Address(RVA = "0xCD1C20", Offset = "0xCD0A20", Length = "0xC0")]
	private bool ShouldStowOrUnstowForInteraction()
	{
		return false;
	}

	[Token(Token = "0x60047FF")]
	[Address(RVA = "0xCD1CF0", Offset = "0xCD0AF0", Length = "0x354")]
	private void ItemInHandsDuringInteractionEndInternal(Panel_HUD hud)
	{
	}

	[Token(Token = "0x6004800")]
	[Address(RVA = "0xCD2050", Offset = "0xCD0E50", Length = "0x618")]
	public bool ProcessPickupItemInteraction(GearItem item, bool forceEquip, bool forceEquipImmediate, bool skipAudio)
	{
		return false;
	}

	[Token(Token = "0x6004801")]
	[Address(RVA = "0xCD2670", Offset = "0xCD1470", Length = "0x2C7")]
	public void ProcessPickupWithNoInspectScreen(GearItem pickupItem, bool immediate)
	{
	}

	[Token(Token = "0x6004802")]
	[Address(RVA = "0xCD2940", Offset = "0xCD1740", Length = "0x33A")]
	public void ProcessPickupWithNoInspectScreenDropCurrent(PlayerAnimation.OnAnimationEvent nextEvent)
	{
	}

	[Token(Token = "0x6004803")]
	[Address(RVA = "0xCD2C80", Offset = "0xCD1A80", Length = "0x6A")]
	private void OnUnequipItemInHandInternalCompleteResetWeapon()
	{
	}

	[Token(Token = "0x6004804")]
	[Address(RVA = "0xCD2CF0", Offset = "0xCD1AF0", Length = "0x2CC")]
	private void ProcessPickupWithNoInspectScreenEquip()
	{
	}

	[Token(Token = "0x6004805")]
	[Address(RVA = "0xCD2FC0", Offset = "0xCD1DC0", Length = "0x5E0")]
	private void OnProcessPickupWinNoInspectEquipComplete()
	{
	}

	[Token(Token = "0x6004806")]
	[Address(RVA = "0xCD35B0", Offset = "0xCD23B0", Length = "0x52")]
	public void ResetPickup()
	{
	}

	[Token(Token = "0x6004807")]
	[Address(RVA = "0xCD3610", Offset = "0xCD2410", Length = "0xE9")]
	public bool ShouldShowClickHoldBackpiece()
	{
		return false;
	}

	[Token(Token = "0x6004808")]
	[Address(RVA = "0xCD3700", Offset = "0xCD2500", Length = "0x30F")]
	public HoverTextState GetInteractiveObjectDisplayTextState()
	{
		return default(HoverTextState);
	}

	[Token(Token = "0x6004809")]
	[Address(RVA = "0xCD3A10", Offset = "0xCD2810", Length = "0x121")]
	public string GetInteractiveObjectHoverText()
	{
		return null;
	}

	[Token(Token = "0x600480A")]
	[Address(RVA = "0xCD3B40", Offset = "0xCD2940", Length = "0xA2")]
	public string GetInteractiveObjectHoldText()
	{
		return null;
	}

	[Token(Token = "0x600480B")]
	[Address(RVA = "0xCD3BF0", Offset = "0xCD29F0", Length = "0x842")]
	private GameObject GetInteractiveObjectNearCrosshairs(float maxRange)
	{
		return null;
	}

	[Token(Token = "0x600480C")]
	[Address(RVA = "0xCD4440", Offset = "0xCD3240", Length = "0x26")]
	public bool HasInteractiveObjectUnderCrossHair()
	{
		return false;
	}

	[Token(Token = "0x600480D")]
	[Address(RVA = "0xCD4470", Offset = "0xCD3270", Length = "0x3F5")]
	private GameObject GetInteractiveObjectWithConstraints(GameObject interactiveObject)
	{
		return null;
	}

	[Token(Token = "0x600480E")]
	[Address(RVA = "0xCD4870", Offset = "0xCD3670", Length = "0x4C7")]
	private void FindInteractiveObject(RaycastHit hit, ref GearItem gi, ref GameObject interactiveObj)
	{
	}

	[Token(Token = "0x600480F")]
	[Address(RVA = "0xCD4D40", Offset = "0xCD3B40", Length = "0x1C0B")]
	public GameObject GetInteractiveObjectUnderCrosshairs(float maxRange)
	{
		return null;
	}

	[Token(Token = "0x6004810")]
	[Address(RVA = "0xCD6950", Offset = "0xCD5750", Length = "0x196")]
	public void InteractiveObjectsProcess()
	{
	}

	[Token(Token = "0x6004811")]
	[Address(RVA = "0xCD6AF0", Offset = "0xCD58F0", Length = "0x3F6")]
	private void FindInteractiveObject(float range)
	{
	}

	[Token(Token = "0x6004812")]
	[Address(RVA = "0xCD6EF0", Offset = "0xCD5CF0", Length = "0xD9")]
	private void SetCurrentInteraction(IInteraction interaction)
	{
	}

	[Token(Token = "0x6004813")]
	[Address(RVA = "0xCD6FD0", Offset = "0xCD5DD0", Length = "0x14")]
	public void SetForcedInteraction(IInteraction interaction)
	{
	}

	[Token(Token = "0x6004814")]
	[Address(RVA = "0xCD6FF0", Offset = "0xCD5DF0", Length = "0x1C6")]
	private void UpdateActiveInteraction()
	{
	}

	[Token(Token = "0x6004815")]
	[Address(RVA = "0xCD71C0", Offset = "0xCD5FC0", Length = "0xF2")]
	public void UpdateHoldInteractionActive()
	{
	}

	[Token(Token = "0x6004816")]
	[Address(RVA = "0xCD72C0", Offset = "0xCD60C0", Length = "0x30")]
	public void ResetInteraction()
	{
	}

	[Token(Token = "0x6004817")]
	[Address(RVA = "0xCD72F0", Offset = "0xCD60F0", Length = "0xAF")]
	private bool ShouldCancelHoldInteraction()
	{
		return false;
	}

	[Token(Token = "0x6004818")]
	[Address(RVA = "0xCD73A0", Offset = "0xCD61A0", Length = "0x9F")]
	public void TryCancelHoldInteraction()
	{
	}

	[Token(Token = "0x6004819")]
	[Address(RVA = "0xCD7440", Offset = "0xCD6240", Length = "0x8D")]
	public bool InteractiveObjectsProcessAltFire()
	{
		return false;
	}

	[Token(Token = "0x600481A")]
	[Address(RVA = "0xCD74D0", Offset = "0xCD62D0", Length = "0x518")]
	public bool InteractiveObjectsProcessInteraction()
	{
		return false;
	}

	[Token(Token = "0x600481B")]
	[Address(RVA = "0xCD79F0", Offset = "0xCD67F0", Length = "0x20F")]
	public bool ItemCanEquipInHands(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600481C")]
	[Address(RVA = "0xCD7C00", Offset = "0xCD6A00", Length = "0x2A0")]
	public float ComputeModifiedPickupRange(float range)
	{
		return 0f;
	}

	[Token(Token = "0x600481D")]
	[Address(RVA = "0xCD7EB0", Offset = "0xCD6CB0", Length = "0x27F")]
	private bool ItemShouldEquipOnPickup(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600481E")]
	[Address(RVA = "0xCD8130", Offset = "0xCD6F30", Length = "0x1BE")]
	public bool PlayerHoldingTorchThatCanBeLit()
	{
		return false;
	}

	[Token(Token = "0x600481F")]
	[Address(RVA = "0xCD82F0", Offset = "0xCD70F0", Length = "0x8D")]
	public bool ObjectUnderCrosshairCanLightTorch()
	{
		return false;
	}

	[Token(Token = "0x6004820")]
	[Address(RVA = "0xCD8380", Offset = "0xCD7180", Length = "0x385")]
	private bool ShouldSuppressCrosshairs()
	{
		return false;
	}

	[Token(Token = "0x6004825")]
	[Address(RVA = "0xCD8CB0", Offset = "0xCD7AB0", Length = "0xA5B")]
	public void EquipItem(GearItem gi, bool fromDeserialize)
	{
	}

	[Token(Token = "0x6004826")]
	[Address(RVA = "0xCD9710", Offset = "0xCD8510", Length = "0x1E3")]
	public void OnEquipItemBegin()
	{
	}

	[Token(Token = "0x6004827")]
	[Address(RVA = "0xCD9900", Offset = "0xCD8700", Length = "0x256")]
	public void EquipLastItemInHands()
	{
	}

	[Token(Token = "0x6004828")]
	[Address(RVA = "0xCD9B60", Offset = "0xCD8960", Length = "0x14")]
	public GearItem GetItemInHandsToRestoreAfterInteraction()
	{
		return null;
	}

	[Token(Token = "0x6004829")]
	[Address(RVA = "0xCD9B80", Offset = "0xCD8980", Length = "0x52")]
	public void ClearHeldItemRestriction()
	{
	}

	[Token(Token = "0x600482A")]
	[Address(RVA = "0xCD9BE0", Offset = "0xCD89E0", Length = "0x107")]
	public bool IsHeldItemRestricted(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600482B")]
	[Address(RVA = "0xCD9CF0", Offset = "0xCD8AF0", Length = "0x22A")]
	public void RestrictHeldItems(HeldItemRestriction restriction)
	{
	}

	[Token(Token = "0x600482C")]
	[Address(RVA = "0xCD9F20", Offset = "0xCD8D20", Length = "0xF")]
	public bool CanHolsterItemInHand()
	{
		return false;
	}

	[Token(Token = "0x600482D")]
	[Address(RVA = "0xCD9F30", Offset = "0xCD8D30", Length = "0x1B3")]
	public bool CanHolsterItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600482E")]
	[Address(RVA = "0xCDA0F0", Offset = "0xCD8EF0", Length = "0x82")]
	public void UnequipItemInHands()
	{
	}

	[Token(Token = "0x600482F")]
	[Address(RVA = "0xCDA180", Offset = "0xCD8F80", Length = "0x2D")]
	public void MaybeRestoreSaveItemInHands()
	{
	}

	[Token(Token = "0x6004830")]
	[Address(RVA = "0xCDA1B0", Offset = "0xCD8FB0", Length = "0x1D1")]
	public void UnequipImmediate(bool saveLastItem)
	{
	}

	[Token(Token = "0x6004831")]
	[Address(RVA = "0xCDA390", Offset = "0xCD9190", Length = "0x1C5")]
	public void AutoUnequipItemInHandsBeforeInteraction(bool pauseFlare = true)
	{
	}

	[Token(Token = "0x6004832")]
	[Address(RVA = "0xCDA560", Offset = "0xCD9360", Length = "0x101")]
	public void AutoEquipItemInHandsAfterInteraction()
	{
	}

	[Token(Token = "0x6004833")]
	[Address(RVA = "0xCDA670", Offset = "0xCD9470", Length = "0x4A0")]
	public static void TurnLightOffImmediate(bool pauseFlare, GearItem gi)
	{
	}

	[Token(Token = "0x6004834")]
	[Address(RVA = "0xCDAB20", Offset = "0xCD9920", Length = "0x475")]
	private void PauseLight(GearItem gi)
	{
	}

	[Token(Token = "0x6004835")]
	[Address(RVA = "0xCDAFA0", Offset = "0xCD9DA0", Length = "0x35F")]
	private void ResumeLight(GearItem gi)
	{
	}

	[Token(Token = "0x6004836")]
	[Address(RVA = "0xCDB300", Offset = "0xCDA100", Length = "0x193")]
	public void UnequipItemInHandsSkipAnimation()
	{
	}

	[Token(Token = "0x6004837")]
	[Address(RVA = "0xCDB4A0", Offset = "0xCDA2A0", Length = "0x53B")]
	public void StopAudioForEquippedItem(GearItem gi)
	{
	}

	[Token(Token = "0x6004838")]
	[Address(RVA = "0xCDB9E0", Offset = "0xCDA7E0", Length = "0x7E9")]
	public void CancelItemInHandsAction(bool cancelByUser)
	{
	}

	[Token(Token = "0x6004839")]
	[Address(RVA = "0xCDC1D0", Offset = "0xCDAFD0", Length = "0x2A2")]
	public void UnequipItemInHandsForPlacement()
	{
	}

	[Token(Token = "0x600483A")]
	[Address(RVA = "0xCDC480", Offset = "0xCDB280", Length = "0x52")]
	public void ClearLastUnequippedItem()
	{
	}

	[Token(Token = "0x600483B")]
	[Address(RVA = "0xCDC4E0", Offset = "0xCDB2E0", Length = "0x8C")]
	public bool UseInventoryItem(GearItem gi, bool suppressWeaponsErrorMessage = false)
	{
		return false;
	}

	[Token(Token = "0x600483C")]
	[Address(RVA = "0xCDC570", Offset = "0xCDB370", Length = "0x1187")]
	public bool UseInventoryItem(GearItem gi, ItemLiquidVolume volumeAvailable, bool suppressWeaponsErrorMessage = false)
	{
		return false;
	}

	[Token(Token = "0x600483D")]
	[Address(RVA = "0xCDD700", Offset = "0xCDC500", Length = "0x5F")]
	public bool TryAddToExistingStackable(GearItem gearToAdd, int numUnits, out GearItem existingGearItem)
	{
		existingGearItem = null;
		return false;
	}

	[Token(Token = "0x600483E")]
	[Address(RVA = "0xCDD760", Offset = "0xCDC560", Length = "0x2A4")]
	public bool TryAddToExistingStackable(GearItem gearToAdd, float normalizedCondition, int numUnits, out GearItem existingGearItem)
	{
		existingGearItem = null;
		return false;
	}

	[Token(Token = "0x600483F")]
	[Address(RVA = "0xCDDA10", Offset = "0xCDC810", Length = "0x9EB")]
	public GearItem AddItemToPlayerInventory(GearItem gi, bool trackItemLooted = true, bool enableNotificationFlag = false)
	{
		return null;
	}

	[Token(Token = "0x6004840")]
	[Address(RVA = "0xCDE400", Offset = "0xCDD200", Length = "0x293")]
	public float GetFoodCaloriesTotal()
	{
		return 0f;
	}

	[Token(Token = "0x6004841")]
	[Address(RVA = "0xCDE6A0", Offset = "0xCDD4A0", Length = "0x61")]
	public ItemLiquidVolume GetTotalLiters(LiquidType liquidType)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6004842")]
	[Address(RVA = "0xCDE710", Offset = "0xCDD510", Length = "0x41D")]
	public ItemLiquidVolume GetCapacityLiters(LiquidType liquidType)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6004843")]
	[Address(RVA = "0xCDEB30", Offset = "0xCDD930", Length = "0x45E")]
	public ItemLiquidVolume AddLiquidToInventory(ItemLiquidVolume litersToAdd, LiquidType liquidType)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6004844")]
	[Address(RVA = "0xCDEF90", Offset = "0xCDDD90", Length = "0xA9C")]
	public ItemLiquidVolume DeductLiquidFromInventory(ItemLiquidVolume literDeduction, LiquidType liquidType)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6004845")]
	[Address(RVA = "0xCDFA30", Offset = "0xCDE830", Length = "0x2A5")]
	private ItemLiquidVolume DeductWaterFromInventory(ItemLiquidVolume literDeduction, LiquidQuality liquidQuality)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6004846")]
	[Address(RVA = "0xCDFCE0", Offset = "0xCDEAE0", Length = "0x738")]
	public GearItem AddPowderToInventory(ItemWeight amount, PowderType type)
	{
		return null;
	}

	[Token(Token = "0x6004847")]
	[Address(RVA = "0xCE0420", Offset = "0xCDF220", Length = "0x7BD")]
	public ItemWeight DeductPowderFromInventory(ItemWeight deduction, PowderType type)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6004848")]
	[Address(RVA = "0xCE0BE0", Offset = "0xCDF9E0", Length = "0x61")]
	public ItemWeight GetTotalPowderWeight(PowderType type)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6004849")]
	[Address(RVA = "0xCE0C50", Offset = "0xCDFA50", Length = "0x3E5")]
	public GearItem AddItemCONSOLE(string name, int count, float normalizedCondition = 1f)
	{
		return null;
	}

	[Token(Token = "0x600484A")]
	[Address(RVA = "0xCE1040", Offset = "0xCDFE40", Length = "0x32E")]
	public void ConsumeUnitFromInventory(GameObject go)
	{
	}

	[Token(Token = "0x600484B")]
	[Address(RVA = "0xCE1370", Offset = "0xCE0170", Length = "0x33D")]
	public bool UseSmashableItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600484C")]
	[Address(RVA = "0xCE16B0", Offset = "0xCE04B0", Length = "0x884")]
	private void TreatAffliction(FirstAidItem firstAidItem, AfflictionType afflictionType, AfflictionBodyArea location, int afflictionId)
	{
	}

	[Token(Token = "0x600484D")]
	[Address(RVA = "0xCE1F40", Offset = "0xCE0D40", Length = "0x2B2")]
	private void FirstAidConsumed(GearItem gi)
	{
	}

	[Token(Token = "0x600484E")]
	[Address(RVA = "0xCE2200", Offset = "0xCE1000", Length = "0x3F6")]
	public void RemoveFirstAidItem(GearItem gi)
	{
	}

	[Token(Token = "0x600484F")]
	[Address(RVA = "0xCE2600", Offset = "0xCE1400", Length = "0x433")]
	public void OnFirstAidComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x6004850")]
	[Address(RVA = "0xCE2A40", Offset = "0xCE1840", Length = "0xDB")]
	public bool IsTreatingAffliction()
	{
		return false;
	}

	[Token(Token = "0x6004851")]
	[Address(RVA = "0xCE2B20", Offset = "0xCE1920", Length = "0xED")]
	public void OnEatingComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x6004852")]
	[Address(RVA = "0xCE2C10", Offset = "0xCE1A10", Length = "0x65D")]
	public void OnDrinkWaterComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x6004853")]
	[Address(RVA = "0xCE3270", Offset = "0xCE2070", Length = "0xC7")]
	public void RemoveWater(WaterSupply ws, ItemLiquidVolume removedLiters)
	{
	}

	[Token(Token = "0x6004854")]
	[Address(RVA = "0xCE3340", Offset = "0xCE2140", Length = "0x571")]
	public void OnPurifyWaterComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x6004855")]
	[Address(RVA = "0xCE38C0", Offset = "0xCE26C0", Length = "0x7D8")]
	public void OnFoodOpeningComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x6004856")]
	[Address(RVA = "0xCE40A0", Offset = "0xCE2EA0", Length = "0x9B9")]
	public void OnSmashComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x6004857")]
	[Address(RVA = "0xCE4A60", Offset = "0xCE3860", Length = "0x48F")]
	public float GetHeldLightIntensity()
	{
		return 0f;
	}

	[Token(Token = "0x6004858")]
	[Address(RVA = "0xCE4EF0", Offset = "0xCE3CF0", Length = "0x3AC")]
	public Color GetHeldLightColor()
	{
		return default(Color);
	}

	[Token(Token = "0x6004859")]
	[Address(RVA = "0xCE52A0", Offset = "0xCE40A0", Length = "0x270")]
	private ItemLiquidVolume CalculateWaterVolumeToDrink(ItemLiquidVolume availableLiters)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x600485A")]
	[Address(RVA = "0xCE5520", Offset = "0xCE4320", Length = "0x420")]
	private bool UseWeaponInventoryItem(GearItem gi, bool suppressWeaponsErrorMessage = false)
	{
		return false;
	}

	[Token(Token = "0x600485B")]
	[Address(RVA = "0xCE5950", Offset = "0xCE4750", Length = "0x311")]
	public void OpenAndUseFoodInventoryItem(GearItem gi, CanOpeningItem gearOpenedWith)
	{
	}

	[Token(Token = "0x600485C")]
	[Address(RVA = "0xCE5C70", Offset = "0xCE4A70", Length = "0xBD")]
	private bool CanUseFirstAidItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600485D")]
	[Address(RVA = "0xCE5D30", Offset = "0xCE4B30", Length = "0x438")]
	private bool CanUseFoodInventoryItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600485E")]
	[Address(RVA = "0xCE6170", Offset = "0xCE4F70", Length = "0x892")]
	private bool UseFoodInventoryItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600485F")]
	[Address(RVA = "0xCE6A10", Offset = "0xCE5810", Length = "0x4A3")]
	private bool DrinkFromWaterSupply(WaterSupply ws, ItemLiquidVolume volumeAvailable)
	{
		return false;
	}

	[Token(Token = "0x6004860")]
	[Address(RVA = "0xCE6EC0", Offset = "0xCE5CC0", Length = "0x2BF")]
	private bool UseFireStarterInventoryItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6004861")]
	[Address(RVA = "0xCE7180", Offset = "0xCE5F80", Length = "0x2EE")]
	private bool UseFPSMeshItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6004862")]
	[Address(RVA = "0xCE7470", Offset = "0xCE6270", Length = "0x2C8")]
	private bool UseMatchesItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6004863")]
	[Address(RVA = "0xCE7740", Offset = "0xCE6540", Length = "0x48C")]
	public bool TreatAfflictionWithFirstAid(FirstAidItem firstAidItem, Affliction afflictionSelected)
	{
		return false;
	}

	[Token(Token = "0x6004864")]
	[Address(RVA = "0xCE7BD0", Offset = "0xCE69D0", Length = "0x461")]
	private bool UseFirstAidItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6004865")]
	[Address(RVA = "0xCE8040", Offset = "0xCE6E40", Length = "0x1B7")]
	private bool UseBedItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6004866")]
	[Address(RVA = "0xCE8200", Offset = "0xCE7000", Length = "0x1E1")]
	private bool PlaceSnare(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6004867")]
	[Address(RVA = "0xCE83F0", Offset = "0xCE71F0", Length = "0x40B")]
	private bool UseWaterPurificationItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6004868")]
	[Address(RVA = "0xCE8800", Offset = "0xCE7600", Length = "0x1DA")]
	private bool UseSprayPaintCan(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6004869")]
	[Address(RVA = "0xCE89E0", Offset = "0xCE77E0", Length = "0x134")]
	private bool PlaceCookingPot(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600486A")]
	[Address(RVA = "0xCE8B20", Offset = "0xCE7920", Length = "0x377")]
	private bool ActivateHeatPad(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600486B")]
	[Address(RVA = "0xCE8EA0", Offset = "0xCE7CA0", Length = "0x1C3")]
	private void OnHeatPadActivated(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x600486C")]
	[Address(RVA = "0xCE9070", Offset = "0xCE7E70", Length = "0x1318")]
	private void UpdateItemInHands()
	{
	}

	[Token(Token = "0x600486D")]
	[Address(RVA = "0xCEA390", Offset = "0xCE9190", Length = "0x3E6")]
	private void UnequipItemInHandsInternal()
	{
	}

	[Token(Token = "0x600486E")]
	[Address(RVA = "0xCEA780", Offset = "0xCE9580", Length = "0x1AC")]
	public void OnExtinguishComplete()
	{
	}

	[Token(Token = "0x600486F")]
	[Address(RVA = "0xCEA930", Offset = "0xCE9730", Length = "0x585")]
	public void OnUnequipItemInHandInternalComplete()
	{
	}

	[Token(Token = "0x6004870")]
	[Address(RVA = "0xCEAEC0", Offset = "0xCE9CC0", Length = "0x358")]
	public ICraftingResult InstantiateCraftedItemInPlayerInventory(ICraftingResult result, int units = 1, float normalizedCondition = 1f, InventoryInstantiateFlags flags = InventoryInstantiateFlags.None)
	{
		return null;
	}

	[Token(Token = "0x6004871")]
	[Address(RVA = "0xCEB220", Offset = "0xCEA020", Length = "0x12C")]
	public DecorationItem InstantiateDecorationItemInPlayerInventory(DecorationItem decorationItem, InventoryInstantiateFlags flags)
	{
		return null;
	}

	[Token(Token = "0x6004872")]
	[Address(RVA = "0xCEB350", Offset = "0xCEA150", Length = "0x135")]
	public GearItem InstantiateItemInPlayerInventory(GearItem gearItem, int units = 1, float normalizedCondition = 1f, InventoryInstantiateFlags flags = InventoryInstantiateFlags.None)
	{
		return null;
	}

	[Token(Token = "0x6004873")]
	[Address(RVA = "0xCEB490", Offset = "0xCEA290", Length = "0x9AC")]
	public GearItem InstantiateItemInPlayerInventory(AssetReferenceGearItem assetReference, int units = 1, float normalizedCondition = 1f, InventoryInstantiateFlags flags = InventoryInstantiateFlags.None)
	{
		return null;
	}

	[Token(Token = "0x6004874")]
	[Address(RVA = "0xCEBE40", Offset = "0xCEAC40", Length = "0x2A")]
	public GearItem InstantiateItemAtPlayersFeet(GearItem gearItemPrefab, int numUnits)
	{
		return null;
	}

	[Token(Token = "0x6004875")]
	[Address(RVA = "0xCEBE70", Offset = "0xCEAC70", Length = "0x14A")]
	public GearItem InstantiateItemAtPlayersFeet(AssetReferenceGearItem assetReference, int numUnits)
	{
		return null;
	}

	[Token(Token = "0x6004876")]
	[Address(RVA = "0xCEBFC0", Offset = "0xCEADC0", Length = "0x52")]
	public GearItem InstantiateItemAtLocation(GearItem gearItemPrefab, int numUnits, Vector3 position, bool stickToGround)
	{
		return null;
	}

	[Token(Token = "0x6004877")]
	[Address(RVA = "0xCEC020", Offset = "0xCEAE20", Length = "0x26A")]
	public GearItem InstantiateItemAtLocation(AssetReferenceGearItem assetReference, int numUnits, Vector3 position, bool stickToGround)
	{
		return null;
	}

	[Token(Token = "0x6004878")]
	[Address(RVA = "0xCEC290", Offset = "0xCEB090", Length = "0x165")]
	private bool ShouldDestroyFoodAfterEating(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6004879")]
	[Address(RVA = "0xCEC400", Offset = "0xCEB200", Length = "0x141")]
	private void MaybeUpdateEquipItem()
	{
	}

	[Token(Token = "0x600487A")]
	[Address(RVA = "0xCEC550", Offset = "0xCEB350", Length = "0xCC")]
	private bool IsReadyToEquip()
	{
		return false;
	}

	[Token(Token = "0x600487B")]
	[Address(RVA = "0xCEC620", Offset = "0xCEB420", Length = "0x8")]
	private bool HasSavedItemInHands()
	{
		return false;
	}

	[Token(Token = "0x600487C")]
	[Address(RVA = "0xCEC630", Offset = "0xCEB430", Length = "0xE88")]
	private void EatingComplete_Internal(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x600487D")]
	[Address(RVA = "0xCED4C0", Offset = "0xCEC2C0", Length = "0x285")]
	private void HandleEatingCompleteStackableFoodItem(GearItem foodItem)
	{
	}

	[Token(Token = "0x600487E")]
	[Address(RVA = "0xCED750", Offset = "0xCEC550", Length = "0x2D4")]
	public bool CheckIfCanDropGearItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600487F")]
	[Address(RVA = "0xCEDA30", Offset = "0xCEC830", Length = "0x38E")]
	private bool CheckIfInsideBlockPlacement(Vector3 position, float radius)
	{
		return false;
	}

	[Token(Token = "0x6004880")]
	[Address(RVA = "0xCEDDC0", Offset = "0xCECBC0", Length = "0x3C")]
	public void RequestLookAtTarget(LookAtTargetForTime lookAtTargetForTime)
	{
	}

	[Token(Token = "0x6004881")]
	[Address(RVA = "0xCEDE00", Offset = "0xCECC00", Length = "0x8")]
	public void StopLookAtTarget()
	{
	}

	[Token(Token = "0x6004882")]
	[Address(RVA = "0xCEDE10", Offset = "0xCECC10", Length = "0x18")]
	private void UpdateLookAt()
	{
	}

	[Token(Token = "0x6004883")]
	[Address(RVA = "0xCEDE30", Offset = "0xCECC30", Length = "0x194")]
	public bool ShouldShowSprayPaintCan()
	{
		return false;
	}

	[Token(Token = "0x6004884")]
	[Address(RVA = "0xCEDFD0", Offset = "0xCECDD0", Length = "0x27")]
	public bool IsInDecalPlacementMode()
	{
		return false;
	}

	[Token(Token = "0x6004885")]
	[Address(RVA = "0xCEE000", Offset = "0xCECE00", Length = "0x3BC")]
	public bool StartPlaceDecal(GearItem gearItem, ProjectileType decalShape, DecalColour decalColour, float placementDistance)
	{
		return false;
	}

	[Token(Token = "0x6004886")]
	[Address(RVA = "0xCEE560", Offset = "0xCED360", Length = "0x251")]
	public void EraseDecal(DecalProjectorInstance decalInstance)
	{
	}

	[Token(Token = "0x6004887")]
	[Address(RVA = "0xCEE7C0", Offset = "0xCED5C0", Length = "0x7E")]
	public void ProcessReloadAction()
	{
	}

	[Token(Token = "0x6004888")]
	[Address(RVA = "0xCEE840", Offset = "0xCED640", Length = "0x122")]
	private void CleanupDecalToRemove()
	{
	}

	[Token(Token = "0x6004889")]
	[Address(RVA = "0xCEE970", Offset = "0xCED770", Length = "0x8B0")]
	private void UpdatePlaceDecal()
	{
	}

	[Token(Token = "0x600488A")]
	[Address(RVA = "0xCEF240", Offset = "0xCEE040", Length = "0xC0")]
	private void HandleNowhereToHideEventSpecificBehaviour(DecalProjectorInstance decalInstance)
	{
	}

	[Token(Token = "0x600488B")]
	[Address(RVA = "0xCEF310", Offset = "0xCEE110", Length = "0x33A")]
	private void UpdateOverlappingDecalInPlace()
	{
	}

	[Token(Token = "0x600488C")]
	[Address(RVA = "0xCEF650", Offset = "0xCEE450", Length = "0xA8")]
	private void TintDecalDuringPlacement(DecalProjectorInstance decalInstance, MeshLocationCategory newCategory)
	{
	}

	[Token(Token = "0x600488D")]
	[Address(RVA = "0xCEF720", Offset = "0xCEE520", Length = "0x9E")]
	private void TintPlacedDecal(DecalProjectorInstance decalInstance)
	{
	}

	[Token(Token = "0x600488E")]
	[Address(RVA = "0xCEF7C0", Offset = "0xCEE5C0", Length = "0x92")]
	private Color GetColourForDecalColour(DecalColour decalColour)
	{
		return default(Color);
	}

	[Token(Token = "0x600488F")]
	[Address(RVA = "0xCEF860", Offset = "0xCEE660", Length = "0x30A")]
	private void AttemptToPlaceDecal()
	{
	}

	[Token(Token = "0x6004890")]
	[Address(RVA = "0xCEFB70", Offset = "0xCEE970", Length = "0x112")]
	private void AttemptToRemoveDecalInPlace()
	{
	}

	[Token(Token = "0x6004891")]
	[Address(RVA = "0xCEFC90", Offset = "0xCEEA90", Length = "0xDA")]
	public void StopSprayPaintAudio()
	{
	}

	[Token(Token = "0x6004892")]
	[Address(RVA = "0xCEFD70", Offset = "0xCEEB70", Length = "0x477")]
	private void OnCompletedDecalPlaceDown()
	{
	}

	[Token(Token = "0x6004893")]
	[Address(RVA = "0xCF01F0", Offset = "0xCEEFF0", Length = "0xAC")]
	public void OnDecalDeserialized(DecalProjectorInstance decal)
	{
	}

	[Token(Token = "0x6004894")]
	[Address(RVA = "0xCF02A0", Offset = "0xCEF0A0", Length = "0x7D")]
	public void OnDecalRemoved(DecalProjectorInstance decal)
	{
	}

	[Token(Token = "0x6004895")]
	[Address(RVA = "0xCF0320", Offset = "0xCEF120", Length = "0x46")]
	public void UpdatePlacementDecalReveal(float amount, bool isErasing)
	{
	}

	[Token(Token = "0x6004896")]
	[Address(RVA = "0xCF0370", Offset = "0xCEF170", Length = "0x33D")]
	private void ExitDecalPlacement()
	{
	}

	[Token(Token = "0x6004897")]
	[Address(RVA = "0xCF06B0", Offset = "0xCEF4B0", Length = "0x87")]
	private void CancelDecalPlacement()
	{
	}

	[Token(Token = "0x6004898")]
	[Address(RVA = "0xCF0740", Offset = "0xCEF540", Length = "0x206")]
	public void InterruptDecalAction()
	{
	}

	[Token(Token = "0x6004899")]
	[Address(RVA = "0xCF0950", Offset = "0xCEF750", Length = "0xBC")]
	public void SuspendDecalPlacement()
	{
	}

	[Token(Token = "0x600489D")]
	[Address(RVA = "0xCF0AE0", Offset = "0xCEF8E0", Length = "0xDB")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600489E")]
	[Address(RVA = "0xCF0BC0", Offset = "0xCEF9C0", Length = "0x193")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600489F")]
	[Address(RVA = "0xCF0D60", Offset = "0xCEFB60", Length = "0x1EB")]
	private void InitPlaceMeshMode()
	{
	}

	[Token(Token = "0x60048A0")]
	[Address(RVA = "0xCF0F50", Offset = "0xCEFD50", Length = "0x396")]
	public void UpdatePlaceMesh()
	{
	}

	[Token(Token = "0x60048A1")]
	[Address(RVA = "0xCF12F0", Offset = "0xCF00F0", Length = "0x94")]
	public void SetPlacementColors(Color validColor, Color invalidColor)
	{
	}

	[Token(Token = "0x60048A2")]
	[Address(RVA = "0xCF1390", Offset = "0xCF0190", Length = "0xD2")]
	public void ResetPlacementColors()
	{
	}

	[Token(Token = "0x60048A3")]
	[Address(RVA = "0xCF1470", Offset = "0xCF0270", Length = "0x43")]
	private void UpdatePlacementDistance()
	{
	}

	[Token(Token = "0x60048A4")]
	[Address(RVA = "0xCF14C0", Offset = "0xCF02C0", Length = "0x274")]
	private bool CanPlaceCookingItemOnPoint(GearItem obj)
	{
		return false;
	}

	[Token(Token = "0x60048A5")]
	[Address(RVA = "0xCF1740", Offset = "0xCF0540", Length = "0xF4")]
	private bool IsOverCreatureOrRemains(GameObject go)
	{
		return false;
	}

	[Token(Token = "0x60048A6")]
	[Address(RVA = "0xCF1840", Offset = "0xCF0640", Length = "0x2F2")]
	private bool CheckForValidHolePlacement(vp_FPSCamera fpsCamera)
	{
		return false;
	}

	[Token(Token = "0x60048A7")]
	[Address(RVA = "0xCF1B40", Offset = "0xCF0940", Length = "0x3A61")]
	private MeshLocationCategory DoPositionCheck()
	{
		return default(MeshLocationCategory);
	}

	[Token(Token = "0x60048A8")]
	[Address(RVA = "0xCF55B0", Offset = "0xCF43B0", Length = "0x34F")]
	private bool IsHitPointOutOfBounds(RaycastHit hit)
	{
		return false;
	}

	[Token(Token = "0x60048A9")]
	[Address(RVA = "0xCF5900", Offset = "0xCF4700", Length = "0x110")]
	private bool IsOverDecorationItemThatPreventsStacking(GameObject hitGameObject)
	{
		return false;
	}

	[Token(Token = "0x60048AA")]
	[Address(RVA = "0xCF5A20", Offset = "0xCF4820", Length = "0x1AD")]
	private static bool IsOverAFire(GameObject hitGameObject)
	{
		return false;
	}

	[Token(Token = "0x60048AB")]
	[Address(RVA = "0xCF5BD0", Offset = "0xCF49D0", Length = "0x136")]
	public bool IsPlacementPending(GameObject gameobject)
	{
		return false;
	}

	[Token(Token = "0x60048AC")]
	[Address(RVA = "0xCF5D10", Offset = "0xCF4B10", Length = "0x39D")]
	public bool CanPlaceMeshImmediately(GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x60048AD")]
	[Address(RVA = "0xCF60B0", Offset = "0xCF4EB0", Length = "0x38E")]
	private void UpdateObjectToPlaceTransform(Vector3 position, Quaternion rotation, Vector3 userRotationAxis)
	{
	}

	[Token(Token = "0x60048AE")]
	[Address(RVA = "0xCF6440", Offset = "0xCF5240", Length = "0x13A")]
	private void ApplyObjectPositionToDecorationItemChain()
	{
	}

	[Token(Token = "0x60048AF")]
	[Address(RVA = "0xCF6580", Offset = "0xCF5380", Length = "0xA4")]
	private void UpdateObjectToPlaceTransform(Vector3 position, Quaternion rotation)
	{
	}

	[Token(Token = "0x60048B0")]
	[Address(RVA = "0xCF6630", Offset = "0xCF5430", Length = "0x9D")]
	private float GetDefaultPlacementDistance()
	{
		return 0f;
	}

	[Token(Token = "0x60048B1")]
	[Address(RVA = "0xCF66D0", Offset = "0xCF54D0", Length = "0x5A")]
	public bool StartPlaceMesh(GameObject objectToPlace, PlaceMeshFlags flags, PlaceMeshRules rules = PlaceMeshRules.Default)
	{
		return false;
	}

	[Token(Token = "0x60048B2")]
	[Address(RVA = "0xCF6730", Offset = "0xCF5530", Length = "0xC26")]
	public bool StartPlaceMesh(GameObject objectToPlace, float placementDistance, PlaceMeshFlags flags, PlaceMeshRules rules = PlaceMeshRules.Default)
	{
		return false;
	}

	[Token(Token = "0x60048B3")]
	[Address(RVA = "0xCF7360", Offset = "0xCF6160", Length = "0x624")]
	private bool CanPlaceCurrentPlaceable()
	{
		return false;
	}

	[Token(Token = "0x60048B4")]
	[Address(RVA = "0xCF79E0", Offset = "0xCF67E0", Length = "0xD2")]
	public void AttemptToPlaceObject()
	{
	}

	[Token(Token = "0x60048B5")]
	[Address(RVA = "0xCF7AC0", Offset = "0xCF68C0", Length = "0x92A")]
	private void AttemptToPlaceMesh()
	{
	}

	[Token(Token = "0x60048B6")]
	[Address(RVA = "0xCF83F0", Offset = "0xCF71F0", Length = "0x121")]
	public void ProcessRemoveObjectPressed()
	{
	}

	[Token(Token = "0x60048B7")]
	[Address(RVA = "0xCF8520", Offset = "0xCF7320", Length = "0x258")]
	public void StowOrDropPlaceMesh()
	{
	}

	[Token(Token = "0x60048B8")]
	[Address(RVA = "0xCF8780", Offset = "0xCF7580", Length = "0x106")]
	public void CancelPlacementMode()
	{
	}

	[Token(Token = "0x60048B9")]
	[Address(RVA = "0xCF8890", Offset = "0xCF7690", Length = "0x275")]
	private void CancelPlaceMesh()
	{
	}

	[Token(Token = "0x60048BA")]
	[Address(RVA = "0xCF8B10", Offset = "0xCF7910", Length = "0xFBA")]
	public void ExitMeshPlacement()
	{
	}

	[Token(Token = "0x60048BB")]
	[Address(RVA = "0xCF9AD0", Offset = "0xCF88D0", Length = "0x490")]
	public void CleanUpPlaceMesh()
	{
	}

	[Token(Token = "0x60048BC")]
	[Address(RVA = "0xCF9F70", Offset = "0xCF8D70", Length = "0x17E")]
	private void MaybeStartWaitingForCollisionOverlapsToResolve()
	{
	}

	[Token(Token = "0x60048BD")]
	[Address(RVA = "0xCFA0F0", Offset = "0xCF8EF0", Length = "0x1C3")]
	public bool ItemInHandsPlaceable()
	{
		return false;
	}

	[Token(Token = "0x60048BE")]
	[Address(RVA = "0xCFA2C0", Offset = "0xCF90C0", Length = "0x1BC")]
	public string GetPlaceMeshFireButtonString()
	{
		return null;
	}

	[Token(Token = "0x60048BF")]
	[Address(RVA = "0xCFA480", Offset = "0xCF9280", Length = "0x175")]
	public string GetPlaceMeshAltFireButtonString()
	{
		return null;
	}

	[Token(Token = "0x60048C0")]
	[Address(RVA = "0xCFA600", Offset = "0xCF9400", Length = "0x137")]
	public string GetPlaceMeshRotateLeftButtonString()
	{
		return null;
	}

	[Token(Token = "0x60048C1")]
	[Address(RVA = "0xCFA740", Offset = "0xCF9540", Length = "0x137")]
	public string GetPlaceMeshRotateRightButtonString()
	{
		return null;
	}

	[Token(Token = "0x60048C2")]
	[Address(RVA = "0xCFA880", Offset = "0xCF9680", Length = "0x137")]
	public string GetPlaceMeshRotateMouseScrollButtonString()
	{
		return null;
	}

	[Token(Token = "0x60048C3")]
	[Address(RVA = "0xCFA9C0", Offset = "0xCF97C0", Length = "0x84")]
	public string GetPlaceMeshHolsterButtonString()
	{
		return null;
	}

	[Token(Token = "0x60048C4")]
	[Address(RVA = "0xCFAA50", Offset = "0xCF9850", Length = "0x84")]
	public string GetPlaceMeshReloadButtonString()
	{
		return null;
	}

	[Token(Token = "0x60048C5")]
	[Address(RVA = "0xCFAAE0", Offset = "0xCF98E0", Length = "0x8")]
	public GameObject GetObjectToPlace()
	{
		return null;
	}

	[Token(Token = "0x60048C6")]
	[Address(RVA = "0xCFAAF0", Offset = "0xCF98F0", Length = "0x3D")]
	public bool IsInPlacementMode()
	{
		return false;
	}

	[Token(Token = "0x60048C7")]
	[Address(RVA = "0xCFAB30", Offset = "0xCF9930", Length = "0xEA")]
	public bool IsInMeshPlacementMode()
	{
		return false;
	}

	[Token(Token = "0x60048C8")]
	[Address(RVA = "0xCFAC20", Offset = "0xCF9A20", Length = "0xE1")]
	public void RotateCurrentPlaceable()
	{
	}

	[Token(Token = "0x60048C9")]
	[Address(RVA = "0xCFAD10", Offset = "0xCF9B10", Length = "0x20A")]
	public bool ObjectToPlaceInInventory()
	{
		return false;
	}

	[Token(Token = "0x60048CA")]
	[Address(RVA = "0xCFAF20", Offset = "0xCF9D20", Length = "0x54")]
	public bool IsRendererBeingPlaced(Renderer renderer)
	{
		return false;
	}

	[Token(Token = "0x60048CB")]
	[Address(RVA = "0xCFAF80", Offset = "0xCF9D80", Length = "0x3B5")]
	private bool VisPointVisible(Transform xform)
	{
		return false;
	}

	[Token(Token = "0x60048CC")]
	[Address(RVA = "0xCFB340", Offset = "0xCFA140", Length = "0x680")]
	private bool VisPointsAllVisible(GameObject parent)
	{
		return false;
	}

	[Token(Token = "0x60048CD")]
	[Address(RVA = "0xCFB9D0", Offset = "0xCFA7D0", Length = "0xD11")]
	private MeshLocationCategory CalculateGhostedMeshValidPosition(RaycastHit hit)
	{
		return default(MeshLocationCategory);
	}

	[Token(Token = "0x60048CE")]
	[Address(RVA = "0xCFC6F0", Offset = "0xCFB4F0", Length = "0x973")]
	private void PrepareGhostedObject()
	{
	}

	[Token(Token = "0x60048CF")]
	[Address(RVA = "0xCFD070", Offset = "0xCFBE70", Length = "0x1011")]
	private void PlaceMeshInWorld()
	{
	}

	[Token(Token = "0x60048D0")]
	[Address(RVA = "0xCFE090", Offset = "0xCFCE90", Length = "0x2B3")]
	private void InitializePropertyBlocks()
	{
	}

	[Token(Token = "0x60048D1")]
	[Address(RVA = "0xCFE350", Offset = "0xCFD150", Length = "0x3E")]
	private MaterialPropertyBlock GetPropertyBlockForMeshLocationCategory(MeshLocationCategory category)
	{
		return null;
	}

	[Token(Token = "0x60048D2")]
	[Address(RVA = "0xCFE390", Offset = "0xCFD190", Length = "0x24D")]
	private void TintPreviewRenderers(MeshLocationCategory locationCategory)
	{
	}

	[Token(Token = "0x60048D3")]
	[Address(RVA = "0xCFE5E0", Offset = "0xCFD3E0", Length = "0x1F2")]
	private void ResetTintedRenderers()
	{
	}

	[Token(Token = "0x60048D4")]
	[Address(RVA = "0xCFE7E0", Offset = "0xCFD5E0", Length = "0xEA")]
	private void SetBedPlacedMesh(GameObject go)
	{
	}

	[Token(Token = "0x60048D5")]
	[Address(RVA = "0xCFE8D0", Offset = "0xCFD6D0", Length = "0xE8")]
	private void SetBedRolledMesh(GameObject go)
	{
	}

	[Token(Token = "0x60048D6")]
	[Address(RVA = "0xCFE9C0", Offset = "0xCFD7C0", Length = "0x137")]
	private void SetCampfirePlacedMesh(GameObject go)
	{
	}

	[Token(Token = "0x60048D7")]
	[Address(RVA = "0xCFEB00", Offset = "0xCFD900", Length = "0x17B")]
	private void SetSnarePlacedMesh(GameObject go)
	{
	}

	[Token(Token = "0x60048D8")]
	[Address(RVA = "0xCFEC80", Offset = "0xCFDA80", Length = "0x1A6")]
	private bool ObjectToPlaceIsKeroseneLamp()
	{
		return false;
	}

	[Token(Token = "0x60048D9")]
	[Address(RVA = "0xCFEE30", Offset = "0xCFDC30", Length = "0x1A5")]
	private bool ObjectToPlaceIsFlare()
	{
		return false;
	}

	[Token(Token = "0x60048DA")]
	[Address(RVA = "0xCFEFE0", Offset = "0xCFDDE0", Length = "0x1A5")]
	private bool ObjectToPlaceIsFlashlight()
	{
		return false;
	}

	[Token(Token = "0x60048DB")]
	[Address(RVA = "0xCFF190", Offset = "0xCFDF90", Length = "0x1A5")]
	private bool ObjectToPlaceIsTorch()
	{
		return false;
	}

	[Token(Token = "0x60048DC")]
	[Address(RVA = "0xCFF340", Offset = "0xCFE140", Length = "0x6")]
	private static int GetLayerMaskForPlaceMeshRaycast()
	{
		return 0;
	}

	[Token(Token = "0x60048DD")]
	[Address(RVA = "0xCFF350", Offset = "0xCFE150", Length = "0x44")]
	public static int GetLayerMaskForPlacementPosition()
	{
		return 0;
	}

	[Token(Token = "0x60048DE")]
	[Address(RVA = "0xCFF3A0", Offset = "0xCFE1A0", Length = "0xE2")]
	private bool InvalidCampfireRequiredToBeWithinVolume(Vector3 worldPosition)
	{
		return false;
	}

	[Token(Token = "0x60048DF")]
	[Address(RVA = "0xCFF490", Offset = "0xCFE290", Length = "0x221")]
	private bool CampfireTooCloseToPlayer(Vector3 campfirePos)
	{
		return false;
	}

	[Token(Token = "0x60048E0")]
	[Address(RVA = "0xCFF6C0", Offset = "0xCFE4C0", Length = "0x195")]
	private bool SnowShelterTooCloseToPlayer(Vector3 shelterPos)
	{
		return false;
	}

	[Token(Token = "0x60048E1")]
	[Address(RVA = "0xCFF860", Offset = "0xCFE660", Length = "0x42B")]
	private bool SnowShelterNotOnGroundSnow()
	{
		return false;
	}

	[Token(Token = "0x60048E2")]
	[Address(RVA = "0xCFFC90", Offset = "0xCFEA90", Length = "0x270")]
	private bool SnowShelterTooLow()
	{
		return false;
	}

	[Token(Token = "0x60048E3")]
	[Address(RVA = "0xCFFF10", Offset = "0xCFED10", Length = "0x260")]
	private bool SnowShelterExitBlocked()
	{
		return false;
	}

	[Token(Token = "0x60048E4")]
	[Address(RVA = "0xD00180", Offset = "0xCFEF80", Length = "0x2C1")]
	private bool BedrollOnIce()
	{
		return false;
	}

	[Token(Token = "0x60048E5")]
	[Address(RVA = "0xD00450", Offset = "0xCFF250", Length = "0x329")]
	private bool VisPointsOnSurface(Transform parent, List<Transform> visPoints, float visPointCheckLength, bool debugPlacement)
	{
		return false;
	}

	[Token(Token = "0x60048E6")]
	[Address(RVA = "0xD00780", Offset = "0xCFF580", Length = "0x4BA")]
	private bool IsPositionOverGround()
	{
		return false;
	}

	[Token(Token = "0x60048E7")]
	[Address(RVA = "0xD00C40", Offset = "0xCFFA40", Length = "0x11F6")]
	private Collider ObjectToPlaceOverlapsWithObjectsThatBlockPlacement(RaycastHit hit)
	{
		return null;
	}

	[Token(Token = "0x60048E8")]
	[Address(RVA = "0xD01E40", Offset = "0xD00C40", Length = "0x630")]
	private Collider CheckBoundsAgainstObjectsThatBlockPlacement(Vector3 worldPos, Vector3 localExtents, Quaternion rotation, RaycastHit targetHit, int mask)
	{
		return null;
	}

	[Token(Token = "0x60048E9")]
	[Address(RVA = "0xD02480", Offset = "0xD01280", Length = "0xC1D")]
	private Collider CheckBoundsAgainstBlockPlacementColliders(Vector3 worldPos, Vector3 localExtents, Quaternion rotation, RaycastHit targetHit, int mask)
	{
		return null;
	}

	[Token(Token = "0x60048EA")]
	[Address(RVA = "0xD030A0", Offset = "0xD01EA0", Length = "0x7C5")]
	private bool HasCollisionPenetration(Collider candidate)
	{
		return false;
	}

	[Token(Token = "0x60048EB")]
	[Address(RVA = "0xD03870", Offset = "0xD02670", Length = "0x56E")]
	private bool IsOverlappingWithFloorPartOfObject(Vector3 worldPos, Vector3 localExtents, Quaternion rotation, Collider candidate)
	{
		return false;
	}

	[Token(Token = "0x60048EC")]
	[Address(RVA = "0xD03DE0", Offset = "0xD02BE0", Length = "0x2A8")]
	private bool IsInStackingChain(Transform candidateTransform)
	{
		return false;
	}

	[Token(Token = "0x60048ED")]
	[Address(RVA = "0xD04090", Offset = "0xD02E90", Length = "0xA8D")]
	private bool DecorationToPlaceOverlapsDoors(bool evaluateForWallPlacement)
	{
		return false;
	}

	[Token(Token = "0x60048EE")]
	[Address(RVA = "0xD04B20", Offset = "0xD03920", Length = "0x10B")]
	private static int FindSmallestExtentAxis(Bounds colliderBounds, out float result)
	{
		result = default(float);
		return 0;
	}

	[Token(Token = "0x60048EF")]
	[Address(RVA = "0xD04C30", Offset = "0xD03A30", Length = "0x3FF")]
	private bool ObjectToPlaceOverlapsSnowShelter()
	{
		return false;
	}

	[Token(Token = "0x60048F0")]
	[Address(RVA = "0xD05030", Offset = "0xD03E30", Length = "0xCF8")]
	private bool ObjectToPlaceOverlapsWithInteractiveProp()
	{
		return false;
	}

	[Token(Token = "0x60048F1")]
	[Address(RVA = "0xD05D30", Offset = "0xD04B30", Length = "0x3AF")]
	private bool ObjectToPlaceIsOnBrokenIce()
	{
		return false;
	}

	[Token(Token = "0x60048F2")]
	[Address(RVA = "0xD060E0", Offset = "0xD04EE0", Length = "0x78A")]
	private GearPlacePoint GetGearPlacePoint(GameObject go, Vector3 searchPos)
	{
		return null;
	}

	[Token(Token = "0x60048F3")]
	[Address(RVA = "0xD06870", Offset = "0xD05670", Length = "0x3B0")]
	private void RestoreTransform()
	{
	}

	[Token(Token = "0x60048F4")]
	[Address(RVA = "0xD06C30", Offset = "0xD05A30", Length = "0x628")]
	private void HideLightFromMesh(bool hide)
	{
	}

	[Token(Token = "0x60048F5")]
	[Address(RVA = "0xD07260", Offset = "0xD06060", Length = "0x1BE")]
	private bool ShouldDoVisPointVisibilityCheck()
	{
		return false;
	}

	[Token(Token = "0x60048F6")]
	[Address(RVA = "0xD07420", Offset = "0xD06220", Length = "0x626")]
	private void AssignComponents(GameObject go, bool alreadyPlaced)
	{
	}

	[Token(Token = "0x60048F7")]
	[Address(RVA = "0xD07A50", Offset = "0xD06850", Length = "0x348")]
	private static void AddChildrenToChain(DecorationItem item, List<DecorationItemPlacementInfo> chain)
	{
	}

	[Token(Token = "0x60048F8")]
	[Address(RVA = "0xD07DA0", Offset = "0xD06BA0", Length = "0x1A51")]
	private static void AddStackedGearItemsToChain(DecorationItem item, List<DecorationItemPlacementInfo> chain)
	{
	}

	[Token(Token = "0x60048F9")]
	[Address(RVA = "0xD09800", Offset = "0xD08600", Length = "0x87A")]
	private void InitializeRenderers()
	{
	}

	[Token(Token = "0x60048FA")]
	[Address(RVA = "0xD0A080", Offset = "0xD08E80", Length = "0xE61")]
	private void InitializeObjectToPlace(GameObject go)
	{
	}

	[Token(Token = "0x60048FB")]
	[Address(RVA = "0xD0AEF0", Offset = "0xD09CF0", Length = "0x910")]
	private void GetCollidersThatShouldIgnorePlayer(List<Collider> collidersToIgnore)
	{
	}

	[Token(Token = "0x60048FC")]
	[Address(RVA = "0xD0B810", Offset = "0xD0A610", Length = "0x2F8")]
	private void SetIgnoreCollisionWithPlayer(bool ignore)
	{
	}

	[Token(Token = "0x60048FD")]
	[Address(RVA = "0xD0BB10", Offset = "0xD0A910", Length = "0x286")]
	private void CheckForButtomPromptUpdate(GearPlacePoint gpp)
	{
	}

	[Token(Token = "0x60048FE")]
	[Address(RVA = "0xD0BDA0", Offset = "0xD0ABA0", Length = "0x3DC")]
	private void UpdateInventoryOnPlacement()
	{
	}

	[Token(Token = "0x60048FF")]
	[Address(RVA = "0xD0C180", Offset = "0xD0AF80", Length = "0x1D5")]
	private static bool IsFloor(RaycastHit hit)
	{
		return false;
	}

	[Token(Token = "0x6004900")]
	[Address(RVA = "0xD0C360", Offset = "0xD0B160", Length = "0x158")]
	private static bool IsFloor(Collider collider)
	{
		return false;
	}

	[Token(Token = "0x6004901")]
	[Address(RVA = "0xD0C4C0", Offset = "0xD0B2C0", Length = "0x212")]
	private static bool IsWall(RaycastHit hit)
	{
		return false;
	}

	[Token(Token = "0x6004902")]
	[Address(RVA = "0xD0C6E0", Offset = "0xD0B4E0", Length = "0x802")]
	private bool HasOverlapsWithWallObjects(RaycastHit hit)
	{
		return false;
	}

	[Token(Token = "0x6004903")]
	[Address(RVA = "0xD0CEF0", Offset = "0xD0BCF0", Length = "0x1F8")]
	private BoxCollider GetProxyCollisionVolume()
	{
		return null;
	}

	[Token(Token = "0x6004904")]
	[Address(RVA = "0xD0D0F0", Offset = "0xD0BEF0", Length = "0x273")]
	public bool ItemInHandsThrowable()
	{
		return false;
	}

	[Token(Token = "0x6004905")]
	[Address(RVA = "0xD0D370", Offset = "0xD0C170", Length = "0x72E")]
	public void DropLitItemInHand(DropLitItemsOptions options, bool useGravity = true)
	{
	}

	[Token(Token = "0x6004906")]
	[Address(RVA = "0xD0DAA0", Offset = "0xD0C8A0", Length = "0x2C6")]
	public void Drop(GameObject go, bool useGravity = true)
	{
	}

	[Token(Token = "0x6004907")]
	[Address(RVA = "0xD0DD70", Offset = "0xD0CB70", Length = "0x313")]
	private static void DropRigidBody(GameObject go, bool useGravity = true)
	{
	}

	[Token(Token = "0x6004908")]
	[Address(RVA = "0xD0E090", Offset = "0xD0CE90", Length = "0x109")]
	public static void SetGravity(GameObject go, bool useGravity)
	{
	}

	[Token(Token = "0x6004909")]
	[Address(RVA = "0xD0E1A0", Offset = "0xD0CFA0", Length = "0x4B8")]
	public void Throw(GearItem gi, PlayerAnimation.OnAnimationEvent throwCompleteCallback = null)
	{
	}

	[Token(Token = "0x600490A")]
	[Address(RVA = "0xD0E660", Offset = "0xD0D460", Length = "0xBA5")]
	private void ReleaseThrownObject()
	{
	}

	[Token(Token = "0x600490B")]
	[Address(RVA = "0xD0F210", Offset = "0xD0E010", Length = "0xE44")]
	private GameObject ReleaseFromHands(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x600490C")]
	[Address(RVA = "0xD10060", Offset = "0xD0EE60", Length = "0x415")]
	private GearItem InstantiateCopyOfThrownObject(GearItem gi)
	{
		return null;
	}

	[Token(Token = "0x600490D")]
	[Address(RVA = "0xD10480", Offset = "0xD0F280", Length = "0x1CB")]
	private void MaybeDuplicateItemBeforeDrop(DropLitItemsOptions options)
	{
	}

	[Token(Token = "0x600490E")]
	[Address(RVA = "0xD10650", Offset = "0xD0F450", Length = "0x43A")]
	public static Vector3 MaybeAdjustShotPositionForNearShot(Vector3 emissionPos, Vector3 firePos, Vector3 testDir)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600490F")]
	[Address(RVA = "0xD10A90", Offset = "0xD0F890", Length = "0x72")]
	private static Vector3 AdjustNearShotFirePosition(RaycastHit hit, Vector3 testDir)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6004910")]
	[Address(RVA = "0xD10B10", Offset = "0xD0F910", Length = "0x121")]
	private static float GetNearDistanceShot(Vector3 weaponSpaceEmissionPosition)
	{
		return 0f;
	}

	[Token(Token = "0x6004911")]
	[Address(RVA = "0xD10C40", Offset = "0xD0FA40", Length = "0xDF3")]
	public PlayerManager()
	{
	}
}

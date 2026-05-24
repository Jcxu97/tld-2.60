using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.Interactions;
using TLD.Utility;
using UnityEngine;
using UnityEngine.AI;

namespace TLD.BigCarry;

[Token(Token = "0x20014DD")]
public class TravoisBigCarryItem : BigCarryItem
{
	[Token(Token = "0x20014DE")]
	private class TravoisBigCarryItemSaveData
	{
		[Token(Token = "0x40096F0")]
		[FieldOffset(Offset = "0x10")]
		public float m_NormalizedCondition;

		[Token(Token = "0x40096F1")]
		[FieldOffset(Offset = "0x14")]
		public float m_HoursActive;

		[Token(Token = "0x40096F2")]
		[FieldOffset(Offset = "0x18")]
		public string m_SerializedContainer;

		[Token(Token = "0x60083F4")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public TravoisBigCarryItemSaveData()
		{
		}
	}

	[Token(Token = "0x20014DF")]
	private enum TravoisPrepareState
	{
		[Token(Token = "0x40096F4")]
		None,
		[Token(Token = "0x40096F5")]
		WaitingForCameraLerp,
		[Token(Token = "0x40096F6")]
		WaitingForPlayerTeleport
	}

	[Token(Token = "0x40096C0")]
	private const float TERRAIN_CHECK_OFFSET = 1000f;

	[Token(Token = "0x40096C1")]
	private const float TERRAIN_CHECK_OFFSET_FUDGE = 1f;

	[Header("Travois Settings")]
	[SerializeField]
	[Token(Token = "0x40096C2")]
	[FieldOffset(Offset = "0x98")]
	private Container m_Container;

	[SerializeField]
	[Token(Token = "0x40096C3")]
	[FieldOffset(Offset = "0xA0")]
	private AssetReferenceCustomSpawnedItem m_RuinedTravoisItemReference;

	[SerializeField]
	[Token(Token = "0x40096C4")]
	[FieldOffset(Offset = "0xA8")]
	private AssetReferenceGearItem m_TravoisGearItemReference;

	[SerializeField]
	[Token(Token = "0x40096C5")]
	[FieldOffset(Offset = "0xB0")]
	private TravoisDropSettings m_TravoisDropSettings;

	[Header("Drop")]
	[SerializeField]
	[Token(Token = "0x40096C6")]
	[FieldOffset(Offset = "0xB8")]
	private NavMeshObstacle m_NavMeshObstacle;

	[SerializeField]
	[Token(Token = "0x40096C7")]
	[FieldOffset(Offset = "0xC0")]
	private GameObject m_TravoisBlocker;

	[SerializeField]
	[Token(Token = "0x40096C8")]
	[FieldOffset(Offset = "0xC8")]
	private float m_DropAngleCalculationBackOffset;

	[Header("Interaction")]
	[SerializeField]
	[Token(Token = "0x40096C9")]
	[FieldOffset(Offset = "0xD0")]
	private LocalizedString m_CarryTravoisText;

	[SerializeField]
	[Token(Token = "0x40096CA")]
	[FieldOffset(Offset = "0xD8")]
	private LocalizedString m_PickupTravoisText;

	[Header("Intro Lerp")]
	[SerializeField]
	[Token(Token = "0x40096CB")]
	[FieldOffset(Offset = "0xE0")]
	private float m_IntroLerpTime;

	[SerializeField]
	[Token(Token = "0x40096CC")]
	[FieldOffset(Offset = "0xE8")]
	private AnimationCurve m_IntroLerpCurve;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x40096CD")]
	[FieldOffset(Offset = "0xF0")]
	private TravoisAudio m_TravoisAudio;

	[Header("Movement")]
	[SerializeField]
	[Token(Token = "0x40096CE")]
	[FieldOffset(Offset = "0xF8")]
	private float m_PickupBlockMovementTimeSeconds;

	[SerializeField]
	[Token(Token = "0x40096CF")]
	[FieldOffset(Offset = "0x100")]
	private TravoisMovement m_TravoisMovement;

	[SerializeField]
	[Token(Token = "0x40096D0")]
	[FieldOffset(Offset = "0x108")]
	private AnimationCurve m_MoveSpeedModifierCurve;

	[SerializeField]
	[Token(Token = "0x40096D1")]
	[FieldOffset(Offset = "0x110")]
	private AnimationCurve m_TurnSpeedModifierCurve;

	[Header("Decay")]
	[SerializeField]
	[Token(Token = "0x40096D2")]
	[FieldOffset(Offset = "0x118")]
	private float m_MaxHP;

	[SerializeField]
	[Token(Token = "0x40096D3")]
	[FieldOffset(Offset = "0x11C")]
	private float m_DecayHPPerHour;

	[SerializeField]
	[Token(Token = "0x40096D4")]
	[FieldOffset(Offset = "0x120")]
	private float m_BlizzardDecayPerHour;

	[SerializeField]
	[Token(Token = "0x40096D5")]
	[FieldOffset(Offset = "0x124")]
	private float m_FallDamagePerMeter;

	[SerializeField]
	[Token(Token = "0x40096D6")]
	[FieldOffset(Offset = "0x128")]
	private float m_MovementDecayPerUnit;

	[SerializeField]
	[Token(Token = "0x40096D7")]
	[FieldOffset(Offset = "0x130")]
	private MaterialTagMapping<float>[] m_MaterialDecayModifiers;

	[Header("Scent")]
	[SerializeField]
	[Token(Token = "0x40096D8")]
	[FieldOffset(Offset = "0x138")]
	private float m_ScentRange;

	[Header("Scatter")]
	[SerializeField]
	[Token(Token = "0x40096D9")]
	[FieldOffset(Offset = "0x13C")]
	private int m_MinScatterItems;

	[SerializeField]
	[Token(Token = "0x40096DA")]
	[FieldOffset(Offset = "0x140")]
	private int m_MaxScatterItems;

	[SerializeField]
	[Token(Token = "0x40096DB")]
	[FieldOffset(Offset = "0x144")]
	private float m_MinScatterRange;

	[SerializeField]
	[Token(Token = "0x40096DC")]
	[FieldOffset(Offset = "0x148")]
	private float m_MaxScatterRange;

	[SerializeField]
	[Token(Token = "0x40096DD")]
	[FieldOffset(Offset = "0x14C")]
	private int m_MinScatterAngle;

	[SerializeField]
	[Token(Token = "0x40096DE")]
	[FieldOffset(Offset = "0x150")]
	private int m_MaxScatterAngle;

	[Token(Token = "0x40096DF")]
	[FieldOffset(Offset = "0x158")]
	private ActionPickerItemData m_PickupPickerData;

	[Token(Token = "0x40096E0")]
	[FieldOffset(Offset = "0x160")]
	private float m_CurrentHP;

	[Token(Token = "0x40096E1")]
	[FieldOffset(Offset = "0x164")]
	private Vector3 m_LastCarryPosition;

	[Token(Token = "0x40096E2")]
	[FieldOffset(Offset = "0x170")]
	private float m_MoveSpeedModifier;

	[Token(Token = "0x40096E3")]
	[FieldOffset(Offset = "0x174")]
	private float m_TurnSpeedModifier;

	[Token(Token = "0x40096E4")]
	[FieldOffset(Offset = "0x178")]
	private float m_ScentIntensity;

	[Token(Token = "0x40096E5")]
	[FieldOffset(Offset = "0x180")]
	private GearItem m_TravoisGearItem;

	[Token(Token = "0x40096E6")]
	private static readonly List<TravoisBigCarryItem> s_ActiveBigCarryItems;

	[Token(Token = "0x40096E7")]
	private static readonly TravoisBigCarryItemSaveData s_TravoisBigItemSaveData;

	[Token(Token = "0x40096E8")]
	[FieldOffset(Offset = "0x188")]
	private Vector3 m_CameraStartPosition;

	[Token(Token = "0x40096E9")]
	[FieldOffset(Offset = "0x194")]
	private Vector3 m_CameraTargetPosition;

	[Token(Token = "0x40096EA")]
	[FieldOffset(Offset = "0x1A0")]
	private Quaternion m_CameraStartRotation;

	[Token(Token = "0x40096EB")]
	[FieldOffset(Offset = "0x1B0")]
	private Quaternion m_CameraTargetRotation;

	[Token(Token = "0x40096EC")]
	[FieldOffset(Offset = "0x1C0")]
	private float m_IntroTimer;

	[Token(Token = "0x40096ED")]
	[FieldOffset(Offset = "0x1C4")]
	private TravoisPrepareState m_PrepareState;

	[Token(Token = "0x40096EE")]
	[FieldOffset(Offset = "0x1C8")]
	private Action m_OnDonePreparing;

	[Token(Token = "0x40096EF")]
	[FieldOffset(Offset = "0x1D0")]
	private string m_PendingSerializedContainerData;

	[Token(Token = "0x17000B6F")]
	public override bool CanCarryWhileCrouched
	{
		[Token(Token = "0x60083BC")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000B70")]
	public override bool AlwaysSkipDropAnimation
	{
		[Token(Token = "0x60083BD")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000B71")]
	public Container Container
	{
		[Token(Token = "0x60083BE")]
		[Address(RVA = "0x4B3EA0", Offset = "0x4B2CA0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60083BF")]
	[Address(RVA = "0x124EEF0", Offset = "0x124DCF0", Length = "0xBD")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60083C0")]
	[Address(RVA = "0x124EFB0", Offset = "0x124DDB0", Length = "0x1D4")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60083C1")]
	[Address(RVA = "0x124F190", Offset = "0x124DF90", Length = "0x41")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60083C2")]
	[Address(RVA = "0x124F1E0", Offset = "0x124DFE0", Length = "0x223")]
	public override BigCarryItemSaveData Serialize()
	{
		return null;
	}

	[Token(Token = "0x60083C3")]
	[Address(RVA = "0x124F410", Offset = "0x124E210", Length = "0x1B1")]
	public override void Deserialize(BigCarryItemSaveData data, bool isCarried)
	{
	}

	[Token(Token = "0x60083C4")]
	[Address(RVA = "0x124F5D0", Offset = "0x124E3D0", Length = "0x12E")]
	public override void DeserializePostSceneLoad()
	{
	}

	[Token(Token = "0x60083C5")]
	[Address(RVA = "0x124F700", Offset = "0x124E500", Length = "0x511")]
	private bool IsTravoisUnderTerrain(out Vector3 terrainHit)
	{
		terrainHit = default(Vector3);
		return false;
	}

	[Token(Token = "0x60083C6")]
	[Address(RVA = "0x124FC20", Offset = "0x124EA20", Length = "0x384")]
	private void MoveInaccessibleTravoisToSurface(Vector3 desiredPosition)
	{
	}

	[Token(Token = "0x60083C7")]
	[Address(RVA = "0x124FFB0", Offset = "0x124EDB0", Length = "0x649")]
	private void MoveInaccessibleTravoisToTheLostAndFoundBox()
	{
	}

	[Token(Token = "0x60083C8")]
	[Address(RVA = "0x1250600", Offset = "0x124F400", Length = "0xDA")]
	public override bool CanPerformInteractionWhileCarrying(IInteraction interaction)
	{
		return false;
	}

	[Token(Token = "0x60083C9")]
	[Address(RVA = "0x12506E0", Offset = "0x124F4E0", Length = "0x121")]
	private bool CanLoadIntoScene(LoadScene loadScene)
	{
		return false;
	}

	[Token(Token = "0x60083CA")]
	[Address(RVA = "0x1250810", Offset = "0x124F610", Length = "0x11E")]
	public override void PlayHoistAudio(bool pickingUp)
	{
	}

	[Token(Token = "0x60083CB")]
	[Address(RVA = "0x1250930", Offset = "0x124F730", Length = "0x15B")]
	public override AK.Wwise.Event GetBreathAudioEvent()
	{
		return null;
	}

	[Token(Token = "0x60083CC")]
	[Address(RVA = "0x1250A90", Offset = "0x124F890", Length = "0x4FB")]
	public override void OnPrepareForCarry(bool restoringCarry, Action onDonePreparing)
	{
	}

	[Token(Token = "0x60083CD")]
	[Address(RVA = "0x1250F90", Offset = "0x124FD90", Length = "0x279")]
	public override void OnCarried(bool restoringCarry)
	{
	}

	[Token(Token = "0x60083CE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public override void OnRestored(bool replacedOriginal)
	{
	}

	[Token(Token = "0x60083CF")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public override void OnBeginPlacement()
	{
	}

	[Token(Token = "0x60083D0")]
	[Address(RVA = "0x1251210", Offset = "0x1250010", Length = "0x353")]
	public override void OnPrepareForDrop()
	{
	}

	[Token(Token = "0x60083D1")]
	[Address(RVA = "0x1251570", Offset = "0x1250370", Length = "0x12B")]
	public override void OnDropped()
	{
	}

	[Token(Token = "0x60083D2")]
	[Address(RVA = "0x12516A0", Offset = "0x12504A0", Length = "0x328")]
	public override bool DropItemOnGround(Vector3 desiredPosition)
	{
		return false;
	}

	[Token(Token = "0x60083D3")]
	[Address(RVA = "0x12519D0", Offset = "0x12507D0", Length = "0x423")]
	public override void UpdateItem()
	{
	}

	[Token(Token = "0x60083D4")]
	[Address(RVA = "0x1251E00", Offset = "0x1250C00", Length = "0x11")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60083D5")]
	[Address(RVA = "0x1251E20", Offset = "0x1250C20", Length = "0x6E7")]
	private void UpdatePrepareLerp()
	{
	}

	[Token(Token = "0x60083D6")]
	[Address(RVA = "0x1252510", Offset = "0x1251310", Length = "0x88")]
	private void FinishPreparing()
	{
	}

	[Token(Token = "0x60083D7")]
	[Address(RVA = "0x12525A0", Offset = "0x12513A0", Length = "0x1D")]
	protected void UpdateTimeDecay(float elapsedHours)
	{
	}

	[Token(Token = "0x60083D8")]
	[Address(RVA = "0x12525C0", Offset = "0x12513C0", Length = "0xFA")]
	protected void UpdateBlizzardDecay(float elapsedHours)
	{
	}

	[Token(Token = "0x60083D9")]
	[Address(RVA = "0x12526C0", Offset = "0x12514C0", Length = "0x30F")]
	protected void UpdateTravelDecay()
	{
	}

	[Token(Token = "0x60083DA")]
	[Address(RVA = "0x12529D0", Offset = "0x12517D0", Length = "0x2C")]
	public void ApplyFallDamage(float fallHeight)
	{
	}

	[Token(Token = "0x60083DB")]
	[Address(RVA = "0x1252A00", Offset = "0x1251800", Length = "0x11")]
	public void SetNormalizedHP(float normalizedHP)
	{
	}

	[Token(Token = "0x60083DC")]
	[Address(RVA = "0x1252A20", Offset = "0x1251820", Length = "0x129")]
	private Vector3 GetPlayerPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60083DD")]
	[Address(RVA = "0x1252B50", Offset = "0x1251950", Length = "0x19D")]
	private float GetMaterialDecayModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60083DE")]
	[Address(RVA = "0x1252CF0", Offset = "0x1251AF0", Length = "0x1F6")]
	protected override void InitializeActionPickerItems()
	{
	}

	[Token(Token = "0x60083DF")]
	[Address(RVA = "0x1252EF0", Offset = "0x1251CF0", Length = "0x100")]
	protected override void BuildActionPickerData()
	{
	}

	[Token(Token = "0x60083E0")]
	[Address(RVA = "0x1253000", Offset = "0x1251E00", Length = "0x89")]
	private bool CanCarryTravois()
	{
		return false;
	}

	[Token(Token = "0x60083E1")]
	[Address(RVA = "0x1253090", Offset = "0x1251E90", Length = "0x12E")]
	public override string GetHoverText()
	{
		return null;
	}

	[Token(Token = "0x60083E2")]
	[Address(RVA = "0x12531C0", Offset = "0x1251FC0", Length = "0xA1")]
	private void CarryCallback()
	{
	}

	[Token(Token = "0x60083E3")]
	[Address(RVA = "0x1253270", Offset = "0x1252070", Length = "0x84")]
	private void PickupCallback()
	{
	}

	[Token(Token = "0x60083E4")]
	[Address(RVA = "0x1253300", Offset = "0x1252100", Length = "0x264")]
	private void PrepareGearItem()
	{
	}

	[Token(Token = "0x60083E5")]
	[Address(RVA = "0x1253570", Offset = "0x1252370", Length = "0x132")]
	public void InitializeFromDroppedGearItem(GearItem gearItem)
	{
	}

	[Token(Token = "0x60083E6")]
	[Address(RVA = "0x12536B0", Offset = "0x12524B0", Length = "0x198")]
	private void UpdateMovementModifier()
	{
	}

	[Token(Token = "0x60083E7")]
	[Address(RVA = "0x1253850", Offset = "0x1252650", Length = "0x7")]
	public void ForceDestroyTravois()
	{
	}

	[Token(Token = "0x60083E8")]
	[Address(RVA = "0x1253860", Offset = "0x1252660", Length = "0x82B")]
	private void DestroyTravois()
	{
	}

	[Token(Token = "0x60083E9")]
	[Address(RVA = "0x1254090", Offset = "0x1252E90", Length = "0x9")]
	public override float GetMovementSpeedModifier(bool isSprinting)
	{
		return 0f;
	}

	[Token(Token = "0x60083EA")]
	[Address(RVA = "0x12540A0", Offset = "0x1252EA0", Length = "0x9")]
	public override float GetTurnSpeedModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60083EB")]
	[Address(RVA = "0x12540B0", Offset = "0x1252EB0", Length = "0x21")]
	public Vector2 ModifyMove(Vector2 move)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60083EC")]
	[Address(RVA = "0x12540E0", Offset = "0x1252EE0", Length = "0x3FD")]
	public static float GetScentIntensityOfAllTravoisInRange(Vector3 playerPosition)
	{
		return 0f;
	}

	[Token(Token = "0x60083ED")]
	[Address(RVA = "0x12544E0", Offset = "0x12532E0", Length = "0x1B4")]
	public float GetScentIntensityOfContainerIfInRange(Vector3 playerPosition)
	{
		return 0f;
	}

	[Token(Token = "0x60083EE")]
	[Address(RVA = "0x12546A0", Offset = "0x12534A0", Length = "0x17F")]
	private void UpdateScentIntensityOfContainer()
	{
	}

	[Token(Token = "0x60083EF")]
	[Address(RVA = "0x1254820", Offset = "0x1253620", Length = "0x1ED")]
	public int DropAndScatterItems()
	{
		return 0;
	}

	[Token(Token = "0x60083F0")]
	[Address(RVA = "0x1254A10", Offset = "0x1253810", Length = "0x53")]
	private GearItem DropScatterItem(GearItem item)
	{
		return null;
	}

	[Token(Token = "0x60083F1")]
	[Address(RVA = "0x1254A70", Offset = "0x1253870", Length = "0xDB")]
	private bool CanDropScatterItem(GearItem item)
	{
		return false;
	}

	[Token(Token = "0x60083F2")]
	[Address(RVA = "0x1254B50", Offset = "0x1253950", Length = "0x1B")]
	public TravoisBigCarryItem()
	{
	}
}

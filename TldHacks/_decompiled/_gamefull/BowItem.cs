using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x200045B")]
public class BowItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400278F")]
	[FieldOffset(Offset = "0x20")]
	private AK.Wwise.Event m_DrawAudio;

	[SerializeField]
	[Token(Token = "0x4002790")]
	[FieldOffset(Offset = "0x28")]
	private AK.Wwise.Event m_HoldAudio;

	[SerializeField]
	[Token(Token = "0x4002791")]
	[FieldOffset(Offset = "0x30")]
	private AK.Wwise.Event m_ReleaseAudio;

	[SerializeField]
	[Token(Token = "0x4002792")]
	[FieldOffset(Offset = "0x38")]
	private AK.Wwise.Event m_ArrowNockAudio;

	[SerializeField]
	[Token(Token = "0x4002793")]
	[FieldOffset(Offset = "0x40")]
	private List<AssetReferenceT<GearItemData>> m_ArrowReferences;

	[Range(0f, 1f)]
	[Token(Token = "0x4002794")]
	[FieldOffset(Offset = "0x48")]
	public float m_SwayValueZeroFatigue;

	[Range(0f, 1f)]
	[Token(Token = "0x4002795")]
	[FieldOffset(Offset = "0x4C")]
	public float m_SwayValueMaxFatigue;

	[Range(0f, 1f)]
	[Tooltip("% of Aim Stamina consumed per second while the weapon is Aimed.")]
	[Token(Token = "0x4002796")]
	[FieldOffset(Offset = "0x50")]
	public float m_SwayIncreasePerSecond;

	[Range(0f, 1f)]
	[Tooltip("% of Aim Stamina restored per second while the weapon is not Aimed.")]
	[Token(Token = "0x4002797")]
	[FieldOffset(Offset = "0x54")]
	public float m_SwayDecreasePerSecond;

	[Tooltip("Slows down Aim Stamina depletion")]
	[Range(0f, 1f)]
	[Token(Token = "0x4002798")]
	[FieldOffset(Offset = "0x58")]
	public float m_SwayEnergyBoostBonus;

	[Tooltip("Slows down Aim Stamina depletion")]
	[Range(0f, 1f)]
	[Token(Token = "0x4002799")]
	[FieldOffset(Offset = "0x5C")]
	public float m_SwayEnergyStimBonus;

	[Token(Token = "0x400279A")]
	[FieldOffset(Offset = "0x60")]
	public float m_AimingSwayDropThresholdPercent;

	[SerializeField]
	[Token(Token = "0x400279B")]
	[FieldOffset(Offset = "0x64")]
	private float m_BowDamageMultiplier;

	[Token(Token = "0x400279C")]
	[FieldOffset(Offset = "0x68")]
	private GearItem m_GearArrow;

	[Token(Token = "0x400279D")]
	[FieldOffset(Offset = "0x70")]
	private GearItem m_GearBow;

	[Token(Token = "0x400279E")]
	[FieldOffset(Offset = "0x78")]
	private BowState m_BowState;

	[Token(Token = "0x400279F")]
	[FieldOffset(Offset = "0x7C")]
	private uint m_HoldAudioInstance;

	[Token(Token = "0x40027A0")]
	[FieldOffset(Offset = "0x80")]
	private float m_SwayValue;

	[Token(Token = "0x40027A1")]
	[FieldOffset(Offset = "0x88")]
	private AsyncOperationHandle<IList<GearItemData>> m_ValidArrowsHandle;

	[Token(Token = "0x40027A2")]
	[FieldOffset(Offset = "0xA0")]
	private int m_SelectedArrowIndex;

	[Token(Token = "0x40027A4")]
	private static BowItemSaveDataProxy m_BowItemSaveDataProxy;

	[Token(Token = "0x1700021D")]
	private IList<GearItemData> ValidArrows
	{
		[Token(Token = "0x60020DA")]
		[Address(RVA = "0x8070A0", Offset = "0x805EA0", Length = "0x42")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700021E")]
	private GearItemData SelectedArrow
	{
		[Token(Token = "0x60020DB")]
		[Address(RVA = "0x8070F0", Offset = "0x805EF0", Length = "0x7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700021F")]
	[field: Token(Token = "0x40027A3")]
	[field: FieldOffset(Offset = "0xA8")]
	public string SelectedArrowIconSpriteName
	{
		[Token(Token = "0x60020DC")]
		[Address(RVA = "0x636F10", Offset = "0x635D10", Length = "0x8")]
		get;
		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x6BCEA0", Offset = "0x6BBCA0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x60020DE")]
	[Address(RVA = "0x807170", Offset = "0x805F70", Length = "0x169")]
	private void Awake()
	{
	}

	[Token(Token = "0x60020DF")]
	[Address(RVA = "0x8072E0", Offset = "0x8060E0", Length = "0x12")]
	private void Start()
	{
	}

	[Token(Token = "0x60020E0")]
	[Address(RVA = "0x807300", Offset = "0x806100", Length = "0xFC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60020E1")]
	[Address(RVA = "0x807400", Offset = "0x806200", Length = "0xE2")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60020E2")]
	[Address(RVA = "0x8074F0", Offset = "0x8062F0", Length = "0xF8")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60020E3")]
	[Address(RVA = "0x8075F0", Offset = "0x8063F0", Length = "0x22E")]
	public void Update()
	{
	}

	[Token(Token = "0x60020E4")]
	[Address(RVA = "0x807820", Offset = "0x806620", Length = "0x2FE")]
	public void PressFire()
	{
	}

	[Token(Token = "0x60020E5")]
	[Address(RVA = "0x807B20", Offset = "0x806920", Length = "0xA6")]
	public bool CanSwitchArrow()
	{
		return false;
	}

	[Token(Token = "0x60020E6")]
	[Address(RVA = "0x807BD0", Offset = "0x8069D0", Length = "0x12D")]
	public void PressSwitchArrow()
	{
	}

	[Token(Token = "0x60020E7")]
	[Address(RVA = "0x807D00", Offset = "0x806B00", Length = "0x265")]
	private int GetNextValidArrowIndex()
	{
		return 0;
	}

	[Token(Token = "0x60020E8")]
	[Address(RVA = "0x807F70", Offset = "0x806D70", Length = "0xE")]
	private void OnReadyToAimComplete()
	{
	}

	[Token(Token = "0x60020E9")]
	[Address(RVA = "0x807F80", Offset = "0x806D80", Length = "0x155")]
	public void ExhaustedRelaxBow()
	{
	}

	[Token(Token = "0x60020EA")]
	[Address(RVA = "0x8080E0", Offset = "0x806EE0", Length = "0x263")]
	public void ReleaseFire()
	{
	}

	[Token(Token = "0x60020EB")]
	[Address(RVA = "0x808350", Offset = "0x807150", Length = "0xAE")]
	private void OnFireComplete()
	{
	}

	[Token(Token = "0x60020EC")]
	[Address(RVA = "0x808400", Offset = "0x807200", Length = "0x71")]
	public void CancelItemInHandsAction()
	{
	}

	[Token(Token = "0x60020ED")]
	[Address(RVA = "0x808480", Offset = "0x807280", Length = "0xED")]
	public void ForceReady()
	{
	}

	[Token(Token = "0x60020EE")]
	[Address(RVA = "0x808570", Offset = "0x807370", Length = "0xE")]
	private void OnAimToReadyComplete()
	{
	}

	[Token(Token = "0x60020EF")]
	[Address(RVA = "0x808580", Offset = "0x807380", Length = "0x8")]
	public bool InReadyState()
	{
		return false;
	}

	[Token(Token = "0x60020F0")]
	[Address(RVA = "0x808590", Offset = "0x807390", Length = "0x12")]
	public bool ShouldBeZooming()
	{
		return false;
	}

	[Token(Token = "0x60020F1")]
	[Address(RVA = "0x8085B0", Offset = "0x8073B0", Length = "0x8")]
	public bool IsSwitchingArrow()
	{
		return false;
	}

	[Token(Token = "0x60020F2")]
	[Address(RVA = "0x8085C0", Offset = "0x8073C0", Length = "0x258")]
	public int GetNumAllArrowsInInventory()
	{
		return 0;
	}

	[Token(Token = "0x60020F3")]
	[Address(RVA = "0x808820", Offset = "0x807620", Length = "0x69")]
	public int GetNumSelectedArrowsInInventory()
	{
		return 0;
	}

	[Token(Token = "0x60020F4")]
	[Address(RVA = "0x808890", Offset = "0x807690", Length = "0x62")]
	public int GetNumArrowsInInventory(GearItemData arrowData)
	{
		return 0;
	}

	[Token(Token = "0x60020F5")]
	[Address(RVA = "0x808900", Offset = "0x807700", Length = "0x8")]
	public bool IsArrowNocked()
	{
		return false;
	}

	[Token(Token = "0x60020F6")]
	[Address(RVA = "0x808910", Offset = "0x807710", Length = "0x160")]
	private void UpdateBowState()
	{
	}

	[Token(Token = "0x60020F7")]
	[Address(RVA = "0x808A80", Offset = "0x807880", Length = "0x9")]
	private void SetState(BowState state)
	{
	}

	[Token(Token = "0x60020F8")]
	[Address(RVA = "0x808A90", Offset = "0x807890", Length = "0x2E9")]
	private bool Equipped()
	{
		return false;
	}

	[Token(Token = "0x60020F9")]
	[Address(RVA = "0x808D80", Offset = "0x807B80", Length = "0x132")]
	private void UpdateBowStateUnloaded()
	{
	}

	[Token(Token = "0x60020FA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void UpdateBowStateReadyToAim()
	{
	}

	[Token(Token = "0x60020FB")]
	[Address(RVA = "0x808EC0", Offset = "0x807CC0", Length = "0x256")]
	public float GetSwayIncreasePerSecond()
	{
		return 0f;
	}

	[Token(Token = "0x60020FC")]
	[Address(RVA = "0x809120", Offset = "0x807F20", Length = "0x126")]
	public float GetSwayDecreasePerSecond()
	{
		return 0f;
	}

	[Token(Token = "0x60020FD")]
	[Address(RVA = "0x809250", Offset = "0x808050", Length = "0x11")]
	public float GetCurrentStaminaPercent()
	{
		return 0f;
	}

	[Token(Token = "0x60020FE")]
	[Address(RVA = "0x809270", Offset = "0x808070", Length = "0x26")]
	public float GetStaminaDropThresholdPercent()
	{
		return 0f;
	}

	[Token(Token = "0x60020FF")]
	[Address(RVA = "0x8092A0", Offset = "0x8080A0", Length = "0x272")]
	private void UpdateBowStamina()
	{
	}

	[Token(Token = "0x6002100")]
	[Address(RVA = "0x809520", Offset = "0x808320", Length = "0x355")]
	private void UpdateBowStateAim()
	{
	}

	[Token(Token = "0x6002101")]
	[Address(RVA = "0x809880", Offset = "0x808680", Length = "0x1A8")]
	private void MaybeHandleDroppedArrow()
	{
	}

	[Token(Token = "0x6002102")]
	[Address(RVA = "0x809A30", Offset = "0x808830", Length = "0x83E")]
	private void ShootArrow()
	{
	}

	[Token(Token = "0x6002103")]
	[Address(RVA = "0x80A270", Offset = "0x809070", Length = "0x1A2")]
	public float GetBowDamageModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6002104")]
	[Address(RVA = "0x80A420", Offset = "0x809220", Length = "0x5A9")]
	private void MaybeSpawnArrow()
	{
	}

	[Token(Token = "0x6002105")]
	[Address(RVA = "0x80A9D0", Offset = "0x8097D0", Length = "0x28D")]
	public void OnDequip()
	{
	}

	[Token(Token = "0x6002106")]
	[Address(RVA = "0x80AC60", Offset = "0x809A60", Length = "0x27E")]
	private void NockArrow()
	{
	}

	[Token(Token = "0x6002107")]
	[Address(RVA = "0x808570", Offset = "0x807370", Length = "0xE")]
	private void OnReloadComplete()
	{
	}

	[Token(Token = "0x6002108")]
	[Address(RVA = "0x80AEE0", Offset = "0x809CE0", Length = "0x520")]
	private void MakeArrowChildOfBow(GearItem arrow)
	{
	}

	[Token(Token = "0x6002109")]
	[Address(RVA = "0x80B410", Offset = "0x80A210", Length = "0x43E")]
	private void RemoveArrowChildFromBow(GearItem arrow)
	{
	}

	[Token(Token = "0x600210A")]
	[Address(RVA = "0x80B850", Offset = "0x80A650", Length = "0x54")]
	private void StopHoldAudio()
	{
	}

	[Token(Token = "0x600210B")]
	[Address(RVA = "0x80B8B0", Offset = "0x80A6B0", Length = "0xB8")]
	private void ZoomStart()
	{
	}

	[Token(Token = "0x600210C")]
	[Address(RVA = "0x80B970", Offset = "0x80A770", Length = "0x9E")]
	private void ZoomEnd()
	{
	}

	[Token(Token = "0x600210D")]
	[Address(RVA = "0x80BA10", Offset = "0x80A810", Length = "0x5F")]
	public BowItem()
	{
	}
}

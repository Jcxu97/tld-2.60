using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.IntBackedUnit;
using TLD.Logging;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x20004A6")]
public class GunItem : MonoBehaviour
{
	[Token(Token = "0x4002AE3")]
	private static LogFilter s_LogFilter;

	[Token(Token = "0x4002AE4")]
	[FieldOffset(Offset = "0x20")]
	public GunType m_GunType;

	[SerializeField]
	[Token(Token = "0x4002AE5")]
	[FieldOffset(Offset = "0x28")]
	private List<AssetReferenceT<GearItemData>> m_AmmoReferences;

	[Token(Token = "0x4002AE6")]
	[FieldOffset(Offset = "0x30")]
	public GearItemData m_CasingData;

	[Token(Token = "0x4002AE7")]
	[FieldOffset(Offset = "0x38")]
	public bool m_AllowHipFire;

	[Token(Token = "0x4002AE8")]
	[FieldOffset(Offset = "0x39")]
	public bool m_SupportsUnload;

	[Tooltip("This is a legacy property but is used to define how many rounds the gun starts with when created")]
	[Token(Token = "0x4002AE9")]
	[FieldOffset(Offset = "0x3C")]
	public int m_RoundsInClip;

	[Token(Token = "0x4002AEA")]
	[FieldOffset(Offset = "0x40")]
	public int m_ClipSize;

	[SerializeField]
	[Token(Token = "0x4002AEB")]
	[FieldOffset(Offset = "0x44")]
	private int m_RoundsToReloadPerClip;

	[Token(Token = "0x4002AEC")]
	[FieldOffset(Offset = "0x48")]
	public float m_DamageHP;

	[Token(Token = "0x4002AED")]
	[FieldOffset(Offset = "0x4C")]
	public float m_FiringRateSeconds;

	[Token(Token = "0x4002AEE")]
	[FieldOffset(Offset = "0x50")]
	public float m_ReloadCoolDownSeconds;

	[Token(Token = "0x4002AEF")]
	[FieldOffset(Offset = "0x54")]
	public float m_FireDelayOnAim;

	[Token(Token = "0x4002AF0")]
	[FieldOffset(Offset = "0x58")]
	public float m_FireDelayAfterReload;

	[Token(Token = "0x4002AF1")]
	[FieldOffset(Offset = "0x5C")]
	public float m_AccuracyRange;

	[Token(Token = "0x4002AF2")]
	[FieldOffset(Offset = "0x60")]
	public float m_MinDistanceForAimAssist;

	[Token(Token = "0x4002AF3")]
	[FieldOffset(Offset = "0x64")]
	public float m_MuzzleFlash_FlashDelay;

	[Token(Token = "0x4002AF4")]
	[FieldOffset(Offset = "0x68")]
	public float m_MuzzleFlash_SmokeDelay;

	[Token(Token = "0x4002AF5")]
	[FieldOffset(Offset = "0x70")]
	public string m_CasingAudio;

	[Token(Token = "0x4002AF6")]
	[FieldOffset(Offset = "0x78")]
	public string m_DryFireAudio;

	[Token(Token = "0x4002AF7")]
	[FieldOffset(Offset = "0x80")]
	public AK.Wwise.Event m_FireAudio;

	[Token(Token = "0x4002AF8")]
	[FieldOffset(Offset = "0x88")]
	public string m_ImpactAudio;

	[Token(Token = "0x4002AF9")]
	[FieldOffset(Offset = "0x90")]
	public string m_UncockAudio;

	[Token(Token = "0x4002AFA")]
	[FieldOffset(Offset = "0x98")]
	public string m_AmmoSpriteName;

	[Token(Token = "0x4002AFB")]
	[FieldOffset(Offset = "0xA0")]
	public MisfireTable m_MisfireTable;

	[Token(Token = "0x4002AFC")]
	[FieldOffset(Offset = "0xA8")]
	public string m_MisfirePlayerVO;

	[Token(Token = "0x4002AFD")]
	[FieldOffset(Offset = "0xB0")]
	public bool m_EnableFPWeaponShivering;

	[Token(Token = "0x4002AFE")]
	[FieldOffset(Offset = "0xB8")]
	public string m_FireButtonLabel;

	[Token(Token = "0x4002AFF")]
	[FieldOffset(Offset = "0xC0")]
	public string m_AimButtonLabel;

	[Token(Token = "0x4002B00")]
	[FieldOffset(Offset = "0xC8")]
	public string m_ReloadButtonLabel;

	[NonSerialized]
	[Token(Token = "0x4002B01")]
	[FieldOffset(Offset = "0xD0")]
	public List<int> m_Clip;

	[NonSerialized]
	[Token(Token = "0x4002B02")]
	[FieldOffset(Offset = "0xD8")]
	public bool m_HasMisfired;

	[Token(Token = "0x4002B03")]
	[FieldOffset(Offset = "0xDC")]
	private int m_SpentCasingsInClip;

	[Token(Token = "0x4002B04")]
	public static bool m_ForceNoJam;

	[Token(Token = "0x4002B05")]
	public static bool m_ForceJam;

	[Token(Token = "0x4002B06")]
	[FieldOffset(Offset = "0xE0")]
	private ItemWeight m_WeightOfSingleRoundKG;

	[Token(Token = "0x4002B07")]
	[FieldOffset(Offset = "0xE8")]
	private GearItem m_GearItem;

	[HideInInspector]
	[Token(Token = "0x4002B08")]
	[FieldOffset(Offset = "0xF0")]
	public bool m_IsJammed;

	[Header("Animation Speed Multiplier")]
	[Range(0.01f, 2f)]
	[Token(Token = "0x4002B09")]
	[FieldOffset(Offset = "0xF4")]
	public float m_MultiplierAiming;

	[Range(0.01f, 2f)]
	[Token(Token = "0x4002B0A")]
	[FieldOffset(Offset = "0xF8")]
	public float m_MultiplierFire;

	[Range(0.01f, 2f)]
	[Token(Token = "0x4002B0B")]
	[FieldOffset(Offset = "0xFC")]
	public float m_MultiplierReload;

	[Header("Weapon Aim Sway")]
	[Range(0f, 1f)]
	[Token(Token = "0x4002B0C")]
	[FieldOffset(Offset = "0x100")]
	public float m_SwayValueZeroFatigue;

	[Range(0f, 1f)]
	[Token(Token = "0x4002B0D")]
	[FieldOffset(Offset = "0x104")]
	public float m_SwayValueMaxFatigue;

	[Tooltip("% of Aim Stamina consumed per second while the weapon is Aimed.")]
	[Range(0f, 1f)]
	[Token(Token = "0x4002B0E")]
	[FieldOffset(Offset = "0x108")]
	public float m_SwayIncreasePerSecond;

	[Tooltip("% of Aim Stamina restored per second while the weapon is not Aimed.")]
	[Range(0f, 1f)]
	[Token(Token = "0x4002B0F")]
	[FieldOffset(Offset = "0x10C")]
	public float m_SwayDecreasePerSecond;

	[Tooltip("Slows down Aim Stamina depletion")]
	[Range(0f, 1f)]
	[Token(Token = "0x4002B10")]
	[FieldOffset(Offset = "0x110")]
	public float m_SwayEnergyBoostBonus;

	[Tooltip("Slows down Aim Stamina depletion")]
	[Range(0f, 1f)]
	[Token(Token = "0x4002B11")]
	[FieldOffset(Offset = "0x114")]
	public float m_SwayEnergyStimBonus;

	[Tooltip("Cooldown after exiting Aiming before the player can Aim again.")]
	[Token(Token = "0x4002B12")]
	[FieldOffset(Offset = "0x118")]
	public float m_RestartAimingSwayRecoveryTime;

	[Tooltip("% threshold of Aim Stamina where aim drop starts to be applied")]
	[Token(Token = "0x4002B13")]
	[FieldOffset(Offset = "0x11C")]
	public float m_AimingSwayDropThresholdPercent;

	[Header("Recoil")]
	[Range(0f, 90f)]
	[Token(Token = "0x4002B14")]
	[FieldOffset(Offset = "0x120")]
	public float m_PitchRecoilMin;

	[Range(0f, 90f)]
	[Token(Token = "0x4002B15")]
	[FieldOffset(Offset = "0x124")]
	public float m_PitchRecoilMax;

	[Range(-90f, 90f)]
	[Token(Token = "0x4002B16")]
	[FieldOffset(Offset = "0x128")]
	public float m_YawRecoilMin;

	[Range(-90f, 90f)]
	[Token(Token = "0x4002B17")]
	[FieldOffset(Offset = "0x12C")]
	public float m_YawRecoilMax;

	[Token(Token = "0x4002B18")]
	[FieldOffset(Offset = "0x130")]
	private float m_SwayValue;

	[Token(Token = "0x4002B19")]
	[FieldOffset(Offset = "0x134")]
	private float m_SwayRecoverTimer;

	[Token(Token = "0x4002B1A")]
	[FieldOffset(Offset = "0x138")]
	public string m_AimingStaminaExhaustedSound;

	[Token(Token = "0x4002B1B")]
	[FieldOffset(Offset = "0x140")]
	private PlayerControlMode m_RestoreControlMode;

	[Token(Token = "0x4002B1C")]
	private static GunItemSaveDataProxy m_GunItemSaveDataProxy;

	[Token(Token = "0x4002B1D")]
	private static Dictionary<GunType, Action<GameObject>> s_OnGunFired;

	[Token(Token = "0x4002B1E")]
	[FieldOffset(Offset = "0x148")]
	private AsyncOperationHandle<IList<GearItemData>> m_ValidAmmoHandle;

	[Token(Token = "0x4002B1F")]
	[FieldOffset(Offset = "0x160")]
	private int m_SelectedAmmoIndex;

	[Token(Token = "0x4002B20")]
	[FieldOffset(Offset = "0x164")]
	private int m_PreviousAmmoIndex;

	[Token(Token = "0x4002B21")]
	[FieldOffset(Offset = "0x168")]
	private bool m_HasStartedAiming;

	[Token(Token = "0x17000231")]
	public int RoundsToReloadPerClip
	{
		[Token(Token = "0x600236B")]
		[Address(RVA = "0x856C90", Offset = "0x855A90", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000232")]
	private IList<GearItemData> ValidAmmo
	{
		[Token(Token = "0x600236C")]
		[Address(RVA = "0x856CA0", Offset = "0x855AA0", Length = "0x42")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000233")]
	public GearItemData AmmoToShowInHud
	{
		[Token(Token = "0x600236D")]
		[Address(RVA = "0x856CF0", Offset = "0x855AF0", Length = "0xD2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000234")]
	public bool SupportsMultipleAmmoTypes
	{
		[Token(Token = "0x600236E")]
		[Address(RVA = "0x856DD0", Offset = "0x855BD0", Length = "0x85")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000235")]
	public bool IsSwappingAmmo
	{
		[Token(Token = "0x600236F")]
		[Address(RVA = "0x856E60", Offset = "0x855C60", Length = "0xC")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000236")]
	public bool IsClipEmpty
	{
		[Token(Token = "0x6002370")]
		[Address(RVA = "0x856E70", Offset = "0x855C70", Length = "0x48")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6002371")]
	[Address(RVA = "0x856EC0", Offset = "0x855CC0", Length = "0x181")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002372")]
	[Address(RVA = "0x857050", Offset = "0x855E50", Length = "0xAA")]
	public void Start()
	{
	}

	[Token(Token = "0x6002373")]
	[Address(RVA = "0x857100", Offset = "0x855F00", Length = "0x1FE")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002374")]
	[Address(RVA = "0x857300", Offset = "0x856100", Length = "0x1F5")]
	public bool TryGetSelectedAmmo(out GearItemData ammo)
	{
		ammo = null;
		return false;
	}

	[Token(Token = "0x6002375")]
	[Address(RVA = "0x857500", Offset = "0x856300", Length = "0x49")]
	private void SetSelectedAmmoIndex(int index)
	{
	}

	[Token(Token = "0x6002376")]
	[Address(RVA = "0x857550", Offset = "0x856350", Length = "0x1CB")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002377")]
	[Address(RVA = "0x857720", Offset = "0x856520", Length = "0x138")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002378")]
	[Address(RVA = "0x857860", Offset = "0x856660", Length = "0x92")]
	public void PlayFireAudio()
	{
	}

	[Token(Token = "0x6002379")]
	[Address(RVA = "0x857900", Offset = "0x856700", Length = "0x116")]
	public void AddRangeToClip(List<int> bullets)
	{
	}

	[Token(Token = "0x600237A")]
	[Address(RVA = "0x857A20", Offset = "0x856820", Length = "0xDE")]
	public void AddRoundsToClip(int count, int condition)
	{
	}

	[Token(Token = "0x600237B")]
	[Address(RVA = "0x857B00", Offset = "0x856900", Length = "0xB")]
	public void ClearSpentCasings()
	{
	}

	[Token(Token = "0x600237C")]
	[Address(RVA = "0x857B10", Offset = "0x856910", Length = "0x4F")]
	public void EmptyClip()
	{
	}

	[Token(Token = "0x600237D")]
	[Address(RVA = "0x857B60", Offset = "0x856960", Length = "0xE")]
	public void FillClipAtCondition(int condition)
	{
	}

	[Token(Token = "0x600237E")]
	[Address(RVA = "0x857B70", Offset = "0x856970", Length = "0x96")]
	public int GetAmmoCondition(int index)
	{
		return 0;
	}

	[Token(Token = "0x600237F")]
	[Address(RVA = "0x857C10", Offset = "0x856A10", Length = "0x45")]
	public int NumRoundsInClip()
	{
		return 0;
	}

	[Token(Token = "0x6002380")]
	[Address(RVA = "0x694DD0", Offset = "0x693BD0", Length = "0x7")]
	public int NumSpentCasingsInClip()
	{
		return 0;
	}

	[Token(Token = "0x6002381")]
	[Address(RVA = "0x857C60", Offset = "0x856A60", Length = "0xA8")]
	public void RemoveNextFromClip()
	{
	}

	[Token(Token = "0x6002382")]
	[Address(RVA = "0x857D10", Offset = "0x856B10", Length = "0x57")]
	public int TotalCasingsInClip()
	{
		return 0;
	}

	[Token(Token = "0x6002383")]
	[Address(RVA = "0x857D70", Offset = "0x856B70", Length = "0x1C0")]
	public float GetSwayIncreasePerSecond()
	{
		return 0f;
	}

	[Token(Token = "0x6002384")]
	[Address(RVA = "0x857F40", Offset = "0x856D40", Length = "0x135")]
	public float GetSwayDecreasePerSecond()
	{
		return 0f;
	}

	[Token(Token = "0x6002385")]
	[Address(RVA = "0x858080", Offset = "0x856E80", Length = "0x11")]
	public float GetCurrentStaminaPercent()
	{
		return 0f;
	}

	[Token(Token = "0x6002386")]
	[Address(RVA = "0x8580A0", Offset = "0x856EA0", Length = "0x29")]
	public float GetStaminaDropThresholdPercent()
	{
		return 0f;
	}

	[Token(Token = "0x6002387")]
	[Address(RVA = "0x8580D0", Offset = "0x856ED0", Length = "0xB5")]
	public bool CanStartAiming()
	{
		return false;
	}

	[Token(Token = "0x6002388")]
	[Address(RVA = "0x858190", Offset = "0x856F90", Length = "0x8D3")]
	public void Update()
	{
	}

	[Token(Token = "0x6002389")]
	[Address(RVA = "0x858A70", Offset = "0x857870", Length = "0x8F")]
	public void PlayDryFireAudio(GameObject _)
	{
	}

	[Token(Token = "0x600238A")]
	[Address(RVA = "0x858B00", Offset = "0x857900", Length = "0x132")]
	public void ZoomStart()
	{
	}

	[Token(Token = "0x600238B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnAiming()
	{
	}

	[Token(Token = "0x600238C")]
	[Address(RVA = "0x858C40", Offset = "0x857A40", Length = "0x1B7")]
	public void ZoomEnd()
	{
	}

	[Token(Token = "0x600238D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnAimingStoppedComplete()
	{
	}

	[Token(Token = "0x600238E")]
	[Address(RVA = "0x858E00", Offset = "0x857C00", Length = "0x87")]
	public void ResetControlState()
	{
	}

	[Token(Token = "0x600238F")]
	[Address(RVA = "0x858E90", Offset = "0x857C90", Length = "0xC7")]
	public void MaybePlayUncockAudio(GameObject _)
	{
	}

	[Token(Token = "0x6002390")]
	[Address(RVA = "0x858F60", Offset = "0x857D60", Length = "0x90")]
	public ItemWeight GetClipWeightKG()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6002391")]
	[Address(RVA = "0x858FF0", Offset = "0x857DF0", Length = "0x7")]
	public void SetJammed(bool state)
	{
	}

	[Token(Token = "0x6002392")]
	[Address(RVA = "0x859000", Offset = "0x857E00", Length = "0x4CE")]
	public void ResetEffects()
	{
	}

	[Token(Token = "0x6002393")]
	[Address(RVA = "0x8594D0", Offset = "0x8582D0", Length = "0x121")]
	private bool IsAiming()
	{
		return false;
	}

	[Token(Token = "0x6002394")]
	[Address(RVA = "0x859600", Offset = "0x858400", Length = "0x122")]
	private bool IsAllowedToFire()
	{
		return false;
	}

	[Token(Token = "0x6002395")]
	[Address(RVA = "0x859730", Offset = "0x858530", Length = "0x10F")]
	private bool IsFiring()
	{
		return false;
	}

	[Token(Token = "0x6002396")]
	[Address(RVA = "0x859840", Offset = "0x858640", Length = "0x2EC")]
	private bool IsEquipped()
	{
		return false;
	}

	[Token(Token = "0x6002397")]
	[Address(RVA = "0x859B30", Offset = "0x858930", Length = "0x89")]
	public float GetRecoilPitch()
	{
		return 0f;
	}

	[Token(Token = "0x6002398")]
	[Address(RVA = "0x859BC0", Offset = "0x8589C0", Length = "0x89")]
	public float GetRecoilYaw()
	{
		return 0f;
	}

	[Token(Token = "0x6002399")]
	[Address(RVA = "0x859C50", Offset = "0x858A50", Length = "0x2C9")]
	public void StruggleRevolverFire()
	{
	}

	[Token(Token = "0x600239A")]
	[Address(RVA = "0x859F20", Offset = "0x858D20", Length = "0x289")]
	public void Fired(GameObject projectile)
	{
	}

	[Token(Token = "0x600239B")]
	[Address(RVA = "0x85A1B0", Offset = "0x858FB0", Length = "0x135")]
	public void HandleShellDischarge()
	{
	}

	[Token(Token = "0x600239C")]
	[Address(RVA = "0x85A2F0", Offset = "0x8590F0", Length = "0x99")]
	public void MaybeHandleMisfire()
	{
	}

	[Token(Token = "0x600239D")]
	[Address(RVA = "0x85A390", Offset = "0x859190", Length = "0x176")]
	public bool RollForMisfire()
	{
		return false;
	}

	[Token(Token = "0x600239E")]
	[Address(RVA = "0x85A510", Offset = "0x859310", Length = "0xBF")]
	public void PlayCasingAudio(int count)
	{
	}

	[Token(Token = "0x600239F")]
	[Address(RVA = "0x85A5D0", Offset = "0x8593D0", Length = "0x242")]
	public static void RegisterOnFiredAction(Action<GameObject> action, GunType gunType)
	{
	}

	[Token(Token = "0x60023A0")]
	[Address(RVA = "0x85A820", Offset = "0x859620", Length = "0x16B")]
	public static void UnRegisterOnFiredAction(Action<GameObject> action, GunType gunType)
	{
	}

	[Token(Token = "0x60023A1")]
	[Address(RVA = "0x85A990", Offset = "0x859790", Length = "0x1E7")]
	private static bool IsFiredActionRegistered(Action<GameObject> action, GunType gunType)
	{
		return false;
	}

	[Token(Token = "0x60023A2")]
	[Address(RVA = "0x85AB80", Offset = "0x859980", Length = "0x180")]
	public bool CanReload()
	{
		return false;
	}

	[Token(Token = "0x60023A3")]
	[Address(RVA = "0x85AD10", Offset = "0x859B10", Length = "0x7B")]
	public void PressReloadAmmo()
	{
	}

	[Token(Token = "0x60023A4")]
	[Address(RVA = "0x85AD90", Offset = "0x859B90", Length = "0x58")]
	public bool CanSwitchAmmo()
	{
		return false;
	}

	[Token(Token = "0x60023A5")]
	[Address(RVA = "0x85ADF0", Offset = "0x859BF0", Length = "0xE4")]
	public void PressSwitchAmmo()
	{
	}

	[Token(Token = "0x60023A6")]
	[Address(RVA = "0x85AEE0", Offset = "0x859CE0", Length = "0x234")]
	public void UnloadPreviousAmmoType()
	{
	}

	[Token(Token = "0x60023A7")]
	[Address(RVA = "0x85B120", Offset = "0x859F20", Length = "0x221")]
	private int GetNextValidAmmoIndex()
	{
		return 0;
	}

	[Token(Token = "0x60023A8")]
	[Address(RVA = "0x85B350", Offset = "0x85A150", Length = "0x107")]
	private int GetNumAmmoInInventory(GearItemData ammoData)
	{
		return 0;
	}

	[Token(Token = "0x60023A9")]
	[Address(RVA = "0x85B460", Offset = "0x85A260", Length = "0x122")]
	private void MaybeLoadAmmoReferencesAsync()
	{
	}

	[Token(Token = "0x60023AA")]
	[Address(RVA = "0x85B590", Offset = "0x85A390", Length = "0x4B0")]
	private void SynchronizeFirstPersonAmmoFX()
	{
	}

	[Token(Token = "0x60023AB")]
	[Address(RVA = "0x85BA50", Offset = "0x85A850", Length = "0x2B1")]
	public GunItem()
	{
	}
}

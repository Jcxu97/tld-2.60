using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.AddressableAssets;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Timeline;

namespace TLD.Gear;

[RequireComponent(typeof(GearItem))]
[Token(Token = "0x2001433")]
public class Respirator : AfflictionTriggerListener
{
	[AutoComponent(ComponentRequirement.Required)]
	[SerializeField]
	[Token(Token = "0x4009342")]
	[FieldOffset(Offset = "0x28")]
	private GearItem m_GearItem;

	[SerializeField]
	[Token(Token = "0x4009343")]
	[FieldOffset(Offset = "0x30")]
	private List<AfflictionType> m_ProtectionTypes;

	[Header("Gameplay")]
	[SerializeField]
	[Token(Token = "0x4009344")]
	[FieldOffset(Offset = "0x38")]
	private RespiratorCanister m_AttachedCanister;

	[SerializeField]
	[Token(Token = "0x4009345")]
	[FieldOffset(Offset = "0x40")]
	private LocalizedString m_CanisterRequiredEquipError;

	[Header("Animation")]
	[SerializeField]
	[Token(Token = "0x4009346")]
	[FieldOffset(Offset = "0x48")]
	private AssetReferenceTimeline m_EquipTimelineAsset;

	[SerializeField]
	[Token(Token = "0x4009347")]
	[FieldOffset(Offset = "0x50")]
	private AssetReferenceTimeline m_SwapTimelineAsset;

	[SerializeField]
	[Token(Token = "0x4009348")]
	[FieldOffset(Offset = "0x58")]
	private AssetReferenceTimeline m_UnequipTimelineAsset;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4009349")]
	[FieldOffset(Offset = "0x60")]
	private RTPC m_ConditionRTPC;

	[Token(Token = "0x400934A")]
	[FieldOffset(Offset = "0x68")]
	private RespiratorCanister m_PostAnimTargetCanister;

	[Token(Token = "0x400934B")]
	[FieldOffset(Offset = "0x70")]
	private string m_DelayAttachCanisterPDID;

	[Token(Token = "0x400934C")]
	[FieldOffset(Offset = "0x78")]
	private AsyncOperationHandle<TimelineAsset> m_TimelineHandle;

	[Token(Token = "0x400934D")]
	[FieldOffset(Offset = "0x90")]
	private PlayerAnimation.CameraBasedHandPositioningMode m_LastCameraBasedHandPositionMode;

	[Token(Token = "0x17000B23")]
	public float CanisterCondition
	{
		[Token(Token = "0x60080D8")]
		[Address(RVA = "0x120F0C0", Offset = "0x120DEC0", Length = "0xEC")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000B24")]
	public bool HasActiveProtection
	{
		[Token(Token = "0x60080D9")]
		[Address(RVA = "0x120F1B0", Offset = "0x120DFB0", Length = "0x1A1")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000B25")]
	public bool HasCanister
	{
		[Token(Token = "0x60080DA")]
		[Address(RVA = "0x120F360", Offset = "0x120E160", Length = "0xCA")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000B26")]
	public bool IsEquippedInstance
	{
		[Token(Token = "0x60080DB")]
		[Address(RVA = "0x120F430", Offset = "0x120E230", Length = "0x19A")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60080DC")]
	[Address(RVA = "0x120F5D0", Offset = "0x120E3D0", Length = "0x14F")]
	protected new void Awake()
	{
	}

	[Token(Token = "0x60080DD")]
	[Address(RVA = "0x120F720", Offset = "0x120E520", Length = "0xE9")]
	protected new void OnDestroy()
	{
	}

	[Token(Token = "0x60080DE")]
	[Address(RVA = "0x120F810", Offset = "0x120E610", Length = "0x15C")]
	public void CompleteSpawnFromCONSOLE()
	{
	}

	[Token(Token = "0x60080DF")]
	[Address(RVA = "0x120F970", Offset = "0x120E770", Length = "0x338")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x60080E0")]
	[Address(RVA = "0x120FCB0", Offset = "0x120EAB0", Length = "0x82")]
	protected override bool IsSupportedType(AfflictionType afflictionType)
	{
		return false;
	}

	[Token(Token = "0x60080E1")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public override void OnStartAffliction()
	{
	}

	[Token(Token = "0x60080E2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public override void OnStopAffliction()
	{
	}

	[Token(Token = "0x60080E3")]
	[Address(RVA = "0x120FD40", Offset = "0x120EB40", Length = "0x415")]
	public void Deserialize(RespiratorSaveData data)
	{
	}

	[Token(Token = "0x60080E4")]
	[Address(RVA = "0x1210160", Offset = "0x120EF60", Length = "0x40C")]
	public RespiratorSaveData Serialize()
	{
		return null;
	}

	[Token(Token = "0x60080E5")]
	[Address(RVA = "0x1210570", Offset = "0x120F370", Length = "0x1A6")]
	public void ForceExpireCanister()
	{
	}

	[Token(Token = "0x60080E6")]
	[Address(RVA = "0x1210720", Offset = "0x120F520", Length = "0x186")]
	public bool MaybeEquipOrRemove()
	{
		return false;
	}

	[Token(Token = "0x60080E7")]
	[Address(RVA = "0x12108B0", Offset = "0x120F6B0", Length = "0x10D")]
	public void MaybeInterruptAnimations()
	{
	}

	[Token(Token = "0x60080E8")]
	[Address(RVA = "0x12109C0", Offset = "0x120F7C0", Length = "0x472")]
	private void AttachCanister(RespiratorCanister canister)
	{
	}

	[Token(Token = "0x60080E9")]
	[Address(RVA = "0x1210E40", Offset = "0x120FC40", Length = "0x246")]
	private RespiratorCanister FindNextValidCanister()
	{
		return null;
	}

	[Token(Token = "0x60080EA")]
	[Address(RVA = "0x1211090", Offset = "0x120FE90", Length = "0x176")]
	private void FinishAnimation()
	{
	}

	[Token(Token = "0x60080EB")]
	[Address(RVA = "0x1211210", Offset = "0x1210010", Length = "0x176")]
	private void ForceCanisterAttachment()
	{
	}

	[Token(Token = "0x60080EC")]
	[Address(RVA = "0x1211390", Offset = "0x1210190", Length = "0x324")]
	private bool MaybeHandleItemInHandsCustom()
	{
		return false;
	}

	[Token(Token = "0x60080ED")]
	[Address(RVA = "0x12116C0", Offset = "0x12104C0", Length = "0x221")]
	private void MaybeUnattachCurrentCanister()
	{
	}

	[Token(Token = "0x60080EE")]
	[Address(RVA = "0x12118F0", Offset = "0x12106F0", Length = "0x13A")]
	private void OnCanisterSwapComplete()
	{
	}

	[Token(Token = "0x60080EF")]
	[Address(RVA = "0x1211A30", Offset = "0x1210830", Length = "0x57")]
	private void OnUnequipComplete()
	{
	}

	[Token(Token = "0x60080F0")]
	[Address(RVA = "0x1211A90", Offset = "0x1210890", Length = "0x2F3")]
	private void PlayTimelineAnimation(AssetReferenceTimeline timelineAssetReference, Action onStop)
	{
	}

	[Token(Token = "0x60080F1")]
	[Address(RVA = "0x1211D90", Offset = "0x1210B90", Length = "0x2D3")]
	private void StartAnimation(AssetReferenceTimeline timelineAssetReference, Action onStop)
	{
	}

	[Token(Token = "0x60080F2")]
	[Address(RVA = "0x1212070", Offset = "0x1210E70", Length = "0x125")]
	private void HandleItemInHands()
	{
	}

	[Token(Token = "0x60080F3")]
	[Address(RVA = "0x12121A0", Offset = "0x1210FA0", Length = "0x413")]
	private bool TryEquip()
	{
		return false;
	}

	[Token(Token = "0x60080F4")]
	[Address(RVA = "0x12125C0", Offset = "0x12113C0", Length = "0xA6")]
	public bool TryUnequip()
	{
		return false;
	}

	[Token(Token = "0x60080F5")]
	[Address(RVA = "0x1212670", Offset = "0x1211470", Length = "0x2C5")]
	private void UpdateCanisterSwap()
	{
	}

	[Token(Token = "0x60080F6")]
	[Address(RVA = "0x1212940", Offset = "0x1211740", Length = "0xE3")]
	public Respirator()
	{
	}
}

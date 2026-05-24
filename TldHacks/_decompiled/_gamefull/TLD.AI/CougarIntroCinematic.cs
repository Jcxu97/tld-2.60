using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.AddressableAssets;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Timeline;

namespace TLD.AI;

[Token(Token = "0x20014FE")]
public class CougarIntroCinematic : MonoBehaviour
{
	[Token(Token = "0x40097B0")]
	[FieldOffset(Offset = "0x20")]
	public List<AssetReferenceTimeline> m_CougarIntroTimelineAssets;

	[SerializeField]
	[Token(Token = "0x40097B1")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_CougarModelGO;

	[SerializeField]
	[Token(Token = "0x40097B2")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_CougarAuroraModelGO;

	[SerializeField]
	[Token(Token = "0x40097B3")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_SyncPointGO;

	[SerializeField]
	[Token(Token = "0x40097B4")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_OnPlayActivateAudioGameObject;

	[Token(Token = "0x40097B5")]
	[FieldOffset(Offset = "0x48")]
	private List<AsyncOperationHandle<TimelineAsset>> m_TimelineHandles;

	[Token(Token = "0x40097B6")]
	[FieldOffset(Offset = "0x50")]
	private PlayerAnimation.CameraBasedHandPositioningMode m_LastCameraBasedHandPositionMode;

	[Token(Token = "0x40097B7")]
	[FieldOffset(Offset = "0x58")]
	private Action m_OnFinish;

	[Token(Token = "0x40097B8")]
	[FieldOffset(Offset = "0x60")]
	private GameObject m_ActiveCougar;

	[Token(Token = "0x40097B9")]
	[FieldOffset(Offset = "0x68")]
	private int m_NextTimelineIndex;

	[Token(Token = "0x40097BA")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_WasCrouched;

	[Token(Token = "0x60084A8")]
	[Address(RVA = "0x1264C10", Offset = "0x1263A10", Length = "0x342")]
	private void Start()
	{
	}

	[Token(Token = "0x60084A9")]
	[Address(RVA = "0x1264F60", Offset = "0x1263D60", Length = "0xB6")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60084AA")]
	[Address(RVA = "0x1265020", Offset = "0x1263E20", Length = "0x21B")]
	private bool TryLoadAllTimelines()
	{
		return false;
	}

	[Token(Token = "0x60084AB")]
	[Address(RVA = "0x1265240", Offset = "0x1264040", Length = "0x205")]
	private void ReleaseHandles(int count)
	{
	}

	[Token(Token = "0x60084AC")]
	[Address(RVA = "0x1265450", Offset = "0x1264250", Length = "0x3F8")]
	public bool PlayTimelineAnimation(Action onFinish)
	{
		return false;
	}

	[Token(Token = "0x60084AD")]
	[Address(RVA = "0x1265850", Offset = "0x1264650", Length = "0x5CB")]
	private void PlayTimeline(int index)
	{
	}

	[Token(Token = "0x60084AE")]
	[Address(RVA = "0x1265E20", Offset = "0x1264C20", Length = "0x22E")]
	private void FinishAnimation()
	{
	}

	[Token(Token = "0x60084AF")]
	[Address(RVA = "0x1266050", Offset = "0x1264E50", Length = "0x18F")]
	public CougarIntroCinematic()
	{
	}
}

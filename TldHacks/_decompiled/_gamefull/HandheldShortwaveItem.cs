using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Audio;
using Cpp2ILInjected;
using InteractiveObjects;
using TLD.FX;
using UnityEngine;

[Token(Token = "0x20004A8")]
public class HandheldShortwaveItem : MonoBehaviour
{
	[Token(Token = "0x20004A9")]
	public enum Range
	{
		[Token(Token = "0x4002B37")]
		OutOfRange,
		[Token(Token = "0x4002B38")]
		FullSignal,
		[Token(Token = "0x4002B39")]
		AudioStart,
		[Token(Token = "0x4002B3A")]
		Far
	}

	[Token(Token = "0x20004AA")]
	private enum DeviceState
	{
		[Token(Token = "0x4002B3C")]
		Tracking,
		[Token(Token = "0x4002B3D")]
		SwitchingMode,
		[Token(Token = "0x4002B3E")]
		Off
	}

	[CompilerGenerated]
	[Token(Token = "0x20004AB")]
	private sealed class _003CUpdateTrackingInfoCoroutine_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002B3F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002B40")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002B41")]
		[FieldOffset(Offset = "0x20")]
		public HandheldShortwaveItem _003C_003E4__this;

		[Token(Token = "0x17000237")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60023CB")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000238")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60023CD")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60023C8")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CUpdateTrackingInfoCoroutine_003Ed__45(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60023C9")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60023CA")]
		[Address(RVA = "0x85E310", Offset = "0x85D110", Length = "0x8D")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x60023CC")]
		[Address(RVA = "0x85E3A0", Offset = "0x85D1A0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4002B23")]
	public static bool s_ShowDebugInfo;

	[Token(Token = "0x4002B24")]
	[FieldOffset(Offset = "0x20")]
	public List<TrackableItemType> m_TrackingModes;

	[HideInInspector]
	[Token(Token = "0x4002B26")]
	[FieldOffset(Offset = "0x30")]
	public Range m_NearestRange;

	[HideInInspector]
	[Token(Token = "0x4002B27")]
	[FieldOffset(Offset = "0x34")]
	public float m_NearestDistance;

	[HideInInspector]
	[Token(Token = "0x4002B28")]
	[FieldOffset(Offset = "0x38")]
	public float m_Intensity;

	[HideInInspector]
	[Token(Token = "0x4002B29")]
	[FieldOffset(Offset = "0x3C")]
	public float m_NearestAudioRange;

	[HideInInspector]
	[Token(Token = "0x4002B2A")]
	[FieldOffset(Offset = "0x40")]
	public float m_NearestFullSignalRange;

	[HideInInspector]
	[Token(Token = "0x4002B2B")]
	[FieldOffset(Offset = "0x44")]
	public float m_NearestMaxRange;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4002B2C")]
	[FieldOffset(Offset = "0x48")]
	private HandheldShortwaveAudio m_AudioComponent;

	[Header("VFX")]
	[SerializeField]
	[Token(Token = "0x4002B2D")]
	[FieldOffset(Offset = "0x50")]
	private EmissiveGlow m_EmissiveGlow;

	[SerializeField]
	[Token(Token = "0x4002B2E")]
	[FieldOffset(Offset = "0x58")]
	private EmissiveGlow.Channel m_GaugeGlowMaskChannel;

	[SerializeField]
	[Token(Token = "0x4002B2F")]
	[FieldOffset(Offset = "0x5C")]
	private EmissiveGlow.Channel m_BlinkingLightGlowMaskChannel;

	[Tooltip("X: Distance, Y: Blink/Beep Rate")]
	[SerializeField]
	[Token(Token = "0x4002B30")]
	[FieldOffset(Offset = "0x60")]
	private AnimationCurve m_BlinkRatePerDistanceAnimationCurve;

	[Token(Token = "0x4002B31")]
	[FieldOffset(Offset = "0x68")]
	private Coroutine m_TrackingInformationUpdate;

	[Token(Token = "0x4002B32")]
	[FieldOffset(Offset = "0x70")]
	private float m_LedBlinkTimer;

	[Token(Token = "0x4002B33")]
	[FieldOffset(Offset = "0x74")]
	private bool m_LastElectrostaticForceActive;

	[Token(Token = "0x4002B34")]
	[FieldOffset(Offset = "0x78")]
	private TrackableItemType m_CurrentTrackingMode;

	[Token(Token = "0x4002B35")]
	[FieldOffset(Offset = "0x80")]
	private DeviceState m_DeviceState;

	[Token(Token = "0x14000003")]
	public event Action<TrackableItemType> m_TrackingModeChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x60023AE")]
		[Address(RVA = "0x85BFC0", Offset = "0x85ADC0", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60023AF")]
		[Address(RVA = "0x85C130", Offset = "0x85AF30", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x60023B0")]
	[Address(RVA = "0x85C2A0", Offset = "0x85B0A0", Length = "0x82")]
	private void Awake()
	{
	}

	[Token(Token = "0x60023B1")]
	[Address(RVA = "0x85C330", Offset = "0x85B130", Length = "0xB4")]
	public HandheldShortwaveSaveDataProxy Serialize()
	{
		return null;
	}

	[Token(Token = "0x60023B2")]
	[Address(RVA = "0x85C3F0", Offset = "0x85B1F0", Length = "0x24A")]
	public void Deserialize(HandheldShortwaveSaveDataProxy saveProxy)
	{
	}

	[Token(Token = "0x60023B3")]
	[Address(RVA = "0x85C640", Offset = "0x85B440", Length = "0x243")]
	private void Update()
	{
	}

	[Token(Token = "0x60023B4")]
	[Address(RVA = "0x85C890", Offset = "0x85B690", Length = "0xDF")]
	public void UpdateAudio()
	{
	}

	[Token(Token = "0x60023B5")]
	[Address(RVA = "0x85C970", Offset = "0x85B770", Length = "0x79")]
	public bool CanTrack()
	{
		return false;
	}

	[Token(Token = "0x60023B6")]
	[Address(RVA = "0x85C9F0", Offset = "0x85B7F0", Length = "0x29F")]
	public bool IsEquipped()
	{
		return false;
	}

	[Token(Token = "0x60023B7")]
	[Address(RVA = "0x85CC90", Offset = "0x85BA90", Length = "0x264")]
	public void OnAddedToBackPack()
	{
	}

	[Token(Token = "0x60023B8")]
	[Address(RVA = "0x85CF00", Offset = "0x85BD00", Length = "0x1D1")]
	public void OnEquippedInHand()
	{
	}

	[Token(Token = "0x60023B9")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public static string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x60023BA")]
	[Address(RVA = "0x85D0E0", Offset = "0x85BEE0", Length = "0x27")]
	private float GetNormalizedDistance()
	{
		return 0f;
	}

	[Token(Token = "0x60023BB")]
	[Address(RVA = "0x85D110", Offset = "0x85BF10", Length = "0x10")]
	private void Reset()
	{
	}

	[Token(Token = "0x60023BC")]
	[Address(RVA = "0x85D120", Offset = "0x85BF20", Length = "0xE3")]
	private bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x60023BD")]
	[Address(RVA = "0x85D210", Offset = "0x85C010", Length = "0x1BC")]
	private void UpdateBlinkingLight()
	{
	}

	[Token(Token = "0x60023BE")]
	[Address(RVA = "0x85D3D0", Offset = "0x85C1D0", Length = "0xBC")]
	public float GetBlinkAudioInterval()
	{
		return 0f;
	}

	[Token(Token = "0x60023BF")]
	[Address(RVA = "0x85D490", Offset = "0x85C290", Length = "0x906")]
	private void UpdateTrackingInformation()
	{
	}

	[Token(Token = "0x60023C0")]
	[Address(RVA = "0x85DDA0", Offset = "0x85CBA0", Length = "0xEA")]
	public void StartSwitchingTrackingMode()
	{
	}

	[Token(Token = "0x60023C1")]
	[Address(RVA = "0x85DE90", Offset = "0x85CC90", Length = "0xB")]
	public bool IsSwitchingMode()
	{
		return false;
	}

	[Token(Token = "0x60023C2")]
	[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
	public TrackableItemType GetTrackableMode()
	{
		return null;
	}

	[Token(Token = "0x60023C3")]
	[Address(RVA = "0x85DEA0", Offset = "0x85CCA0", Length = "0x7")]
	private void SetDeviceState(DeviceState deviceState)
	{
	}

	[Token(Token = "0x60023C4")]
	[Address(RVA = "0x85DEB0", Offset = "0x85CCB0", Length = "0x5B")]
	private void UpdateNearestRange(TrackableItemData item, float nearestDistance)
	{
	}

	[Token(Token = "0x60023C5")]
	[Address(RVA = "0x85DF10", Offset = "0x85CD10", Length = "0x30A")]
	private void SetCurrentTrackingMode(TrackableItemType trackingMode, bool fireEvent = true)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateTrackingInfoCoroutine_003Ed__45))]
	[Token(Token = "0x60023C6")]
	[Address(RVA = "0x85E220", Offset = "0x85D020", Length = "0x9A")]
	private IEnumerator UpdateTrackingInfoCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60023C7")]
	[Address(RVA = "0x85E2C0", Offset = "0x85D0C0", Length = "0x4D")]
	public HandheldShortwaveItem()
	{
	}
}

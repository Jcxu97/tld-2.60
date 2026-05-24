using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007FB")]
public class AnimationEvents : StateMachineBehaviour
{
	[Token(Token = "0x40054EB")]
	[FieldOffset(Offset = "0x18")]
	public float m_FrameRate;

	[Token(Token = "0x40054EC")]
	[FieldOffset(Offset = "0x20")]
	public List<AnimationEventData> m_Events;

	[Token(Token = "0x40054ED")]
	[FieldOffset(Offset = "0x28")]
	private bool[] m_EventsPushed;

	[Token(Token = "0x40054EE")]
	[FieldOffset(Offset = "0x30")]
	private bool[] m_EventsPopped;

	[Token(Token = "0x40054EF")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<string, AnimationEventStack> m_EventStacks;

	[Token(Token = "0x40054F0")]
	[FieldOffset(Offset = "0x40")]
	private float m_NumFrames;

	[Token(Token = "0x40054F1")]
	[FieldOffset(Offset = "0x44")]
	private float m_LastFrameId;

	[Token(Token = "0x40054F2")]
	[FieldOffset(Offset = "0x48")]
	private float m_SyncNormalizedTime;

	[Token(Token = "0x40054F3")]
	[FieldOffset(Offset = "0x4C")]
	private int m_NumTimesLooped;

	[Token(Token = "0x40054F4")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<int, bool> m_HasEntered;

	[Token(Token = "0x40054F5")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<int, bool> m_HasUpdated;

	[Token(Token = "0x40054F6")]
	[FieldOffset(Offset = "0x60")]
	private PlayEventMonitor m_PlayEventMonitor;

	[Token(Token = "0x40054F7")]
	[FieldOffset(Offset = "0x68")]
	private uint m_NumSubtitles;

	[Token(Token = "0x40054F8")]
	private static Utils.Subtitle[] s_Subtitles;

	[Token(Token = "0x40054F9")]
	[FieldOffset(Offset = "0x70")]
	private List<Animator> m_FilteredListForResetEventStacks;

	[Token(Token = "0x6004AF2")]
	[Address(RVA = "0xD48A50", Offset = "0xD47850", Length = "0x106")]
	private void DoEnter(Animator animator, AnimatorStateInfo stateInfo)
	{
	}

	[Token(Token = "0x6004AF3")]
	[Address(RVA = "0xD48B60", Offset = "0xD47960", Length = "0x242")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004AF4")]
	[Address(RVA = "0xD48DB0", Offset = "0xD47BB0", Length = "0xA1F")]
	private void DoExit(AnimatorStateInfo stateInfo, Animator animator)
	{
	}

	[Token(Token = "0x6004AF5")]
	[Address(RVA = "0xD497D0", Offset = "0xD485D0", Length = "0x18C")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004AF6")]
	[Address(RVA = "0xD49960", Offset = "0xD48760", Length = "0x21D")]
	private void DoUpdate(AnimatorStateInfo stateInfo, Animator animator)
	{
	}

	[Token(Token = "0x6004AF7")]
	[Address(RVA = "0xD49B80", Offset = "0xD48980", Length = "0xAE")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004AF8")]
	[Address(RVA = "0xD49C30", Offset = "0xD48A30", Length = "0x8F0")]
	private void MaybeTriggerEvent(Animator animator, int index, float frame)
	{
	}

	[Token(Token = "0x6004AF9")]
	[Address(RVA = "0xD4A530", Offset = "0xD49330", Length = "0x308")]
	private void MaybeRecreateEventArrays()
	{
	}

	[Token(Token = "0x6004AFA")]
	[Address(RVA = "0xD4A840", Offset = "0xD49640", Length = "0x8")]
	private void ProcessEndFrameEvents(Animator animator)
	{
	}

	[Token(Token = "0x6004AFB")]
	[Address(RVA = "0xD4A850", Offset = "0xD49650", Length = "0x59D")]
	private void ResetEventStacks(Animator animator)
	{
	}

	[Token(Token = "0x6004AFC")]
	[Address(RVA = "0xD4ADF0", Offset = "0xD49BF0", Length = "0x403")]
	private AnimationEventValue GetCurrentValueFromList(List<Animator> list, Animator animator, int hash, AnimatorControllerParameterType type, RuntimeAnimatorController target)
	{
		return default(AnimationEventValue);
	}

	[Token(Token = "0x6004AFD")]
	[Address(RVA = "0xD4B200", Offset = "0xD4A000", Length = "0x395")]
	private void EventHide(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Token(Token = "0x6004AFE")]
	[Address(RVA = "0xD4B5A0", Offset = "0xD4A3A0", Length = "0x395")]
	private void EventShow(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Token(Token = "0x6004AFF")]
	[Address(RVA = "0xD4B940", Offset = "0xD4A740", Length = "0x1D2")]
	private bool IsChildOfFP(GameObject go)
	{
		return false;
	}

	[Token(Token = "0x6004B00")]
	[Address(RVA = "0xD4BB20", Offset = "0xD4A920", Length = "0x4E6")]
	private void EventPlay(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Token(Token = "0x6004B01")]
	[Address(RVA = "0xD4C010", Offset = "0xD4AE10", Length = "0x4A1")]
	private void EventStop(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Token(Token = "0x6004B02")]
	[Address(RVA = "0xD4C4C0", Offset = "0xD4B2C0", Length = "0x13C")]
	private void EventPlayMovie(Animator animator, AnimationEventData eventAnimationData, float delay, float startTime)
	{
	}

	[Token(Token = "0x6004B03")]
	[Address(RVA = "0xD4C600", Offset = "0xD4B400", Length = "0x186")]
	private void EventDisplaySubtitles(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Token(Token = "0x6004B04")]
	[Address(RVA = "0xD4C790", Offset = "0xD4B590", Length = "0x69")]
	private void EventUpdateLayerWeight(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Token(Token = "0x6004B05")]
	[Address(RVA = "0xD4C800", Offset = "0xD4B600", Length = "0x63")]
	private void EnableHipAndShoulderOffsetLayerOverride(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Token(Token = "0x6004B06")]
	[Address(RVA = "0xD4C870", Offset = "0xD4B670", Length = "0x85")]
	private void EventCameraFadeIn(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Token(Token = "0x6004B07")]
	[Address(RVA = "0xD4C900", Offset = "0xD4B700", Length = "0x85")]
	private void EventCameraFadeOut(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Token(Token = "0x6004B08")]
	[Address(RVA = "0xD4C990", Offset = "0xD4B790", Length = "0x76")]
	private void EventPrepareMovie(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Token(Token = "0x6004B09")]
	[Address(RVA = "0xD4CA10", Offset = "0xD4B810", Length = "0x1A")]
	private void EventEnableObject(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Token(Token = "0x6004B0A")]
	[Address(RVA = "0xD4CA30", Offset = "0xD4B830", Length = "0x1A")]
	private void EventDisableObject(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Token(Token = "0x6004B0B")]
	[Address(RVA = "0xD4CA50", Offset = "0xD4B850", Length = "0x2BF")]
	private void DoEnableObject(Animator animator, AnimationEventData eventAnimationData, bool isEnabled)
	{
	}

	[Token(Token = "0x6004B0C")]
	[Address(RVA = "0xD4CD10", Offset = "0xD4BB10", Length = "0x45")]
	private void EventStopMovie(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Token(Token = "0x6004B0D")]
	[Address(RVA = "0xD4CD60", Offset = "0xD4BB60", Length = "0x43B")]
	private void SetParameterValue(Animator animator, string name, AnimationEventValue value, RuntimeAnimatorController target, int targetCycleOffsetHash)
	{
	}

	[Token(Token = "0x6004B0E")]
	[Address(RVA = "0xD4D1A0", Offset = "0xD4BFA0", Length = "0x176")]
	private void PushAnimationEventValue(Animator animator, int index, AnimationEventValue value)
	{
	}

	[Token(Token = "0x6004B0F")]
	[Address(RVA = "0xD4D320", Offset = "0xD4C120", Length = "0x158")]
	private void PopAnimationEventValue(Animator animator, int index)
	{
	}

	[Token(Token = "0x6004B10")]
	[Address(RVA = "0xD4D480", Offset = "0xD4C280", Length = "0x2E9")]
	public AnimationEvents()
	{
	}
}

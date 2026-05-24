using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000872")]
public class NPC_Animation : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000873")]
	public class PermanentPropInfo
	{
		[Token(Token = "0x4005787")]
		[FieldOffset(Offset = "0x10")]
		public CinematicAssets.PermanentPropId m_PermanentPropId;

		[Token(Token = "0x4005788")]
		[FieldOffset(Offset = "0x18")]
		public Animator m_Animator;

		[Token(Token = "0x6004D93")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public PermanentPropInfo()
		{
		}
	}

	[Token(Token = "0x2000874")]
	public enum VO_State
	{
		[Token(Token = "0x400578A")]
		None,
		[Token(Token = "0x400578B")]
		RequestRandomVO,
		[Token(Token = "0x400578C")]
		VOPlaying
	}

	[SerializeField]
	[Token(Token = "0x4005765")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Subtitles> m_Subtitles;

	[Token(Token = "0x4005766")]
	[FieldOffset(Offset = "0x28")]
	public List<PermanentPropInfo> m_PermanentProps;

	[Token(Token = "0x4005767")]
	[FieldOffset(Offset = "0x30")]
	public List<string> m_LocIdList;

	[Token(Token = "0x4005768")]
	[FieldOffset(Offset = "0x38")]
	public int m_IdlesVariationCount;

	[Token(Token = "0x4005769")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_AudioEmitterNode;

	[Token(Token = "0x400576A")]
	[FieldOffset(Offset = "0x48")]
	public float m_MinDelayUntilNextVOSeconds;

	[Token(Token = "0x400576B")]
	[FieldOffset(Offset = "0x4C")]
	public float m_MaxDelayUntilNextVOSeconds;

	[Token(Token = "0x400576C")]
	[FieldOffset(Offset = "0x50")]
	public float m_MinDelayUntilNextIdleSeconds;

	[Token(Token = "0x400576D")]
	[FieldOffset(Offset = "0x54")]
	public float m_MaxDelayUntilNextIdleSeconds;

	[Token(Token = "0x400576E")]
	[FieldOffset(Offset = "0x58")]
	private VO_State m_VO_State;

	[Token(Token = "0x400576F")]
	[FieldOffset(Offset = "0x60")]
	private Animator m_Animator;

	[Token(Token = "0x4005770")]
	[FieldOffset(Offset = "0x68")]
	private int m_OnGoingAnimationState;

	[Token(Token = "0x4005771")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_AudioID;

	[Token(Token = "0x4005772")]
	[FieldOffset(Offset = "0x70")]
	private float m_VODuration;

	[Token(Token = "0x4005773")]
	[FieldOffset(Offset = "0x74")]
	private float m_AudioDurationRealtimeSeconds;

	[Token(Token = "0x4005774")]
	[FieldOffset(Offset = "0x78")]
	private float m_OnGoingAnimationDuration;

	[Token(Token = "0x4005775")]
	[FieldOffset(Offset = "0x7C")]
	private int m_NPCBaseLayerIndex;

	[Token(Token = "0x4005776")]
	[FieldOffset(Offset = "0x80")]
	private int m_NPCHeadLayerIndex;

	[Token(Token = "0x4005777")]
	[FieldOffset(Offset = "0x84")]
	private int m_NPCFaceLayerIndex;

	[Token(Token = "0x4005778")]
	[FieldOffset(Offset = "0x88")]
	private float m_VOElapsedTime;

	[Token(Token = "0x4005779")]
	[FieldOffset(Offset = "0x90")]
	private string m_OnGoingAnimationTrigger;

	[Token(Token = "0x400577A")]
	[FieldOffset(Offset = "0x98")]
	private string m_OnGoingFaceAnimationTrigger;

	[Token(Token = "0x400577B")]
	[FieldOffset(Offset = "0xA0")]
	private PlayEventMonitor m_PlayEventMonitor;

	[Token(Token = "0x400577C")]
	[FieldOffset(Offset = "0xA8")]
	private float m_NextVOElapsedTime;

	[Token(Token = "0x400577D")]
	[FieldOffset(Offset = "0xAC")]
	private float m_DelayUntilNextVOSeconds;

	[Token(Token = "0x400577E")]
	[FieldOffset(Offset = "0xB0")]
	private float m_NextIdleVariationElapsedTime;

	[Token(Token = "0x400577F")]
	[FieldOffset(Offset = "0xB4")]
	private float m_DelayUntilNextIdleVariationSeconds;

	[Token(Token = "0x4005780")]
	[FieldOffset(Offset = "0xB8")]
	private int m_CurrentRandomLocIndex;

	[Token(Token = "0x4005781")]
	[FieldOffset(Offset = "0xBC")]
	private int m_CurrentVariationIdleIndex;

	[Token(Token = "0x4005782")]
	[FieldOffset(Offset = "0xC0")]
	private int m_AnimParameter_IdleVariationIndex;

	[Token(Token = "0x4005783")]
	private const string TRIGGER_PREFIX = "Trigger_";

	[Token(Token = "0x4005784")]
	private const string TRIGGER_FACE_PREFIX = "Trigger_Face_";

	[Token(Token = "0x4005785")]
	private const string TRIGGER_IDLE = "Trigger_Idle";

	[Token(Token = "0x4005786")]
	private const string TRIGGER_IDLE_FACE = "Trigger_Idle_Face";

	[Token(Token = "0x6004D7D")]
	[Address(RVA = "0xD8C3C0", Offset = "0xD8B1C0", Length = "0x29")]
	private void RollDelayNextVO()
	{
	}

	[Token(Token = "0x6004D7E")]
	[Address(RVA = "0xD8C3F0", Offset = "0xD8B1F0", Length = "0x29")]
	private void RollDelayNextIdle()
	{
	}

	[Token(Token = "0x6004D7F")]
	[Address(RVA = "0xD8C420", Offset = "0xD8B220", Length = "0x3DF")]
	public void Awake()
	{
	}

	[Token(Token = "0x6004D80")]
	[Address(RVA = "0xD8C800", Offset = "0xD8B600", Length = "0x218")]
	public void Update()
	{
	}

	[Token(Token = "0x6004D81")]
	[Address(RVA = "0xD8CA20", Offset = "0xD8B820", Length = "0x7E")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6004D82")]
	[Address(RVA = "0xD8CAA0", Offset = "0xD8B8A0", Length = "0x8")]
	public bool IsNotSpeaking()
	{
		return false;
	}

	[Token(Token = "0x6004D83")]
	[Address(RVA = "0xD8CAB0", Offset = "0xD8B8B0", Length = "0xE")]
	public void RestoreIdleIndex()
	{
	}

	[Token(Token = "0x6004D84")]
	[Address(RVA = "0xD8CAC0", Offset = "0xD8B8C0", Length = "0x79")]
	private void Update_None()
	{
	}

	[Token(Token = "0x6004D85")]
	[Address(RVA = "0xD8CB40", Offset = "0xD8B940", Length = "0x105")]
	private string RollLocId()
	{
		return null;
	}

	[Token(Token = "0x6004D86")]
	[Address(RVA = "0xD8CC50", Offset = "0xD8BA50", Length = "0x7D")]
	private void RollCurrentIdleVariation()
	{
	}

	[Token(Token = "0x6004D87")]
	[Address(RVA = "0xD8CCD0", Offset = "0xD8BAD0", Length = "0x887")]
	private void RequestVO(string requestedLocId)
	{
	}

	[Token(Token = "0x6004D88")]
	[Address(RVA = "0xD8D560", Offset = "0xD8C360", Length = "0x123")]
	private void Update_RequestRandomVO()
	{
	}

	[Token(Token = "0x6004D89")]
	[Address(RVA = "0xD8D690", Offset = "0xD8C490", Length = "0x258")]
	private void Update_VOPlaying()
	{
	}

	[Token(Token = "0x6004D8A")]
	[Address(RVA = "0xD8D8F0", Offset = "0xD8C6F0", Length = "0x9F")]
	private void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[Token(Token = "0x6004D8B")]
	[Address(RVA = "0xD8D990", Offset = "0xD8C790", Length = "0xB1")]
	private float GetOnGoingStateDuration()
	{
		return 0f;
	}

	[Token(Token = "0x6004D8C")]
	[Address(RVA = "0xD8DA50", Offset = "0xD8C850", Length = "0x126")]
	private float ComputeSubtitleDurationInSeconds(string text)
	{
		return 0f;
	}

	[Token(Token = "0x6004D8D")]
	[Address(RVA = "0xD8DB80", Offset = "0xD8C980", Length = "0x2A5")]
	private void ReturnToIdleAnimation()
	{
	}

	[Token(Token = "0x6004D8E")]
	[Address(RVA = "0xD8DE30", Offset = "0xD8CC30", Length = "0x576")]
	private void LateSynchronizeAnimators(float currentTime, int stateHash)
	{
	}

	[Token(Token = "0x6004D8F")]
	[Address(RVA = "0xD8E3B0", Offset = "0xD8D1B0", Length = "0x1A5")]
	private void SynchronizePropAnimation(Animator animator, PlayEventMonitor playEventMonitor, float currentTime)
	{
	}

	[Token(Token = "0x6004D90")]
	[Address(RVA = "0xD8E560", Offset = "0xD8D360", Length = "0x283")]
	private void SetAnimationParameter_IdleVariationIndex(int idleVariationIndex)
	{
	}

	[Token(Token = "0x6004D91")]
	[Address(RVA = "0xD8E7F0", Offset = "0xD8D5F0", Length = "0x229")]
	private void MaybeChangeVariationIdle()
	{
	}

	[Token(Token = "0x6004D92")]
	[Address(RVA = "0xD8EA20", Offset = "0xD8D820", Length = "0x9D")]
	public NPC_Animation()
	{
	}
}

using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.GameplayTags;
using TLD.Logging;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x200148D")]
public class MiseryManager : MonoBehaviour
{
	[Token(Token = "0x200148E")]
	public enum MiseryAffliction
	{
		[Token(Token = "0x400952F")]
		None,
		[Token(Token = "0x4009530")]
		BrokenBody,
		[Token(Token = "0x4009531")]
		PoorCirculation,
		[Token(Token = "0x4009532")]
		SourStomach,
		[Token(Token = "0x4009533")]
		UnsettledSleep,
		[Token(Token = "0x4009534")]
		WeakConstitution,
		[Token(Token = "0x4009535")]
		WeakJoints
	}

	[Serializable]
	[Token(Token = "0x200148F")]
	private class MiseryStageSetting
	{
		[Min(1f)]
		[Token(Token = "0x4009536")]
		[FieldOffset(Offset = "0x10")]
		public int m_StageDurationDays;

		[Token(Token = "0x4009537")]
		[FieldOffset(Offset = "0x14")]
		public MiseryAffliction m_StaticAffliction;

		[Token(Token = "0x4009538")]
		[FieldOffset(Offset = "0x18")]
		public int m_RandomAfflictions;

		[Header("UI")]
		[Token(Token = "0x4009539")]
		[FieldOffset(Offset = "0x20")]
		public LocalizedString m_StageName;

		[Header("Audio")]
		[Token(Token = "0x400953A")]
		[FieldOffset(Offset = "0x28")]
		public AK.Wwise.Event m_StageMusicEvent;

		[Token(Token = "0x400953B")]
		[FieldOffset(Offset = "0x30")]
		public AK.Wwise.Event m_StageVoiceEvent;

		[Token(Token = "0x600828C")]
		[Address(RVA = "0x123B960", Offset = "0x123A760", Length = "0x8")]
		public MiseryStageSetting()
		{
		}
	}

	[Token(Token = "0x4009520")]
	private const string NOT_ACTIVE_TEXT = "Misery Manager Not Active";

	[Token(Token = "0x4009521")]
	private static readonly LogFilter s_LogFilter;

	[Header("Activation")]
	[SerializeField]
	[Token(Token = "0x4009522")]
	[FieldOffset(Offset = "0x20")]
	private GameplayTag m_ActiveTag;

	[Header("Stage Settings")]
	[SerializeField]
	[Token(Token = "0x4009523")]
	[FieldOffset(Offset = "0x30")]
	private float m_StageAfflictionDelay;

	[SerializeField]
	[Token(Token = "0x4009524")]
	[FieldOffset(Offset = "0x38")]
	private List<MiseryAffliction> m_RandomAfflictionPool;

	[SerializeField]
	[Token(Token = "0x4009525")]
	[FieldOffset(Offset = "0x40")]
	private List<MiseryStageSetting> m_MiseryStageSettings;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4009526")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_HUD> m_HudReference;

	[Token(Token = "0x4009527")]
	[FieldOffset(Offset = "0x50")]
	private MiseryManagerSaveData m_State;

	[Token(Token = "0x4009528")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsInitialized;

	[Token(Token = "0x4009529")]
	[FieldOffset(Offset = "0x59")]
	private bool m_IsActiveTagFound;

	[Token(Token = "0x400952A")]
	[FieldOffset(Offset = "0x5C")]
	private int m_NextStageHours;

	[Token(Token = "0x400952B")]
	[FieldOffset(Offset = "0x60")]
	private float m_CurrentAfflictionDelay;

	[Token(Token = "0x400952C")]
	[FieldOffset(Offset = "0x68")]
	private readonly List<MiseryAffliction> m_PendingAfflictions;

	[Token(Token = "0x400952D")]
	public static bool s_Debug;

	[Token(Token = "0x17000B55")]
	private float CurrentTimeHours
	{
		[Token(Token = "0x6008280")]
		[Address(RVA = "0x1239F60", Offset = "0x1238D60", Length = "0x7E")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x6008281")]
	[Address(RVA = "0x1239FE0", Offset = "0x1238DE0", Length = "0x1DC")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6008282")]
	[Address(RVA = "0x123A1C0", Offset = "0x1238FC0", Length = "0x361")]
	private void RollMiseryStages()
	{
	}

	[Token(Token = "0x6008283")]
	[Address(RVA = "0x123A530", Offset = "0x1239330", Length = "0x3E7")]
	private void Update()
	{
	}

	[Token(Token = "0x6008284")]
	[Address(RVA = "0x123A920", Offset = "0x1239720", Length = "0x36B")]
	private void GoToNextStage()
	{
	}

	[Token(Token = "0x6008285")]
	[Address(RVA = "0x123AC90", Offset = "0x1239A90", Length = "0x5C")]
	private void ApplyMiseryAffliction(MiseryAffliction affliction, bool deserialized = false)
	{
	}

	[Token(Token = "0x6008286")]
	[Address(RVA = "0x123AE90", Offset = "0x1239C90", Length = "0x199")]
	private void ShowMiseryStageUI()
	{
	}

	[Token(Token = "0x6008287")]
	[Address(RVA = "0x123B030", Offset = "0x1239E30", Length = "0x20C")]
	private void PlayMiseryStageAudio()
	{
	}

	[Token(Token = "0x6008288")]
	[Address(RVA = "0x123B240", Offset = "0x123A040", Length = "0xE")]
	public MiseryManagerSaveData Serialize()
	{
		return null;
	}

	[Token(Token = "0x6008289")]
	[Address(RVA = "0x123B250", Offset = "0x123A050", Length = "0x3AA")]
	public void Deserialize(MiseryManagerSaveData miseryManagerSaveData)
	{
	}

	[Token(Token = "0x600828A")]
	[Address(RVA = "0x123B600", Offset = "0x123A400", Length = "0x234")]
	public MiseryManager()
	{
	}
}

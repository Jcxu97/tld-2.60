using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000673")]
public class Panel_LifeAfterDeath : Panel_AutoReferenced
{
	[Serializable]
	[Token(Token = "0x2000674")]
	private struct Campfire
	{
		[Token(Token = "0x40041B7")]
		[FieldOffset(Offset = "0x0")]
		public GameObject m_CampFireParent;

		[Token(Token = "0x40041B8")]
		[FieldOffset(Offset = "0x8")]
		public GameObject m_LitCampfire;

		[Token(Token = "0x40041B9")]
		[FieldOffset(Offset = "0x10")]
		public UITweener[] m_BurnoutTweeners;
	}

	[Serializable]
	[Token(Token = "0x2000675")]
	private struct LifeAfterDeathStageGroup
	{
		[Token(Token = "0x40041BA")]
		[FieldOffset(Offset = "0x0")]
		public GameObject m_Group;

		[Token(Token = "0x40041BB")]
		[FieldOffset(Offset = "0x8")]
		public UITweener m_DisableTweener;

		[Token(Token = "0x40041BC")]
		[FieldOffset(Offset = "0x10")]
		public Transform m_ButtonParent;

		[Token(Token = "0x40041BD")]
		[FieldOffset(Offset = "0x18")]
		public UITweener[] m_ButtonTweens;
	}

	[Token(Token = "0x2000676")]
	private enum LifeAfterDeathStage
	{
		[Token(Token = "0x40041BF")]
		RevivingPlayer = -3,
		[Token(Token = "0x40041C0")]
		OpeningLogScreen,
		[Token(Token = "0x40041C1")]
		None,
		[Token(Token = "0x40041C2")]
		Revive,
		[Token(Token = "0x40041C3")]
		Text,
		[Token(Token = "0x40041C4")]
		Penalty,
		[Token(Token = "0x40041C5")]
		Spawn,
		[Token(Token = "0x40041C6")]
		Campfire
	}

	[Token(Token = "0x4004197")]
	private const string PERCENT_VALUE = "{percent-value}";

	[Token(Token = "0x4004198")]
	private const string DURATION_VALUE = "{duration-value}";

	[SerializeField]
	[Token(Token = "0x4004199")]
	[FieldOffset(Offset = "0x30")]
	private UISprite m_BackgroundSprite;

	[SerializeField]
	[Token(Token = "0x400419A")]
	[FieldOffset(Offset = "0x38")]
	private ButtonLegendContainer m_ButtonLegendContainer;

	[SerializeField]
	[Token(Token = "0x400419B")]
	[FieldOffset(Offset = "0x40")]
	private Transform m_ButtonLegendParent;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x400419C")]
	[FieldOffset(Offset = "0x48")]
	private State m_LifeAfterDeathOff;

	[SerializeField]
	[Token(Token = "0x400419D")]
	[FieldOffset(Offset = "0x50")]
	private State m_LifeAfterDeathOn;

	[Header("Life After Death Stages")]
	[SerializeField]
	[Token(Token = "0x400419E")]
	[FieldOffset(Offset = "0x58")]
	private LifeAfterDeathStageGroup[] m_StageGroups;

	[Header("Stage 1 - Revive")]
	[SerializeField]
	[Token(Token = "0x400419F")]
	[FieldOffset(Offset = "0x60")]
	private GameObject m_ReviveInteractions;

	[SerializeField]
	[Token(Token = "0x40041A0")]
	[FieldOffset(Offset = "0x68")]
	private UIWidget m_CheatDeathButtonWidget;

	[SerializeField]
	[Token(Token = "0x40041A1")]
	[FieldOffset(Offset = "0x70")]
	private float m_CheatDeathButtonDisabledAlpha;

	[SerializeField]
	[Token(Token = "0x40041A2")]
	[FieldOffset(Offset = "0x78")]
	private UILabel m_CauseOfDeathLabel;

	[SerializeField]
	[Token(Token = "0x40041A3")]
	[FieldOffset(Offset = "0x80")]
	private UIGrid m_CampfireGrid;

	[SerializeField]
	[Token(Token = "0x40041A4")]
	[FieldOffset(Offset = "0x88")]
	private Campfire[] m_Campfires;

	[Header("Stage 3 - Penalty")]
	[SerializeField]
	[Token(Token = "0x40041A5")]
	[FieldOffset(Offset = "0x90")]
	private LocalizedString m_ShortTermPenaltyText;

	[SerializeField]
	[Token(Token = "0x40041A6")]
	[FieldOffset(Offset = "0x98")]
	private UILabel m_ShortTermPenaltyLabel;

	[SerializeField]
	[Token(Token = "0x40041A7")]
	[FieldOffset(Offset = "0xA0")]
	private LocalizedString m_PermanentPenaltyText;

	[SerializeField]
	[Token(Token = "0x40041A8")]
	[FieldOffset(Offset = "0xA8")]
	private UILabel m_PermanentPenaltyLabel;

	[Header("Stage 5 - Campfire")]
	[SerializeField]
	[Token(Token = "0x40041A9")]
	[FieldOffset(Offset = "0xB0")]
	private UIGrid m_AnimatedCampfireGrid;

	[SerializeField]
	[Token(Token = "0x40041AA")]
	[FieldOffset(Offset = "0xB8")]
	private Campfire[] m_AnimatedCampfires;

	[Header("Tweens")]
	[SerializeField]
	[Token(Token = "0x40041AB")]
	[FieldOffset(Offset = "0xC0")]
	private UITweener m_TextTween;

	[SerializeField]
	[Token(Token = "0x40041AC")]
	[FieldOffset(Offset = "0xC8")]
	private TweenAlpha m_FadeOutTween;

	[SerializeField]
	[Token(Token = "0x40041AD")]
	[FieldOffset(Offset = "0xD0")]
	private TweenAlpha m_FastFadeOutTween;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40041AE")]
	[FieldOffset(Offset = "0xD8")]
	private PanelReference<Panel_Log> m_LogPanel;

	[SerializeField]
	[Token(Token = "0x40041AF")]
	[FieldOffset(Offset = "0xE0")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[Token(Token = "0x40041B0")]
	[FieldOffset(Offset = "0xE8")]
	private GamepadButtonSprite[] m_GamepadButtonSprites;

	[Token(Token = "0x40041B1")]
	[FieldOffset(Offset = "0xF0")]
	private LifeAfterDeathStage m_CurrentStage;

	[Token(Token = "0x40041B2")]
	[FieldOffset(Offset = "0xF4")]
	private LifeAfterDeathStage m_PendingStage;

	[Token(Token = "0x40041B3")]
	[FieldOffset(Offset = "0xF8")]
	private readonly List<UITweener> m_TweenerCache;

	[Token(Token = "0x40041B4")]
	[FieldOffset(Offset = "0x100")]
	private readonly List<UITweener> m_TrackedTweeners;

	[Token(Token = "0x40041B5")]
	[FieldOffset(Offset = "0x108")]
	private LifeAfterDeathSpawnPointType m_SelectedSpawnPointType;

	[Token(Token = "0x40041B6")]
	[FieldOffset(Offset = "0x10C")]
	private bool m_SelectedPermanentAffliction;

	[Token(Token = "0x600363B")]
	[Address(RVA = "0xAD5E30", Offset = "0xAD4C30", Length = "0x1C4")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600363C")]
	[Address(RVA = "0xAD6000", Offset = "0xAD4E00", Length = "0x255")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x600363D")]
	[Address(RVA = "0xAD6260", Offset = "0xAD5060", Length = "0xE9")]
	private void ShowLifeAfterDeath()
	{
	}

	[Token(Token = "0x600363E")]
	[Address(RVA = "0xAD6350", Offset = "0xAD5150", Length = "0x330")]
	private void SwitchToStage(LifeAfterDeathStage newStage)
	{
	}

	[Token(Token = "0x600363F")]
	[Address(RVA = "0xAD6690", Offset = "0xAD5490", Length = "0x9A1")]
	private void ActuallyShowStage(LifeAfterDeathStage newStage)
	{
	}

	[Token(Token = "0x6003640")]
	[Address(RVA = "0xAD7040", Offset = "0xAD5E40", Length = "0xA70")]
	private void PrepareStage()
	{
	}

	[Token(Token = "0x6003641")]
	[Address(RVA = "0xAD7AC0", Offset = "0xAD68C0", Length = "0x238")]
	private bool AnyTweenersPlaying()
	{
		return false;
	}

	[Token(Token = "0x6003642")]
	[Address(RVA = "0xAD7D00", Offset = "0xAD6B00", Length = "0x1CA")]
	public void HandleOnLeftButtonPressed()
	{
	}

	[Token(Token = "0x6003643")]
	[Address(RVA = "0xAD7ED0", Offset = "0xAD6CD0", Length = "0xAF")]
	public void HandleOnRightButtonPressed()
	{
	}

	[Token(Token = "0x6003644")]
	[Address(RVA = "0xAD7F80", Offset = "0xAD6D80", Length = "0x8D")]
	public void HandleOnBackButtonPressed()
	{
	}

	[Token(Token = "0x6003645")]
	[Address(RVA = "0xAD8010", Offset = "0xAD6E10", Length = "0xAB")]
	private void ShowNoLivesRemainingDialog()
	{
	}

	[Token(Token = "0x6003646")]
	[Address(RVA = "0xAD80C0", Offset = "0xAD6EC0", Length = "0x14F")]
	private void ShowConfirmationDialog()
	{
	}

	[Token(Token = "0x6003647")]
	[Address(RVA = "0xAD8210", Offset = "0xAD7010", Length = "0xC")]
	private void OnConfirmChoices()
	{
	}

	[Token(Token = "0x6003648")]
	[Address(RVA = "0xAD8220", Offset = "0xAD7020", Length = "0xB8")]
	private void RevivePlayer()
	{
	}

	[Token(Token = "0x6003649")]
	[Address(RVA = "0xAD82E0", Offset = "0xAD70E0", Length = "0x3AA")]
	private void ContinueToLogPanel(bool fastFadeOut)
	{
	}

	[Token(Token = "0x600364A")]
	[Address(RVA = "0xAD8690", Offset = "0xAD7490", Length = "0x682")]
	private void Update()
	{
	}

	[Token(Token = "0x600364B")]
	[Address(RVA = "0xAD8D20", Offset = "0xAD7B20", Length = "0x10F")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x600364C")]
	[Address(RVA = "0xAD8E30", Offset = "0xAD7C30", Length = "0x1EF")]
	public Panel_LifeAfterDeath()
	{
	}
}

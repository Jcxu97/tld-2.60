using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20006DC")]
public class Panel_TutorialPopup : Panel_AutoReferenced
{
	[Serializable]
	[Token(Token = "0x20006DD")]
	public class TutorialPopupRequest
	{
		[Token(Token = "0x4004937")]
		[FieldOffset(Offset = "0x10")]
		public string m_DebugPopupName;

		[Token(Token = "0x4004938")]
		[FieldOffset(Offset = "0x18")]
		public string m_MessageLocID;

		[Token(Token = "0x4004939")]
		[FieldOffset(Offset = "0x20")]
		public string m_TitleLocID;

		[Token(Token = "0x400493A")]
		[FieldOffset(Offset = "0x28")]
		public string m_ShortLocID;

		[Token(Token = "0x400493B")]
		[FieldOffset(Offset = "0x30")]
		public string m_SummaryLocID;

		[Token(Token = "0x400493C")]
		[FieldOffset(Offset = "0x38")]
		public KnowledgeCateogry m_KnowledgeCategory;

		[Token(Token = "0x400493D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject m_BackgroundPrefab;

		[Token(Token = "0x6003C79")]
		[Address(RVA = "0xB7DFE0", Offset = "0xB7CDE0", Length = "0x8")]
		public TutorialPopupRequest()
		{
		}
	}

	[Token(Token = "0x4004929")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x400492A")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_TitleLabel;

	[Token(Token = "0x400492B")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_MessageLabel;

	[Token(Token = "0x400492C")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_SummaryLabel;

	[Token(Token = "0x400492D")]
	[FieldOffset(Offset = "0x50")]
	public GameObject[] m_MouseButtons;

	[Token(Token = "0x400492E")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_PanelElements;

	[Token(Token = "0x400492F")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_BackgroundContainer;

	[Tooltip("Enable this to redirect tutorial messages to the non-blocking HUD popup instead of the fullscreen tutorial panel.")]
	[Token(Token = "0x4004930")]
	[FieldOffset(Offset = "0x68")]
	public bool m_UseHUDPopup;

	[Token(Token = "0x4004931")]
	[FieldOffset(Offset = "0x70")]
	public List<TutorialPopupRequest> m_TutorialPopups;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4004932")]
	[FieldOffset(Offset = "0x78")]
	private PanelReference<Panel_FireStart> m_FireStart;

	[SerializeField]
	[Token(Token = "0x4004933")]
	[FieldOffset(Offset = "0x80")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4004934")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_Subtitles> m_Subtitles;

	[Token(Token = "0x4004935")]
	[FieldOffset(Offset = "0x90")]
	private List<TutorialPopupRequest> m_TutorialPopupRequests;

	[Token(Token = "0x4004936")]
	[FieldOffset(Offset = "0x98")]
	private GameObject m_BackgroundPane;

	[Token(Token = "0x6003C65")]
	[Address(RVA = "0xB42190", Offset = "0xB40F90", Length = "0x89")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003C66")]
	[Address(RVA = "0xB7C190", Offset = "0xB7AF90", Length = "0x639")]
	private void Update()
	{
	}

	[Token(Token = "0x6003C67")]
	[Address(RVA = "0xB7C7D0", Offset = "0xB7B5D0", Length = "0x7")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6003C68")]
	[Address(RVA = "0xB7C7E0", Offset = "0xB7B5E0", Length = "0x2F5")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003C69")]
	[Address(RVA = "0xB7CAE0", Offset = "0xB7B8E0", Length = "0x34")]
	public override bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x6003C6A")]
	[Address(RVA = "0xB7CB20", Offset = "0xB7B920", Length = "0x1A3")]
	public void ShowPanelAndPause()
	{
	}

	[Token(Token = "0x6003C6B")]
	[Address(RVA = "0xB7CCD0", Offset = "0xB7BAD0", Length = "0x67")]
	public void ClearRequests()
	{
	}

	[Token(Token = "0x6003C6C")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[Token(Token = "0x6003C6D")]
	[Address(RVA = "0xB7CD40", Offset = "0xB7BB40", Length = "0x13F")]
	private bool CanShowTutorialPopup()
	{
		return false;
	}

	[Token(Token = "0x6003C6E")]
	[Address(RVA = "0xB7CE80", Offset = "0xB7BC80", Length = "0x64")]
	private void RemoveCurrentTutorialPopup()
	{
	}

	[Token(Token = "0x6003C6F")]
	[Address(RVA = "0xB7CEF0", Offset = "0xB7BCF0", Length = "0xA6")]
	private bool ShowNextTutorialPopup()
	{
		return false;
	}

	[Token(Token = "0x6003C70")]
	[Address(RVA = "0xB7CFA0", Offset = "0xB7BDA0", Length = "0xA4")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003C71")]
	[Address(RVA = "0xB7D050", Offset = "0xB7BE50", Length = "0x4DF")]
	private void ShowCurrentTutorialPopup()
	{
	}

	[Token(Token = "0x6003C72")]
	[Address(RVA = "0xB7D530", Offset = "0xB7C330", Length = "0xA9")]
	private void QueueTutorialPopupRequest(TutorialPopupRequest request)
	{
	}

	[Token(Token = "0x6003C73")]
	[Address(RVA = "0xB7D5E0", Offset = "0xB7C3E0", Length = "0x83")]
	private TutorialPopupRequest GetCurrentConfirmationRequest()
	{
		return null;
	}

	[Token(Token = "0x6003C74")]
	[Address(RVA = "0xB7D670", Offset = "0xB7C470", Length = "0x342")]
	private void ShowTutorialPopupRequest(TutorialPopupRequest tutorialPopupRequest)
	{
	}

	[Token(Token = "0x6003C75")]
	[Address(RVA = "0xB7D9C0", Offset = "0xB7C7C0", Length = "0x17C")]
	public void ShowTutorialPopupRequest(string name)
	{
	}

	[Token(Token = "0x6003C76")]
	[Address(RVA = "0xB7DB40", Offset = "0xB7C940", Length = "0x11E")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003C77")]
	[Address(RVA = "0xB7DC60", Offset = "0xB7CA60", Length = "0x206")]
	private void UpdateButtons()
	{
	}

	[Token(Token = "0x6003C78")]
	[Address(RVA = "0xB7DE70", Offset = "0xB7CC70", Length = "0x16F")]
	public Panel_TutorialPopup()
	{
	}
}

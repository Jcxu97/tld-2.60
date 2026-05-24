using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200061E")]
public class Panel_ChooseSandbox : Panel_AutoReferenced
{
	[Serializable]
	[Token(Token = "0x200061F")]
	public class AnimMenuItems
	{
		[Token(Token = "0x40039DD")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_Display;

		[Token(Token = "0x40039DE")]
		[FieldOffset(Offset = "0x18")]
		public SandboxConfig m_SandboxConfig;

		[Token(Token = "0x40039DF")]
		[FieldOffset(Offset = "0x20")]
		public AnimationStateRef m_PlayOnSelect;

		[Token(Token = "0x40039E0")]
		[FieldOffset(Offset = "0x28")]
		public AnimationStateRef m_PlayOnDeselect;

		[Token(Token = "0x60030A2")]
		[Address(RVA = "0x9AF7E0", Offset = "0x9AE5E0", Length = "0x109")]
		public AnimMenuItems()
		{
		}
	}

	[Token(Token = "0x2000620")]
	private enum AnimationState
	{
		[Token(Token = "0x40039E2")]
		None,
		[Token(Token = "0x40039E3")]
		Select,
		[Token(Token = "0x40039E4")]
		Deselect
	}

	[SerializeField]
	[Token(Token = "0x40039C1")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[SerializeField]
	[Token(Token = "0x40039C2")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_Loading> m_Loading;

	[SerializeField]
	[Token(Token = "0x40039C3")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_MainMenu> m_MainMenu;

	[SerializeField]
	[Token(Token = "0x40039C4")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_Sandbox> m_Sandbox;

	[SerializeField]
	[Token(Token = "0x40039C5")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_SurvivalSettings> m_SurvivalSettings;

	[Token(Token = "0x40039C6")]
	[FieldOffset(Offset = "0x58")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x40039C7")]
	[FieldOffset(Offset = "0x60")]
	public UtilsPanelChoose.DetailsObjets m_DetailObjects;

	[Header("Menu")]
	[Token(Token = "0x40039C8")]
	[FieldOffset(Offset = "0x68")]
	public LocalizedString m_Title;

	[Token(Token = "0x40039C9")]
	[FieldOffset(Offset = "0x70")]
	public LocalizedString m_TitleHeader;

	[Token(Token = "0x40039CA")]
	[FieldOffset(Offset = "0x78")]
	public Vector3 m_TitleHeaderOffset;

	[Token(Token = "0x40039CB")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_BasicMenuRoot;

	[Header("Invalid Save")]
	[Token(Token = "0x40039CC")]
	[FieldOffset(Offset = "0x90")]
	public Color m_InvalidSaveColor;

	[Token(Token = "0x40039CD")]
	[FieldOffset(Offset = "0xA0")]
	public LocalizedString m_MissingDLCString;

	[Header("Slots In Use")]
	[Token(Token = "0x40039CE")]
	[FieldOffset(Offset = "0xA8")]
	public SaveSpaceInfo m_SaveSpaceInfo;

	[Header("Mouse button")]
	[Token(Token = "0x40039CF")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_MouseButtonDelete;

	[Token(Token = "0x40039D0")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_MouseButtonRename;

	[Header("Steam Cloud")]
	[Token(Token = "0x40039D1")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel m_CloudMessageLabel;

	[Header("Animations")]
	[Token(Token = "0x40039D2")]
	[FieldOffset(Offset = "0xC8")]
	public List<AnimMenuItems> m_AnimMenuItems;

	[Token(Token = "0x40039D3")]
	[FieldOffset(Offset = "0xD0")]
	public Animator m_Animator;

	[Token(Token = "0x40039D4")]
	[FieldOffset(Offset = "0xD8")]
	private SaveSlotInfo m_SlotToRename;

	[Token(Token = "0x40039D5")]
	[FieldOffset(Offset = "0xE0")]
	private SaveSlotInfo m_SlotToDelete;

	[Token(Token = "0x40039D6")]
	[FieldOffset(Offset = "0xE8")]
	private BasicMenu m_BasicMenu;

	[Token(Token = "0x40039D7")]
	[FieldOffset(Offset = "0xF0")]
	private CloudSaveMenuExtension m_CloudSaveMenuExtension;

	[Token(Token = "0x40039D8")]
	private const int INVALID_INDEX = -1;

	[Token(Token = "0x40039D9")]
	[FieldOffset(Offset = "0xF8")]
	private int m_PreviousAnimIndex;

	[Token(Token = "0x40039DA")]
	[FieldOffset(Offset = "0xFC")]
	private int m_TargetAnimIndex;

	[Token(Token = "0x40039DB")]
	[FieldOffset(Offset = "0x100")]
	private int m_IndexToLoad;

	[Token(Token = "0x40039DC")]
	[FieldOffset(Offset = "0x104")]
	private AnimationState m_CurrentEpisodeAnimationState;

	[Token(Token = "0x6003082")]
	[Address(RVA = "0x9AC750", Offset = "0x9AB550", Length = "0x13F")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003083")]
	[Address(RVA = "0x9AC890", Offset = "0x9AB690", Length = "0x1E")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003084")]
	[Address(RVA = "0x9AC8B0", Offset = "0x9AB6B0", Length = "0x309")]
	private void ConfigureMenu()
	{
	}

	[Token(Token = "0x6003085")]
	[Address(RVA = "0x9ACBC0", Offset = "0x9AB9C0", Length = "0x736")]
	private void AddSavesOfTypeToMenu()
	{
	}

	[Token(Token = "0x6003086")]
	[Address(RVA = "0x9AD300", Offset = "0x9AC100", Length = "0x1AB")]
	private void Update()
	{
	}

	[Token(Token = "0x6003087")]
	[Address(RVA = "0x9AD4B0", Offset = "0x9AC2B0", Length = "0x159")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003088")]
	[Address(RVA = "0x9AD610", Offset = "0x9AC410", Length = "0xDC")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6003089")]
	[Address(RVA = "0x9AD6F0", Offset = "0x9AC4F0", Length = "0x56")]
	public void BackWithouSFX()
	{
	}

	[Token(Token = "0x600308A")]
	[Address(RVA = "0x9AD750", Offset = "0x9AC550", Length = "0x23F")]
	private void ProcessMenu()
	{
	}

	[Token(Token = "0x600308B")]
	[Address(RVA = "0x9AD990", Offset = "0x9AC790", Length = "0x51")]
	private SaveSlotInfo GetSaveSlotInfo(int index)
	{
		return null;
	}

	[Token(Token = "0x600308C")]
	[Address(RVA = "0x9AD9F0", Offset = "0x9AC7F0", Length = "0x70")]
	private SaveSlotInfo GetSelectedSaveSlotInfo()
	{
		return null;
	}

	[Token(Token = "0x600308D")]
	[Address(RVA = "0x9ADA70", Offset = "0x9AC870", Length = "0x28E")]
	public void OnRename()
	{
	}

	[Token(Token = "0x600308E")]
	[Address(RVA = "0x9ADD00", Offset = "0x9ACB00", Length = "0x52")]
	public void OnRenameExistingSandboxCancelled(bool wasCancelled)
	{
	}

	[Token(Token = "0x600308F")]
	[Address(RVA = "0x9ADD60", Offset = "0x9ACB60", Length = "0x1E0")]
	private void OnRenameExistingSandboxConfirmed()
	{
	}

	[Token(Token = "0x6003090")]
	[Address(RVA = "0x9ADF50", Offset = "0x9ACD50", Length = "0x1CD")]
	public void OnDelete()
	{
	}

	[Token(Token = "0x6003091")]
	[Address(RVA = "0x9AE120", Offset = "0x9ACF20", Length = "0x148")]
	private void DeleteSaveSlot()
	{
	}

	[Token(Token = "0x6003092")]
	[Address(RVA = "0x9AE270", Offset = "0x9AD070", Length = "0x52")]
	private void OnDeleteCancelled(bool wasCancelled)
	{
	}

	[Token(Token = "0x6003093")]
	[Address(RVA = "0x9AE2D0", Offset = "0x9AD0D0", Length = "0x10E")]
	private void RefreshDetails(SaveSlotInfo slotInfo)
	{
	}

	[Token(Token = "0x6003094")]
	[Address(RVA = "0x9AE3E0", Offset = "0x9AD1E0", Length = "0x2AE")]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Token(Token = "0x6003095")]
	[Address(RVA = "0x9AE690", Offset = "0x9AD490", Length = "0x27F")]
	private void OnLoadSlotClicked(int index)
	{
	}

	[Token(Token = "0x6003096")]
	[Address(RVA = "0x9A9F30", Offset = "0x9A8D30", Length = "0x13")]
	private void OnGoBackInSurvivalSettings()
	{
	}

	[Token(Token = "0x6003097")]
	[Address(RVA = "0x9AE910", Offset = "0x9AD710", Length = "0x74")]
	private void OnDoneShowingSurvivalSettings()
	{
	}

	[Token(Token = "0x6003098")]
	[Address(RVA = "0x9AE990", Offset = "0x9AD790", Length = "0xC4")]
	private void OnSlotClicked()
	{
	}

	[Token(Token = "0x6003099")]
	[Address(RVA = "0x9AEA60", Offset = "0x9AD860", Length = "0x188")]
	private void EnableSingleAnimItem(int targetIndex)
	{
	}

	[Token(Token = "0x600309A")]
	[Address(RVA = "0x9AEBF0", Offset = "0x9AD9F0", Length = "0x97")]
	private AnimMenuItems GetAnimMenuItem(int index)
	{
		return null;
	}

	[Token(Token = "0x600309B")]
	[Address(RVA = "0x9AEC90", Offset = "0x9ADA90", Length = "0x177")]
	private bool IsPlayingAnySelectionAnimation()
	{
		return false;
	}

	[Token(Token = "0x600309C")]
	[Address(RVA = "0x9AEE10", Offset = "0x9ADC10", Length = "0x177")]
	private bool IsPlayingAnyDeselectionAnimation()
	{
		return false;
	}

	[Token(Token = "0x600309D")]
	[Address(RVA = "0x9AEF90", Offset = "0x9ADD90", Length = "0x117")]
	private bool IsPlayingAnimation(int stateHash)
	{
		return false;
	}

	[Token(Token = "0x600309E")]
	[Address(RVA = "0x9AF0B0", Offset = "0x9ADEB0", Length = "0x130")]
	private void PlaySelectedAnimation(AnimMenuItems menuItem)
	{
	}

	[Token(Token = "0x600309F")]
	[Address(RVA = "0x9AF1F0", Offset = "0x9ADFF0", Length = "0x130")]
	private void PlayDeselectedAnimation(AnimMenuItems menuItem)
	{
	}

	[Token(Token = "0x60030A0")]
	[Address(RVA = "0x9AF330", Offset = "0x9AE130", Length = "0x336")]
	private void UpdateAnimation()
	{
	}

	[Token(Token = "0x60030A1")]
	[Address(RVA = "0x9AF670", Offset = "0x9AE470", Length = "0x16C")]
	public Panel_ChooseSandbox()
	{
	}
}

using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.UI;
using UnityEngine;

[Token(Token = "0x20006C3")]
public class Panel_SelectExperience : Panel_AutoReferenced
{
	[Serializable]
	[Token(Token = "0x20006C4")]
	private class XPModeMenuItem
	{
		[Token(Token = "0x4004827")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_Display;

		[Token(Token = "0x4004828")]
		[FieldOffset(Offset = "0x18")]
		public SandboxConfig m_SandboxConfig;

		[Token(Token = "0x4004829")]
		[FieldOffset(Offset = "0x20")]
		public AnimationStateRef m_PlayOnSelect;

		[Token(Token = "0x400482A")]
		[FieldOffset(Offset = "0x28")]
		public AnimationStateRef m_PlayOnDeselect;

		[Token(Token = "0x6003B64")]
		[Address(RVA = "0xB5E8C0", Offset = "0xB5D6C0", Length = "0x109")]
		public XPModeMenuItem()
		{
		}
	}

	[Token(Token = "0x20006C5")]
	private enum AnimationState
	{
		[Token(Token = "0x400482C")]
		None,
		[Token(Token = "0x400482D")]
		Select,
		[Token(Token = "0x400482E")]
		Deselect
	}

	[Token(Token = "0x400481B")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Header("Menu")]
	[Token(Token = "0x400481C")]
	[FieldOffset(Offset = "0x38")]
	public string m_HeaderTitleLocalizationId;

	[Token(Token = "0x400481D")]
	[FieldOffset(Offset = "0x40")]
	public string m_TitleLocalizationId;

	[Token(Token = "0x400481E")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 m_TitleHeaderOffset;

	[Token(Token = "0x400481F")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_BasicMenuRoot;

	[Token(Token = "0x4004820")]
	[FieldOffset(Offset = "0x60")]
	private BasicMenu m_BasicMenu;

	[Token(Token = "0x4004821")]
	[FieldOffset(Offset = "0x68")]
	public Animator m_Animator;

	[SerializeField]
	[Token(Token = "0x4004822")]
	[FieldOffset(Offset = "0x70")]
	private List<XPModeMenuItem> m_MenuItems;

	[Token(Token = "0x4004823")]
	[FieldOffset(Offset = "0x78")]
	public Color m_CustomXPLabelColor;

	[Token(Token = "0x4004824")]
	[FieldOffset(Offset = "0x88")]
	private int m_LastItemIndexSelected;

	[Token(Token = "0x4004825")]
	[FieldOffset(Offset = "0x90")]
	private XPModeMenuItem m_PreviousMenuItemSelected;

	[Token(Token = "0x4004826")]
	[FieldOffset(Offset = "0x98")]
	private AnimationState m_CurrentEpisodeAnimationState;

	[Token(Token = "0x6003B4E")]
	[Address(RVA = "0xB5C5C0", Offset = "0xB5B3C0", Length = "0x125")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003B4F")]
	[Address(RVA = "0xB5C6F0", Offset = "0xB5B4F0", Length = "0x1E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6003B50")]
	[Address(RVA = "0xB5C8E0", Offset = "0xB5B6E0", Length = "0x285")]
	public void OnExperienceClicked()
	{
	}

	[Token(Token = "0x6003B51")]
	[Address(RVA = "0xB5CB70", Offset = "0xB5B970", Length = "0x305")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[Token(Token = "0x6003B52")]
	[Address(RVA = "0xB5CE80", Offset = "0xB5BC80", Length = "0x3E8")]
	private void ConfigureMenu()
	{
	}

	[Token(Token = "0x6003B53")]
	[Address(RVA = "0xB5D270", Offset = "0xB5C070", Length = "0x1E7")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003B54")]
	[Address(RVA = "0xB5D460", Offset = "0xB5C260", Length = "0xE4")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6003B55")]
	[Address(RVA = "0xB5D550", Offset = "0xB5C350", Length = "0x20E")]
	private void ResetStartRegionAndSceneSets()
	{
	}

	[Token(Token = "0x6003B56")]
	[Address(RVA = "0xB5D760", Offset = "0xB5C560", Length = "0x1D")]
	private int GetSelectedIndex()
	{
		return 0;
	}

	[Token(Token = "0x6003B57")]
	[Address(RVA = "0xB5D780", Offset = "0xB5C580", Length = "0x94")]
	private XPModeMenuItem GetSelectedItemAtIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6003B58")]
	[Address(RVA = "0xB5D820", Offset = "0xB5C620", Length = "0xA4")]
	private XPModeMenuItem GetSelectedMenuItem()
	{
		return null;
	}

	[Token(Token = "0x6003B59")]
	[Address(RVA = "0xB5D8D0", Offset = "0xB5C6D0", Length = "0x177")]
	private bool IsPlayingAnySelectionAnimation()
	{
		return false;
	}

	[Token(Token = "0x6003B5A")]
	[Address(RVA = "0xB5DA50", Offset = "0xB5C850", Length = "0x177")]
	private bool IsPlayingAnyDeselectionAnimation()
	{
		return false;
	}

	[Token(Token = "0x6003B5B")]
	[Address(RVA = "0xB5DBD0", Offset = "0xB5C9D0", Length = "0x111")]
	private bool IsPlayingAnimation(int stateHash)
	{
		return false;
	}

	[Token(Token = "0x6003B5C")]
	[Address(RVA = "0xB5DCF0", Offset = "0xB5CAF0", Length = "0x1FA")]
	private void OnlyEnableItem(XPModeMenuItem enabledItem)
	{
	}

	[Token(Token = "0x6003B5D")]
	[Address(RVA = "0xB5DEF0", Offset = "0xB5CCF0", Length = "0x12A")]
	private void PlaySelectedAnimation(XPModeMenuItem menuItem)
	{
	}

	[Token(Token = "0x6003B5E")]
	[Address(RVA = "0xB5E020", Offset = "0xB5CE20", Length = "0x12A")]
	private void PlayDeselectedAnimation(XPModeMenuItem menuItem)
	{
	}

	[Token(Token = "0x6003B5F")]
	[Address(RVA = "0xB5E150", Offset = "0xB5CF50", Length = "0x30F")]
	private void UpdateAnimation()
	{
	}

	[Token(Token = "0x6003B60")]
	[Address(RVA = "0xB5E460", Offset = "0xB5D260", Length = "0x200")]
	private void HideAllAnimatedItems()
	{
	}

	[Token(Token = "0x6003B61")]
	[Address(RVA = "0xB5E670", Offset = "0xB5D470", Length = "0xF5")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003B62")]
	[Address(RVA = "0xB5E770", Offset = "0xB5D570", Length = "0x7C")]
	private void RestoreSelection()
	{
	}

	[Token(Token = "0x6003B63")]
	[Address(RVA = "0xB5E7F0", Offset = "0xB5D5F0", Length = "0xCD")]
	public Panel_SelectExperience()
	{
	}
}

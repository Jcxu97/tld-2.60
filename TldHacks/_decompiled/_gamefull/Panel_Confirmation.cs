using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using UnityEngine;

[Token(Token = "0x2000624")]
public class Panel_Confirmation : Panel_AutoReferenced
{
	[Token(Token = "0x2000625")]
	public delegate void CallbackDelegate();

	[Token(Token = "0x2000626")]
	public delegate void EnableDelegate(bool enable);

	[Serializable]
	[Token(Token = "0x2000627")]
	public class Group
	{
		[Token(Token = "0x4003A38")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_Parent;

		[Token(Token = "0x4003A39")]
		[FieldOffset(Offset = "0x18")]
		public ButtonLegendContainer m_ButtonLegendContainer;

		[Token(Token = "0x4003A3A")]
		[FieldOffset(Offset = "0x20")]
		public UILabel m_MessageLabel;

		[Token(Token = "0x4003A3B")]
		[FieldOffset(Offset = "0x28")]
		public UILabel m_MessageLabel_InputFieldTitle;

		[Token(Token = "0x4003A3C")]
		[FieldOffset(Offset = "0x30")]
		public UILabel m_MessageLabel_InputFieldText;

		[Token(Token = "0x4003A3D")]
		[FieldOffset(Offset = "0x38")]
		public GameObject m_2ButtonLayout;

		[Token(Token = "0x4003A3E")]
		[FieldOffset(Offset = "0x40")]
		public GameObject m_1ButtonLayout;

		[Token(Token = "0x4003A3F")]
		[FieldOffset(Offset = "0x48")]
		public UILabel m_1ButtonLayout_LabelConfirm;

		[Token(Token = "0x4003A40")]
		[FieldOffset(Offset = "0x50")]
		public UIButton m_2ButtonLayout_ButtonConfirm;

		[Token(Token = "0x4003A41")]
		[FieldOffset(Offset = "0x58")]
		public UILabel m_2ButtonLayout_LabelConfirm;

		[Token(Token = "0x4003A42")]
		[FieldOffset(Offset = "0x60")]
		public UILabel m_2ButtonLayout_LabelCancel;

		[Token(Token = "0x4003A43")]
		[FieldOffset(Offset = "0x68")]
		public GameObject m_FadeOverlayTransparent;

		[Token(Token = "0x4003A44")]
		[FieldOffset(Offset = "0x70")]
		public GameObject m_FadeOverlayOpaque;

		[Token(Token = "0x4003A45")]
		[FieldOffset(Offset = "0x78")]
		public GameObject[] m_MouseButtons;

		[Token(Token = "0x4003A46")]
		[FieldOffset(Offset = "0x80")]
		public TextInputField m_InputField;

		[Token(Token = "0x600311C")]
		[Address(RVA = "0x9BAE20", Offset = "0x9B9C20", Length = "0x7B")]
		public void Initialize(GameObject obj)
		{
		}

		[Token(Token = "0x600311D")]
		[Address(RVA = "0x9BAEA0", Offset = "0x9B9CA0", Length = "0x88")]
		public Group()
		{
		}
	}

	[Token(Token = "0x2000628")]
	public enum ConfirmationType
	{
		[Token(Token = "0x4003A48")]
		ControllerDisconnect,
		[Token(Token = "0x4003A49")]
		SaveFailed,
		[Token(Token = "0x4003A4A")]
		SaveFailedSlots,
		[Token(Token = "0x4003A4B")]
		UserSignedOut,
		[Token(Token = "0x4003A4C")]
		QuitGame,
		[Token(Token = "0x4003A4D")]
		DeleteSaveSlot,
		[Token(Token = "0x4003A4E")]
		ResetAllTimeStats,
		[Token(Token = "0x4003A4F")]
		DeleteJournal,
		[Token(Token = "0x4003A50")]
		OverwriteJournalNotification,
		[Token(Token = "0x4003A51")]
		OverwriteJournalConfirmation,
		[Token(Token = "0x4003A52")]
		Rename,
		[Token(Token = "0x4003A53")]
		QuitWithoutSavingJournal,
		[Token(Token = "0x4003A54")]
		ResetBindings,
		[Token(Token = "0x4003A55")]
		BurnResearch,
		[Token(Token = "0x4003A56")]
		OverwriteSaveConfirmation,
		[Token(Token = "0x4003A57")]
		SettingsNeedRestart,
		[Token(Token = "0x4003A58")]
		Waiting,
		[Token(Token = "0x4003A59")]
		MailingListResult,
		[Token(Token = "0x4003A5A")]
		MailingListPanel,
		[Token(Token = "0x4003A5B")]
		ErrorMessage,
		[Token(Token = "0x4003A5C")]
		CloudSyncCloudNewerConfirm,
		[Token(Token = "0x4003A5D")]
		CloudSyncLocalNewerConfirm,
		[Token(Token = "0x4003A5E")]
		CloudRetryAuthentication,
		[Token(Token = "0x4003A5F")]
		Confirm,
		[Token(Token = "0x4003A60")]
		GenericMessage,
		[Token(Token = "0x4003A61")]
		AnnotatePhoto
	}

	[Token(Token = "0x2000629")]
	public class ConfirmationRequest
	{
		[Token(Token = "0x4003A62")]
		[FieldOffset(Offset = "0x10")]
		public CallbackDelegate m_ConfirmCallback;

		[Token(Token = "0x4003A63")]
		[FieldOffset(Offset = "0x18")]
		public EnableDelegate m_EnableCallback;

		[Token(Token = "0x4003A64")]
		[FieldOffset(Offset = "0x20")]
		public ConfirmationType m_ConfirmationType;

		[Token(Token = "0x4003A65")]
		[FieldOffset(Offset = "0x28")]
		public string m_TitleLocID;

		[Token(Token = "0x4003A66")]
		[FieldOffset(Offset = "0x30")]
		public string m_MessageLocID;

		[Token(Token = "0x4003A67")]
		[FieldOffset(Offset = "0x38")]
		public ButtonLayout m_ButtonLayout;

		[Token(Token = "0x4003A68")]
		[FieldOffset(Offset = "0x3C")]
		public Background m_Background;

		[Token(Token = "0x4003A69")]
		[FieldOffset(Offset = "0x40")]
		public string m_RenameCurrentName;

		[Token(Token = "0x4003A6A")]
		[FieldOffset(Offset = "0x48")]
		public string m_ButtonPromptLocId1;

		[Token(Token = "0x4003A6B")]
		[FieldOffset(Offset = "0x50")]
		public string m_ButtonPromptLocId2;

		[Token(Token = "0x4003A6C")]
		[FieldOffset(Offset = "0x58")]
		public string m_DebugInfo;

		[Token(Token = "0x600311E")]
		[Address(RVA = "0x9BAF30", Offset = "0x9B9D30", Length = "0x17")]
		public bool IsInputType()
		{
			return false;
		}

		[Token(Token = "0x600311F")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ConfirmationRequest()
		{
		}
	}

	[Token(Token = "0x200062A")]
	public enum ButtonLayout
	{
		[Token(Token = "0x4003A6E")]
		Button_0,
		[Token(Token = "0x4003A6F")]
		Button_1,
		[Token(Token = "0x4003A70")]
		Button_2
	}

	[Token(Token = "0x200062B")]
	public enum Background
	{
		[Token(Token = "0x4003A72")]
		None,
		[Token(Token = "0x4003A73")]
		Opaque,
		[Token(Token = "0x4003A74")]
		Transperent
	}

	[Token(Token = "0x4003A33")]
	[FieldOffset(Offset = "0x30")]
	public Group m_GenericMessageGroup;

	[Token(Token = "0x4003A34")]
	[FieldOffset(Offset = "0x38")]
	public Group m_EmailSubmissionGroup;

	[Token(Token = "0x4003A35")]
	[FieldOffset(Offset = "0x40")]
	public Group m_AnnotatePhotoGroup;

	[Token(Token = "0x4003A36")]
	[FieldOffset(Offset = "0x48")]
	private Group m_CurrentGroup;

	[Token(Token = "0x4003A37")]
	[FieldOffset(Offset = "0x50")]
	private List<ConfirmationRequest> m_ConfirmationRequests;

	[Token(Token = "0x60030D6")]
	[Address(RVA = "0x9B6760", Offset = "0x9B5560", Length = "0x86")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60030D7")]
	[Address(RVA = "0x9B67F0", Offset = "0x9B55F0", Length = "0x44B")]
	private void Update()
	{
	}

	[Token(Token = "0x60030D8")]
	[Address(RVA = "0x9B6C40", Offset = "0x9B5A40", Length = "0x7")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x60030D9")]
	[Address(RVA = "0x9B6C50", Offset = "0x9B5A50", Length = "0x201")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x60030DA")]
	[Address(RVA = "0x9B6E60", Offset = "0x9B5C60", Length = "0x44")]
	public bool IsControllerDisconnectedPanel()
	{
		return false;
	}

	[Token(Token = "0x60030DB")]
	[Address(RVA = "0x9B6EB0", Offset = "0x9B5CB0", Length = "0x217")]
	public void CancelConfirmation(ConfirmationType confirmationType)
	{
	}

	[Token(Token = "0x60030DC")]
	[Address(RVA = "0x9B70D0", Offset = "0x9B5ED0", Length = "0x74")]
	public void ForceQuit()
	{
	}

	[Token(Token = "0x60030DD")]
	[Address(RVA = "0x9B7150", Offset = "0x9B5F50", Length = "0x32")]
	public string GetInputFieldText()
	{
		return null;
	}

	[Token(Token = "0x60030DE")]
	[Address(RVA = "0x9B7190", Offset = "0x9B5F90", Length = "0x2F")]
	public uint GetMaxInputLength()
	{
		return 0u;
	}

	[Token(Token = "0x60030DF")]
	[Address(RVA = "0x9B71C0", Offset = "0x9B5FC0", Length = "0x30")]
	public string GetVirtualKeyboardDescription()
	{
		return null;
	}

	[Token(Token = "0x60030E0")]
	[Address(RVA = "0x9B7200", Offset = "0x9B6000", Length = "0x25B")]
	public void SetupInputField(string virtualKeyboardDescriptionLocId, uint maxLength, bool capsLock)
	{
	}

	[Token(Token = "0x60030E1")]
	[Address(RVA = "0x9B7460", Offset = "0x9B6260", Length = "0x5E")]
	private void RemoveConfirmation(ConfirmationRequest confirmation)
	{
	}

	[Token(Token = "0x60030E2")]
	[Address(RVA = "0x9B74C0", Offset = "0x9B62C0", Length = "0xA7")]
	private bool ShowNextConfirmation(ConfirmationRequest currentConfirmation)
	{
		return false;
	}

	[Token(Token = "0x60030E3")]
	[Address(RVA = "0x9B7570", Offset = "0x9B6370", Length = "0xAC")]
	private void SetCurrentGroup(Group group)
	{
	}

	[Token(Token = "0x60030E4")]
	[Address(RVA = "0x9B7620", Offset = "0x9B6420", Length = "0x29C")]
	private bool IsControllerSchemeEnabled()
	{
		return false;
	}

	[Token(Token = "0x60030E5")]
	[Address(RVA = "0x9B78C0", Offset = "0x9B66C0", Length = "0x81")]
	private void MaybeUpdateDisconnectedGamepadConfirmButton()
	{
	}

	[Token(Token = "0x60030E6")]
	[Address(RVA = "0x9B7950", Offset = "0x9B6750", Length = "0x405")]
	private void SetActiveButtons(ConfirmationRequest confirmationRequest)
	{
	}

	[Token(Token = "0x60030E7")]
	[Address(RVA = "0x9B7D60", Offset = "0x9B6B60", Length = "0x4E9")]
	private void ShowCurrentConfirmation()
	{
	}

	[Token(Token = "0x60030E8")]
	[Address(RVA = "0x9B8250", Offset = "0x9B7050", Length = "0x201")]
	private void QueueConfirmation(ConfirmationRequest request)
	{
	}

	[Token(Token = "0x60030E9")]
	[Address(RVA = "0x9B8460", Offset = "0x9B7260", Length = "0x360")]
	private void AddConfirmation(ConfirmationType type, string messageLocID, ButtonLayout buttonLayout, Background background, CallbackDelegate confirmCallback, EnableDelegate enableCallback, string debugInfo = null)
	{
	}

	[Token(Token = "0x60030EA")]
	[Address(RVA = "0x9B87D0", Offset = "0x9B75D0", Length = "0x360")]
	private void AddConfirmation(ConfirmationType type, string titleLocID, string messageLocID, ButtonLayout buttonLayout, Background background, CallbackDelegate confirmCallback, EnableDelegate enableCallback, string debugInfo = null)
	{
	}

	[Token(Token = "0x60030EB")]
	[Address(RVA = "0x9B8B40", Offset = "0x9B7940", Length = "0x330")]
	private void AddConfirmation(ConfirmationType type, string titleLocID, string currentName, ButtonLayout buttonLayout, string buttonLocID1, string buttonLocID2, Background background, CallbackDelegate confirmCallback, EnableDelegate enableCallback, string debugInfo = null)
	{
	}

	[Token(Token = "0x60030EC")]
	[Address(RVA = "0x9B8E80", Offset = "0x9B7C80", Length = "0x330")]
	private void AddConfirmation(ConfirmationType type, string titleLocID, ButtonLayout buttonLayout, string buttonLocID1, string buttonLocID2, Background background, CallbackDelegate confirmCallback, EnableDelegate cancelCallback, string debugInfo = null)
	{
	}

	[Token(Token = "0x60030ED")]
	[Address(RVA = "0x9B91C0", Offset = "0x9B7FC0", Length = "0x340")]
	private void AddConfirmation(ConfirmationType type, string titleLocID, string messageLocID, string currentName, ButtonLayout buttonLayout, string buttonLocID1, string buttonLocID2, Background background, CallbackDelegate confirmCallback, EnableDelegate enableCallback, string debugInfo = null)
	{
	}

	[Token(Token = "0x60030EE")]
	[Address(RVA = "0x9B9510", Offset = "0x9B8310", Length = "0x350")]
	private void AddConfirmation(ConfirmationType type, string messageLocID, ButtonLayout buttonLayout, Background background, EnableDelegate enableCallback, string debugInfo = null)
	{
	}

	[Token(Token = "0x60030EF")]
	[Address(RVA = "0x9B9870", Offset = "0x9B8670", Length = "0x80")]
	private ConfirmationRequest GetCurrentConfirmationRequest()
	{
		return null;
	}

	[Token(Token = "0x60030F0")]
	[Address(RVA = "0x9B9900", Offset = "0x9B8700", Length = "0x36")]
	public void ShowErrorMessage(string text, CallbackDelegate confirmCallback = null)
	{
	}

	[Token(Token = "0x60030F1")]
	[Address(RVA = "0x9B9940", Offset = "0x9B8740", Length = "0x6F")]
	public void ShowControllerDisconnectedPanel(CallbackDelegate confirmCallback)
	{
	}

	[Token(Token = "0x60030F2")]
	[Address(RVA = "0x9B99B0", Offset = "0x9B87B0", Length = "0x70")]
	public void ShowSignoutConfirmationPanel(CallbackDelegate confirmCallback)
	{
	}

	[Token(Token = "0x60030F3")]
	[Address(RVA = "0x9B9A20", Offset = "0x9B8820", Length = "0x7D")]
	public void ShowQuitConfirmationPanel(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[Token(Token = "0x60030F4")]
	[Address(RVA = "0x9B9AA0", Offset = "0x9B88A0", Length = "0xBA")]
	public void ShowDeleteConfirmationPanel(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[Token(Token = "0x60030F5")]
	[Address(RVA = "0x9B9B60", Offset = "0x9B8960", Length = "0x7D")]
	public void ShowResetAllTimeStatsConfirmationPanel(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[Token(Token = "0x60030F6")]
	[Address(RVA = "0x9B9BE0", Offset = "0x9B89E0", Length = "0x7D")]
	public void ShowDeleteJounalPanel(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[Token(Token = "0x60030F7")]
	[Address(RVA = "0x9B9C60", Offset = "0x9B8A60", Length = "0x7D")]
	public void ShowOverwriteJournalPanelConfirmation(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[Token(Token = "0x60030F8")]
	[Address(RVA = "0x9B9CE0", Offset = "0x9B8AE0", Length = "0x7D")]
	public void ShowOverwriteSaveConfirmation(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[Token(Token = "0x60030F9")]
	[Address(RVA = "0x9B9D60", Offset = "0x9B8B60", Length = "0x7D")]
	public void ShowOverwriteJournalPanelNotification(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[Token(Token = "0x60030FA")]
	[Address(RVA = "0x9B9DE0", Offset = "0x9B8BE0", Length = "0x87")]
	public void ShowRenamePanel(string locID, string currentName, string buttonPromptLocId1, string buttonPromptLocId2, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[Token(Token = "0x60030FB")]
	[Address(RVA = "0x9B9E70", Offset = "0x9B8C70", Length = "0x53")]
	public void ShowConfirmPanel(string locID, string buttonPromptLocId1, string buttonPromptLocId2, CallbackDelegate confirmCallback, EnableDelegate cancelCallback)
	{
	}

	[Token(Token = "0x60030FC")]
	[Address(RVA = "0x9B9ED0", Offset = "0x9B8CD0", Length = "0x6A")]
	public void ShowMailingListPanel(string titleLocID, string messageLocID, string currentName, string buttonPromptLocId1, string buttonPromptLocId2, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[Token(Token = "0x60030FD")]
	[Address(RVA = "0x9B9F40", Offset = "0x9B8D40", Length = "0x3D")]
	public void ShowMailingListResultPanel(string titleLocID, string messageLocID)
	{
	}

	[Token(Token = "0x60030FE")]
	[Address(RVA = "0x9B9F80", Offset = "0x9B8D80", Length = "0x7D")]
	public void ShowQuitWithoutSavingJournalNotification(CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[Token(Token = "0x60030FF")]
	[Address(RVA = "0x9BA000", Offset = "0x9B8E00", Length = "0x70")]
	public void ShowResetBindingsNotification(CallbackDelegate confirmCallback)
	{
	}

	[Token(Token = "0x6003100")]
	[Address(RVA = "0x9BA070", Offset = "0x9B8E70", Length = "0x70")]
	public void ShowBurnResearchNotification(CallbackDelegate confirmCallback)
	{
	}

	[Token(Token = "0x6003101")]
	[Address(RVA = "0x9BA0E0", Offset = "0x9B8EE0", Length = "0x70")]
	public void ShowEatRawMeatRadialNotification(CallbackDelegate confirmCallback)
	{
	}

	[Token(Token = "0x6003102")]
	[Address(RVA = "0x9BA150", Offset = "0x9B8F50", Length = "0x7F")]
	public void ShowSaveGameFailedSaveNotification(CallbackDelegate confirmCallback, string debugInfo = null)
	{
	}

	[Token(Token = "0x6003103")]
	[Address(RVA = "0x9BA1D0", Offset = "0x9B8FD0", Length = "0x72")]
	public void ShowProfileFailedSaveNotification(CallbackDelegate confirmCallback)
	{
	}

	[Token(Token = "0x6003104")]
	[Address(RVA = "0x9BA250", Offset = "0x9B9050", Length = "0x72")]
	public void ShowSaveGameFaileLoadNotification(CallbackDelegate confirmCallback)
	{
	}

	[Token(Token = "0x6003105")]
	[Address(RVA = "0x9BA2D0", Offset = "0x9B90D0", Length = "0x72")]
	public void ShowProfileFailedLoadNotification(CallbackDelegate confirmCallback)
	{
	}

	[Token(Token = "0x6003106")]
	[Address(RVA = "0x9BA350", Offset = "0x9B9150", Length = "0x72")]
	public void ShowSaveDeleteFailedNotification(CallbackDelegate confirmCallback)
	{
	}

	[Token(Token = "0x6003107")]
	[Address(RVA = "0x9BA3D0", Offset = "0x9B91D0", Length = "0x72")]
	public void ShowNotEnoughSaveSlotsAvailableNotification(CallbackDelegate confirmCallback)
	{
	}

	[Token(Token = "0x6003108")]
	[Address(RVA = "0x9BA450", Offset = "0x9B9250", Length = "0x70")]
	public void ShowSettingsNeedRestartPanel(CallbackDelegate confirmCallback)
	{
	}

	[Token(Token = "0x6003109")]
	[Address(RVA = "0x9BA4C0", Offset = "0x9B92C0", Length = "0x30")]
	public void ShowWaitingPanel(string text)
	{
	}

	[Token(Token = "0x600310A")]
	[Address(RVA = "0x9BA4F0", Offset = "0x9B92F0", Length = "0x36")]
	public void ShowGenericMessage(string locID, CallbackDelegate confirmCallback = null)
	{
	}

	[Token(Token = "0x600310B")]
	[Address(RVA = "0x9BA530", Offset = "0x9B9330", Length = "0xF4")]
	public void ShowCloudRetryAuthenticationConfirmationPanel(CallbackDelegate confirmCallback, EnableDelegate cancelCallback)
	{
	}

	[Token(Token = "0x600310C")]
	[Address(RVA = "0x9BA630", Offset = "0x9B9430", Length = "0xF4")]
	public void ShowCloudSyncCloudNewerConfirm(CallbackDelegate confirmCallback, EnableDelegate cancelCallback)
	{
	}

	[Token(Token = "0x600310D")]
	[Address(RVA = "0x9BA730", Offset = "0x9B9530", Length = "0xF4")]
	public void ShowCloudSyncLocalNewer(CallbackDelegate confirmCallback, EnableDelegate cancelCallback)
	{
	}

	[Token(Token = "0x600310E")]
	[Address(RVA = "0x9BA830", Offset = "0x9B9630", Length = "0x87")]
	public void ShowAnnotatePhotoPanel(string locID, string currentAnnotation, string buttonPromptLocId1, string buttonPromptLocId2, CallbackDelegate confirmCallback, EnableDelegate enableCallback)
	{
	}

	[Token(Token = "0x600310F")]
	[Address(RVA = "0x9BA8C0", Offset = "0x9B96C0", Length = "0xD0")]
	public void OnConfirm()
	{
	}

	[Token(Token = "0x6003110")]
	[Address(RVA = "0x9BA990", Offset = "0x9B9790", Length = "0xD2")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003111")]
	[Address(RVA = "0x9BAA70", Offset = "0x9B9870", Length = "0x250")]
	private void UpdateButtons()
	{
	}

	[Token(Token = "0x6003112")]
	[Address(RVA = "0x9BACD0", Offset = "0x9B9AD0", Length = "0x53")]
	private bool IsConfirmationEnabled(ConfirmationType confirmationType)
	{
		return false;
	}

	[Token(Token = "0x6003113")]
	[Address(RVA = "0x9BAD30", Offset = "0x9B9B30", Length = "0xE3")]
	public Panel_Confirmation()
	{
	}
}

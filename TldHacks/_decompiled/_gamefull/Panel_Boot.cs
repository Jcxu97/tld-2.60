using Cpp2ILInjected;
using TLD.OptionalContent;
using UnityEngine;

[Token(Token = "0x2000614")]
public class Panel_Boot : Panel_Base
{
	[Header("General")]
	[SerializeField]
	[Token(Token = "0x40038FE")]
	[FieldOffset(Offset = "0x28")]
	private ButtonLegendContainer m_ButtonLegendContainer;

	[Header("Flows")]
	[SerializeField]
	[Token(Token = "0x40038FF")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_BootFlow;

	[SerializeField]
	[Token(Token = "0x4003900")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_LoadingFlow;

	[SerializeField]
	[Token(Token = "0x4003901")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_ErrorFlow;

	[Header("Main Disclaimer")]
	[SerializeField]
	[Token(Token = "0x4003902")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_MainDisclaimer;

	[SerializeField]
	[Token(Token = "0x4003903")]
	[FieldOffset(Offset = "0x50")]
	private UILabel m_MainDisclaimerContinue;

	[SerializeField]
	[Token(Token = "0x4003904")]
	[FieldOffset(Offset = "0x58")]
	private LocalizedString m_LoadingText;

	[Header("Secondary Disclaimers")]
	[Tooltip("List of disclaimer screens to show before the main disclaimer screen that waits for user input")]
	[SerializeField]
	[Token(Token = "0x4003905")]
	[FieldOffset(Offset = "0x60")]
	private GameObject[] m_DisclaimerScreenList;

	[SerializeField]
	[Token(Token = "0x4003906")]
	[FieldOffset(Offset = "0x68")]
	private UILabel[] m_DisclaimerScreenContinues;

	[Header("Error")]
	[SerializeField]
	[Token(Token = "0x4003907")]
	[FieldOffset(Offset = "0x70")]
	private string m_SupportUrl;

	[SerializeField]
	[Token(Token = "0x4003908")]
	[FieldOffset(Offset = "0x78")]
	private UILabel m_ErrorLabel;

	[SerializeField]
	[Token(Token = "0x4003909")]
	[FieldOffset(Offset = "0x80")]
	private LocalizedString m_ErrorText;

	[SerializeField]
	[Token(Token = "0x400390A")]
	[FieldOffset(Offset = "0x88")]
	private GameObject m_QuitAndContactSupportParent;

	[SerializeField]
	[Token(Token = "0x400390B")]
	[FieldOffset(Offset = "0x90")]
	private GameObject m_OnlyContactSupportParent;

	[Header("Loading")]
	[SerializeField]
	[Token(Token = "0x400390C")]
	[FieldOffset(Offset = "0x98")]
	private GameObject m_LoadingAnimationsRoot;

	[SerializeField]
	[Token(Token = "0x400390D")]
	[FieldOffset(Offset = "0xA0")]
	private UILabel m_LoadingContinue;

	[Token(Token = "0x400390F")]
	[FieldOffset(Offset = "0xAC")]
	private OptionalContentProviderResult m_ErrorResult;

	[Token(Token = "0x4003910")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_StartShowingDisclaimers;

	[Token(Token = "0x4003911")]
	[FieldOffset(Offset = "0xB4")]
	private int m_DisclaimerScreenIndex;

	[Token(Token = "0x4003912")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_HoldLoadingUntilInputGiven;

	[Token(Token = "0x4003913")]
	[FieldOffset(Offset = "0xB9")]
	private bool m_SceneLoaded;

	[Token(Token = "0x4003914")]
	[FieldOffset(Offset = "0xC0")]
	private GamepadButtonSprite[] m_GamepadButtonSprites;

	[Token(Token = "0x170002E2")]
	[field: Token(Token = "0x400390E")]
	[field: FieldOffset(Offset = "0xA8")]
	public bool ReadyToActivateScene
	{
		[Token(Token = "0x6002FF3")]
		[Address(RVA = "0x835870", Offset = "0x834670", Length = "0x8")]
		get;
		[Token(Token = "0x6002FF4")]
		[Address(RVA = "0x99BB70", Offset = "0x99A970", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x6002FF5")]
	[Address(RVA = "0x99BB80", Offset = "0x99A980", Length = "0xF1")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6002FF6")]
	[Address(RVA = "0x99BC80", Offset = "0x99AA80", Length = "0x2E8")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6002FF7")]
	[Address(RVA = "0x99BF70", Offset = "0x99AD70", Length = "0x8")]
	private void ShowBootDislaimers()
	{
	}

	[Token(Token = "0x6002FF8")]
	[Address(RVA = "0x99BF80", Offset = "0x99AD80", Length = "0x21D")]
	public void OnNextDisclaimerScreen()
	{
	}

	[Token(Token = "0x6002FF9")]
	[Address(RVA = "0x99C1A0", Offset = "0x99AFA0", Length = "0x20")]
	private void ShowMainDisclaimer()
	{
	}

	[Token(Token = "0x6002FFA")]
	[Address(RVA = "0x99C1D0", Offset = "0x99AFD0", Length = "0x4F")]
	private void ShowBootLoading()
	{
	}

	[Token(Token = "0x6002FFB")]
	[Address(RVA = "0x99C220", Offset = "0x99B020", Length = "0x244")]
	private void ShowRandomLoadingAnimation()
	{
	}

	[Token(Token = "0x6002FFC")]
	[Address(RVA = "0x810C30", Offset = "0x80FA30", Length = "0x7")]
	public void SetErrorResult(OptionalContentProviderResult errorResult)
	{
	}

	[Token(Token = "0x6002FFD")]
	[Address(RVA = "0x99C470", Offset = "0x99B270", Length = "0x1D2")]
	private void ShowErrorResult()
	{
	}

	[Token(Token = "0x6002FFE")]
	[Address(RVA = "0x99C650", Offset = "0x99B450", Length = "0x8")]
	public void NotifyDoneLoading()
	{
	}

	[Token(Token = "0x6002FFF")]
	[Address(RVA = "0x99C660", Offset = "0x99B460", Length = "0x63E")]
	private void Update()
	{
	}

	[Token(Token = "0x6003000")]
	[Address(RVA = "0x99CCA0", Offset = "0x99BAA0", Length = "0x52")]
	public void OnContactSupport()
	{
	}

	[Token(Token = "0x6003001")]
	[Address(RVA = "0x99CD00", Offset = "0x99BB00", Length = "0x45")]
	public void OnQuitGame()
	{
	}

	[Token(Token = "0x6003002")]
	[Address(RVA = "0x99CD50", Offset = "0x99BB50", Length = "0x4D")]
	public Panel_Boot()
	{
	}
}

using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.OptionalContent;
using TLD.UI;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x20006D9")]
public class Panel_SurvivalSettings : Panel_AutoReferenced
{
	[Serializable]
	[Token(Token = "0x20006DA")]
	private class SurvivalSetting
	{
		[Token(Token = "0x4004911")]
		[FieldOffset(Offset = "0x10")]
		public AssetReferenceTexture2D m_FeatureTexture;

		[Token(Token = "0x4004912")]
		[FieldOffset(Offset = "0x18")]
		public LocalizedString m_FeatureTitle;

		[Token(Token = "0x4004913")]
		[FieldOffset(Offset = "0x20")]
		public LocalizedString m_FeatureDescription;

		[NonSerialized]
		[Token(Token = "0x4004914")]
		[FieldOffset(Offset = "0x28")]
		public bool m_Toggled;

		[NonSerialized]
		[Token(Token = "0x4004915")]
		[FieldOffset(Offset = "0x30")]
		public AsyncOperationHandle<Texture2D> m_TextureHandle;

		[Token(Token = "0x6003C52")]
		[Address(RVA = "0xB798B0", Offset = "0xB786B0", Length = "0x111")]
		public void LoadTextureIfNeeded()
		{
		}

		[Token(Token = "0x6003C53")]
		[Address(RVA = "0xB799D0", Offset = "0xB787D0", Length = "0x49")]
		public Texture2D GetTexture()
		{
			return null;
		}

		[Token(Token = "0x6003C54")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SurvivalSetting()
		{
		}
	}

	[Token(Token = "0x40048F5")]
	private const int SCURVY_CHANGELIST = 148300;

	[Token(Token = "0x40048F6")]
	private const int COUGAR_CHANGELIST = 148869;

	[Token(Token = "0x40048F7")]
	private const int TRADER_CHANGELIST = 143892;

	[SerializeField]
	[Token(Token = "0x40048F8")]
	[FieldOffset(Offset = "0x30")]
	private ButtonLegendContainer m_ButtonLegendContainer;

	[Header("Elements")]
	[SerializeField]
	[Token(Token = "0x40048F9")]
	[FieldOffset(Offset = "0x38")]
	private UITexture m_FeatureTexture;

	[SerializeField]
	[Token(Token = "0x40048FA")]
	[FieldOffset(Offset = "0x40")]
	private UILabel m_FeatureTitleText;

	[SerializeField]
	[Token(Token = "0x40048FB")]
	[FieldOffset(Offset = "0x48")]
	private UILabel m_FeatureDescriptionText;

	[SerializeField]
	[Token(Token = "0x40048FC")]
	[FieldOffset(Offset = "0x50")]
	private UIButton m_PreviousButton;

	[SerializeField]
	[Token(Token = "0x40048FD")]
	[FieldOffset(Offset = "0x58")]
	private UIButton m_NextButton;

	[SerializeField]
	[Token(Token = "0x40048FE")]
	[FieldOffset(Offset = "0x60")]
	private ToggleButton m_ToggleButton;

	[SerializeField]
	[Token(Token = "0x40048FF")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_EnabledText;

	[SerializeField]
	[Token(Token = "0x4004900")]
	[FieldOffset(Offset = "0x70")]
	private GameObject m_DisabledText;

	[Header("Tweens")]
	[SerializeField]
	[Token(Token = "0x4004901")]
	[FieldOffset(Offset = "0x78")]
	private TweenAlpha m_TextureFadeOutTween;

	[SerializeField]
	[Token(Token = "0x4004902")]
	[FieldOffset(Offset = "0x80")]
	private TweenAlpha m_TextureFadeInTween;

	[Header("Settings")]
	[SerializeField]
	[Token(Token = "0x4004903")]
	[FieldOffset(Offset = "0x88")]
	private SurvivalSetting m_Cougar;

	[SerializeField]
	[Token(Token = "0x4004904")]
	[FieldOffset(Offset = "0x90")]
	private SurvivalSetting m_Scurvy;

	[SerializeField]
	[Token(Token = "0x4004905")]
	[FieldOffset(Offset = "0x98")]
	private SurvivalSetting m_Trader;

	[Header("Scurvy")]
	[SerializeField]
	[Token(Token = "0x4004906")]
	[FieldOffset(Offset = "0xA0")]
	private AssetReferenceNutrientDefinition m_VitaminCReference;

	[Header("DLC References")]
	[SerializeField]
	[Token(Token = "0x4004907")]
	[FieldOffset(Offset = "0xA8")]
	private OptionalContentConfig m_ExpansionPassConfig;

	[Token(Token = "0x4004908")]
	[FieldOffset(Offset = "0xB0")]
	private Action m_OnGoBack;

	[Token(Token = "0x4004909")]
	[FieldOffset(Offset = "0xB8")]
	private Action m_OnContinue;

	[Token(Token = "0x400490A")]
	[FieldOffset(Offset = "0xC0")]
	private readonly List<SurvivalSetting> m_ActiveSurvivalSettings;

	[Token(Token = "0x400490B")]
	[FieldOffset(Offset = "0xC8")]
	private readonly List<GamepadButtonSprite> m_GamepadButtonSprites;

	[Token(Token = "0x400490C")]
	[FieldOffset(Offset = "0xD0")]
	private int m_SelectedIndex;

	[Token(Token = "0x400490D")]
	[FieldOffset(Offset = "0xD8")]
	private GameModeConfig m_CurrentGameModeConfig;

	[Token(Token = "0x400490E")]
	[FieldOffset(Offset = "0xE0")]
	private int m_CurrentChangelist;

	[Token(Token = "0x400490F")]
	[FieldOffset(Offset = "0xE8")]
	private List<string> m_CurrentInstalledOptionalContent;

	[Token(Token = "0x4004910")]
	[FieldOffset(Offset = "0xF0")]
	private AsyncOperationHandle<NutrientDefinition> m_VitaminCHandle;

	[Token(Token = "0x1700030E")]
	private SurvivalSetting SelectedSurvivalSetting
	{
		[Token(Token = "0x6003C3E")]
		[Address(RVA = "0xB77250", Offset = "0xB76050", Length = "0x6E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003C3F")]
	[Address(RVA = "0xB772C0", Offset = "0xB760C0", Length = "0x27B")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003C40")]
	[Address(RVA = "0xB77540", Offset = "0xB76340", Length = "0x306")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003C41")]
	[Address(RVA = "0xB77850", Offset = "0xB76650", Length = "0x5BA")]
	public bool PrepareToShowSurvivalSettings(GameModeConfig gameModeConfig, int saveChangelist = 0, List<string> installedOptionalContent = null)
	{
		return false;
	}

	[Token(Token = "0x6003C42")]
	[Address(RVA = "0xB77E10", Offset = "0xB76C10", Length = "0x14E")]
	public void ShowSurvivalSettings(Action onGoBack, Action onContinue)
	{
	}

	[Token(Token = "0x6003C43")]
	[Address(RVA = "0xB77F60", Offset = "0xB76D60", Length = "0xD2")]
	private void AddSurvivalSettingIfValid(SurvivalSetting survivalSetting, Func<bool> shouldShowFunction)
	{
	}

	[Token(Token = "0x6003C44")]
	[Address(RVA = "0xB78040", Offset = "0xB76E40", Length = "0x246")]
	private bool ShouldShowCougar()
	{
		return false;
	}

	[Token(Token = "0x6003C45")]
	[Address(RVA = "0xB78290", Offset = "0xB77090", Length = "0x23B")]
	private bool ShouldShowScurvy()
	{
		return false;
	}

	[Token(Token = "0x6003C46")]
	[Address(RVA = "0xB784D0", Offset = "0xB772D0", Length = "0x118")]
	private bool ShouldShowTrader()
	{
		return false;
	}

	[Token(Token = "0x6003C47")]
	[Address(RVA = "0xB785F0", Offset = "0xB773F0", Length = "0x209")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003C48")]
	[Address(RVA = "0xB78800", Offset = "0xB77600", Length = "0x4FD")]
	private void Update()
	{
	}

	[Token(Token = "0x6003C49")]
	[Address(RVA = "0xB78D00", Offset = "0xB77B00", Length = "0xBA")]
	private void HandleFadeOutFinished()
	{
	}

	[Token(Token = "0x6003C4A")]
	[Address(RVA = "0xB78DC0", Offset = "0xB77BC0", Length = "0x96")]
	public void GoToNextIndex()
	{
	}

	[Token(Token = "0x6003C4B")]
	[Address(RVA = "0xB78E60", Offset = "0xB77C60", Length = "0x70")]
	public void GoToPreviousIndex()
	{
	}

	[Token(Token = "0x6003C4C")]
	[Address(RVA = "0xB78ED0", Offset = "0xB77CD0", Length = "0x311")]
	private void UpdateIndex(int newIndex, bool instant = false)
	{
	}

	[Token(Token = "0x6003C4D")]
	[Address(RVA = "0xB791F0", Offset = "0xB77FF0", Length = "0x89")]
	private void OnFeatureToggle()
	{
	}

	[Token(Token = "0x6003C4E")]
	[Address(RVA = "0xB79280", Offset = "0xB78080", Length = "0xF5")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003C4F")]
	[Address(RVA = "0xB79380", Offset = "0xB78180", Length = "0x7E")]
	public void HandleOnClickBack()
	{
	}

	[Token(Token = "0x6003C50")]
	[Address(RVA = "0xB79400", Offset = "0xB78200", Length = "0x2A9")]
	public void HandleOnClickContinue()
	{
	}

	[Token(Token = "0x6003C51")]
	[Address(RVA = "0xB796B0", Offset = "0xB784B0", Length = "0x1FF")]
	public Panel_SurvivalSettings()
	{
	}
}

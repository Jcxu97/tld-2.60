using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200027E")]
public class StatusBar : MonoBehaviour
{
	[Token(Token = "0x200027F")]
	protected struct FillValues
	{
		[Token(Token = "0x40016E1")]
		[FieldOffset(Offset = "0x0")]
		public float m_NormalizedValue;

		[Token(Token = "0x40016E2")]
		[FieldOffset(Offset = "0x4")]
		public float m_Fill;

		[Token(Token = "0x40016E3")]
		[FieldOffset(Offset = "0x8")]
		public float m_ModifierFill;

		[Token(Token = "0x40016E4")]
		[FieldOffset(Offset = "0xC")]
		public float m_CheatDeathFill;
	}

	[Token(Token = "0x2000280")]
	public enum StatusBarType
	{
		[Token(Token = "0x40016E6")]
		Cold,
		[Token(Token = "0x40016E7")]
		Hunger,
		[Token(Token = "0x40016E8")]
		Thirst,
		[Token(Token = "0x40016E9")]
		Fatigue,
		[Token(Token = "0x40016EA")]
		Condition
	}

	[Header("SET COLORS ON SCRIPT_EngineSystems - InterfaceManager\n")]
	[Token(Token = "0x40016BE")]
	[FieldOffset(Offset = "0x20")]
	public StatusBarType m_StatusBarType;

	[Token(Token = "0x40016BF")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_HierarchyRoot;

	[Token(Token = "0x40016C0")]
	[FieldOffset(Offset = "0x30")]
	public GameObject[] m_UpArrows;

	[Token(Token = "0x40016C1")]
	[FieldOffset(Offset = "0x38")]
	public GameObject[] m_DownArrows;

	[Tooltip("A rate of change above this value will be considered medium")]
	[Token(Token = "0x40016C2")]
	[FieldOffset(Offset = "0x40")]
	public float m_MediumThreshold;

	[Tooltip("A rate of change above this value will be considered high")]
	[Token(Token = "0x40016C3")]
	[FieldOffset(Offset = "0x44")]
	public float m_HighThreshold;

	[Token(Token = "0x40016C4")]
	[FieldOffset(Offset = "0x48")]
	public UISprite m_OuterBoxSprite;

	[Range(0f, 1f)]
	[Token(Token = "0x40016C5")]
	[FieldOffset(Offset = "0x50")]
	public float m_AlphaWhenHUDFadedOut;

	[Tooltip("If HUD status bar fill level is above this value, it will fade out")]
	[Range(0f, 1f)]
	[Token(Token = "0x40016C6")]
	[FieldOffset(Offset = "0x54")]
	public float m_ThresholdHUDFadeOut;

	[Tooltip("If status bar fill level is below this value, it will change color")]
	[Range(0f, 1f)]
	[Token(Token = "0x40016C7")]
	[FieldOffset(Offset = "0x58")]
	public float m_ThresholdCritical;

	[Token(Token = "0x40016C8")]
	[FieldOffset(Offset = "0x60")]
	public UISprite m_FillSprite;

	[Token(Token = "0x40016C9")]
	[FieldOffset(Offset = "0x68")]
	public UISprite m_DebuffFillSprite;

	[Token(Token = "0x40016CA")]
	[FieldOffset(Offset = "0x70")]
	public UISprite m_BuffFillSprite;

	[Token(Token = "0x40016CB")]
	[FieldOffset(Offset = "0x78")]
	public UISprite m_CheatDeathDebuffFillSprite;

	[Token(Token = "0x40016CC")]
	[FieldOffset(Offset = "0x80")]
	public UISprite m_SpriteWhenEmpty;

	[Token(Token = "0x40016CD")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_BuffObject;

	[Token(Token = "0x40016CE")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_DebuffObject;

	[Tooltip("Fill Sprite modifier value for sprites with a lot of empty space. For example, setting this to 0.2 will make a fill sprite go from 0.2 to 0.8 instead of 0 to 1")]
	[Token(Token = "0x40016CF")]
	[FieldOffset(Offset = "0x98")]
	public float m_FillSpriteOffset;

	[Token(Token = "0x40016D0")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_BacksplashDepleted;

	[Token(Token = "0x40016D1")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_BacksplashCritical;

	[Token(Token = "0x40016D2")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_BacksplashDebuff;

	[Token(Token = "0x40016D3")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_BacksplashBuff;

	[Token(Token = "0x40016D4")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject m_BacksplashNormal;

	[Token(Token = "0x40016D5")]
	[FieldOffset(Offset = "0xC8")]
	public bool m_IsOnHUD;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40016D6")]
	[FieldOffset(Offset = "0xD0")]
	private PanelReference<Panel_Actions> m_Actions;

	[SerializeField]
	[Token(Token = "0x40016D7")]
	[FieldOffset(Offset = "0xD8")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[SerializeField]
	[Token(Token = "0x40016D8")]
	[FieldOffset(Offset = "0xE0")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x40016D9")]
	[FieldOffset(Offset = "0xE8")]
	private bool[] m_UpArrowsEnabled;

	[Token(Token = "0x40016DA")]
	[FieldOffset(Offset = "0xF0")]
	private bool[] m_DownArrowsEnabled;

	[Token(Token = "0x40016DB")]
	[FieldOffset(Offset = "0xF8")]
	private bool m_ForceShow;

	[Token(Token = "0x40016DC")]
	[FieldOffset(Offset = "0xFC")]
	private float m_ForceShowStartTime;

	[Token(Token = "0x40016DD")]
	[FieldOffset(Offset = "0x100")]
	private float m_ForceShowSecondsToFadeIn;

	[Token(Token = "0x40016DE")]
	[FieldOffset(Offset = "0x104")]
	private float m_ForceShowSecondsToShow;

	[Token(Token = "0x40016DF")]
	[FieldOffset(Offset = "0x108")]
	private float m_ForceShowSecondsToFadeOut;

	[Token(Token = "0x40016E0")]
	[FieldOffset(Offset = "0x110")]
	private TweenAlpha m_TweenAlpha;

	[Token(Token = "0x60015BA")]
	[Address(RVA = "0x6A7BA0", Offset = "0x6A69A0", Length = "0x591")]
	private void Awake()
	{
	}

	[Token(Token = "0x60015BB")]
	[Address(RVA = "0x6A8140", Offset = "0x6A6F40", Length = "0x108")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60015BC")]
	[Address(RVA = "0x6A8250", Offset = "0x6A7050", Length = "0xF0F")]
	public void Update()
	{
	}

	[Token(Token = "0x60015BD")]
	[Address(RVA = "0x6A9160", Offset = "0x6A7F60", Length = "0x6D")]
	public int GetNumFreezingEffectArrows()
	{
		return 0;
	}

	[Token(Token = "0x60015BE")]
	[Address(RVA = "0x6A91D0", Offset = "0x6A7FD0", Length = "0x9D")]
	public void ForceShowForSeconds(float secondsToFadeIn, float secondsToShow, float secondsToFadeOut)
	{
	}

	[Token(Token = "0x60015BF")]
	[Address(RVA = "0x6A9270", Offset = "0x6A8070", Length = "0x8")]
	public void MarkAsChildOfHUD()
	{
	}

	[Token(Token = "0x60015C0")]
	[Address(RVA = "0x6A9280", Offset = "0x6A8080", Length = "0x393")]
	private void SetSpriteColors(float fillValue)
	{
	}

	[Token(Token = "0x60015C1")]
	[Address(RVA = "0x6A9620", Offset = "0x6A8420", Length = "0x527")]
	protected virtual bool ShouldBeHidden()
	{
		return false;
	}

	[Token(Token = "0x60015C2")]
	[Address(RVA = "0x6A9B50", Offset = "0x6A8950", Length = "0x216")]
	private void SetArrowBools(float rateOfChange)
	{
	}

	[Token(Token = "0x60015C3")]
	[Address(RVA = "0x6A9D70", Offset = "0x6A8B70", Length = "0x28C")]
	private void SetArrowActiveStates()
	{
	}

	[Token(Token = "0x60015C4")]
	[Address(RVA = "0x6AA000", Offset = "0x6A8E00", Length = "0x12E")]
	private void ToggleAll(GameObject[] objects, bool toggleVal)
	{
	}

	[Token(Token = "0x60015C5")]
	[Address(RVA = "0x6AA130", Offset = "0x6A8F30", Length = "0xAF")]
	private FillValues GetFillValues()
	{
		return default(FillValues);
	}

	[Token(Token = "0x60015C6")]
	[Address(RVA = "0x6AA1E0", Offset = "0x6A8FE0", Length = "0xAD")]
	protected virtual FillValues GetFillValuesThirst()
	{
		return default(FillValues);
	}

	[Token(Token = "0x60015C7")]
	[Address(RVA = "0x6AA290", Offset = "0x6A9090", Length = "0x143")]
	protected virtual FillValues GetFillValuesHunger()
	{
		return default(FillValues);
	}

	[Token(Token = "0x60015C8")]
	[Address(RVA = "0x6AA3E0", Offset = "0x6A91E0", Length = "0xAD")]
	protected virtual FillValues GetFillValuesCold()
	{
		return default(FillValues);
	}

	[Token(Token = "0x60015C9")]
	[Address(RVA = "0x6AA490", Offset = "0x6A9290", Length = "0x11C")]
	protected virtual FillValues GetFillValuesFatigue()
	{
		return default(FillValues);
	}

	[Token(Token = "0x60015CA")]
	[Address(RVA = "0x6AA5B0", Offset = "0x6A93B0", Length = "0x145")]
	protected virtual FillValues GetFillValuesCondition()
	{
		return default(FillValues);
	}

	[Token(Token = "0x60015CB")]
	[Address(RVA = "0x6AA700", Offset = "0x6A9500", Length = "0x6A")]
	private float GetRateOfChange()
	{
		return 0f;
	}

	[Token(Token = "0x60015CC")]
	[Address(RVA = "0x6AA770", Offset = "0x6A9570", Length = "0x2A0")]
	protected virtual float GetRateOfChangeThirst()
	{
		return 0f;
	}

	[Token(Token = "0x60015CD")]
	[Address(RVA = "0x6AAA20", Offset = "0x6A9820", Length = "0x158")]
	protected virtual float GetRateOfChangeHunger()
	{
		return 0f;
	}

	[Token(Token = "0x60015CE")]
	[Address(RVA = "0x6AAB80", Offset = "0x6A9980", Length = "0x1F7")]
	protected virtual float GetRateOfChangeCold()
	{
		return 0f;
	}

	[Token(Token = "0x60015CF")]
	[Address(RVA = "0x6AAD80", Offset = "0x6A9B80", Length = "0xE4")]
	protected virtual float GetRateOfChangeFatigue()
	{
		return 0f;
	}

	[Token(Token = "0x60015D0")]
	[Address(RVA = "0x6AAE70", Offset = "0x6A9C70", Length = "0x1BE")]
	protected virtual bool IsBuffActive()
	{
		return false;
	}

	[Token(Token = "0x60015D1")]
	[Address(RVA = "0x6AB030", Offset = "0x6A9E30", Length = "0x102")]
	protected virtual bool IsDebuffActive()
	{
		return false;
	}

	[Token(Token = "0x60015D2")]
	[Address(RVA = "0x6AB140", Offset = "0x6A9F40", Length = "0x219")]
	private void UpdateForceShow()
	{
	}

	[Token(Token = "0x60015D3")]
	[Address(RVA = "0x6AB360", Offset = "0x6AA160", Length = "0x97")]
	private void SetAlpha(float alphaVal, float duration)
	{
	}

	[Token(Token = "0x60015D4")]
	[Address(RVA = "0x6AB400", Offset = "0x6AA200", Length = "0xC3")]
	private void UpdateBacksplash(float fillValue)
	{
	}

	[Token(Token = "0x60015D5")]
	[Address(RVA = "0x6AB4D0", Offset = "0x6AA2D0", Length = "0x878")]
	private void SetActiveBacksplash(GameObject activeBacksplash)
	{
	}

	[Token(Token = "0x60015D6")]
	[Address(RVA = "0x6ABD50", Offset = "0x6AAB50", Length = "0x1EF")]
	private bool ShouldFadeOut(float fillValue)
	{
		return false;
	}

	[Token(Token = "0x60015D7")]
	[Address(RVA = "0x6ABF40", Offset = "0x6AAD40", Length = "0x82")]
	private int GetNumActiveArrows()
	{
		return 0;
	}

	[Token(Token = "0x60015D8")]
	[Address(RVA = "0x69A420", Offset = "0x699220", Length = "0x58")]
	public StatusBar()
	{
	}
}

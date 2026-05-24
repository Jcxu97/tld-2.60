using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.UI;
using TLD.UI.Generics;
using TLD.Utility;
using TMPro;
using UnityEngine;

[Token(Token = "0x200065E")]
public class Panel_HUD : Panel_AutoReferenced
{
	[Token(Token = "0x200065F")]
	public class BuffNotification
	{
		[Token(Token = "0x4003FBC")]
		[FieldOffset(Offset = "0x10")]
		public string m_BuffNameLocID;

		[Token(Token = "0x4003FBD")]
		[FieldOffset(Offset = "0x18")]
		public string m_BuffHeaderLocId;

		[Token(Token = "0x4003FBE")]
		[FieldOffset(Offset = "0x20")]
		public string m_BuffSpriteName;

		[Token(Token = "0x4003FBF")]
		[FieldOffset(Offset = "0x28")]
		public bool m_BuffWasGained;

		[Token(Token = "0x60034C3")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public BuffNotification()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000660")]
	public struct InspectFade
	{
		[Token(Token = "0x4003FC0")]
		[FieldOffset(Offset = "0x0")]
		public float m_FadeStart;

		[Token(Token = "0x4003FC1")]
		[FieldOffset(Offset = "0x8")]
		public UIWidget[] m_FadeElements;
	}

	[Token(Token = "0x2000661")]
	public enum MoraleMeterState
	{
		[Token(Token = "0x4003FC3")]
		Inactive,
		[Token(Token = "0x4003FC4")]
		Hidden,
		[Token(Token = "0x4003FC5")]
		Visible
	}

	[Token(Token = "0x2000662")]
	public class CreditsQueueInfo
	{
		[Token(Token = "0x4003FC6")]
		[FieldOffset(Offset = "0x10")]
		public bool m_IsCenter;

		[Token(Token = "0x4003FC7")]
		[FieldOffset(Offset = "0x18")]
		public string m_MessageCenter;

		[Token(Token = "0x4003FC8")]
		[FieldOffset(Offset = "0x20")]
		public string m_MessageTop;

		[Token(Token = "0x4003FC9")]
		[FieldOffset(Offset = "0x28")]
		public string m_MessageBottom;

		[Token(Token = "0x4003FCA")]
		[FieldOffset(Offset = "0x30")]
		public float m_TweenDuration;

		[Token(Token = "0x4003FCB")]
		[FieldOffset(Offset = "0x34")]
		public float m_WaitDuration;

		[Token(Token = "0x60034C4")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public CreditsQueueInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000663")]
	public class ScentIndicator
	{
		[Token(Token = "0x4003FCC")]
		[FieldOffset(Offset = "0x10")]
		public UIWidget m_ScentIndicatorRoot;

		[Token(Token = "0x4003FCD")]
		[FieldOffset(Offset = "0x18")]
		public UISprite m_Sprite_ScentIndicator1;

		[Token(Token = "0x4003FCE")]
		[FieldOffset(Offset = "0x20")]
		public UISprite m_Sprite_ScentIndicator2;

		[Token(Token = "0x4003FCF")]
		[FieldOffset(Offset = "0x28")]
		public UISprite m_Sprite_ScentIndicator3;

		[Token(Token = "0x4003FD0")]
		[FieldOffset(Offset = "0x30")]
		public GameObject m_ScentIndicatorEmptySlot1;

		[Token(Token = "0x4003FD1")]
		[FieldOffset(Offset = "0x38")]
		public GameObject m_ScentIndicatorEmptySlot2;

		[Token(Token = "0x4003FD2")]
		[FieldOffset(Offset = "0x40")]
		public GameObject m_ScentIndicatorEmptySlot3;

		[Token(Token = "0x4003FD3")]
		[FieldOffset(Offset = "0x48")]
		public float m_SecondsToShowOnStateChange;

		[Token(Token = "0x4003FD4")]
		[FieldOffset(Offset = "0x4C")]
		public float m_SecondsToFadeOut;

		[Token(Token = "0x4003FD5")]
		[FieldOffset(Offset = "0x50")]
		public bool m_AlwaysShowWhenAboveZero;

		[Token(Token = "0x4003FD6")]
		[FieldOffset(Offset = "0x54")]
		private int m_IndicatorValue;

		[Token(Token = "0x4003FD7")]
		[FieldOffset(Offset = "0x58")]
		private float m_TimerSeconds;

		[Token(Token = "0x4003FD8")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_DoFadeOut;

		[Token(Token = "0x4003FD9")]
		[FieldOffset(Offset = "0x60")]
		private Panel_Actions m_Actions;

		[Token(Token = "0x4003FDA")]
		[FieldOffset(Offset = "0x68")]
		private readonly int[] m_RangeScents;

		[Token(Token = "0x60034C5")]
		[Address(RVA = "0xA6D2F0", Offset = "0xA6C0F0", Length = "0x191")]
		private void UpdateActionsPanel()
		{
		}

		[Token(Token = "0x60034C6")]
		[Address(RVA = "0xA6D490", Offset = "0xA6C290", Length = "0xB8")]
		private void UpdateSprites(int indicatorValue)
		{
		}

		[Token(Token = "0x60034C7")]
		[Address(RVA = "0xA6D550", Offset = "0xA6C350", Length = "0x472")]
		public void Update()
		{
		}

		[Token(Token = "0x60034C8")]
		[Address(RVA = "0xA6D9D0", Offset = "0xA6C7D0", Length = "0x77")]
		public void SetActive(bool enabled)
		{
		}

		[Token(Token = "0x60034C9")]
		[Address(RVA = "0xA6DA50", Offset = "0xA6C850", Length = "0xAB")]
		private void SetVisibleSprites(int indicatorValue)
		{
		}

		[Token(Token = "0x60034CA")]
		[Address(RVA = "0xA6DB00", Offset = "0xA6C900", Length = "0xF7")]
		private int GetIndicatorValue(float scent)
		{
			return 0;
		}

		[Token(Token = "0x60034CB")]
		[Address(RVA = "0xA6DC00", Offset = "0xA6CA00", Length = "0xBC")]
		public ScentIndicator()
		{
		}
	}

	[Header("Buff Notification")]
	[Token(Token = "0x4003E29")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_BuffNotificationParent;

	[Token(Token = "0x4003E2A")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_BuffNotificationAimingParent;

	[Token(Token = "0x4003E2B")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_BuffNotificationPanel;

	[Token(Token = "0x4003E2C")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_BuffHeaderLabel;

	[Token(Token = "0x4003E2D")]
	[FieldOffset(Offset = "0x50")]
	public UILabel m_BuffNameLabel;

	[Token(Token = "0x4003E2E")]
	[FieldOffset(Offset = "0x58")]
	public UISprite m_BuffSprite;

	[Token(Token = "0x4003E2F")]
	[FieldOffset(Offset = "0x60")]
	public float m_BuffNotificationDurationSeconds;

	[SpriteAtlasIconName]
	[Token(Token = "0x4003E30")]
	[FieldOffset(Offset = "0x68")]
	public string m_BuffSpriteWellFed;

	[SpriteAtlasIconName]
	[Token(Token = "0x4003E31")]
	[FieldOffset(Offset = "0x70")]
	public string m_BuffSpriteFatigueBuff;

	[SpriteAtlasIconName]
	[Token(Token = "0x4003E32")]
	[FieldOffset(Offset = "0x78")]
	public string m_BuffSpriteFreezingBuff;

	[SpriteAtlasIconName]
	[Token(Token = "0x4003E33")]
	[FieldOffset(Offset = "0x80")]
	public string m_BuffSpriteRestBuff;

	[SpriteAtlasIconName]
	[Token(Token = "0x4003E34")]
	[FieldOffset(Offset = "0x88")]
	public string m_BuffSpriteConditionOverTimeBuff;

	[SpriteAtlasIconName]
	[Token(Token = "0x4003E35")]
	[FieldOffset(Offset = "0x90")]
	public string m_BuffSpriteSprainProtection;

	[Token(Token = "0x4003E36")]
	[FieldOffset(Offset = "0x98")]
	public UIWidget[] m_BuffWidgetsToChangeColor;

	[Token(Token = "0x4003E37")]
	[FieldOffset(Offset = "0xA0")]
	public Color m_BuffGainColor;

	[Token(Token = "0x4003E38")]
	[FieldOffset(Offset = "0xB0")]
	public Color m_BuffLossColor;

	[Token(Token = "0x4003E39")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_IsShowingBuffNotification;

	[Token(Token = "0x4003E3A")]
	[FieldOffset(Offset = "0xC8")]
	private List<BuffNotification> m_BuffNotificationQueue;

	[Token(Token = "0x4003E3B")]
	[FieldOffset(Offset = "0xD0")]
	private float m_BuffNotificationElapsedSeconds;

	[Header("Cairn Notification")]
	[Token(Token = "0x4003E3C")]
	[FieldOffset(Offset = "0xD8")]
	public TweenAlpha m_CairnNotificationTween;

	[Token(Token = "0x4003E3D")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel m_CairnNameLabel;

	[Token(Token = "0x4003E3E")]
	[FieldOffset(Offset = "0xE8")]
	public UILabel m_CairnQuoteLabel;

	[Token(Token = "0x4003E3F")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel m_CairnBackerLabel;

	[Token(Token = "0x4003E40")]
	[FieldOffset(Offset = "0xF8")]
	public UILabel m_CairnThanksLabel;

	[Token(Token = "0x4003E41")]
	[FieldOffset(Offset = "0x100")]
	private bool m_IsShowingCairnNotification;

	[Header("Inspect Collectible Note")]
	[Token(Token = "0x4003E42")]
	[FieldOffset(Offset = "0x108")]
	public GameObject m_CollectibleNoteObject;

	[Token(Token = "0x4003E43")]
	[FieldOffset(Offset = "0x110")]
	public UILabel m_CollectibleNoteObjectText;

	[Token(Token = "0x4003E44")]
	[FieldOffset(Offset = "0x118")]
	public UILabel m_CollectibleNoteObjectTitle;

	[Token(Token = "0x4003E45")]
	[FieldOffset(Offset = "0x120")]
	public GameObject m_CollectibleNoteScrollObject;

	[Token(Token = "0x4003E46")]
	[FieldOffset(Offset = "0x128")]
	public UIScrollView m_CollectibleNoteScrollView;

	[Token(Token = "0x4003E47")]
	[FieldOffset(Offset = "0x130")]
	private float m_ScrollPanelHeight;

	[Token(Token = "0x4003E48")]
	[FieldOffset(Offset = "0x134")]
	private Color m_SliderDefaultColor;

	[Token(Token = "0x4003E49")]
	[FieldOffset(Offset = "0x144")]
	private float m_TitleY;

	[Token(Token = "0x4003E4A")]
	[FieldOffset(Offset = "0x148")]
	private float m_TitleYOffset;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003E4B")]
	[FieldOffset(Offset = "0x150")]
	private PanelReference<Panel_Actions> m_Actions;

	[SerializeField]
	[Token(Token = "0x4003E4C")]
	[FieldOffset(Offset = "0x158")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[SerializeField]
	[Token(Token = "0x4003E4D")]
	[FieldOffset(Offset = "0x160")]
	private PanelReference<Panel_BodyHarvest> m_BodyHarvest;

	[SerializeField]
	[Token(Token = "0x4003E4E")]
	[FieldOffset(Offset = "0x168")]
	private PanelReference<Panel_BreakDown> m_BreakDown;

	[SerializeField]
	[Token(Token = "0x4003E4F")]
	[FieldOffset(Offset = "0x170")]
	private PanelReference<Panel_Cooking> m_Cooking;

	[SerializeField]
	[Token(Token = "0x4003E50")]
	[FieldOffset(Offset = "0x178")]
	private PanelReference<Panel_FeedFire> m_FeedFire;

	[SerializeField]
	[Token(Token = "0x4003E51")]
	[FieldOffset(Offset = "0x180")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[SerializeField]
	[Token(Token = "0x4003E52")]
	[FieldOffset(Offset = "0x188")]
	private PanelReference<Panel_Loading> m_Loading;

	[SerializeField]
	[Token(Token = "0x4003E53")]
	[FieldOffset(Offset = "0x190")]
	private PanelReference<Panel_Log> m_Log;

	[SerializeField]
	[Token(Token = "0x4003E54")]
	[FieldOffset(Offset = "0x198")]
	private PanelReference<Panel_Map> m_Map;

	[SerializeField]
	[Token(Token = "0x4003E55")]
	[FieldOffset(Offset = "0x1A0")]
	private PanelReference<Panel_PauseMenu> m_PauseMenu;

	[SerializeField]
	[Token(Token = "0x4003E56")]
	[FieldOffset(Offset = "0x1A8")]
	private PanelReference<Panel_Rest> m_Rest;

	[SerializeField]
	[Token(Token = "0x4003E57")]
	[FieldOffset(Offset = "0x1B0")]
	private PanelReference<Panel_TutorialPopup> m_TutorialPopup;

	[Space]
	[Token(Token = "0x4003E58")]
	[FieldOffset(Offset = "0x1B8")]
	public float m_TextFadeOutTimeSeconds;

	[Token(Token = "0x4003E59")]
	[FieldOffset(Offset = "0x1BC")]
	public float m_ConditionTweenNormalizedThreshold;

	[Token(Token = "0x4003E5A")]
	[FieldOffset(Offset = "0x1C0")]
	public UIWidget m_Widget_Affliction;

	[Token(Token = "0x4003E5B")]
	[FieldOffset(Offset = "0x1C8")]
	public UISprite m_Sprite_HasAffliction;

	[Token(Token = "0x4003E5C")]
	[FieldOffset(Offset = "0x1D0")]
	public UISprite m_Sprite_HasAfflictionRisk;

	[Token(Token = "0x4003E5D")]
	[FieldOffset(Offset = "0x1D8")]
	public UISprite m_Sprite_Crouching;

	[Token(Token = "0x4003E5E")]
	[FieldOffset(Offset = "0x1E0")]
	public UITexture m_Texture_InspectItem;

	[Token(Token = "0x4003E5F")]
	[FieldOffset(Offset = "0x1E8")]
	public UILabel m_Label_Calories;

	[Token(Token = "0x4003E60")]
	[FieldOffset(Offset = "0x1F0")]
	public UILabel m_Label_Condition;

	[Token(Token = "0x4003E61")]
	[FieldOffset(Offset = "0x1F8")]
	public UILabel m_Label_DebugLines;

	[Token(Token = "0x4003E62")]
	[FieldOffset(Offset = "0x200")]
	public UILabel m_Label_DebugPlayerInfo;

	[Token(Token = "0x4003E63")]
	[FieldOffset(Offset = "0x208")]
	public UILabel m_Label_DebugString;

	[Token(Token = "0x4003E64")]
	[FieldOffset(Offset = "0x210")]
	public UILabel m_Label_DebugStruggleEvents;

	[Token(Token = "0x4003E65")]
	[FieldOffset(Offset = "0x218")]
	public UILabel m_Label_DebugHeavyBreathing;

	[Token(Token = "0x4003E66")]
	[FieldOffset(Offset = "0x220")]
	public UILabel m_Label_FPS;

	[Token(Token = "0x4003E67")]
	[FieldOffset(Offset = "0x228")]
	public UILabel m_Label_SurvivalTime;

	[Token(Token = "0x4003E68")]
	[FieldOffset(Offset = "0x230")]
	public UILabel m_Label_Message;

	[Token(Token = "0x4003E69")]
	[FieldOffset(Offset = "0x238")]
	public UILabel m_Label_MessageBottom;

	[Token(Token = "0x4003E6A")]
	[FieldOffset(Offset = "0x240")]
	public UILabel m_Label_ItemProgressBar;

	[Token(Token = "0x4003E6B")]
	[FieldOffset(Offset = "0x248")]
	public UILabel m_Label_WarningMessage;

	[Token(Token = "0x4003E6C")]
	[FieldOffset(Offset = "0x250")]
	public Animator m_ThinIceAnimator;

	[Token(Token = "0x4003E6D")]
	[FieldOffset(Offset = "0x258")]
	public UIWidget m_ThinIceWidget;

	[Token(Token = "0x4003E6E")]
	[FieldOffset(Offset = "0x260")]
	public UILabel m_Label_DebugCompass;

	[Token(Token = "0x4003E6F")]
	[FieldOffset(Offset = "0x268")]
	public UILabel m_Label_DebugMissionText;

	[Token(Token = "0x4003E70")]
	[FieldOffset(Offset = "0x270")]
	public GameObject m_ClickHoldCancelButton;

	[Token(Token = "0x4003E71")]
	[FieldOffset(Offset = "0x278")]
	public ButtonPrompt m_ExitDialogueButtonPrompt;

	[Token(Token = "0x4003E72")]
	[FieldOffset(Offset = "0x280")]
	public UISprite m_ProgressBar_Item;

	[Token(Token = "0x4003E73")]
	[FieldOffset(Offset = "0x288")]
	public UISlider m_Slider_TOD;

	[Token(Token = "0x4003E74")]
	[FieldOffset(Offset = "0x290")]
	public UILabel m_SliderLabel_TOD;

	[Token(Token = "0x4003E75")]
	[FieldOffset(Offset = "0x298")]
	public UISprite m_Sprite_Crosshair;

	[Token(Token = "0x4003E76")]
	[FieldOffset(Offset = "0x2A0")]
	public UISprite m_Sprite_CrosshairClickHold;

	[Token(Token = "0x4003E77")]
	[FieldOffset(Offset = "0x2A8")]
	public UISlider m_Slider_StruggleWolfHealth;

	[Token(Token = "0x4003E78")]
	[FieldOffset(Offset = "0x2B0")]
	public UILabel m_Label_WolfHealth;

	[Token(Token = "0x4003E79")]
	[FieldOffset(Offset = "0x2B8")]
	public UISprite m_Sprite_UnarmedIcon;

	[Token(Token = "0x4003E7A")]
	[FieldOffset(Offset = "0x2C0")]
	public UITexture m_Texture_StruggleWeapon;

	[Token(Token = "0x4003E7B")]
	[FieldOffset(Offset = "0x2C8")]
	public UILabel m_Label_StruggleWeaponBonus;

	[Token(Token = "0x4003E7C")]
	[FieldOffset(Offset = "0x2D0")]
	public UILabel m_Label_StruggleLMB;

	[Token(Token = "0x4003E7D")]
	[FieldOffset(Offset = "0x2D8")]
	public UILabel m_Label_StruggleRMB;

	[Token(Token = "0x4003E7E")]
	[FieldOffset(Offset = "0x2E0")]
	public UILabel m_Label_StruggleCaption;

	[Token(Token = "0x4003E7F")]
	[FieldOffset(Offset = "0x2E8")]
	public GameObject m_StruggleWidget;

	[Token(Token = "0x4003E80")]
	[FieldOffset(Offset = "0x2F0")]
	public GameObject m_StruggleRevolverWidget;

	[Token(Token = "0x4003E81")]
	[FieldOffset(Offset = "0x2F8")]
	public TweenAlpha[] m_Struggle_TweenAlpha;

	[Token(Token = "0x4003E82")]
	[FieldOffset(Offset = "0x300")]
	public GameObject m_Struggle_Button_Mouse;

	[Token(Token = "0x4003E83")]
	[FieldOffset(Offset = "0x308")]
	public GameObject m_Struggle_Button_Key;

	[Token(Token = "0x4003E84")]
	[FieldOffset(Offset = "0x310")]
	public UISprite m_Struggle_Button_Key_Sprite;

	[Token(Token = "0x4003E85")]
	[FieldOffset(Offset = "0x318")]
	public UISprite m_Struggle_Button_Key_Feedback;

	[Token(Token = "0x4003E86")]
	[FieldOffset(Offset = "0x320")]
	public UILabel m_Struggle_Button_Key_Label;

	[Token(Token = "0x4003E87")]
	[FieldOffset(Offset = "0x328")]
	public GameObject m_Struggle_Button_Gamepad;

	[Token(Token = "0x4003E88")]
	[FieldOffset(Offset = "0x330")]
	public GameObject m_Struggle_Revolver_Shoot_Button_Mouse;

	[Token(Token = "0x4003E89")]
	[FieldOffset(Offset = "0x338")]
	public GameObject m_Struggle_Revolver_Shoot_Button_Key;

	[Token(Token = "0x4003E8A")]
	[FieldOffset(Offset = "0x340")]
	public GameObject m_Struggle_Revolver_Shoot_Button_Gamepad;

	[Token(Token = "0x4003E8B")]
	[FieldOffset(Offset = "0x348")]
	public UILabel m_Label_Struggle_Revolver_Shoot_Caption;

	[Token(Token = "0x4003E8C")]
	[FieldOffset(Offset = "0x350")]
	public UISprite m_Sprite_SystemFadeOverlay;

	[Token(Token = "0x4003E8D")]
	[FieldOffset(Offset = "0x358")]
	public UISprite m_Sprite_CinematicFadeOverlay;

	[Token(Token = "0x4003E8E")]
	[FieldOffset(Offset = "0x360")]
	public GameObject m_NonEssentialHud;

	[Token(Token = "0x4003E8F")]
	[FieldOffset(Offset = "0x368")]
	public GameObject m_EssentialHud;

	[Token(Token = "0x4003E90")]
	[FieldOffset(Offset = "0x370")]
	public AccelTimePopup m_AccelTimePopup;

	[Token(Token = "0x4003E91")]
	[FieldOffset(Offset = "0x378")]
	public GameObject m_FreeTrialMode;

	[Token(Token = "0x4003E92")]
	[FieldOffset(Offset = "0x380")]
	public UILabel m_FreeTrialModeTimeLabel;

	[Token(Token = "0x4003E93")]
	[FieldOffset(Offset = "0x388")]
	public UILabel m_ExperimentalBuildLabel;

	[Token(Token = "0x4003E94")]
	[FieldOffset(Offset = "0x390")]
	public EquipItemPopup m_EquipItemPopup;

	[Token(Token = "0x4003E95")]
	[FieldOffset(Offset = "0x398")]
	public TwoButtonsChoiceUI m_TwoButtonsChoiceUI;

	[Token(Token = "0x4003E96")]
	[FieldOffset(Offset = "0x3A0")]
	public GenericInteractionCancelUI m_InteractionCancelUI;

	[Token(Token = "0x4003E97")]
	[FieldOffset(Offset = "0x3A8")]
	public Animator m_SprainWarningAnimator;

	[Token(Token = "0x4003E98")]
	[FieldOffset(Offset = "0x3B0")]
	public UIWidget m_SprainWarningWidget;

	[Header("HUD Size Groups")]
	[Token(Token = "0x4003E99")]
	[FieldOffset(Offset = "0x3B8")]
	public Transform m_SmallSizeGroup;

	[Token(Token = "0x4003E9A")]
	[FieldOffset(Offset = "0x3C0")]
	public Transform m_RegularSizeGroup;

	[Token(Token = "0x4003E9B")]
	[FieldOffset(Offset = "0x3C8")]
	public Transform m_LargeSizeGroup;

	[Header("BearSpear")]
	[Token(Token = "0x4003E9C")]
	[FieldOffset(Offset = "0x3D0")]
	public GameObject m_BearSpearTarget;

	[Token(Token = "0x4003E9D")]
	[FieldOffset(Offset = "0x3D8")]
	public GameObject m_BearSpearVisorDebug;

	[Token(Token = "0x4003E9E")]
	[FieldOffset(Offset = "0x3E0")]
	public GameObject m_BearSpearTopRightCorner;

	[Header("Stamina")]
	[Token(Token = "0x4003E9F")]
	[FieldOffset(Offset = "0x3E8")]
	public UIWidget m_SprintBar;

	[Token(Token = "0x4003EA0")]
	[FieldOffset(Offset = "0x3F0")]
	public UISprite m_Sprite_SprintBarX;

	[Token(Token = "0x4003EA1")]
	[FieldOffset(Offset = "0x3F8")]
	public UISprite m_Sprite_SprintBar;

	[Token(Token = "0x4003EA2")]
	[FieldOffset(Offset = "0x400")]
	public UISprite m_Sprite_SprintBarGlow;

	[Token(Token = "0x4003EA3")]
	[FieldOffset(Offset = "0x408")]
	public UISprite m_Sprite_SprintBarBackground;

	[Token(Token = "0x4003EA4")]
	[FieldOffset(Offset = "0x410")]
	public UISprite m_Sprite_SprintReductionBar;

	[Token(Token = "0x4003EA5")]
	[FieldOffset(Offset = "0x418")]
	public UISprite m_Sprite_SprintBuffBar;

	[Token(Token = "0x4003EA6")]
	[FieldOffset(Offset = "0x420")]
	public Color m_SprintBarNoSprintColor;

	[Token(Token = "0x4003EA7")]
	[FieldOffset(Offset = "0x430")]
	public Color m_SprintBarGlowNoSprintColor;

	[Token(Token = "0x4003EA8")]
	[FieldOffset(Offset = "0x440")]
	public Color m_SprintBarBackgroundNoSprintColor;

	[Token(Token = "0x4003EA9")]
	[FieldOffset(Offset = "0x450")]
	private Color m_SprintIconOriginalColor;

	[Token(Token = "0x4003EAA")]
	[FieldOffset(Offset = "0x460")]
	private Color m_SprintBarOrigionalColor;

	[Token(Token = "0x4003EAB")]
	[FieldOffset(Offset = "0x470")]
	private Color m_SprintBarGlowOrigionalColor;

	[Token(Token = "0x4003EAC")]
	[FieldOffset(Offset = "0x480")]
	private Color m_SprintBarBackgroundOrigionalColor;

	[Token(Token = "0x4003EAD")]
	[FieldOffset(Offset = "0x490")]
	public float m_SprintBar_SecondsBeforeFadeOut;

	[Token(Token = "0x4003EAE")]
	[FieldOffset(Offset = "0x494")]
	public float m_SprintBar_SecondsToFadeOut;

	[Token(Token = "0x4003EAF")]
	[FieldOffset(Offset = "0x498")]
	public UIWidget m_AimingStaminaBar;

	[Token(Token = "0x4003EB0")]
	[FieldOffset(Offset = "0x4A0")]
	public UIWidget m_AimingLimitedMobility;

	[Token(Token = "0x4003EB1")]
	[FieldOffset(Offset = "0x4A8")]
	public UISprite m_Sprite_AimingStaminaBar;

	[Token(Token = "0x4003EB2")]
	[FieldOffset(Offset = "0x4B0")]
	public UISprite m_Sprite_AimingStaminaBarGlow;

	[Token(Token = "0x4003EB3")]
	[FieldOffset(Offset = "0x4B8")]
	public UISprite m_Sprite_AimingStaminaBarCenter;

	[Token(Token = "0x4003EB4")]
	[FieldOffset(Offset = "0x4C0")]
	public UISprite m_Sprite_AimingStaminaBarBackground;

	[Token(Token = "0x4003EB5")]
	[FieldOffset(Offset = "0x4C8")]
	public UISprite m_Sprite_AimingStaminaBarReductionBar;

	[Token(Token = "0x4003EB6")]
	[FieldOffset(Offset = "0x4D0")]
	public float m_AimingStaminaBar_SecondsBeforeFadeOut;

	[Token(Token = "0x4003EB7")]
	[FieldOffset(Offset = "0x4D4")]
	public float m_AimingStaminaBar_SecondsToFadeOut;

	[Header("Inspect")]
	[Token(Token = "0x4003EB8")]
	[FieldOffset(Offset = "0x4D8")]
	public GameObject m_Button_InspectModePutBack_Mac;

	[Token(Token = "0x4003EB9")]
	[FieldOffset(Offset = "0x4E0")]
	public GameObject m_Button_InspectModePutBack_PC;

	[Token(Token = "0x4003EBA")]
	[FieldOffset(Offset = "0x4E8")]
	public UISprite m_Sprite_GamepadTake;

	[Token(Token = "0x4003EBB")]
	[FieldOffset(Offset = "0x4F0")]
	public UISprite m_Sprite_GamepadPutback;

	[Token(Token = "0x4003EBC")]
	[FieldOffset(Offset = "0x4F8")]
	public UISprite m_Sprite_GamepadEquip;

	[Token(Token = "0x4003EBD")]
	[FieldOffset(Offset = "0x500")]
	public UISprite m_Sprite_GamepadSecondaryAction;

	[Token(Token = "0x4003EBE")]
	[FieldOffset(Offset = "0x508")]
	public UISprite m_Sprite_GamepadStruggleTap;

	[Header("Struggle")]
	[Token(Token = "0x4003EBF")]
	[FieldOffset(Offset = "0x510")]
	public UIGrid m_PlayerDamageEventsGrid;

	[Token(Token = "0x4003EC0")]
	[FieldOffset(Offset = "0x518")]
	public GameObject m_PlayerDamageEventPrefab;

	[Token(Token = "0x4003EC1")]
	[FieldOffset(Offset = "0x520")]
	public UISprite m_StruggleBar;

	[Token(Token = "0x4003EC2")]
	[FieldOffset(Offset = "0x528")]
	public float m_StruggleBarFillOffset;

	[Token(Token = "0x4003EC3")]
	[FieldOffset(Offset = "0x530")]
	public UISprite m_Sprite_GamepadRevolverShoot;

	[Header("Stats")]
	[Token(Token = "0x4003EC4")]
	[FieldOffset(Offset = "0x538")]
	public UISprite m_Sprite_Encumbered;

	[Token(Token = "0x4003EC5")]
	[FieldOffset(Offset = "0x540")]
	public UISprite m_Sprite_CapacityBuff;

	[Token(Token = "0x4003EC6")]
	[FieldOffset(Offset = "0x548")]
	public UISprite m_Sprite_Sheltered;

	[Token(Token = "0x4003EC7")]
	[FieldOffset(Offset = "0x550")]
	public UISprite m_Sprite_Cold;

	[Token(Token = "0x4003EC8")]
	[FieldOffset(Offset = "0x558")]
	public UISprite m_Sprite_Thirsty;

	[Token(Token = "0x4003EC9")]
	[FieldOffset(Offset = "0x560")]
	public UISprite m_Sprite_Tired;

	[Token(Token = "0x4003ECA")]
	[FieldOffset(Offset = "0x568")]
	public UISprite m_Sprite_Hungry;

	[Token(Token = "0x4003ECB")]
	[FieldOffset(Offset = "0x570")]
	public UISprite m_Sprite_SprintCenter;

	[Token(Token = "0x4003ECC")]
	[FieldOffset(Offset = "0x578")]
	public UISprite m_Sprite_ClimbCenter;

	[Token(Token = "0x4003ECD")]
	[FieldOffset(Offset = "0x580")]
	public UISprite m_Sprite_SpearCenter;

	[Token(Token = "0x4003ECE")]
	[FieldOffset(Offset = "0x588")]
	public UISprite m_Sprite_CarryRestrictions;

	[Token(Token = "0x4003ECF")]
	[FieldOffset(Offset = "0x590")]
	public UISprite m_Sprite_TravoisCarry;

	[Header("Notifications")]
	[Token(Token = "0x4003ED0")]
	[FieldOffset(Offset = "0x598")]
	public UIWidget m_Widget_GearMessage;

	[Token(Token = "0x4003ED1")]
	[FieldOffset(Offset = "0x5A0")]
	public UISprite m_Sprite_GearMessageIcon;

	[Token(Token = "0x4003ED2")]
	[FieldOffset(Offset = "0x5A8")]
	public UITexture m_Texture_GearMessageIcon;

	[Token(Token = "0x4003ED3")]
	[FieldOffset(Offset = "0x5B0")]
	public UILabel m_Label_GearMessageHeader;

	[Token(Token = "0x4003ED4")]
	[FieldOffset(Offset = "0x5B8")]
	public UILabel m_Label_GearMessageText;

	[Token(Token = "0x4003ED5")]
	[FieldOffset(Offset = "0x5C0")]
	public UILabel m_Label_GearMessageQuickKeyText;

	[Token(Token = "0x4003ED6")]
	[FieldOffset(Offset = "0x5C8")]
	public Transform m_GearMessageNormalLocation;

	[Token(Token = "0x4003ED7")]
	[FieldOffset(Offset = "0x5D0")]
	public Transform m_GearMessageOffsetLocation;

	[Token(Token = "0x4003ED8")]
	[FieldOffset(Offset = "0x5D8")]
	public UIWidget m_VistaNotification;

	[Token(Token = "0x4003ED9")]
	[FieldOffset(Offset = "0x5E0")]
	public UILabel m_VistaNotificationTitle;

	[Token(Token = "0x4003EDA")]
	[FieldOffset(Offset = "0x5E8")]
	public UILabel m_VistaNotificationDescription;

	[Token(Token = "0x4003EDB")]
	[FieldOffset(Offset = "0x5F0")]
	public UITexture m_VistaNotificationPostcardTexture;

	[Token(Token = "0x4003EDC")]
	[FieldOffset(Offset = "0x5F8")]
	public float m_VistaNotificationDurationSeconds;

	[Token(Token = "0x4003EDD")]
	[FieldOffset(Offset = "0x600")]
	public TextMeshPro m_TMP_Location;

	[Token(Token = "0x4003EDE")]
	[FieldOffset(Offset = "0x608")]
	public TextMeshPro m_TMP_Region;

	[Token(Token = "0x4003EDF")]
	[FieldOffset(Offset = "0x610")]
	public LocationRevealText m_TMP_Location_FadeComponent;

	[Token(Token = "0x4003EE0")]
	[FieldOffset(Offset = "0x618")]
	public Vector3 m_TMPLocationPosAlone;

	[Token(Token = "0x4003EE1")]
	[FieldOffset(Offset = "0x624")]
	public Vector3 m_TMPLocationPosUnderRegion;

	[Token(Token = "0x4003EE2")]
	[FieldOffset(Offset = "0x630")]
	public TweenAlpha m_NewLocationDiscovered;

	[Token(Token = "0x4003EE3")]
	[FieldOffset(Offset = "0x638")]
	public float m_StatusIconsHorizontalOffset;

	[Token(Token = "0x4003EE4")]
	[FieldOffset(Offset = "0x63C")]
	public float m_StatusIconVerticalOffset;

	[Token(Token = "0x4003EE5")]
	[FieldOffset(Offset = "0x640")]
	public float m_StatusIconsPadding;

	[Token(Token = "0x4003EE6")]
	[FieldOffset(Offset = "0x644")]
	public Color m_StatusIconRedColor;

	[Header("Debug Fly Buttons")]
	[Token(Token = "0x4003EE7")]
	[FieldOffset(Offset = "0x658")]
	public GameObject m_FlyModeButtonGO;

	[Token(Token = "0x4003EE8")]
	[FieldOffset(Offset = "0x660")]
	public ButtonPrompt m_ButtonPromptFlyModeMoveSlow;

	[Token(Token = "0x4003EE9")]
	[FieldOffset(Offset = "0x668")]
	public ButtonPrompt m_ButtonPromptFlyModeMoveFast;

	[Token(Token = "0x4003EEA")]
	[FieldOffset(Offset = "0x670")]
	public ButtonPrompt m_ButtonPromptFlyModeMoveUp;

	[Token(Token = "0x4003EEB")]
	[FieldOffset(Offset = "0x678")]
	public ButtonPrompt m_ButtonPromptFlyModeMoveDown;

	[Token(Token = "0x4003EEC")]
	[FieldOffset(Offset = "0x680")]
	public ButtonPrompt m_ButtonPromptFlyModeLockOrientation;

	[Token(Token = "0x4003EED")]
	[FieldOffset(Offset = "0x688")]
	public ButtonPrompt m_ButtonPromptFlyModeToggleCoords;

	[Token(Token = "0x4003EEE")]
	[FieldOffset(Offset = "0x690")]
	public ButtonPrompt m_ButtonPromptFlyModeAcceptPlacement;

	[Token(Token = "0x4003EEF")]
	[FieldOffset(Offset = "0x698")]
	public ButtonPrompt m_ButtonPromptFlyModeCancelPlacement;

	[Token(Token = "0x4003EF0")]
	[FieldOffset(Offset = "0x6A0")]
	public ButtonLegendContainer m_FlyModeButtonLegendContainer;

	[Token(Token = "0x4003EF1")]
	[FieldOffset(Offset = "0x6A8")]
	public ButtonLegendContainer m_TimePopupButtonLegendContainer;

	[Token(Token = "0x4003EF2")]
	[FieldOffset(Offset = "0x6B0")]
	public ButtonLegendContainer m_GenericButtonLegendContainer;

	[Token(Token = "0x4003EF3")]
	[FieldOffset(Offset = "0x6B8")]
	public float m_DamageEventDisplaySeconds;

	[Token(Token = "0x4003EF4")]
	[FieldOffset(Offset = "0x6BC")]
	public float m_DamageEventFadeOutSeconds;

	[Token(Token = "0x4003EF5")]
	[FieldOffset(Offset = "0x6C0")]
	public UISprite m_FireGamepadButtonSprite;

	[Token(Token = "0x4003EF6")]
	[FieldOffset(Offset = "0x6C8")]
	public UISprite m_AltFireGamepadButtonSprite;

	[Token(Token = "0x4003EF7")]
	[FieldOffset(Offset = "0x6D0")]
	public UISprite m_InspectMode_InventoryStatusSprite;

	[Header("Skill Increase Kicker")]
	[Token(Token = "0x4003EF8")]
	[FieldOffset(Offset = "0x6D8")]
	public UIWidget m_SkillIncreaseWidget;

	[Token(Token = "0x4003EF9")]
	[FieldOffset(Offset = "0x6E0")]
	public UISprite m_SkillIncreaseIcon;

	[Header("Skill LevelUp Kicker")]
	[Token(Token = "0x4003EFA")]
	[FieldOffset(Offset = "0x6E8")]
	public UIWidget m_SkillLevelUpWidget;

	[Token(Token = "0x4003EFB")]
	[FieldOffset(Offset = "0x6F0")]
	public UISprite m_SkillLevelUpBackgroundIcon;

	[Token(Token = "0x4003EFC")]
	[FieldOffset(Offset = "0x6F8")]
	public UILabel m_SkillLevelUpLabel;

	[Token(Token = "0x4003EFD")]
	[FieldOffset(Offset = "0x700")]
	public UILabel m_SkillLevelUpHeader;

	[Token(Token = "0x4003EFE")]
	[FieldOffset(Offset = "0x708")]
	public UILabel m_SkillLevelUpFooter;

	[Header("Feat Unlocked Kicker")]
	[Token(Token = "0x4003EFF")]
	[FieldOffset(Offset = "0x710")]
	public UIWidget m_FeatUnlockedWidget;

	[Token(Token = "0x4003F00")]
	[FieldOffset(Offset = "0x718")]
	public UITexture m_FeatUnlockedBadgeIcon;

	[Token(Token = "0x4003F01")]
	[FieldOffset(Offset = "0x720")]
	public UILabel m_FeatUnlockedFooter;

	[Header("Hover Text")]
	[Token(Token = "0x4003F02")]
	[FieldOffset(Offset = "0x728")]
	public GameObject m_HoverTextObject;

	[Token(Token = "0x4003F03")]
	[FieldOffset(Offset = "0x730")]
	public UILabel m_Label_ObjectName;

	[Token(Token = "0x4003F04")]
	[FieldOffset(Offset = "0x738")]
	public UILabel m_Label_SubText;

	[Token(Token = "0x4003F05")]
	[FieldOffset(Offset = "0x740")]
	public UILabel m_Label_FireTime;

	[Token(Token = "0x4003F06")]
	[FieldOffset(Offset = "0x748")]
	public UILabel m_Label_FireTemp;

	[Token(Token = "0x4003F07")]
	[FieldOffset(Offset = "0x750")]
	public UISprite m_HoverTextBG;

	[Token(Token = "0x4003F08")]
	[FieldOffset(Offset = "0x758")]
	public UISprite m_HoverTextLinebreak;

	[Token(Token = "0x4003F09")]
	[FieldOffset(Offset = "0x760")]
	public int m_HoverTextLinebreakOffset;

	[Token(Token = "0x4003F0A")]
	[FieldOffset(Offset = "0x768")]
	public UISprite[] m_HoverTextIcons;

	[Token(Token = "0x4003F0B")]
	[FieldOffset(Offset = "0x770")]
	public UISprite[] m_HoverTextIconsRow2;

	[Token(Token = "0x4003F0C")]
	[FieldOffset(Offset = "0x778")]
	public UISprite[] m_HoverTextIconsRow3;

	[Token(Token = "0x4003F0D")]
	[FieldOffset(Offset = "0x780")]
	public int m_HoverTextBGPadding;

	[Token(Token = "0x4003F0E")]
	[FieldOffset(Offset = "0x784")]
	public int m_HoverTextBGPaddingBonusWithIcons;

	[Token(Token = "0x4003F0F")]
	[FieldOffset(Offset = "0x788")]
	public int m_HoverTextBGSizePerIcon;

	[Token(Token = "0x4003F10")]
	[FieldOffset(Offset = "0x78C")]
	public int m_HoverTextBGHeightWithSub;

	[Token(Token = "0x4003F11")]
	[FieldOffset(Offset = "0x790")]
	public int m_HoverTextBGHeightWithFire;

	[Token(Token = "0x4003F12")]
	[FieldOffset(Offset = "0x798")]
	public UIGrid m_HoverTextGrid;

	[Token(Token = "0x4003F13")]
	[FieldOffset(Offset = "0x7A0")]
	public GameObject m_HoverTextGridRow1;

	[Token(Token = "0x4003F14")]
	[FieldOffset(Offset = "0x7A8")]
	public GameObject m_HoverTextGridRow2;

	[Token(Token = "0x4003F15")]
	[FieldOffset(Offset = "0x7B0")]
	public GameObject m_HoverTextGridRow3;

	[Token(Token = "0x4003F16")]
	[FieldOffset(Offset = "0x7B8")]
	public Color m_HoverTextNormalColor;

	[Token(Token = "0x4003F17")]
	[FieldOffset(Offset = "0x7C8")]
	public Color m_HoverTextTheftColor;

	[Token(Token = "0x4003F18")]
	[FieldOffset(Offset = "0x7D8")]
	public Color m_HoverTextUnlockedColor;

	[Token(Token = "0x4003F19")]
	[FieldOffset(Offset = "0x7E8")]
	public Color m_HoverTextLockedColor;

	[Header("Inspect Mode Details")]
	[Token(Token = "0x4003F1A")]
	[FieldOffset(Offset = "0x7F8")]
	public GameObject m_InspectMode_StandardElementsParent;

	[Token(Token = "0x4003F1B")]
	[FieldOffset(Offset = "0x800")]
	public GameObject m_InspectMode_InspectPrompts;

	[Token(Token = "0x4003F1C")]
	[FieldOffset(Offset = "0x808")]
	public GameObject m_InspectMode_StackGO;

	[Token(Token = "0x4003F1D")]
	[FieldOffset(Offset = "0x810")]
	public UIGrid m_InspectMode_ButtonLayout;

	[Token(Token = "0x4003F1E")]
	[FieldOffset(Offset = "0x818")]
	public Transform m_InspectMode_StatDetails;

	[Token(Token = "0x4003F1F")]
	[FieldOffset(Offset = "0x820")]
	public float m_StatDetailsOffsetFromDesc;

	[Token(Token = "0x4003F20")]
	[FieldOffset(Offset = "0x824")]
	public float m_StatDetailsOffsetFromContains;

	[Token(Token = "0x4003F21")]
	[FieldOffset(Offset = "0x828")]
	public UISprite m_Sprite_Condition;

	[Token(Token = "0x4003F22")]
	[FieldOffset(Offset = "0x830")]
	public UISprite m_Sprite_ConditionBarBG;

	[Token(Token = "0x4003F23")]
	[FieldOffset(Offset = "0x838")]
	public UISprite m_Sprite_ConditionBarFG;

	[Token(Token = "0x4003F24")]
	[FieldOffset(Offset = "0x840")]
	public UISprite m_Sprite_StackFG;

	[Token(Token = "0x4003F25")]
	[FieldOffset(Offset = "0x848")]
	public UISprite m_Sprite_StackBG;

	[Token(Token = "0x4003F26")]
	[FieldOffset(Offset = "0x850")]
	public UISprite m_Sprite_ContainsFG;

	[Token(Token = "0x4003F27")]
	[FieldOffset(Offset = "0x858")]
	public UISprite m_Sprite_ContainsBG;

	[Token(Token = "0x4003F28")]
	[FieldOffset(Offset = "0x860")]
	public UISprite m_Sprite_Weight;

	[Token(Token = "0x4003F29")]
	[FieldOffset(Offset = "0x868")]
	public UISprite m_InspectMode_FoodHot;

	[Token(Token = "0x4003F2A")]
	[FieldOffset(Offset = "0x870")]
	public UISprite m_InspectMode_FoodCold;

	[Token(Token = "0x4003F2B")]
	[FieldOffset(Offset = "0x878")]
	public UILabel m_InspectMode_Conditon;

	[Token(Token = "0x4003F2C")]
	[FieldOffset(Offset = "0x880")]
	public GameObject m_InspectMode_ContainsGO;

	[Token(Token = "0x4003F2D")]
	[FieldOffset(Offset = "0x888")]
	public UILabel m_InspectMode_Contains;

	[Token(Token = "0x4003F2E")]
	[FieldOffset(Offset = "0x890")]
	public UILabel m_InspectMode_Stack;

	[Token(Token = "0x4003F2F")]
	[FieldOffset(Offset = "0x898")]
	public UILabel m_InspectMode_Description;

	[Token(Token = "0x4003F30")]
	[FieldOffset(Offset = "0x8A0")]
	public UILabel m_InspectMode_Equip;

	[Token(Token = "0x4003F31")]
	[FieldOffset(Offset = "0x8A8")]
	public UILabel m_InspectMode_SecondaryAction;

	[Token(Token = "0x4003F32")]
	[FieldOffset(Offset = "0x8B0")]
	public UILabel m_InspectMode_PutBack;

	[Token(Token = "0x4003F33")]
	[FieldOffset(Offset = "0x8B8")]
	public UILabel m_InspectMode_Take;

	[Token(Token = "0x4003F34")]
	[FieldOffset(Offset = "0x8C0")]
	public UILabel m_InspectMode_Title;

	[Token(Token = "0x4003F35")]
	[FieldOffset(Offset = "0x8C8")]
	public UILabel m_InspectMode_Weight;

	[Token(Token = "0x4003F36")]
	[FieldOffset(Offset = "0x8D0")]
	public UILabel m_InspectMode_InventoryStatus;

	[Token(Token = "0x4003F37")]
	[FieldOffset(Offset = "0x8D8")]
	public UILabel m_InspectMode_ResearchBenefit;

	[Token(Token = "0x4003F38")]
	[FieldOffset(Offset = "0x8E0")]
	public GameObject m_InspectMode_VitaminCObj;

	[Token(Token = "0x4003F39")]
	[FieldOffset(Offset = "0x8E8")]
	public UILabel m_InspectMode_VitaminCAmount;

	[Token(Token = "0x4003F3A")]
	[FieldOffset(Offset = "0x8F0")]
	public UIGrid m_InspectModeDetailsGrid;

	[Token(Token = "0x4003F3B")]
	[FieldOffset(Offset = "0x8F8")]
	public GameObject m_InspectMode_FlaskTopLevel;

	[Token(Token = "0x4003F3C")]
	[FieldOffset(Offset = "0x900")]
	public GameObject m_InspectMode_FlaskCold;

	[Token(Token = "0x4003F3D")]
	[FieldOffset(Offset = "0x908")]
	public GameObject m_InspectMode_FlaskHot;

	[Token(Token = "0x4003F3E")]
	[FieldOffset(Offset = "0x910")]
	public UISprite m_InspectMode_FlaskHotFillSprite;

	[Token(Token = "0x4003F3F")]
	[FieldOffset(Offset = "0x918")]
	public UILabel m_InspectMode_FlaskContentsLabel;

	[SpriteAtlasIconName]
	[Token(Token = "0x4003F40")]
	[FieldOffset(Offset = "0x920")]
	public string m_UnitsSprite_Calories;

	[SpriteAtlasIconName]
	[Token(Token = "0x4003F41")]
	[FieldOffset(Offset = "0x928")]
	public string m_UnitsSprite_WaterPotable;

	[SpriteAtlasIconName]
	[Token(Token = "0x4003F42")]
	[FieldOffset(Offset = "0x930")]
	public string m_UnitsSprite_WaterNonPotable;

	[SpriteAtlasIconName]
	[Token(Token = "0x4003F43")]
	[FieldOffset(Offset = "0x938")]
	public string m_UnitsSprite_Time;

	[Token(Token = "0x4003F44")]
	[FieldOffset(Offset = "0x940")]
	public UISprite[] m_InspectModeItemTypeIcons;

	[Token(Token = "0x4003F45")]
	[FieldOffset(Offset = "0x948")]
	public DishEffectInfo m_DishEffectInfo;

	[Header("Inspect Fade Controls")]
	[Token(Token = "0x4003F46")]
	[FieldOffset(Offset = "0x950")]
	public float m_InspectFadeAlphaPerSecond;

	[Token(Token = "0x4003F47")]
	[FieldOffset(Offset = "0x958")]
	public InspectFade[] m_InspectFadeSequence;

	[Header("Bear Hunt")]
	[Token(Token = "0x4003F48")]
	[FieldOffset(Offset = "0x960")]
	public GameObject m_BearHuntWidget;

	[Token(Token = "0x4003F49")]
	[FieldOffset(Offset = "0x968")]
	public UISprite m_BearHuntProgressBar;

	[Header("Full Screen Message")]
	[Token(Token = "0x4003F4A")]
	[FieldOffset(Offset = "0x970")]
	public TextMeshPro m_FullScreenMessageTMP;

	[Header("Mission Info HUD")]
	[Token(Token = "0x4003F4B")]
	[FieldOffset(Offset = "0x978")]
	public MissionInfoHUD m_MissionInfoHUD;

	[Header("Story Update HUD")]
	[Token(Token = "0x4003F4C")]
	[FieldOffset(Offset = "0x980")]
	public HUDChapter m_ChapterPanel;

	[Token(Token = "0x4003F4D")]
	[FieldOffset(Offset = "0x988")]
	public HUDMission m_MissionPanel;

	[Token(Token = "0x4003F4E")]
	[FieldOffset(Offset = "0x990")]
	public HUDObjectives m_ObjectivesPanel;

	[Header("Tutorial Popup")]
	[Token(Token = "0x4003F4F")]
	[FieldOffset(Offset = "0x998")]
	public HUDTutorial m_TutorialPanel;

	[Header("NPC Carry Missions")]
	[Token(Token = "0x4003F50")]
	[FieldOffset(Offset = "0x9A0")]
	public List<GenericStatusBarSpawner> m_NPCStatusBarSpawners;

	[Token(Token = "0x4003F51")]
	[FieldOffset(Offset = "0x9A8")]
	public List<GameObject> m_NpcStatusHudObjects;

	[Token(Token = "0x4003F52")]
	[FieldOffset(Offset = "0x9B0")]
	public List<UILabel> m_NpcNames;

	[Token(Token = "0x4003F53")]
	[FieldOffset(Offset = "0x9B8")]
	public float m_MaxDistanceToShowNpcCondition;

	[NonSerialized]
	[Token(Token = "0x4003F54")]
	[FieldOffset(Offset = "0x9C0")]
	public UILabel m_InspectMode_ToolTip;

	[NonSerialized]
	[Token(Token = "0x4003F55")]
	[FieldOffset(Offset = "0x9C8")]
	public bool m_EnableDiscoveryText;

	[Header("Morale Meter")]
	[Range(2f, 10f)]
	[Token(Token = "0x4003F56")]
	[FieldOffset(Offset = "0x9CC")]
	public float m_MaxMoraleMeterPackSize;

	[Token(Token = "0x4003F57")]
	[FieldOffset(Offset = "0x9D0")]
	public Animator m_MoraleMeterAnimator;

	[Token(Token = "0x4003F58")]
	[FieldOffset(Offset = "0x9D8")]
	public UIWidget m_MoraleMeterWidget;

	[Token(Token = "0x4003F59")]
	[FieldOffset(Offset = "0x9E0")]
	public UITexture m_MoraleMeter;

	[Token(Token = "0x4003F5A")]
	[FieldOffset(Offset = "0x9E8")]
	public UITexture m_MoraleMeterBackground;

	[Token(Token = "0x4003F5B")]
	[FieldOffset(Offset = "0x9F0")]
	public UILabel m_MoralePackNumber;

	[Token(Token = "0x4003F5C")]
	[FieldOffset(Offset = "0x9F8")]
	private float m_FillBarPercentPerMember;

	[Header("Suffocating Meter")]
	[Token(Token = "0x4003F5D")]
	[FieldOffset(Offset = "0xA00")]
	public UIWidget m_SuffocatingMeterWidget;

	[Token(Token = "0x4003F5E")]
	[FieldOffset(Offset = "0xA08")]
	public UISprite m_SuffocatingMeterForeground;

	[Token(Token = "0x4003F5F")]
	[FieldOffset(Offset = "0xA10")]
	public UILabel m_SuffocatingRemainingTime;

	[Token(Token = "0x4003F60")]
	[FieldOffset(Offset = "0xA18")]
	public LocalizedString m_SuffocationTimeRemaining;

	[Header("Respirator Meter")]
	[Token(Token = "0x4003F61")]
	[FieldOffset(Offset = "0xA20")]
	public UIWidget m_RespiratorMeterWidget;

	[Token(Token = "0x4003F62")]
	[FieldOffset(Offset = "0xA28")]
	public UISprite m_RespiratorMeterForeground;

	[Token(Token = "0x4003F63")]
	[FieldOffset(Offset = "0xA30")]
	public UILabel m_RespiratorRemainingCanisters;

	[Header("Misery")]
	[Token(Token = "0x4003F64")]
	[FieldOffset(Offset = "0xA38")]
	public MiseryHUD m_MiseryHUD;

	[Header("Generic Interaction Prompt")]
	[Token(Token = "0x4003F65")]
	[FieldOffset(Offset = "0xA40")]
	public GenericInteractionPrompt m_GenericInteractionPrompt;

	[Token(Token = "0x4003F66")]
	[FieldOffset(Offset = "0xA48")]
	public GameObject m_GenericCancelPrompt;

	[Token(Token = "0x4003F67")]
	[FieldOffset(Offset = "0xA50")]
	public ButtonPrompt m_GenericCancelButtonPrompt;

	[Header("Title Cards")]
	[Token(Token = "0x4003F68")]
	[FieldOffset(Offset = "0xA58")]
	public GameObject m_TitleCards;

	[Header("Event HUD")]
	[Token(Token = "0x4003F69")]
	[FieldOffset(Offset = "0xA60")]
	public HUDNowhereToHide m_NowhereToHide;

	[Header("Safehouse")]
	[Token(Token = "0x4003F6A")]
	[FieldOffset(Offset = "0xA68")]
	public GameObject m_SafehouseRoot;

	[Token(Token = "0x4003F6B")]
	[FieldOffset(Offset = "0xA70")]
	public GameObject m_SafehouseNormalMode;

	[Token(Token = "0x4003F6C")]
	[FieldOffset(Offset = "0xA78")]
	public GameObject m_SafehouseEditMode;

	[Token(Token = "0x4003F6D")]
	[FieldOffset(Offset = "0xA80")]
	public GameObject m_SafehouseLimitRoot;

	[Token(Token = "0x4003F6E")]
	[FieldOffset(Offset = "0xA88")]
	public UILabel m_SafehouseCountLabel;

	[Token(Token = "0x4003F6F")]
	[FieldOffset(Offset = "0xA90")]
	public UISprite m_SafehouseCountSprite;

	[Token(Token = "0x4003F70")]
	[FieldOffset(Offset = "0xA98")]
	public GameObject m_SafehouseControllerRoot;

	[Token(Token = "0x4003F71")]
	[FieldOffset(Offset = "0xAA0")]
	public GameObject m_SafehouseMKBRoot;

	[Token(Token = "0x4003F72")]
	[FieldOffset(Offset = "0xAA8")]
	public SafehouseClearJunkIndicator m_SafehouseClearJunkIndicator;

	[Token(Token = "0x4003F73")]
	[FieldOffset(Offset = "0xAB0")]
	private MoraleMeterState m_MoraleMeterState;

	[Token(Token = "0x4003F74")]
	private static readonly int s_AnimState_PackMoraleIn;

	[Token(Token = "0x4003F75")]
	private static readonly int s_AnimState_PackMoraleOut;

	[Token(Token = "0x4003F76")]
	private static readonly int s_AnimState_PackMoraleIdle;

	[Token(Token = "0x4003F77")]
	public static bool m_DebugHeavyBreathing;

	[Token(Token = "0x4003F78")]
	public static bool m_HideTestBuildWatermark;

	[Space]
	[Token(Token = "0x4003F79")]
	[FieldOffset(Offset = "0xAB4")]
	public bool m_ForceTimeOfDayDisplay;

	[NonSerialized]
	[Token(Token = "0x4003F7A")]
	[FieldOffset(Offset = "0xAB5")]
	public bool m_ForceHideNotifications;

	[Token(Token = "0x4003F7B")]
	[FieldOffset(Offset = "0xAB6")]
	private bool m_ForceDisableTimeOfDayDisplay;

	[Token(Token = "0x4003F7C")]
	[FieldOffset(Offset = "0xAB7")]
	private bool m_DisplayVistaNotification;

	[Token(Token = "0x4003F7D")]
	[FieldOffset(Offset = "0xAB8")]
	private string m_DisplayVistaPostcardName;

	[Token(Token = "0x4003F7E")]
	[FieldOffset(Offset = "0xAC0")]
	private float m_VistaNotificationElapsedDisplayTimeSeconds;

	[Token(Token = "0x4003F7F")]
	[FieldOffset(Offset = "0xAC4")]
	private bool m_DisplaySurvivalTimeAfterRest;

	[Token(Token = "0x4003F80")]
	[FieldOffset(Offset = "0xAC8")]
	private float m_SurvivalTimeLabelDisplayTimeSeconds;

	[Token(Token = "0x4003F81")]
	[FieldOffset(Offset = "0xACC")]
	private float m_SurvivalTimeLabelElapsedDisplayTimeSeconds;

	[Token(Token = "0x4003F82")]
	[FieldOffset(Offset = "0xAD0")]
	private float m_SurvivalTimeLabelAlpha;

	[Token(Token = "0x4003F83")]
	[FieldOffset(Offset = "0xAD4")]
	private float m_ItemProgressBarTimer;

	[Token(Token = "0x4003F84")]
	[FieldOffset(Offset = "0xAD8")]
	private float m_ItemProgressBarDuration;

	[Token(Token = "0x4003F85")]
	[FieldOffset(Offset = "0xAE0")]
	private Action m_ItemProgressBarCallback;

	[Token(Token = "0x4003F86")]
	[FieldOffset(Offset = "0xAE8")]
	private GearItem m_ItemProgressBarRelatedItem;

	[Token(Token = "0x4003F87")]
	[FieldOffset(Offset = "0xAF0")]
	private bool m_ItemProgressBarCancelled;

	[Token(Token = "0x4003F88")]
	[FieldOffset(Offset = "0xAF1")]
	private bool m_ItemProgressBarActive;

	[Token(Token = "0x4003F89")]
	[FieldOffset(Offset = "0xAF4")]
	private float m_RegisterClickAsHoldDelay;

	[Token(Token = "0x4003F8A")]
	[FieldOffset(Offset = "0xAF8")]
	private float m_ItemProgressBarMinDuration;

	[Token(Token = "0x4003F8B")]
	[FieldOffset(Offset = "0xAFC")]
	private HudDisplayMode m_HudDisplayMode;

	[Token(Token = "0x4003F8C")]
	[FieldOffset(Offset = "0xB00")]
	private bool m_SetDisplayModeOnce;

	[Token(Token = "0x4003F8D")]
	[FieldOffset(Offset = "0xB04")]
	private float m_TimeToHideSubtitles;

	[Token(Token = "0x4003F8E")]
	[FieldOffset(Offset = "0xB08")]
	private float m_AspectRatioBonusSize;

	[Token(Token = "0x4003F8F")]
	[FieldOffset(Offset = "0xB0C")]
	private int m_HoverTextSizeOrig;

	[Token(Token = "0x4003F90")]
	[FieldOffset(Offset = "0xB10")]
	private bool m_WasFadedDueToSleep;

	[Token(Token = "0x4003F91")]
	[FieldOffset(Offset = "0xB14")]
	private int m_PanelDepthOrig;

	[Token(Token = "0x4003F92")]
	[FieldOffset(Offset = "0xB18")]
	private bool m_FadeOutDamageEvents;

	[Token(Token = "0x4003F93")]
	[FieldOffset(Offset = "0xB1C")]
	private float m_DamageEventsTimeSinceFadoutStarted;

	[Token(Token = "0x4003F94")]
	[FieldOffset(Offset = "0xB20")]
	private float m_DamageEventsFadeOutTimerStartsInSeconds;

	[Token(Token = "0x4003F95")]
	[FieldOffset(Offset = "0xB24")]
	private float m_DamageEventsFadeoutTime;

	[Token(Token = "0x4003F96")]
	[FieldOffset(Offset = "0xB28")]
	private int m_HoverTextBGHeightOrig;

	[Token(Token = "0x4003F97")]
	[FieldOffset(Offset = "0xB30")]
	private List<Transform> m_StatusIconTransforms;

	[Token(Token = "0x4003F98")]
	[FieldOffset(Offset = "0xB38")]
	private bool m_CinematicBlackout;

	[Token(Token = "0x4003F99")]
	[FieldOffset(Offset = "0xB39")]
	private bool m_HideHudElements;

	[Token(Token = "0x4003F9A")]
	[FieldOffset(Offset = "0xB3A")]
	private bool m_HideReticle;

	[Token(Token = "0x4003F9B")]
	[FieldOffset(Offset = "0xB40")]
	private TweenScale m_TweenScaleAffliction;

	[Token(Token = "0x4003F9C")]
	[FieldOffset(Offset = "0xB48")]
	private string m_CurrentObjectiveLocID;

	[Token(Token = "0x4003F9D")]
	[FieldOffset(Offset = "0xB50")]
	private string m_DisplayedMissionID;

	[Token(Token = "0x4003F9E")]
	[FieldOffset(Offset = "0xB58")]
	private float m_DisplayedMissionNextUpdate;

	[Token(Token = "0x4003F9F")]
	private static readonly float DISPLAYED_MISSION_UPDATE_DELAY;

	[Token(Token = "0x4003FA0")]
	[FieldOffset(Offset = "0xB5C")]
	private float m_SprintFadeTimeTracker;

	[Token(Token = "0x4003FA1")]
	[FieldOffset(Offset = "0xB60")]
	private float m_AimStaminaFadeTimeTracker;

	[Token(Token = "0x4003FA2")]
	[FieldOffset(Offset = "0xB68")]
	private Queue<LocationRevealQueueInfo> m_LocationRevealQueue;

	[Token(Token = "0x4003FA3")]
	private static readonly int NUM_CACHED_OBJECTIVES;

	[Token(Token = "0x4003FA4")]
	[FieldOffset(Offset = "0xB70")]
	private List<string> m_LastObjectiveIDs;

	[Token(Token = "0x4003FA5")]
	[FieldOffset(Offset = "0xB78")]
	private List<StoryMissionObjective> m_TempObjectives;

	[Token(Token = "0x4003FA6")]
	[FieldOffset(Offset = "0xB80")]
	private Animator m_StruggleWidgetAnimator;

	[Token(Token = "0x4003FA7")]
	[FieldOffset(Offset = "0xB88")]
	private int m_AnimParameter_EnableRevolverPointBlank;

	[Token(Token = "0x4003FA8")]
	[FieldOffset(Offset = "0xB8C")]
	private uint m_TimerwolfCombatMusicPlayingID;

	[Token(Token = "0x4003FA9")]
	[FieldOffset(Offset = "0xB90")]
	private NPCStatusBar[] m_SatusBars;

	[HideInInspector]
	[Token(Token = "0x4003FAA")]
	public static bool s_DebugStoryHUD;

	[Header("Timed Action Popup")]
	[Token(Token = "0x4003FAB")]
	[FieldOffset(Offset = "0xB98")]
	public TimedActionPopup m_TimedActionPopup;

	[Token(Token = "0x4003FAC")]
	[FieldOffset(Offset = "0xBA0")]
	private GameObject m_PreviousItemUnderCrosshairs;

	[Token(Token = "0x4003FAD")]
	[FieldOffset(Offset = "0xBA8")]
	private HoverTextState m_PreviousTextState;

	[Token(Token = "0x4003FAE")]
	[FieldOffset(Offset = "0xBB0")]
	private string m_PreviousHoverText;

	[Token(Token = "0x4003FAF")]
	[FieldOffset(Offset = "0xBB8")]
	private bool m_WasSuffocating;

	[Token(Token = "0x4003FB0")]
	[FieldOffset(Offset = "0xBB9")]
	private bool m_WasRespiratorEquipped;

	[Token(Token = "0x4003FB1")]
	[FieldOffset(Offset = "0xBBC")]
	private int m_LastRespiratorCanisterCount;

	[Header("Opening Credits")]
	[Token(Token = "0x4003FB2")]
	[FieldOffset(Offset = "0xBC0")]
	public GameObject m_CreditsParentObject;

	[Token(Token = "0x4003FB3")]
	[FieldOffset(Offset = "0xBC8")]
	public TweenAlpha m_CenterLabelTween;

	[Token(Token = "0x4003FB4")]
	[FieldOffset(Offset = "0xBD0")]
	public TweenAlpha m_SideLabelTopTween;

	[Token(Token = "0x4003FB5")]
	[FieldOffset(Offset = "0xBD8")]
	public TweenAlpha m_SideLabelCenterTween;

	[Token(Token = "0x4003FB6")]
	[FieldOffset(Offset = "0xBE0")]
	public TweenAlpha m_SideLabelBottomTween;

	[Token(Token = "0x4003FB7")]
	[FieldOffset(Offset = "0xBE8")]
	public float m_MinTimeBetweenCredits;

	[Token(Token = "0x4003FB8")]
	[FieldOffset(Offset = "0xBF0")]
	private List<CreditsQueueInfo> m_CreditsQueue;

	[Token(Token = "0x4003FB9")]
	[FieldOffset(Offset = "0xBF8")]
	private float m_CreditsQueueTimer;

	[Token(Token = "0x4003FBA")]
	[FieldOffset(Offset = "0xBFC")]
	private float m_CreditsWaitTimer;

	[Token(Token = "0x4003FBB")]
	[FieldOffset(Offset = "0xC00")]
	public ScentIndicator m_ScentIndicator;

	[Token(Token = "0x600343E")]
	[Address(RVA = "0xA59C70", Offset = "0xA58A70", Length = "0x1DB")]
	public void ShowBuffNotification(string buffNameLocID, string buffHeaderLocId, string buffSpriteName)
	{
	}

	[Token(Token = "0x600343F")]
	[Address(RVA = "0xA59E50", Offset = "0xA58C50", Length = "0x1DB")]
	public void ShowBuffLossNotification(string buffNameLocID, string buffHeaderLocId, string buffSpriteName)
	{
	}

	[Token(Token = "0x6003440")]
	[Address(RVA = "0xA5A030", Offset = "0xA58E30", Length = "0xA9")]
	public void HideBuffNotification()
	{
	}

	[Token(Token = "0x6003441")]
	[Address(RVA = "0xA5A0E0", Offset = "0xA58EE0", Length = "0x471")]
	private void UpdateBuffNotification()
	{
	}

	[Token(Token = "0x6003442")]
	[Address(RVA = "0xA5A560", Offset = "0xA59360", Length = "0x291")]
	private void StartBuffNotificationTweeens(GameObject parent)
	{
	}

	[Token(Token = "0x6003443")]
	[Address(RVA = "0xA5A800", Offset = "0xA59600", Length = "0x9A3")]
	private void DoShowBuffNotification(BuffNotification buffNotification)
	{
	}

	[Token(Token = "0x6003444")]
	[Address(RVA = "0xA5B1B0", Offset = "0xA59FB0", Length = "0x316")]
	public void ShowCairnNotification(Cairn cairn)
	{
	}

	[Token(Token = "0x6003445")]
	[Address(RVA = "0xA5B4D0", Offset = "0xA5A2D0", Length = "0x73")]
	public void HideCairnNotification()
	{
	}

	[Token(Token = "0x6003446")]
	[Address(RVA = "0xA5B550", Offset = "0xA5A350", Length = "0x93")]
	private void UpdateCairnNotification()
	{
	}

	[Token(Token = "0x6003447")]
	[Address(RVA = "0xA5B5F0", Offset = "0xA5A3F0", Length = "0x2A4")]
	public void SetupCollectibleNote()
	{
	}

	[Token(Token = "0x6003448")]
	[Address(RVA = "0xA5B8A0", Offset = "0xA5A6A0", Length = "0x803")]
	public void ShowCollectibleNote(GearItem gearItem)
	{
	}

	[Token(Token = "0x6003449")]
	[Address(RVA = "0xA5C0B0", Offset = "0xA5AEB0", Length = "0x84")]
	public void OnCollectibleNoteReadingClickBack()
	{
	}

	[Token(Token = "0x600344A")]
	[Address(RVA = "0xA5C140", Offset = "0xA5AF40", Length = "0x1DB")]
	public void HideCollectibleNote(GearItem gearItem)
	{
	}

	[Token(Token = "0x600344B")]
	[Address(RVA = "0xA5C320", Offset = "0xA5B120", Length = "0x21E")]
	public void UpdateCollectibleNote()
	{
	}

	[Token(Token = "0x600344C")]
	[Address(RVA = "0xA5C540", Offset = "0xA5B340", Length = "0x9C")]
	public bool IsShowingCollectibleNote()
	{
		return false;
	}

	[Token(Token = "0x600344D")]
	[Address(RVA = "0xA5C5E0", Offset = "0xA5B3E0", Length = "0xB0")]
	public void ShowReadNoteButtonLegend()
	{
	}

	[Token(Token = "0x600344E")]
	[Address(RVA = "0xA5C6A0", Offset = "0xA5B4A0", Length = "0xB5E")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600344F")]
	[Address(RVA = "0xA5D200", Offset = "0xA5C000", Length = "0x12EB")]
	private void Update()
	{
	}

	[Token(Token = "0x6003450")]
	[Address(RVA = "0xA5E4F0", Offset = "0xA5D2F0", Length = "0x160")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6003451")]
	[Address(RVA = "0xA5E660", Offset = "0xA5D460", Length = "0x1E")]
	public bool IsShowingGenericInteractionPrompt()
	{
		return false;
	}

	[Token(Token = "0x6003452")]
	[Address(RVA = "0xA5E680", Offset = "0xA5D480", Length = "0x15")]
	public bool IsOverlayActive()
	{
		return false;
	}

	[Token(Token = "0x6003453")]
	[Address(RVA = "0xA5E6A0", Offset = "0xA5D4A0", Length = "0x395")]
	public void EnableTimeOfDayScaleDisplay(bool enable)
	{
	}

	[Token(Token = "0x6003454")]
	[Address(RVA = "0xA5EA40", Offset = "0xA5D840", Length = "0x7")]
	public void ForceDisableTimeOfDayScaleDisplay(bool disable)
	{
	}

	[Token(Token = "0x6003455")]
	[Address(RVA = "0xA5EA50", Offset = "0xA5D850", Length = "0x170")]
	public void EnableForcedTimeOfDayScaleDisplay(bool enable)
	{
	}

	[Token(Token = "0x6003456")]
	[Address(RVA = "0xA5EBD0", Offset = "0xA5D9D0", Length = "0x227")]
	public void SetConditionLabelDepth()
	{
	}

	[Token(Token = "0x6003457")]
	[Address(RVA = "0xA5EE00", Offset = "0xA5DC00", Length = "0xCE")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003458")]
	[Address(RVA = "0xA5EED0", Offset = "0xA5DCD0", Length = "0x7F")]
	public void SetStruggleBarFillAmount(float value)
	{
	}

	[Token(Token = "0x6003459")]
	[Address(RVA = "0xA5EF50", Offset = "0xA5DD50", Length = "0x26B")]
	public void ShowStruggleWidget(bool enable)
	{
	}

	[Token(Token = "0x600345A")]
	[Address(RVA = "0xA5F1C0", Offset = "0xA5DFC0", Length = "0x114")]
	public void ShowStruggleRevolverWidget(bool enable)
	{
	}

	[Token(Token = "0x600345B")]
	[Address(RVA = "0xA5F2E0", Offset = "0xA5E0E0", Length = "0x39")]
	public void ShowSurvivalTimeAfterRest(string text, float numSeconds)
	{
	}

	[Token(Token = "0x600345C")]
	[Address(RVA = "0xA5F320", Offset = "0xA5E120", Length = "0x4FE")]
	public void ShowLocationReveal(string text, string subText = "", bool showNewLocation = false)
	{
	}

	[Token(Token = "0x600345D")]
	[Address(RVA = "0xA5F820", Offset = "0xA5E620", Length = "0x110")]
	public void ShowVistaNotification(bool enabled, string gearItemName)
	{
	}

	[Token(Token = "0x600345E")]
	[Address(RVA = "0xA5F940", Offset = "0xA5E740", Length = "0x86")]
	public void ShowRegionReveal(string text, string subText, bool showNewLocation = false)
	{
	}

	[Token(Token = "0x600345F")]
	[Address(RVA = "0xA5F9D0", Offset = "0xA5E7D0", Length = "0x292")]
	private void ShowNewLocationDiscovered()
	{
	}

	[Token(Token = "0x6003460")]
	[Address(RVA = "0xA5FC70", Offset = "0xA5EA70", Length = "0x24")]
	private void HideNewLocationDiscovered()
	{
	}

	[Token(Token = "0x6003461")]
	[Address(RVA = "0xA5FCA0", Offset = "0xA5EAA0", Length = "0xF7")]
	public bool ShouldHideNotification()
	{
		return false;
	}

	[Token(Token = "0x6003462")]
	[Address(RVA = "0xA5FDA0", Offset = "0xA5EBA0", Length = "0xC1")]
	public bool IsNonRadialOverlayActive()
	{
		return false;
	}

	[Token(Token = "0x6003463")]
	[Address(RVA = "0xA5FE70", Offset = "0xA5EC70", Length = "0x51")]
	private void MaybeHideNewLocationDiscovered()
	{
	}

	[Token(Token = "0x6003464")]
	[Address(RVA = "0xA5FED0", Offset = "0xA5ECD0", Length = "0xDF")]
	public void HideLocationLabel()
	{
	}

	[Token(Token = "0x6003465")]
	[Address(RVA = "0xA5FFB0", Offset = "0xA5EDB0", Length = "0xF1")]
	public UILabel GetUILabel(string label)
	{
		return null;
	}

	[Token(Token = "0x6003466")]
	[Address(RVA = "0xA600B0", Offset = "0xA5EEB0", Length = "0x199")]
	public void OnSliderTODChange()
	{
	}

	[Token(Token = "0x6003467")]
	[Address(RVA = "0xA60250", Offset = "0xA5F050", Length = "0x119")]
	public void StartItemProgressBar(float duration, string progressLabel, GearItem relatedItem, Action callbackDelegate = null)
	{
	}

	[Token(Token = "0x6003468")]
	[Address(RVA = "0xA60370", Offset = "0xA5F170", Length = "0xB4")]
	public void CancelItemProgressBar()
	{
	}

	[Token(Token = "0x6003469")]
	[Address(RVA = "0xA60430", Offset = "0xA5F230", Length = "0x8")]
	public bool IsItemProgressBarActive()
	{
		return false;
	}

	[Token(Token = "0x600346A")]
	[Address(RVA = "0xA60440", Offset = "0xA5F240", Length = "0x136")]
	public bool IsProgressBarRelatedItem(GearItem item)
	{
		return false;
	}

	[Token(Token = "0x600346B")]
	[Address(RVA = "0xA60580", Offset = "0xA5F380", Length = "0x26")]
	public void SetHudDisplayMode(HudDisplayMode hudDisplayMode)
	{
	}

	[Token(Token = "0x600346C")]
	[Address(RVA = "0xA605B0", Offset = "0xA5F3B0", Length = "0x6BD")]
	public void RefreshHudDisplayMode()
	{
	}

	[Token(Token = "0x600346D")]
	[Address(RVA = "0xA60C70", Offset = "0xA5FA70", Length = "0x5B")]
	public void DisplayWarningMessage(string msg)
	{
	}

	[Token(Token = "0x600346E")]
	[Address(RVA = "0xA60CD0", Offset = "0xA5FAD0", Length = "0x74")]
	public void ClearWarningMessage()
	{
	}

	[Token(Token = "0x600346F")]
	[Address(RVA = "0xA60D50", Offset = "0xA5FB50", Length = "0x22")]
	public void FadeOutDamageEvents(float delayTime, float fadeOutTime)
	{
	}

	[Token(Token = "0x6003470")]
	[Address(RVA = "0xA60D80", Offset = "0xA5FB80", Length = "0xF6")]
	public void ShowMissionTimer(bool visible)
	{
	}

	[Token(Token = "0x6003471")]
	[Address(RVA = "0xA60E80", Offset = "0xA5FC80", Length = "0xD8")]
	public void RefreshMissionTimer(string text)
	{
	}

	[Token(Token = "0x6003472")]
	[Address(RVA = "0xA60F60", Offset = "0xA5FD60", Length = "0x16E")]
	public void ShowMissionMessage(bool visible)
	{
	}

	[Token(Token = "0x6003473")]
	[Address(RVA = "0xA610D0", Offset = "0xA5FED0", Length = "0xE6")]
	public void RefreshObjectiveLabel()
	{
	}

	[Token(Token = "0x6003474")]
	[Address(RVA = "0xA611C0", Offset = "0xA5FFC0", Length = "0x424")]
	public void RefreshMissionMessage(string locID, Color col, bool allowSkipFirstTime)
	{
	}

	[Token(Token = "0x6003475")]
	[Address(RVA = "0xA615F0", Offset = "0xA603F0", Length = "0x404")]
	public void RefreshMissionMessageNoLoc(string mesasge, Color col, bool allowSkipFirstTime)
	{
	}

	[Token(Token = "0x6003476")]
	[Address(RVA = "0xA61A00", Offset = "0xA60800", Length = "0x39")]
	public void ShowDebugMissionText(bool visible)
	{
	}

	[Token(Token = "0x6003477")]
	[Address(RVA = "0xA61A40", Offset = "0xA60840", Length = "0xCA")]
	public void RefreshDebugMissionText(string str, Color col)
	{
	}

	[Token(Token = "0x6003478")]
	[Address(RVA = "0xA61B10", Offset = "0xA60910", Length = "0x31")]
	public void ResetHoverText()
	{
	}

	[Token(Token = "0x6003479")]
	[Address(RVA = "0xA61B50", Offset = "0xA60950", Length = "0x14E4")]
	public void SetHoverText(string hoverText, GameObject itemUnderCrosshairs, HoverTextState textState)
	{
	}

	[Token(Token = "0x600347A")]
	[Address(RVA = "0xA63040", Offset = "0xA61E40", Length = "0x8")]
	public bool GetCinematicBlackout()
	{
		return false;
	}

	[Token(Token = "0x600347B")]
	[Address(RVA = "0xA63050", Offset = "0xA61E50", Length = "0x41")]
	public void SetCinematicBlackout(bool enabled)
	{
	}

	[Token(Token = "0x600347C")]
	[Address(RVA = "0xA630A0", Offset = "0xA61EA0", Length = "0x7")]
	public void HideHudElements(bool hide)
	{
	}

	[Token(Token = "0x600347D")]
	[Address(RVA = "0xA630B0", Offset = "0xA61EB0", Length = "0x8")]
	public bool GetHideHudElements()
	{
		return false;
	}

	[Token(Token = "0x600347E")]
	[Address(RVA = "0xA630C0", Offset = "0xA61EC0", Length = "0x7")]
	public void HideReticle(bool hide)
	{
	}

	[Token(Token = "0x600347F")]
	[Address(RVA = "0xA630D0", Offset = "0xA61ED0", Length = "0x8")]
	public bool ShouldHideReticle()
	{
		return false;
	}

	[Token(Token = "0x6003480")]
	[Address(RVA = "0xA630E0", Offset = "0xA61EE0", Length = "0x397")]
	public void CleanupDamageEventTable()
	{
	}

	[Token(Token = "0x6003481")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void SetExperimentalBuildLabel()
	{
	}

	[Token(Token = "0x6003482")]
	[Address(RVA = "0xA63480", Offset = "0xA62280", Length = "0xEE")]
	public void DoClickHoldCancel()
	{
	}

	[Token(Token = "0x6003483")]
	[Address(RVA = "0xA63570", Offset = "0xA62370", Length = "0x168")]
	public void DoExitDialogue()
	{
	}

	[Token(Token = "0x6003484")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public string GetStoryHUDDebugText()
	{
		return null;
	}

	[Token(Token = "0x6003485")]
	[Address(RVA = "0xA636E0", Offset = "0xA624E0", Length = "0x183")]
	public void HideNotifications()
	{
	}

	[Token(Token = "0x6003486")]
	[Address(RVA = "0xA63870", Offset = "0xA62670", Length = "0x95")]
	private void UpdateLocationLabel()
	{
	}

	[Token(Token = "0x6003487")]
	[Address(RVA = "0xA63910", Offset = "0xA62710", Length = "0x1E2")]
	private void UpdateVistaNotification()
	{
	}

	[Token(Token = "0x6003488")]
	[Address(RVA = "0xA63B00", Offset = "0xA62900", Length = "0x12B")]
	private bool CanShowLocationReveal()
	{
		return false;
	}

	[Token(Token = "0x6003489")]
	[Address(RVA = "0xA63C30", Offset = "0xA62A30", Length = "0x322")]
	private void UpdateSurvivalTimeLabel()
	{
	}

	[Token(Token = "0x600348A")]
	[Address(RVA = "0xA63F60", Offset = "0xA62D60", Length = "0x64D")]
	private void ItemProgressBarCheck()
	{
	}

	[Token(Token = "0x600348B")]
	[Address(RVA = "0xA645B0", Offset = "0xA633B0", Length = "0x148")]
	private bool IsDialogueExitButtonAvailable()
	{
		return false;
	}

	[Token(Token = "0x600348C")]
	[Address(RVA = "0xA64700", Offset = "0xA63500", Length = "0x315")]
	private void ExitDialogueUpdate()
	{
	}

	[Token(Token = "0x600348D")]
	[Address(RVA = "0xA64A20", Offset = "0xA63820", Length = "0x9B")]
	private void MaybeHideHudElementsThatOverlapPauseMenuIcon()
	{
	}

	[Token(Token = "0x600348E")]
	[Address(RVA = "0xA64AC0", Offset = "0xA638C0", Length = "0x285")]
	private void UpdateDebugCompass()
	{
	}

	[Token(Token = "0x600348F")]
	[Address(RVA = "0xA64D50", Offset = "0xA63B50", Length = "0x1C1")]
	public bool ShouldHideConditionRelatedLabels()
	{
		return false;
	}

	[Token(Token = "0x6003490")]
	[Address(RVA = "0xA64F20", Offset = "0xA63D20", Length = "0x12C")]
	private bool ShouldHideCaloriesLabel()
	{
		return false;
	}

	[Token(Token = "0x6003491")]
	[Address(RVA = "0xA65050", Offset = "0xA63E50", Length = "0x81")]
	private bool ShouldShowAlternateColor()
	{
		return false;
	}

	[Token(Token = "0x6003492")]
	[Address(RVA = "0xA650E0", Offset = "0xA63EE0", Length = "0x1D2")]
	private bool DoingBodyCarry()
	{
		return false;
	}

	[Token(Token = "0x6003493")]
	[Address(RVA = "0xA652C0", Offset = "0xA640C0", Length = "0x1D2")]
	private bool DoingTravoisCarry()
	{
		return false;
	}

	[Token(Token = "0x6003494")]
	[Address(RVA = "0xA654A0", Offset = "0xA642A0", Length = "0xB29")]
	private void UpdateStaminaBar()
	{
	}

	[Token(Token = "0x6003495")]
	[Address(RVA = "0xA65FD0", Offset = "0xA64DD0", Length = "0x6F5")]
	private void UpdateAimingStaminaBar()
	{
	}

	[Token(Token = "0x6003496")]
	[Address(RVA = "0xA666D0", Offset = "0xA654D0", Length = "0xC4C")]
	private void UpdateStatusIcons()
	{
	}

	[Token(Token = "0x6003497")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void CreateFlyModeIcons()
	{
	}

	[Token(Token = "0x6003498")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void UpdateFlyModeIcons()
	{
	}

	[Token(Token = "0x6003499")]
	[Address(RVA = "0xA67320", Offset = "0xA66120", Length = "0x16D")]
	private void ClearButtonPromptsForFlyMode()
	{
	}

	[Token(Token = "0x600349A")]
	[Address(RVA = "0xA67490", Offset = "0xA66290", Length = "0xCC")]
	private void MaintainOriginalObjectSize()
	{
	}

	[Token(Token = "0x600349B")]
	[Address(RVA = "0xA67560", Offset = "0xA66360", Length = "0x3BF")]
	private void FadeOutAllEvents()
	{
	}

	[Token(Token = "0x600349C")]
	[Address(RVA = "0xA67920", Offset = "0xA66720", Length = "0x48A")]
	private void MaybeFadeOutIndividualDamageEvents()
	{
	}

	[Token(Token = "0x600349D")]
	[Address(RVA = "0xA67DB0", Offset = "0xA66BB0", Length = "0x28")]
	private void UpdateDamageEventFade()
	{
	}

	[Token(Token = "0x600349E")]
	[Address(RVA = "0xA67DE0", Offset = "0xA66BE0", Length = "0x1F")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600349F")]
	[Address(RVA = "0xA67E00", Offset = "0xA66C00", Length = "0x37A")]
	private void SetUpConditionTween()
	{
	}

	[Token(Token = "0x60034A0")]
	[Address(RVA = "0xA68180", Offset = "0xA66F80", Length = "0x2B1")]
	private void ToggleConditionTween(bool toggle)
	{
	}

	[Token(Token = "0x60034A1")]
	[Address(RVA = "0xA68440", Offset = "0xA67240", Length = "0x498")]
	private void UpdateBuffCapacityIcon(bool isEncumbered)
	{
	}

	[Token(Token = "0x60034A2")]
	[Address(RVA = "0xA688E0", Offset = "0xA676E0", Length = "0x2A")]
	private void SetupPopupPanels()
	{
	}

	[Token(Token = "0x60034A3")]
	[Address(RVA = "0xA68910", Offset = "0xA67710", Length = "0x650")]
	private void UpdatePopupPanels()
	{
	}

	[Token(Token = "0x60034A4")]
	[Address(RVA = "0xA68F70", Offset = "0xA67D70", Length = "0xA5")]
	private void MaybeHideCurrentMissionDisplay()
	{
	}

	[Token(Token = "0x60034A5")]
	[Address(RVA = "0xA69020", Offset = "0xA67E20", Length = "0x133")]
	private void SetCurrentMissionDisplay(string missionName, string objectives)
	{
	}

	[Token(Token = "0x60034A6")]
	[Address(RVA = "0xA69160", Offset = "0xA67F60", Length = "0x13C")]
	private void ShowCurrentMissionDisplay(bool show)
	{
	}

	[Token(Token = "0x60034A7")]
	[Address(RVA = "0xA692A0", Offset = "0xA680A0", Length = "0x130")]
	private void UpdateCurrentMissionDisplay()
	{
	}

	[Token(Token = "0x60034A8")]
	[Address(RVA = "0xA693D0", Offset = "0xA681D0", Length = "0xC7F")]
	private void UpdateCurrentNPCCondition()
	{
	}

	[Token(Token = "0x60034A9")]
	[Address(RVA = "0xA6A050", Offset = "0xA68E50", Length = "0x270")]
	private bool IsPackMoraleMeterIdle()
	{
		return false;
	}

	[Token(Token = "0x60034AA")]
	[Address(RVA = "0xA6A2D0", Offset = "0xA690D0", Length = "0x1E3")]
	private void SetMoraleMeterState(MoraleMeterState state)
	{
	}

	[Token(Token = "0x60034AB")]
	[Address(RVA = "0xA6A4C0", Offset = "0xA692C0", Length = "0x6D")]
	private bool IsMoraleMeterOptionEnabled()
	{
		return false;
	}

	[Token(Token = "0x60034AC")]
	[Address(RVA = "0xA6A530", Offset = "0xA69330", Length = "0x53A")]
	private void UpdatePackMorale()
	{
	}

	[Token(Token = "0x60034AD")]
	[Address(RVA = "0xA6AA70", Offset = "0xA69870", Length = "0x22D")]
	private void UpdateNowhereToHideEvent()
	{
	}

	[Token(Token = "0x60034AE")]
	[Address(RVA = "0xA6ACA0", Offset = "0xA69AA0", Length = "0x3F8")]
	private void UpdateRespiratorMeter()
	{
	}

	[Token(Token = "0x60034AF")]
	[Address(RVA = "0xA6B0A0", Offset = "0xA69EA0", Length = "0x24B")]
	private void UpdateSuffocatingMeter()
	{
	}

	[Token(Token = "0x60034B0")]
	[Address(RVA = "0xA6B2F0", Offset = "0xA6A0F0", Length = "0x407")]
	private void UpdateSafehouse()
	{
	}

	[Token(Token = "0x60034B1")]
	[Address(RVA = "0xA6B700", Offset = "0xA6A500", Length = "0x57")]
	public void QuietlyResetTimberWolfCombatMusic()
	{
	}

	[Token(Token = "0x60034B2")]
	[Address(RVA = "0xA6B760", Offset = "0xA6A560", Length = "0xBD")]
	public void ForceCurrentMissionDisplayUpdate()
	{
	}

	[Token(Token = "0x60034B3")]
	[Address(RVA = "0xA6B820", Offset = "0xA6A620", Length = "0x1FF")]
	public string GetDisplayedMissionId()
	{
		return null;
	}

	[Token(Token = "0x60034B4")]
	[Address(RVA = "0xA6BA20", Offset = "0xA6A820", Length = "0xD8")]
	private bool ShouldShowAfflictionSprite()
	{
		return false;
	}

	[Token(Token = "0x60034B5")]
	[Address(RVA = "0xA6BB00", Offset = "0xA6A900", Length = "0x10D")]
	private bool ShouldShowAfflictionRiskSprite()
	{
		return false;
	}

	[Token(Token = "0x60034B6")]
	[Address(RVA = "0xA6BC10", Offset = "0xA6AA10", Length = "0x15F")]
	public void OnControllerScheme(bool isController)
	{
	}

	[Token(Token = "0x60034B7")]
	[Address(RVA = "0xA6BD70", Offset = "0xA6AB70", Length = "0x160")]
	private void UpdateEnvironmentStateIconVisibility()
	{
	}

	[Token(Token = "0x60034B8")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[Token(Token = "0x60034B9")]
	[Address(RVA = "0xA6BEE0", Offset = "0xA6ACE0", Length = "0x173")]
	public void ShowCreditsCenter(string msg, float tweenDuration, float waitDuration)
	{
	}

	[Token(Token = "0x60034BA")]
	[Address(RVA = "0xA6C060", Offset = "0xA6AE60", Length = "0x3A9")]
	public void ShowCreditsSide(string msgTop, string msgCenter, string msgBottom, float waitDuration)
	{
	}

	[Token(Token = "0x60034BB")]
	[Address(RVA = "0xA6C410", Offset = "0xA6B210", Length = "0x1C2")]
	private void ShowQueuedCredits(CreditsQueueInfo creditsInfo)
	{
	}

	[Token(Token = "0x60034BC")]
	[Address(RVA = "0xA6C5E0", Offset = "0xA6B3E0", Length = "0x13F")]
	private void ShowQueuedCreditsCenter(string msg)
	{
	}

	[Token(Token = "0x60034BD")]
	[Address(RVA = "0xA6C720", Offset = "0xA6B520", Length = "0x1B1")]
	private void ShowQueuedCreditsSide(string msgTop, string msgCenter, string msgBottom)
	{
	}

	[Token(Token = "0x60034BE")]
	[Address(RVA = "0xA6C8E0", Offset = "0xA6B6E0", Length = "0x77")]
	public void HideCredits()
	{
	}

	[Token(Token = "0x60034BF")]
	[Address(RVA = "0xA6C960", Offset = "0xA6B760", Length = "0x21D")]
	private void UpdateCredits()
	{
	}

	[Token(Token = "0x60034C0")]
	[Address(RVA = "0xA6CB80", Offset = "0xA6B980", Length = "0x5A")]
	private void UpdateScentIndicator()
	{
	}

	[Token(Token = "0x60034C1")]
	[Address(RVA = "0xA6CBE0", Offset = "0xA6B9E0", Length = "0x606")]
	public Panel_HUD()
	{
	}
}

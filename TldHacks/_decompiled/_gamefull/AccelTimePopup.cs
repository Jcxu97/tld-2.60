using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20005C4")]
public class AccelTimePopup : MonoBehaviour
{
	[Token(Token = "0x20005C5")]
	private class GenericTimeAcceleratorProvider : IAccelerateTimeProvider
	{
		[Token(Token = "0x4003552")]
		[FieldOffset(Offset = "0x10")]
		public Func<bool> m_IsAcceleratingTime;

		[Token(Token = "0x4003553")]
		[FieldOffset(Offset = "0x18")]
		public Func<string> m_GetActionText;

		[Token(Token = "0x4003554")]
		[FieldOffset(Offset = "0x20")]
		public Func<string> m_GetSpriteName;

		[Token(Token = "0x4003555")]
		[FieldOffset(Offset = "0x28")]
		public Func<Action> m_GetCancelAction;

		[Token(Token = "0x6002CAC")]
		[Address(RVA = "0x93AB50", Offset = "0x939950", Length = "0x1B")]
		public bool IsAcceleratingTime()
		{
			return false;
		}

		[Token(Token = "0x6002CAD")]
		[Address(RVA = "0x93AB70", Offset = "0x939970", Length = "0x1B")]
		public string GetActionText()
		{
			return null;
		}

		[Token(Token = "0x6002CAE")]
		[Address(RVA = "0x93AB90", Offset = "0x939990", Length = "0x1B")]
		public string GetSpriteName()
		{
			return null;
		}

		[Token(Token = "0x6002CAF")]
		[Address(RVA = "0x93ABB0", Offset = "0x9399B0", Length = "0x1B")]
		public Action GetCancelAction()
		{
			return null;
		}

		[Token(Token = "0x6002CB0")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		public UIRect GetElementToFade()
		{
			return null;
		}

		[Token(Token = "0x6002CB1")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		public UIProgressBar GetActionProgress()
		{
			return null;
		}

		[Token(Token = "0x6002CB2")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		public bool ShowCameraEffects()
		{
			return false;
		}

		[Token(Token = "0x6002CB3")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public GenericTimeAcceleratorProvider()
		{
		}
	}

	[HideInInspector]
	[Token(Token = "0x4003533")]
	[FieldOffset(Offset = "0x20")]
	public RopeAnchorPoint m_ActiveRopeAnchorPoint;

	[Token(Token = "0x4003534")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_Label_Action;

	[Token(Token = "0x4003535")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_Label_Message;

	[Token(Token = "0x4003536")]
	[FieldOffset(Offset = "0x38")]
	public UISprite m_Sprite_Action;

	[Token(Token = "0x4003537")]
	[FieldOffset(Offset = "0x40")]
	public UIProgressBar m_Slider;

	[SerializeField]
	[Token(Token = "0x4003538")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_Vignette;

	[Token(Token = "0x4003539")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_RestingObject;

	[Token(Token = "0x400353A")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_ActionObject;

	[Token(Token = "0x400353B")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_BackButtonObject;

	[Tooltip("These values are for the fade on all screens except Rest and Forage")]
	[Token(Token = "0x400353C")]
	[FieldOffset(Offset = "0x68")]
	public float m_NonFullFadeValue;

	[Tooltip("These values are for the fade on all screens except Rest and Forage")]
	[Token(Token = "0x400353D")]
	[FieldOffset(Offset = "0x6C")]
	public float m_NonFullFadeDuration;

	[Header("Time Widget")]
	[Token(Token = "0x400353E")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_TimeWidgetPos;

	[Header("Icons")]
	[Token(Token = "0x400353F")]
	[FieldOffset(Offset = "0x78")]
	public string m_IconNameDeployingRope;

	[Token(Token = "0x4003540")]
	[FieldOffset(Offset = "0x80")]
	public string m_IconNameTakingRope;

	[Token(Token = "0x4003541")]
	[FieldOffset(Offset = "0x88")]
	public string m_IconNameMappingLocalArea;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003542")]
	[FieldOffset(Offset = "0x90")]
	private Panel_HUD m_HUD;

	[SerializeField]
	[Token(Token = "0x4003543")]
	[FieldOffset(Offset = "0x98")]
	private PanelReference<Panel_GenericProgressBar> m_ProgressBar;

	[Token(Token = "0x4003544")]
	[FieldOffset(Offset = "0xA0")]
	private Action m_CancelCallback;

	[Token(Token = "0x4003545")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_Active;

	[Token(Token = "0x4003546")]
	[FieldOffset(Offset = "0xB0")]
	private UIProgressBar m_SliderFromPanel;

	[Token(Token = "0x4003547")]
	[FieldOffset(Offset = "0xB8")]
	private UIRect m_ElementToFade;

	[Token(Token = "0x4003548")]
	[FieldOffset(Offset = "0xC0")]
	private float m_MessageDuration;

	[Token(Token = "0x4003549")]
	[FieldOffset(Offset = "0xC4")]
	private float m_MessageFadeDuration;

	[Token(Token = "0x400354A")]
	[FieldOffset(Offset = "0xC8")]
	private float m_MessageTimer;

	[Token(Token = "0x400354B")]
	[FieldOffset(Offset = "0xCC")]
	private float m_MessageStartFadeoutTime;

	[Token(Token = "0x400354C")]
	[FieldOffset(Offset = "0xD0")]
	private float m_MessageDelay;

	[Token(Token = "0x400354D")]
	[FieldOffset(Offset = "0xD4")]
	private bool m_IsPassTimeUISuppressed;

	[Token(Token = "0x400354E")]
	[FieldOffset(Offset = "0xD5")]
	private bool m_ShowCameraEffects;

	[Token(Token = "0x400354F")]
	[FieldOffset(Offset = "0xD8")]
	private List<IAccelerateTimeProvider> m_accelerators;

	[Token(Token = "0x4003550")]
	[FieldOffset(Offset = "0xE0")]
	private List<IAccelerateTimeProvider> m_nonPanelAccelerators;

	[Token(Token = "0x4003551")]
	[FieldOffset(Offset = "0xE8")]
	private IAccelerateTimeProvider m_activeAccelerator;

	[Token(Token = "0x6002C9A")]
	[Address(RVA = "0x9385C0", Offset = "0x9373C0", Length = "0xDF2")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002C9B")]
	[Address(RVA = "0x9393C0", Offset = "0x9381C0", Length = "0x14")]
	private void ForceDisable()
	{
	}

	[Token(Token = "0x6002C9C")]
	[Address(RVA = "0x9393E0", Offset = "0x9381E0", Length = "0x2AF")]
	private void Update()
	{
	}

	[Token(Token = "0x6002C9D")]
	[Address(RVA = "0x939690", Offset = "0x938490", Length = "0xD62")]
	public void SetActive(bool active, bool fadeIn)
	{
	}

	[Token(Token = "0x6002C9E")]
	[Address(RVA = "0x93A400", Offset = "0x939200", Length = "0xC7")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6002C9F")]
	[Address(RVA = "0x835870", Offset = "0x834670", Length = "0x8")]
	public bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x6002CA0")]
	[Address(RVA = "0x93A4D0", Offset = "0x9392D0", Length = "0x175")]
	public void SetLabelMessageLocIdAndDuration(string localizationId, float duration, float fadeduration, float delay)
	{
	}

	[Token(Token = "0x6002CA1")]
	[Address(RVA = "0x93A650", Offset = "0x939450", Length = "0x100")]
	public void EnableLabelMessage(bool enabled)
	{
	}

	[Token(Token = "0x6002CA2")]
	[Address(RVA = "0x93A760", Offset = "0x939560", Length = "0xFA")]
	public bool IsLabelMessageActive()
	{
		return false;
	}

	[Token(Token = "0x6002CA3")]
	[Address(RVA = "0x93A860", Offset = "0x939660", Length = "0x7")]
	public void SupressPassTimeUI(bool isSuppressed)
	{
	}

	[Token(Token = "0x6002CA4")]
	[Address(RVA = "0x93A870", Offset = "0x939670", Length = "0x8")]
	public bool IsPassTimeUISuppressed()
	{
		return false;
	}

	[Token(Token = "0x6002CA5")]
	[Address(RVA = "0x93A880", Offset = "0x939680", Length = "0x57")]
	private static PlayerControlMode GetControlMode()
	{
		return default(PlayerControlMode);
	}

	[Token(Token = "0x6002CA6")]
	[Address(RVA = "0x93A8E0", Offset = "0x9396E0", Length = "0x16F")]
	public AccelTimePopup()
	{
	}
}

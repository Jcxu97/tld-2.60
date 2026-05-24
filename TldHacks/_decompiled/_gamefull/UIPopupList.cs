using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Scroll Popup List")]
[Token(Token = "0x2000089")]
public class UIPopupList : UIWidgetContainer
{
	[Token(Token = "0x200008A")]
	public enum Position
	{
		[Token(Token = "0x40004F0")]
		Auto,
		[Token(Token = "0x40004F1")]
		Above,
		[Token(Token = "0x40004F2")]
		Below
	}

	[Token(Token = "0x200008B")]
	public enum OpenOn
	{
		[Token(Token = "0x40004F4")]
		ClickOrTap,
		[Token(Token = "0x40004F5")]
		RightClick,
		[Token(Token = "0x40004F6")]
		DoubleClick,
		[Token(Token = "0x40004F7")]
		Manual
	}

	[Token(Token = "0x200008C")]
	public delegate void LegacyEvent(string val);

	[CompilerGenerated]
	[Token(Token = "0x200008D")]
	private sealed class _003CCloseIfUnselected_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0x20")]
		public UIPopupList _003C_003E4__this;

		[Token(Token = "0x1700004B")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CCloseIfUnselected_003Ed__94(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xBE3D10", Offset = "0xBE2B10", Length = "0x1E9")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xBE3F00", Offset = "0xBE2D00", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x200008E")]
	private sealed class _003CUpdateTweenPosition_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004FB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0x20")]
		public UIPopupList _003C_003E4__this;

		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0x28")]
		private TweenPosition _003Ctp_003E5__2;

		[Token(Token = "0x1700004D")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CUpdateTweenPosition_003Ed__79(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xBE3F40", Offset = "0xBE2D40", Length = "0x349")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xBE4290", Offset = "0xBE3090", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004C8")]
	public static UIPopupList current;

	[Token(Token = "0x40004C9")]
	private const float animSpeed = 0.15f;

	[Token(Token = "0x40004CA")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 popupWindowSize;

	[Token(Token = "0x40004CB")]
	[FieldOffset(Offset = "0x28")]
	public UIAtlas atlas;

	[Token(Token = "0x40004CC")]
	[FieldOffset(Offset = "0x30")]
	public UIFont bitmapFont;

	[Token(Token = "0x40004CD")]
	[FieldOffset(Offset = "0x38")]
	public Font trueTypeFont;

	[Token(Token = "0x40004CE")]
	[FieldOffset(Offset = "0x40")]
	public int fontSize;

	[Token(Token = "0x40004CF")]
	[FieldOffset(Offset = "0x44")]
	public FontStyle fontStyle;

	[Token(Token = "0x40004D0")]
	[FieldOffset(Offset = "0x48")]
	public string backgroundSprite;

	[Token(Token = "0x40004D1")]
	[FieldOffset(Offset = "0x50")]
	public string highlightSprite;

	[Token(Token = "0x40004D2")]
	[FieldOffset(Offset = "0x58")]
	public Position position;

	[Token(Token = "0x40004D3")]
	[FieldOffset(Offset = "0x5C")]
	public NGUIText.Alignment alignment;

	[Token(Token = "0x40004D4")]
	[FieldOffset(Offset = "0x60")]
	public List<string> items;

	[Token(Token = "0x40004D5")]
	[FieldOffset(Offset = "0x68")]
	public List<object> itemData;

	[Token(Token = "0x40004D6")]
	[FieldOffset(Offset = "0x70")]
	public Vector2 padding;

	[Token(Token = "0x40004D7")]
	[FieldOffset(Offset = "0x78")]
	public Color textColor;

	[Token(Token = "0x40004D8")]
	[FieldOffset(Offset = "0x88")]
	public Color backgroundColor;

	[Token(Token = "0x40004D9")]
	[FieldOffset(Offset = "0x98")]
	public Color highlightColor;

	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0xA8")]
	public bool isAnimated;

	[Token(Token = "0x40004DB")]
	[FieldOffset(Offset = "0xA9")]
	public bool isLocalized;

	[Token(Token = "0x40004DC")]
	[FieldOffset(Offset = "0xAC")]
	public OpenOn openOn;

	[Token(Token = "0x40004DD")]
	[FieldOffset(Offset = "0xB0")]
	public List<EventDelegate> onChange;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004DE")]
	[FieldOffset(Offset = "0xB8")]
	private string mSelectedItem;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004DF")]
	[FieldOffset(Offset = "0xC0")]
	private UIPanel mPanel;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004E0")]
	[FieldOffset(Offset = "0xC8")]
	private GameObject mChild;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004E1")]
	[FieldOffset(Offset = "0xD0")]
	private UISprite mBackground;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004E2")]
	[FieldOffset(Offset = "0xD8")]
	private UISprite mHighlight;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004E3")]
	[FieldOffset(Offset = "0xE0")]
	private UILabel mHighlightedLabel;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004E4")]
	[FieldOffset(Offset = "0xE8")]
	private List<UILabel> mLabelList;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004E5")]
	[FieldOffset(Offset = "0xF0")]
	private float mBgBorder;

	[NonSerialized]
	[Token(Token = "0x40004E6")]
	[FieldOffset(Offset = "0xF8")]
	private GameObject mSelection;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004E7")]
	[FieldOffset(Offset = "0x100")]
	private GameObject eventReceiver;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004E8")]
	[FieldOffset(Offset = "0x108")]
	private string functionName;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004E9")]
	[FieldOffset(Offset = "0x110")]
	private float textScale;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004EA")]
	[FieldOffset(Offset = "0x118")]
	private UIFont font;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004EB")]
	[FieldOffset(Offset = "0x120")]
	private UILabel textLabel;

	[Token(Token = "0x40004EC")]
	[FieldOffset(Offset = "0x128")]
	private LegacyEvent mLegacyEvent;

	[Token(Token = "0x40004ED")]
	[FieldOffset(Offset = "0x130")]
	private bool mUseDynamicFont;

	[Token(Token = "0x40004EE")]
	[FieldOffset(Offset = "0x131")]
	private bool mTweening;

	[Token(Token = "0x17000041")]
	public UnityEngine.Object ambigiousFont
	{
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xBDD980", Offset = "0xBDC780", Length = "0x180")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xBDDB00", Offset = "0xBDC900", Length = "0x2A4")]
		set
		{
		}
	}

	[Obsolete("Use EventDelegate.Add(popup.onChange, YourCallback) instead, and UIPopupList.current.value to determine the state")]
	[Token(Token = "0x17000042")]
	public LegacyEvent onSelectionChange
	{
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x6C49F0", Offset = "0x6C37F0", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x6C4A00", Offset = "0x6C3800", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public bool isOpen
	{
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xBDDDB0", Offset = "0xBDCBB0", Length = "0xCD")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000044")]
	public string value
	{
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x502320", Offset = "0x501120", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xBDDE80", Offset = "0xBDCC80", Length = "0x66")]
		set
		{
		}
	}

	[Token(Token = "0x17000045")]
	public object data
	{
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xBDDEF0", Offset = "0xBDCCF0", Length = "0xD6")]
		get
		{
			return null;
		}
	}

	[Obsolete("Use 'value' instead")]
	[Token(Token = "0x17000046")]
	public string selection
	{
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x502320", Offset = "0x501120", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xBDDFD0", Offset = "0xBDCDD0", Length = "0x8")]
		set
		{
		}
	}

	[Token(Token = "0x17000047")]
	private bool handleEvents
	{
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xBDDFE0", Offset = "0xBDCDE0", Length = "0xF7")]
		get
		{
			return false;
		}
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xBDE0E0", Offset = "0xBDCEE0", Length = "0xFF")]
		set
		{
		}
	}

	[Token(Token = "0x17000048")]
	private bool isValid
	{
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xBDE1E0", Offset = "0xBDCFE0", Length = "0x176")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000049")]
	private int activeFontSize
	{
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xBDE360", Offset = "0xBDD160", Length = "0x181")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700004A")]
	private float activeFontScale
	{
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xBDE4F0", Offset = "0xBDD2F0", Length = "0x1A7")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0xBDE6A0", Offset = "0xBDD4A0", Length = "0x9F")]
	public void Clear()
	{
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0xBDE740", Offset = "0xBDD540", Length = "0x100")]
	public void AddItem(string text)
	{
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0xBDE850", Offset = "0xBDD650", Length = "0x113")]
	public void AddItem(string text, object data)
	{
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0xBDE970", Offset = "0xBDD770", Length = "0xD2")]
	public void RemoveItem(string text)
	{
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0xBDEA50", Offset = "0xBDD850", Length = "0xD2")]
	public void RemoveItemByData(object data)
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0xBDEB30", Offset = "0xBDD930", Length = "0x385")]
	protected void TriggerCallbacks()
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0xBDEEC0", Offset = "0xBDDCC0", Length = "0x5BA")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0xBDF480", Offset = "0xBDE280", Length = "0x419")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0xBDF8A0", Offset = "0xBDE6A0", Length = "0x323")]
	private void Start()
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0xBDFBD0", Offset = "0xBDE9D0", Length = "0x11")]
	private void OnLocalize()
	{
	}

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0xBDFBF0", Offset = "0xBDE9F0", Length = "0x2BF")]
	private void Highlight(UILabel lbl, bool instant)
	{
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0xBDFEB0", Offset = "0xBDECB0", Length = "0x354")]
	private Vector3 GetHighlightPosition()
	{
		return default(Vector3);
	}

	[IteratorStateMachine(typeof(_003CUpdateTweenPosition_003Ed__79))]
	[Token(Token = "0x60004C8")]
	[Address(RVA = "0xBE0210", Offset = "0xBDF010", Length = "0x9A")]
	private IEnumerator UpdateTweenPosition()
	{
		return null;
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0xBE02B0", Offset = "0xBDF0B0", Length = "0x79")]
	private void OnItemHover(GameObject go, bool isOver)
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0xBE0330", Offset = "0xBDF130", Length = "0x19D")]
	private void Select(UILabel lbl, bool instant)
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0xBE04D0", Offset = "0xBDF2D0", Length = "0x79")]
	private void OnItemPress(GameObject go, bool isPressed)
	{
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0xBE0550", Offset = "0xBDF350", Length = "0x7")]
	private void OnItemClick(GameObject go)
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0xBE0560", Offset = "0xBDF360", Length = "0x2D8")]
	private void OnKey(KeyCode key)
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0xBE0550", Offset = "0xBDF350", Length = "0x7")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0xBE0840", Offset = "0xBDF640", Length = "0xC")]
	private void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0xBE0850", Offset = "0xBDF650", Length = "0x6FF")]
	public void Close()
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0xBE0F50", Offset = "0xBDFD50", Length = "0x15D")]
	private void AnimateColor(UIWidget widget)
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0xBE10B0", Offset = "0xBDFEB0", Length = "0x223")]
	private void AnimatePosition(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0xBE12E0", Offset = "0xBE00E0", Length = "0x34C")]
	private void AnimateScale(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0xBE1630", Offset = "0xBE0430", Length = "0x58")]
	private void Animate(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0xBE1690", Offset = "0xBE0490", Length = "0x81")]
	private void OnClick()
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0xBE1720", Offset = "0xBE0520", Length = "0x11")]
	private void OnDoubleClick()
	{
	}

	[IteratorStateMachine(typeof(_003CCloseIfUnselected_003Ed__94))]
	[Token(Token = "0x60004D7")]
	[Address(RVA = "0xBE1740", Offset = "0xBE0540", Length = "0x9A")]
	private IEnumerator CloseIfUnselected()
	{
		return null;
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0xBE17E0", Offset = "0xBE05E0", Length = "0x21A1")]
	public void Show()
	{
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0xBE3990", Offset = "0xBE2790", Length = "0x371")]
	public UIPopupList()
	{
	}
}

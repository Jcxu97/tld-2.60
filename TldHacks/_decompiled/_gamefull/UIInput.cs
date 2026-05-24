using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Input Field")]
[Token(Token = "0x200010D")]
public class UIInput : MonoBehaviour
{
	[Token(Token = "0x200010E")]
	public enum InputType
	{
		[Token(Token = "0x4000857")]
		Standard,
		[Token(Token = "0x4000858")]
		AutoCorrect,
		[Token(Token = "0x4000859")]
		Password
	}

	[Token(Token = "0x200010F")]
	public enum Validation
	{
		[Token(Token = "0x400085B")]
		None,
		[Token(Token = "0x400085C")]
		Integer,
		[Token(Token = "0x400085D")]
		Float,
		[Token(Token = "0x400085E")]
		Alphanumeric,
		[Token(Token = "0x400085F")]
		Username,
		[Token(Token = "0x4000860")]
		Name
	}

	[Token(Token = "0x2000110")]
	public enum KeyboardType
	{
		[Token(Token = "0x4000862")]
		Default,
		[Token(Token = "0x4000863")]
		ASCIICapable,
		[Token(Token = "0x4000864")]
		NumbersAndPunctuation,
		[Token(Token = "0x4000865")]
		URL,
		[Token(Token = "0x4000866")]
		NumberPad,
		[Token(Token = "0x4000867")]
		PhonePad,
		[Token(Token = "0x4000868")]
		NamePhonePad,
		[Token(Token = "0x4000869")]
		EmailAddress
	}

	[Token(Token = "0x2000111")]
	public enum OnReturnKey
	{
		[Token(Token = "0x400086B")]
		Default,
		[Token(Token = "0x400086C")]
		Submit,
		[Token(Token = "0x400086D")]
		NewLine
	}

	[Token(Token = "0x2000112")]
	public delegate char OnValidate(string text, int charIndex, char addedChar);

	[Token(Token = "0x4000831")]
	public static UIInput current;

	[Token(Token = "0x4000832")]
	public static UIInput selection;

	[Token(Token = "0x4000833")]
	[FieldOffset(Offset = "0x20")]
	public UILabel label;

	[Token(Token = "0x4000834")]
	[FieldOffset(Offset = "0x28")]
	public InputType inputType;

	[Token(Token = "0x4000835")]
	[FieldOffset(Offset = "0x2C")]
	public OnReturnKey onReturnKey;

	[Token(Token = "0x4000836")]
	[FieldOffset(Offset = "0x30")]
	public KeyboardType keyboardType;

	[Token(Token = "0x4000837")]
	[FieldOffset(Offset = "0x34")]
	public bool hideInput;

	[NonSerialized]
	[Token(Token = "0x4000838")]
	[FieldOffset(Offset = "0x35")]
	public bool selectAllTextOnFocus;

	[Token(Token = "0x4000839")]
	[FieldOffset(Offset = "0x38")]
	public Validation validation;

	[Token(Token = "0x400083A")]
	[FieldOffset(Offset = "0x3C")]
	public int characterLimit;

	[Token(Token = "0x400083B")]
	[FieldOffset(Offset = "0x40")]
	public string savedAs;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400083C")]
	[FieldOffset(Offset = "0x48")]
	private GameObject selectOnTab;

	[Token(Token = "0x400083D")]
	[FieldOffset(Offset = "0x50")]
	public Color activeTextColor;

	[Token(Token = "0x400083E")]
	[FieldOffset(Offset = "0x60")]
	public Color caretColor;

	[Token(Token = "0x400083F")]
	[FieldOffset(Offset = "0x70")]
	public Color selectionColor;

	[Token(Token = "0x4000840")]
	[FieldOffset(Offset = "0x80")]
	public List<EventDelegate> onSubmit;

	[Token(Token = "0x4000841")]
	[FieldOffset(Offset = "0x88")]
	public List<EventDelegate> onChange;

	[Token(Token = "0x4000842")]
	[FieldOffset(Offset = "0x90")]
	public OnValidate onValidate;

	[SerializeField]
	[HideInInspector]
	[Token(Token = "0x4000843")]
	[FieldOffset(Offset = "0x98")]
	protected string mValue;

	[NonSerialized]
	[Token(Token = "0x4000844")]
	[FieldOffset(Offset = "0xA0")]
	protected string mDefaultText;

	[NonSerialized]
	[Token(Token = "0x4000845")]
	[FieldOffset(Offset = "0xA8")]
	protected Color mDefaultColor;

	[NonSerialized]
	[Token(Token = "0x4000846")]
	[FieldOffset(Offset = "0xB8")]
	protected float mPosition;

	[NonSerialized]
	[Token(Token = "0x4000847")]
	[FieldOffset(Offset = "0xBC")]
	protected bool mDoInit;

	[NonSerialized]
	[Token(Token = "0x4000848")]
	[FieldOffset(Offset = "0xC0")]
	protected UIWidget.Pivot mPivot;

	[NonSerialized]
	[Token(Token = "0x4000849")]
	[FieldOffset(Offset = "0xC4")]
	protected bool mLoadSavedValue;

	[Token(Token = "0x400084A")]
	protected static int mDrawStart;

	[Token(Token = "0x400084B")]
	protected static string mLastIME;

	[NonSerialized]
	[Token(Token = "0x400084C")]
	[FieldOffset(Offset = "0xC8")]
	protected int mSelectionStart;

	[NonSerialized]
	[Token(Token = "0x400084D")]
	[FieldOffset(Offset = "0xCC")]
	protected int mSelectionEnd;

	[NonSerialized]
	[Token(Token = "0x400084E")]
	[FieldOffset(Offset = "0xD0")]
	protected UITexture mHighlight;

	[NonSerialized]
	[Token(Token = "0x400084F")]
	[FieldOffset(Offset = "0xD8")]
	protected UITexture mCaret;

	[NonSerialized]
	[Token(Token = "0x4000850")]
	[FieldOffset(Offset = "0xE0")]
	protected Texture2D mBlankTex;

	[NonSerialized]
	[Token(Token = "0x4000851")]
	[FieldOffset(Offset = "0xE8")]
	protected float mNextBlink;

	[NonSerialized]
	[Token(Token = "0x4000852")]
	[FieldOffset(Offset = "0xEC")]
	protected float mLastAlpha;

	[NonSerialized]
	[Token(Token = "0x4000853")]
	[FieldOffset(Offset = "0xF0")]
	protected string mCached;

	[NonSerialized]
	[Token(Token = "0x4000854")]
	[FieldOffset(Offset = "0xF8")]
	protected int mSelectMe;

	[NonSerialized]
	[Token(Token = "0x4000855")]
	[FieldOffset(Offset = "0x100")]
	private UIInputOnGUI mOnGUI;

	[Token(Token = "0x1700012C")]
	public string defaultText
	{
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x12799C0", Offset = "0x12787C0", Length = "0x33")]
		get
		{
			return null;
		}
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x1279A00", Offset = "0x1278800", Length = "0x85")]
		set
		{
		}
	}

	[Token(Token = "0x1700012D")]
	public bool inputShouldBeHidden
	{
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x1279A90", Offset = "0x1278890", Length = "0x100")]
		get
		{
			return false;
		}
	}

	[Obsolete("Use UIInput.value instead")]
	[Token(Token = "0x1700012E")]
	public string text
	{
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x1279BA0", Offset = "0x12789A0", Length = "0x33")]
		get
		{
			return null;
		}
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x1279BE0", Offset = "0x12789E0", Length = "0x8")]
		set
		{
		}
	}

	[Token(Token = "0x1700012F")]
	public string value
	{
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x1279BA0", Offset = "0x12789A0", Length = "0x33")]
		get
		{
			return null;
		}
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x1279BF0", Offset = "0x12789F0", Length = "0x19F")]
		set
		{
		}
	}

	[Obsolete("Use UIInput.isSelected instead")]
	[Token(Token = "0x17000130")]
	public bool selected
	{
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x1279D90", Offset = "0x1278B90", Length = "0x7")]
		get
		{
			return false;
		}
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x1279DA0", Offset = "0x1278BA0", Length = "0x8")]
		set
		{
		}
	}

	[Token(Token = "0x17000131")]
	public bool isSelected
	{
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x1279DB0", Offset = "0x1278BB0", Length = "0x167")]
		get
		{
			return false;
		}
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x1279F20", Offset = "0x1278D20", Length = "0x9E")]
		set
		{
		}
	}

	[Token(Token = "0x17000132")]
	public int cursorPosition
	{
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x1279FC0", Offset = "0x1278DC0", Length = "0x4D")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000985")]
		[Address(RVA = "0x127A010", Offset = "0x1278E10", Length = "0x35")]
		set
		{
		}
	}

	[Token(Token = "0x17000133")]
	public int selectionStart
	{
		[Token(Token = "0x6000986")]
		[Address(RVA = "0x127A050", Offset = "0x1278E50", Length = "0x4D")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000987")]
		[Address(RVA = "0x127A0A0", Offset = "0x1278EA0", Length = "0x35")]
		set
		{
		}
	}

	[Token(Token = "0x17000134")]
	public int selectionEnd
	{
		[Token(Token = "0x6000988")]
		[Address(RVA = "0x1279FC0", Offset = "0x1278DC0", Length = "0x4D")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000989")]
		[Address(RVA = "0x127A010", Offset = "0x1278E10", Length = "0x35")]
		set
		{
		}
	}

	[Token(Token = "0x17000135")]
	public UITexture caret
	{
		[Token(Token = "0x600098A")]
		[Address(RVA = "0x502650", Offset = "0x501450", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600098B")]
	[Address(RVA = "0x127A0E0", Offset = "0x1278EE0", Length = "0x20D")]
	public string Validate(string val)
	{
		return null;
	}

	[Token(Token = "0x600098C")]
	[Address(RVA = "0x127A2F0", Offset = "0x12790F0", Length = "0x45C")]
	private void Start()
	{
	}

	[Token(Token = "0x600098D")]
	[Address(RVA = "0x127A750", Offset = "0x1279550", Length = "0x2E8")]
	protected void Init()
	{
	}

	[Token(Token = "0x600098E")]
	[Address(RVA = "0x127AA40", Offset = "0x1279840", Length = "0x36")]
	protected void SaveToPlayerPrefs(string val)
	{
	}

	[Token(Token = "0x600098F")]
	[Address(RVA = "0x127AA80", Offset = "0x1279880", Length = "0x2DF")]
	protected virtual void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x6000990")]
	[Address(RVA = "0x127AD60", Offset = "0x1279B60", Length = "0x1E5")]
	protected void OnSelectEvent()
	{
	}

	[Token(Token = "0x6000991")]
	[Address(RVA = "0x127AF50", Offset = "0x1279D50", Length = "0x2FE")]
	protected void OnDeselectEvent()
	{
	}

	[Token(Token = "0x6000992")]
	[Address(RVA = "0x127B250", Offset = "0x127A050", Length = "0xBDD")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000993")]
	[Address(RVA = "0x127BE30", Offset = "0x127AC30", Length = "0x7A")]
	protected void DoBackspace()
	{
	}

	[Token(Token = "0x6000994")]
	[Address(RVA = "0x127BEB0", Offset = "0x127ACB0", Length = "0x9D4")]
	public virtual bool ProcessEvent(Event ev)
	{
		return false;
	}

	[Token(Token = "0x6000995")]
	[Address(RVA = "0x127C8B0", Offset = "0x127B6B0", Length = "0x456")]
	protected virtual void Insert(string text)
	{
	}

	[Token(Token = "0x6000996")]
	[Address(RVA = "0x127CD10", Offset = "0x127BB10", Length = "0x77")]
	protected string GetLeftText()
	{
		return null;
	}

	[Token(Token = "0x6000997")]
	[Address(RVA = "0x127CD90", Offset = "0x127BB90", Length = "0x73")]
	protected string GetRightText()
	{
		return null;
	}

	[Token(Token = "0x6000998")]
	[Address(RVA = "0x127CE10", Offset = "0x127BC10", Length = "0x75")]
	protected string GetSelection()
	{
		return null;
	}

	[Token(Token = "0x6000999")]
	[Address(RVA = "0x127CE90", Offset = "0x127BC90", Length = "0x237")]
	protected int GetCharUnderMouse()
	{
		return 0;
	}

	[Token(Token = "0x600099A")]
	[Address(RVA = "0x127D0D0", Offset = "0x127BED0", Length = "0x1AC")]
	protected virtual void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x600099B")]
	[Address(RVA = "0x127D280", Offset = "0x127C080", Length = "0x146")]
	protected virtual void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x600099C")]
	[Address(RVA = "0x127D3D0", Offset = "0x127C1D0", Length = "0x11")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600099D")]
	[Address(RVA = "0x127D3F0", Offset = "0x127C1F0", Length = "0x2B1")]
	protected virtual void Cleanup()
	{
	}

	[Token(Token = "0x600099E")]
	[Address(RVA = "0x127D6B0", Offset = "0x127C4B0", Length = "0x333")]
	public void Submit()
	{
	}

	[Token(Token = "0x600099F")]
	[Address(RVA = "0x127D9F0", Offset = "0x127C7F0", Length = "0x1105")]
	public void UpdateLabel()
	{
	}

	[Token(Token = "0x60009A0")]
	[Address(RVA = "0x127EB00", Offset = "0x127D900", Length = "0x5C")]
	protected void SetPivotToLeft()
	{
	}

	[Token(Token = "0x60009A1")]
	[Address(RVA = "0x127EB60", Offset = "0x127D960", Length = "0x61")]
	protected void SetPivotToRight()
	{
	}

	[Token(Token = "0x60009A2")]
	[Address(RVA = "0x127EBD0", Offset = "0x127D9D0", Length = "0xEE")]
	protected void RestoreLabelPivot()
	{
	}

	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x127ECC0", Offset = "0x127DAC0", Length = "0x2B9")]
	protected char Validate(string text, int pos, char ch)
	{
		return '\0';
	}

	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x127EF80", Offset = "0x127DD80", Length = "0x269")]
	protected void ExecuteOnChange()
	{
	}

	[Token(Token = "0x60009A5")]
	[Address(RVA = "0x127F1F0", Offset = "0x127DFF0", Length = "0x61")]
	public void RemoveFocus()
	{
	}

	[Token(Token = "0x60009A6")]
	[Address(RVA = "0x127F260", Offset = "0x127E060", Length = "0x3D")]
	public void SaveValue()
	{
	}

	[Token(Token = "0x60009A7")]
	[Address(RVA = "0x127F2A0", Offset = "0x127E0A0", Length = "0x14D")]
	public void LoadValue()
	{
	}

	[Token(Token = "0x60009A8")]
	[Address(RVA = "0x127F3F0", Offset = "0x127E1F0", Length = "0x29B")]
	public UIInput()
	{
	}
}

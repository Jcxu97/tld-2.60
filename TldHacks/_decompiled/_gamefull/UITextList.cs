using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Text List")]
[Token(Token = "0x2000128")]
public class UITextList : MonoBehaviour
{
	[Token(Token = "0x2000129")]
	public enum Style
	{
		[Token(Token = "0x400093F")]
		Text,
		[Token(Token = "0x4000940")]
		Chat
	}

	[Token(Token = "0x200012A")]
	protected class Paragraph
	{
		[Token(Token = "0x4000941")]
		[FieldOffset(Offset = "0x10")]
		public string text;

		[Token(Token = "0x4000942")]
		[FieldOffset(Offset = "0x18")]
		public string[] lines;

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public Paragraph()
		{
		}
	}

	[Token(Token = "0x4000934")]
	[FieldOffset(Offset = "0x20")]
	public UILabel textLabel;

	[Token(Token = "0x4000935")]
	[FieldOffset(Offset = "0x28")]
	public UIProgressBar scrollBar;

	[Token(Token = "0x4000936")]
	[FieldOffset(Offset = "0x30")]
	public Style style;

	[Token(Token = "0x4000937")]
	[FieldOffset(Offset = "0x34")]
	public int paragraphHistory;

	[Token(Token = "0x4000938")]
	[FieldOffset(Offset = "0x38")]
	protected char[] mSeparator;

	[Token(Token = "0x4000939")]
	[FieldOffset(Offset = "0x40")]
	protected BetterList<Paragraph> mParagraphs;

	[Token(Token = "0x400093A")]
	[FieldOffset(Offset = "0x48")]
	protected float mScroll;

	[Token(Token = "0x400093B")]
	[FieldOffset(Offset = "0x4C")]
	protected int mTotalLines;

	[Token(Token = "0x400093C")]
	[FieldOffset(Offset = "0x50")]
	protected int mLastWidth;

	[Token(Token = "0x400093D")]
	[FieldOffset(Offset = "0x54")]
	protected int mLastHeight;

	[Token(Token = "0x17000193")]
	public bool isValid
	{
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x5C9910", Offset = "0x5C8710", Length = "0x189")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000194")]
	public float scrollValue
	{
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x5737C0", Offset = "0x5725C0", Length = "0x6")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x5C9AA0", Offset = "0x5C88A0", Length = "0x14E")]
		set
		{
		}
	}

	[Token(Token = "0x17000195")]
	protected float lineHeight
	{
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x5C9BF0", Offset = "0x5C89F0", Length = "0x138")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000196")]
	protected int scrollHeight
	{
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x5C9D30", Offset = "0x5C8B30", Length = "0x6A")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6000ADC")]
	[Address(RVA = "0x5C9DA0", Offset = "0x5C8BA0", Length = "0x4E")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000ADD")]
	[Address(RVA = "0x5C9DF0", Offset = "0x5C8BF0", Length = "0x2D6")]
	private void Start()
	{
	}

	[Token(Token = "0x6000ADE")]
	[Address(RVA = "0x5CA0D0", Offset = "0x5C8ED0", Length = "0x5F")]
	private void Update()
	{
	}

	[Token(Token = "0x6000ADF")]
	[Address(RVA = "0x5CA130", Offset = "0x5C8F30", Length = "0x5F")]
	public void OnScroll(float val)
	{
	}

	[Token(Token = "0x6000AE0")]
	[Address(RVA = "0x5CA190", Offset = "0x5C8F90", Length = "0x59")]
	public void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6000AE1")]
	[Address(RVA = "0x5CA1F0", Offset = "0x5C8FF0", Length = "0x94")]
	private void OnScrollBar()
	{
	}

	[Token(Token = "0x6000AE2")]
	[Address(RVA = "0x5CA290", Offset = "0x5C9090", Length = "0x14D")]
	public void Add(string text)
	{
	}

	[Token(Token = "0x6000AE3")]
	[Address(RVA = "0x5CA290", Offset = "0x5C9090", Length = "0x14D")]
	protected void Add(string text, bool updateVisible)
	{
	}

	[Token(Token = "0x6000AE4")]
	[Address(RVA = "0x5CA3E0", Offset = "0x5C91E0", Length = "0x7AC")]
	protected void Rebuild()
	{
	}

	[Token(Token = "0x6000AE5")]
	[Address(RVA = "0x5CAB90", Offset = "0x5C9990", Length = "0x26E")]
	protected void UpdateVisibleText()
	{
	}

	[Token(Token = "0x6000AE6")]
	[Address(RVA = "0x5CAE00", Offset = "0x5C9C00", Length = "0x18A")]
	public UITextList()
	{
	}
}

using System;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000593")]
public class InteractiveScrollText : MonoBehaviour
{
	[Range(0f, 1f)]
	[Token(Token = "0x4003365")]
	[FieldOffset(Offset = "0x20")]
	public float m_ControllerScrollScale;

	[Range(0.1f, 10f)]
	[Token(Token = "0x4003366")]
	[FieldOffset(Offset = "0x24")]
	public float m_KeyboardScrollScale;

	[Token(Token = "0x4003367")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_Label;

	[Token(Token = "0x4003368")]
	[FieldOffset(Offset = "0x30")]
	public UILocalize m_Localize;

	[Token(Token = "0x4003369")]
	[FieldOffset(Offset = "0x38")]
	public UIScrollView m_ScrollView;

	[SerializeField]
	[Token(Token = "0x400336A")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x400336B")]
	[FieldOffset(Offset = "0x48")]
	private bool m_FirstUpdate;

	[Token(Token = "0x400336C")]
	[FieldOffset(Offset = "0x49")]
	private bool m_EnableScrolling;

	[Token(Token = "0x400336D")]
	[FieldOffset(Offset = "0x50")]
	private Action m_OnScrollAction;

	[Token(Token = "0x6002B06")]
	[Address(RVA = "0x912460", Offset = "0x911260", Length = "0x7")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002B07")]
	[Address(RVA = "0x912470", Offset = "0x911270", Length = "0x5C8")]
	public void Update()
	{
	}

	[Token(Token = "0x6002B08")]
	[Address(RVA = "0x912A40", Offset = "0x911840", Length = "0x5")]
	public bool GetScrollingEnabled()
	{
		return false;
	}

	[Token(Token = "0x6002B09")]
	[Address(RVA = "0x6339B0", Offset = "0x6327B0", Length = "0xED7")]
	public void SetScrollingAction(Action action)
	{
	}

	[Token(Token = "0x6002B0A")]
	[Address(RVA = "0x912A50", Offset = "0x911850", Length = "0xFC")]
	public void SetScrollingEnabled(bool isEnabled)
	{
	}

	[Token(Token = "0x6002B0B")]
	[Address(RVA = "0x912B50", Offset = "0x911950", Length = "0x1BC")]
	public void RefreshLocalization()
	{
	}

	[Token(Token = "0x6002B0C")]
	[Address(RVA = "0x912D10", Offset = "0x911B10", Length = "0x3F")]
	private void Scroll(float amount)
	{
	}

	[Token(Token = "0x6002B0D")]
	[Address(RVA = "0x912D50", Offset = "0x911B50", Length = "0x47")]
	private void ScrollToBottom()
	{
	}

	[Token(Token = "0x6002B0E")]
	[Address(RVA = "0x912DA0", Offset = "0x911BA0", Length = "0x47")]
	private void ScrollToTop()
	{
	}

	[Token(Token = "0x6002B0F")]
	[Address(RVA = "0x912DF0", Offset = "0x911BF0", Length = "0xF8")]
	private void UpdateButtonDisplay()
	{
	}

	[Token(Token = "0x6002B10")]
	[Address(RVA = "0x912EF0", Offset = "0x911CF0", Length = "0x55")]
	public InteractiveScrollText()
	{
	}
}

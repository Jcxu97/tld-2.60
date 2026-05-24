using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000294")]
public class TwoButtonsChoiceUI : MonoBehaviour
{
	[Token(Token = "0x400174C")]
	[FieldOffset(Offset = "0x20")]
	public Panel_HUD m_HUD;

	[Token(Token = "0x400174D")]
	[FieldOffset(Offset = "0x28")]
	private Action<int> m_OnButtonSelected;

	[Token(Token = "0x400174E")]
	[FieldOffset(Offset = "0x30")]
	private string m_FireButtonStr;

	[Token(Token = "0x400174F")]
	[FieldOffset(Offset = "0x38")]
	private string m_AltFireButtonStr;

	[Token(Token = "0x600162B")]
	[Address(RVA = "0x6B38E0", Offset = "0x6B26E0", Length = "0x141")]
	private void Start()
	{
	}

	[Token(Token = "0x600162C")]
	[Address(RVA = "0x649950", Offset = "0x648750", Length = "0x9F")]
	public bool IsShowing()
	{
		return false;
	}

	[Token(Token = "0x600162D")]
	[Address(RVA = "0x6B3A30", Offset = "0x6B2830", Length = "0x28")]
	public bool IsManagingInput()
	{
		return false;
	}

	[Token(Token = "0x600162E")]
	[Address(RVA = "0x6B3A60", Offset = "0x6B2860", Length = "0x343")]
	public void ShowChoices(string textChoiceA, string textChoiceB, Action<int> onButtonSelected)
	{
	}

	[Token(Token = "0x600162F")]
	[Address(RVA = "0x6B3DB0", Offset = "0x6B2BB0", Length = "0x98")]
	public void HideChoices()
	{
	}

	[Token(Token = "0x6001630")]
	[Address(RVA = "0x6B3E50", Offset = "0x6B2C50", Length = "0xE9")]
	public void Update()
	{
	}

	[Token(Token = "0x6001631")]
	[Address(RVA = "0x6B3F40", Offset = "0x6B2D40", Length = "0x1AD")]
	private void RefreshChoices(bool gamepadActive)
	{
	}

	[Token(Token = "0x6001632")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TwoButtonsChoiceUI()
	{
	}
}

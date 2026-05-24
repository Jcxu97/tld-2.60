using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000248")]
public class GenericInteractionCancelUI : MonoBehaviour
{
	[Token(Token = "0x4001440")]
	[FieldOffset(Offset = "0x20")]
	public Panel_HUD m_HUD;

	[Token(Token = "0x4001441")]
	[FieldOffset(Offset = "0x28")]
	private string m_DisplayText;

	[Token(Token = "0x4001442")]
	[FieldOffset(Offset = "0x30")]
	private Action m_OnButtonSelected;

	[Token(Token = "0x600141E")]
	[Address(RVA = "0x67DC70", Offset = "0x67CA70", Length = "0x141")]
	private void Start()
	{
	}

	[Token(Token = "0x600141F")]
	[Address(RVA = "0x649950", Offset = "0x648750", Length = "0x9F")]
	private bool IsShowing()
	{
		return false;
	}

	[Token(Token = "0x6001420")]
	[Address(RVA = "0x67DDC0", Offset = "0x67CBC0", Length = "0x116")]
	public void Show(string text, Action onButtonSelected)
	{
	}

	[Token(Token = "0x6001421")]
	[Address(RVA = "0x67DEE0", Offset = "0x67CCE0", Length = "0x4B")]
	public void Hide()
	{
	}

	[Token(Token = "0x6001422")]
	[Address(RVA = "0x67DF30", Offset = "0x67CD30", Length = "0xC5")]
	public void Update()
	{
	}

	[Token(Token = "0x6001423")]
	[Address(RVA = "0x67E000", Offset = "0x67CE00", Length = "0x181")]
	private void RefreshButtonPrompt()
	{
	}

	[Token(Token = "0x6001424")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public GenericInteractionCancelUI()
	{
	}
}

using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200060D")]
public class Panel_BedRollSelect : Panel_AutoReferenced
{
	[Token(Token = "0x400387D")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x400387E")]
	[FieldOffset(Offset = "0x38")]
	public UIButton m_ButtonUseBedRoll;

	[Token(Token = "0x400387F")]
	[FieldOffset(Offset = "0x40")]
	public UIButton m_ButtonUseBearSkin;

	[Token(Token = "0x4003880")]
	[FieldOffset(Offset = "0x48")]
	public Color m_GreyoutColor;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003881")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_Actions> m_Actions;

	[Token(Token = "0x4003882")]
	[FieldOffset(Offset = "0x60")]
	private List<UIButton> m_Buttons;

	[Token(Token = "0x4003883")]
	[FieldOffset(Offset = "0x68")]
	private int m_SelectedButtonIndex;

	[Token(Token = "0x6002F5E")]
	[Address(RVA = "0x988690", Offset = "0x987490", Length = "0x159")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6002F5F")]
	[Address(RVA = "0x9887F0", Offset = "0x9875F0", Length = "0x2AF")]
	private void Update()
	{
	}

	[Token(Token = "0x6002F60")]
	[Address(RVA = "0x988AA0", Offset = "0x9878A0", Length = "0x3D9")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6002F61")]
	[Address(RVA = "0x988E80", Offset = "0x987C80", Length = "0xD0")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6002F62")]
	[Address(RVA = "0x988F60", Offset = "0x987D60", Length = "0x2D0")]
	public void OnUseBedRoll()
	{
	}

	[Token(Token = "0x6002F63")]
	[Address(RVA = "0x989240", Offset = "0x988040", Length = "0x2D0")]
	public void OnUseBearSkin()
	{
	}

	[Token(Token = "0x6002F64")]
	[Address(RVA = "0x989520", Offset = "0x988320", Length = "0x22C")]
	private void UpdateButtonState()
	{
	}

	[Token(Token = "0x6002F65")]
	[Address(RVA = "0x989750", Offset = "0x988550", Length = "0x22D")]
	private void SetButtonColors(UIButton button, bool greyout)
	{
	}

	[Token(Token = "0x6002F66")]
	[Address(RVA = "0x989980", Offset = "0x988780", Length = "0x507")]
	private void UpdateNavigation()
	{
	}

	[Token(Token = "0x6002F67")]
	[Address(RVA = "0x989E90", Offset = "0x988C90", Length = "0xF5")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6002F68")]
	[Address(RVA = "0x989F90", Offset = "0x988D90", Length = "0x16F")]
	public Panel_BedRollSelect()
	{
	}
}

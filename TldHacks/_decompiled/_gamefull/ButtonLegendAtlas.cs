using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200020B")]
public class ButtonLegendAtlas : ScriptableObject
{
	[Token(Token = "0x400127F")]
	[FieldOffset(Offset = "0x18")]
	public UIAtlas m_ButtonIconAtlasXbox;

	[Token(Token = "0x4001280")]
	[FieldOffset(Offset = "0x20")]
	public UIAtlas m_ButtonIconAtlasSteam;

	[Token(Token = "0x4001281")]
	[FieldOffset(Offset = "0x28")]
	public UIAtlas m_ButtonIconAtlasPS4;

	[Token(Token = "0x4001282")]
	[FieldOffset(Offset = "0x30")]
	public UIAtlas m_ButtonIconAtlasSwitch;

	[Token(Token = "0x4001283")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<string, ButtonIcon> m_ButtonIconsDictionaryXbox;

	[Token(Token = "0x4001284")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<string, ButtonIcon> m_ButtonIconsDictionarySteam;

	[Token(Token = "0x4001285")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<string, ButtonIcon> m_ButtonIconsDictionaryPS4;

	[Token(Token = "0x600127F")]
	[Address(RVA = "0x652DC0", Offset = "0x651BC0", Length = "0x1B9")]
	public void BuildDictionaries()
	{
	}

	[Token(Token = "0x6001280")]
	[Address(RVA = "0x652F80", Offset = "0x651D80", Length = "0x375")]
	private Dictionary<string, ButtonIcon> BuildDictionary(Dictionary<string, string> input, UIAtlas atlas)
	{
		return null;
	}

	[Token(Token = "0x6001281")]
	[Address(RVA = "0x653300", Offset = "0x652100", Length = "0x2D4")]
	private void AdjustSteamDictionary(Dictionary<string, ButtonIcon> dictionary)
	{
	}

	[Token(Token = "0x6001282")]
	[Address(RVA = "0x6535E0", Offset = "0x6523E0", Length = "0x171")]
	public ButtonIcon GetButtonIcon(string action)
	{
		return null;
	}

	[Token(Token = "0x6001283")]
	[Address(RVA = "0x653760", Offset = "0x652560", Length = "0x2B3")]
	private Dictionary<string, ButtonIcon> GetActiveDictionary()
	{
		return null;
	}

	[Token(Token = "0x6001284")]
	[Address(RVA = "0x653A20", Offset = "0x652820", Length = "0x1B2")]
	public ButtonLegendAtlas()
	{
	}
}

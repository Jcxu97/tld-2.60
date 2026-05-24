using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using UnityEngine;

[Token(Token = "0x20006CA")]
public class Panel_SelectSurvivor : Panel_AutoReferenced
{
	[Token(Token = "0x400484E")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Header("Menu")]
	[Token(Token = "0x400484F")]
	[FieldOffset(Offset = "0x38")]
	public string m_HeaderTitleLocalizationId;

	[Token(Token = "0x4004850")]
	[FieldOffset(Offset = "0x40")]
	public string m_TitleLocalizationId;

	[Token(Token = "0x4004851")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 m_TitleHeaderOffset;

	[Token(Token = "0x4004852")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_BasicMenuRoot;

	[Token(Token = "0x4004853")]
	[FieldOffset(Offset = "0x60")]
	private BasicMenu m_BasicMenu;

	[Token(Token = "0x4004854")]
	[FieldOffset(Offset = "0x68")]
	public List<VoicePersona> m_MenuItems;

	[Token(Token = "0x4004855")]
	[FieldOffset(Offset = "0x70")]
	public List<GameObject> m_ItemDetails;

	[Token(Token = "0x6003B80")]
	[Address(RVA = "0xB64AF0", Offset = "0xB638F0", Length = "0x11B")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003B81")]
	[Address(RVA = "0xB64C10", Offset = "0xB63A10", Length = "0x1DA")]
	private void Update()
	{
	}

	[Token(Token = "0x6003B82")]
	[Address(RVA = "0xB64DF0", Offset = "0xB63BF0", Length = "0x346")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[Token(Token = "0x6003B83")]
	[Address(RVA = "0xB65140", Offset = "0xB63F40", Length = "0x703")]
	private void ConfigureMenu()
	{
	}

	[Token(Token = "0x6003B84")]
	[Address(RVA = "0xB65850", Offset = "0xB64650", Length = "0x1BE")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003B85")]
	[Address(RVA = "0xB65A10", Offset = "0xB64810", Length = "0x1A5")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6003B86")]
	[Address(RVA = "0xB65BC0", Offset = "0xB649C0", Length = "0xA")]
	public void OnSelectSurvivorMale()
	{
	}

	[Token(Token = "0x6003B87")]
	[Address(RVA = "0xB65BD0", Offset = "0xB649D0", Length = "0xC")]
	public void OnSelectSurvivorFemale()
	{
	}

	[Token(Token = "0x6003B88")]
	[Address(RVA = "0xB65BE0", Offset = "0xB649E0", Length = "0x1E6")]
	private void OnSelectSurvivor(VoicePersona voicePersona)
	{
	}

	[Token(Token = "0x6003B89")]
	[Address(RVA = "0xB65DD0", Offset = "0xB64BD0", Length = "0x25A")]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Token(Token = "0x6003B8A")]
	[Address(RVA = "0xB66030", Offset = "0xB64E30", Length = "0xF5")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003B8B")]
	[Address(RVA = "0xB66130", Offset = "0xB64F30", Length = "0x88")]
	private void RestoreSelection()
	{
	}

	[Token(Token = "0x6003B8C")]
	[Address(RVA = "0xB661C0", Offset = "0xB64FC0", Length = "0xC3")]
	public Panel_SelectSurvivor()
	{
	}
}

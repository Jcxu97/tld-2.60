using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;

[Token(Token = "0x2000293")]
public class ToolsList : MonoBehaviour
{
	[Token(Token = "0x400173E")]
	[FieldOffset(Offset = "0x20")]
	public ScrollList m_ToolScrollList;

	[Token(Token = "0x400173F")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_Tool_ConditionSprite;

	[Token(Token = "0x4001740")]
	[FieldOffset(Offset = "0x30")]
	public UISprite m_Tool_ConditionBarBG;

	[Token(Token = "0x4001741")]
	[FieldOffset(Offset = "0x38")]
	public UISprite m_Tool_ConditionBarFG;

	[Token(Token = "0x4001742")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_SelectedToolName_Label;

	[Token(Token = "0x4001743")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_Tool_Condition_Label;

	[Token(Token = "0x4001744")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_Button_ToolIncrease;

	[Token(Token = "0x4001745")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_Button_ToolDecrease;

	[Token(Token = "0x4001746")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_ToolMissing;

	[Token(Token = "0x4001747")]
	[FieldOffset(Offset = "0x68")]
	public Color m_NoToolSpriteColor;

	[Token(Token = "0x4001748")]
	[FieldOffset(Offset = "0x78")]
	public Color m_HighConditionColor;

	[Token(Token = "0x4001749")]
	[FieldOffset(Offset = "0x88")]
	public string m_NoToolSpriteName;

	[Token(Token = "0x400174A")]
	[FieldOffset(Offset = "0x90")]
	public Vector3 m_NoToolSpriteSizeModifier;

	[Token(Token = "0x400174B")]
	[FieldOffset(Offset = "0xA0")]
	private List<GameObject> m_Tools;

	[Token(Token = "0x6001622")]
	[Address(RVA = "0x6B1B00", Offset = "0x6B0900", Length = "0x13E9")]
	public void RefreshTools(IRepairable repairable, GearItem gearItem)
	{
	}

	[Token(Token = "0x6001623")]
	[Address(RVA = "0x6B2EF0", Offset = "0x6B1CF0", Length = "0x4B7")]
	public void RefreshSelectedActionTool()
	{
	}

	[Token(Token = "0x6001624")]
	[Address(RVA = "0x6B33B0", Offset = "0x6B21B0", Length = "0x6A")]
	public void OnToolIncrease()
	{
	}

	[Token(Token = "0x6001625")]
	[Address(RVA = "0x6B3420", Offset = "0x6B2220", Length = "0x6A")]
	public void OnToolDecrease()
	{
	}

	[Token(Token = "0x6001626")]
	[Address(RVA = "0x6B3490", Offset = "0x6B2290", Length = "0x44")]
	public int GetToolsCount()
	{
		return 0;
	}

	[Token(Token = "0x6001627")]
	[Address(RVA = "0x6B34E0", Offset = "0x6B22E0", Length = "0xC3")]
	public GameObject GetSelectedTool()
	{
		return null;
	}

	[Token(Token = "0x6001628")]
	[Address(RVA = "0x6B35B0", Offset = "0x6B23B0", Length = "0x157")]
	public void UpdateActionToolSelect(MonoBehaviour context, Action BackAction, Action SelectAction)
	{
	}

	[Token(Token = "0x6001629")]
	[Address(RVA = "0x6B3710", Offset = "0x6B2510", Length = "0xC6")]
	public void UpdateToolHorizontalMovement(MonoBehaviour context)
	{
	}

	[Token(Token = "0x600162A")]
	[Address(RVA = "0x6B37E0", Offset = "0x6B25E0", Length = "0xF2")]
	public ToolsList()
	{
	}
}

using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000208")]
public class ButtonLegendContainer
{
	[Token(Token = "0x400126C")]
	[FieldOffset(Offset = "0x10")]
	public GameObject m_ButtonLegendParent;

	[Token(Token = "0x400126D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject m_ButtonLegendParentPrefab;

	[Token(Token = "0x400126E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_ButtonLegendPrefab;

	[Token(Token = "0x400126F")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_Parent;

	[HideInInspector]
	[Token(Token = "0x4001270")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegend m_ButtonLegend;

	[Token(Token = "0x4001271")]
	[FieldOffset(Offset = "0x38")]
	public bool m_OverrideDepth;

	[Token(Token = "0x4001272")]
	[FieldOffset(Offset = "0x3C")]
	public int m_Depth;

	[Token(Token = "0x4001273")]
	private static Dictionary<GameObject, ButtonLegendContainer> m_OwnerDictionnary;

	[Token(Token = "0x6001262")]
	[Address(RVA = "0x64FEB0", Offset = "0x64ECB0", Length = "0x901")]
	public void Create(GameObject owner)
	{
	}

	[Token(Token = "0x6001263")]
	[Address(RVA = "0x6507C0", Offset = "0x64F5C0", Length = "0x63")]
	public void Show(bool show)
	{
	}

	[Token(Token = "0x6001264")]
	[Address(RVA = "0x650830", Offset = "0x64F630", Length = "0xDF")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001265")]
	[Address(RVA = "0x650910", Offset = "0x64F710", Length = "0x121")]
	public void AddButton(string action, string localizationKey, int priority, bool localize = true)
	{
	}

	[Token(Token = "0x6001266")]
	[Address(RVA = "0x650A40", Offset = "0x64F840", Length = "0xF0")]
	public void RemoveButton(string action)
	{
	}

	[Token(Token = "0x6001267")]
	[Address(RVA = "0x650B40", Offset = "0x64F940", Length = "0xE0")]
	public void BeginUpdate()
	{
	}

	[Token(Token = "0x6001268")]
	[Address(RVA = "0x650C30", Offset = "0x64FA30", Length = "0x133")]
	public void UpdateButton(string action, string localizationKey, bool active, int priority, bool localize = true)
	{
	}

	[Token(Token = "0x6001269")]
	[Address(RVA = "0x650D70", Offset = "0x64FB70", Length = "0x168")]
	public void EndUpdate()
	{
	}

	[Token(Token = "0x600126A")]
	[Address(RVA = "0x650EE0", Offset = "0x64FCE0", Length = "0x1A2")]
	public void OverrideDepthOfAllItems(int depthAmount)
	{
	}

	[Token(Token = "0x600126B")]
	[Address(RVA = "0x651090", Offset = "0x64FE90", Length = "0xB")]
	public void ResetDefaultDepthOfAllItems()
	{
	}

	[Token(Token = "0x600126C")]
	[Address(RVA = "0x6510A0", Offset = "0x64FEA0", Length = "0xA5")]
	public static ButtonLegendContainer TryGetButtonLegendContainer(GameObject owner)
	{
		return null;
	}

	[Token(Token = "0x600126D")]
	[Address(RVA = "0x651150", Offset = "0x64FF50", Length = "0x8")]
	public ButtonLegendContainer()
	{
	}
}

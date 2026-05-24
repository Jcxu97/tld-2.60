using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000249")]
public class GenericInteractionPrompt : MonoBehaviour
{
	[Token(Token = "0x4001443")]
	private const int PROMPT_WARNING_COUNT = 4;

	[Token(Token = "0x4001444")]
	[FieldOffset(Offset = "0x20")]
	public ButtonPrompt m_ButtonPromptPrefab;

	[Token(Token = "0x4001445")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid m_Grid;

	[Token(Token = "0x4001446")]
	[FieldOffset(Offset = "0x30")]
	public Color m_DefaultDisabledColor;

	[Token(Token = "0x4001447")]
	[FieldOffset(Offset = "0x40")]
	private List<ButtonPrompt> m_SpawnedPrompts;

	[Token(Token = "0x4001448")]
	[FieldOffset(Offset = "0x48")]
	private bool m_CurrentInteractionState;

	[Token(Token = "0x4001449")]
	[FieldOffset(Offset = "0x49")]
	private bool m_IsEssentialInteraction;

	[Token(Token = "0x400144A")]
	[FieldOffset(Offset = "0x4C")]
	private HudDisplayMode m_HudDisplayMode;

	[Token(Token = "0x400144B")]
	[FieldOffset(Offset = "0x50")]
	private Action<bool> m_OnInputStatusChanged;

	[Token(Token = "0x400144C")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsShowing;

	[Token(Token = "0x6001425")]
	[Address(RVA = "0x67E190", Offset = "0x67CF90", Length = "0x89")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001426")]
	[Address(RVA = "0x67E220", Offset = "0x67D020", Length = "0x81")]
	public void PrepareInteraction(bool essentialInteraction = true, Action<bool> onInputStatusChanged = null)
	{
	}

	[Token(Token = "0x6001427")]
	[Address(RVA = "0x67E2B0", Offset = "0x67D0B0", Length = "0xD2")]
	public void ShowInteraction(string interactionText, string action, bool promptEnabled = true)
	{
	}

	[Token(Token = "0x6001428")]
	[Address(RVA = "0x67E390", Offset = "0x67D190", Length = "0xC9")]
	public void ShowInteraction(string interactionText, string action, Color disabledColor, bool promptEnabled = true)
	{
	}

	[Token(Token = "0x6001429")]
	[Address(RVA = "0x67E460", Offset = "0x67D260", Length = "0x3EC")]
	public void HideInteraction()
	{
	}

	[Token(Token = "0x600142A")]
	[Address(RVA = "0x67E850", Offset = "0x67D650", Length = "0x5")]
	public bool IsShowing()
	{
		return false;
	}

	[Token(Token = "0x600142B")]
	[Address(RVA = "0x67E860", Offset = "0x67D660", Length = "0x2B5")]
	public void DestroyInteraction()
	{
	}

	[Token(Token = "0x600142C")]
	[Address(RVA = "0x67EB20", Offset = "0x67D920", Length = "0x33C")]
	private ButtonPrompt GetNextFreeButtonPrompt()
	{
		return null;
	}

	[Token(Token = "0x600142D")]
	[Address(RVA = "0x67EE60", Offset = "0x67DC60", Length = "0x1C3")]
	private void Update()
	{
	}

	[Token(Token = "0x600142E")]
	[Address(RVA = "0x67F030", Offset = "0x67DE30", Length = "0x24C")]
	private void RefreshButtonPrompts()
	{
	}

	[Token(Token = "0x600142F")]
	[Address(RVA = "0x67F280", Offset = "0x67E080", Length = "0xE7")]
	public GenericInteractionPrompt()
	{
	}
}

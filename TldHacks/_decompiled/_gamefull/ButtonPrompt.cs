using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200020F")]
public class ButtonPrompt : MonoBehaviour
{
	[Token(Token = "0x4001292")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_KeyboardButtonLabel;

	[Token(Token = "0x4001293")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_KeyboardButtonSprite;

	[Token(Token = "0x4001294")]
	[FieldOffset(Offset = "0x30")]
	public UISprite m_KeyboardButtonBGSprite;

	[Token(Token = "0x4001295")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_KeyboardActionLabel;

	[Token(Token = "0x4001296")]
	[FieldOffset(Offset = "0x40")]
	public UISprite m_NonKeyboardButtonSprite;

	[Token(Token = "0x4001297")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_NonKeyboardActionLabel;

	[Token(Token = "0x4001298")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_ButtonObjectCmdClickPlace;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4001299")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[SerializeField]
	[Token(Token = "0x400129A")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x400129B")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<UIWidget, Color> m_DefaultColorsByWidget;

	[Token(Token = "0x400129C")]
	[FieldOffset(Offset = "0x70")]
	public Color m_DisabledColor;

	[Token(Token = "0x400129D")]
	[FieldOffset(Offset = "0x80")]
	private string m_PromptStr;

	[Token(Token = "0x400129E")]
	[FieldOffset(Offset = "0x88")]
	private string m_InputActionName;

	[Token(Token = "0x400129F")]
	[FieldOffset(Offset = "0x90")]
	private bool m_HasInitialized;

	[Token(Token = "0x6001291")]
	[Address(RVA = "0x6546A0", Offset = "0x6534A0", Length = "0x7")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001292")]
	[Address(RVA = "0x6546B0", Offset = "0x6534B0", Length = "0xCA")]
	public void ResetPrompt()
	{
	}

	[Token(Token = "0x6001293")]
	[Address(RVA = "0x654780", Offset = "0x653580", Length = "0x9E3")]
	public void ShowPromptForKey(string promptStr, string inputActionName, bool forceRefresh = false)
	{
	}

	[Token(Token = "0x6001294")]
	[Address(RVA = "0x655170", Offset = "0x653F70", Length = "0x45D")]
	public void ShowPromptForKeyWithDisable(string promptStr, string inputActionName, bool isPromptEnabled)
	{
	}

	[Token(Token = "0x6001295")]
	[Address(RVA = "0x6555D0", Offset = "0x6543D0", Length = "0x1F9")]
	public void UpdatePromptLabel(string promptStr)
	{
	}

	[Token(Token = "0x6001296")]
	[Address(RVA = "0x6557D0", Offset = "0x6545D0", Length = "0x28")]
	public void RefreshPrompt()
	{
	}

	[Token(Token = "0x6001297")]
	[Address(RVA = "0x655800", Offset = "0x654600", Length = "0x650")]
	private void InitializeValues()
	{
	}

	[Token(Token = "0x6001298")]
	[Address(RVA = "0x655E60", Offset = "0x654C60", Length = "0x4AD")]
	private void DisableAll()
	{
	}

	[Token(Token = "0x6001299")]
	[Address(RVA = "0x656310", Offset = "0x655110", Length = "0x53")]
	public ButtonPrompt()
	{
	}
}

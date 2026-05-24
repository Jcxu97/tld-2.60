using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20006EA")]
public class TimedActionPopup : MonoBehaviour
{
	[Token(Token = "0x40049B3")]
	[FieldOffset(Offset = "0x20")]
	public ButtonPrompt m_ButtonPrompt;

	[Token(Token = "0x40049B4")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_ProgressSprite;

	[Token(Token = "0x40049B6")]
	[FieldOffset(Offset = "0x34")]
	private InputManager.InputAction m_Action;

	[Token(Token = "0x40049B7")]
	[FieldOffset(Offset = "0x38")]
	private float m_DisplayElapsed;

	[Token(Token = "0x40049B8")]
	[FieldOffset(Offset = "0x3C")]
	private float m_DisplayTime;

	[Token(Token = "0x40049B9")]
	[FieldOffset(Offset = "0x40")]
	private float m_HoldElapsed;

	[Token(Token = "0x40049BA")]
	[FieldOffset(Offset = "0x44")]
	private float m_HoldTime;

	[Token(Token = "0x40049BB")]
	[FieldOffset(Offset = "0x48")]
	private string m_LocalizedText;

	[Token(Token = "0x40049BC")]
	[FieldOffset(Offset = "0x50")]
	private string m_PromptKey;

	[Token(Token = "0x40049BD")]
	[FieldOffset(Offset = "0x58")]
	private bool m_UpdateButton;

	[HideInInspector]
	[Token(Token = "0x17000312")]
	[field: Token(Token = "0x40049B5")]
	[field: FieldOffset(Offset = "0x30")]
	public bool m_ActionTriggered
	{
		[Token(Token = "0x6003CD0")]
		[Address(RVA = "0x5027A0", Offset = "0x5015A0", Length = "0x5")]
		get;
		[Token(Token = "0x6003CD1")]
		[Address(RVA = "0x5027B0", Offset = "0x5015B0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x6003CD2")]
	[Address(RVA = "0xB84BA0", Offset = "0xB839A0", Length = "0x7")]
	public void Awake()
	{
	}

	[Token(Token = "0x6003CD3")]
	[Address(RVA = "0xB84BB0", Offset = "0xB839B0", Length = "0x295")]
	public void Update()
	{
	}

	[Token(Token = "0x6003CD4")]
	[Address(RVA = "0xB84E50", Offset = "0xB83C50", Length = "0xA0")]
	public void OnControllerScene(bool isController)
	{
	}

	[Token(Token = "0x6003CD5")]
	[Address(RVA = "0xB84F00", Offset = "0xB83D00", Length = "0x112")]
	private void Reset()
	{
	}

	[Token(Token = "0x6003CD6")]
	[Address(RVA = "0xB85020", Offset = "0xB83E20", Length = "0x109")]
	private void SetPrompt(string prompt, string action)
	{
	}

	[Token(Token = "0x6003CD7")]
	[Address(RVA = "0xB85130", Offset = "0xB83F30", Length = "0x195")]
	public void Setup(float displaytime, float holdtime, string prompt, InputManager.InputAction action)
	{
	}

	[Token(Token = "0x6003CD8")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TimedActionPopup()
	{
	}
}

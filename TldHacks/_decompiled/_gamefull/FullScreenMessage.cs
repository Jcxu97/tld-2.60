using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20005D9")]
public class FullScreenMessage : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400361F")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4003620")]
	private static HUDMessage.HUDMessageInfo m_FullScreenMessageInfo;

	[Token(Token = "0x4003621")]
	private static float m_MessageLabelDisplayTimeSeconds;

	[Token(Token = "0x4003622")]
	private static float m_MessageLabelElapsedDisplayTimeSeconds;

	[Token(Token = "0x4003623")]
	private static float m_MessageLabelAlpha;

	[Token(Token = "0x4003624")]
	private static float m_MessageLabelFadeTimeSeconds;

	[Token(Token = "0x4003625")]
	private static bool m_BlackOutScreen;

	[Token(Token = "0x4003626")]
	private static LocationRevealText m_LocationRevealText;

	[Token(Token = "0x6002D60")]
	[Address(RVA = "0x949FA0", Offset = "0x948DA0", Length = "0x3F")]
	private void Start()
	{
	}

	[Token(Token = "0x6002D61")]
	[Address(RVA = "0x949FE0", Offset = "0x948DE0", Length = "0x41D")]
	private void Update()
	{
	}

	[Token(Token = "0x6002D62")]
	[Address(RVA = "0x94A400", Offset = "0x949200", Length = "0x2B3")]
	public static void AddMessage(string message, float numSeconds, bool blackOutScreen, bool fadeIn)
	{
	}

	[Token(Token = "0x6002D63")]
	[Address(RVA = "0x94A6C0", Offset = "0x9494C0", Length = "0x149")]
	private static void ShowMessage()
	{
	}

	[Token(Token = "0x6002D64")]
	[Address(RVA = "0x94A810", Offset = "0x949610", Length = "0x347")]
	private static void ShowText(string text)
	{
	}

	[Token(Token = "0x6002D65")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FullScreenMessage()
	{
	}
}

using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20005E5")]
public class HUDMessage : MonoBehaviour
{
	[Token(Token = "0x20005E6")]
	public class HUDMessageInfo : IPrioritizable
	{
		[Token(Token = "0x400367F")]
		[FieldOffset(Offset = "0x10")]
		public string m_Text;

		[Token(Token = "0x4003680")]
		[FieldOffset(Offset = "0x18")]
		public float m_DisplayTime;

		[Token(Token = "0x4003681")]
		[FieldOffset(Offset = "0x1C")]
		public float m_StartAlpha;

		[Token(Token = "0x4003682")]
		[FieldOffset(Offset = "0x20")]
		public int m_Instances;

		[Token(Token = "0x4003683")]
		[FieldOffset(Offset = "0x24")]
		public bool m_IgnoreOverlayActive;

		[Token(Token = "0x170002D7")]
		[field: Token(Token = "0x4003684")]
		[field: FieldOffset(Offset = "0x28")]
		public int m_Priority
		{
			[Token(Token = "0x6002DB7")]
			[Address(RVA = "0x4588A0", Offset = "0x4576A0", Length = "0x4")]
			get;
			[Token(Token = "0x6002DB8")]
			[Address(RVA = "0x92FF10", Offset = "0x92ED10", Length = "0x4")]
			set;
		}

		[Token(Token = "0x6002DB9")]
		[Address(RVA = "0x953FE0", Offset = "0x952DE0", Length = "0x81")]
		public void Reset()
		{
		}

		[Token(Token = "0x6002DBA")]
		[Address(RVA = "0x954070", Offset = "0x952E70", Length = "0x83")]
		public HUDMessageInfo()
		{
		}
	}

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003675")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4003676")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_FeedFire> m_FeedFire;

	[Token(Token = "0x4003677")]
	private static PriorityQueue<HUDMessageInfo> m_HUDMessageQueue;

	[Token(Token = "0x4003678")]
	private static Stack<HUDMessageInfo> s_HUDMessageCache;

	[Token(Token = "0x4003679")]
	private static float m_MessageLabelElapsedDisplayTimeSeconds;

	[Token(Token = "0x400367A")]
	private static float m_MessageLabelAlpha;

	[Token(Token = "0x400367B")]
	private static float m_MessageLabelFadeTimeSeconds;

	[Token(Token = "0x400367C")]
	private static HUDMessageInfo m_CurrentMessage;

	[Token(Token = "0x400367D")]
	private const int HIGH_PRIORITY = 1;

	[Token(Token = "0x400367E")]
	private const int LOW_PRIORITY = 3;

	[Token(Token = "0x6002DAA")]
	[Address(RVA = "0x952BF0", Offset = "0x9519F0", Length = "0x1A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6002DAB")]
	[Address(RVA = "0x952D90", Offset = "0x951B90", Length = "0x723")]
	private void Update()
	{
	}

	[Token(Token = "0x6002DAC")]
	[Address(RVA = "0x9534C0", Offset = "0x9522C0", Length = "0x111")]
	private static void UpdateAlphaValue(Panel_HUD hud)
	{
	}

	[Token(Token = "0x6002DAD")]
	[Address(RVA = "0x9535E0", Offset = "0x9523E0", Length = "0xA3")]
	public static void AddMessage(string message, bool highPriority = false, bool ignoreOverlayActive = false)
	{
	}

	[Token(Token = "0x6002DAE")]
	[Address(RVA = "0x953690", Offset = "0x952490", Length = "0xB3")]
	public static void AddMessage(string message, float numSeconds, bool highPriority = false, bool ignoreOverlayActive = false)
	{
	}

	[Token(Token = "0x6002DAF")]
	[Address(RVA = "0x953750", Offset = "0x952550", Length = "0xAF")]
	public static void AddMessageFadeIn(string message, float numSeconds, bool highPriority = false)
	{
	}

	[Token(Token = "0x6002DB0")]
	[Address(RVA = "0x953800", Offset = "0x952600", Length = "0x39A")]
	private static void AddMessageToQueue(HUDMessageInfo newHudMessage)
	{
	}

	[Token(Token = "0x6002DB1")]
	[Address(RVA = "0x953BA0", Offset = "0x9529A0", Length = "0x7")]
	private static void PutMessageBackToQueue(HUDMessageInfo message)
	{
	}

	[Token(Token = "0x6002DB2")]
	[Address(RVA = "0x953BB0", Offset = "0x9529B0", Length = "0x148")]
	private static HUDMessageInfo CreateMessageInfo()
	{
		return null;
	}

	[Token(Token = "0x6002DB3")]
	[Address(RVA = "0x953D00", Offset = "0x952B00", Length = "0x131")]
	private static void CacheMessageInfo(HUDMessageInfo messageInfo)
	{
	}

	[Token(Token = "0x6002DB4")]
	[Address(RVA = "0x953E40", Offset = "0x952C40", Length = "0x116")]
	private static void ShowMessage(Panel_HUD hud, HUDMessageInfo message)
	{
	}

	[Token(Token = "0x6002DB5")]
	[Address(RVA = "0x953F60", Offset = "0x952D60", Length = "0x7A")]
	private bool ShowMessageAtBottomOfScreen()
	{
		return false;
	}

	[Token(Token = "0x6002DB6")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public HUDMessage()
	{
	}
}

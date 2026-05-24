using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;

[Token(Token = "0x20005D3")]
public class DebugPanel_WolfHowlController : Panel_Base
{
	[Token(Token = "0x20005D4")]
	private enum HowlEventType
	{
		[Token(Token = "0x40035D5")]
		Failure,
		[Token(Token = "0x40035D6")]
		SuccessLead,
		[Token(Token = "0x40035D7")]
		SuccessResponce
	}

	[Token(Token = "0x20005D5")]
	private struct HowlEvent
	{
		[Token(Token = "0x40035D8")]
		[FieldOffset(Offset = "0x0")]
		public int m_HowlID;

		[Token(Token = "0x40035D9")]
		[FieldOffset(Offset = "0x4")]
		public float m_NextTime;

		[Token(Token = "0x40035DA")]
		[FieldOffset(Offset = "0x8")]
		public TimeSpan m_Timestamp;

		[Token(Token = "0x40035DB")]
		[FieldOffset(Offset = "0x10")]
		public HowlEventType m_Type;

		[Token(Token = "0x40035DC")]
		[FieldOffset(Offset = "0x18")]
		public string m_WolfName;

		[Token(Token = "0x6002D3D")]
		[Address(RVA = "0x9445D0", Offset = "0x9433D0", Length = "0xAA")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6002D3E")]
		[Address(RVA = "0x944680", Offset = "0x943480", Length = "0x34B")]
		private string FailureToString()
		{
			return null;
		}

		[Token(Token = "0x6002D3F")]
		[Address(RVA = "0x9449D0", Offset = "0x9437D0", Length = "0x33A")]
		private string SuccessToString()
		{
			return null;
		}
	}

	[Token(Token = "0x40035CF")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_EventListLabel;

	[Token(Token = "0x40035D0")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_TimerLabel;

	[Token(Token = "0x40035D1")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_WolfListLabel;

	[Token(Token = "0x40035D2")]
	private const int MAX_HOWL_EVENTS = 10;

	[Token(Token = "0x40035D3")]
	[FieldOffset(Offset = "0x40")]
	private List<HowlEvent> m_HowlEvents;

	[Token(Token = "0x6002D35")]
	[Address(RVA = "0x943C50", Offset = "0x942A50", Length = "0xFB")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6002D36")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[Token(Token = "0x6002D37")]
	[Address(RVA = "0x943D50", Offset = "0x942B50", Length = "0x2AB")]
	private void Update()
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6002D38")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void NotifyHowlStarted(int howlID, BaseAi howler, bool isLead)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6002D39")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void NotifyHowlFailed(int howlID, float timer)
	{
	}

	[Token(Token = "0x6002D3A")]
	[Address(RVA = "0x944000", Offset = "0x942E00", Length = "0xB2")]
	private void AddEvent(HowlEvent howl)
	{
	}

	[Token(Token = "0x6002D3B")]
	[Address(RVA = "0x9440C0", Offset = "0x942EC0", Length = "0x392")]
	private void RefreshEventList()
	{
	}

	[Token(Token = "0x6002D3C")]
	[Address(RVA = "0x944460", Offset = "0x943260", Length = "0x16F")]
	public DebugPanel_WolfHowlController()
	{
	}
}

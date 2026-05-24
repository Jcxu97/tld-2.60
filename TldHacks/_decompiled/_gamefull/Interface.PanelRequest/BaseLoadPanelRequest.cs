using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Interface.PanelRequest;

[Token(Token = "0x2001319")]
public abstract class BaseLoadPanelRequest : ILoadPanelRequest
{
	[Token(Token = "0x4008D4B")]
	[FieldOffset(Offset = "0x20")]
	protected string m_PanelName;

	[Token(Token = "0x4008D4C")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsCompleted;

	[Token(Token = "0x4008D4D")]
	[FieldOffset(Offset = "0x30")]
	private Panel_Base m_Panel;

	[Token(Token = "0x4008D4E")]
	[FieldOffset(Offset = "0x38")]
	private string m_ErrorMessage;

	[Token(Token = "0x14000039")]
	public event Action<bool> m_PanelLoadedCallback
	{
		[CompilerGenerated]
		[Token(Token = "0x6007A64")]
		[Address(RVA = "0x1192D70", Offset = "0x1191B70", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007A65")]
		[Address(RVA = "0x1192EE0", Offset = "0x1191CE0", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x1400003A")]
	public event Action<Panel_Base> m_PanelInstantiatedCallback
	{
		[CompilerGenerated]
		[Token(Token = "0x6007A66")]
		[Address(RVA = "0x1193050", Offset = "0x1191E50", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007A67")]
		[Address(RVA = "0x11931C0", Offset = "0x1191FC0", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x6007A68")]
	[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
	public BaseLoadPanelRequest(string panelName)
	{
	}

	[Token(Token = "0x6007A69")]
	[Address(RVA = "0x1193330", Offset = "0x1192130", Length = "0x38")]
	public bool IsLoadingPanel(string panelName)
	{
		return false;
	}

	[Token(Token = "0x6007A6A")]
	[Address(RVA = "0x1193370", Offset = "0x1192170", Length = "0x56")]
	public void NotifyPanelLoaded()
	{
	}

	[Token(Token = "0x6007A6B")]
	public abstract float GetProgress();

	[Token(Token = "0x6007A6C")]
	[Address(RVA = "0xB97C80", Offset = "0xB96A80", Length = "0x5")]
	public bool HasCompleted()
	{
		return false;
	}

	[Token(Token = "0x6007A6D")]
	[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
	public Panel_Base GetPanel()
	{
		return null;
	}

	[Token(Token = "0x6007A6E")]
	[Address(RVA = "0x11933D0", Offset = "0x11921D0", Length = "0x15")]
	public bool HasFailed()
	{
		return false;
	}

	[Token(Token = "0x6007A6F")]
	[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
	public string GetError()
	{
		return null;
	}

	[Token(Token = "0x6007A70")]
	[Address(RVA = "0x11933F0", Offset = "0x11921F0", Length = "0x18")]
	public void UpdateRequest()
	{
	}

	[Token(Token = "0x6007A71")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void UpdateRequest_Internal()
	{
	}

	[Token(Token = "0x6007A72")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void CleanupRequest()
	{
	}

	[Token(Token = "0x6007A73")]
	[Address(RVA = "0x1193410", Offset = "0x1192210", Length = "0x13E")]
	protected void FinishLoadRequest(Panel_Base panelObject)
	{
	}

	[Token(Token = "0x6007A74")]
	[Address(RVA = "0x1193550", Offset = "0x1192350", Length = "0x5C")]
	protected void SetRequestFailed(string errorMessage)
	{
	}
}

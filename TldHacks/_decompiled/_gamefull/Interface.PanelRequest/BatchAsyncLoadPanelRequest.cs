using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Interface.PanelRequest;

[Token(Token = "0x200131A")]
public class BatchAsyncLoadPanelRequest : ILoadPanelRequest
{
	[Token(Token = "0x4008D50")]
	[FieldOffset(Offset = "0x18")]
	private List<Type> m_PanelTypes;

	[Token(Token = "0x4008D51")]
	[FieldOffset(Offset = "0x20")]
	private ILoadPanelRequest m_CurrentRequest;

	[Token(Token = "0x4008D52")]
	[FieldOffset(Offset = "0x28")]
	private int m_CurrentIndex;

	[Token(Token = "0x1400003B")]
	public event Action<bool> m_PanelLoadedCallback
	{
		[CompilerGenerated]
		[Token(Token = "0x6007A75")]
		[Address(RVA = "0x11935B0", Offset = "0x11923B0", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007A76")]
		[Address(RVA = "0x1193720", Offset = "0x1192520", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x6007A77")]
	[Address(RVA = "0x1193890", Offset = "0x1192690", Length = "0x5B")]
	public BatchAsyncLoadPanelRequest(List<Type> panelTypes)
	{
	}

	[Token(Token = "0x6007A78")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool IsLoadingPanel(string panelName)
	{
		return false;
	}

	[Token(Token = "0x6007A79")]
	[Address(RVA = "0x11938F0", Offset = "0x11926F0", Length = "0x18")]
	public void NotifyPanelLoaded()
	{
	}

	[Token(Token = "0x6007A7A")]
	[Address(RVA = "0x1193910", Offset = "0x1192710", Length = "0x8E")]
	public float GetProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6007A7B")]
	[Address(RVA = "0x11939A0", Offset = "0x11927A0", Length = "0x47")]
	public bool HasCompleted()
	{
		return false;
	}

	[Token(Token = "0x6007A7C")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool HasFailed()
	{
		return false;
	}

	[Token(Token = "0x6007A7D")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public string GetError()
	{
		return null;
	}

	[Token(Token = "0x6007A7E")]
	[Address(RVA = "0x11939F0", Offset = "0x11927F0", Length = "0x94")]
	public void UpdateRequest()
	{
	}

	[Token(Token = "0x6007A7F")]
	[Address(RVA = "0x1193A90", Offset = "0x1192890", Length = "0x1D9")]
	private void LoadNextPanel()
	{
	}

	[Token(Token = "0x6007A80")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void CleanupRequest()
	{
	}
}

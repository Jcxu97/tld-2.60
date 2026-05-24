using System;
using Cpp2ILInjected;

namespace Interface.PanelRequest;

[Token(Token = "0x2001318")]
public interface ILoadPanelRequest
{
	[Token(Token = "0x14000038")]
	event Action<bool> m_PanelLoadedCallback;

	[Token(Token = "0x6007A5C")]
	bool IsLoadingPanel(string panelName);

	[Token(Token = "0x6007A5D")]
	void NotifyPanelLoaded();

	[Token(Token = "0x6007A5E")]
	float GetProgress();

	[Token(Token = "0x6007A5F")]
	bool HasCompleted();

	[Token(Token = "0x6007A60")]
	bool HasFailed();

	[Token(Token = "0x6007A61")]
	string GetError();

	[Token(Token = "0x6007A62")]
	void UpdateRequest();

	[Token(Token = "0x6007A63")]
	void CleanupRequest();
}

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Interface.PanelRequest;

[Token(Token = "0x2001317")]
public class AsyncLoadPanelRequest : BaseLoadPanelRequest
{
	[Token(Token = "0x4008D48")]
	[FieldOffset(Offset = "0x40")]
	private AsyncOperationHandle<GameObject> m_AsyncRequest;

	[Token(Token = "0x6007A57")]
	[Address(RVA = "0x1192950", Offset = "0x1191750", Length = "0x1E4")]
	public AsyncLoadPanelRequest(string panelName, string panelVariantName)
		: base(null)
	{
	}

	[Token(Token = "0x6007A58")]
	[Address(RVA = "0x1192B40", Offset = "0x1191940", Length = "0x190")]
	private void PanelInstantiated(AsyncOperationHandle<GameObject> panelHandle)
	{
	}

	[Token(Token = "0x6007A59")]
	[Address(RVA = "0x1192CD0", Offset = "0x1191AD0", Length = "0x91")]
	public override float GetProgress()
	{
		return 0f;
	}
}

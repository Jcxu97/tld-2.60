using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005F1")]
public class HUDTutorial : MonoBehaviour
{
	[Token(Token = "0x20005F2")]
	public delegate void OnCompleteDelegate();

	[Token(Token = "0x40036E1")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_MessageLabel;

	[Token(Token = "0x40036E2")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_InfoLabel;

	[HideInInspector]
	[Token(Token = "0x40036E3")]
	[FieldOffset(Offset = "0x30")]
	public bool m_RestoreDisplay;

	[Token(Token = "0x40036E4")]
	[FieldOffset(Offset = "0x38")]
	public OnCompleteDelegate m_OnComplete;

	[Token(Token = "0x40036E5")]
	[FieldOffset(Offset = "0x40")]
	public Panel_TutorialPopup.TutorialPopupRequest m_Current;

	[Token(Token = "0x40036E6")]
	[FieldOffset(Offset = "0x48")]
	private Queue<Panel_TutorialPopup.TutorialPopupRequest> m_Queue;

	[Token(Token = "0x40036E7")]
	[FieldOffset(Offset = "0x50")]
	private List<UITweener> m_Tweens;

	[Token(Token = "0x40036E8")]
	[FieldOffset(Offset = "0x58")]
	private int m_ActiveTweens;

	[Token(Token = "0x6002DF0")]
	[Address(RVA = "0x95B900", Offset = "0x95A700", Length = "0x4A0")]
	public void Disable()
	{
	}

	[Token(Token = "0x6002DF1")]
	[Address(RVA = "0x95BDB0", Offset = "0x95ABB0", Length = "0x68")]
	public void Enqueue(Panel_TutorialPopup.TutorialPopupRequest request)
	{
	}

	[Token(Token = "0x6002DF2")]
	[Address(RVA = "0x95BE20", Offset = "0x95AC20", Length = "0x62")]
	public void HideDisplay()
	{
	}

	[Token(Token = "0x6002DF3")]
	[Address(RVA = "0x952270", Offset = "0x951070", Length = "0x9F")]
	public bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x6002DF4")]
	[Address(RVA = "0x95BE90", Offset = "0x95AC90", Length = "0x7")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6002DF5")]
	[Address(RVA = "0x95BEA0", Offset = "0x95ACA0", Length = "0x6E")]
	public void RestoreDisplay()
	{
	}

	[Token(Token = "0x6002DF6")]
	[Address(RVA = "0x95BF10", Offset = "0x95AD10", Length = "0x61")]
	public bool WantsUpdates()
	{
		return false;
	}

	[Token(Token = "0x6002DF7")]
	[Address(RVA = "0x95BF80", Offset = "0x95AD80", Length = "0x5A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002DF8")]
	[Address(RVA = "0x95C530", Offset = "0x95B330", Length = "0x370")]
	private void Dequeue()
	{
	}

	[Token(Token = "0x6002DF9")]
	[Address(RVA = "0x95C8B0", Offset = "0x95B6B0", Length = "0x7D")]
	private void OnTweenComplete()
	{
	}

	[Token(Token = "0x6002DFA")]
	[Address(RVA = "0x95C930", Offset = "0x95B730", Length = "0xE3")]
	public HUDTutorial()
	{
	}
}

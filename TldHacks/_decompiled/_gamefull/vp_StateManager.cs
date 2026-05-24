using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000020")]
public class vp_StateManager
{
	[Token(Token = "0x4000217")]
	[FieldOffset(Offset = "0x10")]
	private vp_Component m_Component;

	[Token(Token = "0x4000218")]
	[FieldOffset(Offset = "0x18")]
	private List<vp_StateInfo> m_States;

	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x20")]
	private string m_AppNotPlayingMessage;

	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0x28")]
	private string m_DefaultStateDisableMessage;

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x57A9A0", Offset = "0x5797A0", Length = "0x369")]
	public vp_StateManager(vp_Component component, List<vp_StateInfo> states)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x57AD10", Offset = "0x579B10", Length = "0x278")]
	public void SetState(string state, bool isEnabled)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x57AF90", Offset = "0x579D90", Length = "0x281")]
	public void AllowState(string state, bool isAllowed)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x57B220", Offset = "0x57A020", Length = "0x241")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x57B470", Offset = "0x57A270", Length = "0x146")]
	private void CombineStates()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x57B5C0", Offset = "0x57A3C0", Length = "0x83")]
	public void BringToFront(vp_StateInfo state)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x57B650", Offset = "0x57A450", Length = "0x1CA")]
	public bool IsEnabled(string stateName)
	{
		return false;
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x57B820", Offset = "0x57A620", Length = "0x4C7")]
	public bool IsAllowed(string stateName)
	{
		return false;
	}
}

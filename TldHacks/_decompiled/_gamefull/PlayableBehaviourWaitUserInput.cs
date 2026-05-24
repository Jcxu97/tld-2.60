using Cpp2ILInjected;
using UnityEngine.Playables;

[Token(Token = "0x2000994")]
public class PlayableBehaviourWaitUserInput : PlayableBehaviour
{
	[Token(Token = "0x400627F")]
	[FieldOffset(Offset = "0x10")]
	public double m_StartTime;

	[Token(Token = "0x4006280")]
	[FieldOffset(Offset = "0x18")]
	public LocalizedString m_LocalizationId;

	[Token(Token = "0x4006281")]
	[FieldOffset(Offset = "0x20")]
	private bool m_IsWaiting;

	[Token(Token = "0x4006282")]
	[FieldOffset(Offset = "0x21")]
	private bool m_HasInteracted;

	[Token(Token = "0x4006283")]
	[FieldOffset(Offset = "0x28")]
	private Panel_HUD m_HUD;

	[Token(Token = "0x600558C")]
	[Address(RVA = "0xE9F0B0", Offset = "0xE9DEB0", Length = "0x1FB")]
	private bool HasHUD()
	{
		return false;
	}

	[Token(Token = "0x600558D")]
	[Address(RVA = "0xE9F2B0", Offset = "0xE9E0B0", Length = "0x124")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600558E")]
	[Address(RVA = "0xE9F3E0", Offset = "0xE9E1E0", Length = "0x1C7")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600558F")]
	[Address(RVA = "0xE9F5B0", Offset = "0xE9E3B0", Length = "0x44")]
	private void OnButtonSelected(int choice)
	{
	}

	[Token(Token = "0x6005590")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayableBehaviourWaitUserInput()
	{
	}
}

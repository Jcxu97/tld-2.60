using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

namespace Audio.SimpleAudio;

[Token(Token = "0x200133B")]
public class LoopTracker : BaseTracker
{
	[Token(Token = "0x4008DE5")]
	[FieldOffset(Offset = "0x38")]
	public AkGameObj m_AudioObject;

	[Token(Token = "0x4008DE6")]
	[FieldOffset(Offset = "0x40")]
	public bool m_DynamicProxy;

	[Token(Token = "0x4008DE7")]
	[FieldOffset(Offset = "0x44")]
	public uint m_Instance;

	[Token(Token = "0x4008DE8")]
	[FieldOffset(Offset = "0x48")]
	public AK.Wwise.Event m_Event;

	[Token(Token = "0x4008DE9")]
	[FieldOffset(Offset = "0x50")]
	public string m_EventID;

	[Token(Token = "0x4008DEA")]
	[FieldOffset(Offset = "0x58")]
	public EmitterProxy m_Proxy;

	[Token(Token = "0x4008DEB")]
	[FieldOffset(Offset = "0x60")]
	public bool m_TrackPosition;

	[Token(Token = "0x6007B48")]
	[Address(RVA = "0x119F630", Offset = "0x119E430", Length = "0x216")]
	public LoopTracker(string eventId, GameObject go, float radius, bool stopWhenDisabled, bool position)
		: base(null, 0f, stopWhenDisabled: false)
	{
	}

	[Token(Token = "0x6007B49")]
	[Address(RVA = "0x119F850", Offset = "0x119E650", Length = "0x1FB")]
	public LoopTracker(AK.Wwise.Event eventSpec, GameObject go, float radius, bool stopWhenDisabled, bool position)
		: base(null, 0f, stopWhenDisabled: false)
	{
	}

	[Token(Token = "0x6007B4A")]
	[Address(RVA = "0x119FA50", Offset = "0x119E850", Length = "0x1E4")]
	public override void Cleanup()
	{
	}

	[Token(Token = "0x6007B4B")]
	[Address(RVA = "0x119FC40", Offset = "0x119EA40", Length = "0xCA")]
	public override bool HasProxy()
	{
		return false;
	}

	[Token(Token = "0x6007B4C")]
	[Address(RVA = "0x119FD10", Offset = "0x119EB10", Length = "0x8")]
	public override bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x6007B4D")]
	[Address(RVA = "0x119FD20", Offset = "0x119EB20", Length = "0x174")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6007B4E")]
	[Address(RVA = "0x119FEA0", Offset = "0x119ECA0", Length = "0xB2")]
	private void PlayFromEvent()
	{
	}

	[Token(Token = "0x6007B4F")]
	[Address(RVA = "0x119FF60", Offset = "0x119ED60", Length = "0xB2")]
	private void PlayFromEventString()
	{
	}

	[Token(Token = "0x6007B50")]
	[Address(RVA = "0x11A0020", Offset = "0x119EE20", Length = "0x8C")]
	protected override void Stop()
	{
	}

	[Token(Token = "0x6007B51")]
	[Address(RVA = "0x11A00B0", Offset = "0x119EEB0", Length = "0x2A3")]
	protected void SetupDynamicProxy()
	{
	}
}

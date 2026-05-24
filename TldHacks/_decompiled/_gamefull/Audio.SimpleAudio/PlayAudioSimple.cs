using AK.Wwise;
using Cpp2ILInjected;
using TLD.Audio.Migration;
using UnityEngine;

namespace Audio.SimpleAudio;

[Token(Token = "0x2001334")]
public class PlayAudioSimple : BaseSimpleAudioComponent
{
	[AudioEventMigratedString("m_EventName")]
	[Token(Token = "0x4008DBC")]
	[FieldOffset(Offset = "0x28")]
	public AK.Wwise.Event m_Event;

	[HideInInspector]
	[Token(Token = "0x4008DBD")]
	[FieldOffset(Offset = "0x30")]
	public string m_EventName;

	[Token(Token = "0x4008DBE")]
	[FieldOffset(Offset = "0x38")]
	public float m_Radius;

	[Token(Token = "0x4008DBF")]
	[FieldOffset(Offset = "0x3C")]
	public bool m_StopWhenDisabled;

	[Token(Token = "0x4008DC0")]
	[FieldOffset(Offset = "0x3D")]
	public bool m_TrackPosition;

	[Token(Token = "0x6007B1E")]
	[Address(RVA = "0x119C060", Offset = "0x119AE60", Length = "0x1CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6007B1F")]
	[Address(RVA = "0x119C230", Offset = "0x119B030", Length = "0x8E")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007B20")]
	[Address(RVA = "0x119C2C0", Offset = "0x119B0C0", Length = "0x4A")]
	public PlayAudioSimple()
	{
	}
}

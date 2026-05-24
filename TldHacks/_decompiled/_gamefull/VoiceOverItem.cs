using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using UnityEngine;

[Serializable]
[Token(Token = "0x200085C")]
public class VoiceOverItem
{
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40056CE")]
	[FieldOffset(Offset = "0x10")]
	private string LocIDValue;

	[Token(Token = "0x40056CF")]
	[FieldOffset(Offset = "0x18")]
	public string speech;

	[Token(Token = "0x40056D0")]
	[FieldOffset(Offset = "0x20")]
	public BBParameter<string> LocID;

	[Token(Token = "0x40056D1")]
	[FieldOffset(Offset = "0x28")]
	public bool m_IsUnknownSpeaker;

	[Token(Token = "0x40056D2")]
	[FieldOffset(Offset = "0x2C")]
	public VoiceOverAnimationState m_VoiceOverAnimation;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40056D3")]
	[FieldOffset(Offset = "0x30")]
	public float m_Duration;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40056D4")]
	[FieldOffset(Offset = "0x34")]
	public float m_AfterDuration;

	[Token(Token = "0x6004CEC")]
	[Address(RVA = "0xD7EB20", Offset = "0xD7D920", Length = "0x197")]
	public VoiceOverItem()
	{
	}

	[Token(Token = "0x6004CED")]
	[Address(RVA = "0xD7ECC0", Offset = "0xD7DAC0", Length = "0x160")]
	public string GetLocString()
	{
		return null;
	}

	[Token(Token = "0x6004CEE")]
	[Address(RVA = "0xD7EE30", Offset = "0xD7DC30", Length = "0xAE")]
	public string GetLocId()
	{
		return null;
	}
}

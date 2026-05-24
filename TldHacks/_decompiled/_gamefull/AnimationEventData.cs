using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20007F8")]
public class AnimationEventData
{
	[Token(Token = "0x40054D5")]
	[FieldOffset(Offset = "0x10")]
	public AnimationEventType m_Type;

	[Token(Token = "0x40054D6")]
	[FieldOffset(Offset = "0x18")]
	public string m_Name;

	[Token(Token = "0x40054D7")]
	[FieldOffset(Offset = "0x20")]
	public float m_FrameStart;

	[Token(Token = "0x40054D8")]
	[FieldOffset(Offset = "0x24")]
	public float m_FrameEnd;

	[Token(Token = "0x40054D9")]
	[FieldOffset(Offset = "0x28")]
	public bool m_TriggerOnExit;

	[Token(Token = "0x40054DA")]
	[FieldOffset(Offset = "0x2C")]
	public AnimationEventValue m_Value;

	[Token(Token = "0x40054DB")]
	[FieldOffset(Offset = "0x40")]
	public RuntimeAnimatorController m_Target;

	[Token(Token = "0x40054DC")]
	[FieldOffset(Offset = "0x48")]
	public int m_TargetCycleOffsetParamHash;

	[Token(Token = "0x40054DD")]
	[FieldOffset(Offset = "0x50")]
	public TextAsset m_SubtitleAsset;

	[Token(Token = "0x40054DE")]
	[FieldOffset(Offset = "0x58")]
	private string m_CachedName;

	[Token(Token = "0x40054DF")]
	[FieldOffset(Offset = "0x60")]
	private RuntimeAnimatorController m_CachedTarget;

	[Token(Token = "0x40054E0")]
	[FieldOffset(Offset = "0x68")]
	private string m_CachedString;

	[Token(Token = "0x6004AEC")]
	[Address(RVA = "0xD48470", Offset = "0xD47270", Length = "0x398")]
	public string Key()
	{
		return null;
	}

	[Token(Token = "0x6004AED")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public AnimationEventData()
	{
	}
}

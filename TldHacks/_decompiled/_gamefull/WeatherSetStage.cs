using System;
using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000329")]
public class WeatherSetStage
{
	[Token(Token = "0x4001C42")]
	[FieldOffset(Offset = "0x10")]
	public WeatherStage m_WeatherType;

	[Token(Token = "0x4001C43")]
	[FieldOffset(Offset = "0x14")]
	public Vector2 m_DurationMinMax;

	[Token(Token = "0x4001C44")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 m_TransitionTimeMinMax;

	[Token(Token = "0x4001C45")]
	[FieldOffset(Offset = "0x28")]
	public AK.Wwise.Event m_StartAudio;

	[Token(Token = "0x4001C46")]
	[FieldOffset(Offset = "0x30")]
	public AK.Wwise.Event m_StopAudio;

	[Token(Token = "0x4001C47")]
	[FieldOffset(Offset = "0x38")]
	public State m_AudioState;

	[HideInInspector]
	[Token(Token = "0x4001C48")]
	[FieldOffset(Offset = "0x40")]
	public float m_CurrentDuration;

	[HideInInspector]
	[Token(Token = "0x4001C49")]
	[FieldOffset(Offset = "0x44")]
	public float m_CurrentTransitionTime;

	[HideInInspector]
	[Token(Token = "0x4001C4A")]
	[FieldOffset(Offset = "0x48")]
	public float m_ElapsedTime;

	[Token(Token = "0x4001C4B")]
	[FieldOffset(Offset = "0x4C")]
	private WeatherStage m_PreviousType;

	[Token(Token = "0x60019F8")]
	[Address(RVA = "0x745980", Offset = "0x744780", Length = "0x42")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60019F9")]
	[Address(RVA = "0x7459D0", Offset = "0x7447D0", Length = "0x8")]
	public void Reset()
	{
	}

	[Token(Token = "0x60019FA")]
	[Address(RVA = "0x7459E0", Offset = "0x7447E0", Length = "0x175")]
	public void Activate(float startAtFrac, WeatherStage previousStage)
	{
	}

	[Token(Token = "0x60019FB")]
	[Address(RVA = "0x745B60", Offset = "0x744960", Length = "0xA2")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x60019FC")]
	[Address(RVA = "0x745C10", Offset = "0x744A10", Length = "0xC2")]
	public float Update(float todTimeStep)
	{
		return 0f;
	}

	[Token(Token = "0x60019FD")]
	[Address(RVA = "0x745CE0", Offset = "0x744AE0", Length = "0x7")]
	public void ForceComplete()
	{
	}

	[Token(Token = "0x60019FE")]
	[Address(RVA = "0x745CF0", Offset = "0x744AF0", Length = "0x3F4")]
	public string GetDebugString(int setIndex, bool isCurrent)
	{
		return null;
	}

	[Token(Token = "0x60019FF")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public WeatherSetStage()
	{
	}
}

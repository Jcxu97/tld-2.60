using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200090D")]
public class RumbleEffect : MonoBehaviour
{
	[Token(Token = "0x4005E73")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve m_LowFrequency;

	[Token(Token = "0x4005E74")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve m_HighFrequency;

	[Token(Token = "0x4005E75")]
	[FieldOffset(Offset = "0x30")]
	public float m_Duration;

	[Token(Token = "0x4005E76")]
	[FieldOffset(Offset = "0x34")]
	public bool m_Loop;

	[Token(Token = "0x4005E77")]
	[FieldOffset(Offset = "0x38")]
	private float m_CurrentTime;

	[Token(Token = "0x4005E78")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_IsPlaying;

	[Token(Token = "0x4005E79")]
	[FieldOffset(Offset = "0x40")]
	private float m_CurrentLowFrequencyValue;

	[Token(Token = "0x4005E7A")]
	[FieldOffset(Offset = "0x44")]
	private float m_CurrentHighFrequencyValue;

	[Token(Token = "0x6005286")]
	[Address(RVA = "0xE4A250", Offset = "0xE49050", Length = "0xE")]
	public void StartEffect()
	{
	}

	[Token(Token = "0x6005287")]
	[Address(RVA = "0xE4A260", Offset = "0xE49060", Length = "0xE")]
	public void StopEffect()
	{
	}

	[Token(Token = "0x6005288")]
	[Address(RVA = "0x4C38C0", Offset = "0x4C26C0", Length = "0x5")]
	public bool IsPlaying()
	{
		return false;
	}

	[Token(Token = "0x6005289")]
	[Address(RVA = "0xE4A270", Offset = "0xE49070", Length = "0xA")]
	public void ResetEffect()
	{
	}

	[Token(Token = "0x600528A")]
	[Address(RVA = "0xE4A280", Offset = "0xE49080", Length = "0x144")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x600528B")]
	[Address(RVA = "0x509B50", Offset = "0x508950", Length = "0x6")]
	public float GetHighFrequencyValue()
	{
		return 0f;
	}

	[Token(Token = "0x600528C")]
	[Address(RVA = "0x502440", Offset = "0x501240", Length = "0x6")]
	public float GetLowFrequencyValue()
	{
		return 0f;
	}

	[Token(Token = "0x600528D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public RumbleEffect()
	{
	}
}

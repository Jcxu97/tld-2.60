using Cpp2ILInjected;
using UnityEngine;

namespace TLD.AI;

[Token(Token = "0x20014EF")]
public class AiBaseWolf : BaseAi
{
	[Range(0f, 60f)]
	[Token(Token = "0x4009753")]
	[FieldOffset(Offset = "0xA48")]
	public float m_HowlResponseMinSeconds;

	[Range(0f, 60f)]
	[Token(Token = "0x4009754")]
	[FieldOffset(Offset = "0xA4C")]
	public float m_HowlResponseMaxSeconds;

	[Token(Token = "0x4009755")]
	[FieldOffset(Offset = "0xA50")]
	private float m_HowlStartDelay;

	[Token(Token = "0x4009756")]
	[FieldOffset(Offset = "0xA54")]
	protected AiMode m_PostHowlState;

	[Token(Token = "0x600842A")]
	[Address(RVA = "0x125A370", Offset = "0x1259170", Length = "0xB")]
	public void ClearHowlStartDelay()
	{
	}

	[Token(Token = "0x600842B")]
	[Address(RVA = "0x125A380", Offset = "0x1259180", Length = "0xC4")]
	public float GetRemainingHowlDelay()
	{
		return 0f;
	}

	[Token(Token = "0x600842C")]
	[Address(RVA = "0x125A450", Offset = "0x1259250", Length = "0x4A")]
	public void OnAnimationEvent_HowlComplete()
	{
	}

	[Token(Token = "0x600842D")]
	[Address(RVA = "0x125A4A0", Offset = "0x12592A0", Length = "0x43")]
	public float SetHowlStartDelay(float baseTime)
	{
		return 0f;
	}

	[Token(Token = "0x600842E")]
	[Address(RVA = "0x125A4F0", Offset = "0x12592F0", Length = "0x8A")]
	public void EnterHowl()
	{
	}

	[Token(Token = "0x600842F")]
	[Address(RVA = "0x125A370", Offset = "0x1259170", Length = "0xB")]
	public void ExitHowl()
	{
	}

	[Token(Token = "0x6008430")]
	[Address(RVA = "0x125A580", Offset = "0x1259380", Length = "0x1E6")]
	public void ProcessHowl()
	{
	}

	[Token(Token = "0x6008431")]
	[Address(RVA = "0x125A770", Offset = "0x1259570", Length = "0x82")]
	public override void ApplyBloodLossEvent(AfflictionOptions options)
	{
	}

	[Token(Token = "0x6008432")]
	[Address(RVA = "0x125A800", Offset = "0x1259600", Length = "0xDB")]
	public override void ApplyRiskOfInfectionEvent()
	{
	}

	[Token(Token = "0x6008433")]
	[Address(RVA = "0x125A8E0", Offset = "0x12596E0", Length = "0x78")]
	public override void ApplySprainedAnkleEvent(AfflictionOptions options)
	{
	}

	[Token(Token = "0x6008434")]
	[Address(RVA = "0x125A960", Offset = "0x1259760", Length = "0x78")]
	public override void ApplySprainedWristEvent(AfflictionOptions options)
	{
	}

	[Token(Token = "0x6008435")]
	[Address(RVA = "0x125A9E0", Offset = "0x12597E0", Length = "0x3B")]
	private void AdvanceToNextBehavior()
	{
	}

	[Token(Token = "0x6008436")]
	[Address(RVA = "0x125AA20", Offset = "0x1259820", Length = "0x62")]
	public AiBaseWolf()
	{
	}
}

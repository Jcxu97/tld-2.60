using Cpp2ILInjected;
using UnityEngine;

namespace TLD.ModularElectrolizer;

[CreateAssetMenu(menuName = "Aurora/Electrolizer Flicker Value Generator")]
[Token(Token = "0x20013D4")]
public class FlickerValueGenerator : ScriptableObject
{
	[Token(Token = "0x20013D5")]
	public enum FlickerGeneratorType
	{
		[Token(Token = "0x4009155")]
		CustomCurve,
		[Token(Token = "0x4009156")]
		RandomCurve,
		[Token(Token = "0x4009157")]
		SpikeyCurve,
		[Token(Token = "0x4009158")]
		Sine
	}

	[Token(Token = "0x400914C")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve m_CustomIntensityCurve;

	[Token(Token = "0x400914D")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve m_RandomIntensityCurve;

	[Token(Token = "0x400914E")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve m_SpikyIntensityCurve;

	[Token(Token = "0x400914F")]
	[FieldOffset(Offset = "0x30")]
	public FlickerGeneratorType m_FlickerGeneratorGeneratorType;

	[Token(Token = "0x4009150")]
	[FieldOffset(Offset = "0x34")]
	public bool m_SmoothSteps;

	[Token(Token = "0x4009151")]
	[FieldOffset(Offset = "0x38")]
	public int m_KeyCount;

	[Token(Token = "0x4009152")]
	[FieldOffset(Offset = "0x3C")]
	public float m_SpikePercentage;

	[Token(Token = "0x4009153")]
	[FieldOffset(Offset = "0x40")]
	public float m_SineFrequency;

	[Token(Token = "0x6007EA2")]
	[Address(RVA = "0x11E2B60", Offset = "0x11E1960", Length = "0x13B")]
	public float GetFlickerValue(float time)
	{
		return 0f;
	}

	[Token(Token = "0x6007EA3")]
	[Address(RVA = "0x11E2CA0", Offset = "0x11E1AA0", Length = "0x1F")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007EA4")]
	[Address(RVA = "0x11E2CC0", Offset = "0x11E1AC0", Length = "0x41B")]
	public void GenerateRandomCurve()
	{
	}

	[Token(Token = "0x6007EA5")]
	[Address(RVA = "0x11E30E0", Offset = "0x11E1EE0", Length = "0x38E")]
	public void GenerateSpikyCurve()
	{
	}

	[Token(Token = "0x6007EA6")]
	[Address(RVA = "0x11E3470", Offset = "0x11E2270", Length = "0x36A")]
	public FlickerValueGenerator()
	{
	}
}

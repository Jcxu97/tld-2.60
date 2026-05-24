using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.ModularElectrolizer;

[CreateAssetMenu(menuName = "Aurora/Electrolizer Flicker Module Set")]
[Token(Token = "0x20013D0")]
public class FlickerModuleSet : ScriptableObject
{
	[Token(Token = "0x20013D1")]
	public enum IntensityOperation
	{
		[Token(Token = "0x400913F")]
		mutliply,
		[Token(Token = "0x4009140")]
		add,
		[Token(Token = "0x4009141")]
		subtract,
		[Token(Token = "0x4009142")]
		average,
		[Token(Token = "0x4009143")]
		min,
		[Token(Token = "0x4009144")]
		max
	}

	[Token(Token = "0x400913A")]
	[FieldOffset(Offset = "0x18")]
	public MinMax m_FlickerChangeTime;

	[Token(Token = "0x400913B")]
	[FieldOffset(Offset = "0x20")]
	public List<FlickerModule> m_FlickerModule;

	[Token(Token = "0x400913C")]
	[FieldOffset(Offset = "0x28")]
	public List<IntensityOperation> m_IntensityOperation;

	[Token(Token = "0x400913D")]
	[FieldOffset(Offset = "0x30")]
	private float m_MaxIntensity;

	[Token(Token = "0x6007E92")]
	[Address(RVA = "0x11E1F40", Offset = "0x11E0D40", Length = "0x188")]
	public float ProcessIntensity(List<float> moduleTimeValues, float inputIntensity)
	{
		return 0f;
	}

	[Token(Token = "0x6007E93")]
	[Address(RVA = "0x11E20D0", Offset = "0x11E0ED0", Length = "0x215")]
	private float ProcessIntensity(FlickerValueGenerator valueGenerator, float timeValue, float inputIntensity, FlickerAmplitudeParameters amMods, IntensityOperation operation)
	{
		return 0f;
	}

	[Token(Token = "0x6007E94")]
	[Address(RVA = "0x11DEAE0", Offset = "0x11DD8E0", Length = "0x28")]
	public float GetRandomFlickerDuration()
	{
		return 0f;
	}

	[Token(Token = "0x6007E95")]
	[Address(RVA = "0x11E22F0", Offset = "0x11E10F0", Length = "0x16")]
	public float GetMaxIntensity()
	{
		return 0f;
	}

	[Token(Token = "0x6007E96")]
	[Address(RVA = "0x11E2310", Offset = "0x11E1110", Length = "0x26")]
	public float Remap(float value, float inMin, float inMax, float toMin, float toMax)
	{
		return 0f;
	}

	[Token(Token = "0x6007E97")]
	[Address(RVA = "0x11E2340", Offset = "0x11E1140", Length = "0xA2")]
	public FlickerModuleSet()
	{
	}
}

using System.Collections.Generic;
using Cpp2ILInjected;

namespace TLD.ModularElectrolizer;

[Token(Token = "0x20013D3")]
public class FlickerTimingControl
{
	[Token(Token = "0x4009148")]
	[FieldOffset(Offset = "0x10")]
	private float m_FlickerDurationLimit;

	[Token(Token = "0x4009149")]
	[FieldOffset(Offset = "0x14")]
	private int m_CurrentFlickerSet;

	[Token(Token = "0x400914A")]
	[FieldOffset(Offset = "0x18")]
	private List<float> m_FlickerModuleTiming;

	[Token(Token = "0x400914B")]
	[FieldOffset(Offset = "0x20")]
	private List<float> m_FlickerModuleRateVariance;

	[Token(Token = "0x17000ACE")]
	public float FlickerDurationLimit
	{
		[Token(Token = "0x6007E9B")]
		[Address(RVA = "0x4A7A20", Offset = "0x4A6820", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000ACF")]
	public int CurrentFlickerSet
	{
		[Token(Token = "0x6007E9C")]
		[Address(RVA = "0x40E0B0", Offset = "0x40CEB0", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000AD0")]
	public List<float> FlickerModuleTiming
	{
		[Token(Token = "0x6007E9D")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007E9E")]
	[Address(RVA = "0x11E2520", Offset = "0x11E1320", Length = "0x5D")]
	public void SelectRandomFlickerSet(int flickerSetCount)
	{
	}

	[Token(Token = "0x6007E9F")]
	[Address(RVA = "0x11E2580", Offset = "0x11E1380", Length = "0x3DA")]
	public void InitializeFlickerTiming(FlickerModuleSet moduleSet)
	{
	}

	[Token(Token = "0x6007EA0")]
	[Address(RVA = "0x11E2960", Offset = "0x11E1760", Length = "0x1F2")]
	public void AdvanceFlickerTiming(FlickerModuleSet moduleSet, float deltaTime)
	{
	}

	[Token(Token = "0x6007EA1")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FlickerTimingControl()
	{
	}
}

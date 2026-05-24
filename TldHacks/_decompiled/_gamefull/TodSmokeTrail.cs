using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200031C")]
public class TodSmokeTrail : MonoBehaviour
{
	[Token(Token = "0x4001B65")]
	[FieldOffset(Offset = "0x20")]
	public TodControllerCategory m_Cateogry;

	[Token(Token = "0x4001B66")]
	[FieldOffset(Offset = "0x28")]
	private SmokeTrail[] m_SmokeTrails;

	[Token(Token = "0x4001B67")]
	[FieldOffset(Offset = "0x30")]
	private bool m_ForcedUpdate;

	[Token(Token = "0x4001B68")]
	[FieldOffset(Offset = "0x38")]
	private Light[] m_GimbleLights;

	[Token(Token = "0x4001B69")]
	[FieldOffset(Offset = "0x40")]
	private List<ParticleSystem> m_GimbleFX;

	[Token(Token = "0x6001956")]
	[Address(RVA = "0x732530", Offset = "0x731330", Length = "0x90")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001957")]
	[Address(RVA = "0x7325C0", Offset = "0x7313C0", Length = "0x2A8")]
	public void Update()
	{
	}

	[Token(Token = "0x6001958")]
	[Address(RVA = "0x732870", Offset = "0x731670", Length = "0x279")]
	public void ForceUpdate()
	{
	}

	[Token(Token = "0x6001959")]
	[Address(RVA = "0x732AF0", Offset = "0x7318F0", Length = "0x60")]
	private void ForceToOriginalState()
	{
	}

	[Token(Token = "0x600195A")]
	[Address(RVA = "0x732B60", Offset = "0x731960", Length = "0x60")]
	private void ForceToOffState()
	{
	}

	[Token(Token = "0x600195B")]
	[Address(RVA = "0x732AF0", Offset = "0x7318F0", Length = "0x60")]
	private void InterpolateToOriginalState()
	{
	}

	[Token(Token = "0x600195C")]
	[Address(RVA = "0x732B60", Offset = "0x731960", Length = "0x60")]
	private void InterpolateToOffState()
	{
	}

	[Token(Token = "0x600195D")]
	[Address(RVA = "0x732BD0", Offset = "0x7319D0", Length = "0x13F")]
	private void ForceDayOnlyObject()
	{
	}

	[Token(Token = "0x600195E")]
	[Address(RVA = "0x732D10", Offset = "0x731B10", Length = "0x13F")]
	private void ForceNightOnlyObject()
	{
	}

	[Token(Token = "0x600195F")]
	[Address(RVA = "0x732E50", Offset = "0x731C50", Length = "0x28A")]
	private void ForceMiddayObject()
	{
	}

	[Token(Token = "0x6001960")]
	[Address(RVA = "0x7330E0", Offset = "0x731EE0", Length = "0xEE")]
	private void UpdateDayOnlyObject()
	{
	}

	[Token(Token = "0x6001961")]
	[Address(RVA = "0x7331D0", Offset = "0x731FD0", Length = "0xEE")]
	private void UpdateNightOnlyObject()
	{
	}

	[Token(Token = "0x6001962")]
	[Address(RVA = "0x7332C0", Offset = "0x7320C0", Length = "0x1BE")]
	private void UpdateMiddayObject()
	{
	}

	[Token(Token = "0x6001963")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TodSmokeTrail()
	{
	}
}

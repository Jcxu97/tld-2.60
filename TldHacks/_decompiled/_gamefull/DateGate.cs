using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20002F7")]
public class DateGate : MonoBehaviour
{
	[Token(Token = "0x4001A11")]
	[FieldOffset(Offset = "0x20")]
	public int m_StartYear;

	[Token(Token = "0x4001A12")]
	[FieldOffset(Offset = "0x24")]
	public int m_StartMonth;

	[Token(Token = "0x4001A13")]
	[FieldOffset(Offset = "0x28")]
	public int m_StartDay;

	[Token(Token = "0x4001A14")]
	[FieldOffset(Offset = "0x2C")]
	public int m_StartHour;

	[Token(Token = "0x4001A15")]
	[FieldOffset(Offset = "0x30")]
	public int m_StartMinute;

	[Token(Token = "0x4001A16")]
	[FieldOffset(Offset = "0x34")]
	public int m_EndYear;

	[Token(Token = "0x4001A17")]
	[FieldOffset(Offset = "0x38")]
	public int m_EndMonth;

	[Token(Token = "0x4001A18")]
	[FieldOffset(Offset = "0x3C")]
	public int m_EndDay;

	[Token(Token = "0x4001A19")]
	[FieldOffset(Offset = "0x40")]
	public int m_EndHour;

	[Token(Token = "0x4001A1A")]
	[FieldOffset(Offset = "0x44")]
	public int m_EndMinute;

	[Token(Token = "0x4001A1B")]
	[FieldOffset(Offset = "0x48")]
	public SpecialTODState m_AssociatedTODState;

	[Token(Token = "0x4001A1C")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_GateObject;

	[Token(Token = "0x4001A1D")]
	[FieldOffset(Offset = "0x58")]
	private int m_MinDay;

	[Token(Token = "0x4001A1E")]
	[FieldOffset(Offset = "0x5C")]
	private int m_MaxDay;

	[Token(Token = "0x4001A1F")]
	private const int PDT_UTC_OFFSET = -7;

	[Token(Token = "0x4001A20")]
	private static TimeSpan m_PDTToUTC;

	[Token(Token = "0x4001A21")]
	[FieldOffset(Offset = "0x60")]
	private DateTime m_MinTime;

	[Token(Token = "0x4001A22")]
	[FieldOffset(Offset = "0x68")]
	private DateTime m_MaxTime;

	[Token(Token = "0x4001A23")]
	[FieldOffset(Offset = "0x70")]
	private bool m_Active;

	[Token(Token = "0x6001884")]
	[Address(RVA = "0x6F0240", Offset = "0x6EF040", Length = "0x2AE")]
	public void Start()
	{
	}

	[Token(Token = "0x6001885")]
	[Address(RVA = "0x6F04F0", Offset = "0x6EF2F0", Length = "0x119")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001886")]
	[Address(RVA = "0x6F0610", Offset = "0x6EF410", Length = "0x1E8")]
	public void Update()
	{
	}

	[Token(Token = "0x6001887")]
	[Address(RVA = "0x6F0800", Offset = "0x6EF600", Length = "0x158")]
	private bool PassesDateGate()
	{
		return false;
	}

	[Token(Token = "0x6001888")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public DateGate()
	{
	}
}

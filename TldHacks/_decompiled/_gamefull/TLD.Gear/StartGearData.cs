using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[CreateAssetMenu(menuName = "The Long Dark/Starting Gear Table")]
[Token(Token = "0x2001448")]
public class StartGearData : ScriptableObject
{
	[Token(Token = "0x400939D")]
	[FieldOffset(Offset = "0x18")]
	public FixedGearItem[] m_FixedGear;

	[Token(Token = "0x400939E")]
	[FieldOffset(Offset = "0x20")]
	public RandomGearItem[] m_RandomGear;

	[Token(Token = "0x17000B2B")]
	[field: Token(Token = "0x400939F")]
	[field: FieldOffset(Offset = "0x28")]
	public Func<int, int, int> RandomRange
	{
		[Token(Token = "0x6008137")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get;
		[Token(Token = "0x6008138")]
		[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
		set;
	}

	[Token(Token = "0x6008139")]
	[Address(RVA = "0x1218E30", Offset = "0x1217C30", Length = "0x851")]
	public void AddStartingGearToPlayer(PlayerManager playerManager, Action<List<GearItem>> onItemsAddedCallback = null)
	{
	}

	[Token(Token = "0x600813A")]
	[Address(RVA = "0x1219690", Offset = "0x1218490", Length = "0xAC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600813B")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public StartGearData()
	{
	}
}

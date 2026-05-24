using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000008")]
public sealed class vp_DecalManager
{
	[Token(Token = "0x400002C")]
	public static readonly vp_DecalManager instance;

	[Token(Token = "0x400002D")]
	private static List<GameObject> m_Decals;

	[Token(Token = "0x400002E")]
	private static float m_MaxDecals;

	[Token(Token = "0x400002F")]
	private static float m_FadedDecals;

	[Token(Token = "0x4000030")]
	private static float m_NonFadedDecals;

	[Token(Token = "0x4000031")]
	private static float m_FadeAmount;

	[Token(Token = "0x17000005")]
	public static float MaxDecals
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x546790", Offset = "0x545590", Length = "0x55")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x5467F0", Offset = "0x5455F0", Length = "0x68")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public static float FadedDecals
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x546860", Offset = "0x545660", Length = "0x55")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x5468C0", Offset = "0x5456C0", Length = "0xD5")]
		set
		{
		}
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x5469A0", Offset = "0x5457A0", Length = "0x1BA")]
	static vp_DecalManager()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private vp_DecalManager()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x546B60", Offset = "0x545960", Length = "0xCC")]
	public static void Add(GameObject decal)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x546C30", Offset = "0x545A30", Length = "0x97B")]
	private static void FadeAndRemove()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x5475B0", Offset = "0x5463B0", Length = "0xD0")]
	private static void Refresh()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x547680", Offset = "0x546480", Length = "0x79D")]
	private static void DebugOutput()
	{
	}
}

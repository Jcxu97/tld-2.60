using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000752")]
public class GearManager
{
	[Token(Token = "0x4004E35")]
	private const int NUM_PROCESS_PER_FRAME = 10;

	[Token(Token = "0x4004E36")]
	public static List<GearItem> m_Gear;

	[Token(Token = "0x4004E37")]
	public static List<GearItem> m_DroppedDecoys;

	[Token(Token = "0x4004E38")]
	public static GameObject m_GearCategory;

	[Token(Token = "0x4004E39")]
	public static float m_DecayScale;

	[Token(Token = "0x4004E3C")]
	private static List<GearItem> m_GearToDestroy;

	[Token(Token = "0x4004E3D")]
	private static int m_CurrentIndex;

	[Token(Token = "0x4004E3E")]
	private static bool m_UpdateAllNextFrame;

	[Token(Token = "0x1400000E")]
	public static event Action<GearItem> m_OnGearItemAdded
	{
		[CompilerGenerated]
		[Token(Token = "0x6004350")]
		[Address(RVA = "0xC53DC0", Offset = "0xC52BC0", Length = "0x1C6")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6004351")]
		[Address(RVA = "0xC53F90", Offset = "0xC52D90", Length = "0x1C6")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public static event Action<GearItem> m_OnGearItemRemoved
	{
		[CompilerGenerated]
		[Token(Token = "0x6004352")]
		[Address(RVA = "0xC54160", Offset = "0xC52F60", Length = "0x1C6")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6004353")]
		[Address(RVA = "0xC54330", Offset = "0xC53130", Length = "0x1C6")]
		remove
		{
		}
	}

	[Token(Token = "0x6004354")]
	[Address(RVA = "0xC54500", Offset = "0xC53300", Length = "0x37D")]
	public static void Add(GearItem gi)
	{
	}

	[Token(Token = "0x6004355")]
	[Address(RVA = "0xC54880", Offset = "0xC53680", Length = "0x392")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6004356")]
	[Address(RVA = "0xC54C20", Offset = "0xC53A20", Length = "0x2C8")]
	public static void DeleteAllActive()
	{
	}

	[Token(Token = "0x6004357")]
	[Address(RVA = "0xC54EF0", Offset = "0xC53CF0", Length = "0x149")]
	public static void DestroyGearObject(GameObject go)
	{
	}

	[Token(Token = "0x6004358")]
	[Address(RVA = "0xC55040", Offset = "0xC53E40", Length = "0x687")]
	public static void DestroyGearObject(GearItem gi)
	{
	}

	[Token(Token = "0x6004359")]
	[Address(RVA = "0xC556D0", Offset = "0xC544D0", Length = "0xC4")]
	public static void Remove(GearItem gi)
	{
	}

	[Token(Token = "0x600435A")]
	[Address(RVA = "0xC557A0", Offset = "0xC545A0", Length = "0x3AB")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600435B")]
	[Address(RVA = "0xC55B50", Offset = "0xC54950", Length = "0x51")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x600435C")]
	[Address(RVA = "0xC55BB0", Offset = "0xC549B0", Length = "0xB3")]
	public static void Deserialize(string text, List<GearItem> loadedItems)
	{
	}

	[Token(Token = "0x600435D")]
	[Address(RVA = "0xC55C70", Offset = "0xC54A70", Length = "0x42E")]
	public static void Deserialize(GearSaveList list, List<GearItem> loadedItems)
	{
	}

	[Token(Token = "0x600435E")]
	[Address(RVA = "0xC560A0", Offset = "0xC54EA0", Length = "0x211")]
	public static void MaybeAddToDroppedDecoys(GearItem gi)
	{
	}

	[Token(Token = "0x600435F")]
	[Address(RVA = "0xC562C0", Offset = "0xC550C0", Length = "0xD5")]
	public static void RemovedFromDroppedDecoys(GearItem gi)
	{
	}

	[Token(Token = "0x6004360")]
	[Address(RVA = "0xC563A0", Offset = "0xC551A0", Length = "0x4E")]
	public static void RegisterForOnGearItemAdded(Action<GearItem> function)
	{
	}

	[Token(Token = "0x6004361")]
	[Address(RVA = "0xC563F0", Offset = "0xC551F0", Length = "0x4E")]
	public static void RegisterForOnGearItemRemoved(Action<GearItem> function)
	{
	}

	[Token(Token = "0x6004362")]
	[Address(RVA = "0xC56440", Offset = "0xC55240", Length = "0x80")]
	public static int GetFrameCountBetweenItemUpdates()
	{
		return 0;
	}

	[Token(Token = "0x6004363")]
	[Address(RVA = "0xC564D0", Offset = "0xC552D0", Length = "0x1F6")]
	private static bool ShouldDeleteActiveGearItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6004364")]
	[Address(RVA = "0xC566D0", Offset = "0xC554D0", Length = "0x110")]
	public static void DestroyNextUpdate(GearItem gearItem, bool value)
	{
	}

	[Token(Token = "0x6004365")]
	[Address(RVA = "0xC567F0", Offset = "0xC555F0", Length = "0x24E")]
	private static void DestroyMarkedObjects()
	{
	}

	[Token(Token = "0x6004366")]
	[Address(RVA = "0xC56A40", Offset = "0xC55840", Length = "0x177")]
	public static void Update()
	{
	}

	[Token(Token = "0x6004367")]
	[Address(RVA = "0xC56BC0", Offset = "0xC559C0", Length = "0x7A")]
	public static void UpdateAll()
	{
	}

	[Token(Token = "0x6004368")]
	[Address(RVA = "0xC56C40", Offset = "0xC55A40", Length = "0x54")]
	public static void UpdateAllNextFrame()
	{
	}

	[Token(Token = "0x6004369")]
	[Address(RVA = "0xC56CA0", Offset = "0xC55AA0", Length = "0x214")]
	private static void UpdateItems(int start, int endExclusive)
	{
	}

	[Token(Token = "0x600436A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public GearManager()
	{
	}
}

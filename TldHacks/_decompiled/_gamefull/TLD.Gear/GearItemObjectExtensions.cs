using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.IntBackedUnit;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x200141E")]
public static class GearItemObjectExtensions
{
	[Token(Token = "0x6008035")]
	[Address(RVA = "0x1203000", Offset = "0x1201E00", Length = "0x37A")]
	public static GearItem GetBestGearItemWithName(this List<GearItemObject> items, string name)
	{
		return null;
	}

	[Token(Token = "0x6008036")]
	[Address(RVA = "0x1203380", Offset = "0x1202180", Length = "0x35B")]
	public static int NumGearInList(this List<GearItemObject> items, string gearName, bool ignoreWornOut = false)
	{
		return 0;
	}

	[Token(Token = "0x6008037")]
	[Address(RVA = "0x12036E0", Offset = "0x12024E0", Length = "0x3C6")]
	public static int NumGearInList(this List<GearItemObject> items, GearItemData gearItemData)
	{
		return 0;
	}

	[Token(Token = "0x6008038")]
	[Address(RVA = "0x1203AB0", Offset = "0x12028B0", Length = "0x1CB")]
	public static ItemWeight GetTotalWeightKG(this List<GearItemObject> items)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6008039")]
	[Address(RVA = "0x1203C80", Offset = "0x1202A80", Length = "0xE5C")]
	public static ItemWeight GetMeasurableTotalByTypeInList(this List<GearItemObject> items, string type)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x600803A")]
	[Address(RVA = "0x1204AE0", Offset = "0x12038E0", Length = "0x296")]
	private static ItemLiquidVolume GetWaterAmount(List<GearItemObject> items, bool includeNonPotable, bool includePotable)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x600803B")]
	[Address(RVA = "0x1204D80", Offset = "0x1203B80", Length = "0x310")]
	private static ItemWeight GetMeatAmount(List<GearItemObject> items, bool includeFish, bool includeRawFish, bool includeMeat, bool includeRawMeat, bool includeMeatType, GearMeatTypeEnum meatType)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x600803C")]
	[Address(RVA = "0x12050A0", Offset = "0x1203EA0", Length = "0x348")]
	private static ItemLiquidVolume GetLiquidItemAmount(this List<GearItemObject> items, LiquidType type)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x600803D")]
	[Address(RVA = "0x12053F0", Offset = "0x12041F0", Length = "0x96F")]
	public static int DropAndScatterItems(this List<GearItemObject> items, int count, Func<GearItem, GearItem> dropFunction, Predicate<GearItem> validDropPredicate, GearItem forceDropItem, Transform dropAroundTransform, float minRadius, float maxRadius, int minAngleDegrees, int maxAngleDegrees)
	{
		return 0;
	}

	[Token(Token = "0x600803E")]
	[Address(RVA = "0x1205D60", Offset = "0x1204B60", Length = "0x1C2")]
	private static void AdjustForSlope(Vector3 origin, ref Vector3 target)
	{
	}
}

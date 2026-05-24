using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[Serializable]
[Token(Token = "0x200143E")]
public class UserBlueprintData
{
	[Serializable]
	[Token(Token = "0x200143F")]
	public class RequiredGearItem
	{
		[Token(Token = "0x4009385")]
		[FieldOffset(Offset = "0x10")]
		public string Item;

		[Token(Token = "0x4009386")]
		[FieldOffset(Offset = "0x18")]
		public int Count;

		[Token(Token = "0x6008124")]
		[Address(RVA = "0x1195710", Offset = "0x1194510", Length = "0x8")]
		public RequiredGearItem()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001440")]
	public class RequiredPowderItem
	{
		[Token(Token = "0x4009387")]
		[FieldOffset(Offset = "0x10")]
		public string Powder;

		[Token(Token = "0x4009388")]
		[FieldOffset(Offset = "0x18")]
		public float Amount;

		[Token(Token = "0x6008125")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public RequiredPowderItem()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001441")]
	public class RequiredLiquidItem
	{
		[Token(Token = "0x4009389")]
		[FieldOffset(Offset = "0x10")]
		public string Liquid;

		[Token(Token = "0x400938A")]
		[FieldOffset(Offset = "0x18")]
		public float Volume;

		[Token(Token = "0x6008126")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public RequiredLiquidItem()
		{
		}
	}

	[Token(Token = "0x4009370")]
	[FieldOffset(Offset = "0x10")]
	public List<RequiredGearItem> RequiredGear;

	[Token(Token = "0x4009371")]
	[FieldOffset(Offset = "0x18")]
	public List<RequiredPowderItem> RequiredPowders;

	[Token(Token = "0x4009372")]
	[FieldOffset(Offset = "0x20")]
	public List<RequiredLiquidItem> RequiredLiquids;

	[Token(Token = "0x4009373")]
	[FieldOffset(Offset = "0x28")]
	public string RequiredTool;

	[Token(Token = "0x4009374")]
	[FieldOffset(Offset = "0x30")]
	public List<string> OptionalTools;

	[Token(Token = "0x4009375")]
	[FieldOffset(Offset = "0x38")]
	public string CraftedResult;

	[Token(Token = "0x4009376")]
	[FieldOffset(Offset = "0x40")]
	public string CraftedIcon;

	[Token(Token = "0x4009377")]
	[FieldOffset(Offset = "0x48")]
	public int CraftedResultCount;

	[Token(Token = "0x4009378")]
	[FieldOffset(Offset = "0x4C")]
	public int DurationMinutes;

	[Token(Token = "0x4009379")]
	[FieldOffset(Offset = "0x50")]
	public string CraftingAudio;

	[Token(Token = "0x400937A")]
	[FieldOffset(Offset = "0x58")]
	public bool RequiresLight;

	[Token(Token = "0x400937B")]
	[FieldOffset(Offset = "0x59")]
	public bool Locked;

	[Token(Token = "0x400937C")]
	[FieldOffset(Offset = "0x5A")]
	public bool IgnoreLockInSurvival;

	[Token(Token = "0x400937D")]
	[FieldOffset(Offset = "0x5B")]
	public bool AppearsInStoryOnly;

	[Token(Token = "0x400937E")]
	[FieldOffset(Offset = "0x5C")]
	public bool AppearsInSurvivalOnly;

	[Token(Token = "0x400937F")]
	[FieldOffset(Offset = "0x60")]
	public SkillType AppliedSkill;

	[Token(Token = "0x4009380")]
	[FieldOffset(Offset = "0x64")]
	public SkillType ImprovedSkill;

	[Token(Token = "0x4009381")]
	[FieldOffset(Offset = "0x68")]
	public CraftingLocation RequiredCraftingLocation;

	[Token(Token = "0x4009382")]
	[FieldOffset(Offset = "0x6C")]
	public bool RequiresLitFire;

	[Token(Token = "0x4009383")]
	[FieldOffset(Offset = "0x6D")]
	public bool CanIncreaseRepairSkill;

	[Token(Token = "0x4009384")]
	[FieldOffset(Offset = "0x6E")]
	public bool UsesPhoto;

	[Token(Token = "0x600811E")]
	[Address(RVA = "0x1215750", Offset = "0x1214550", Length = "0x2A0")]
	private UserBlueprintData()
	{
	}

	[Token(Token = "0x600811F")]
	[Address(RVA = "0x12159F0", Offset = "0x12147F0", Length = "0x1505")]
	public static BlueprintData CreateFromJson(string text)
	{
		return null;
	}

	[Token(Token = "0x6008120")]
	[Address(RVA = "0x1216F00", Offset = "0x1215D00", Length = "0x131")]
	private static bool FindLiquidType(string liquid, Dictionary<string, LiquidType> library)
	{
		return false;
	}

	[Token(Token = "0x6008121")]
	[Address(RVA = "0x1217040", Offset = "0x1215E40", Length = "0x131")]
	private static bool FindPowderType(string powder, Dictionary<string, PowderType> library)
	{
		return false;
	}

	[Token(Token = "0x6008122")]
	[Address(RVA = "0x1217180", Offset = "0x1215F80", Length = "0x113")]
	private static bool FindGearItemPrefab(string gearName, Dictionary<string, GameObject> library)
	{
		return false;
	}

	[Token(Token = "0x6008123")]
	[Address(RVA = "0x12172A0", Offset = "0x12160A0", Length = "0x225")]
	private static AK.Wwise.Event MakeRuntimeWwiseEvent(string eventName)
	{
		return null;
	}
}

using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;

namespace MissionTypes;

[Serializable]
[Token(Token = "0x2000D47")]
public class InventoryItemRequirement
{
	[Token(Token = "0x400833B")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x400833C")]
	[FieldOffset(Offset = "0x18")]
	public GearItem item;

	[Token(Token = "0x400833D")]
	[FieldOffset(Offset = "0x20")]
	public AssetReferenceGearItem assetReference;

	[Token(Token = "0x400833E")]
	[FieldOffset(Offset = "0x28")]
	public int amount;

	[Token(Token = "0x400833F")]
	[FieldOffset(Offset = "0x2C")]
	public bool testMeasurableAmount;

	[Token(Token = "0x4008340")]
	[FieldOffset(Offset = "0x30")]
	public string optionGroupTag;

	[Token(Token = "0x4008341")]
	[FieldOffset(Offset = "0x38")]
	public string requirementCondition;

	[Token(Token = "0x4008342")]
	[FieldOffset(Offset = "0x40")]
	private Variable reqLHVar;

	[Token(Token = "0x4008343")]
	[FieldOffset(Offset = "0x48")]
	private string reqOp;

	[Token(Token = "0x4008344")]
	[FieldOffset(Offset = "0x50")]
	private Variable reqRHVar;

	[Token(Token = "0x4008345")]
	[FieldOffset(Offset = "0x58")]
	private string cachedAssetReferenceName;

	[Token(Token = "0x6006806")]
	[Address(RVA = "0x105E2D0", Offset = "0x105D0D0", Length = "0xFE")]
	public InventoryItemRequirement()
	{
	}

	[Token(Token = "0x6006807")]
	[Address(RVA = "0x105E3D0", Offset = "0x105D1D0", Length = "0x1C4")]
	public InventoryItemRequirement(string _name, int _amount, bool _testMeasurable, string _optionGroupTag, string _condition)
	{
	}

	[Token(Token = "0x6006808")]
	[Address(RVA = "0x105E5A0", Offset = "0x105D3A0", Length = "0x118")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006809")]
	[Address(RVA = "0x105E6C0", Offset = "0x105D4C0", Length = "0x119")]
	public bool TestRequirementCondition(IBlackboard bb)
	{
		return false;
	}

	[Token(Token = "0x600680A")]
	[Address(RVA = "0x105E7E0", Offset = "0x105D5E0", Length = "0x114")]
	public bool HasValidItemName()
	{
		return false;
	}

	[Token(Token = "0x600680B")]
	[Address(RVA = "0x105E900", Offset = "0x105D700", Length = "0x2E6")]
	public string GetItemName()
	{
		return null;
	}
}

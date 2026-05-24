using System.Collections.Generic;
using Cpp2ILInjected;
using MissionTypes;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Container")]
[Description("Check if a named container contains a given list of items.")]
[Name("Container Contains", 0)]
[Token(Token = "0x200111C")]
public class TLD_CheckContainerContains : ConditionTask<GraphOwner>
{
	[RequiredField]
	[Token(Token = "0x400875E")]
	[FieldOffset(Offset = "0x68")]
	public string containerName;

	[Token(Token = "0x400875F")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<List<InventoryItemRequirement>> requiredItemsList;

	[Token(Token = "0x4008760")]
	[FieldOffset(Offset = "0x78")]
	public bool mustHaveAll;

	[Token(Token = "0x4008761")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<string, List<InventoryItemRequirement>> requirementsDict;

	[Token(Token = "0x170008E6")]
	protected override string info
	{
		[Token(Token = "0x60073DB")]
		[Address(RVA = "0x10F3D50", Offset = "0x10F2B50", Length = "0x326")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60073DC")]
	[Address(RVA = "0x10F4080", Offset = "0x10F2E80", Length = "0x359")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073DD")]
	[Address(RVA = "0x10F43E0", Offset = "0x10F31E0", Length = "0x171")]
	public TLD_CheckContainerContains()
	{
	}
}

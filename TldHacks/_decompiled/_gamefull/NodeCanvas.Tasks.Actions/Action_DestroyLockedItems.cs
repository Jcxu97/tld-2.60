using System.Collections.Generic;
using Cpp2ILInjected;
using MissionTypes;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Destroy Locked Items", 0)]
[Description("Remove/destroy locked items from the container.")]
[Category("TLD Actions/Container")]
[Token(Token = "0x20011D5")]
public class Action_DestroyLockedItems : ActionTask
{
	[RequiredField]
	[Token(Token = "0x4008910")]
	[FieldOffset(Offset = "0x68")]
	public string containerName;

	[Token(Token = "0x4008911")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<GearItemComponentFilter> componentFilter;

	[Token(Token = "0x4008912")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<InventoryItemRequirement> requiredItem;

	[Token(Token = "0x4008913")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<int> itemCount;

	[Token(Token = "0x4008914")]
	[FieldOffset(Offset = "0x88")]
	private List<GearItem> items;

	[Token(Token = "0x4008915")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<bool> removeAll;

	[Token(Token = "0x17000964")]
	protected override string info
	{
		[Token(Token = "0x6007655")]
		[Address(RVA = "0x1144820", Offset = "0x1143620", Length = "0x289")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007656")]
	[Address(RVA = "0x1144AB0", Offset = "0x11438B0", Length = "0x23")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007657")]
	[Address(RVA = "0x1144AE0", Offset = "0x11438E0", Length = "0x61B")]
	private bool DoDestroyContainerLockedItems()
	{
		return false;
	}

	[Token(Token = "0x6007658")]
	[Address(RVA = "0x1145100", Offset = "0x1143F00", Length = "0x426")]
	public Action_DestroyLockedItems()
	{
	}
}

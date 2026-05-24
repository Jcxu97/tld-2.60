using System.Collections.Generic;
using Cpp2ILInjected;
using MissionTypes;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Lock Items ", 0)]
[Description("Lock a count of items so they cannot be removed from the container.")]
[Category("TLD Actions/Container")]
[Token(Token = "0x20011D4")]
public class Action_LockItems : ActionTask
{
	[RequiredField]
	[Token(Token = "0x400890A")]
	[FieldOffset(Offset = "0x68")]
	public string containerName;

	[Token(Token = "0x400890B")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<GearItemComponentFilter> componentFilter;

	[Token(Token = "0x400890C")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<InventoryItemRequirement> requiredItem;

	[Token(Token = "0x400890D")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<int> itemCount;

	[Token(Token = "0x400890E")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<bool> lockAll;

	[Token(Token = "0x400890F")]
	[FieldOffset(Offset = "0x90")]
	private List<GearItem> items;

	[Token(Token = "0x17000963")]
	protected override string info
	{
		[Token(Token = "0x6007651")]
		[Address(RVA = "0x1143950", Offset = "0x1142750", Length = "0x289")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007652")]
	[Address(RVA = "0x1143BE0", Offset = "0x11429E0", Length = "0x23")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007653")]
	[Address(RVA = "0x1143C10", Offset = "0x1142A10", Length = "0x7CA")]
	private bool DoContainerLock()
	{
		return false;
	}

	[Token(Token = "0x6007654")]
	[Address(RVA = "0x11443E0", Offset = "0x11431E0", Length = "0x435")]
	public Action_LockItems()
	{
	}
}

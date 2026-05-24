using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Lower Item In Hand", 0)]
[Description("Lower (stow) any items in hand")]
[Category("TLD Actions/Player")]
[Token(Token = "0x2001205")]
public class Action_LowerItemsInHand : ActionTask
{
	[Tooltip("Drop Lit Item When Stowed")]
	[Token(Token = "0x400898C")]
	[FieldOffset(Offset = "0x68")]
	public bool dropLitItemWhenStowed;

	[Tooltip("Keep Item In Inventory When Dropped")]
	[Token(Token = "0x400898D")]
	[FieldOffset(Offset = "0x69")]
	public bool keepItemInInventoryWhenDropped;

	[Tooltip("Delete Dropped Item When TimelineEnds")]
	[Token(Token = "0x400898E")]
	[FieldOffset(Offset = "0x6A")]
	public bool deleteDroppedItemWhenTimelineEnds;

	[Token(Token = "0x400898F")]
	[FieldOffset(Offset = "0x6B")]
	private bool m_HasStowedItem;

	[Token(Token = "0x60076DD")]
	[Address(RVA = "0x1150240", Offset = "0x114F040", Length = "0x74")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076DE")]
	[Address(RVA = "0x11502C0", Offset = "0x114F0C0", Length = "0x6C")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60076DF")]
	[Address(RVA = "0x1150330", Offset = "0x114F130", Length = "0x1E2")]
	private void OnItemInHandStowed()
	{
	}

	[Token(Token = "0x60076E0")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_LowerItemsInHand()
	{
	}
}

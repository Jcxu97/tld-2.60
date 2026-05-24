using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Enable Objects", 0)]
[Description("Set the active state for a list of objects. Object are made active or inactive according to 'activeState'.")]
[Category("TLD Actions/Utils")]
[Token(Token = "0x2001262")]
public class Action_EnableObjects : ActionTask
{
	[Token(Token = "0x4008ACE")]
	[FieldOffset(Offset = "0x68")]
	public List<string> objectList;

	[Token(Token = "0x4008ACF")]
	[FieldOffset(Offset = "0x70")]
	public List<BBParameter<string>> bbObjectList;

	[Token(Token = "0x4008AD0")]
	[FieldOffset(Offset = "0x78")]
	public bool activeState;

	[Token(Token = "0x4008AD1")]
	[FieldOffset(Offset = "0x79")]
	public bool scopeToState;

	[Token(Token = "0x170009A5")]
	protected override string info
	{
		[Token(Token = "0x60077EA")]
		[Address(RVA = "0x1166740", Offset = "0x1165540", Length = "0x110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077EB")]
	[Address(RVA = "0x1166850", Offset = "0x1165650", Length = "0x40D")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077EC")]
	[Address(RVA = "0x1166C60", Offset = "0x1165A60", Length = "0x1C3")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x60077ED")]
	[Address(RVA = "0x1166E30", Offset = "0x1165C30", Length = "0x160")]
	public Action_EnableObjects()
	{
	}
}

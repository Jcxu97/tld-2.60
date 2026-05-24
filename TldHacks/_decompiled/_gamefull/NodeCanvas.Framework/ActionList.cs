using System.Collections.Generic;
using Cpp2ILInjected;
using ParadoxNotion.Design;

namespace NodeCanvas.Framework;

[DoNotList]
[Token(Token = "0x200106A")]
public class ActionList : ActionTask, ISubTasksContainer
{
	[Token(Token = "0x200106B")]
	public enum ActionsExecutionMode
	{
		[Token(Token = "0x4008582")]
		ActionsRunInSequence,
		[Token(Token = "0x4008583")]
		ActionsRunInParallel
	}

	[Token(Token = "0x400857C")]
	[FieldOffset(Offset = "0x68")]
	public ActionsExecutionMode executionMode;

	[Token(Token = "0x400857D")]
	[FieldOffset(Offset = "0x70")]
	public List<ActionTask> actions;

	[Token(Token = "0x400857E")]
	[FieldOffset(Offset = "0x78")]
	private List<ActionTask> initialActiveActions;

	[Token(Token = "0x400857F")]
	[FieldOffset(Offset = "0x80")]
	private int currentActionIndex;

	[Token(Token = "0x4008580")]
	[FieldOffset(Offset = "0x88")]
	private readonly List<int> finishedIndeces;

	[Token(Token = "0x170007D1")]
	protected override string info
	{
		[Token(Token = "0x6006F67")]
		[Address(RVA = "0x10C39F0", Offset = "0x10C27F0", Length = "0x31E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006F68")]
	[Address(RVA = "0x10C3D10", Offset = "0x10C2B10", Length = "0x49")]
	Task[] ISubTasksContainer.GetSubTasks()
	{
		return null;
	}

	[Token(Token = "0x6006F69")]
	[Address(RVA = "0x10C3D60", Offset = "0x10C2B60", Length = "0x290")]
	public override Task Duplicate(ITaskSystem newOwnerSystem)
	{
		return null;
	}

	[Token(Token = "0x6006F6A")]
	[Address(RVA = "0x10C4000", Offset = "0x10C2E00", Length = "0x266")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6006F6B")]
	[Address(RVA = "0x10C4270", Offset = "0x10C3070", Length = "0x4F")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6006F6C")]
	[Address(RVA = "0x10C42C0", Offset = "0x10C30C0", Length = "0x2AB")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6006F6D")]
	[Address(RVA = "0x10C4570", Offset = "0x10C3370", Length = "0xD5")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x6006F6E")]
	[Address(RVA = "0x10C4650", Offset = "0x10C3450", Length = "0xC7")]
	protected override void OnPause()
	{
	}

	[Token(Token = "0x6006F6F")]
	[Address(RVA = "0x10C4720", Offset = "0x10C3520", Length = "0xD1")]
	public override void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6006F70")]
	[Address(RVA = "0x10C4800", Offset = "0x10C3600", Length = "0xD1")]
	public override void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6006F71")]
	[Address(RVA = "0x10C48E0", Offset = "0x10C36E0", Length = "0x203")]
	public void AddAction(ActionTask action)
	{
	}

	[Token(Token = "0x6006F72")]
	[Address(RVA = "0x10C4AF0", Offset = "0x10C38F0", Length = "0x160")]
	public ActionList()
	{
	}
}

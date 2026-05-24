using System.Collections.Generic;
using Cpp2ILInjected;
using ParadoxNotion.Design;

namespace NodeCanvas.Framework;

[DoNotList]
[Token(Token = "0x2001070")]
public class ConditionList : ConditionTask, ISubTasksContainer
{
	[Token(Token = "0x2001071")]
	public enum ConditionsCheckMode
	{
		[Token(Token = "0x4008596")]
		AllTrueRequired,
		[Token(Token = "0x4008597")]
		AnyTrueSuffice
	}

	[Token(Token = "0x4008592")]
	[FieldOffset(Offset = "0x68")]
	public ConditionsCheckMode checkMode;

	[Token(Token = "0x4008593")]
	[FieldOffset(Offset = "0x70")]
	public List<ConditionTask> conditions;

	[Token(Token = "0x4008594")]
	[FieldOffset(Offset = "0x78")]
	private List<ConditionTask> initialActiveConditions;

	[Token(Token = "0x170007DC")]
	private bool allTrueRequired
	{
		[Token(Token = "0x6006F93")]
		[Address(RVA = "0x10C5610", Offset = "0x10C4410", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170007DD")]
	protected override string info
	{
		[Token(Token = "0x6006F94")]
		[Address(RVA = "0x10C5620", Offset = "0x10C4420", Length = "0x2D9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006F95")]
	[Address(RVA = "0x10C5900", Offset = "0x10C4700", Length = "0x49")]
	Task[] ISubTasksContainer.GetSubTasks()
	{
		return null;
	}

	[Token(Token = "0x6006F96")]
	[Address(RVA = "0x10C5950", Offset = "0x10C4750", Length = "0x290")]
	public override Task Duplicate(ITaskSystem newOwnerSystem)
	{
		return null;
	}

	[Token(Token = "0x6006F97")]
	[Address(RVA = "0x10C5BF0", Offset = "0x10C49F0", Length = "0x266")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6006F98")]
	[Address(RVA = "0x10C5E60", Offset = "0x10C4C60", Length = "0xE8")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6006F99")]
	[Address(RVA = "0x10C5F50", Offset = "0x10C4D50", Length = "0xBE")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6006F9A")]
	[Address(RVA = "0x10C6010", Offset = "0x10C4E10", Length = "0x12F")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6006F9B")]
	[Address(RVA = "0x10C6140", Offset = "0x10C4F40", Length = "0xD1")]
	public override void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6006F9C")]
	[Address(RVA = "0x10C6220", Offset = "0x10C5020", Length = "0xD1")]
	public override void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6006F9D")]
	[Address(RVA = "0x10C6300", Offset = "0x10C5100", Length = "0x242")]
	public void AddCondition(ConditionTask condition)
	{
	}

	[Token(Token = "0x6006F9E")]
	[Address(RVA = "0x10C6550", Offset = "0x10C5350", Length = "0xB4")]
	public ConditionList()
	{
	}
}

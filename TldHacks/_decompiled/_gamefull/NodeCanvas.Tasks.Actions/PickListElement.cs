using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard/Lists")]
[Token(Token = "0x200129B")]
public class PickListElement<T> : ActionTask
{
	[RequiredField]
	[BlackboardOnly]
	[Token(Token = "0x4008B71")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<List<T>> targetList;

	[Token(Token = "0x4008B72")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<int> index;

	[BlackboardOnly]
	[Token(Token = "0x4008B73")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> saveAs;

	[Token(Token = "0x170009CD")]
	protected override string info
	{
		[Token(Token = "0x600789E")]
		[Address(RVA = "0x1E6AE60", Offset = "0x1E69C60", Length = "0x95")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600789F")]
	[Address(RVA = "0x1E6AF00", Offset = "0x1E69D00", Length = "0x141")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078A0")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public PickListElement()
	{
	}
}

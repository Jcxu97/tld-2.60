using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard/Lists")]
[Token(Token = "0x200129C")]
public class PickRandomListElement<T> : ActionTask
{
	[RequiredField]
	[Token(Token = "0x4008B74")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<List<T>> targetList;

	[Token(Token = "0x4008B75")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> saveAs;

	[Token(Token = "0x170009CE")]
	protected override string info
	{
		[Token(Token = "0x60078A1")]
		[Address(RVA = "0x1E6D740", Offset = "0x1E6C540", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078A2")]
	[Address(RVA = "0x1E6D7D0", Offset = "0x1E6C5D0", Length = "0x14C")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078A3")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public PickRandomListElement()
	{
	}
}

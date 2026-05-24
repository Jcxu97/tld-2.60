using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Token(Token = "0x20012AF")]
public class SetVariable<T> : ActionTask
{
	[BlackboardOnly]
	[Token(Token = "0x4008BA0")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> valueA;

	[Token(Token = "0x4008BA1")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> valueB;

	[Token(Token = "0x170009DC")]
	protected override string info
	{
		[Token(Token = "0x60078D4")]
		[Address(RVA = "0x1FE69E0", Offset = "0x1FE57E0", Length = "0x9F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078D5")]
	[Address(RVA = "0x1FE6A80", Offset = "0x1FE5880", Length = "0x5A")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078D6")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public SetVariable()
	{
	}
}

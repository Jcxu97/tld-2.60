using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Token(Token = "0x20012A8")]
public class SetEnum : ActionTask
{
	[BlackboardOnly]
	[RequiredField]
	[Token(Token = "0x4008B8D")]
	[FieldOffset(Offset = "0x68")]
	public BBObjectParameter valueA;

	[Token(Token = "0x4008B8E")]
	[FieldOffset(Offset = "0x70")]
	public BBObjectParameter valueB;

	[Token(Token = "0x170009D5")]
	protected override string info
	{
		[Token(Token = "0x60078BF")]
		[Address(RVA = "0x11722C0", Offset = "0x11710C0", Length = "0x9F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078C0")]
	[Address(RVA = "0x1172360", Offset = "0x1171160", Length = "0x8B")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078C1")]
	[Address(RVA = "0x11723F0", Offset = "0x11711F0", Length = "0x1B5")]
	public SetEnum()
	{
	}
}

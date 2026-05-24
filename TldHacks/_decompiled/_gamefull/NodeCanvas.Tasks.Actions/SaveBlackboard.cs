using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Description("Saves the blackboard variables in the provided key and to be loaded later on")]
[Token(Token = "0x20012A4")]
public class SaveBlackboard : ActionTask<Blackboard>
{
	[RequiredField]
	[Token(Token = "0x4008B85")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> saveKey;

	[Token(Token = "0x170009D2")]
	protected override string info
	{
		[Token(Token = "0x60078B6")]
		[Address(RVA = "0x1171DE0", Offset = "0x1170BE0", Length = "0x9B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078B7")]
	[Address(RVA = "0x1171E80", Offset = "0x1170C80", Length = "0xE5")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078B8")]
	[Address(RVA = "0x1171F70", Offset = "0x1170D70", Length = "0x44")]
	public SaveBlackboard()
	{
	}
}

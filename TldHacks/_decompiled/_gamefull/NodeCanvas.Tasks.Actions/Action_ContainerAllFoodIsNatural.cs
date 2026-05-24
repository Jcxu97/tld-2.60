using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Container All Food Is Natural", 0)]
[Description("Return true if all food items in container are natural.")]
[Category("TLD Actions/Container")]
[Token(Token = "0x20011D2")]
public class Action_ContainerAllFoodIsNatural : ActionTask
{
	[RequiredField]
	[Token(Token = "0x4008906")]
	[FieldOffset(Offset = "0x68")]
	public string containerName;

	[Token(Token = "0x4008907")]
	[FieldOffset(Offset = "0x70")]
	public string naturalVar;

	[Token(Token = "0x600764B")]
	[Address(RVA = "0x111AE70", Offset = "0x1119C70", Length = "0x23")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600764C")]
	[Address(RVA = "0x111AEA0", Offset = "0x1119CA0", Length = "0x367")]
	private bool DoContainerCheck()
	{
		return false;
	}

	[Token(Token = "0x600764D")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ContainerAllFoodIsNatural()
	{
	}
}

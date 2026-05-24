using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Container Get Calories", 0)]
[Description("Get calories from all food items in a container.")]
[Category("TLD Actions/Container")]
[Token(Token = "0x20011D1")]
public class Action_ContainerGetCalories : ActionTask
{
	[RequiredField]
	[Token(Token = "0x4008904")]
	[FieldOffset(Offset = "0x68")]
	public string containerName;

	[Token(Token = "0x4008905")]
	[FieldOffset(Offset = "0x70")]
	public string caloriesVar;

	[Token(Token = "0x6007648")]
	[Address(RVA = "0x111AAD0", Offset = "0x11198D0", Length = "0x23")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007649")]
	[Address(RVA = "0x111AB00", Offset = "0x1119900", Length = "0x366")]
	private bool DoContainerCheck()
	{
		return false;
	}

	[Token(Token = "0x600764A")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ContainerGetCalories()
	{
	}
}

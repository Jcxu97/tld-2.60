using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Is In Scene", 0)]
[Category("TLD Actions/Utils")]
[Token(Token = "0x2001265")]
public class Action_IsInScene : ActionTask<GraphOwner>
{
	[Token(Token = "0x4008AD5")]
	[FieldOffset(Offset = "0x68")]
	public string sceneName;

	[Token(Token = "0x4008AD6")]
	[FieldOffset(Offset = "0x70")]
	public string successEvent;

	[Token(Token = "0x4008AD7")]
	[FieldOffset(Offset = "0x78")]
	public string failureEvent;

	[Token(Token = "0x60077F5")]
	[Address(RVA = "0x1167600", Offset = "0x1166400", Length = "0x169")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077F6")]
	[Address(RVA = "0x1167770", Offset = "0x1166570", Length = "0x108")]
	public Action_IsInScene()
	{
	}
}

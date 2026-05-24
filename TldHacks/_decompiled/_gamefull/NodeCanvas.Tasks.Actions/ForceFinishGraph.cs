using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Utility")]
[Description("Force Finish the current graph this Task is assigned to.")]
[Token(Token = "0x2001305")]
public class ForceFinishGraph : ActionTask
{
	[Token(Token = "0x4008CBE")]
	[FieldOffset(Offset = "0x68")]
	public CompactStatus finishStatus;

	[Token(Token = "0x6007A18")]
	[Address(RVA = "0x118DF70", Offset = "0x118CD70", Length = "0x1C8")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007A19")]
	[Address(RVA = "0x118E140", Offset = "0x118CF40", Length = "0xF")]
	public ForceFinishGraph()
	{
	}
}

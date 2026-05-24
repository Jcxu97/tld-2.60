using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Toggle Scent Indicator", 0)]
[Category("TLD Mission UI")]
[Token(Token = "0x200124A")]
public class Action_ToggleScentIndicator : ActionTask
{
	[Token(Token = "0x4008A8A")]
	[FieldOffset(Offset = "0x68")]
	public bool enableScentIndicator;

	[Token(Token = "0x17000992")]
	protected override string info
	{
		[Token(Token = "0x60077A8")]
		[Address(RVA = "0x1160B80", Offset = "0x115F980", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077A7")]
	[Address(RVA = "0x1160B10", Offset = "0x115F910", Length = "0x6D")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077A9")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ToggleScentIndicator()
	{
	}
}

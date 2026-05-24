using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Command Block", 0)]
[Category("TLD Actions")]
[Token(Token = "0x20011CF")]
public class Action_CommandBlock : ActionTask
{
	[Token(Token = "0x40088FE")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> commandString;

	[Token(Token = "0x17000961")]
	protected override string info
	{
		[Token(Token = "0x6007641")]
		[Address(RVA = "0x1119D80", Offset = "0x1118B80", Length = "0x2AA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007642")]
	[Address(RVA = "0x111A030", Offset = "0x1118E30", Length = "0x231")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007643")]
	[Address(RVA = "0x111A270", Offset = "0x1119070", Length = "0x128")]
	public Action_CommandBlock()
	{
	}
}

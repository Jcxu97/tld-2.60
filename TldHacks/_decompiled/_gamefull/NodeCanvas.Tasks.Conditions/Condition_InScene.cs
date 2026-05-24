using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Description("Check if we are in a named scene.")]
[Name("In Scene", 0)]
[Token(Token = "0x2001149")]
public class Condition_InScene : ConditionTask
{
	[Token(Token = "0x40087B7")]
	[FieldOffset(Offset = "0x68")]
	public string sceneName;

	[Token(Token = "0x17000901")]
	protected override string info
	{
		[Token(Token = "0x6007467")]
		[Address(RVA = "0x10FD680", Offset = "0x10FC480", Length = "0x42")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007468")]
	[Address(RVA = "0x10FD6D0", Offset = "0x10FC4D0", Length = "0xCC")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007469")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_InScene()
	{
	}
}

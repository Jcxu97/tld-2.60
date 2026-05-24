using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Utility")]
[Description("Logs the value of a variable in the console")]
[Token(Token = "0x2001304")]
public class DebugLogVariable : ActionTask
{
	[BlackboardOnly]
	[Token(Token = "0x4008CBA")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<object> log;

	[Token(Token = "0x4008CBB")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> prefix;

	[Token(Token = "0x4008CBC")]
	[FieldOffset(Offset = "0x78")]
	public float secondsToRun;

	[Token(Token = "0x4008CBD")]
	[FieldOffset(Offset = "0x7C")]
	public CompactStatus finishStatus;

	[Token(Token = "0x17000A23")]
	protected override string info
	{
		[Token(Token = "0x6007A14")]
		[Address(RVA = "0x118DB50", Offset = "0x118C950", Length = "0x10C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A15")]
	[Address(RVA = "0x118DC60", Offset = "0x118CA60", Length = "0x2A2")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007A16")]
	[Address(RVA = "0x118DF10", Offset = "0x118CD10", Length = "0x33")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007A17")]
	[Address(RVA = "0x118DF50", Offset = "0x118CD50", Length = "0x16")]
	public DebugLogVariable()
	{
	}
}

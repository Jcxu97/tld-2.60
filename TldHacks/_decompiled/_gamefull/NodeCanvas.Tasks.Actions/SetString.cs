using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set String", 0)]
[Category("✫ Blackboard")]
[Description("Set a blackboard string variable")]
[Token(Token = "0x20012AE")]
public class SetString : ActionTask
{
	[Token(Token = "0x4008B9E")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> valueA;

	[Token(Token = "0x4008B9F")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> valueB;

	[Token(Token = "0x170009DB")]
	protected override string info
	{
		[Token(Token = "0x60078D1")]
		[Address(RVA = "0x11731D0", Offset = "0x1171FD0", Length = "0x9F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078D2")]
	[Address(RVA = "0x1173270", Offset = "0x1172070", Length = "0x8B")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078D3")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public SetString()
	{
	}
}

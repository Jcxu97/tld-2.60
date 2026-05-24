using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Remove Timer", 0)]
[Category("TLD Actions")]
[Token(Token = "0x2001238")]
public class Action_RemoveTimer : ActionTask
{
	[Token(Token = "0x4008A5E")]
	[FieldOffset(Offset = "0x68")]
	public string id;

	[Token(Token = "0x4008A5F")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> bbID;

	[Token(Token = "0x1700098A")]
	private string realId
	{
		[Token(Token = "0x6007775")]
		[Address(RVA = "0x115D310", Offset = "0x115C110", Length = "0x73")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007776")]
		[Address(RVA = "0x115D390", Offset = "0x115C190", Length = "0x128")]
		set
		{
		}
	}

	[Token(Token = "0x1700098B")]
	protected override string info
	{
		[Token(Token = "0x6007777")]
		[Address(RVA = "0x115D4C0", Offset = "0x115C2C0", Length = "0x63")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007778")]
	[Address(RVA = "0x115D530", Offset = "0x115C330", Length = "0x9F")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007779")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_RemoveTimer()
	{
	}
}

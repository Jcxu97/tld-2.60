using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Filter objects by Tags", 0)]
[Description("Disable any mission objects that *don't* possess one of the given tags. While active this will apply for any loaded scenes too. We expect tagged mission objects to be enabled by default. To specify multiple tags separate them using a semicolon.")]
[Category("TLD Actions/Utils")]
[Token(Token = "0x2001264")]
public class Action_FilterObjectsByTag : ActionTask
{
	[Token(Token = "0x4008AD3")]
	[FieldOffset(Offset = "0x68")]
	public string tags;

	[Token(Token = "0x4008AD4")]
	[FieldOffset(Offset = "0x70")]
	public bool scopeToState;

	[Token(Token = "0x170009A7")]
	protected override string info
	{
		[Token(Token = "0x60077F1")]
		[Address(RVA = "0x1167340", Offset = "0x1166140", Length = "0x78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077F2")]
	[Address(RVA = "0x11673C0", Offset = "0x11661C0", Length = "0x118")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077F3")]
	[Address(RVA = "0x11674E0", Offset = "0x11662E0", Length = "0x70")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x60077F4")]
	[Address(RVA = "0x1167560", Offset = "0x1166360", Length = "0x92")]
	public Action_FilterObjectsByTag()
	{
	}
}

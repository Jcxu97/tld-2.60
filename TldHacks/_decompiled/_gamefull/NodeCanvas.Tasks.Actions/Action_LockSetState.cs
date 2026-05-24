using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Lock Set State", 0)]
[Description("Forces A Lock object to a specific state")]
[Category("TLD Actions/Objects")]
[Token(Token = "0x20011E5")]
public class Action_LockSetState : ActionTask
{
	[Token(Token = "0x4008945")]
	[FieldOffset(Offset = "0x68")]
	public string missionObjectIdentifier;

	[Token(Token = "0x4008946")]
	[FieldOffset(Offset = "0x70")]
	public LockState lockState;

	[Token(Token = "0x600768A")]
	[Address(RVA = "0x1149920", Offset = "0x1148720", Length = "0x22")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600768B")]
	[Address(RVA = "0x1149950", Offset = "0x1148750", Length = "0x1FD")]
	private void DoWork()
	{
	}

	[Token(Token = "0x600768C")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_LockSetState()
	{
	}
}

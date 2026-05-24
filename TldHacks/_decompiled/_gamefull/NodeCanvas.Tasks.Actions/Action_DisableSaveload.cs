using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Disable Save Load", 0)]
[Description("Disables or restores game saving and loading. Use this sparingly!")]
[Category("TLD Actions")]
[Token(Token = "0x2001225")]
public class Action_DisableSaveload : ActionTask
{
	[Token(Token = "0x40089FE")]
	[FieldOffset(Offset = "0x68")]
	public bool disable;

	[Token(Token = "0x1700097E")]
	protected override string info
	{
		[Token(Token = "0x600772E")]
		[Address(RVA = "0x1157B90", Offset = "0x1156990", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600772F")]
	[Address(RVA = "0x1157BF0", Offset = "0x11569F0", Length = "0x73")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007730")]
	[Address(RVA = "0x11185E0", Offset = "0x11173E0", Length = "0xC")]
	public Action_DisableSaveload()
	{
	}
}

using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Enable Saving Without Grounding", 0)]
[Category("TLD Actions/Utils")]
[Token(Token = "0x2001275")]
public class Action_EnableSavingWithoutGrounding : ActionTask
{
	[Token(Token = "0x4008B01")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<bool> enableSavingWithoutGrounding;

	[Token(Token = "0x170009AE")]
	protected override string info
	{
		[Token(Token = "0x600781B")]
		[Address(RVA = "0x116A160", Offset = "0x1168F60", Length = "0x9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600781C")]
	[Address(RVA = "0x116A200", Offset = "0x1169000", Length = "0x9B")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600781D")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_EnableSavingWithoutGrounding()
	{
	}
}

using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Force Custom Load Screen", 0)]
[Category("TLD Load Screen")]
[Token(Token = "0x2001251")]
public class Action_ForceCustomLoadScreen : ActionTask
{
	[Token(Token = "0x4008AA1")]
	private const int LOC_PREVIEW_LENGTH = 60;

	[Token(Token = "0x4008AA2")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> locID;

	[Token(Token = "0x4008AA3")]
	[FieldOffset(Offset = "0x70")]
	public float minHoldTime;

	[Token(Token = "0x17000997")]
	protected override string info
	{
		[Token(Token = "0x60077B8")]
		[Address(RVA = "0x1161DE0", Offset = "0x1160BE0", Length = "0x22D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077B9")]
	[Address(RVA = "0x1162010", Offset = "0x1160E10", Length = "0x13B")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077BA")]
	[Address(RVA = "0x1162150", Offset = "0x1160F50", Length = "0x128")]
	public Action_ForceCustomLoadScreen()
	{
	}
}

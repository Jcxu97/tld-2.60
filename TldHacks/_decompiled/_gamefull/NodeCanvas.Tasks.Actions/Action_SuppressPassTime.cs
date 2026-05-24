using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Suppress Pass Time", 0)]
[Description("Removes Pass Time from radial and makes Rest UI only show the Sleep portion.")]
[Category("TLD Actions/Player")]
[Token(Token = "0x200120E")]
public class Action_SuppressPassTime : ActionTask
{
	[Token(Token = "0x40089B1")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<bool> suppressPassTime;

	[Token(Token = "0x1700097A")]
	protected override string info
	{
		[Token(Token = "0x60076F9")]
		[Address(RVA = "0x1152A00", Offset = "0x1151800", Length = "0xC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60076F8")]
	[Address(RVA = "0x1152930", Offset = "0x1151730", Length = "0xCB")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076FA")]
	[Address(RVA = "0x1152AD0", Offset = "0x11518D0", Length = "0x93")]
	public Action_SuppressPassTime()
	{
	}
}

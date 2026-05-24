using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Get Inv Item Count", 0)]
[Description("Store a count of how many of a given item type the player possesses. Use measureableType for item categories like cookedMeat, potableWater, etc. Notes that measurables are integers, counted as milliliters and grams")]
[Category("TLD Actions/Player")]
[Token(Token = "0x20011F5")]
public class Action_GetInvItemCount : ActionTask
{
	[Token(Token = "0x4008965")]
	[FieldOffset(Offset = "0x68")]
	public string measurableType;

	[Token(Token = "0x4008966")]
	[FieldOffset(Offset = "0x70")]
	public GearItem item;

	[Token(Token = "0x4008967")]
	[FieldOffset(Offset = "0x78")]
	public string storeCountVar;

	[Token(Token = "0x17000971")]
	protected override string info
	{
		[Token(Token = "0x60076B2")]
		[Address(RVA = "0x114CBD0", Offset = "0x114B9D0", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60076B3")]
	[Address(RVA = "0x114CC10", Offset = "0x114BA10", Length = "0x3A0")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076B4")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_GetInvItemCount()
	{
	}
}

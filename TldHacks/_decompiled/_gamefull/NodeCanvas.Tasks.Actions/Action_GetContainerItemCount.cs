using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Get Container Item Count", 0)]
[Description("Store a count of how many of a given item type are in a given container Use measureableType for item categories like cookedMeat, potableWater, etc. Note that measurables are integers, counted as milliliters and grams")]
[Category("TLD Actions/Container")]
[Token(Token = "0x20011D0")]
public class Action_GetContainerItemCount : ActionTask
{
	[RequiredField]
	[Token(Token = "0x40088FF")]
	[FieldOffset(Offset = "0x68")]
	public string containerName;

	[Token(Token = "0x4008900")]
	[FieldOffset(Offset = "0x70")]
	public string measurableType;

	[Token(Token = "0x4008901")]
	[FieldOffset(Offset = "0x78")]
	public GearItem item;

	[Token(Token = "0x4008902")]
	[FieldOffset(Offset = "0x80")]
	public GearItem alternateItem;

	[Token(Token = "0x4008903")]
	[FieldOffset(Offset = "0x88")]
	public string storeCountVar;

	[Token(Token = "0x17000962")]
	protected override string info
	{
		[Token(Token = "0x6007644")]
		[Address(RVA = "0x111A3A0", Offset = "0x11191A0", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007645")]
	[Address(RVA = "0x111A3E0", Offset = "0x11191E0", Length = "0x23")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007646")]
	[Address(RVA = "0x111A410", Offset = "0x1119210", Length = "0x6BB")]
	private bool DoContainerCheck()
	{
		return false;
	}

	[Token(Token = "0x6007647")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_GetContainerItemCount()
	{
	}
}

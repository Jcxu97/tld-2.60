using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Container Get Fuel Hours", 0)]
[Description("Get hours of burn time for for all fuel items in a container.")]
[Category("TLD Actions/Container")]
[Token(Token = "0x20011D3")]
public class Action_ContainerGetFuelHours : ActionTask
{
	[RequiredField]
	[Token(Token = "0x4008908")]
	[FieldOffset(Offset = "0x68")]
	public string containerName;

	[Token(Token = "0x4008909")]
	[FieldOffset(Offset = "0x70")]
	public string fuelVar;

	[Token(Token = "0x600764E")]
	[Address(RVA = "0x11435B0", Offset = "0x11423B0", Length = "0x23")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600764F")]
	[Address(RVA = "0x11435E0", Offset = "0x11423E0", Length = "0x367")]
	private bool DoContainerCheck()
	{
		return false;
	}

	[Token(Token = "0x6007650")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ContainerGetFuelHours()
	{
	}
}

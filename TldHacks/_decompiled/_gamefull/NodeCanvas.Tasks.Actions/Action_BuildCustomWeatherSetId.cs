using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Build Custom Weather Set ID", 0)]
[Description("Builds a unique identifier that can be used to initiate a custom weather set built from randomly selected components.")]
[Category("TLD Actions/Utils")]
[Token(Token = "0x200126B")]
public class Action_BuildCustomWeatherSetId : ActionTask
{
	[RequiredField]
	[Token(Token = "0x4008AEA")]
	[FieldOffset(Offset = "0x68")]
	public string weatherSetFolderName;

	[RequiredField]
	[Token(Token = "0x4008AEB")]
	[FieldOffset(Offset = "0x70")]
	public string customSetVarName;

	[Token(Token = "0x6007801")]
	[Address(RVA = "0x1168600", Offset = "0x1167400", Length = "0x2FC")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007802")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_BuildCustomWeatherSetId()
	{
	}
}

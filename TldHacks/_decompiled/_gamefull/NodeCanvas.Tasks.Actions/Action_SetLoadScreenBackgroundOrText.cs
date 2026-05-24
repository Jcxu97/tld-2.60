using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Background or Text", 0)]
[Category("TLD Load Screen")]
[Token(Token = "0x2001252")]
public class Action_SetLoadScreenBackgroundOrText : ActionTask
{
	[Token(Token = "0x4008AA4")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<LoadingScreenData> data;

	[Token(Token = "0x4008AA5")]
	[FieldOffset(Offset = "0x70")]
	public bool isFallbackNode;

	[Token(Token = "0x17000998")]
	protected override string info
	{
		[Token(Token = "0x60077BB")]
		[Address(RVA = "0x1162280", Offset = "0x1161080", Length = "0x191")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077BC")]
	[Address(RVA = "0x1162420", Offset = "0x1161220", Length = "0x3DA")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077BD")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetLoadScreenBackgroundOrText()
	{
	}
}

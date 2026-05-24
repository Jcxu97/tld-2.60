using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("Input")]
[Token(Token = "0x200117D")]
public class CheckButtonInput : ConditionTask
{
	[Token(Token = "0x400882F")]
	[FieldOffset(Offset = "0x68")]
	public PressTypes pressType;

	[RequiredField]
	[Token(Token = "0x4008830")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> buttonName;

	[Token(Token = "0x17000929")]
	protected override string info
	{
		[Token(Token = "0x6007505")]
		[Address(RVA = "0x1108F40", Offset = "0x1107D40", Length = "0xAB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007506")]
	[Address(RVA = "0x1108FF0", Offset = "0x1107DF0", Length = "0xB4")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007507")]
	[Address(RVA = "0x11090B0", Offset = "0x1107EB0", Length = "0xB3")]
	public CheckButtonInput()
	{
	}
}

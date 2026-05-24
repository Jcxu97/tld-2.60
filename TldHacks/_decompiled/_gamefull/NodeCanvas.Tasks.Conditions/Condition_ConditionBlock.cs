using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Description("Perform one or more AND or OR checks using CommandBlock style syntax. You can have conditions in both blocks, if either is true then the result is true.")]
[Name("Condition Block", 0)]
[Token(Token = "0x200111B")]
public class Condition_ConditionBlock : ConditionTask
{
	[Token(Token = "0x400875A")]
	[FieldOffset(Offset = "0x68")]
	public string andConditions;

	[Token(Token = "0x400875B")]
	[FieldOffset(Offset = "0x70")]
	public string orConditions;

	[Token(Token = "0x400875C")]
	[FieldOffset(Offset = "0x78")]
	private object[] cachedAndConditions;

	[Token(Token = "0x400875D")]
	[FieldOffset(Offset = "0x80")]
	private object[] cachedOrConditions;

	[Token(Token = "0x170008E5")]
	protected override string info
	{
		[Token(Token = "0x60073D7")]
		[Address(RVA = "0x10F35C0", Offset = "0x10F23C0", Length = "0xC2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60073D8")]
	[Address(RVA = "0x10F3690", Offset = "0x10F2490", Length = "0x1B4")]
	private object[] BuildVarCache(string[] conditions)
	{
		return null;
	}

	[Token(Token = "0x60073D9")]
	[Address(RVA = "0x10F3850", Offset = "0x10F2650", Length = "0x4F8")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073DA")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_ConditionBlock()
	{
	}
}

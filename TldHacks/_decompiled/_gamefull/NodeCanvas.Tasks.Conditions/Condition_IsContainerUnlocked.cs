using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Container")]
[Description("returns true if container is unlocked")]
[Name("Is Container Unlocked", 0)]
[Token(Token = "0x200111D")]
public class Condition_IsContainerUnlocked : ConditionTask
{
	[Token(Token = "0x4008762")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> containerId;

	[Token(Token = "0x170008E7")]
	protected override string info
	{
		[Token(Token = "0x60073DE")]
		[Address(RVA = "0x10F4560", Offset = "0x10F3360", Length = "0x6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60073DF")]
	[Address(RVA = "0x10F45D0", Offset = "0x10F33D0", Length = "0x29F")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073E0")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_IsContainerUnlocked()
	{
	}
}

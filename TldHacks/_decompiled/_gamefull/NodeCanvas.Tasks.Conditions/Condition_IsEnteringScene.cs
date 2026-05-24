using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Loading Screen")]
[Name("Is Entering Scene", 0)]
[Token(Token = "0x2001122")]
public class Condition_IsEnteringScene : ConditionTask
{
	[Token(Token = "0x4008769")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> sceneName;

	[Token(Token = "0x170008EA")]
	protected override string info
	{
		[Token(Token = "0x60073EB")]
		[Address(RVA = "0x10F5590", Offset = "0x10F4390", Length = "0x6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60073EC")]
	[Address(RVA = "0x10F5600", Offset = "0x10F4400", Length = "0x198")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073ED")]
	[Address(RVA = "0x10F57A0", Offset = "0x10F45A0", Length = "0x108")]
	public Condition_IsEnteringScene()
	{
	}
}

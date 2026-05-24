using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Player")]
[Description("Returns true if the objective is active or complete, meaning it has been added to the mission UI at some point")]
[Name("ObjectiveIsActiveOrComplete", 0)]
[Token(Token = "0x2001134")]
public class Condition_ObjectiveIsActiveOrComplete : ConditionTask
{
	[Token(Token = "0x400879C")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> objectiveID;

	[Token(Token = "0x170008F2")]
	protected override string info
	{
		[Token(Token = "0x6007426")]
		[Address(RVA = "0x10F9D60", Offset = "0x10F8B60", Length = "0xA5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007427")]
	[Address(RVA = "0x10F9E10", Offset = "0x10F8C10", Length = "0xD9")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007428")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_ObjectiveIsActiveOrComplete()
	{
	}
}

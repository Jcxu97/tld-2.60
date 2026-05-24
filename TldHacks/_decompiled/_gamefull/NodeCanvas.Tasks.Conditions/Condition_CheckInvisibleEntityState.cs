using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Events/Nowhere To Hide")]
[Description("Check the state of the Invisible Entity")]
[Name("Invisible Entity State", 0)]
[Token(Token = "0x2001144")]
public class Condition_CheckInvisibleEntityState : ConditionTask
{
	[Token(Token = "0x40087B0")]
	[FieldOffset(Offset = "0x68")]
	public InvisibleEntityManager.Behavior m_TargetBehavior;

	[Token(Token = "0x170008FE")]
	protected override string info
	{
		[Token(Token = "0x600745A")]
		[Address(RVA = "0x10FCAA0", Offset = "0x10FB8A0", Length = "0xA3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600745B")]
	[Address(RVA = "0x10FCB50", Offset = "0x10FB950", Length = "0x18F")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600745C")]
	[Address(RVA = "0x10FCCE0", Offset = "0x10FBAE0", Length = "0xF")]
	public Condition_CheckInvisibleEntityState()
	{
	}
}

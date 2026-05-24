using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Phone")]
[Description("Check Phone Ringing cycle.")]
[Name("Check Phone Ringing cycle", 0)]
[Token(Token = "0x200115D")]
public class TLD_CheckPhoneRingCycle : ConditionTask
{
	[Token(Token = "0x40087E4")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> phoneMissionId;

	[Token(Token = "0x40087E5")]
	[FieldOffset(Offset = "0x70")]
	public CompareMethod checkType;

	[Token(Token = "0x40087E6")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<int> compareValue;

	[Token(Token = "0x40087E7")]
	[FieldOffset(Offset = "0x80")]
	private Phone m_Phone;

	[Token(Token = "0x40087E8")]
	[FieldOffset(Offset = "0x88")]
	private bool m_HasRetrievedPhone;

	[Token(Token = "0x1700090F")]
	protected override string info
	{
		[Token(Token = "0x600749E")]
		[Address(RVA = "0x1101530", Offset = "0x1100330", Length = "0x136")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600749F")]
	[Address(RVA = "0x1101670", Offset = "0x1100470", Length = "0x16F")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074A0")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public TLD_CheckPhoneRingCycle()
	{
	}
}

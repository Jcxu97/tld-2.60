using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Utility")]
[Description("Will return true after a specific amount of time has passed and false while still counting down")]
[Token(Token = "0x200119E")]
public class Timeout : ConditionTask
{
	[Token(Token = "0x400888F")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<float> timeout;

	[Token(Token = "0x4008890")]
	[FieldOffset(Offset = "0x70")]
	private float currentTime;

	[Token(Token = "0x17000957")]
	protected override string info
	{
		[Token(Token = "0x60075BB")]
		[Address(RVA = "0x1110B70", Offset = "0x110F970", Length = "0xCF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60075BC")]
	[Address(RVA = "0x5DE440", Offset = "0x5DD240", Length = "0x8")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60075BD")]
	[Address(RVA = "0x1110C40", Offset = "0x110FA40", Length = "0xBF")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60075BE")]
	[Address(RVA = "0x1110D00", Offset = "0x110FB00", Length = "0x95")]
	public Timeout()
	{
	}
}

using Cpp2ILInjected;
using InteractiveObjects;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

[Token(Token = "0x2001162")]
public abstract class Condition_TransmitterCheckBase : ConditionTask<GraphOwner>
{
	[Token(Token = "0x40087EF")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<TransmitterData> transmitterSite;

	[Token(Token = "0x17000912")]
	protected override string info
	{
		[Token(Token = "0x60074B0")]
		[Address(RVA = "0x1102650", Offset = "0x1101450", Length = "0x252")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074AE")]
	protected abstract string GetPropertyInfoString(TransmitterRuntimeState state);

	[Token(Token = "0x60074AF")]
	protected abstract bool GetPropertyValue(TransmitterRuntimeState state);

	[Token(Token = "0x60074B1")]
	[Address(RVA = "0x11028B0", Offset = "0x11016B0", Length = "0x1B7")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074B2")]
	[Address(RVA = "0x1102A70", Offset = "0x1101870", Length = "0x194")]
	private TransmitterRuntimeState GetState()
	{
		return null;
	}

	[Token(Token = "0x60074B3")]
	[Address(RVA = "0x1102600", Offset = "0x1101400", Length = "0x44")]
	protected Condition_TransmitterCheckBase()
	{
	}
}

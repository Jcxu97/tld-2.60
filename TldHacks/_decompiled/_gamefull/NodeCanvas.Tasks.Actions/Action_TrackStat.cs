using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.Stats;

namespace NodeCanvas.Tasks.Actions;

[Category("TLD Actions")]
[Name("Track Stat", 0)]
[Token(Token = "0x2001274")]
public class Action_TrackStat : ActionTask
{
	[Token(Token = "0x4008AFE")]
	[FieldOffset(Offset = "0x68")]
	public StatID Stat;

	[Token(Token = "0x4008AFF")]
	[FieldOffset(Offset = "0x6C")]
	public float UnitScale;

	[BlackboardOnly]
	[Token(Token = "0x4008B00")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> StoreValue;

	[Token(Token = "0x170009AD")]
	protected override string info
	{
		[Token(Token = "0x6007815")]
		[Address(RVA = "0x1169950", Offset = "0x1168750", Length = "0xB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007816")]
	[Address(RVA = "0x1169A00", Offset = "0x1168800", Length = "0x2EC")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007817")]
	[Address(RVA = "0x1169CF0", Offset = "0x1168AF0", Length = "0x2EC")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x6007818")]
	[Address(RVA = "0x1169FE0", Offset = "0x1168DE0", Length = "0xA3")]
	private void OnIncrementStat(StatID id, float amount)
	{
	}

	[Token(Token = "0x6007819")]
	[Address(RVA = "0x116A090", Offset = "0x1168E90", Length = "0xB4")]
	private void OnSetStat(StatID id, float previous, float current)
	{
	}

	[Token(Token = "0x600781A")]
	[Address(RVA = "0x116A150", Offset = "0x1168F50", Length = "0xF")]
	public Action_TrackStat()
	{
	}
}

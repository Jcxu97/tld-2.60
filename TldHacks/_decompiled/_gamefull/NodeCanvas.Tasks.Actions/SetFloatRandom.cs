using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Description("Set a blackboard float variable at random between min and max value")]
[Token(Token = "0x20012AA")]
public class SetFloatRandom : ActionTask
{
	[Token(Token = "0x4008B93")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<float> minValue;

	[Token(Token = "0x4008B94")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> maxValue;

	[BlackboardOnly]
	[Token(Token = "0x4008B95")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> floatVariable;

	[Token(Token = "0x170009D7")]
	protected override string info
	{
		[Token(Token = "0x60078C5")]
		[Address(RVA = "0x1172910", Offset = "0x1171710", Length = "0x192")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078C6")]
	[Address(RVA = "0x1172AB0", Offset = "0x11718B0", Length = "0xB4")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078C7")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public SetFloatRandom()
	{
	}
}

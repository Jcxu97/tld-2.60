using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Integer Random", 0)]
[Category("✫ Blackboard")]
[Description("Set a blackboard integer variable at random between min and max value")]
[Token(Token = "0x20012AC")]
public class SetIntRandom : ActionTask
{
	[Token(Token = "0x4008B99")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<int> minValue;

	[Token(Token = "0x4008B9A")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<int> maxValue;

	[BlackboardOnly]
	[Token(Token = "0x4008B9B")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<int> intVariable;

	[Token(Token = "0x170009D9")]
	protected override string info
	{
		[Token(Token = "0x60078CB")]
		[Address(RVA = "0x1172CE0", Offset = "0x1171AE0", Length = "0x192")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078CC")]
	[Address(RVA = "0x1172E80", Offset = "0x1171C80", Length = "0xF6")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078CD")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public SetIntRandom()
	{
	}
}

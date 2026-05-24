using Cpp2ILInjected;
using MissionTypes;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Description("Check if a particular game state is true.")]
[Name("Check Game State", 0)]
[Token(Token = "0x200111A")]
public class TLD_CheckGameState : ConditionTask
{
	[RequiredField]
	[Token(Token = "0x4008757")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> stateName;

	[Token(Token = "0x4008758")]
	[FieldOffset(Offset = "0x70")]
	public string compareAgainstVar;

	[Token(Token = "0x4008759")]
	[FieldOffset(Offset = "0x78")]
	private MissionGameState gameState;

	[Token(Token = "0x170008E4")]
	protected override string info
	{
		[Token(Token = "0x60073D3")]
		[Address(RVA = "0x10F3040", Offset = "0x10F1E40", Length = "0x7A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60073D4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60073D5")]
	[Address(RVA = "0x10F30C0", Offset = "0x10F1EC0", Length = "0x36A")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073D6")]
	[Address(RVA = "0x10F3430", Offset = "0x10F2230", Length = "0x182")]
	public TLD_CheckGameState()
	{
	}
}

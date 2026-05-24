using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Name("Check Episode", 0)]
[Token(Token = "0x200113F")]
public class Condition_CheckEpisode : ConditionTask
{
	[Token(Token = "0x40087AD")]
	[FieldOffset(Offset = "0x68")]
	public Episode episode;

	[Token(Token = "0x170008FB")]
	protected override string info
	{
		[Token(Token = "0x600744C")]
		[Address(RVA = "0x10FC190", Offset = "0x10FAF90", Length = "0xB9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600744D")]
	[Address(RVA = "0x10FC250", Offset = "0x10FB050", Length = "0x52")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600744E")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_CheckEpisode()
	{
	}
}

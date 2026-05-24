using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Name("Check Experience Mode", 0)]
[Token(Token = "0x200113D")]
public class Condition_CheckExperienceMode : ConditionTask
{
	[Token(Token = "0x40087AC")]
	[FieldOffset(Offset = "0x68")]
	public ExperienceModeType xpMode;

	[Token(Token = "0x170008F9")]
	protected override string info
	{
		[Token(Token = "0x6007446")]
		[Address(RVA = "0x10FBF90", Offset = "0x10FAD90", Length = "0xB9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007447")]
	[Address(RVA = "0x10FC050", Offset = "0x10FAE50", Length = "0x52")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007448")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_CheckExperienceMode()
	{
	}
}

using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.Scenes;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Loading Screen")]
[Name("Is Entering Region", 0)]
[Token(Token = "0x2001123")]
public class Condition_IsEnteringRegion : ConditionTask
{
	[Token(Token = "0x400876A")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<RegionSpecification> regionName;

	[Token(Token = "0x170008EB")]
	protected override string info
	{
		[Token(Token = "0x60073EE")]
		[Address(RVA = "0x10F58B0", Offset = "0x10F46B0", Length = "0x159")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60073EF")]
	[Address(RVA = "0x10F5A10", Offset = "0x10F4810", Length = "0x24B")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073F0")]
	[Address(RVA = "0x10F5C60", Offset = "0x10F4A60", Length = "0x108")]
	public Condition_IsEnteringRegion()
	{
	}
}

using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.Gear;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Container")]
[Description("Check if a named container has a required amount of powder.")]
[Name("Container has Powder", 0)]
[Token(Token = "0x200111F")]
public class Condition_CheckContainerPowder : ConditionTask
{
	[RequiredField]
	[Token(Token = "0x4008766")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> m_ContainerId;

	[Token(Token = "0x4008767")]
	[FieldOffset(Offset = "0x70")]
	public PowderType m_Powder;

	[Tooltip("Required amount of powder, in kilograms.")]
	[Token(Token = "0x4008768")]
	[FieldOffset(Offset = "0x78")]
	public float m_RequiredAmount;

	[Token(Token = "0x170008E9")]
	protected override string info
	{
		[Token(Token = "0x60073E4")]
		[Address(RVA = "0x10F4EA0", Offset = "0x10F3CA0", Length = "0x1C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60073E5")]
	[Address(RVA = "0x10F5070", Offset = "0x10F3E70", Length = "0x316")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073E6")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_CheckContainerPowder()
	{
	}
}

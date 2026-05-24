using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.Gear;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Container")]
[Description("Check if a named container has a required amount of liquid.")]
[Name("Container has Liquid", 0)]
[Token(Token = "0x200111E")]
public class Condition_CheckContainerLiquid : ConditionTask
{
	[RequiredField]
	[Token(Token = "0x4008763")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> m_ContainerId;

	[Token(Token = "0x4008764")]
	[FieldOffset(Offset = "0x70")]
	public LiquidType m_Liquid;

	[Tooltip("Required amount of liquid, in litres.")]
	[Token(Token = "0x4008765")]
	[FieldOffset(Offset = "0x78")]
	public float m_RequiredAmount;

	[Token(Token = "0x170008E8")]
	protected override string info
	{
		[Token(Token = "0x60073E1")]
		[Address(RVA = "0x10F4870", Offset = "0x10F3670", Length = "0x1C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60073E2")]
	[Address(RVA = "0x10F4A40", Offset = "0x10F3840", Length = "0x457")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073E3")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_CheckContainerLiquid()
	{
	}
}

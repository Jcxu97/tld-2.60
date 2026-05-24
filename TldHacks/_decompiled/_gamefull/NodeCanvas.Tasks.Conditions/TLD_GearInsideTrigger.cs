using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Name("Gear Inside Trigger Box", 0)]
[Token(Token = "0x2001119")]
public class TLD_GearInsideTrigger : ConditionTask<BoxCollider>
{
	[Token(Token = "0x4008756")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GearItem> gearitem;

	[Token(Token = "0x170008E3")]
	protected override string info
	{
		[Token(Token = "0x60073D0")]
		[Address(RVA = "0x10F28D0", Offset = "0x10F16D0", Length = "0xEA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60073D1")]
	[Address(RVA = "0x10F29C0", Offset = "0x10F17C0", Length = "0x62E")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073D2")]
	[Address(RVA = "0x10F2FF0", Offset = "0x10F1DF0", Length = "0x44")]
	public TLD_GearInsideTrigger()
	{
	}
}

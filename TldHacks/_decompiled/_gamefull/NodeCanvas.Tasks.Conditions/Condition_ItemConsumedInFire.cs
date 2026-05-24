using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Description("returns true if a given named item has been consumed in a fire inside an optional given volume (leave empty to check all fires)")]
[Name("Item Consumed In Fire", 0)]
[Token(Token = "0x200114E")]
public class Condition_ItemConsumedInFire : ConditionTask
{
	[Token(Token = "0x40087C9")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> itemName;

	[Token(Token = "0x40087CA")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> collisionVolumeMissionObjectIdentifier;

	[Token(Token = "0x17000904")]
	protected override string info
	{
		[Token(Token = "0x6007474")]
		[Address(RVA = "0x10FF430", Offset = "0x10FE230", Length = "0x11A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007475")]
	[Address(RVA = "0x10FF550", Offset = "0x10FE350", Length = "0x6F7")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007476")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_ItemConsumedInFire()
	{
	}
}

using Cpp2ILInjected;
using TLD.Logging;
using UnityEngine;

namespace TLD.Gear.Migration;

[Token(Token = "0x200144A")]
public class MigrateFromStacksToLiquid : MonoBehaviour
{
	[Token(Token = "0x40093A1")]
	private static readonly LogFilter s_LogFilter;

	[SerializeField]
	[Token(Token = "0x40093A2")]
	[FieldOffset(Offset = "0x20")]
	private float m_PreviousBaseWeightKG;

	[SerializeField]
	[Token(Token = "0x40093A3")]
	[FieldOffset(Offset = "0x24")]
	private int m_UnitsPerItem;

	[Token(Token = "0x600813F")]
	[Address(RVA = "0x1219740", Offset = "0x1218540", Length = "0x1E0")]
	public void MigrateToLiquid(GearItem gearItem, StackableItemSaveDataProxy saveData, ILiquidContainer targetContainer)
	{
	}

	[Token(Token = "0x6008140")]
	[Address(RVA = "0x1219930", Offset = "0x1218730", Length = "0x2E8")]
	private void MigrateSingleContainer(GearItem gearItem, int numUnits, ILiquidContainer targetContainer)
	{
	}

	[Token(Token = "0x6008141")]
	[Address(RVA = "0x1219C20", Offset = "0x1218A20", Length = "0x98")]
	private GearItem CloneGearItem(GearItem gearItem)
	{
		return null;
	}

	[Token(Token = "0x6008142")]
	[Address(RVA = "0x1219CC0", Offset = "0x1218AC0", Length = "0x51")]
	public MigrateFromStacksToLiquid()
	{
	}
}

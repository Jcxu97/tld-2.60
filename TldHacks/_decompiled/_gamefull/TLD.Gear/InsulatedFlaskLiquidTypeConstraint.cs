using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Gear;

[CreateAssetMenu(fileName = "LiquidContentRestriction_New Liquid Restriction", menuName = "The Long Dark/Gear/Insulated Flask Content Restriction")]
[Token(Token = "0x2001425")]
public class InsulatedFlaskLiquidTypeConstraint : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x40092FD")]
	[FieldOffset(Offset = "0x18")]
	private List<AssetReferenceLiquidType> m_AllowedLiquids;

	[Token(Token = "0x40092FE")]
	[FieldOffset(Offset = "0x20")]
	private AsyncOperationHandle<IList<LiquidType>> m_LoadOp;

	[Token(Token = "0x6008079")]
	[Address(RVA = "0x120A9A0", Offset = "0x12097A0", Length = "0x10C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600807A")]
	[Address(RVA = "0x120AAB0", Offset = "0x12098B0", Length = "0x271")]
	public bool IsAllowed(GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x600807B")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public InsulatedFlaskLiquidTypeConstraint()
	{
	}
}

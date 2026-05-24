using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.IntBackedUnit;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x200046A")]
public class WeightReductionBuff : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40027DB")]
	[FieldOffset(Offset = "0x20")]
	private AssetReferenceT<GearItemData>[] m_Targets;

	[SerializeField]
	[Token(Token = "0x40027DC")]
	[FieldOffset(Offset = "0x28")]
	private int m_AffectedItems;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x40027DD")]
	[FieldOffset(Offset = "0x2C")]
	private float m_WeightReduction;

	[Token(Token = "0x40027DE")]
	[FieldOffset(Offset = "0x30")]
	private List<GearItemData> m_ValidTargets;

	[Token(Token = "0x40027DF")]
	[FieldOffset(Offset = "0x38")]
	private ItemWeight m_CachedWeightReduction;

	[Token(Token = "0x40027E0")]
	[FieldOffset(Offset = "0x40")]
	private AsyncOperationHandle<IList<GearItemData>> m_OperationHandle;

	[Token(Token = "0x40027E1")]
	[FieldOffset(Offset = "0x58")]
	private GearItem m_GearItem;

	[Token(Token = "0x40027E2")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsDirty;

	[Token(Token = "0x600212C")]
	[Address(RVA = "0x80C870", Offset = "0x80B670", Length = "0x168")]
	private void Awake()
	{
	}

	[Token(Token = "0x600212D")]
	[Address(RVA = "0x80C9E0", Offset = "0x80B7E0", Length = "0x335")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600212E")]
	[Address(RVA = "0x7DF760", Offset = "0x7DE560", Length = "0x5")]
	private void HandleOnInventoryChanged(GearItem _)
	{
	}

	[Token(Token = "0x600212F")]
	[Address(RVA = "0x80CD20", Offset = "0x80BB20", Length = "0x203")]
	private void InitializeTargets()
	{
	}

	[Token(Token = "0x6002130")]
	[Address(RVA = "0x80CF30", Offset = "0x80BD30", Length = "0x221")]
	private bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x6002131")]
	[Address(RVA = "0x80D160", Offset = "0x80BF60", Length = "0x92")]
	public ItemWeight GetWeightReduction()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6002132")]
	[Address(RVA = "0x80D200", Offset = "0x80C000", Length = "0x285")]
	private void CalculateWeightReduction()
	{
	}

	[Token(Token = "0x6002133")]
	[Address(RVA = "0x80D490", Offset = "0x80C290", Length = "0x451")]
	private void GetTargetsByWeight(List<GearItem> targets)
	{
	}

	[Token(Token = "0x6002134")]
	[Address(RVA = "0x80D8F0", Offset = "0x80C6F0", Length = "0x55")]
	public WeightReductionBuff()
	{
	}
}

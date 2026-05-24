using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[CreateAssetMenu(order = 10002)]
[Token(Token = "0x20004F5")]
public class AfflictionDefinitionTable : ScriptableObject
{
	[Token(Token = "0x20004F6")]
	private class AfflictionTypeComparer : IEqualityComparer<AfflictionType>
	{
		[Token(Token = "0x4002D75")]
		public static readonly AfflictionTypeComparer Default;

		[Token(Token = "0x6002588")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		private AfflictionTypeComparer()
		{
		}

		[Token(Token = "0x6002589")]
		[Address(RVA = "0x5DC750", Offset = "0x5DB550", Length = "0x7")]
		public bool Equals(AfflictionType x, AfflictionType y)
		{
			return false;
		}

		[Token(Token = "0x600258A")]
		[Address(RVA = "0x5DC760", Offset = "0x5DB560", Length = "0x3")]
		public int GetHashCode(AfflictionType afflictionType)
		{
			return 0;
		}
	}

	[SerializeField]
	[Token(Token = "0x4002D71")]
	[FieldOffset(Offset = "0x18")]
	private AssetLabelReference m_AfflictionLabel;

	[Token(Token = "0x4002D72")]
	[FieldOffset(Offset = "0x20")]
	private AsyncOperationHandle<IList<AfflictionDefinition>> m_AfflictionsHandle;

	[Token(Token = "0x4002D73")]
	[FieldOffset(Offset = "0x38")]
	private readonly Dictionary<AfflictionType, List<AfflictionDefinition>> m_AfflictionsPerTypeMap;

	[Token(Token = "0x4002D74")]
	[FieldOffset(Offset = "0x40")]
	private readonly Dictionary<string, AfflictionDefinition> m_AfflictionPerNameMap;

	[Token(Token = "0x17000253")]
	public AssetLabelReference AfflictionLabel
	{
		[Token(Token = "0x6002583")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002584")]
	[Address(RVA = "0x87CCF0", Offset = "0x87BAF0", Length = "0xCC")]
	public AfflictionDefinition GetAfflictionDefinitionByType(AfflictionType afflictionType)
	{
		return null;
	}

	[Token(Token = "0x6002585")]
	[Address(RVA = "0x87CDC0", Offset = "0x87BBC0", Length = "0x87")]
	public AfflictionDefinition GetAfflictionDefinitionByName(string afflictionName)
	{
		return null;
	}

	[Token(Token = "0x6002586")]
	[Address(RVA = "0x87CE50", Offset = "0x87BC50", Length = "0x5A0")]
	private void MaybeLoadAfflictions()
	{
	}

	[Token(Token = "0x6002587")]
	[Address(RVA = "0x87D400", Offset = "0x87C200", Length = "0x1A2")]
	public AfflictionDefinitionTable()
	{
	}
}

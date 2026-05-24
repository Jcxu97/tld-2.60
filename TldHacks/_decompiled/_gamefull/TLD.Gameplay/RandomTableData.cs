using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Logging;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Serialization;

namespace TLD.Gameplay;

[Token(Token = "0x2001492")]
public abstract class RandomTableData : ScriptableObject
{
	[Token(Token = "0x17000B56")]
	public abstract bool CanDrawFromTable
	{
		[Token(Token = "0x6008290")]
		get;
	}

	[Token(Token = "0x17000B57")]
	[field: Token(Token = "0x400953E")]
	[field: FieldOffset(Offset = "0x18")]
	public Func<int, int, int> CustomRandomRange
	{
		[Token(Token = "0x6008294")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		protected get;
		[Token(Token = "0x6008295")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		set;
	}

	[Token(Token = "0x17000B58")]
	protected Func<int, int, int> RandomRange
	{
		[Token(Token = "0x6008296")]
		[Address(RVA = "0x123B9D0", Offset = "0x123A7D0", Length = "0x64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008291")]
	public abstract int DrawRandomPrefabs(int wantedPrefabs, List<GameObject> drawnPrefabs, bool allowDuplicates = true);

	[Token(Token = "0x6008292")]
	public abstract GameObject DrawRandomPrefab();

	[Token(Token = "0x6008293")]
	public abstract GameObject GetPrefabByName(string prefabName);

	[Token(Token = "0x6008297")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	protected RandomTableData()
	{
	}
}
[Token(Token = "0x2001493")]
public class RandomTableData<T> : RandomTableData where T : AssetReferenceGameObject
{
	[Token(Token = "0x400953F")]
	public static readonly LogFilter s_LogFilter;

	[FormerlySerializedAs("m_BaseLoot")]
	[SerializeField]
	[Token(Token = "0x4009540")]
	[FieldOffset(Offset = "0x0")]
	private List<RandomTableDataEntry<T>> m_BaseEntries;

	[Token(Token = "0x4009541")]
	[FieldOffset(Offset = "0x0")]
	protected readonly List<T> m_FilteredExtendedItems;

	[Token(Token = "0x4009542")]
	[FieldOffset(Offset = "0x0")]
	private readonly Dictionary<IKeyEvaluator, AsyncOperationHandle<GameObject>> m_ExistingOperations;

	[Token(Token = "0x17000B59")]
	public override bool CanDrawFromTable
	{
		[Token(Token = "0x6008298")]
		[Address(RVA = "0x1EFA3B0", Offset = "0x1EF91B0", Length = "0x37")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6008299")]
	[Address(RVA = "0x1EFA3F0", Offset = "0x1EF91F0", Length = "0x322")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600829A")]
	[Address(RVA = "0x1EFA720", Offset = "0x1EF9520", Length = "0x1A3")]
	private void MaybeInitializeTable()
	{
	}

	[Token(Token = "0x600829B")]
	[Address(RVA = "0x1EFA8D0", Offset = "0x1EF96D0", Length = "0x1C6")]
	protected void FilterEntries()
	{
	}

	[Token(Token = "0x600829C")]
	[Address(RVA = "0x1EFAAA0", Offset = "0x1EF98A0", Length = "0x16")]
	protected virtual int GetEntryWeight(RandomTableDataEntry<T> entry)
	{
		return 0;
	}

	[Token(Token = "0x600829D")]
	[Address(RVA = "0x1EFAAC0", Offset = "0x1EF98C0", Length = "0x3F")]
	protected virtual bool ShouldFilterOutItem(T item)
	{
		return false;
	}

	[Token(Token = "0x600829E")]
	[Address(RVA = "0x1EFAB00", Offset = "0x1EF9900", Length = "0xC6")]
	protected virtual bool ShouldFilterOutPrefab(GameObject prefab)
	{
		return false;
	}

	[Token(Token = "0x600829F")]
	[Address(RVA = "0x1EFABD0", Offset = "0x1EF99D0", Length = "0x285")]
	public int DrawRandomItems(int wantedItems, List<T> drawnItems, bool allowDuplicates = true)
	{
		return 0;
	}

	[Token(Token = "0x60082A0")]
	[Address(RVA = "0x1EFAE60", Offset = "0x1EF9C60", Length = "0xBF")]
	public T DrawRandomItem()
	{
		return null;
	}

	[Token(Token = "0x60082A1")]
	[Address(RVA = "0x1EFAF20", Offset = "0x1EF9D20", Length = "0x2BD")]
	public override int DrawRandomPrefabs(int wantedPrefabs, List<GameObject> drawnPrefabs, bool allowDuplicates = true)
	{
		return 0;
	}

	[Token(Token = "0x60082A2")]
	[Address(RVA = "0x1EFB1E0", Offset = "0x1EF9FE0", Length = "0x4E")]
	public override GameObject DrawRandomPrefab()
	{
		return null;
	}

	[Token(Token = "0x60082A3")]
	[Address(RVA = "0x1EFB230", Offset = "0x1EFA030", Length = "0x1BF")]
	public override GameObject GetPrefabByName(string itemName)
	{
		return null;
	}

	[Token(Token = "0x60082A4")]
	[Address(RVA = "0x1EFB3F0", Offset = "0x1EFA1F0", Length = "0x164")]
	protected GameObject LoadPrefab(T item)
	{
		return null;
	}

	[Token(Token = "0x60082A5")]
	[Address(RVA = "0x1EFB560", Offset = "0x1EFA360", Length = "0x217")]
	public RandomTableData()
	{
	}
}

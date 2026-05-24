using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Events;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Scenes;

[CreateAssetMenu(menuName = "The Long Dark/Events/World Map Changed")]
[Token(Token = "0x2001366")]
public class WorldMapChangedEvent : GameEvent
{
	[SerializeField]
	[Token(Token = "0x4008EBC")]
	[FieldOffset(Offset = "0x20")]
	private AssetLabelReference m_WorldMapLabel;

	[SerializeField]
	[Token(Token = "0x4008EBD")]
	[FieldOffset(Offset = "0x28")]
	private WorldMapSpecification m_CoreRegionWorldMap;

	[Token(Token = "0x4008EBF")]
	[FieldOffset(Offset = "0x38")]
	private readonly List<WorldMapSpecification> m_AllMaps;

	[Token(Token = "0x4008EC0")]
	[FieldOffset(Offset = "0x40")]
	private readonly List<WorldMapSpecification> m_AvailableMaps;

	[Token(Token = "0x4008EC1")]
	[FieldOffset(Offset = "0x48")]
	private bool m_InitializedAllMaps;

	[Token(Token = "0x17000A67")]
	[field: Token(Token = "0x4008EBE")]
	[field: FieldOffset(Offset = "0x30")]
	public WorldMapSpecification CurrentMap
	{
		[Token(Token = "0x6007BDC")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get;
		[Token(Token = "0x6007BDD")]
		[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000A68")]
	public bool IsCoreRegionMapSelected
	{
		[Token(Token = "0x6007BE0")]
		[Address(RVA = "0x11AC000", Offset = "0x11AAE00", Length = "0x1CD")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007BDE")]
	[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
	public IList<WorldMapSpecification> GetAllWorldMaps()
	{
		return null;
	}

	[Token(Token = "0x6007BDF")]
	[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
	public IList<WorldMapSpecification> GetAvailableWorldMaps()
	{
		return null;
	}

	[Token(Token = "0x6007BE1")]
	[Address(RVA = "0x11AC1D0", Offset = "0x11AAFD0", Length = "0x5C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007BE2")]
	[Address(RVA = "0x11AC230", Offset = "0x11AB030", Length = "0x197")]
	public void SetCurrentMap(WorldMapSpecification worldMap)
	{
	}

	[Token(Token = "0x6007BE3")]
	[Address(RVA = "0x11AC3D0", Offset = "0x11AB1D0", Length = "0x274")]
	public WorldMapSpecification GetNextAvailableWorldMap()
	{
		return null;
	}

	[Token(Token = "0x6007BE4")]
	[Address(RVA = "0x11AC650", Offset = "0x11AB450", Length = "0x623")]
	public void UpdateAvailableWorldMaps()
	{
	}

	[Token(Token = "0x6007BE5")]
	[Address(RVA = "0x11ACC80", Offset = "0x11ABA80", Length = "0x107")]
	private void UpdateAllMaps()
	{
	}

	[Token(Token = "0x6007BE6")]
	[Address(RVA = "0x11ACD90", Offset = "0x11ABB90", Length = "0x280")]
	private static bool DoesMapHaveUnlockedRegions(WorldMapSpecification map, IEnumerable<RegionSpecification> regions)
	{
		return false;
	}

	[Token(Token = "0x6007BE7")]
	[Address(RVA = "0x11AD020", Offset = "0x11ABE20", Length = "0x501")]
	private static bool HasValidStartingRegionsForGameMode(WorldMapSpecification map, IEnumerable<RegionSpecification> regions)
	{
		return false;
	}

	[Token(Token = "0x6007BE8")]
	[Address(RVA = "0x11AD530", Offset = "0x11AC330", Length = "0x142")]
	public WorldMapChangedEvent()
	{
	}
}

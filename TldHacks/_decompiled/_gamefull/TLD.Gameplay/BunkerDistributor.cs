using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Scenes.ObjectReferences;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Gameplay/Bunker Distributor")]
[Token(Token = "0x200145D")]
public class BunkerDistributor : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200145E")]
	private class BunkerLocationInteriorPair
	{
		[Token(Token = "0x40093E8")]
		[FieldOffset(Offset = "0x10")]
		public readonly BunkerLocationReference m_LocationReference;

		[Token(Token = "0x40093E9")]
		[FieldOffset(Offset = "0x18")]
		public readonly BunkerInteriorSpecification m_ReplacementInterior;

		[Token(Token = "0x60081AE")]
		[Address(RVA = "0x1223E70", Offset = "0x1222C70", Length = "0x21B")]
		public BunkerLocationInteriorPair(BunkerLocationReference bunkerLocation, BunkerInteriorSpecification bunkerInterior)
		{
		}

		[Token(Token = "0x60081AF")]
		[Address(RVA = "0x1224090", Offset = "0x1222E90", Length = "0xBE")]
		public void Detach()
		{
		}

		[Token(Token = "0x60081B0")]
		[Address(RVA = "0x1224150", Offset = "0x1222F50", Length = "0x15F")]
		private void Attach()
		{
		}

		[Token(Token = "0x60081B1")]
		[Address(RVA = "0x12242B0", Offset = "0x12230B0", Length = "0x34B")]
		private void ApplyInterior(SceneObjectReference reference, GameObject owner)
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x40093E4")]
	[FieldOffset(Offset = "0x18")]
	private AssetLabelReference m_BunkerLocationLabel;

	[SerializeField]
	[Token(Token = "0x40093E5")]
	[FieldOffset(Offset = "0x20")]
	private BunkerInteriorSpecification[] m_BunkerInteriors;

	[Token(Token = "0x40093E6")]
	[FieldOffset(Offset = "0x28")]
	private readonly List<BunkerLocationInteriorPair> m_Replacements;

	[Token(Token = "0x40093E7")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<BunkerLocationSaveData> m_SaveData;

	[Token(Token = "0x60081A6")]
	[Address(RVA = "0x12220C0", Offset = "0x1220EC0", Length = "0xDDD")]
	public void DistributeBunkerInteriors()
	{
	}

	[Token(Token = "0x60081A7")]
	[Address(RVA = "0x1222EA0", Offset = "0x1221CA0", Length = "0x3D8")]
	public List<BunkerLocationSaveData> Serialize()
	{
		return null;
	}

	[Token(Token = "0x60081A8")]
	[Address(RVA = "0x1223280", Offset = "0x1222080", Length = "0x59F")]
	public void Deserialize(List<BunkerLocationSaveData> savedData)
	{
	}

	[Token(Token = "0x60081A9")]
	[Address(RVA = "0x1223820", Offset = "0x1222620", Length = "0x259")]
	public void ClearReplacementData()
	{
	}

	[Token(Token = "0x60081AA")]
	[Address(RVA = "0x1223A80", Offset = "0x1222880", Length = "0x7")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60081AB")]
	[Address(RVA = "0x1223A90", Offset = "0x1222890", Length = "0xEA")]
	private BunkerLocationReference FindBunkerLocation(IList<BunkerLocationReference> bunkerLocations, string bunkerId)
	{
		return null;
	}

	[Token(Token = "0x60081AC")]
	[Address(RVA = "0x1223B80", Offset = "0x1222980", Length = "0x17E")]
	private BunkerInteriorSpecification FindBunkerInterior(string interiorId)
	{
		return null;
	}

	[Token(Token = "0x60081AD")]
	[Address(RVA = "0x1223D00", Offset = "0x1222B00", Length = "0x162")]
	public BunkerDistributor()
	{
	}
}

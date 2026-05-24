using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Token(Token = "0x2000299")]
public class ConsoleManagerSettings : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200029A")]
	public class KeyToGearItem
	{
		[Token(Token = "0x4001775")]
		[FieldOffset(Offset = "0x10")]
		public string m_Key;

		[Token(Token = "0x4001776")]
		[FieldOffset(Offset = "0x18")]
		public AssetReferenceGearItem m_GearItemReference;

		[Token(Token = "0x600164A")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public KeyToGearItem()
		{
		}
	}

	[Token(Token = "0x4001772")]
	[FieldOffset(Offset = "0x18")]
	public AssetLabelReference m_GearItemDataLabel;

	[Token(Token = "0x4001773")]
	[FieldOffset(Offset = "0x20")]
	public KeyToGearItem[] m_CustomGearItemSearchTerms;

	[Tooltip("Used for the add_type command to spawn all gear items with the corresponding component")]
	[Token(Token = "0x4001774")]
	[FieldOffset(Offset = "0x28")]
	public string[] m_GearItemComponentNames;

	[Token(Token = "0x6001649")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public ConsoleManagerSettings()
	{
	}
}

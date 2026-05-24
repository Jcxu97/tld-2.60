using System;
using System.Collections.Generic;
using System.ComponentModel;
using Cpp2ILInjected;
using TLD.IntBackedUnit;
using UnityEngine.AddressableAssets;

[Token(Token = "0x2000567")]
public class CuringStorageState
{
	[Token(Token = "0x2000568")]
	public class CuringItem
	{
		[Token(Token = "0x40031E4")]
		[FieldOffset(Offset = "0x10")]
		public float m_LastUpdateHour;

		[Token(Token = "0x40031E5")]
		[FieldOffset(Offset = "0x14")]
		public float m_HoursCured;

		[Token(Token = "0x40031E6")]
		[FieldOffset(Offset = "0x18")]
		public float m_HoursRotting;

		[Token(Token = "0x40031E7")]
		[FieldOffset(Offset = "0x1C")]
		public bool m_IsFish;

		[Token(Token = "0x40031E8")]
		[FieldOffset(Offset = "0x20")]
		public AssetReference m_PrefabReference;

		[Token(Token = "0x40031E9")]
		[FieldOffset(Offset = "0x28")]
		public float m_NormalizedCondition;

		[DefaultValue(1f)]
		[Token(Token = "0x40031EA")]
		[FieldOffset(Offset = "0x2C")]
		public float m_RemainingFraction;

		[NonSerialized]
		[Token(Token = "0x40031EB")]
		[FieldOffset(Offset = "0x30")]
		public GearItem m_InstantiatedItem;

		[NonSerialized]
		[Token(Token = "0x40031EC")]
		[FieldOffset(Offset = "0x38")]
		public bool m_HasFinishedCuring;

		[Token(Token = "0x6002984")]
		[Address(RVA = "0x8EC830", Offset = "0x8EB630", Length = "0x8")]
		public CuringItem()
		{
		}
	}

	[Token(Token = "0x40031E0")]
	[FieldOffset(Offset = "0x10")]
	public string m_GUID;

	[Token(Token = "0x40031E1")]
	[FieldOffset(Offset = "0x18")]
	public ItemWeight m_SaltStorage;

	[Token(Token = "0x40031E2")]
	[FieldOffset(Offset = "0x20")]
	public float m_LastUpdateHour;

	[Token(Token = "0x40031E3")]
	[FieldOffset(Offset = "0x28")]
	public List<CuringItem> m_CuringItems;

	[Token(Token = "0x6002983")]
	[Address(RVA = "0x8EC780", Offset = "0x8EB580", Length = "0xAD")]
	public CuringStorageState()
	{
	}
}

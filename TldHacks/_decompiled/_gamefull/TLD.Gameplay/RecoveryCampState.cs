using System.Collections.Generic;
using System.ComponentModel;
using Cpp2ILInjected;
using TLD.Placement;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

[Token(Token = "0x200147C")]
public class RecoveryCampState
{
	[Token(Token = "0x200147D")]
	public class RecoveryItem
	{
		[Token(Token = "0x40094BE")]
		[FieldOffset(Offset = "0x10")]
		public AssetReference m_PrefabReference;

		[Token(Token = "0x40094BF")]
		[FieldOffset(Offset = "0x18")]
		public GearItemSaveDataProxy m_SerializedGear;

		[Token(Token = "0x40094C0")]
		[FieldOffset(Offset = "0x20")]
		public bool m_IsInContainer;

		[Token(Token = "0x600823F")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public RecoveryItem()
		{
		}
	}

	[Token(Token = "0x200147E")]
	public class RecoveryDecorationItem
	{
		[Token(Token = "0x40094C1")]
		[FieldOffset(Offset = "0x10")]
		public string m_GUID;

		[Token(Token = "0x40094C2")]
		[FieldOffset(Offset = "0x18")]
		public PlaceableSaveData m_PlaceableSaveData;

		[Token(Token = "0x6008240")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public RecoveryDecorationItem()
		{
		}
	}

	[Token(Token = "0x40094B8")]
	[FieldOffset(Offset = "0x10")]
	public string m_Scene;

	[Token(Token = "0x40094B9")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 m_Position;

	[Token(Token = "0x40094BA")]
	[FieldOffset(Offset = "0x28")]
	public string m_CampsiteGUID;

	[DefaultValue(true)]
	[Token(Token = "0x40094BB")]
	[FieldOffset(Offset = "0x30")]
	public bool m_SignalFireActive;

	[Token(Token = "0x40094BC")]
	[FieldOffset(Offset = "0x38")]
	public readonly List<RecoveryItem> m_RecoveryItems;

	[Token(Token = "0x40094BD")]
	[FieldOffset(Offset = "0x40")]
	public readonly List<RecoveryDecorationItem> m_RecoveryDecorationItems;

	[Token(Token = "0x600823E")]
	[Address(RVA = "0x122DDE0", Offset = "0x122CBE0", Length = "0x159")]
	public RecoveryCampState()
	{
	}
}

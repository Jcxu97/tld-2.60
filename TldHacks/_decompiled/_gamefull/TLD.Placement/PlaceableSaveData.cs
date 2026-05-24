using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Placement;

[Serializable]
[Token(Token = "0x2001374")]
public class PlaceableSaveData
{
	[Token(Token = "0x4008F1D")]
	[FieldOffset(Offset = "0x10")]
	public bool m_ActiveSelf;

	[Token(Token = "0x4008F1E")]
	[FieldOffset(Offset = "0x18")]
	public string m_Name;

	[Token(Token = "0x4008F1F")]
	[FieldOffset(Offset = "0x20")]
	public AssetReferencePlaceable m_Addressable;

	[Token(Token = "0x4008F20")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 m_Position;

	[Token(Token = "0x4008F21")]
	[FieldOffset(Offset = "0x34")]
	public Quaternion m_Rotation;

	[Token(Token = "0x4008F22")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 m_Scale;

	[Token(Token = "0x4008F23")]
	[FieldOffset(Offset = "0x50")]
	public InProgressCraftItem.InProgressCraftItemSaveDataProxy m_InProgress;

	[Token(Token = "0x6007C4F")]
	[Address(RVA = "0x11B3080", Offset = "0x11B1E80", Length = "0x4E")]
	public PlaceableSaveData()
	{
	}
}

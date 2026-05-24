using System;
using Cpp2ILInjected;
using TLD.Logging;
using UnityEngine;

namespace TLD.Placement;

[Token(Token = "0x2001375")]
public class Placeable : MonoBehaviour
{
	[Token(Token = "0x4008F24")]
	private const string SPAWNED_NAME_SUFFIX = "(PLACED)";

	[Token(Token = "0x4008F25")]
	public static LogFilter LogFilter;

	[NonSerialized]
	[Token(Token = "0x4008F26")]
	[FieldOffset(Offset = "0x20")]
	public string m_Guid;

	[Token(Token = "0x4008F27")]
	[FieldOffset(Offset = "0x28")]
	public AssetReferencePlaceable m_Addressable;

	[Token(Token = "0x4008F28")]
	[FieldOffset(Offset = "0x30")]
	private bool m_Invalidated;

	[Token(Token = "0x6007C50")]
	[Address(RVA = "0x11B30D0", Offset = "0x11B1ED0", Length = "0x202")]
	public void Awake()
	{
	}

	[Token(Token = "0x6007C51")]
	[Address(RVA = "0x11B32E0", Offset = "0x11B20E0", Length = "0x5")]
	public void Invalidate()
	{
	}

	[Token(Token = "0x6007C52")]
	[Address(RVA = "0x11B32F0", Offset = "0x11B20F0", Length = "0x546")]
	public PlaceableSaveData Serialize()
	{
		return null;
	}

	[Token(Token = "0x6007C53")]
	[Address(RVA = "0x11B3840", Offset = "0x11B2640", Length = "0x60A")]
	private void Deserialize(string guid, PlaceableSaveData data)
	{
	}

	[Token(Token = "0x6007C54")]
	[Address(RVA = "0x11B3E50", Offset = "0x11B2C50", Length = "0xA1")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007C55")]
	[Address(RVA = "0x11B3F00", Offset = "0x11B2D00", Length = "0x16C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007C56")]
	[Address(RVA = "0x11B4070", Offset = "0x11B2E70", Length = "0xBF")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6007C57")]
	[Address(RVA = "0x11B4130", Offset = "0x11B2F30", Length = "0x5A")]
	private void RemoveIfValid()
	{
	}

	[Token(Token = "0x6007C58")]
	[Address(RVA = "0x11B4190", Offset = "0x11B2F90", Length = "0x43E")]
	public static Placeable FindOrCreateAndDeserialize(string guid, PlaceableSaveData data)
	{
		return null;
	}

	[Token(Token = "0x6007C59")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Placeable()
	{
	}
}

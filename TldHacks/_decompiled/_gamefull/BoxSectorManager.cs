using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Logging;
using UnityEngine;

[Token(Token = "0x20009AF")]
public class BoxSectorManager : MonoBehaviour
{
	[Token(Token = "0x20009B0")]
	public enum SectorCullMode
	{
		[Token(Token = "0x400631F")]
		DisableObject,
		[Token(Token = "0x4006320")]
		DisableRenderer
	}

	[Token(Token = "0x20009B1")]
	public enum SectorVisMode
	{
		[Token(Token = "0x4006322")]
		ShowVisListOnEnter,
		[Token(Token = "0x4006323")]
		HideVisListOnEnter
	}

	[Token(Token = "0x4006312")]
	public static BoxSectorManager s_Instance;

	[Token(Token = "0x4006313")]
	[FieldOffset(Offset = "0x20")]
	public List<BoxSector> m_PrimarySectorList;

	[Token(Token = "0x4006314")]
	[FieldOffset(Offset = "0x28")]
	public SectorCullMode m_SectorCullMode;

	[Token(Token = "0x4006315")]
	[FieldOffset(Offset = "0x2C")]
	public SectorVisMode m_SectorVisMode;

	[Tooltip("When true, all sectors will be activated if the player leaves the box sector system. Otherwise all sectors will be disabled")]
	[Token(Token = "0x4006316")]
	[FieldOffset(Offset = "0x30")]
	public bool m_ActivateAllOnExit;

	[Token(Token = "0x4006317")]
	[FieldOffset(Offset = "0x31")]
	public bool m_UpdateSectorsOnStart;

	[Tooltip("Find all box sectors which are children of the box sector manager. Otherwise use only what's explicitly referenced, like if box sectors are scattered in the world within prefabs")]
	[Token(Token = "0x4006318")]
	[FieldOffset(Offset = "0x32")]
	public bool m_FindSectorsOnStart;

	[Token(Token = "0x4006319")]
	[FieldOffset(Offset = "0x38")]
	private List<BoxSector> m_CurrentSectors;

	[Token(Token = "0x400631A")]
	[FieldOffset(Offset = "0x40")]
	private BoxSector m_CurSector;

	[Token(Token = "0x400631B")]
	[FieldOffset(Offset = "0x48")]
	private BoxSector m_LastSector;

	[Token(Token = "0x400631C")]
	[FieldOffset(Offset = "0x50")]
	private DecorationItem[] m_InitialRemovedDecorationItems;

	[Token(Token = "0x400631D")]
	private static readonly LogFilter s_LogFilter;

	[Token(Token = "0x600562C")]
	[Address(RVA = "0xEB2040", Offset = "0xEB0E40", Length = "0x55B")]
	private void Awake()
	{
	}

	[Token(Token = "0x600562D")]
	[Address(RVA = "0xEB25A0", Offset = "0xEB13A0", Length = "0x13A")]
	public void InitialRemoveAllDecorations()
	{
	}

	[Token(Token = "0x600562E")]
	[Address(RVA = "0xEB26E0", Offset = "0xEB14E0", Length = "0x1C5")]
	public bool HasBeenInitiallyRemoved(DecorationItem decorationItem)
	{
		return false;
	}

	[Token(Token = "0x600562F")]
	[Address(RVA = "0xEB28B0", Offset = "0xEB16B0", Length = "0xC0")]
	public void AddSector(BoxSector sector)
	{
	}

	[Token(Token = "0x6005630")]
	[Address(RVA = "0xEB2980", Offset = "0xEB1780", Length = "0x88")]
	public void RemoveSector(BoxSector sector)
	{
	}

	[Token(Token = "0x6005631")]
	[Address(RVA = "0xEB2A10", Offset = "0xEB1810", Length = "0x891")]
	private void UpdateSectors()
	{
	}

	[Token(Token = "0x6005632")]
	[Address(RVA = "0xEB32B0", Offset = "0xEB20B0", Length = "0x110")]
	public void ForceAllActive()
	{
	}

	[Token(Token = "0x6005633")]
	[Address(RVA = "0xEB33D0", Offset = "0xEB21D0", Length = "0x110")]
	public void ForceAllInactive()
	{
	}

	[Token(Token = "0x6005634")]
	[Address(RVA = "0xEB34F0", Offset = "0xEB22F0", Length = "0x7")]
	public void RestoreSectorState()
	{
	}

	[Token(Token = "0x6005635")]
	[Address(RVA = "0xEB3500", Offset = "0xEB2300", Length = "0xE8")]
	public void MaybeAddDecorationIntoSystem(DecorationItem decor)
	{
	}

	[Token(Token = "0x6005636")]
	[Address(RVA = "0xEB35F0", Offset = "0xEB23F0", Length = "0x2A3")]
	public void RemoveDecorationFromSystem(DecorationItem decor)
	{
	}

	[Token(Token = "0x6005637")]
	[Address(RVA = "0xEB38A0", Offset = "0xEB26A0", Length = "0xE8")]
	public void RemoveDecorationFromSystemUsingOverlaps(DecorationItem decor)
	{
	}

	[Token(Token = "0x6005638")]
	[Address(RVA = "0xEB3990", Offset = "0xEB2790", Length = "0x472")]
	private BoxSector MaybeGetContactingBoxSector(DecorationItem decor)
	{
		return null;
	}

	[Token(Token = "0x6005639")]
	[Address(RVA = "0xEB3E10", Offset = "0xEB2C10", Length = "0xF2")]
	public BoxSectorManager()
	{
	}
}

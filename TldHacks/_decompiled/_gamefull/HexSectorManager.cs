using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009B7")]
public class HexSectorManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20009B8")]
	public struct HexExclusion
	{
		[Token(Token = "0x4006348")]
		[FieldOffset(Offset = "0x0")]
		public string m_Sector;

		[Token(Token = "0x4006349")]
		[FieldOffset(Offset = "0x8")]
		public List<string> m_ExclusionList;
	}

	[Serializable]
	[Token(Token = "0x20009B9")]
	public struct SystemInfo
	{
		[Token(Token = "0x400634A")]
		[FieldOffset(Offset = "0x0")]
		public string m_SystemTerrain;

		[Token(Token = "0x400634B")]
		[FieldOffset(Offset = "0x8")]
		public string m_SystemObjects;

		[Token(Token = "0x400634C")]
		[FieldOffset(Offset = "0x10")]
		public string m_SystemName;

		[Token(Token = "0x400634D")]
		[FieldOffset(Offset = "0x18")]
		public int m_SystemSize;

		[Token(Token = "0x400634E")]
		[FieldOffset(Offset = "0x1C")]
		public float m_LodDist0;

		[Token(Token = "0x400634F")]
		[FieldOffset(Offset = "0x20")]
		public float m_LodDist1;

		[Token(Token = "0x4006350")]
		[FieldOffset(Offset = "0x24")]
		public float m_LodDist2;

		[Token(Token = "0x4006351")]
		[FieldOffset(Offset = "0x28")]
		public List<HexExclusion> m_ExclusionInfo;
	}

	[Token(Token = "0x20009BA")]
	public enum SectorMode
	{
		[Token(Token = "0x4006353")]
		LOD,
		[Token(Token = "0x4006354")]
		Vista,
		[Token(Token = "0x4006355")]
		Scenes
	}

	[Token(Token = "0x400633A")]
	[FieldOffset(Offset = "0x20")]
	public List<HexSector> m_PrimarySectorList;

	[Header("Timers")]
	[Range(0.1f, 2f)]
	[Token(Token = "0x400633B")]
	[FieldOffset(Offset = "0x28")]
	public float m_UpdateFrequencySeconds;

	[Header("LOD minimum distances")]
	[Token(Token = "0x400633C")]
	[FieldOffset(Offset = "0x2C")]
	public float m_Lod0;

	[Token(Token = "0x400633D")]
	[FieldOffset(Offset = "0x30")]
	public float m_Lod1;

	[Token(Token = "0x400633E")]
	[FieldOffset(Offset = "0x34")]
	public float m_Lod2;

	[Header("The type of sectors to use: LOD only, LOD with vista objects, Scenes")]
	[Token(Token = "0x400633F")]
	[FieldOffset(Offset = "0x38")]
	public SectorMode m_SectorMode;

	[Token(Token = "0x4006340")]
	[FieldOffset(Offset = "0x3C")]
	private float m_ElapsedTimeSeconds;

	[Token(Token = "0x4006341")]
	[FieldOffset(Offset = "0x40")]
	private int m_CurSectorIndex;

	[Token(Token = "0x4006342")]
	[FieldOffset(Offset = "0x44")]
	private int m_PrvSectorIndex;

	[Token(Token = "0x4006343")]
	[FieldOffset(Offset = "0x48")]
	private float m_Lod0Adjusted;

	[Token(Token = "0x4006344")]
	[FieldOffset(Offset = "0x4C")]
	private float m_Lod1Adjusted;

	[Token(Token = "0x4006345")]
	[FieldOffset(Offset = "0x50")]
	private float m_Lod2Adjusted;

	[Token(Token = "0x4006346")]
	[FieldOffset(Offset = "0x54")]
	private QualityLodBias m_CachedLodBias;

	[Token(Token = "0x4006347")]
	[FieldOffset(Offset = "0x58")]
	private bool m_Initialized;

	[Token(Token = "0x6005645")]
	[Address(RVA = "0xEB55B0", Offset = "0xEB43B0", Length = "0x188")]
	private void Start()
	{
	}

	[Token(Token = "0x6005646")]
	[Address(RVA = "0xEB5740", Offset = "0xEB4540", Length = "0xE0")]
	private void Update()
	{
	}

	[Token(Token = "0x6005647")]
	[Address(RVA = "0xEB5830", Offset = "0xEB4630", Length = "0x22")]
	public void ForceUpdate()
	{
	}

	[Token(Token = "0x6005648")]
	[Address(RVA = "0xEB5860", Offset = "0xEB4660", Length = "0x467")]
	private int GetClosestSectorIndex()
	{
		return 0;
	}

	[Token(Token = "0x6005649")]
	[Address(RVA = "0xEB5CD0", Offset = "0xEB4AD0", Length = "0x891")]
	private void UpdateSectors()
	{
	}

	[Token(Token = "0x600564A")]
	[Address(RVA = "0xEB6570", Offset = "0xEB5370", Length = "0x149")]
	private void RefreshLodDistance()
	{
	}

	[Token(Token = "0x600564B")]
	[Address(RVA = "0xEB66C0", Offset = "0xEB54C0", Length = "0x5F")]
	public HexSectorManager()
	{
	}
}

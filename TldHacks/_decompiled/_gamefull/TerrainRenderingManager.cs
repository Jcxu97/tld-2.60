using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[Token(Token = "0x2000900")]
public class TerrainRenderingManager : MonoBehaviour
{
	[BurstCompile(CompileSynchronously = true, FloatPrecision = FloatPrecision.Medium, FloatMode = FloatMode.Fast)]
	[Token(Token = "0x2000901")]
	private struct TerrainDistanceJob : IJob
	{
		[ReadOnly]
		[Token(Token = "0x4005E57")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<float4> _terPosArr;

		[ReadOnly]
		[Token(Token = "0x4005E58")]
		[FieldOffset(Offset = "0x10")]
		public float4 _camPos;

		[Token(Token = "0x4005E59")]
		[FieldOffset(Offset = "0x20")]
		public NativeArray<float> _terSqrDistArr;

		[Token(Token = "0x600525A")]
		[Address(RVA = "0xE48A40", Offset = "0xE47840", Length = "0xD1")]
		public void Execute()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x4005E4B")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Loading> m_Loading;

	[Header("Terrain lists")]
	[Token(Token = "0x4005E4C")]
	[FieldOffset(Offset = "0x28")]
	public List<Terrain> m_TerrainList;

	[Token(Token = "0x4005E4D")]
	[FieldOffset(Offset = "0x30")]
	public List<Terrain> m_DistanceCheckList;

	[Header("Rendering")]
	[Token(Token = "0x4005E4E")]
	[FieldOffset(Offset = "0x38")]
	public float m_SmallDetailDistance;

	[Header("Optimizations")]
	[Tooltip("The minimum number of terrains needed to use the job system, otherwise use C# code.")]
	[Token(Token = "0x4005E4F")]
	[FieldOffset(Offset = "0x3C")]
	public int m_MinimumJobNumber;

	[Token(Token = "0x4005E50")]
	public static bool s_DebugTerrain;

	[Token(Token = "0x4005E51")]
	[FieldOffset(Offset = "0x40")]
	private float m_DistSqr;

	[Token(Token = "0x4005E52")]
	[FieldOffset(Offset = "0x48")]
	private NativeArray<float4> m_DistCheckTerrainPosArr;

	[Token(Token = "0x4005E53")]
	[FieldOffset(Offset = "0x58")]
	private NativeArray<float> m_DistCheckComputedDistanceArr;

	[Token(Token = "0x4005E54")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<Terrain, int> m_TerrainVisibilityDict;

	[Token(Token = "0x4005E55")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<Terrain, bool> m_TerrainTreeEnabled;

	[Token(Token = "0x4005E56")]
	private static bool s_TerrainTreeForceDisabled;

	[Token(Token = "0x6005250")]
	[Address(RVA = "0xE46A50", Offset = "0xE45850", Length = "0x7AA")]
	private void Start()
	{
	}

	[Token(Token = "0x6005251")]
	[Address(RVA = "0xE47200", Offset = "0xE46000", Length = "0x96")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005252")]
	[Address(RVA = "0xE472A0", Offset = "0xE460A0", Length = "0x2D7")]
	private Vector4 TerrainCentre(Vector3 worldPos, TerrainData tData)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6005253")]
	[Address(RVA = "0xE47580", Offset = "0xE46380", Length = "0x6B9")]
	private void Update()
	{
	}

	[Token(Token = "0x6005254")]
	[Address(RVA = "0xE47C40", Offset = "0xE46A40", Length = "0x421")]
	public void SetTerrainRendering(List<Terrain> extTerrainList, bool enableTerrain)
	{
	}

	[Token(Token = "0x6005255")]
	[Address(RVA = "0xE48070", Offset = "0xE46E70", Length = "0x331")]
	public static void ForceDisableTerrainTrees(bool forceDisabled)
	{
	}

	[Token(Token = "0x6005256")]
	[Address(RVA = "0xE483B0", Offset = "0xE471B0", Length = "0xF0")]
	public static void EnableTerrainTrees(Terrain t, bool enabled)
	{
	}

	[Token(Token = "0x6005257")]
	[Address(RVA = "0xE484B0", Offset = "0xE472B0", Length = "0x447")]
	public static string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x6005258")]
	[Address(RVA = "0xE48900", Offset = "0xE47700", Length = "0x3C")]
	public static bool IsDisabledTerrainTreesForced()
	{
		return false;
	}

	[Token(Token = "0x6005259")]
	[Address(RVA = "0xE48940", Offset = "0xE47740", Length = "0xF4")]
	public TerrainRenderingManager()
	{
	}
}

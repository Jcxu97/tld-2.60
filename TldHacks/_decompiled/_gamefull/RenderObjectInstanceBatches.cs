using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x20008EA")]
public class RenderObjectInstanceBatches
{
	[Token(Token = "0x20008EB")]
	private struct PerBatch
	{
		[Token(Token = "0x20008EC")]
		public struct RenderInfo
		{
			[Token(Token = "0x4005D84")]
			[FieldOffset(Offset = "0x0")]
			public Mesh m_Mesh;

			[Token(Token = "0x4005D85")]
			[FieldOffset(Offset = "0x8")]
			public Material[] m_Materials;

			[Token(Token = "0x4005D86")]
			[FieldOffset(Offset = "0x10")]
			public ShadowCastingMode m_CastShadows;

			[Token(Token = "0x4005D87")]
			[FieldOffset(Offset = "0x14")]
			public bool m_ReceiveShadows;
		}

		[Token(Token = "0x4005D7C")]
		[FieldOffset(Offset = "0x0")]
		public RenderInfo[] m_RenderInfos;

		[Token(Token = "0x4005D7D")]
		[FieldOffset(Offset = "0x8")]
		public ComputeBuffer[] m_VisiblesIndexes;

		[Token(Token = "0x4005D7E")]
		[FieldOffset(Offset = "0x10")]
		public NativeArray<int> m_StartIndexes;

		[Token(Token = "0x4005D7F")]
		[FieldOffset(Offset = "0x20")]
		public NativeArray<int> m_ObjectCounts;

		[Token(Token = "0x4005D80")]
		[FieldOffset(Offset = "0x30")]
		public NativeArray<int> m_VisibleCounts;

		[Token(Token = "0x4005D81")]
		[FieldOffset(Offset = "0x40")]
		public NativeArray<int> m_LodMasks;

		[Token(Token = "0x4005D82")]
		[FieldOffset(Offset = "0x50")]
		public NativeArray<bool> m_CastShadows;

		[Token(Token = "0x4005D83")]
		[FieldOffset(Offset = "0x60")]
		private bool m_IsUsingProceduralInstancing;

		[Token(Token = "0x60051F0")]
		[Address(RVA = "0xE38740", Offset = "0xE37540", Length = "0x375")]
		public void Allocate(int batchCount, bool isUsingProceduralInstancing)
		{
		}

		[Token(Token = "0x60051F1")]
		[Address(RVA = "0xE38AC0", Offset = "0xE378C0", Length = "0x35C")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60051F2")]
		[Address(RVA = "0xE38E20", Offset = "0xE37C20", Length = "0x1E9")]
		public int Initialize(List<int> objectCounts)
		{
			return 0;
		}

		[Token(Token = "0x60051F3")]
		[Address(RVA = "0xE39010", Offset = "0xE37E10", Length = "0x32")]
		public readonly void InitializeJob(ref RenderObjectInstanceJob job)
		{
		}

		[Token(Token = "0x60051F4")]
		[Address(RVA = "0xE39050", Offset = "0xE37E50", Length = "0x49C")]
		public void SetRenderInfo(int batchIndex, Renderer renderer, Mesh mesh, int lod, bool forceOnlyLod0Shadow)
		{
		}
	}

	[Token(Token = "0x20008ED")]
	private struct PerObject
	{
		[Token(Token = "0x4005D88")]
		[FieldOffset(Offset = "0x0")]
		public ComputeBuffer m_InstancedMatrices;

		[Token(Token = "0x4005D89")]
		[FieldOffset(Offset = "0x8")]
		public ComputeBuffer m_InstancedInverses;

		[Token(Token = "0x4005D8A")]
		[FieldOffset(Offset = "0x10")]
		public NativeArray<Matrix4x4> m_TemporaryMatrices;

		[Token(Token = "0x4005D8B")]
		[FieldOffset(Offset = "0x20")]
		public NativeArray<Matrix4x4> m_TemporaryInverses;

		[Token(Token = "0x4005D8C")]
		[FieldOffset(Offset = "0x30")]
		public NativeArray<int> m_VisibleIndexes;

		[Token(Token = "0x4005D8D")]
		[FieldOffset(Offset = "0x40")]
		public NativeArray<float4> m_Positions;

		[Token(Token = "0x4005D8E")]
		[FieldOffset(Offset = "0x50")]
		public NativeArray<Bounds> m_Bounds;

		[Token(Token = "0x60051F5")]
		[Address(RVA = "0xE394F0", Offset = "0xE382F0", Length = "0x536")]
		public void AddRenderer(Renderer renderer, PerBatch batches, int batchIndex)
		{
		}

		[Token(Token = "0x60051F6")]
		[Address(RVA = "0xE39A30", Offset = "0xE38830", Length = "0x38B")]
		public void Allocate(int objectCount)
		{
		}

		[Token(Token = "0x60051F7")]
		[Address(RVA = "0xE39DC0", Offset = "0xE38BC0", Length = "0x194")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60051F8")]
		[Address(RVA = "0xE39F60", Offset = "0xE38D60", Length = "0x22")]
		public readonly void InitializeJob(ref RenderObjectInstanceJob job)
		{
		}
	}

	[Token(Token = "0x4005D6C")]
	public static bool s_DisableProceduralInstancing;

	[Token(Token = "0x4005D6D")]
	private const int DRAW_MESH_INSTANCED_LIMIT = 1023;

	[Token(Token = "0x4005D6E")]
	[FieldOffset(Offset = "0x10")]
	private Matrix4x4[] m_RenderTransforms;

	[Token(Token = "0x4005D6F")]
	[FieldOffset(Offset = "0x18")]
	private List<string> m_Names;

	[Token(Token = "0x4005D70")]
	[FieldOffset(Offset = "0x20")]
	private List<int> m_ObjectCounts;

	[Token(Token = "0x4005D71")]
	[FieldOffset(Offset = "0x28")]
	private int m_MaxObjectCount;

	[Token(Token = "0x4005D72")]
	[FieldOffset(Offset = "0x2C")]
	private int m_CalculatedRenderBatchCount;

	[Token(Token = "0x4005D73")]
	[FieldOffset(Offset = "0x30")]
	private PerObject m_Objects;

	[Token(Token = "0x4005D74")]
	[FieldOffset(Offset = "0x90")]
	private PerBatch m_Batches;

	[Token(Token = "0x4005D75")]
	[FieldOffset(Offset = "0xF8")]
	private int m_DebugObjectCount;

	[Token(Token = "0x4005D76")]
	[FieldOffset(Offset = "0xFC")]
	private int m_DebugVisibleCount;

	[Token(Token = "0x4005D77")]
	[FieldOffset(Offset = "0x100")]
	private int m_DebugRenderedBatchCount;

	[Token(Token = "0x4005D78")]
	[FieldOffset(Offset = "0x104")]
	private bool m_IsUsingProceduralInstancing;

	[Token(Token = "0x4005D79")]
	private static readonly int s_InstanceMatricesShaderID;

	[Token(Token = "0x4005D7A")]
	private static readonly int s_InstanceInversesShaderID;

	[Token(Token = "0x4005D7B")]
	private static readonly int s_VisibleIndexesShaderID;

	[Token(Token = "0x1700036D")]
	public int CalculatedRenderBatchCount
	{
		[Token(Token = "0x60051DF")]
		[Address(RVA = "0x504230", Offset = "0x503030", Length = "0x4")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60051E0")]
		[Address(RVA = "0xE37340", Offset = "0xE36140", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x60051E1")]
	[Address(RVA = "0xE37350", Offset = "0xE36150", Length = "0x1FF")]
	public bool AddObject(Renderer renderer, int lod, bool forceOnlyLod0Shadows)
	{
		return false;
	}

	[Token(Token = "0x60051E2")]
	[Address(RVA = "0xE37550", Offset = "0xE36350", Length = "0x189")]
	public void Allocate()
	{
	}

	[Token(Token = "0x60051E3")]
	[Address(RVA = "0xE376E0", Offset = "0xE364E0", Length = "0x27")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60051E4")]
	[Address(RVA = "0xE37710", Offset = "0xE36510", Length = "0x65")]
	public void FinishInitialization()
	{
	}

	[Token(Token = "0x60051E5")]
	[Address(RVA = "0xE37780", Offset = "0xE36580", Length = "0x41")]
	public int GetBatchCount()
	{
		return 0;
	}

	[Token(Token = "0x60051E6")]
	[Address(RVA = "0xE377D0", Offset = "0xE365D0", Length = "0xE")]
	public int GetBatchLodMask(int batchIndex)
	{
		return 0;
	}

	[Token(Token = "0x60051E7")]
	[Address(RVA = "0xE377E0", Offset = "0xE365E0", Length = "0x3E8")]
	public void GetDebugText(StringBuilder sb)
	{
	}

	[Token(Token = "0x60051E8")]
	[Address(RVA = "0xE37BD0", Offset = "0xE369D0", Length = "0x65")]
	public void InitializeJob(ref RenderObjectInstanceJob job)
	{
	}

	[Token(Token = "0x60051E9")]
	[Address(RVA = "0xE37C40", Offset = "0xE36A40", Length = "0x6E7")]
	public void RenderBatch(int batchIndex, MaterialPropertyBlock materialProperties)
	{
	}

	[Token(Token = "0x60051EA")]
	[Address(RVA = "0xE38330", Offset = "0xE37130", Length = "0x135")]
	public void ReserveBatchName(string name, int objectCount)
	{
	}

	[Token(Token = "0x60051EB")]
	[Address(RVA = "0xE38470", Offset = "0xE37270", Length = "0x10")]
	public void ResetDebugCounters()
	{
	}

	[Token(Token = "0x60051EC")]
	[Address(RVA = "0xE38480", Offset = "0xE37280", Length = "0x7B")]
	private int GetBatchIndex(string name)
	{
		return 0;
	}

	[Token(Token = "0x60051ED")]
	[Address(RVA = "0xE38500", Offset = "0xE37300", Length = "0xC")]
	private bool IsAllocated()
	{
		return false;
	}

	[Token(Token = "0x60051EE")]
	[Address(RVA = "0xE38510", Offset = "0xE37310", Length = "0x159")]
	public RenderObjectInstanceBatches()
	{
	}
}

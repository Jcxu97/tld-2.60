using Cpp2ILInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

[BurstCompile(CompileSynchronously = true, FloatPrecision = FloatPrecision.Low, FloatMode = FloatMode.Fast)]
[Token(Token = "0x2000710")]
internal struct ElectrolizerParallelJob : IJob
{
	[ReadOnly]
	[Token(Token = "0x4004B0A")]
	[FieldOffset(Offset = "0x0")]
	public float m_DeltaTime;

	[ReadOnly]
	[Token(Token = "0x4004B0B")]
	[FieldOffset(Offset = "0x4")]
	public float3 m_CamPos;

	[ReadOnly]
	[Token(Token = "0x4004B0C")]
	[FieldOffset(Offset = "0x10")]
	public NativeArray<float3> m_PosArr;

	[ReadOnly]
	[Token(Token = "0x4004B0D")]
	[FieldOffset(Offset = "0x20")]
	public NativeArray<float> m_MaxDistSqr;

	[Token(Token = "0x4004B0E")]
	[FieldOffset(Offset = "0x30")]
	public NativeArray<float> m_Timer;

	[Token(Token = "0x4004B0F")]
	[FieldOffset(Offset = "0x40")]
	public NativeArray<float> m_DistSqr;

	[Token(Token = "0x4004B10")]
	[FieldOffset(Offset = "0x50")]
	public NativeArray<float> m_DistDiff;

	[Token(Token = "0x6003DE0")]
	[Address(RVA = "0xBFB670", Offset = "0xBFA470", Length = "0x1FA")]
	public void Execute()
	{
	}

	[Token(Token = "0x6003DE1")]
	[Address(RVA = "0xBFB870", Offset = "0xBFA670", Length = "0x21")]
	private float FastSqrDist2DJob(float3 a, float3 b)
	{
		return 0f;
	}
}

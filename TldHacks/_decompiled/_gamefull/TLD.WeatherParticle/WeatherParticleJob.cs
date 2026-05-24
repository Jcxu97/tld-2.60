using Cpp2ILInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

namespace TLD.WeatherParticle;

[BurstCompile(FloatPrecision.Medium, FloatMode.Fast, OptimizeFor = OptimizeFor.Performance)]
[Token(Token = "0x200134E")]
public struct WeatherParticleJob : IJobParticleSystemParallelFor
{
	[Token(Token = "0x4008E30")]
	private const int PK_BOX_DIMENSIONS = 2;

	[Token(Token = "0x4008E31")]
	private static readonly ProfilerMarker s_ParticleKillerJobUpdateParticle;

	[Token(Token = "0x4008E32")]
	private static readonly ProfilerMarker s_ParticleKillerJobCheckKillerBounds;

	[ReadOnly]
	[Token(Token = "0x4008E33")]
	[FieldOffset(Offset = "0x0")]
	public NativeArray<Bounds> m_ParticleKillers;

	[ReadOnly]
	[Token(Token = "0x4008E34")]
	[FieldOffset(Offset = "0x10")]
	public int m_ActiveParticleKillers;

	[ReadOnly]
	[Token(Token = "0x4008E35")]
	[FieldOffset(Offset = "0x14")]
	public bool m_PerformBoxTest;

	[ReadOnly]
	[Token(Token = "0x4008E36")]
	[FieldOffset(Offset = "0x15")]
	public bool m_WrapBounds;

	[ReadOnly]
	[Token(Token = "0x4008E37")]
	[FieldOffset(Offset = "0x18")]
	public NativeArray<float> m_ParticleCollisionHeightMapHeights;

	[ReadOnly]
	[Token(Token = "0x4008E38")]
	[FieldOffset(Offset = "0x28")]
	public ParticleCollisionHeightMapInfo m_ParticleCollisionHeightMapInfo;

	[ReadOnly]
	[Token(Token = "0x4008E39")]
	[FieldOffset(Offset = "0x60")]
	public WeatherParticleManagerConfiguration m_ParticleManagerConfig;

	[ReadOnly]
	[Token(Token = "0x4008E3A")]
	[FieldOffset(Offset = "0xF4")]
	public CommonVars m_CommonVariables;

	[ReadOnly]
	[Token(Token = "0x4008E3B")]
	[FieldOffset(Offset = "0x1E4")]
	public ParticleSystemVars m_ParticleSystemVariables;

	[Token(Token = "0x4008E3C")]
	private static readonly float3 step;

	[Token(Token = "0x4008E3D")]
	private static readonly float stepDot1;

	[Token(Token = "0x4008E3E")]
	private static readonly float3 vector3;

	[Token(Token = "0x6007B79")]
	[Address(RVA = "0x11A1A10", Offset = "0x11A0810", Length = "0x63C")]
	public void Execute(ParticleSystemJobData particles, int particleIndex)
	{
	}

	[Token(Token = "0x6007B7A")]
	[Address(RVA = "0x11A2050", Offset = "0x11A0E50", Length = "0xFC")]
	private bool IsParticleBelowHeightMap(Vector3 particlePosition)
	{
		return false;
	}

	[Token(Token = "0x6007B7B")]
	[Address(RVA = "0x11A2150", Offset = "0x11A0F50", Length = "0x866")]
	private void UpdateParticle(ref ParticleSystemJobData particles, int particleIndex, Vector3 particlePosition)
	{
	}

	[Token(Token = "0x6007B7C")]
	[Address(RVA = "0x11A29C0", Offset = "0x11A17C0", Length = "0x13F")]
	private void UpdateParticleNoTurbulence(ref ParticleSystemJobData particles, int particleIndex, Vector3 particlePosition)
	{
	}

	[Token(Token = "0x6007B7D")]
	[Address(RVA = "0x11A2B00", Offset = "0x11A1900", Length = "0x438")]
	private void UpdateParticlePosition(ref ParticleSystemJobData particles, int particleIndex, Vector3 particlePosition)
	{
	}

	[Token(Token = "0x6007B7E")]
	[Address(RVA = "0x11A2F40", Offset = "0x11A1D40", Length = "0x10")]
	private readonly void SetParticleAliveTimePercent(ref ParticleSystemJobData particles, int particleIndex, float aliveTimePercent)
	{
	}

	[Token(Token = "0x6007B7F")]
	[Address(RVA = "0x11A2F50", Offset = "0x11A1D50", Length = "0x3B")]
	private readonly void SetParticlePosition(ref ParticleSystemJobData particles, int particleIndex, Vector3 position)
	{
	}

	[Token(Token = "0x6007B80")]
	[Address(RVA = "0x11A2F90", Offset = "0x11A1D90", Length = "0x3B")]
	private readonly void SetParticleVelocity(ref ParticleSystemJobData particles, int particleIndex, Vector3 velocity)
	{
	}

	[Token(Token = "0x6007B81")]
	[Address(RVA = "0x11A2FD0", Offset = "0x11A1DD0", Length = "0x307")]
	private readonly float Noise3(float x, float y, float z)
	{
		return 0f;
	}

	[Token(Token = "0x6007B82")]
	[Address(RVA = "0x11A32E0", Offset = "0x11A20E0", Length = "0x88")]
	private readonly float Hash(float p)
	{
		return 0f;
	}
}

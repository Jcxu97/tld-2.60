using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Logging;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;

namespace TLD.WeatherParticle;

[Token(Token = "0x2001353")]
public class WeatherParticleManager
{
	[Token(Token = "0x2001354")]
	private struct ParticleKillerInstance
	{
		[Token(Token = "0x4008E8E")]
		private const float HUNDRED_SQUARED = 10000f;

		[Token(Token = "0x4008E8F")]
		[FieldOffset(Offset = "0x0")]
		public GameObject m_OwnerGameObject;

		[Token(Token = "0x4008E90")]
		[FieldOffset(Offset = "0x8")]
		public Bounds m_Bounds;

		[Token(Token = "0x4008E91")]
		[FieldOffset(Offset = "0x20")]
		public bool m_KillsFallingSnow;

		[Token(Token = "0x4008E92")]
		[FieldOffset(Offset = "0x21")]
		public bool m_KillsBlowingSnow;

		[Token(Token = "0x6007B92")]
		[Address(RVA = "0x11A7A10", Offset = "0x11A6810", Length = "0x27B")]
		public readonly bool ShouldBeActive(Vector3 camPos)
		{
			return false;
		}
	}

	[Token(Token = "0x4008E72")]
	private static readonly LogFilter s_LogFilter;

	[Token(Token = "0x4008E73")]
	private const float MAX_WIND_SPEED = 55f;

	[Token(Token = "0x4008E74")]
	private const int ITEMS_PER_BATCH = 32;

	[Token(Token = "0x4008E75")]
	private const int MAX_ACTIVE_PARTICLE_KILLERS = 32;

	[Token(Token = "0x4008E76")]
	public const int MAX_FALLING_SNOW_PARTICLES = 5000;

	[Token(Token = "0x4008E77")]
	public const int MAX_BLOWING_SNOW_PARTICLES = 1000;

	[Token(Token = "0x4008E78")]
	[FieldOffset(Offset = "0x10")]
	private WeatherParticleManagerConfiguration m_Config;

	[Token(Token = "0x4008E79")]
	[FieldOffset(Offset = "0xA8")]
	private ParticleSystem m_FallingSnowSystem;

	[Token(Token = "0x4008E7A")]
	[FieldOffset(Offset = "0xB0")]
	private ParticleSystem m_BlowingSnowSystem;

	[Token(Token = "0x4008E7B")]
	[FieldOffset(Offset = "0xB8")]
	private ParticleSystemVars m_ParticleSystemVarsBlowing;

	[Token(Token = "0x4008E7C")]
	[FieldOffset(Offset = "0x13C")]
	private ParticleSystemVars m_ParticleSystemVarsFalling;

	[Token(Token = "0x4008E7D")]
	[FieldOffset(Offset = "0x1C0")]
	private CommonVars m_Common;

	[Token(Token = "0x4008E7E")]
	[FieldOffset(Offset = "0x2B0")]
	private HeightMap m_ParticleCollisionHeightMap;

	[Token(Token = "0x4008E7F")]
	[FieldOffset(Offset = "0x2B8")]
	private NativeArray<float> m_EmptyHeightsNativeArray;

	[Token(Token = "0x4008E80")]
	[FieldOffset(Offset = "0x2C8")]
	private readonly List<ParticleKillerInstance> m_AllParticleKillers;

	[Token(Token = "0x4008E81")]
	[FieldOffset(Offset = "0x2D0")]
	private NativeArray<Bounds> m_ActiveFallingSnowKillers;

	[Token(Token = "0x4008E82")]
	[FieldOffset(Offset = "0x2E0")]
	private NativeArray<Bounds> m_ActiveBlowingSnowKillers;

	[Token(Token = "0x4008E83")]
	[FieldOffset(Offset = "0x2F0")]
	private int m_ActiveFallingSnowKillersCount;

	[Token(Token = "0x4008E84")]
	[FieldOffset(Offset = "0x2F4")]
	private int m_ActiveBlowingSnowKillersCount;

	[Token(Token = "0x4008E85")]
	[FieldOffset(Offset = "0x2F8")]
	private JobHandle m_FallingSnowParticleJobHandle;

	[Token(Token = "0x4008E86")]
	[FieldOffset(Offset = "0x308")]
	private JobHandle m_BlowingSnowParticleJobHandle;

	[Token(Token = "0x4008E87")]
	[FieldOffset(Offset = "0x318")]
	private Vector4 m_GrassPhase;

	[Token(Token = "0x4008E88")]
	[FieldOffset(Offset = "0x328")]
	private Vector2 m_GrassPhaseNoise1;

	[Token(Token = "0x4008E89")]
	[FieldOffset(Offset = "0x330")]
	private Vector2 m_GrassPhaseNoise2;

	[Token(Token = "0x4008E8A")]
	[FieldOffset(Offset = "0x338")]
	private readonly Vector2 m_NoiseDir1;

	[Token(Token = "0x4008E8B")]
	[FieldOffset(Offset = "0x340")]
	private readonly Vector2 m_NoiseDir2;

	[Token(Token = "0x4008E8C")]
	[FieldOffset(Offset = "0x348")]
	private Vector4 m_BranchPhase;

	[Token(Token = "0x4008E8D")]
	private static readonly ProfilerMarker s_ParticleKillerPrepare;

	[Token(Token = "0x6007B84")]
	[Address(RVA = "0x11A34B0", Offset = "0x11A22B0", Length = "0x2C7")]
	public WeatherParticleManager(WeatherParticleManagerConfiguration config)
	{
	}

	[Token(Token = "0x6007B85")]
	[Address(RVA = "0x11A3780", Offset = "0x11A2580", Length = "0x96C")]
	public void InitializeForScene()
	{
	}

	[Token(Token = "0x6007B86")]
	[Address(RVA = "0x11A40F0", Offset = "0x11A2EF0", Length = "0x3CE")]
	private void AddSnowParticleSystems(Weather weather)
	{
	}

	[Token(Token = "0x6007B87")]
	[Address(RVA = "0x11A44C0", Offset = "0x11A32C0", Length = "0x431")]
	public void ResetWeatherParticleManager()
	{
	}

	[Token(Token = "0x6007B88")]
	[Address(RVA = "0x11A4900", Offset = "0x11A3700", Length = "0x189")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x6007B89")]
	[Address(RVA = "0x11A4A90", Offset = "0x11A3890", Length = "0x59")]
	private void ScheduleFallingSnowParticleJobs()
	{
	}

	[Token(Token = "0x6007B8A")]
	[Address(RVA = "0x11A4AF0", Offset = "0x11A38F0", Length = "0x59")]
	private void ScheduleBlowingSnowParticleJobs()
	{
	}

	[Token(Token = "0x6007B8B")]
	[Address(RVA = "0x11A4B50", Offset = "0x11A3950", Length = "0x7BF")]
	private JobHandle ScheduleWeatherParticleJobs(ParticleSystem particleSystem, bool isFallingSnow, NativeArray<Bounds> particleKillers, int particleKillerCount)
	{
		return default(JobHandle);
	}

	[Token(Token = "0x6007B8C")]
	[Address(RVA = "0x11A5310", Offset = "0x11A4110", Length = "0x2C5")]
	public void UpdateWeatherParticleManager()
	{
	}

	[Token(Token = "0x6007B8D")]
	[Address(RVA = "0x11A55E0", Offset = "0x11A43E0", Length = "0x38C")]
	private void UpdateActiveSnowKillers(Vector3 cameraPosition)
	{
	}

	[Token(Token = "0x6007B8E")]
	[Address(RVA = "0x11A5970", Offset = "0x11A4770", Length = "0xBA9")]
	private void UpdateCommonVars(Camera currentCamera, bool isIndoorScene)
	{
	}

	[Token(Token = "0x6007B8F")]
	[Address(RVA = "0x11A6520", Offset = "0x11A5320", Length = "0xBC1")]
	private void ConfigureParticleSystemVariables(ParticleSystem particleSystem, bool isFallingSnow, ref ParticleSystemVars psv)
	{
	}

	[Token(Token = "0x6007B90")]
	[Address(RVA = "0x11A70F0", Offset = "0x11A5EF0", Length = "0x7BD")]
	private void UpdateShaderGlobalsForFoliage()
	{
	}
}

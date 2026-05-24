using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

[Token(Token = "0x20009DD")]
public class SnowPlaneParticles : MonoBehaviour
{
	[Token(Token = "0x20009DE")]
	private class WTTask
	{
		[Token(Token = "0x4006433")]
		[FieldOffset(Offset = "0x10")]
		public int m_BaseIndex;

		[Token(Token = "0x4006434")]
		[FieldOffset(Offset = "0x14")]
		public int m_Limit;

		[Token(Token = "0x60056FF")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public WTTask()
		{
		}
	}

	[BurstCompile(CompileSynchronously = true)]
	[Token(Token = "0x20009DF")]
	private struct SnowPlaneParticleJob : IJobParallelFor
	{
		[ReadOnly]
		[Token(Token = "0x4006435")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<float> m_ParticleVelocityFracs;

		[ReadOnly]
		[Token(Token = "0x4006436")]
		[FieldOffset(Offset = "0x10")]
		public NativeArray<float> m_ParticleFlurryFracs;

		[ReadOnly]
		[Token(Token = "0x4006437")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 m_MotionVec;

		[ReadOnly]
		[Token(Token = "0x4006438")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 m_FlurryVec;

		[ReadOnly]
		[Token(Token = "0x4006439")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 m_GravityVec;

		[Token(Token = "0x400643A")]
		[FieldOffset(Offset = "0x48")]
		public NativeArray<ParticleSystem.Particle> m_WorkParticles;

		[Token(Token = "0x6005700")]
		[Address(RVA = "0xEC77D0", Offset = "0xEC65D0", Length = "0x23D")]
		public void Execute(int i)
		{
		}
	}

	[Token(Token = "0x4006413")]
	[FieldOffset(Offset = "0x20")]
	public int m_MaxParticles;

	[Token(Token = "0x4006414")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem m_ParticleSystem;

	[Token(Token = "0x4006415")]
	[FieldOffset(Offset = "0x30")]
	public SnowPlaneManager m_Manager;

	[Range(0f, 1f)]
	[Token(Token = "0x4006416")]
	[FieldOffset(Offset = "0x38")]
	public float m_MinRandomizedVelocityFrac;

	[Range(0f, 1f)]
	[Token(Token = "0x4006417")]
	[FieldOffset(Offset = "0x3C")]
	public float m_MinGravityWindIntensity;

	[Range(0f, 1f)]
	[Token(Token = "0x4006418")]
	[FieldOffset(Offset = "0x40")]
	public float m_MaxGravityWindIntensity;

	[Range(0f, 1f)]
	[Token(Token = "0x4006419")]
	[FieldOffset(Offset = "0x44")]
	public float m_MinGravityVelocity;

	[Range(0f, 1f)]
	[Token(Token = "0x400641A")]
	[FieldOffset(Offset = "0x48")]
	public float m_MaxGravityVelocity;

	[Range(0f, 5f)]
	[Token(Token = "0x400641B")]
	[FieldOffset(Offset = "0x4C")]
	public float m_WindVelocityScalar;

	[Range(0f, 1f)]
	[Token(Token = "0x400641C")]
	[FieldOffset(Offset = "0x50")]
	public float m_FlurryThreshold;

	[Range(0f, 1f)]
	[Token(Token = "0x400641D")]
	[FieldOffset(Offset = "0x54")]
	public float m_FlurryGravFrac;

	[Range(0f, 1f)]
	[Token(Token = "0x400641E")]
	[FieldOffset(Offset = "0x58")]
	public float m_FlurryVelocityScalar;

	[Token(Token = "0x400641F")]
	[FieldOffset(Offset = "0x60")]
	private NativeArray<ParticleSystem.Particle> m_ParticlesNativeArray;

	[Token(Token = "0x4006420")]
	[FieldOffset(Offset = "0x70")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x4006421")]
	[FieldOffset(Offset = "0x78")]
	private float[] m_ParticleVelocityFracs;

	[Token(Token = "0x4006422")]
	[FieldOffset(Offset = "0x80")]
	private float[] m_ParticleFlurryFracs;

	[Token(Token = "0x4006423")]
	[FieldOffset(Offset = "0x88")]
	private NativeArray<float> m_ParticleVelocityFracsNativeArray;

	[Token(Token = "0x4006424")]
	[FieldOffset(Offset = "0x98")]
	private NativeArray<float> m_ParticleFlurryFracsNativeArray;

	[Token(Token = "0x4006425")]
	[FieldOffset(Offset = "0xA8")]
	private Vector3 m_MotionVec;

	[Token(Token = "0x4006426")]
	[FieldOffset(Offset = "0xB4")]
	private Vector3 m_FlurryVec;

	[Token(Token = "0x4006427")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 m_GravityVec;

	[Token(Token = "0x4006428")]
	private const int MAX_WORKER_THREADS = 4;

	[Token(Token = "0x4006429")]
	private const int MAX_PARTICLES_PER_TASK = 150;

	[Token(Token = "0x400642A")]
	private const int MIN_REMAINDER_PARTICLES_FOR_TASK = 50;

	[Token(Token = "0x400642B")]
	private static int m_NumWorkerThreads;

	[Token(Token = "0x400642C")]
	private static Thread[] m_WorkerThreads;

	[Token(Token = "0x400642D")]
	private static AutoResetEvent[] m_WTAutoResetEvents;

	[Token(Token = "0x400642E")]
	private static List<WTTask> m_WTTaskList;

	[Token(Token = "0x400642F")]
	private static AutoResetEvent m_MainThreadAutoResetEvent;

	[Token(Token = "0x4006430")]
	private static int m_TaskCount;

	[Token(Token = "0x4006431")]
	private static int m_TaskIndex;

	[Token(Token = "0x4006432")]
	private const int ITEMS_PER_BATCH = 32;

	[Token(Token = "0x17000382")]
	public bool IsActive
	{
		[Token(Token = "0x60056F1")]
		[Address(RVA = "0xEC5100", Offset = "0xEC3F00", Length = "0x9E")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60056F2")]
	[Address(RVA = "0xEC51A0", Offset = "0xEC3FA0", Length = "0x1F")]
	private void Start()
	{
	}

	[Token(Token = "0x60056F3")]
	[Address(RVA = "0xEC51C0", Offset = "0xEC3FC0", Length = "0xB1")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60056F4")]
	[Address(RVA = "0xEC5280", Offset = "0xEC4080", Length = "0x57B")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60056F5")]
	[Address(RVA = "0xEC5800", Offset = "0xEC4600", Length = "0x6CB")]
	private void StartWorkerThreads()
	{
	}

	[Token(Token = "0x60056F6")]
	[Address(RVA = "0xEC5ED0", Offset = "0xEC4CD0", Length = "0xC3")]
	private void StopWorkerThreads()
	{
	}

	[Token(Token = "0x60056F7")]
	[Address(RVA = "0xEC5FA0", Offset = "0xEC4DA0", Length = "0x216")]
	public void Reset()
	{
	}

	[Token(Token = "0x60056F8")]
	[Address(RVA = "0xEC61C0", Offset = "0xEC4FC0", Length = "0xBF9")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60056F9")]
	[Address(RVA = "0xEC6DC0", Offset = "0xEC5BC0", Length = "0x284")]
	private void UpdateParticlesJob(int numParticles)
	{
	}

	[Token(Token = "0x60056FA")]
	[Address(RVA = "0xEC7050", Offset = "0xEC5E50", Length = "0x1C7")]
	private void UpdateParticlesMultithread(int numParticles)
	{
	}

	[Token(Token = "0x60056FB")]
	[Address(RVA = "0xEC7220", Offset = "0xEC6020", Length = "0x124")]
	private static void WaitTasksCompletion()
	{
	}

	[Token(Token = "0x60056FC")]
	[Address(RVA = "0xEC7350", Offset = "0xEC6150", Length = "0x2FA")]
	private void SnowPlaneParticleTask(object obj)
	{
	}

	[Token(Token = "0x60056FD")]
	[Address(RVA = "0xEC7650", Offset = "0xEC6450", Length = "0x176")]
	private static void UpdateParticle(ref ParticleSystem.Particle particle, float particleVelocityFrac, float particleFlurryFrac, Vector3 motionVec, Vector3 flurryVec, Vector3 gravityVec)
	{
	}

	[Token(Token = "0x60056FE")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SnowPlaneParticles()
	{
	}
}

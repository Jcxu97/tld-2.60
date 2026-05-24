using System.Collections.Generic;
using Cpp2ILInjected;
using SuperSplines;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

[Token(Token = "0x20007E3")]
public static class SplineManager
{
	[Token(Token = "0x20007E4")]
	public struct SplineMatrices
	{
		[Token(Token = "0x4005489")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<double> m_NativeHermiteMatrix;

		[Token(Token = "0x400548A")]
		[FieldOffset(Offset = "0x10")]
		public NativeArray<double> m_NativeBezierMatrix;

		[Token(Token = "0x400548B")]
		[FieldOffset(Offset = "0x20")]
		public NativeArray<double> m_NativeBSplineMatrix;

		[Token(Token = "0x400548C")]
		[FieldOffset(Offset = "0x30")]
		public NativeArray<double> m_NativeLinearMatrix;
	}

	[Token(Token = "0x20007E5")]
	public struct SplineAudioClipJobInfo
	{
		[Token(Token = "0x400548D")]
		[FieldOffset(Offset = "0x0")]
		public Utils.FastSpline m_FastSpline;

		[Token(Token = "0x400548E")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 m_Position;
	}

	[BurstCompile(CompileSynchronously = true, FloatPrecision = FloatPrecision.Medium, FloatMode = FloatMode.Fast)]
	[Token(Token = "0x20007E6")]
	private struct FastSplineJob : IJob
	{
		[ReadOnly]
		[Token(Token = "0x400548F")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 m_Position;

		[ReadOnly]
		[Token(Token = "0x4005490")]
		[FieldOffset(Offset = "0x10")]
		public Utils.FastSpline m_FastSpline;

		[ReadOnly]
		[Token(Token = "0x4005491")]
		[FieldOffset(Offset = "0x70")]
		public int m_JobIndex;

		[Token(Token = "0x4005492")]
		[FieldOffset(Offset = "0x78")]
		public NativeArray<Vector3> m_Results;

		[Token(Token = "0x6004A7C")]
		[Address(RVA = "0xD3AFB0", Offset = "0xD39DB0", Length = "0x277")]
		public void Execute()
		{
		}
	}

	[Token(Token = "0x4005480")]
	private static SplineMatrices s_Matrices;

	[Token(Token = "0x4005481")]
	public static bool s_UseJobSystem;

	[Token(Token = "0x4005482")]
	public const int MAX_AUDIO_CLIP_JOBS = 256;

	[Token(Token = "0x4005483")]
	public static List<SplineAudioClip> s_SplineAudioClips;

	[Token(Token = "0x4005484")]
	public static List<SplineAudioClipJobInfo> s_SplineAudioClipJobInfos;

	[Token(Token = "0x4005485")]
	public static NativeArray<Vector3>[] s_SplineAudioClipResults;

	[Token(Token = "0x4005486")]
	private static List<FastSplineJob> s_JobList;

	[Token(Token = "0x4005487")]
	private static List<JobHandle> s_JobHandlesList;

	[Token(Token = "0x4005488")]
	private static bool s_Initialized;

	[RuntimeInitializeOnLoadMethod]
	[Token(Token = "0x6004A6E")]
	[Address(RVA = "0xD38CF0", Offset = "0xD37AF0", Length = "0x47B")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6004A6F")]
	[Address(RVA = "0xD39170", Offset = "0xD37F70", Length = "0xD1")]
	public static void RegisterStaticSplineAudioClip(SplineAudioClip splineAudioClip)
	{
	}

	[Token(Token = "0x6004A70")]
	[Address(RVA = "0xD39250", Offset = "0xD38050", Length = "0x113")]
	public static void UnRegisterStaticSplineAudioClip(SplineAudioClip splineAudioClip)
	{
	}

	[Token(Token = "0x6004A71")]
	[Address(RVA = "0xD39370", Offset = "0xD38170", Length = "0x354")]
	public static void EarlyUpdate()
	{
	}

	[Token(Token = "0x6004A72")]
	[Address(RVA = "0xD396D0", Offset = "0xD384D0", Length = "0x1CC")]
	public static int RequestSplineClosestPositionJob(Utils.FastSpline fastSpline, Vector3 position)
	{
		return 0;
	}

	[Token(Token = "0x6004A73")]
	[Address(RVA = "0xD398A0", Offset = "0xD386A0", Length = "0x1E0")]
	public static bool RetrieveSplineClosestPosition(int jobIndex, out Vector3 closestPosition)
	{
		closestPosition = default(Vector3);
		return false;
	}

	[Token(Token = "0x6004A74")]
	[Address(RVA = "0xD39A90", Offset = "0xD38890", Length = "0x676")]
	public static void SheduleJobs()
	{
	}

	[Token(Token = "0x6004A75")]
	[Address(RVA = "0xD3A110", Offset = "0xD38F10", Length = "0x315")]
	public static void CompleteJobs()
	{
	}

	[Token(Token = "0x6004A76")]
	[Address(RVA = "0xD3A430", Offset = "0xD39230", Length = "0x231")]
	public static void Update()
	{
	}

	[Token(Token = "0x6004A77")]
	[Address(RVA = "0xD3A670", Offset = "0xD39470", Length = "0x94")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6004A78")]
	[Address(RVA = "0xD3A710", Offset = "0xD39510", Length = "0xB6")]
	public static bool AreJobPending()
	{
		return false;
	}

	[Token(Token = "0x6004A79")]
	[Address(RVA = "0xD3A7D0", Offset = "0xD395D0", Length = "0x2D8")]
	public static void Dispose()
	{
	}

	[Token(Token = "0x6004A7A")]
	[Address(RVA = "0xD3AAB0", Offset = "0xD398B0", Length = "0x14A")]
	public static NativeArray<double> GetMatrix(Spline.InterpolationMode splineInterpolationMode)
	{
		return default(NativeArray<double>);
	}
}

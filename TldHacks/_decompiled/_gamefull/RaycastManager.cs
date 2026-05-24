using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Unity.Collections;
using UnityEngine;

[Token(Token = "0x20003F4")]
public class RaycastManager : MonoBehaviour
{
	[Token(Token = "0x20003F5")]
	private struct QueuedRaycastCommand
	{
		[Token(Token = "0x4002384")]
		[FieldOffset(Offset = "0x0")]
		public RaycastCommand m_Command;

		[Token(Token = "0x4002385")]
		[FieldOffset(Offset = "0x38")]
		public Action<RaycastHit> m_OnJobCompleted;
	}

	[Token(Token = "0x4002375")]
	public static bool s_Debug;

	[Token(Token = "0x4002376")]
	private const int COMMANDS_PER_FRAME = 32;

	[Token(Token = "0x4002377")]
	private const int WARNING_COMMAND_COUNT = 64;

	[Token(Token = "0x4002378")]
	[FieldOffset(Offset = "0x20")]
	private Queue<QueuedRaycastCommand> m_Pending;

	[Token(Token = "0x4002379")]
	[FieldOffset(Offset = "0x28")]
	private Action<RaycastHit>[] m_ResultCallbacks;

	[Token(Token = "0x400237A")]
	[FieldOffset(Offset = "0x30")]
	private NativeArray<RaycastCommand> m_RaycastCommands;

	[Token(Token = "0x400237B")]
	[FieldOffset(Offset = "0x40")]
	private NativeArray<RaycastHit> m_RaycastHits;

	[Token(Token = "0x400237C")]
	[FieldOffset(Offset = "0x50")]
	private bool m_HasWarnedThisFrame;

	[Token(Token = "0x400237D")]
	private static RaycastManager s_Instance;

	[Token(Token = "0x400237E")]
	private static int s_PendingJobsNumWorstAllTime;

	[Token(Token = "0x400237F")]
	private static int s_PendingJobsNumWorstSecond;

	[Token(Token = "0x4002380")]
	private static float s_PendingJobsTimer;

	[Token(Token = "0x4002381")]
	private static float s_AveragePendingJobsPerSecond;

	[Token(Token = "0x4002382")]
	private static int s_AveragePendingJobsPerSecondCounter;

	[Token(Token = "0x4002383")]
	private static int s_AveragePendingJobsPerSecondSamples;

	[Token(Token = "0x6001E56")]
	[Address(RVA = "0x7BB360", Offset = "0x7BA160", Length = "0x17F")]
	private static void Initialize()
	{
	}

	[Token(Token = "0x6001E57")]
	[Address(RVA = "0x7BB4E0", Offset = "0x7BA2E0", Length = "0x151")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6001E58")]
	[Address(RVA = "0x7BB640", Offset = "0x7BA440", Length = "0x1A")]
	public void Update()
	{
	}

	[Token(Token = "0x6001E59")]
	[Address(RVA = "0x7BB660", Offset = "0x7BA460", Length = "0xA7")]
	public static void RequestAsyncRaycast(Vector3 origin, Vector3 direction, float range, int layer, Action<RaycastHit> onJobCompleted)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6001E5A")]
	[Address(RVA = "0x7BB710", Offset = "0x7BA510", Length = "0x40")]
	public static void SetDebugEnabled(bool debug)
	{
	}

	[Token(Token = "0x6001E5B")]
	[Address(RVA = "0x7BB750", Offset = "0x7BA550", Length = "0x137")]
	public static string GetDebugText()
	{
		return null;
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6001E5C")]
	[Address(RVA = "0x7BB890", Offset = "0x7BA690", Length = "0x92")]
	private static void ResetDebugCounters()
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6001E5D")]
	[Address(RVA = "0x7BB930", Offset = "0x7BA730", Length = "0x17E")]
	private void UpdateDebugCounters()
	{
	}

	[Token(Token = "0x6001E5E")]
	[Address(RVA = "0x7BBAB0", Offset = "0x7BA8B0", Length = "0x2BF")]
	private void CompletePendingRaycasts()
	{
	}

	[Token(Token = "0x6001E5F")]
	[Address(RVA = "0x7BBD70", Offset = "0x7BAB70", Length = "0x2DF")]
	private void RequestAsyncRaycast_Internal(Vector3 origin, Vector3 direction, float range, int layer, Action<RaycastHit> onJobCompleted)
	{
	}

	[Token(Token = "0x6001E60")]
	[Address(RVA = "0x7BC050", Offset = "0x7BAE50", Length = "0x25D")]
	private static RaycastManager GetInstance()
	{
		return null;
	}

	[Token(Token = "0x6001E61")]
	[Address(RVA = "0x7BC2B0", Offset = "0x7BB0B0", Length = "0x2E6")]
	public RaycastManager()
	{
	}
}

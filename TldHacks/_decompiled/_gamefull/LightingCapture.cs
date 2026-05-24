using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A13")]
public class LightingCapture : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000A14")]
	private sealed class _003CCaptureFrame_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400661A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400661B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400661C")]
		[FieldOffset(Offset = "0x20")]
		public LightingCapture _003C_003E4__this;

		[Token(Token = "0x400661D")]
		[FieldOffset(Offset = "0x28")]
		private int _003CcurWeather_003E5__2;

		[Token(Token = "0x400661E")]
		[FieldOffset(Offset = "0x2C")]
		private int _003CcamCounter_003E5__3;

		[Token(Token = "0x400661F")]
		[FieldOffset(Offset = "0x30")]
		private int _003CcurHour_003E5__4;

		[Token(Token = "0x17000392")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005874")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000393")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005876")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6005871")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CCaptureFrame_003Ed__16(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6005872")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6005873")]
		[Address(RVA = "0xEE9970", Offset = "0xEE8770", Length = "0x889")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x6005875")]
		[Address(RVA = "0xEEA200", Offset = "0xEE9000", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400660E")]
	[FieldOffset(Offset = "0x20")]
	public List<WeatherStage> m_WeatherTypes;

	[Token(Token = "0x400660F")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> m_RefCameras;

	[Token(Token = "0x4006610")]
	[FieldOffset(Offset = "0x30")]
	public string m_CaptureName;

	[Token(Token = "0x4006611")]
	public static string m_ThisPath;

	[Token(Token = "0x4006612")]
	[FieldOffset(Offset = "0x38")]
	private List<Transform> m_CapturePoints;

	[Token(Token = "0x4006613")]
	[FieldOffset(Offset = "0x40")]
	private HudDisplayMode m_CachedHudState;

	[Token(Token = "0x4006614")]
	[FieldOffset(Offset = "0x44")]
	private float m_CachedTOD;

	[Token(Token = "0x4006615")]
	[FieldOffset(Offset = "0x48")]
	private WeatherStage m_CachedWeather;

	[Token(Token = "0x4006616")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_IsInitialized;

	[Token(Token = "0x4006617")]
	[FieldOffset(Offset = "0x4D")]
	private bool m_BatchMode;

	[Token(Token = "0x4006618")]
	[FieldOffset(Offset = "0x50")]
	private float m_TimeDelay;

	[Token(Token = "0x4006619")]
	[FieldOffset(Offset = "0x58")]
	private BoxSectorManager m_BoSeMan;

	[Token(Token = "0x6005869")]
	[Address(RVA = "0xEE8340", Offset = "0xEE7140", Length = "0x518")]
	private void Initialize()
	{
	}

	[Token(Token = "0x600586A")]
	[Address(RVA = "0xEE8860", Offset = "0xEE7660", Length = "0xBC")]
	private static void MaybeCreateDirectory()
	{
	}

	[Token(Token = "0x600586B")]
	[Address(RVA = "0xEE8920", Offset = "0xEE7720", Length = "0x61A")]
	public static string MakeNextDirectoryID()
	{
		return null;
	}

	[Token(Token = "0x600586C")]
	[Address(RVA = "0xEE8F40", Offset = "0xEE7D40", Length = "0x2CF")]
	public void SampleCameras(bool batchMode)
	{
	}

	[IteratorStateMachine(typeof(_003CCaptureFrame_003Ed__16))]
	[Token(Token = "0x600586D")]
	[Address(RVA = "0xEE9210", Offset = "0xEE8010", Length = "0x9A")]
	private IEnumerator CaptureFrame()
	{
		return null;
	}

	[Token(Token = "0x600586E")]
	[Address(RVA = "0xEE92B0", Offset = "0xEE80B0", Length = "0x48E")]
	private void RenderCameraToTexture(int idx, int curHour, string weatherType)
	{
	}

	[Token(Token = "0x600586F")]
	[Address(RVA = "0xEE9740", Offset = "0xEE8540", Length = "0xC3")]
	private static void SetBoxSectors(bool activeSectors)
	{
	}

	[Token(Token = "0x6005870")]
	[Address(RVA = "0xEE9810", Offset = "0xEE8610", Length = "0x15D")]
	public LightingCapture()
	{
	}
}

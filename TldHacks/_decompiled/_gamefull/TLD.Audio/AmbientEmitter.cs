using System;
using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Audio;

[Token(Token = "0x20014E6")]
public class AmbientEmitter : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20014E7")]
	public struct AmbientClip
	{
		[Token(Token = "0x400973C")]
		[FieldOffset(Offset = "0x0")]
		public AK.Wwise.Event m_Event;

		[Token(Token = "0x400973D")]
		[FieldOffset(Offset = "0x8")]
		public TimeOfDayFilterEnum m_Filter;

		[Token(Token = "0x400973E")]
		[FieldOffset(Offset = "0xC")]
		public WeatherFilterEnum m_WeatherFilter;

		[Token(Token = "0x400973F")]
		[FieldOffset(Offset = "0x10")]
		public WindFilterEnum m_WindFilter;
	}

	[Serializable]
	[Token(Token = "0x20014E8")]
	public struct AmbientLoop
	{
		[Token(Token = "0x4009740")]
		[FieldOffset(Offset = "0x0")]
		public AK.Wwise.Event m_Event;

		[Token(Token = "0x4009741")]
		[FieldOffset(Offset = "0x8")]
		public TimeOfDayFilterEnum m_Filter;

		[Token(Token = "0x4009742")]
		[FieldOffset(Offset = "0xC")]
		public WeatherFilterEnum m_WeatherFilter;
	}

	[HideInInspector]
	[Token(Token = "0x4009727")]
	[FieldOffset(Offset = "0x20")]
	public AmbientClip[] m_AmbientClips;

	[HideInInspector]
	[Token(Token = "0x4009728")]
	[FieldOffset(Offset = "0x28")]
	public AmbientLoop[] m_AmbientLoops;

	[HideInInspector]
	[Token(Token = "0x4009729")]
	[FieldOffset(Offset = "0x30")]
	public float m_ClipMinDelay;

	[HideInInspector]
	[Token(Token = "0x400972A")]
	[FieldOffset(Offset = "0x34")]
	public float m_ClipMaxDelay;

	[HideInInspector]
	[Obsolete]
	[Token(Token = "0x400972B")]
	[FieldOffset(Offset = "0x38")]
	public string[] m_Clips;

	[HideInInspector]
	[Obsolete]
	[Token(Token = "0x400972C")]
	[FieldOffset(Offset = "0x40")]
	public TimeOfDayFilterEnum[] m_ClipFilter;

	[HideInInspector]
	[Obsolete]
	[Token(Token = "0x400972D")]
	[FieldOffset(Offset = "0x48")]
	public WeatherFilterEnum[] m_ClipWeatherFilter;

	[HideInInspector]
	[Obsolete]
	[Token(Token = "0x400972E")]
	[FieldOffset(Offset = "0x50")]
	public WindFilterEnum[] m_ClipWindFilter;

	[HideInInspector]
	[Obsolete]
	[Token(Token = "0x400972F")]
	[FieldOffset(Offset = "0x58")]
	public string[] m_Loops;

	[HideInInspector]
	[Obsolete]
	[Token(Token = "0x4009730")]
	[FieldOffset(Offset = "0x60")]
	public TimeOfDayFilterEnum[] m_LoopFilter;

	[HideInInspector]
	[Obsolete]
	[Token(Token = "0x4009731")]
	[FieldOffset(Offset = "0x68")]
	public WeatherFilterEnum[] m_LoopWeatherFilter;

	[Token(Token = "0x4009732")]
	[FieldOffset(Offset = "0x70")]
	public bool m_DebugLoggingEnabled;

	[Token(Token = "0x4009733")]
	[FieldOffset(Offset = "0x74")]
	public float m_InnerRadius;

	[Token(Token = "0x4009734")]
	[FieldOffset(Offset = "0x78")]
	public float m_OuterRadius;

	[Token(Token = "0x4009735")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_ClipAudioPending;

	[Token(Token = "0x4009736")]
	[FieldOffset(Offset = "0x80")]
	private int m_LoopAudioCurrentIndex;

	[Token(Token = "0x4009737")]
	[FieldOffset(Offset = "0x84")]
	private float m_TimeToPlayNextClip;

	[Token(Token = "0x4009738")]
	[FieldOffset(Offset = "0x88")]
	private uint m_PlayingLoopID;

	[Token(Token = "0x4009739")]
	[FieldOffset(Offset = "0x8C")]
	private bool m_FirstUpdate;

	[Token(Token = "0x400973A")]
	private static int MAX_CANDIDATES;

	[Token(Token = "0x400973B")]
	private static int[] m_CandidatesBuffer;

	[Token(Token = "0x6008408")]
	[Address(RVA = "0x12574D0", Offset = "0x12562D0", Length = "0x8C")]
	public void Start()
	{
	}

	[Token(Token = "0x6008409")]
	[Address(RVA = "0x1257560", Offset = "0x1256360", Length = "0x21D")]
	public void Update()
	{
	}

	[Token(Token = "0x600840A")]
	[Address(RVA = "0x1257780", Offset = "0x1256580", Length = "0x55")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600840B")]
	[Address(RVA = "0x12577E0", Offset = "0x12565E0", Length = "0x554")]
	private void PlayRandomLoop()
	{
	}

	[Token(Token = "0x600840C")]
	[Address(RVA = "0x1257D40", Offset = "0x1256B40", Length = "0x80A")]
	private void PlayRandomClip()
	{
	}

	[Token(Token = "0x600840D")]
	[Address(RVA = "0x1258550", Offset = "0x1257350", Length = "0xD3")]
	private void MaybePlayRandomClip()
	{
	}

	[Token(Token = "0x600840E")]
	[Address(RVA = "0x1258630", Offset = "0x1257430", Length = "0x11")]
	private void MaybePlayRandomLoop()
	{
	}

	[Token(Token = "0x600840F")]
	[Address(RVA = "0x1258650", Offset = "0x1257450", Length = "0xBC")]
	private void AdjustLoopForTimeOfDay()
	{
	}

	[Token(Token = "0x6008410")]
	[Address(RVA = "0x1258710", Offset = "0x1257510", Length = "0xA6")]
	private bool PassesTimeOfDayFilter(TimeOfDayFilterEnum tod)
	{
		return false;
	}

	[Token(Token = "0x6008411")]
	[Address(RVA = "0x12587C0", Offset = "0x12575C0", Length = "0x158")]
	private bool PassesWeatherFilter(WeatherFilterEnum weather)
	{
		return false;
	}

	[Token(Token = "0x6008412")]
	[Address(RVA = "0x1258920", Offset = "0x1257720", Length = "0xC6")]
	private bool PassesWindFilter(WindFilterEnum wind)
	{
		return false;
	}

	[Token(Token = "0x6008413")]
	[Address(RVA = "0x12589F0", Offset = "0x12577F0", Length = "0x51")]
	public AmbientEmitter()
	{
	}
}

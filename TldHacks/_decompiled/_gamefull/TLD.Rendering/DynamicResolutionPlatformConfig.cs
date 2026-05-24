using System;
using System.Collections.Generic;
using System.ComponentModel;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Rendering;

[Serializable]
[Token(Token = "0x200136E")]
public class DynamicResolutionPlatformConfig
{
	[Serializable]
	[Token(Token = "0x200136F")]
	private class TargetConfig
	{
		[Token(Token = "0x4008EFE")]
		[FieldOffset(Offset = "0x10")]
		public int m_Framerate;

		[Token(Token = "0x4008EFF")]
		[FieldOffset(Offset = "0x14")]
		public int m_MinResolution;

		[Token(Token = "0x4008F00")]
		[FieldOffset(Offset = "0x18")]
		public int m_MaxResolution;

		[Token(Token = "0x4008F01")]
		[FieldOffset(Offset = "0x1C")]
		public int m_OverrideVsync;

		[Token(Token = "0x6007C2B")]
		[Address(RVA = "0x11AFCE0", Offset = "0x11AEAE0", Length = "0xF")]
		public TargetConfig()
		{
		}
	}

	[Serializable]
	[DefaultValue(SystemApplicationMethod.SetFrameTargetAndVSync)]
	[Token(Token = "0x2001370")]
	private enum SystemApplicationMethod
	{
		[Token(Token = "0x4008F03")]
		SetFrameTargetAndVSync,
		[Token(Token = "0x4008F04")]
		SetFrameTargetOnly,
		[Token(Token = "0x4008F05")]
		SetVSyncOnly,
		[Token(Token = "0x4008F06")]
		SetAsResolution
	}

	[Token(Token = "0x4008EEC")]
	private const string NO_ACTIVE_TARGET = "No active target";

	[Token(Token = "0x4008EED")]
	private const int INVALID_VSYNC_VALUE = -1;

	[Header("Framerate Targets")]
	[SerializeField]
	[Token(Token = "0x4008EEE")]
	[FieldOffset(Offset = "0x10")]
	private List<TargetConfig> m_Targets;

	[Header("System Settings")]
	[SerializeField]
	[Tooltip("Sets how the internal logic needs to apply the render settings.")]
	[Token(Token = "0x4008EEF")]
	[FieldOffset(Offset = "0x18")]
	private SystemApplicationMethod m_ApplicationMethod;

	[SerializeField]
	[Tooltip("Default vSync value applied in the graphics settings. Set to -1 to ignore this.")]
	[Token(Token = "0x4008EF0")]
	[FieldOffset(Offset = "0x1C")]
	private int m_DefaultVsync;

	[Header("Tweaking")]
	[SerializeField]
	[Tooltip("How often to update frame timings")]
	[Token(Token = "0x4008EF1")]
	[FieldOffset(Offset = "0x20")]
	private uint m_FrameTimings;

	[SerializeField]
	[Tooltip("When hit, scale resolution up")]
	[Token(Token = "0x4008EF2")]
	[FieldOffset(Offset = "0x24")]
	private uint m_ScaleRaiseCounterLimit;

	[SerializeField]
	[Tooltip("Used when seeing a good GPU time trend")]
	[Token(Token = "0x4008EF3")]
	[FieldOffset(Offset = "0x28")]
	private uint m_ScaleRaiseCounterBigIncrement;

	[SerializeField]
	[Tooltip("Used as long as GPU isn't too taxed")]
	[Token(Token = "0x4008EF4")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_ScaleRaiseCounterSmallIncrement;

	[SerializeField]
	[Tooltip("How much GPU Frametime headroom to have before trending towards scaling up")]
	[Token(Token = "0x4008EF5")]
	[FieldOffset(Offset = "0x30")]
	private double m_HeadroomThreshold;

	[SerializeField]
	[Tooltip("How much GPU Frametime delta to have before trending towards scaling up")]
	[Token(Token = "0x4008EF6")]
	[FieldOffset(Offset = "0x38")]
	private double m_DeltaThreshold;

	[SerializeField]
	[Tooltip("Min threshold factor to increase scale with")]
	[Token(Token = "0x4008EF7")]
	[FieldOffset(Offset = "0x40")]
	private float m_ScaleIncreaseSmallFactor;

	[SerializeField]
	[Tooltip("Max threshold factor to increase scale with")]
	[Token(Token = "0x4008EF8")]
	[FieldOffset(Offset = "0x44")]
	private float m_ScaleIncreaseBigFactor;

	[SerializeField]
	[Tooltip("Min Value to remap Headroom percentage to 0-1")]
	[Token(Token = "0x4008EF9")]
	[FieldOffset(Offset = "0x48")]
	private float m_ScaleHeadroomClampMin;

	[SerializeField]
	[Tooltip("Max Value to remap Headroom percentage to 0-1")]
	[Token(Token = "0x4008EFA")]
	[FieldOffset(Offset = "0x4C")]
	private float m_ScaleHeadroomClampMax;

	[Token(Token = "0x4008EFD")]
	[FieldOffset(Offset = "0x58")]
	private TargetConfig m_Target;

	[Token(Token = "0x17000A79")]
	public uint FrameTimings
	{
		[Token(Token = "0x6007C16")]
		[Address(RVA = "0x4571E0", Offset = "0x455FE0", Length = "0x4")]
		get
		{
			return 0u;
		}
	}

	[Token(Token = "0x17000A7A")]
	public uint ScaleRaiseCounterLimit
	{
		[Token(Token = "0x6007C17")]
		[Address(RVA = "0x4AA8A0", Offset = "0x4A96A0", Length = "0x4")]
		get
		{
			return 0u;
		}
	}

	[Token(Token = "0x17000A7B")]
	public uint ScaleRaiseCounterBigIncrement
	{
		[Token(Token = "0x6007C18")]
		[Address(RVA = "0x4588A0", Offset = "0x4576A0", Length = "0x4")]
		get
		{
			return 0u;
		}
	}

	[Token(Token = "0x17000A7C")]
	public uint ScaleRaiseCounterSmallIncrement
	{
		[Token(Token = "0x6007C19")]
		[Address(RVA = "0x504230", Offset = "0x503030", Length = "0x4")]
		get
		{
			return 0u;
		}
	}

	[Token(Token = "0x17000A7D")]
	public double HeadroomThreshold
	{
		[Token(Token = "0x6007C1A")]
		[Address(RVA = "0x11AF0C0", Offset = "0x11ADEC0", Length = "0x6")]
		get
		{
			return 0.0;
		}
	}

	[Token(Token = "0x17000A7E")]
	public double DeltaThreshold
	{
		[Token(Token = "0x6007C1B")]
		[Address(RVA = "0x11AF0D0", Offset = "0x11ADED0", Length = "0x6")]
		get
		{
			return 0.0;
		}
	}

	[Token(Token = "0x17000A7F")]
	[field: Token(Token = "0x4008EFB")]
	[field: FieldOffset(Offset = "0x50")]
	public float MinRenderScale
	{
		[Token(Token = "0x6007C1C")]
		[Address(RVA = "0x4B4350", Offset = "0x4B3150", Length = "0x6")]
		get;
		[Token(Token = "0x6007C1D")]
		[Address(RVA = "0x8652A0", Offset = "0x8640A0", Length = "0x6")]
		private set;
	}

	[Token(Token = "0x17000A80")]
	[field: Token(Token = "0x4008EFC")]
	[field: FieldOffset(Offset = "0x54")]
	public float MaxRenderScale
	{
		[Token(Token = "0x6007C1E")]
		[Address(RVA = "0x5024C0", Offset = "0x5012C0", Length = "0x6")]
		get;
		[Token(Token = "0x6007C1F")]
		[Address(RVA = "0x5094D0", Offset = "0x5082D0", Length = "0x6")]
		private set;
	}

	[Token(Token = "0x17000A81")]
	public bool AllowDynamicResolutionScaling
	{
		[Token(Token = "0x6007C20")]
		[Address(RVA = "0x11AF0E0", Offset = "0x11ADEE0", Length = "0x12")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000A82")]
	public int TargetFramerate
	{
		[Token(Token = "0x6007C21")]
		[Address(RVA = "0x11AF100", Offset = "0x11ADF00", Length = "0x13")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6007C22")]
	[Address(RVA = "0x11AF120", Offset = "0x11ADF20", Length = "0x75")]
	public void UpdateFramerateTarget(int targetFramerate)
	{
	}

	[Token(Token = "0x6007C23")]
	[Address(RVA = "0x11AF1A0", Offset = "0x11ADFA0", Length = "0x199")]
	public void UpdateRenderScale(int resolutionCap)
	{
	}

	[Token(Token = "0x6007C24")]
	[Address(RVA = "0x11AF340", Offset = "0x11AE140", Length = "0x2D2")]
	private TargetConfig FindBestTargetConfigMatchForFramerate(int targetFramerate)
	{
		return null;
	}

	[Token(Token = "0x6007C25")]
	[Address(RVA = "0x11AF620", Offset = "0x11AE420", Length = "0x46")]
	public float ConvertResolutionScaleToFactor(float resolutionScale)
	{
		return 0f;
	}

	[Token(Token = "0x6007C26")]
	[Address(RVA = "0x11AF670", Offset = "0x11AE470", Length = "0x90")]
	public float CalculateScaleIncrease(float headroomFactor)
	{
		return 0f;
	}

	[Token(Token = "0x6007C27")]
	[Address(RVA = "0x11AF700", Offset = "0x11AE500", Length = "0x1CC")]
	public void GetFramerateTargets(List<int> targets)
	{
	}

	[Token(Token = "0x6007C28")]
	[Address(RVA = "0x11AF8D0", Offset = "0x11AE6D0", Length = "0x150")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007C29")]
	[Address(RVA = "0x11AFA30", Offset = "0x11AE830", Length = "0x24A")]
	private void ApplySystemSettings()
	{
	}

	[Token(Token = "0x6007C2A")]
	[Address(RVA = "0x11AFC80", Offset = "0x11AEA80", Length = "0x5C")]
	public DynamicResolutionPlatformConfig()
	{
	}
}

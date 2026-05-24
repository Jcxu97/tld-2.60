using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CD3")]
public sealed class PostProcessDebugLayer
{
	[Serializable]
	[Token(Token = "0x2000CD4")]
	public class OverlaySettings
	{
		[Token(Token = "0x4007F76")]
		[FieldOffset(Offset = "0x10")]
		public bool linearDepth;

		[Range(0f, 16f)]
		[Token(Token = "0x4007F77")]
		[FieldOffset(Offset = "0x14")]
		public float motionColorIntensity;

		[Range(4f, 128f)]
		[Token(Token = "0x4007F78")]
		[FieldOffset(Offset = "0x18")]
		public int motionGridSize;

		[Token(Token = "0x4007F79")]
		[FieldOffset(Offset = "0x1C")]
		public ColorBlindnessType colorBlindnessType;

		[Range(0f, 1f)]
		[Token(Token = "0x4007F7A")]
		[FieldOffset(Offset = "0x20")]
		public float colorBlindnessStrength;

		[Token(Token = "0x6006596")]
		[Address(RVA = "0x1015510", Offset = "0x1014310", Length = "0x16")]
		public OverlaySettings()
		{
		}
	}

	[Token(Token = "0x4007F6B")]
	[FieldOffset(Offset = "0x10")]
	public LightMeterMonitor lightMeter;

	[Token(Token = "0x4007F6C")]
	[FieldOffset(Offset = "0x18")]
	public HistogramMonitor histogram;

	[Token(Token = "0x4007F6D")]
	[FieldOffset(Offset = "0x20")]
	public WaveformMonitor waveform;

	[Token(Token = "0x4007F6E")]
	[FieldOffset(Offset = "0x28")]
	public VectorscopeMonitor vectorscope;

	[Token(Token = "0x4007F6F")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<MonitorType, Monitor> m_Monitors;

	[Token(Token = "0x4007F70")]
	[FieldOffset(Offset = "0x38")]
	private int frameWidth;

	[Token(Token = "0x4007F71")]
	[FieldOffset(Offset = "0x3C")]
	private int frameHeight;

	[Token(Token = "0x4007F75")]
	[FieldOffset(Offset = "0x50")]
	public OverlaySettings overlaySettings;

	[Token(Token = "0x170006C7")]
	[field: Token(Token = "0x4007F72")]
	[field: FieldOffset(Offset = "0x40")]
	public RenderTexture debugOverlayTarget
	{
		[Token(Token = "0x6006584")]
		[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
		get;
		[Token(Token = "0x6006585")]
		[Address(RVA = "0x4D0B00", Offset = "0x4CF900", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170006C8")]
	[field: Token(Token = "0x4007F73")]
	[field: FieldOffset(Offset = "0x48")]
	public bool debugOverlayActive
	{
		[Token(Token = "0x6006586")]
		[Address(RVA = "0x5C6C80", Offset = "0x5C5A80", Length = "0x5")]
		get;
		[Token(Token = "0x6006587")]
		[Address(RVA = "0x676EA0", Offset = "0x675CA0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x170006C9")]
	[field: Token(Token = "0x4007F74")]
	[field: FieldOffset(Offset = "0x4C")]
	public DebugOverlay debugOverlay
	{
		[Token(Token = "0x6006588")]
		[Address(RVA = "0x1013BD0", Offset = "0x10129D0", Length = "0x4")]
		get;
		[Token(Token = "0x6006589")]
		[Address(RVA = "0x1013BE0", Offset = "0x10129E0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x600658A")]
	[Address(RVA = "0x1013BF0", Offset = "0x10129F0", Length = "0x3F4")]
	internal void OnEnable()
	{
	}

	[Token(Token = "0x600658B")]
	[Address(RVA = "0x1013FF0", Offset = "0x1012DF0", Length = "0x19C")]
	internal void OnDisable()
	{
	}

	[Token(Token = "0x600658C")]
	[Address(RVA = "0x1014190", Offset = "0x1012F90", Length = "0xAC")]
	private void DestroyDebugOverlayTarget()
	{
	}

	[Token(Token = "0x600658D")]
	[Address(RVA = "0x1014240", Offset = "0x1013040", Length = "0x60")]
	public void RequestMonitorPass(MonitorType monitor)
	{
	}

	[Token(Token = "0x600658E")]
	[Address(RVA = "0x1013BE0", Offset = "0x10129E0", Length = "0x4")]
	public void RequestDebugOverlay(DebugOverlay mode)
	{
	}

	[Token(Token = "0x600658F")]
	[Address(RVA = "0x10142B0", Offset = "0x10130B0", Length = "0xC")]
	internal void SetFrameSize(int width, int height)
	{
	}

	[Token(Token = "0x6006590")]
	[Address(RVA = "0x10142C0", Offset = "0x10130C0", Length = "0x489")]
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
	{
	}

	[Token(Token = "0x6006591")]
	[Address(RVA = "0x1014750", Offset = "0x1013550", Length = "0x1B")]
	internal DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x6006592")]
	[Address(RVA = "0x1014770", Offset = "0x1013570", Length = "0x641")]
	internal void RenderMonitors(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6006593")]
	[Address(RVA = "0x1014DC0", Offset = "0x1013BC0", Length = "0x5A8")]
	internal void RenderSpecialOverlays(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6006594")]
	[Address(RVA = "0x1015370", Offset = "0x1014170", Length = "0x19A")]
	internal void EndFrame()
	{
	}

	[Token(Token = "0x6006595")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PostProcessDebugLayer()
	{
	}
}

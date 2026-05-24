using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Preserve]
[Token(Token = "0x2000CB6")]
public sealed class TemporalAntialiasing
{
	[Token(Token = "0x2000CB7")]
	private enum Pass
	{
		[Token(Token = "0x4007F17")]
		SolverDilate,
		[Token(Token = "0x4007F18")]
		SolverNoDilate
	}

	[Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable, but blurrier, output.")]
	[Range(0.1f, 1f)]
	[Token(Token = "0x4007F08")]
	[FieldOffset(Offset = "0x10")]
	public float jitterSpread;

	[Tooltip("Controls the amount of sharpening applied to the color buffer. High values may introduce dark-border artifacts.")]
	[Range(0f, 3f)]
	[Token(Token = "0x4007F09")]
	[FieldOffset(Offset = "0x14")]
	public float sharpness;

	[Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
	[Range(0f, 0.99f)]
	[Token(Token = "0x4007F0A")]
	[FieldOffset(Offset = "0x18")]
	public float stationaryBlending;

	[Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
	[Range(0f, 0.99f)]
	[Token(Token = "0x4007F0B")]
	[FieldOffset(Offset = "0x1C")]
	public float motionBlending;

	[Token(Token = "0x4007F0C")]
	[FieldOffset(Offset = "0x20")]
	public Func<Camera, Vector2, Matrix4x4> jitteredMatrixFunc;

	[Token(Token = "0x4007F0E")]
	[FieldOffset(Offset = "0x30")]
	private readonly RenderTargetIdentifier[] m_Mrt;

	[Token(Token = "0x4007F0F")]
	[FieldOffset(Offset = "0x38")]
	private bool m_ResetHistory;

	[Token(Token = "0x4007F10")]
	private const int k_SampleCount = 8;

	[Token(Token = "0x4007F12")]
	private const int k_NumEyes = 2;

	[Token(Token = "0x4007F13")]
	private const int k_NumHistoryTextures = 2;

	[Token(Token = "0x4007F14")]
	[FieldOffset(Offset = "0x40")]
	private readonly RenderTexture[][] m_HistoryTextures;

	[Token(Token = "0x4007F15")]
	[FieldOffset(Offset = "0x48")]
	private readonly int[] m_HistoryPingPong;

	[Token(Token = "0x170006C1")]
	[field: Token(Token = "0x4007F0D")]
	[field: FieldOffset(Offset = "0x28")]
	public Vector2 jitter
	{
		[Token(Token = "0x600650E")]
		[Address(RVA = "0x100B2B0", Offset = "0x100A0B0", Length = "0x13")]
		get;
		[Token(Token = "0x600650F")]
		[Address(RVA = "0x100B2D0", Offset = "0x100A0D0", Length = "0x5")]
		private set;
	}

	[Token(Token = "0x170006C2")]
	[field: Token(Token = "0x4007F11")]
	[field: FieldOffset(Offset = "0x3C")]
	public int sampleIndex
	{
		[Token(Token = "0x6006510")]
		[Address(RVA = "0x63F4E0", Offset = "0x63E2E0", Length = "0x4")]
		get;
		[Token(Token = "0x6006511")]
		[Address(RVA = "0x620C80", Offset = "0x61FA80", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x6006512")]
	[Address(RVA = "0x100B2E0", Offset = "0x100A0E0", Length = "0x8E")]
	public bool IsSupported()
	{
		return false;
	}

	[Token(Token = "0x6006513")]
	[Address(RVA = "0x457110", Offset = "0x455F10", Length = "0x6")]
	internal DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x6006514")]
	[Address(RVA = "0xEAF760", Offset = "0xEAE560", Length = "0x5")]
	internal void ResetHistory()
	{
	}

	[Token(Token = "0x6006515")]
	[Address(RVA = "0x100B370", Offset = "0x100A170", Length = "0xC9")]
	private Vector2 GenerateRandomOffset()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6006516")]
	[Address(RVA = "0x100B440", Offset = "0x100A240", Length = "0xA4")]
	private Vector2 GetCurrentJitterOffset()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6006517")]
	[Address(RVA = "0x100B4F0", Offset = "0x100A2F0", Length = "0x18F")]
	public void NextJitterSample(Camera camera)
	{
	}

	[Token(Token = "0x6006518")]
	[Address(RVA = "0x100B680", Offset = "0x100A480", Length = "0x43D")]
	public void ConfigureJitteredProjectionMatrix(Camera camera)
	{
	}

	[Token(Token = "0x6006519")]
	[Address(RVA = "0x100BAC0", Offset = "0x100A8C0", Length = "0x5F0")]
	public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600651A")]
	[Address(RVA = "0x100C0C0", Offset = "0x100AEC0", Length = "0x167")]
	private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600651B")]
	[Address(RVA = "0x100C230", Offset = "0x100B030", Length = "0x685")]
	private RenderTexture CheckHistory(int id, PostProcessRenderContext context)
	{
		return null;
	}

	[Token(Token = "0x600651C")]
	[Address(RVA = "0x100C8C0", Offset = "0x100B6C0", Length = "0x668")]
	internal void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600651D")]
	[Address(RVA = "0x100CF30", Offset = "0x100BD30", Length = "0x153")]
	internal void Release()
	{
	}

	[Token(Token = "0x600651E")]
	[Address(RVA = "0x100D090", Offset = "0x100BE90", Length = "0x1AB")]
	public TemporalAntialiasing()
	{
	}
}

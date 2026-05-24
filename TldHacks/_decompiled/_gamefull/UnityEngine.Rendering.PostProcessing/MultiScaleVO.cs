using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Preserve]
[Token(Token = "0x2000CA6")]
internal sealed class MultiScaleVO : IAmbientOcclusionMethod
{
	[Token(Token = "0x2000CA7")]
	internal enum MipLevel
	{
		[Token(Token = "0x4007EC5")]
		Original,
		[Token(Token = "0x4007EC6")]
		L1,
		[Token(Token = "0x4007EC7")]
		L2,
		[Token(Token = "0x4007EC8")]
		L3,
		[Token(Token = "0x4007EC9")]
		L4,
		[Token(Token = "0x4007ECA")]
		L5,
		[Token(Token = "0x4007ECB")]
		L6
	}

	[Token(Token = "0x2000CA8")]
	private enum Pass
	{
		[Token(Token = "0x4007ECD")]
		DepthCopy,
		[Token(Token = "0x4007ECE")]
		CompositionDeferred,
		[Token(Token = "0x4007ECF")]
		CompositionForward,
		[Token(Token = "0x4007ED0")]
		DebugOverlay
	}

	[Token(Token = "0x4007EB5")]
	[FieldOffset(Offset = "0x10")]
	private readonly float[] m_SampleThickness;

	[Token(Token = "0x4007EB6")]
	[FieldOffset(Offset = "0x18")]
	private readonly float[] m_InvThicknessTable;

	[Token(Token = "0x4007EB7")]
	[FieldOffset(Offset = "0x20")]
	private readonly float[] m_SampleWeightTable;

	[Token(Token = "0x4007EB8")]
	[FieldOffset(Offset = "0x28")]
	private readonly int[] m_Widths;

	[Token(Token = "0x4007EB9")]
	[FieldOffset(Offset = "0x30")]
	private readonly int[] m_Heights;

	[Token(Token = "0x4007EBA")]
	[FieldOffset(Offset = "0x38")]
	private readonly int[] m_ScaledWidths;

	[Token(Token = "0x4007EBB")]
	[FieldOffset(Offset = "0x40")]
	private readonly int[] m_ScaledHeights;

	[Token(Token = "0x4007EBC")]
	[FieldOffset(Offset = "0x48")]
	private AmbientOcclusion m_Settings;

	[Token(Token = "0x4007EBD")]
	[FieldOffset(Offset = "0x50")]
	private PropertySheet m_PropertySheet;

	[Token(Token = "0x4007EBE")]
	[FieldOffset(Offset = "0x58")]
	private PostProcessResources m_Resources;

	[Token(Token = "0x4007EBF")]
	[FieldOffset(Offset = "0x60")]
	private RenderTexture m_AmbientOnlyAO;

	[Token(Token = "0x4007EC0")]
	[FieldOffset(Offset = "0x68")]
	private RenderTextureFormat m_R8Format;

	[Token(Token = "0x4007EC1")]
	[FieldOffset(Offset = "0x6C")]
	private RenderTextureFormat m_R16Format;

	[Token(Token = "0x4007EC2")]
	[FieldOffset(Offset = "0x70")]
	private bool float4Texture;

	[Token(Token = "0x4007EC3")]
	[FieldOffset(Offset = "0x78")]
	private readonly RenderTargetIdentifier[] m_MRT;

	[Token(Token = "0x60064E1")]
	[Address(RVA = "0xFFF460", Offset = "0xFFE260", Length = "0x8C4")]
	public MultiScaleVO(AmbientOcclusion settings)
	{
	}

	[Token(Token = "0x60064E2")]
	[Address(RVA = "0x457110", Offset = "0x455F10", Length = "0x6")]
	public DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x60064E3")]
	[Address(RVA = "0x95D320", Offset = "0x95C120", Length = "0x52")]
	public void SetResources(PostProcessResources resources)
	{
	}

	[Token(Token = "0x60064E4")]
	[Address(RVA = "0xFFFD30", Offset = "0xFFEB30", Length = "0x225")]
	private void Alloc(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav, bool dynamicScale)
	{
	}

	[Token(Token = "0x60064E5")]
	[Address(RVA = "0xFFFF60", Offset = "0xFFED60", Length = "0x225")]
	private void AllocArray(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav, bool dynamicScale)
	{
	}

	[Token(Token = "0x60064E6")]
	[Address(RVA = "0x1000190", Offset = "0xFFEF90", Length = "0x7C")]
	private void Release(CommandBuffer cmd, int id)
	{
	}

	[Token(Token = "0x60064E7")]
	[Address(RVA = "0x1000210", Offset = "0xFFF010", Length = "0x1B1")]
	private Vector4 CalculateZBufferParams(Camera camera)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60064E8")]
	[Address(RVA = "0x10003D0", Offset = "0xFFF1D0", Length = "0xC6")]
	private float CalculateTanHalfFovHeight(Camera camera)
	{
		return 0f;
	}

	[Token(Token = "0x60064E9")]
	[Address(RVA = "0x10004A0", Offset = "0xFFF2A0", Length = "0x52")]
	private Vector2 GetSize(MipLevel mip)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60064EA")]
	[Address(RVA = "0x1000500", Offset = "0xFFF300", Length = "0x5F")]
	private Vector3 GetSizeArray(MipLevel mip)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60064EB")]
	[Address(RVA = "0x1000560", Offset = "0xFFF360", Length = "0xE0C")]
	public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA)
	{
	}

	[Token(Token = "0x60064EC")]
	[Address(RVA = "0x1001370", Offset = "0x1000170", Length = "0x787")]
	private void PushAllocCommands(CommandBuffer cmd, bool isMSAA, Camera camera)
	{
	}

	[Token(Token = "0x60064ED")]
	[Address(RVA = "0x1001B00", Offset = "0x1000900", Length = "0x1747")]
	private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, RenderTargetIdentifier? depthMap, bool isMSAA)
	{
	}

	[Token(Token = "0x60064EE")]
	[Address(RVA = "0x1003250", Offset = "0x1002050", Length = "0xCE4")]
	private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA)
	{
	}

	[Token(Token = "0x60064EF")]
	[Address(RVA = "0x1003F40", Offset = "0x1002D40", Length = "0xC58")]
	private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, int? highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = false)
	{
	}

	[Token(Token = "0x60064F0")]
	[Address(RVA = "0x1004BA0", Offset = "0x10039A0", Length = "0x6B5")]
	private void PushReleaseCommands(CommandBuffer cmd)
	{
	}

	[Token(Token = "0x60064F1")]
	[Address(RVA = "0x1005260", Offset = "0x1004060", Length = "0x20F")]
	private void PreparePropertySheet(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064F2")]
	[Address(RVA = "0x1005470", Offset = "0x1004270", Length = "0x2DD")]
	private void CheckAOTexture(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064F3")]
	[Address(RVA = "0x1005750", Offset = "0x1004550", Length = "0xCB")]
	private void PushDebug(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064F4")]
	[Address(RVA = "0x1005820", Offset = "0x1004620", Length = "0x672")]
	public void RenderAfterOpaque(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064F5")]
	[Address(RVA = "0x1005EA0", Offset = "0x1004CA0", Length = "0x1B3")]
	public void RenderAmbientOnly(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064F6")]
	[Address(RVA = "0x1006060", Offset = "0x1004E60", Length = "0x28C")]
	public void CompositeAmbientOnly(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064F7")]
	[Address(RVA = "0x10062F0", Offset = "0x10050F0", Length = "0xAC")]
	public void Release()
	{
	}
}

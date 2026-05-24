using System.Collections;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB;

[Token(Token = "0x2000BD4")]
public static class MaterialManager
{
	[Token(Token = "0x2000BD5")]
	public enum BlendingMode
	{
		[Token(Token = "0x4007930")]
		Additive,
		[Token(Token = "0x4007931")]
		SoftAdditive,
		[Token(Token = "0x4007932")]
		TraditionalTransparency,
		[Token(Token = "0x4007933")]
		Count
	}

	[Token(Token = "0x2000BD6")]
	public enum Noise3D
	{
		[Token(Token = "0x4007935")]
		Off,
		[Token(Token = "0x4007936")]
		On,
		[Token(Token = "0x4007937")]
		Count
	}

	[Token(Token = "0x2000BD7")]
	public enum DepthBlend
	{
		[Token(Token = "0x4007939")]
		Off,
		[Token(Token = "0x400793A")]
		On,
		[Token(Token = "0x400793B")]
		Count
	}

	[Token(Token = "0x2000BD8")]
	public enum ColorGradient
	{
		[Token(Token = "0x400793D")]
		Off,
		[Token(Token = "0x400793E")]
		MatrixLow,
		[Token(Token = "0x400793F")]
		MatrixHigh,
		[Token(Token = "0x4007940")]
		Count
	}

	[Token(Token = "0x2000BD9")]
	public enum DynamicOcclusion
	{
		[Token(Token = "0x4007942")]
		Off,
		[Token(Token = "0x4007943")]
		ClippingPlane,
		[Token(Token = "0x4007944")]
		DepthTexture,
		[Token(Token = "0x4007945")]
		Count
	}

	[Token(Token = "0x2000BDA")]
	public enum MeshSkewing
	{
		[Token(Token = "0x4007947")]
		Off,
		[Token(Token = "0x4007948")]
		On,
		[Token(Token = "0x4007949")]
		Count
	}

	[Token(Token = "0x2000BDB")]
	public enum ShaderAccuracy
	{
		[Token(Token = "0x400794B")]
		Fast,
		[Token(Token = "0x400794C")]
		High,
		[Token(Token = "0x400794D")]
		Count
	}

	[Token(Token = "0x2000BDC")]
	public class StaticProperties
	{
		[Token(Token = "0x400794E")]
		[FieldOffset(Offset = "0x10")]
		public BlendingMode blendingMode;

		[Token(Token = "0x400794F")]
		[FieldOffset(Offset = "0x14")]
		public Noise3D noise3D;

		[Token(Token = "0x4007950")]
		[FieldOffset(Offset = "0x18")]
		public DepthBlend depthBlend;

		[Token(Token = "0x4007951")]
		[FieldOffset(Offset = "0x1C")]
		public ColorGradient colorGradient;

		[Token(Token = "0x4007952")]
		[FieldOffset(Offset = "0x20")]
		public DynamicOcclusion dynamicOcclusion;

		[Token(Token = "0x4007953")]
		[FieldOffset(Offset = "0x24")]
		public MeshSkewing meshSkewing;

		[Token(Token = "0x4007954")]
		[FieldOffset(Offset = "0x28")]
		public ShaderAccuracy shaderAccuracy;

		[Token(Token = "0x170003DB")]
		private int blendingModeID
		{
			[Token(Token = "0x6005D8E")]
			[Address(RVA = "0x40E0A0", Offset = "0x40CEA0", Length = "0x4")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x170003DC")]
		private int noise3DID
		{
			[Token(Token = "0x6005D8F")]
			[Address(RVA = "0xF67090", Offset = "0xF65E90", Length = "0x33")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x170003DD")]
		private int depthBlendID
		{
			[Token(Token = "0x6005D90")]
			[Address(RVA = "0xF670D0", Offset = "0xF65ED0", Length = "0x33")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x170003DE")]
		private int colorGradientID
		{
			[Token(Token = "0x6005D91")]
			[Address(RVA = "0xF67110", Offset = "0xF65F10", Length = "0x33")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x170003DF")]
		private int dynamicOcclusionID
		{
			[Token(Token = "0x6005D92")]
			[Address(RVA = "0xF67150", Offset = "0xF65F50", Length = "0x33")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x170003E0")]
		private int meshSkewingID
		{
			[Token(Token = "0x6005D93")]
			[Address(RVA = "0xF67190", Offset = "0xF65F90", Length = "0x33")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x170003E1")]
		private int shaderAccuracyID
		{
			[Token(Token = "0x6005D94")]
			[Address(RVA = "0xF671D0", Offset = "0xF65FD0", Length = "0x36")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x170003E2")]
		public int materialID
		{
			[Token(Token = "0x6005D95")]
			[Address(RVA = "0xF67210", Offset = "0xF66010", Length = "0x11D")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x6005D96")]
		[Address(RVA = "0xF67330", Offset = "0xF66130", Length = "0x2FB")]
		public void ApplyToMaterial(Material mat)
		{
		}

		[Token(Token = "0x6005D97")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public StaticProperties()
		{
		}
	}

	[Token(Token = "0x2000BDD")]
	private class MaterialsGroup
	{
		[Token(Token = "0x4007955")]
		[FieldOffset(Offset = "0x10")]
		public Material[] materials;

		[Token(Token = "0x6005D98")]
		[Address(RVA = "0xF67630", Offset = "0xF66430", Length = "0xB8")]
		public MaterialsGroup()
		{
		}
	}

	[Token(Token = "0x4007929")]
	public static MaterialPropertyBlock materialPropertyBlock;

	[Token(Token = "0x400792A")]
	private static readonly BlendMode[] BlendingMode_SrcFactor;

	[Token(Token = "0x400792B")]
	private static readonly BlendMode[] BlendingMode_DstFactor;

	[Token(Token = "0x400792C")]
	private static readonly bool[] BlendingMode_AlphaAsBlack;

	[Token(Token = "0x400792D")]
	private static int kStaticPropertiesCount;

	[Token(Token = "0x400792E")]
	private static Hashtable ms_MaterialsGroup;

	[Token(Token = "0x6005D8A")]
	[Address(RVA = "0xF66390", Offset = "0xF65190", Length = "0x2AB")]
	public static Material NewMaterialTransient(bool gpuInstanced)
	{
		return null;
	}

	[Token(Token = "0x6005D8B")]
	[Address(RVA = "0xF66640", Offset = "0xF65440", Length = "0x16F")]
	public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
	{
		return null;
	}

	[Token(Token = "0x6005D8C")]
	[Address(RVA = "0xF667B0", Offset = "0xF655B0", Length = "0x508")]
	public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
	{
		return null;
	}
}

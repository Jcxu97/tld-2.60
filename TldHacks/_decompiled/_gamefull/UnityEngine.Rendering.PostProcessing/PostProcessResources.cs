using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CEA")]
public sealed class PostProcessResources : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000CEB")]
	public sealed class Shaders
	{
		[Token(Token = "0x4007FF9")]
		[FieldOffset(Offset = "0x10")]
		public Shader bloom;

		[Token(Token = "0x4007FFA")]
		[FieldOffset(Offset = "0x18")]
		public Shader copy;

		[Token(Token = "0x4007FFB")]
		[FieldOffset(Offset = "0x20")]
		public Shader copyStd;

		[Token(Token = "0x4007FFC")]
		[FieldOffset(Offset = "0x28")]
		public Shader copyStdFromTexArray;

		[Token(Token = "0x4007FFD")]
		[FieldOffset(Offset = "0x30")]
		public Shader copyStdFromDoubleWide;

		[Token(Token = "0x4007FFE")]
		[FieldOffset(Offset = "0x38")]
		public Shader discardAlpha;

		[Token(Token = "0x4007FFF")]
		[FieldOffset(Offset = "0x40")]
		public Shader depthOfField;

		[Token(Token = "0x4008000")]
		[FieldOffset(Offset = "0x48")]
		public Shader finalPass;

		[Token(Token = "0x4008001")]
		[FieldOffset(Offset = "0x50")]
		public Shader grainBaker;

		[Token(Token = "0x4008002")]
		[FieldOffset(Offset = "0x58")]
		public Shader motionBlur;

		[Token(Token = "0x4008003")]
		[FieldOffset(Offset = "0x60")]
		public Shader temporalAntialiasing;

		[Token(Token = "0x4008004")]
		[FieldOffset(Offset = "0x68")]
		public Shader subpixelMorphologicalAntialiasing;

		[Token(Token = "0x4008005")]
		[FieldOffset(Offset = "0x70")]
		public Shader texture2dLerp;

		[Token(Token = "0x4008006")]
		[FieldOffset(Offset = "0x78")]
		public Shader uber;

		[Token(Token = "0x4008007")]
		[FieldOffset(Offset = "0x80")]
		public Shader lut2DBaker;

		[Token(Token = "0x4008008")]
		[FieldOffset(Offset = "0x88")]
		public Shader lightMeter;

		[Token(Token = "0x4008009")]
		[FieldOffset(Offset = "0x90")]
		public Shader gammaHistogram;

		[Token(Token = "0x400800A")]
		[FieldOffset(Offset = "0x98")]
		public Shader waveform;

		[Token(Token = "0x400800B")]
		[FieldOffset(Offset = "0xA0")]
		public Shader vectorscope;

		[Token(Token = "0x400800C")]
		[FieldOffset(Offset = "0xA8")]
		public Shader debugOverlays;

		[Token(Token = "0x400800D")]
		[FieldOffset(Offset = "0xB0")]
		public Shader deferredFog;

		[Token(Token = "0x400800E")]
		[FieldOffset(Offset = "0xB8")]
		public Shader scalableAO;

		[Token(Token = "0x400800F")]
		[FieldOffset(Offset = "0xC0")]
		public Shader multiScaleAO;

		[Token(Token = "0x4008010")]
		[FieldOffset(Offset = "0xC8")]
		public Shader screenSpaceReflections;

		[Token(Token = "0x600664A")]
		[Address(RVA = "0x1025B80", Offset = "0x1024980", Length = "0x5A")]
		public Shaders Clone()
		{
			return null;
		}

		[Token(Token = "0x600664B")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public Shaders()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000CEC")]
	public sealed class ComputeShaders
	{
		[Token(Token = "0x4008011")]
		[FieldOffset(Offset = "0x10")]
		public ComputeShader autoExposure;

		[Token(Token = "0x4008012")]
		[FieldOffset(Offset = "0x18")]
		public ComputeShader exposureHistogram;

		[Token(Token = "0x4008013")]
		[FieldOffset(Offset = "0x20")]
		public ComputeShader lut3DBaker;

		[Token(Token = "0x4008014")]
		[FieldOffset(Offset = "0x28")]
		public ComputeShader texture3dLerp;

		[Token(Token = "0x4008015")]
		[FieldOffset(Offset = "0x30")]
		public ComputeShader gammaHistogram;

		[Token(Token = "0x4008016")]
		[FieldOffset(Offset = "0x38")]
		public ComputeShader waveform;

		[Token(Token = "0x4008017")]
		[FieldOffset(Offset = "0x40")]
		public ComputeShader vectorscope;

		[Token(Token = "0x4008018")]
		[FieldOffset(Offset = "0x48")]
		public ComputeShader multiScaleAODownsample1;

		[Token(Token = "0x4008019")]
		[FieldOffset(Offset = "0x50")]
		public ComputeShader multiScaleAODownsample2;

		[Token(Token = "0x400801A")]
		[FieldOffset(Offset = "0x58")]
		public ComputeShader multiScaleAORender;

		[Token(Token = "0x400801B")]
		[FieldOffset(Offset = "0x60")]
		public ComputeShader multiScaleAOUpsample;

		[Token(Token = "0x400801C")]
		[FieldOffset(Offset = "0x68")]
		public ComputeShader gaussianDownsample;

		[Token(Token = "0x600664C")]
		[Address(RVA = "0x1025BE0", Offset = "0x10249E0", Length = "0x5A")]
		public ComputeShaders Clone()
		{
			return null;
		}

		[Token(Token = "0x600664D")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ComputeShaders()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000CED")]
	public sealed class SMAALuts
	{
		[Token(Token = "0x400801D")]
		[FieldOffset(Offset = "0x10")]
		public Texture2D area;

		[Token(Token = "0x400801E")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D search;

		[Token(Token = "0x600664E")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SMAALuts()
		{
		}
	}

	[Token(Token = "0x4007FF4")]
	[FieldOffset(Offset = "0x18")]
	public Texture2D[] blueNoise64;

	[Token(Token = "0x4007FF5")]
	[FieldOffset(Offset = "0x20")]
	public Texture2D[] blueNoise256;

	[Token(Token = "0x4007FF6")]
	[FieldOffset(Offset = "0x28")]
	public SMAALuts smaaLuts;

	[Token(Token = "0x4007FF7")]
	[FieldOffset(Offset = "0x30")]
	public Shaders shaders;

	[Token(Token = "0x4007FF8")]
	[FieldOffset(Offset = "0x38")]
	public ComputeShaders computeShaders;

	[Token(Token = "0x6006649")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PostProcessResources()
	{
	}
}

using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CFE")]
internal static class ShaderIDs
{
	[Token(Token = "0x4008068")]
	internal static readonly int MainTex;

	[Token(Token = "0x4008069")]
	internal static readonly int Jitter;

	[Token(Token = "0x400806A")]
	internal static readonly int Sharpness;

	[Token(Token = "0x400806B")]
	internal static readonly int FinalBlendParameters;

	[Token(Token = "0x400806C")]
	internal static readonly int HistoryTex;

	[Token(Token = "0x400806D")]
	internal static readonly int SMAA_Flip;

	[Token(Token = "0x400806E")]
	internal static readonly int SMAA_Flop;

	[Token(Token = "0x400806F")]
	internal static readonly int AOParams;

	[Token(Token = "0x4008070")]
	internal static readonly int AOColor;

	[Token(Token = "0x4008071")]
	internal static readonly int OcclusionTexture1;

	[Token(Token = "0x4008072")]
	internal static readonly int OcclusionTexture2;

	[Token(Token = "0x4008073")]
	internal static readonly int SAOcclusionTexture;

	[Token(Token = "0x4008074")]
	internal static readonly int MSVOcclusionTexture;

	[Token(Token = "0x4008075")]
	internal static readonly int DepthCopy;

	[Token(Token = "0x4008076")]
	internal static readonly int LinearDepth;

	[Token(Token = "0x4008077")]
	internal static readonly int LowDepth1;

	[Token(Token = "0x4008078")]
	internal static readonly int LowDepth2;

	[Token(Token = "0x4008079")]
	internal static readonly int LowDepth3;

	[Token(Token = "0x400807A")]
	internal static readonly int LowDepth4;

	[Token(Token = "0x400807B")]
	internal static readonly int TiledDepth1;

	[Token(Token = "0x400807C")]
	internal static readonly int TiledDepth2;

	[Token(Token = "0x400807D")]
	internal static readonly int TiledDepth3;

	[Token(Token = "0x400807E")]
	internal static readonly int TiledDepth4;

	[Token(Token = "0x400807F")]
	internal static readonly int Occlusion1;

	[Token(Token = "0x4008080")]
	internal static readonly int Occlusion2;

	[Token(Token = "0x4008081")]
	internal static readonly int Occlusion3;

	[Token(Token = "0x4008082")]
	internal static readonly int Occlusion4;

	[Token(Token = "0x4008083")]
	internal static readonly int Combined1;

	[Token(Token = "0x4008084")]
	internal static readonly int Combined2;

	[Token(Token = "0x4008085")]
	internal static readonly int Combined3;

	[Token(Token = "0x4008086")]
	internal static readonly int SSRResolveTemp;

	[Token(Token = "0x4008087")]
	internal static readonly int Noise;

	[Token(Token = "0x4008088")]
	internal static readonly int Test;

	[Token(Token = "0x4008089")]
	internal static readonly int Resolve;

	[Token(Token = "0x400808A")]
	internal static readonly int History;

	[Token(Token = "0x400808B")]
	internal static readonly int ViewMatrix;

	[Token(Token = "0x400808C")]
	internal static readonly int InverseViewMatrix;

	[Token(Token = "0x400808D")]
	internal static readonly int ScreenSpaceProjectionMatrix;

	[Token(Token = "0x400808E")]
	internal static readonly int Params2;

	[Token(Token = "0x400808F")]
	internal static readonly int FogColor;

	[Token(Token = "0x4008090")]
	internal static readonly int FogParams;

	[Token(Token = "0x4008091")]
	internal static readonly int VelocityScale;

	[Token(Token = "0x4008092")]
	internal static readonly int MaxBlurRadius;

	[Token(Token = "0x4008093")]
	internal static readonly int RcpMaxBlurRadius;

	[Token(Token = "0x4008094")]
	internal static readonly int VelocityTex;

	[Token(Token = "0x4008095")]
	internal static readonly int Tile2RT;

	[Token(Token = "0x4008096")]
	internal static readonly int Tile4RT;

	[Token(Token = "0x4008097")]
	internal static readonly int Tile8RT;

	[Token(Token = "0x4008098")]
	internal static readonly int TileMaxOffs;

	[Token(Token = "0x4008099")]
	internal static readonly int TileMaxLoop;

	[Token(Token = "0x400809A")]
	internal static readonly int TileVRT;

	[Token(Token = "0x400809B")]
	internal static readonly int NeighborMaxTex;

	[Token(Token = "0x400809C")]
	internal static readonly int LoopCount;

	[Token(Token = "0x400809D")]
	internal static readonly int DepthOfFieldTemp;

	[Token(Token = "0x400809E")]
	internal static readonly int DepthOfFieldTex;

	[Token(Token = "0x400809F")]
	internal static readonly int Distance;

	[Token(Token = "0x40080A0")]
	internal static readonly int LensCoeff;

	[Token(Token = "0x40080A1")]
	internal static readonly int MaxCoC;

	[Token(Token = "0x40080A2")]
	internal static readonly int RcpMaxCoC;

	[Token(Token = "0x40080A3")]
	internal static readonly int RcpAspect;

	[Token(Token = "0x40080A4")]
	internal static readonly int CoCTex;

	[Token(Token = "0x40080A5")]
	internal static readonly int TaaParams;

	[Token(Token = "0x40080A6")]
	internal static readonly int AutoExposureTex;

	[Token(Token = "0x40080A7")]
	internal static readonly int HistogramBuffer;

	[Token(Token = "0x40080A8")]
	internal static readonly int Params;

	[Token(Token = "0x40080A9")]
	internal static readonly int ScaleOffsetRes;

	[Token(Token = "0x40080AA")]
	internal static readonly int BloomTex;

	[Token(Token = "0x40080AB")]
	internal static readonly int SampleScale;

	[Token(Token = "0x40080AC")]
	internal static readonly int Threshold;

	[Token(Token = "0x40080AD")]
	internal static readonly int ColorIntensity;

	[Token(Token = "0x40080AE")]
	internal static readonly int Bloom_DirtTex;

	[Token(Token = "0x40080AF")]
	internal static readonly int Bloom_Settings;

	[Token(Token = "0x40080B0")]
	internal static readonly int Bloom_Color;

	[Token(Token = "0x40080B1")]
	internal static readonly int Bloom_DirtTileOffset;

	[Token(Token = "0x40080B2")]
	internal static readonly int ChromaticAberration_Amount;

	[Token(Token = "0x40080B3")]
	internal static readonly int ChromaticAberration_SpectralLut;

	[Token(Token = "0x40080B4")]
	internal static readonly int Distortion_CenterScale;

	[Token(Token = "0x40080B5")]
	internal static readonly int Distortion_Amount;

	[Token(Token = "0x40080B6")]
	internal static readonly int Lut2D;

	[Token(Token = "0x40080B7")]
	internal static readonly int Lut3D;

	[Token(Token = "0x40080B8")]
	internal static readonly int Lut3D_Params;

	[Token(Token = "0x40080B9")]
	internal static readonly int Lut2D_Params;

	[Token(Token = "0x40080BA")]
	internal static readonly int NoiseParams;

	[Token(Token = "0x40080BB")]
	internal static readonly int NoiseTex;

	[Token(Token = "0x40080BC")]
	internal static readonly int UserLut2D_Params;

	[Token(Token = "0x40080BD")]
	internal static readonly int PostExposure;

	[Token(Token = "0x40080BE")]
	internal static readonly int ColorBalance;

	[Token(Token = "0x40080BF")]
	internal static readonly int ColorFilter;

	[Token(Token = "0x40080C0")]
	internal static readonly int HueSatCon;

	[Token(Token = "0x40080C1")]
	internal static readonly int Brightness;

	[Token(Token = "0x40080C2")]
	internal static readonly int ChannelMixerRed;

	[Token(Token = "0x40080C3")]
	internal static readonly int ChannelMixerGreen;

	[Token(Token = "0x40080C4")]
	internal static readonly int ChannelMixerBlue;

	[Token(Token = "0x40080C5")]
	internal static readonly int Lift;

	[Token(Token = "0x40080C6")]
	internal static readonly int InvGamma;

	[Token(Token = "0x40080C7")]
	internal static readonly int Gain;

	[Token(Token = "0x40080C8")]
	internal static readonly int Curves;

	[Token(Token = "0x40080C9")]
	internal static readonly int CustomToneCurve;

	[Token(Token = "0x40080CA")]
	internal static readonly int ToeSegmentA;

	[Token(Token = "0x40080CB")]
	internal static readonly int ToeSegmentB;

	[Token(Token = "0x40080CC")]
	internal static readonly int MidSegmentA;

	[Token(Token = "0x40080CD")]
	internal static readonly int MidSegmentB;

	[Token(Token = "0x40080CE")]
	internal static readonly int ShoSegmentA;

	[Token(Token = "0x40080CF")]
	internal static readonly int ShoSegmentB;

	[Token(Token = "0x40080D0")]
	internal static readonly int Lut1A;

	[Token(Token = "0x40080D1")]
	internal static readonly int Lut1B;

	[Token(Token = "0x40080D2")]
	internal static readonly int Lut2A;

	[Token(Token = "0x40080D3")]
	internal static readonly int Lut2B;

	[Token(Token = "0x40080D4")]
	internal static readonly int LutPain;

	[Token(Token = "0x40080D5")]
	internal static readonly int LutStim;

	[Token(Token = "0x40080D6")]
	internal static readonly int LutElectrocution;

	[Token(Token = "0x40080D7")]
	internal static readonly int LutBoost;

	[Token(Token = "0x40080D8")]
	internal static readonly int LutHeadache;

	[Token(Token = "0x40080D9")]
	internal static readonly int LutSuffocation;

	[Token(Token = "0x40080DA")]
	internal static readonly int LutAux;

	[Token(Token = "0x40080DB")]
	internal static readonly int BlendAuxAmount;

	[Token(Token = "0x40080DC")]
	internal static readonly int BlendAmounts;

	[Token(Token = "0x40080DD")]
	internal static readonly int EffectOverrideBlendAmounts;

	[Token(Token = "0x40080DE")]
	internal static readonly int EffectOverrideBlendAmounts2;

	[Token(Token = "0x40080DF")]
	internal static readonly int BlendAdjustments;

	[Token(Token = "0x40080E0")]
	internal static readonly int Vignette_Color;

	[Token(Token = "0x40080E1")]
	internal static readonly int Vignette_Center;

	[Token(Token = "0x40080E2")]
	internal static readonly int Vignette_Settings;

	[Token(Token = "0x40080E3")]
	internal static readonly int Vignette_Mask;

	[Token(Token = "0x40080E4")]
	internal static readonly int Vignette_Opacity;

	[Token(Token = "0x40080E5")]
	internal static readonly int Vignette_Mode;

	[Token(Token = "0x40080E6")]
	internal static readonly int Grain_Params1;

	[Token(Token = "0x40080E7")]
	internal static readonly int Grain_Params2;

	[Token(Token = "0x40080E8")]
	internal static readonly int GrainTex;

	[Token(Token = "0x40080E9")]
	internal static readonly int Phase;

	[Token(Token = "0x40080EA")]
	internal static readonly int GrainNoiseParameters;

	[Token(Token = "0x40080EB")]
	internal static readonly int LumaInAlpha;

	[Token(Token = "0x40080EC")]
	internal static readonly int DitheringTex;

	[Token(Token = "0x40080ED")]
	internal static readonly int Dithering_Coords;

	[Token(Token = "0x40080EE")]
	internal static readonly int From;

	[Token(Token = "0x40080EF")]
	internal static readonly int To;

	[Token(Token = "0x40080F0")]
	internal static readonly int Interp;

	[Token(Token = "0x40080F1")]
	internal static readonly int TargetColor;

	[Token(Token = "0x40080F2")]
	internal static readonly int HalfResFinalCopy;

	[Token(Token = "0x40080F3")]
	internal static readonly int WaveformSource;

	[Token(Token = "0x40080F4")]
	internal static readonly int WaveformBuffer;

	[Token(Token = "0x40080F5")]
	internal static readonly int VectorscopeBuffer;

	[Token(Token = "0x40080F6")]
	internal static readonly int RenderViewportScaleFactor;

	[Token(Token = "0x40080F7")]
	internal static readonly int UVTransform;

	[Token(Token = "0x40080F8")]
	internal static readonly int DepthSlice;

	[Token(Token = "0x40080F9")]
	internal static readonly int UVScaleOffset;

	[Token(Token = "0x40080FA")]
	internal static readonly int PosScaleOffset;
}

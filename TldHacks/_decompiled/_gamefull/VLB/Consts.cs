using Cpp2ILInjected;
using UnityEngine;

namespace VLB;

[Token(Token = "0x2000BBC")]
public static class Consts
{
	[Token(Token = "0x400786F")]
	private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

	[Token(Token = "0x4007870")]
	public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

	[Token(Token = "0x4007871")]
	public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

	[Token(Token = "0x4007872")]
	public const string HelpUrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/";

	[Token(Token = "0x4007873")]
	public const string HelpUrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/";

	[Token(Token = "0x4007874")]
	public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

	[Token(Token = "0x4007875")]
	public const string HelpUrlSkewingHandle = "http://saladgamer.com/vlb-doc/comp-skewinghandle/";

	[Token(Token = "0x4007876")]
	public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

	[Token(Token = "0x4007877")]
	public static readonly bool ProceduralObjectsVisibleInEditor;

	[Token(Token = "0x4007878")]
	public static readonly Color FlatColor;

	[Token(Token = "0x4007879")]
	public const ColorMode ColorModeDefault = ColorMode.Flat;

	[Token(Token = "0x400787A")]
	public const float IntensityDefault = 1f;

	[Token(Token = "0x400787B")]
	public const float IntensityMin = 0f;

	[Token(Token = "0x400787C")]
	public const float IntensityMax = 8f;

	[Token(Token = "0x400787D")]
	public const float SpotAngleDefault = 35f;

	[Token(Token = "0x400787E")]
	public const float SpotAngleMin = 0.1f;

	[Token(Token = "0x400787F")]
	public const float SpotAngleMax = 179.9f;

	[Token(Token = "0x4007880")]
	public const float ConeRadiusStart = 0.1f;

	[Token(Token = "0x4007881")]
	public const MeshType GeomMeshType = MeshType.Shared;

	[Token(Token = "0x4007882")]
	public const int GeomSidesDefault = 18;

	[Token(Token = "0x4007883")]
	public const int GeomSidesMin = 3;

	[Token(Token = "0x4007884")]
	public const int GeomSidesMax = 256;

	[Token(Token = "0x4007885")]
	public const int GeomSegmentsDefault = 5;

	[Token(Token = "0x4007886")]
	public const int GeomSegmentsMin = 0;

	[Token(Token = "0x4007887")]
	public const int GeomSegmentsMax = 64;

	[Token(Token = "0x4007888")]
	public const bool GeomCap = false;

	[Token(Token = "0x4007889")]
	public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

	[Token(Token = "0x400788A")]
	public const float AttenuationCustomBlending = 0.5f;

	[Token(Token = "0x400788B")]
	public const float FallOffStart = 0f;

	[Token(Token = "0x400788C")]
	public const float FallOffEnd = 3f;

	[Token(Token = "0x400788D")]
	public const float FallOffDistancesMinThreshold = 0.01f;

	[Token(Token = "0x400788E")]
	public const float DepthBlendDistance = 2f;

	[Token(Token = "0x400788F")]
	public const float CameraClippingDistance = 0.5f;

	[Token(Token = "0x4007890")]
	public const float FresnelPowMaxValue = 10f;

	[Token(Token = "0x4007891")]
	public const float FresnelPow = 8f;

	[Token(Token = "0x4007892")]
	public const float GlareFrontal = 0.5f;

	[Token(Token = "0x4007893")]
	public const float GlareBehind = 0.5f;

	[Token(Token = "0x4007894")]
	public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

	[Token(Token = "0x4007895")]
	public const float NoiseIntensityMin = 0f;

	[Token(Token = "0x4007896")]
	public const float NoiseIntensityMax = 1f;

	[Token(Token = "0x4007897")]
	public const float NoiseIntensityDefault = 0.5f;

	[Token(Token = "0x4007898")]
	public const float NoiseScaleMin = 0.01f;

	[Token(Token = "0x4007899")]
	public const float NoiseScaleMax = 2f;

	[Token(Token = "0x400789A")]
	public const float NoiseScaleDefault = 0.5f;

	[Token(Token = "0x400789B")]
	public static readonly Vector3 NoiseVelocityDefault;

	[Token(Token = "0x400789C")]
	public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

	[Token(Token = "0x400789D")]
	public const ShaderAccuracy ShaderAccuracyDefault = ShaderAccuracy.Fast;

	[Token(Token = "0x400789E")]
	public const float FadeOutBeginDefault = -150f;

	[Token(Token = "0x400789F")]
	public const float FadeOutEndDefault = -200f;

	[Token(Token = "0x40078A0")]
	public const Dimensions DimensionsDefault = Dimensions.Dim3D;

	[Token(Token = "0x40078A1")]
	public static readonly Vector2 TiltDefault;

	[Token(Token = "0x40078A2")]
	public static readonly Vector3 SkewingLocalForwardDirectionDefault;

	[Token(Token = "0x40078A3")]
	public const Transform ClippingPlaneTransformDefault = null;

	[Token(Token = "0x40078A4")]
	public static readonly LayerMask DynOcclusionLayerMaskDefault;

	[Token(Token = "0x40078A5")]
	public const float DynOcclusionFadeDistanceToSurfaceDefault = 0.25f;

	[Token(Token = "0x40078A6")]
	public const DynamicOcclusionUpdateRate DynamicOcclusionUpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames;

	[Token(Token = "0x40078A7")]
	public const int DynOcclusionWaitFramesCountDefault = 3;

	[Token(Token = "0x40078A8")]
	public const Dimensions DynOcclusionRaycastingDimensionsDefault = Dimensions.Dim3D;

	[Token(Token = "0x40078A9")]
	public const bool DynOcclusionRaycastingConsiderTriggersDefault = false;

	[Token(Token = "0x40078AA")]
	public const float DynOcclusionRaycastingMinOccluderAreaDefault = 0f;

	[Token(Token = "0x40078AB")]
	public const float DynOcclusionRaycastingMinSurfaceRatioDefault = 0.5f;

	[Token(Token = "0x40078AC")]
	public const float DynOcclusionRaycastingMinSurfaceRatioMin = 50f;

	[Token(Token = "0x40078AD")]
	public const float DynOcclusionRaycastingMinSurfaceRatioMax = 100f;

	[Token(Token = "0x40078AE")]
	public const float DynOcclusionRaycastingMaxSurfaceDotDefault = 0.25f;

	[Token(Token = "0x40078AF")]
	public const float DynOcclusionRaycastingMaxSurfaceAngleMin = 45f;

	[Token(Token = "0x40078B0")]
	public const float DynOcclusionRaycastingMaxSurfaceAngleMax = 90f;

	[Token(Token = "0x40078B1")]
	public const PlaneAlignment DynOcclusionRaycastingPlaneAlignmentDefault = PlaneAlignment.Surface;

	[Token(Token = "0x40078B2")]
	public const float DynOcclusionRaycastingPlaneOffsetDefault = 0.1f;

	[Token(Token = "0x40078B3")]
	public const int DynOcclusionDepthBufferDepthMapResolutionDefault = 32;

	[Token(Token = "0x40078B4")]
	public const bool DynOcclusionDepthBufferOcclusionCullingDefault = true;

	[Token(Token = "0x40078B5")]
	public const bool ConfigGeometryOverrideLayerDefault = true;

	[Token(Token = "0x40078B6")]
	public const int ConfigGeometryLayerIDDefault = 1;

	[Token(Token = "0x40078B7")]
	public const string ConfigGeometryTagDefault = "Untagged";

	[Token(Token = "0x40078B8")]
	public const string ConfigFadeOutCameraTagDefault = "MainCamera";

	[Token(Token = "0x40078B9")]
	public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

	[Token(Token = "0x40078BA")]
	public const RenderPipeline ConfigGeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

	[Token(Token = "0x40078BB")]
	public const RenderingMode ConfigGeometryRenderingModeDefault = RenderingMode.SinglePass;

	[Token(Token = "0x40078BC")]
	public const int ConfigNoise3DSizeDefault = 64;

	[Token(Token = "0x40078BD")]
	public const int ConfigSharedMeshSides = 24;

	[Token(Token = "0x40078BE")]
	public const int ConfigSharedMeshSegments = 5;

	[Token(Token = "0x40078BF")]
	public const float ConfigDitheringFactor = 0f;

	[Token(Token = "0x40078C0")]
	public const bool ConfigFeatureEnabledDefault = true;

	[Token(Token = "0x40078C1")]
	public const FeatureEnabledColorGradient ConfigFeatureEnabledColorGradientDefault = FeatureEnabledColorGradient.HighOnly;

	[Token(Token = "0x170003D1")]
	public static HideFlags ProceduralObjectsHideFlags
	{
		[Token(Token = "0x6005D3E")]
		[Address(RVA = "0xF609C0", Offset = "0xF5F7C0", Length = "0x5A")]
		get
		{
			return default(HideFlags);
		}
	}
}

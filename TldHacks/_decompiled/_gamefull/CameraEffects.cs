using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityStandardAssets.ImageEffects;

[Token(Token = "0x2000368")]
public class CameraEffects : MonoBehaviour
{
	[Token(Token = "0x2000369")]
	public enum GameColorScalar
	{
		[Token(Token = "0x4001E30")]
		LowHealthEffect,
		[Token(Token = "0x4001E31")]
		RopeFall,
		[Token(Token = "0x4001E32")]
		Max
	}

	[Token(Token = "0x200036A")]
	public enum SSAOMode
	{
		[Token(Token = "0x4001E34")]
		ExteriorLowQuality,
		[Token(Token = "0x4001E35")]
		Exterior,
		[Token(Token = "0x4001E36")]
		ExteriorHighQuality,
		[Token(Token = "0x4001E37")]
		ExteriorUltraQuality,
		[Token(Token = "0x4001E38")]
		InteriorLowQuality,
		[Token(Token = "0x4001E39")]
		Interior,
		[Token(Token = "0x4001E3A")]
		InteriorHighQuality,
		[Token(Token = "0x4001E3B")]
		InteriorUltraQuality,
		[Token(Token = "0x4001E3C")]
		Off
	}

	[Token(Token = "0x200036B")]
	public enum ImageFilterType
	{
		[Token(Token = "0x4001E3E")]
		None,
		[Token(Token = "0x4001E3F")]
		Heritage,
		[Token(Token = "0x4001E40")]
		Noir
	}

	[Serializable]
	[Token(Token = "0x200036C")]
	public class SSAOParams
	{
		[Token(Token = "0x4001E41")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4001E42")]
		[FieldOffset(Offset = "0x18")]
		public float m_Radius;

		[Token(Token = "0x4001E43")]
		[FieldOffset(Offset = "0x1C")]
		public float m_Intensity;

		[Token(Token = "0x4001E44")]
		[FieldOffset(Offset = "0x20")]
		public float m_WeaponRadius;

		[Token(Token = "0x4001E45")]
		[FieldOffset(Offset = "0x24")]
		public float m_WeaponIntensity;

		[Token(Token = "0x4001E46")]
		[FieldOffset(Offset = "0x28")]
		public float m_MSVOThickness;

		[Token(Token = "0x4001E47")]
		[FieldOffset(Offset = "0x2C")]
		public float m_MSVOZBias;

		[Token(Token = "0x6001BD3")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SSAOParams()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200036D")]
	public class BloomOverride
	{
		[NonSerialized]
		[Token(Token = "0x4001E48")]
		[FieldOffset(Offset = "0x10")]
		public float m_BlendStrength;

		[Token(Token = "0x4001E49")]
		[FieldOffset(Offset = "0x14")]
		public bool m_OverrideIntensity;

		[Token(Token = "0x4001E4A")]
		[FieldOffset(Offset = "0x15")]
		public bool m_OverrideThreshold;

		[Token(Token = "0x4001E4B")]
		[FieldOffset(Offset = "0x16")]
		public bool m_OverrideSoftKnee;

		[Token(Token = "0x4001E4C")]
		[FieldOffset(Offset = "0x17")]
		public bool m_OverrideDiffusion;

		[Token(Token = "0x4001E4D")]
		[FieldOffset(Offset = "0x18")]
		public float m_Intensity;

		[Token(Token = "0x4001E4E")]
		[FieldOffset(Offset = "0x1C")]
		public float m_Threshold;

		[Token(Token = "0x4001E4F")]
		[FieldOffset(Offset = "0x20")]
		public float m_SoftKnee;

		[Token(Token = "0x4001E50")]
		[FieldOffset(Offset = "0x24")]
		public float m_Diffusion;

		[Token(Token = "0x4001E51")]
		[FieldOffset(Offset = "0x28")]
		public Texture2D m_LensDirtTexture;

		[Token(Token = "0x6001BD4")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public BloomOverride()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x4001DFB")]
	[FieldOffset(Offset = "0x20")]
	private PostProcessLayer m_ImageEffectsPostProcessLayer;

	[Header("SSAO")]
	[Token(Token = "0x4001DFC")]
	[FieldOffset(Offset = "0x28")]
	public SSAOParams[] m_SSAO_Configurations;

	[Header("Contrast")]
	[Token(Token = "0x4001DFD")]
	[FieldOffset(Offset = "0x30")]
	public float m_InteriorContrastEnhanceIntensity;

	[Header("Vignette")]
	[Token(Token = "0x4001DFE")]
	[FieldOffset(Offset = "0x34")]
	public float m_IndoorVignetteIntensity;

	[Header("Chromatic Aberration")]
	[Token(Token = "0x4001DFF")]
	[FieldOffset(Offset = "0x38")]
	public float m_IndoorChromaticAberration;

	[Header("Masked Blur")]
	[Token(Token = "0x4001E00")]
	[FieldOffset(Offset = "0x3C")]
	public float m_DefaultMatteBlend;

	[Header("Post Process Volumes")]
	[Token(Token = "0x4001E01")]
	[FieldOffset(Offset = "0x40")]
	public PostProcessVolume m_FPSCameraPostProcessVolume;

	[Token(Token = "0x4001E02")]
	[FieldOffset(Offset = "0x48")]
	public PostProcessVolume m_EffectCameraPostProcessVolume;

	[Token(Token = "0x4001E03")]
	[FieldOffset(Offset = "0x50")]
	public PostProcessVolume m_WeaponCameraPostProcessVolume;

	[Token(Token = "0x4001E04")]
	[FieldOffset(Offset = "0x58")]
	public PostProcessVolume m_AuxPostProcessVolume;

	[Token(Token = "0x4001E05")]
	[FieldOffset(Offset = "0x60")]
	public PostProcessVolume m_RespiratorPostProcessVolume;

	[Token(Token = "0x4001E06")]
	[FieldOffset(Offset = "0x68")]
	public PostProcessVolume m_GunAimingPostProcessVolume;

	[Header("Image Filter profiles")]
	[Token(Token = "0x4001E07")]
	[FieldOffset(Offset = "0x70")]
	public PostProcessProfile m_HeritagePostProcessProfile;

	[Token(Token = "0x4001E08")]
	[FieldOffset(Offset = "0x78")]
	public PostProcessProfile m_NoirPostProcessProfile;

	[Header("Noir filter")]
	[Token(Token = "0x4001E09")]
	[FieldOffset(Offset = "0x80")]
	public Color m_MeshPlacementValidColour;

	[Token(Token = "0x4001E0A")]
	[FieldOffset(Offset = "0x90")]
	public Color m_MeshPlacementInvalidColour;

	[HideInInspector]
	[Token(Token = "0x4001E0B")]
	[FieldOffset(Offset = "0xA0")]
	public UnityEngine.Rendering.PostProcessing.Bloom m_Bloom;

	[HideInInspector]
	[Token(Token = "0x4001E0C")]
	[FieldOffset(Offset = "0xA8")]
	public float m_ColorScalar;

	[HideInInspector]
	[Token(Token = "0x4001E0D")]
	[FieldOffset(Offset = "0xAC")]
	public float m_CurrentSaturationUnscaled;

	[HideInInspector]
	[Token(Token = "0x4001E0E")]
	[FieldOffset(Offset = "0xB0")]
	public float m_CurrentContrastEnhanceIntensityUnscaled;

	[HideInInspector]
	[Token(Token = "0x4001E0F")]
	[FieldOffset(Offset = "0xB4")]
	public float m_SSAO_IntensityScalar;

	[Token(Token = "0x4001E10")]
	public static ImageFilterType s_SessionFilter;

	[Token(Token = "0x4001E11")]
	public static bool s_DisableSuffocationEffect;

	[Token(Token = "0x4001E12")]
	[FieldOffset(Offset = "0xB8")]
	private int m_SSAO_QualityOffset;

	[Token(Token = "0x4001E13")]
	[FieldOffset(Offset = "0xBC")]
	private int m_SSAO_QualityOffsetDefault;

	[Token(Token = "0x4001E14")]
	[FieldOffset(Offset = "0xC0")]
	private SSAOParams m_CurrentSettings;

	[Token(Token = "0x4001E15")]
	[FieldOffset(Offset = "0xC8")]
	private SSAOMode m_CurrentMode;

	[Token(Token = "0x4001E16")]
	[FieldOffset(Offset = "0xCC")]
	private ImageFilterType m_ActiveFilter;

	[Token(Token = "0x4001E17")]
	[FieldOffset(Offset = "0xD0")]
	private CameraStatusEffects m_CameraStatusEffects;

	[Token(Token = "0x4001E18")]
	[FieldOffset(Offset = "0xD8")]
	private UnsharpMask m_UnsharpMask;

	[Token(Token = "0x4001E19")]
	[FieldOffset(Offset = "0xE0")]
	private BlurOptimized m_Blur;

	[Token(Token = "0x4001E1A")]
	[FieldOffset(Offset = "0xE8")]
	private Vignette m_Vignette;

	[Token(Token = "0x4001E1B")]
	[FieldOffset(Offset = "0xF0")]
	private ChromaticAberration m_ChromaticAberration;

	[HideInInspector]
	[Token(Token = "0x4001E1C")]
	[FieldOffset(Offset = "0xF8")]
	public UnityEngine.Rendering.PostProcessing.DepthOfField m_DepthOfField;

	[Token(Token = "0x4001E1D")]
	[FieldOffset(Offset = "0x100")]
	private AmbientOcclusion m_AmbientOcclusionWorldCam;

	[Token(Token = "0x4001E1E")]
	[FieldOffset(Offset = "0x108")]
	private AmbientOcclusion m_AmbientOcclusionWeaponCam;

	[Token(Token = "0x4001E1F")]
	[FieldOffset(Offset = "0x110")]
	private AmbientOcclusion m_AmbientOcclusionEffectsCam;

	[Token(Token = "0x4001E20")]
	[FieldOffset(Offset = "0x118")]
	private UnityEngine.Rendering.PostProcessing.ColorGrading m_NewColorGrading;

	[Token(Token = "0x4001E21")]
	[FieldOffset(Offset = "0x120")]
	private MaskedBlurEffect m_MaskedBlur;

	[Token(Token = "0x4001E22")]
	[FieldOffset(Offset = "0x128")]
	private SuffocationScreenEffect m_SuffocationScreenEffect;

	[Token(Token = "0x4001E23")]
	[FieldOffset(Offset = "0x130")]
	private GradientFadeEffect m_GradientFadeEffect;

	[Token(Token = "0x4001E24")]
	[FieldOffset(Offset = "0x138")]
	private ChemicalPoisoningScreenEffect m_ChemicalPoisoningScreenEffect;

	[Token(Token = "0x4001E25")]
	[FieldOffset(Offset = "0x140")]
	private bool m_DOFTurnedOnThisFrame;

	[Token(Token = "0x4001E26")]
	[FieldOffset(Offset = "0x141")]
	private bool m_DOFWaterOverridden;

	[Token(Token = "0x4001E27")]
	[FieldOffset(Offset = "0x148")]
	private float[] m_ColorScalars;

	[Token(Token = "0x4001E28")]
	[FieldOffset(Offset = "0x150")]
	private List<BloomOverride> m_BloomOverrides;

	[Token(Token = "0x4001E29")]
	[FieldOffset(Offset = "0x158")]
	private GradientFadeEffect m_GradientFadeOverrideSettings;

	[Token(Token = "0x4001E2A")]
	[FieldOffset(Offset = "0x160")]
	private float m_GradientFadeIntensity;

	[Token(Token = "0x4001E2B")]
	[FieldOffset(Offset = "0x164")]
	private float m_GradientFadePosition;

	[Token(Token = "0x4001E2C")]
	[FieldOffset(Offset = "0x168")]
	private float m_GradientFadeDirection;

	[Token(Token = "0x4001E2D")]
	[FieldOffset(Offset = "0x16C")]
	private float m_ChemicalPoisoningEffectIntensity;

	[Token(Token = "0x4001E2E")]
	[FieldOffset(Offset = "0x170")]
	private bool m_HasInitializedImageFilter;

	[Token(Token = "0x6001B9F")]
	[Address(RVA = "0x765BC0", Offset = "0x7649C0", Length = "0x724")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001BA0")]
	[Address(RVA = "0x7662F0", Offset = "0x7650F0", Length = "0x2B8")]
	public void Start()
	{
	}

	[Token(Token = "0x6001BA1")]
	[Address(RVA = "0x7665B0", Offset = "0x7653B0", Length = "0x372")]
	public void Update()
	{
	}

	[Token(Token = "0x6001BA2")]
	[Address(RVA = "0x766930", Offset = "0x765730", Length = "0x125")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001BA3")]
	[Address(RVA = "0x766A60", Offset = "0x765860", Length = "0x30")]
	public void SetColorScalar(GameColorScalar source, float scalar)
	{
	}

	[Token(Token = "0x6001BA4")]
	[Address(RVA = "0x766AA0", Offset = "0x7658A0", Length = "0x26D")]
	public void ConfigureContrastEnhance(float intensity)
	{
	}

	[Token(Token = "0x6001BA5")]
	[Address(RVA = "0x766D10", Offset = "0x765B10", Length = "0xCA")]
	public void DepthOfFieldTurnOn(float focalPoint)
	{
	}

	[Token(Token = "0x6001BA6")]
	[Address(RVA = "0x766DE0", Offset = "0x765BE0", Length = "0x10")]
	public void DepthOfFieldTurnOn()
	{
	}

	[Token(Token = "0x6001BA7")]
	[Address(RVA = "0x766DF0", Offset = "0x765BF0", Length = "0x7F")]
	public void DepthOfFieldTurnOff(bool forceOff = false)
	{
	}

	[Token(Token = "0x6001BA8")]
	[Address(RVA = "0x766E70", Offset = "0x765C70", Length = "0x1E")]
	public bool IsDepthOfFieldEnabled()
	{
		return false;
	}

	[Token(Token = "0x6001BA9")]
	[Address(RVA = "0x766E90", Offset = "0x765C90", Length = "0x23F")]
	public void BlurSetSize(float blurSize)
	{
	}

	[Token(Token = "0x6001BAA")]
	[Address(RVA = "0x7670D0", Offset = "0x765ED0", Length = "0xF7")]
	public void BlurTurnOff()
	{
	}

	[Token(Token = "0x6001BAB")]
	[Address(RVA = "0x7671D0", Offset = "0x765FD0", Length = "0x70")]
	public void BloomEnable(bool enable)
	{
	}

	[Token(Token = "0x6001BAC")]
	[Address(RVA = "0x767250", Offset = "0x766050", Length = "0x1E")]
	public bool GetContrastEnhanceEnabled()
	{
		return false;
	}

	[Token(Token = "0x6001BAD")]
	[Address(RVA = "0x767270", Offset = "0x766070", Length = "0x70")]
	public void ContrastEnhanceEnable(bool enable)
	{
	}

	[Token(Token = "0x6001BAE")]
	[Address(RVA = "0x7672F0", Offset = "0x7660F0", Length = "0x64")]
	public void VignettingEnable(bool enable)
	{
	}

	[Token(Token = "0x6001BAF")]
	[Address(RVA = "0x767360", Offset = "0x766160", Length = "0x56")]
	public void PainPulse(float amount)
	{
	}

	[Token(Token = "0x6001BB0")]
	[Address(RVA = "0x7673C0", Offset = "0x7661C0", Length = "0x56")]
	public void StimPulse(float amount)
	{
	}

	[Token(Token = "0x6001BB1")]
	[Address(RVA = "0x767420", Offset = "0x766220", Length = "0x56")]
	public void BoostEffectPulse(float amount)
	{
	}

	[Token(Token = "0x6001BB2")]
	[Address(RVA = "0x767480", Offset = "0x766280", Length = "0x4B")]
	public void HeadachePulse(float amount)
	{
	}

	[Token(Token = "0x6001BB3")]
	[Address(RVA = "0x7674D0", Offset = "0x7662D0", Length = "0x4B")]
	public void SuffocationPulse(float amount)
	{
	}

	[Token(Token = "0x6001BB4")]
	[Address(RVA = "0x767520", Offset = "0x766320", Length = "0x4B")]
	public void ElectrocutionPulse(float amount)
	{
	}

	[Token(Token = "0x6001BB5")]
	[Address(RVA = "0x767570", Offset = "0x766370", Length = "0x4B")]
	public void WaterPulse(float amount)
	{
	}

	[Token(Token = "0x6001BB6")]
	[Address(RVA = "0x7675C0", Offset = "0x7663C0", Length = "0x4B")]
	public void SprainPulse(float amount)
	{
	}

	[Token(Token = "0x6001BB7")]
	[Address(RVA = "0x502630", Offset = "0x501430", Length = "0x8")]
	public Vignette Vignette()
	{
		return null;
	}

	[Token(Token = "0x6001BB8")]
	[Address(RVA = "0x694DC0", Offset = "0x693BC0", Length = "0x8")]
	public ChromaticAberration ChromaticAberration()
	{
		return null;
	}

	[Token(Token = "0x6001BB9")]
	[Address(RVA = "0x699260", Offset = "0x698060", Length = "0x8")]
	public UnityEngine.Rendering.PostProcessing.ColorGrading ColorGrading()
	{
		return null;
	}

	[Token(Token = "0x6001BBA")]
	[Address(RVA = "0x767610", Offset = "0x766410", Length = "0xAF")]
	public void Configure()
	{
	}

	[Token(Token = "0x6001BBB")]
	[Address(RVA = "0x7676C0", Offset = "0x7664C0", Length = "0x42")]
	public void ConfigureForInterior()
	{
	}

	[Token(Token = "0x6001BBC")]
	[Address(RVA = "0x767710", Offset = "0x766510", Length = "0x22")]
	public void ConfigureForExterior()
	{
	}

	[Token(Token = "0x6001BBD")]
	[Address(RVA = "0x767740", Offset = "0x766540", Length = "0xD")]
	public void SetSSAOQualityOffset(int offset)
	{
	}

	[Token(Token = "0x6001BBE")]
	[Address(RVA = "0x767750", Offset = "0x766550", Length = "0x31")]
	public void DisableSSAO()
	{
	}

	[Token(Token = "0x6001BBF")]
	[Address(RVA = "0x767790", Offset = "0x766590", Length = "0xC")]
	public bool IsSSAOEnabled()
	{
		return false;
	}

	[Token(Token = "0x6001BC0")]
	[Address(RVA = "0x7677A0", Offset = "0x7665A0", Length = "0x3E")]
	public void EnableSSAO()
	{
	}

	[Token(Token = "0x6001BC1")]
	[Address(RVA = "0x7677E0", Offset = "0x7665E0", Length = "0x1C")]
	public void RefreshSSAOSettings()
	{
	}

	[Token(Token = "0x6001BC2")]
	[Address(RVA = "0x767800", Offset = "0x766600", Length = "0xC5")]
	public void AddBloomOverride(BloomOverride bloomOverride)
	{
	}

	[Token(Token = "0x6001BC3")]
	[Address(RVA = "0x7678D0", Offset = "0x7666D0", Length = "0x85")]
	public void RemoveBloomOverride(BloomOverride bloomOverride)
	{
	}

	[Token(Token = "0x6001BC4")]
	[Address(RVA = "0x767960", Offset = "0x766760", Length = "0x189A")]
	private void UpdateEffectParameters()
	{
	}

	[Token(Token = "0x6001BC5")]
	[Address(RVA = "0x769200", Offset = "0x768000", Length = "0x272")]
	public void AdaptSSAOByViewAngle()
	{
	}

	[Token(Token = "0x6001BC6")]
	[Address(RVA = "0x769480", Offset = "0x768280", Length = "0x23B")]
	public void ConfigureSSAO(SSAOMode mode)
	{
	}

	[Token(Token = "0x6001BC7")]
	[Address(RVA = "0x7696C0", Offset = "0x7684C0", Length = "0x7")]
	public SSAOMode GetCurrentSSAOMode()
	{
		return default(SSAOMode);
	}

	[Token(Token = "0x6001BC8")]
	[Address(RVA = "0x7696D0", Offset = "0x7684D0", Length = "0x45")]
	public static bool IsMSVOSupported()
	{
		return false;
	}

	[Token(Token = "0x6001BC9")]
	[Address(RVA = "0x769720", Offset = "0x768520", Length = "0x255")]
	private void UpdateAOEffectSettings(AmbientOcclusion ao, bool isActive, AmbientOcclusionQuality quality, bool useWeaponSettings)
	{
	}

	[Token(Token = "0x6001BCA")]
	[Address(RVA = "0x769980", Offset = "0x768780", Length = "0x12D")]
	private void EnableCameraWeaponPostEffects(bool isEnabled)
	{
	}

	[Token(Token = "0x6001BCB")]
	[Address(RVA = "0x769AB0", Offset = "0x7688B0", Length = "0x55")]
	public void SwitchImageFilter(ImageFilterType filter)
	{
	}

	[Token(Token = "0x6001BCC")]
	[Address(RVA = "0x769B10", Offset = "0x768910", Length = "0x82")]
	public void ForceRefreshImageFilter()
	{
	}

	[Token(Token = "0x6001BCD")]
	[Address(RVA = "0x769BA0", Offset = "0x7689A0", Length = "0x484")]
	private void RefreshActiveImageFilter()
	{
	}

	[Token(Token = "0x6001BCE")]
	[Address(RVA = "0x76A030", Offset = "0x768E30", Length = "0xD1")]
	private ImageFilterType GetActiveImageFilterType()
	{
		return default(ImageFilterType);
	}

	[Token(Token = "0x6001BCF")]
	[Address(RVA = "0x76A110", Offset = "0x768F10", Length = "0xCA")]
	public void SetGradientFadeOverride(GradientFadeEffect settings, float intensity, float position, float direction)
	{
	}

	[Token(Token = "0x6001BD0")]
	[Address(RVA = "0x76A1E0", Offset = "0x768FE0", Length = "0x154")]
	private void UpdateChemicalPoisoningEffectIntensity()
	{
	}

	[Token(Token = "0x6001BD1")]
	[Address(RVA = "0x76A340", Offset = "0x769140", Length = "0x168")]
	public void SetGunAimingPostProcessingProfile(PostProcessProfile profile)
	{
	}

	[Token(Token = "0x6001BD2")]
	[Address(RVA = "0x76A4B0", Offset = "0x7692B0", Length = "0x114")]
	public CameraEffects()
	{
	}
}

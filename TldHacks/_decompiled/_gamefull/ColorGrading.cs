using System;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

[Token(Token = "0x200037A")]
public class ColorGrading : PostEffectsBase
{
	[Serializable]
	[Token(Token = "0x200037B")]
	public class PosBlendInfo
	{
		[Token(Token = "0x4001F03")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 m_Position;

		[Token(Token = "0x4001F04")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 m_EdgeFadePower;

		[Token(Token = "0x4001F05")]
		[FieldOffset(Offset = "0x24")]
		public bool m_IsCamSpace;

		[Range(0f, 100f)]
		[Token(Token = "0x4001F06")]
		[FieldOffset(Offset = "0x28")]
		public float m_NoiseStepSpeed;

		[Token(Token = "0x4001F07")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D m_EdgeEffectLut;

		[Token(Token = "0x4001F08")]
		[FieldOffset(Offset = "0x38")]
		public Texture2D m_ScreenTintLut;

		[Token(Token = "0x4001F09")]
		[FieldOffset(Offset = "0x40")]
		public float m_EdgeIntensity;

		[Token(Token = "0x4001F0A")]
		[FieldOffset(Offset = "0x44")]
		public float m_TintIntensity;

		[HideInInspector]
		[Token(Token = "0x4001F0B")]
		[FieldOffset(Offset = "0x48")]
		public float m_TintIntensityTarget;

		[Token(Token = "0x6001C19")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public PosBlendInfo()
		{
		}
	}

	[Token(Token = "0x200037C")]
	private enum ScreenTintClient
	{
		[Token(Token = "0x4001F0D")]
		None,
		[Token(Token = "0x4001F0E")]
		Pain,
		[Token(Token = "0x4001F0F")]
		Warm,
		[Token(Token = "0x4001F10")]
		Freeze,
		[Token(Token = "0x4001F11")]
		Aux
	}

	[Token(Token = "0x200037D")]
	private enum LutShaderPass
	{
		[Token(Token = "0x4001F13")]
		TODBlend,
		[Token(Token = "0x4001F14")]
		TODBlendCheap,
		[Token(Token = "0x4001F15")]
		ApplyAdjustments,
		[Token(Token = "0x4001F16")]
		SimpleBlend
	}

	[Token(Token = "0x200037E")]
	private enum GradingShaderPass
	{
		[Token(Token = "0x4001F18")]
		StandardColorGrade,
		[Token(Token = "0x4001F19")]
		GradeWithPosBlend1,
		[Token(Token = "0x4001F1A")]
		GradeWithPosBlend2
	}

	[SerializeField]
	[Token(Token = "0x4001EC4")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[Token(Token = "0x4001EC5")]
	[FieldOffset(Offset = "0x30")]
	public Shader m_ImageShader;

	[Token(Token = "0x4001EC6")]
	[FieldOffset(Offset = "0x38")]
	public Material m_LutBlendMaterial;

	[Token(Token = "0x4001EC7")]
	[FieldOffset(Offset = "0x40")]
	public Texture2D m_DefaultLUT;

	[Token(Token = "0x4001EC8")]
	[FieldOffset(Offset = "0x48")]
	public Texture2D m_PainEffectLUT;

	[Token(Token = "0x4001EC9")]
	[FieldOffset(Offset = "0x50")]
	public Texture2D m_NoiseTexture;

	[Token(Token = "0x4001ECA")]
	[FieldOffset(Offset = "0x58")]
	public Vector4 m_NoiseParams;

	[Token(Token = "0x4001ECB")]
	[FieldOffset(Offset = "0x68")]
	public bool m_NoiseRandomize;

	[Range(0.5f, 2f)]
	[Token(Token = "0x4001ECC")]
	[FieldOffset(Offset = "0x6C")]
	public float m_HdrScalar;

	[Range(0f, 1f)]
	[Token(Token = "0x4001ECD")]
	[FieldOffset(Offset = "0x70")]
	public float m_Saturation;

	[Range(0f, 1f)]
	[Token(Token = "0x4001ECE")]
	[FieldOffset(Offset = "0x74")]
	public float m_Gamma;

	[Range(-1f, 1f)]
	[Token(Token = "0x4001ECF")]
	[FieldOffset(Offset = "0x78")]
	public float m_Contrast;

	[Token(Token = "0x4001ED0")]
	[FieldOffset(Offset = "0x7C")]
	public bool m_DebugColorScalar;

	[Token(Token = "0x4001ED1")]
	[FieldOffset(Offset = "0x80")]
	public float m_ColorScalar;

	[Token(Token = "0x4001ED2")]
	[FieldOffset(Offset = "0x88")]
	public Texture2D m_AuxiliaryLUT;

	[Range(0f, 1f)]
	[Token(Token = "0x4001ED3")]
	[FieldOffset(Offset = "0x90")]
	public float m_AuxiliaryBlend;

	[Token(Token = "0x4001ED4")]
	[FieldOffset(Offset = "0x94")]
	public bool m_ShowWarmingEffect;

	[Token(Token = "0x4001ED5")]
	[FieldOffset(Offset = "0x95")]
	public bool m_DebugFreezing;

	[Token(Token = "0x4001ED6")]
	[FieldOffset(Offset = "0x96")]
	public bool m_DebugWarming;

	[Token(Token = "0x4001ED7")]
	[FieldOffset(Offset = "0x98")]
	public PosBlendInfo m_FreezingEffect;

	[Token(Token = "0x4001ED8")]
	[FieldOffset(Offset = "0xA0")]
	public PosBlendInfo m_WarmingEffect;

	[Tooltip("Number of temp drop arrows that must be visible for the freeze edge effect to show.")]
	[Token(Token = "0x4001ED9")]
	[FieldOffset(Offset = "0xA8")]
	public float m_ShowFreezingEdgeArrowCount;

	[Token(Token = "0x4001EDA")]
	[FieldOffset(Offset = "0xAC")]
	public float m_ShowFreezingTintArrowCount;

	[Range(0f, 100f)]
	[Token(Token = "0x4001EDB")]
	[FieldOffset(Offset = "0xB0")]
	public float m_FreezingTintColdStart;

	[Range(0f, 100f)]
	[Token(Token = "0x4001EDC")]
	[FieldOffset(Offset = "0xB4")]
	public float m_FreezingTintColdMax;

	[Token(Token = "0x4001EDD")]
	[FieldOffset(Offset = "0xB8")]
	public float m_GammaLimitLow;

	[Token(Token = "0x4001EDE")]
	[FieldOffset(Offset = "0xBC")]
	public float m_GammaLimitHigh;

	[HideInInspector]
	[Token(Token = "0x4001EDF")]
	[FieldOffset(Offset = "0xC0")]
	public float m_PainEffectIntensity;

	[HideInInspector]
	[Token(Token = "0x4001EE0")]
	[FieldOffset(Offset = "0xC4")]
	public float m_PainEffectIntensityTarget;

	[Token(Token = "0x4001EE1")]
	[FieldOffset(Offset = "0xC8")]
	private Material m_ImageEffectMaterial;

	[Token(Token = "0x4001EE2")]
	[FieldOffset(Offset = "0xD0")]
	private Material m_CustomLUTBlendMaterial;

	[Token(Token = "0x4001EE3")]
	[FieldOffset(Offset = "0xD8")]
	private int m_Tex1AId;

	[Token(Token = "0x4001EE4")]
	[FieldOffset(Offset = "0xDC")]
	private int m_Tex1BId;

	[Token(Token = "0x4001EE5")]
	[FieldOffset(Offset = "0xE0")]
	private int m_Tex2AId;

	[Token(Token = "0x4001EE6")]
	[FieldOffset(Offset = "0xE4")]
	private int m_Tex2BId;

	[Token(Token = "0x4001EE7")]
	[FieldOffset(Offset = "0xE8")]
	private int m_TexAuxId;

	[Token(Token = "0x4001EE8")]
	[FieldOffset(Offset = "0xEC")]
	private int m_TexExtraId;

	[Token(Token = "0x4001EE9")]
	[FieldOffset(Offset = "0xF0")]
	private int m_BlendAmountsId;

	[Token(Token = "0x4001EEA")]
	[FieldOffset(Offset = "0xF4")]
	private int m_AdjustmentsId;

	[Token(Token = "0x4001EEB")]
	[FieldOffset(Offset = "0xF8")]
	private int m_LUTTexId;

	[Token(Token = "0x4001EEC")]
	[FieldOffset(Offset = "0xFC")]
	private int m_NoiseTexId;

	[Token(Token = "0x4001EED")]
	[FieldOffset(Offset = "0x100")]
	private int m_NoiseParamsId;

	[Token(Token = "0x4001EEE")]
	[FieldOffset(Offset = "0x104")]
	private int m_HDRScalarId;

	[Token(Token = "0x4001EEF")]
	[FieldOffset(Offset = "0x108")]
	private int[] m_LUTPosBlendIds;

	[Token(Token = "0x4001EF0")]
	[FieldOffset(Offset = "0x110")]
	private int[] m_PosBlendPosIds;

	[Token(Token = "0x4001EF1")]
	[FieldOffset(Offset = "0x118")]
	private int[] m_PosBlendInfoIds;

	[Token(Token = "0x4001EF2")]
	[FieldOffset(Offset = "0x120")]
	private Vector4 m_BlendRecord;

	[Token(Token = "0x4001EF3")]
	[FieldOffset(Offset = "0x130")]
	private Vector4 m_AdjustmentRecord;

	[Token(Token = "0x4001EF4")]
	[FieldOffset(Offset = "0x140")]
	private Vector2 m_WarmingNoise;

	[Token(Token = "0x4001EF5")]
	[FieldOffset(Offset = "0x148")]
	private Vector2 m_WarmingNoiseStep;

	[Token(Token = "0x4001EF6")]
	[FieldOffset(Offset = "0x150")]
	private Vector2 m_FreezingNoise;

	[Token(Token = "0x4001EF7")]
	[FieldOffset(Offset = "0x158")]
	private Vector2 m_FreezingNoiseStep;

	[Token(Token = "0x4001EF8")]
	[FieldOffset(Offset = "0x160")]
	private LutShaderPass m_LUTBlendMainShaderPass;

	[Token(Token = "0x4001EF9")]
	[FieldOffset(Offset = "0x168")]
	private Texture2D m_Lut1A;

	[Token(Token = "0x4001EFA")]
	[FieldOffset(Offset = "0x170")]
	private Texture2D m_Lut1B;

	[Token(Token = "0x4001EFB")]
	[FieldOffset(Offset = "0x178")]
	private Texture2D m_Lut2A;

	[Token(Token = "0x4001EFC")]
	[FieldOffset(Offset = "0x180")]
	private Texture2D m_Lut2B;

	[Token(Token = "0x4001EFD")]
	[FieldOffset(Offset = "0x188")]
	private float m_BrightnessSetting;

	[Token(Token = "0x4001EFE")]
	[FieldOffset(Offset = "0x190")]
	private RenderTexture[] m_RenderTextures;

	[Token(Token = "0x4001EFF")]
	[FieldOffset(Offset = "0x198")]
	private ScreenTintClient m_ScreenTintLastClient;

	[Token(Token = "0x4001F00")]
	[FieldOffset(Offset = "0x19C")]
	private ScreenTintClient m_ScreenTintTransitionClient;

	[Token(Token = "0x4001F01")]
	[FieldOffset(Offset = "0x1A0")]
	private float m_ScreenTintTransitionTimer;

	[Token(Token = "0x4001F02")]
	[FieldOffset(Offset = "0x1A4")]
	private float m_ScreenTintTransitionDuration;

	[Token(Token = "0x6001C05")]
	[Address(RVA = "0x7708E0", Offset = "0x76F6E0", Length = "0x90")]
	public override bool CheckResources()
	{
		return false;
	}

	[Token(Token = "0x6001C06")]
	[Address(RVA = "0x770970", Offset = "0x76F770", Length = "0x6B6")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001C07")]
	[Address(RVA = "0x771030", Offset = "0x76FE30", Length = "0x2E0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001C08")]
	[Address(RVA = "0x771310", Offset = "0x770110", Length = "0x203")]
	public void Configure()
	{
	}

	[Token(Token = "0x6001C09")]
	[Address(RVA = "0x4A2290", Offset = "0x4A1090", Length = "0x9")]
	public float GetDefaultGamma()
	{
		return 0f;
	}

	[Token(Token = "0x6001C0A")]
	[Address(RVA = "0x771520", Offset = "0x770320", Length = "0x173")]
	public void ConfigureForInterior()
	{
	}

	[Token(Token = "0x6001C0B")]
	[Address(RVA = "0x7716A0", Offset = "0x7704A0", Length = "0x173")]
	public void ConfigureForExterior()
	{
	}

	[Token(Token = "0x6001C0C")]
	[Address(RVA = "0x771820", Offset = "0x770620", Length = "0x392")]
	public void UpdateLUTMaterialForTOD(Texture2D lut1A, Texture2D lut1B, Texture2D lut2A, Texture2D lut2B, float blend1, float blend2, float blendCombine)
	{
	}

	[Token(Token = "0x6001C0D")]
	[Address(RVA = "0x771BC0", Offset = "0x7709C0", Length = "0x101")]
	public void ConfigureLUTMaterialForInterior(Texture2D customLUT)
	{
	}

	[Token(Token = "0x6001C0E")]
	[Address(RVA = "0x771CD0", Offset = "0x770AD0", Length = "0x18C")]
	public void UpdateMaterialForAuxiliaryBlend(Texture2D lut, float blend)
	{
	}

	[Token(Token = "0x6001C0F")]
	[Address(RVA = "0x771E60", Offset = "0x770C60", Length = "0x379")]
	private void PrepareForPositionalBlend(PosBlendInfo pb, RenderTexture rt, int i, float noise, RenderTexture screen)
	{
	}

	[Token(Token = "0x6001C10")]
	[Address(RVA = "0x7721E0", Offset = "0x770FE0", Length = "0x13D")]
	private void Update()
	{
	}

	[Token(Token = "0x6001C11")]
	[Address(RVA = "0x772320", Offset = "0x771120", Length = "0xA29")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6001C12")]
	[Address(RVA = "0x772D50", Offset = "0x771B50", Length = "0x265")]
	private void GetLUTAndBlendForClient(ScreenTintClient client, out Texture2D lut, out float blend)
	{
		lut = null;
		blend = default(float);
	}

	[Token(Token = "0x6001C13")]
	[Address(RVA = "0x772FC0", Offset = "0x771DC0", Length = "0x5E0")]
	private RenderTexture HandleScreenTint(RenderTexture screen)
	{
		return null;
	}

	[Token(Token = "0x6001C14")]
	[Address(RVA = "0x7735B0", Offset = "0x7723B0", Length = "0x9")]
	public float GetBrightnessSetting()
	{
		return 0f;
	}

	[Token(Token = "0x6001C15")]
	[Address(RVA = "0x7735C0", Offset = "0x7723C0", Length = "0x9")]
	public void SetBrightnessSetting(float val)
	{
	}

	[Token(Token = "0x6001C16")]
	[Address(RVA = "0x7735D0", Offset = "0x7723D0", Length = "0x74")]
	private float GetModifiedGamma()
	{
		return 0f;
	}

	[Token(Token = "0x6001C17")]
	[Address(RVA = "0x773650", Offset = "0x772450", Length = "0x43B")]
	private void OnCopyFrom(ColorGrading src)
	{
	}

	[Token(Token = "0x6001C18")]
	[Address(RVA = "0x773A90", Offset = "0x772890", Length = "0x16C")]
	public ColorGrading()
	{
	}
}

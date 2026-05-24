using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(ColorGradingRenderer), "Unity/Color Grading", true)]
[Token(Token = "0x2000C94")]
public sealed class ColorGrading : PostProcessEffectSettings
{
	[DisplayName("Mode")]
	[Tooltip("Select a color grading mode that fits your dynamic range and workflow. Use HDR if your camera is set to render in HDR and your target platform supports it. Use LDR for low-end mobiles or devices that don't support HDR. Use External if you prefer authoring a Log LUT in an external software.")]
	[Token(Token = "0x4007E14")]
	[FieldOffset(Offset = "0x30")]
	public GradingModeParameter gradingMode;

	[DisplayName("Lookup Texture")]
	[Tooltip("A custom 3D log-encoded texture.")]
	[Token(Token = "0x4007E15")]
	[FieldOffset(Offset = "0x38")]
	public TextureParameter externalLut;

	[DisplayName("Mode")]
	[Tooltip("Select a tonemapping algorithm to use at the end of the color grading process.")]
	[Token(Token = "0x4007E16")]
	[FieldOffset(Offset = "0x40")]
	public TonemapperParameter tonemapper;

	[DisplayName("Toe Strength")]
	[Range(0f, 1f)]
	[Tooltip("Affects the transition between the toe and the mid section of the curve. A value of 0 means no toe, a value of 1 means a very hard transition.")]
	[Token(Token = "0x4007E17")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter toneCurveToeStrength;

	[DisplayName("Toe Length")]
	[Range(0f, 1f)]
	[Tooltip("Affects how much of the dynamic range is in the toe. With a small value, the toe will be very short and quickly transition into the linear section, with a larger value, the toe will be longer.")]
	[Token(Token = "0x4007E18")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter toneCurveToeLength;

	[DisplayName("Shoulder Strength")]
	[Range(0f, 1f)]
	[Tooltip("Affects the transition between the mid section and the shoulder of the curve. A value of 0 means no shoulder, a value of 1 means a very hard transition.")]
	[Token(Token = "0x4007E19")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter toneCurveShoulderStrength;

	[DisplayName("Shoulder Length")]
	[Min(0f)]
	[Tooltip("Affects how many F-stops (EV) to add to the dynamic range of the curve.")]
	[Token(Token = "0x4007E1A")]
	[FieldOffset(Offset = "0x60")]
	public FloatParameter toneCurveShoulderLength;

	[DisplayName("Shoulder Angle")]
	[Range(0f, 1f)]
	[Tooltip("Affects how much overshoot to add to the shoulder.")]
	[Token(Token = "0x4007E1B")]
	[FieldOffset(Offset = "0x68")]
	public FloatParameter toneCurveShoulderAngle;

	[DisplayName("Gamma")]
	[Min(0.001f)]
	[Tooltip("Applies a gamma function to the curve.")]
	[Token(Token = "0x4007E1C")]
	[FieldOffset(Offset = "0x70")]
	public FloatParameter toneCurveGamma;

	[DisplayName("Lookup Texture")]
	[Tooltip("Custom lookup texture (strip format, for example 256x16) to apply before the rest of the color grading operators. If none is provided, a neutral one will be generated internally.")]
	[Token(Token = "0x4007E1D")]
	[FieldOffset(Offset = "0x78")]
	public TextureParameter ldrLut;

	[DisplayName("Contribution")]
	[Range(0f, 1f)]
	[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
	[Token(Token = "0x4007E1E")]
	[FieldOffset(Offset = "0x80")]
	public FloatParameter ldrLutContribution;

	[DisplayName("Temperature")]
	[Range(-100f, 100f)]
	[Tooltip("Sets the white balance to a custom color temperature.")]
	[Token(Token = "0x4007E1F")]
	[FieldOffset(Offset = "0x88")]
	public FloatParameter temperature;

	[DisplayName("Tint")]
	[Range(-100f, 100f)]
	[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
	[Token(Token = "0x4007E20")]
	[FieldOffset(Offset = "0x90")]
	public FloatParameter tint;

	[DisplayName("Color Filter")]
	[ColorUsage(false, true)]
	[Tooltip("Tint the render by multiplying a color.")]
	[Token(Token = "0x4007E21")]
	[FieldOffset(Offset = "0x98")]
	public ColorParameter colorFilter;

	[DisplayName("Hue Shift")]
	[Range(-180f, 180f)]
	[Tooltip("Shift the hue of all colors.")]
	[Token(Token = "0x4007E22")]
	[FieldOffset(Offset = "0xA0")]
	public FloatParameter hueShift;

	[DisplayName("Saturation")]
	[Range(-100f, 100f)]
	[Tooltip("Pushes the intensity of all colors.")]
	[Token(Token = "0x4007E23")]
	[FieldOffset(Offset = "0xA8")]
	public FloatParameter saturation;

	[DisplayName("Brightness")]
	[Range(-100f, 100f)]
	[Tooltip("Makes the image brighter or darker.")]
	[Token(Token = "0x4007E24")]
	[FieldOffset(Offset = "0xB0")]
	public FloatParameter brightness;

	[DisplayName("Post-exposure (EV)")]
	[Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after the HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
	[Token(Token = "0x4007E25")]
	[FieldOffset(Offset = "0xB8")]
	public FloatParameter postExposure;

	[DisplayName("Contrast")]
	[Range(-100f, 100f)]
	[Tooltip("Expands or shrinks the overall range of tonal values.")]
	[Token(Token = "0x4007E26")]
	[FieldOffset(Offset = "0xC0")]
	public FloatParameter contrast;

	[DisplayName("Red")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	[Token(Token = "0x4007E27")]
	[FieldOffset(Offset = "0xC8")]
	public FloatParameter mixerRedOutRedIn;

	[DisplayName("Green")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	[Token(Token = "0x4007E28")]
	[FieldOffset(Offset = "0xD0")]
	public FloatParameter mixerRedOutGreenIn;

	[DisplayName("Blue")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	[Token(Token = "0x4007E29")]
	[FieldOffset(Offset = "0xD8")]
	public FloatParameter mixerRedOutBlueIn;

	[DisplayName("Red")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	[Token(Token = "0x4007E2A")]
	[FieldOffset(Offset = "0xE0")]
	public FloatParameter mixerGreenOutRedIn;

	[DisplayName("Green")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	[Token(Token = "0x4007E2B")]
	[FieldOffset(Offset = "0xE8")]
	public FloatParameter mixerGreenOutGreenIn;

	[DisplayName("Blue")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	[Token(Token = "0x4007E2C")]
	[FieldOffset(Offset = "0xF0")]
	public FloatParameter mixerGreenOutBlueIn;

	[DisplayName("Red")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	[Token(Token = "0x4007E2D")]
	[FieldOffset(Offset = "0xF8")]
	public FloatParameter mixerBlueOutRedIn;

	[DisplayName("Green")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	[Token(Token = "0x4007E2E")]
	[FieldOffset(Offset = "0x100")]
	public FloatParameter mixerBlueOutGreenIn;

	[DisplayName("Blue")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	[Token(Token = "0x4007E2F")]
	[FieldOffset(Offset = "0x108")]
	public FloatParameter mixerBlueOutBlueIn;

	[DisplayName("Lift")]
	[Tooltip("Controls the darkest portions of the render.")]
	[Trackball(TrackballAttribute.Mode.Lift)]
	[Token(Token = "0x4007E30")]
	[FieldOffset(Offset = "0x110")]
	public Vector4Parameter lift;

	[DisplayName("Gamma")]
	[Tooltip("Power function that controls mid-range tones.")]
	[Trackball(TrackballAttribute.Mode.Gamma)]
	[Token(Token = "0x4007E31")]
	[FieldOffset(Offset = "0x118")]
	public Vector4Parameter gamma;

	[DisplayName("Gain")]
	[Tooltip("Controls the lightest portions of the render.")]
	[Trackball(TrackballAttribute.Mode.Gain)]
	[Token(Token = "0x4007E32")]
	[FieldOffset(Offset = "0x120")]
	public Vector4Parameter gain;

	[Token(Token = "0x4007E33")]
	[FieldOffset(Offset = "0x128")]
	public SplineParameter masterCurve;

	[Token(Token = "0x4007E34")]
	[FieldOffset(Offset = "0x130")]
	public SplineParameter redCurve;

	[Token(Token = "0x4007E35")]
	[FieldOffset(Offset = "0x138")]
	public SplineParameter greenCurve;

	[Token(Token = "0x4007E36")]
	[FieldOffset(Offset = "0x140")]
	public SplineParameter blueCurve;

	[Token(Token = "0x4007E37")]
	[FieldOffset(Offset = "0x148")]
	public SplineParameter hueVsHueCurve;

	[Token(Token = "0x4007E38")]
	[FieldOffset(Offset = "0x150")]
	public SplineParameter hueVsSatCurve;

	[Token(Token = "0x4007E39")]
	[FieldOffset(Offset = "0x158")]
	public SplineParameter satVsSatCurve;

	[Token(Token = "0x4007E3A")]
	[FieldOffset(Offset = "0x160")]
	public SplineParameter lumVsSatCurve;

	[Token(Token = "0x4007E3B")]
	[FieldOffset(Offset = "0x168")]
	public ColorGradingSettingsParameter settings1A;

	[Token(Token = "0x4007E3C")]
	[FieldOffset(Offset = "0x170")]
	public ColorGradingSettingsParameter settings1B;

	[Token(Token = "0x4007E3D")]
	[FieldOffset(Offset = "0x178")]
	public ColorGradingSettingsParameter settings2A;

	[Token(Token = "0x4007E3E")]
	[FieldOffset(Offset = "0x180")]
	public ColorGradingSettingsParameter settings2B;

	[Token(Token = "0x4007E3F")]
	[FieldOffset(Offset = "0x188")]
	public Vector4Parameter blendRecord;

	[Token(Token = "0x4007E40")]
	[FieldOffset(Offset = "0x190")]
	public FloatParameter blendGamma;

	[Token(Token = "0x4007E41")]
	[FieldOffset(Offset = "0x198")]
	public FloatParameter blendGammaLimitLow;

	[Token(Token = "0x4007E42")]
	[FieldOffset(Offset = "0x1A0")]
	public FloatParameter blendGammaLimitHigh;

	[Token(Token = "0x4007E43")]
	[FieldOffset(Offset = "0x1A8")]
	public FloatParameter blendColorScalar;

	[Token(Token = "0x4007E44")]
	[FieldOffset(Offset = "0x1B0")]
	public FloatParameter blendHdrScalar;

	[DisplayName("Emergency Stim")]
	[Tooltip("Color Grading Settings to blend in for the emergency stim effect.")]
	[Token(Token = "0x4007E45")]
	[FieldOffset(Offset = "0x1B8")]
	public ColorGradingSettingsParameter stimSettings;

	[Token(Token = "0x4007E46")]
	[FieldOffset(Offset = "0x1C0")]
	public FloatParameter stimEffectIntensity;

	[Token(Token = "0x4007E47")]
	[FieldOffset(Offset = "0x1C8")]
	public FloatParameter stimEffectIntensityTarget;

	[DisplayName("Electrocution")]
	[Tooltip("Color Grading Settings to blend in for the electrocution effect.")]
	[Token(Token = "0x4007E48")]
	[FieldOffset(Offset = "0x1D0")]
	public ColorGradingSettingsParameter electrocutionSettings;

	[Token(Token = "0x4007E49")]
	[FieldOffset(Offset = "0x1D8")]
	public FloatParameter electrocutionEffectIntensity;

	[Token(Token = "0x4007E4A")]
	[FieldOffset(Offset = "0x1E0")]
	public FloatParameter electrocutionEffectIntensityTarget;

	[DisplayName("Pain")]
	[Tooltip("Color Grading Settings to blend in for the pain effect.")]
	[Token(Token = "0x4007E4B")]
	[FieldOffset(Offset = "0x1E8")]
	public ColorGradingSettingsParameter painSettings;

	[Token(Token = "0x4007E4C")]
	[FieldOffset(Offset = "0x1F0")]
	public FloatParameter painEffectIntensity;

	[Token(Token = "0x4007E4D")]
	[FieldOffset(Offset = "0x1F8")]
	public FloatParameter painEffectIntensityTarget;

	[DisplayName("Boost Effect")]
	[Tooltip("Color Grading Settings to blend in for the boost effect.")]
	[Token(Token = "0x4007E4E")]
	[FieldOffset(Offset = "0x200")]
	public ColorGradingSettingsParameter boostEffectSettings;

	[Token(Token = "0x4007E4F")]
	[FieldOffset(Offset = "0x208")]
	public FloatParameter boostEffectIntensity;

	[Token(Token = "0x4007E50")]
	[FieldOffset(Offset = "0x210")]
	public FloatParameter boostEffectIntensityTarget;

	[DisplayName("Headache")]
	[Tooltip("Color Grading Settings to blend in for the headache effect.")]
	[Token(Token = "0x4007E51")]
	[FieldOffset(Offset = "0x218")]
	public ColorGradingSettingsParameter headacheSettings;

	[Token(Token = "0x4007E52")]
	[FieldOffset(Offset = "0x220")]
	public FloatParameter headacheEffectIntensity;

	[Token(Token = "0x4007E53")]
	[FieldOffset(Offset = "0x228")]
	public FloatParameter headacheEffectIntensityTarget;

	[DisplayName("Suffocation")]
	[Tooltip("Color Grading Settings to blend in for the suffocation effect.")]
	[Token(Token = "0x4007E54")]
	[FieldOffset(Offset = "0x230")]
	public ColorGradingSettingsParameter suffocationSettings;

	[Token(Token = "0x4007E55")]
	[FieldOffset(Offset = "0x238")]
	public FloatParameter suffocationEffectIntensity;

	[Token(Token = "0x4007E56")]
	[FieldOffset(Offset = "0x240")]
	public FloatParameter suffocationEffectIntensityTarget;

	[DisplayName("Aux")]
	[Tooltip("Color Grading Settings to blend in for auxiliary effects.")]
	[Token(Token = "0x4007E57")]
	[FieldOffset(Offset = "0x248")]
	public ColorGradingSettingsParameter auxSettings;

	[Token(Token = "0x4007E58")]
	[FieldOffset(Offset = "0x250")]
	public FloatParameter auxEffectIntensity;

	[Token(Token = "0x4007E59")]
	[FieldOffset(Offset = "0x258")]
	public FloatParameter auxEffectIntensityTarget;

	[DisplayName("Noise Texture")]
	[Token(Token = "0x4007E5A")]
	[FieldOffset(Offset = "0x260")]
	public TextureParameter noiseTexture;

	[DisplayName("Noise Params")]
	[Tooltip("x = intensity, y = UV scalar, zw = offset")]
	[Token(Token = "0x4007E5B")]
	[FieldOffset(Offset = "0x268")]
	public Vector4Parameter noiseParams;

	[DisplayName("Noise Randomize")]
	[Token(Token = "0x4007E5C")]
	[FieldOffset(Offset = "0x270")]
	public BoolParameter noiseRandomize;

	[Token(Token = "0x60064AA")]
	[Address(RVA = "0xFEDD90", Offset = "0xFECB90", Length = "0xBA")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x60064AB")]
	[Address(RVA = "0xFEDE50", Offset = "0xFECC50", Length = "0xBA")]
	public float GetBlendGammaForBrightness(float brightness)
	{
		return 0f;
	}

	[Token(Token = "0x60064AC")]
	[Address(RVA = "0xFEDF10", Offset = "0xFECD10", Length = "0x1A4")]
	public static PostProcessVolume ApplyTempLut(ColorGradingSettings temp)
	{
		return null;
	}

	[Token(Token = "0x60064AD")]
	[Address(RVA = "0xFEE0C0", Offset = "0xFECEC0", Length = "0x13B")]
	public void ConfigureLutForInterior(ColorGradingSettings customLUT)
	{
	}

	[Token(Token = "0x60064AE")]
	[Address(RVA = "0xFEE200", Offset = "0xFED000", Length = "0x1BD")]
	public void UpdateLutForTimeOfDay(ColorGradingSettings settings1A, ColorGradingSettings settings1B, ColorGradingSettings settings2A, ColorGradingSettings settings2B, float blend1, float blend2, float blendCombine)
	{
	}

	[Token(Token = "0x60064AF")]
	[Address(RVA = "0xFEE3C0", Offset = "0xFED1C0", Length = "0x1F00")]
	public ColorGrading()
	{
	}
}

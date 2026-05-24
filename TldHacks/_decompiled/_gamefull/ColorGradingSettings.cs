using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[CreateAssetMenu(order = 10000)]
[Token(Token = "0x200037F")]
public class ColorGradingSettings : PostProcessEffectSettings
{
	[DisplayName("Temperature")]
	[Range(-100f, 100f)]
	[Tooltip("Sets the white balance to a custom color temperature.")]
	[Token(Token = "0x4001F1B")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter temperature;

	[DisplayName("Tint")]
	[Range(-100f, 100f)]
	[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
	[Token(Token = "0x4001F1C")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter tint;

	[DisplayName("Color Filter")]
	[ColorUsage(false, true)]
	[Tooltip("Tint the render by multiplying a color.")]
	[Token(Token = "0x4001F1D")]
	[FieldOffset(Offset = "0x40")]
	public ColorParameter colorFilter;

	[DisplayName("Hue Shift")]
	[Range(-180f, 180f)]
	[Tooltip("Shift the hue of all colors.")]
	[Token(Token = "0x4001F1E")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter hueShift;

	[DisplayName("Saturation")]
	[Range(-100f, 100f)]
	[Tooltip("Pushes the intensity of all colors.")]
	[Token(Token = "0x4001F1F")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter saturation;

	[DisplayName("Post-exposure (EV)")]
	[Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
	[Token(Token = "0x4001F20")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter postExposure;

	[DisplayName("Contrast")]
	[Range(-100f, 100f)]
	[Tooltip("Expands or shrinks the overall range of tonal values.")]
	[Token(Token = "0x4001F21")]
	[FieldOffset(Offset = "0x60")]
	public FloatParameter contrast;

	[DisplayName("Red")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	[Token(Token = "0x4001F22")]
	[FieldOffset(Offset = "0x68")]
	public FloatParameter mixerRedOutRedIn;

	[DisplayName("Green")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	[Token(Token = "0x4001F23")]
	[FieldOffset(Offset = "0x70")]
	public FloatParameter mixerRedOutGreenIn;

	[DisplayName("Blue")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	[Token(Token = "0x4001F24")]
	[FieldOffset(Offset = "0x78")]
	public FloatParameter mixerRedOutBlueIn;

	[DisplayName("Red")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	[Token(Token = "0x4001F25")]
	[FieldOffset(Offset = "0x80")]
	public FloatParameter mixerGreenOutRedIn;

	[DisplayName("Green")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	[Token(Token = "0x4001F26")]
	[FieldOffset(Offset = "0x88")]
	public FloatParameter mixerGreenOutGreenIn;

	[DisplayName("Blue")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	[Token(Token = "0x4001F27")]
	[FieldOffset(Offset = "0x90")]
	public FloatParameter mixerGreenOutBlueIn;

	[DisplayName("Red")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	[Token(Token = "0x4001F28")]
	[FieldOffset(Offset = "0x98")]
	public FloatParameter mixerBlueOutRedIn;

	[DisplayName("Green")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	[Token(Token = "0x4001F29")]
	[FieldOffset(Offset = "0xA0")]
	public FloatParameter mixerBlueOutGreenIn;

	[DisplayName("Blue")]
	[Range(-200f, 200f)]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	[Token(Token = "0x4001F2A")]
	[FieldOffset(Offset = "0xA8")]
	public FloatParameter mixerBlueOutBlueIn;

	[DisplayName("Lift")]
	[Tooltip("Controls the darkest portions of the render.")]
	[Trackball(TrackballAttribute.Mode.Lift)]
	[Token(Token = "0x4001F2B")]
	[FieldOffset(Offset = "0xB0")]
	public Vector4Parameter lift;

	[DisplayName("Gamma")]
	[Tooltip("Power function that controls midrange tones.")]
	[Trackball(TrackballAttribute.Mode.Gamma)]
	[Token(Token = "0x4001F2C")]
	[FieldOffset(Offset = "0xB8")]
	public Vector4Parameter gamma;

	[DisplayName("Gain")]
	[Tooltip("Controls the lightest portions of the render.")]
	[Trackball(TrackballAttribute.Mode.Gain)]
	[Token(Token = "0x4001F2D")]
	[FieldOffset(Offset = "0xC0")]
	public Vector4Parameter gain;

	[Token(Token = "0x4001F2E")]
	[FieldOffset(Offset = "0xC8")]
	public SplineParameter hueVsHueCurve;

	[Token(Token = "0x4001F2F")]
	[FieldOffset(Offset = "0xD0")]
	public SplineParameter hueVsSatCurve;

	[Token(Token = "0x4001F30")]
	[FieldOffset(Offset = "0xD8")]
	public SplineParameter satVsSatCurve;

	[Token(Token = "0x4001F31")]
	[FieldOffset(Offset = "0xE0")]
	public SplineParameter lumVsSatCurve;

	[Token(Token = "0x4001F32")]
	[FieldOffset(Offset = "0xE8")]
	private Texture2D m_GradingCurves;

	[Token(Token = "0x4001F33")]
	[FieldOffset(Offset = "0xF0")]
	private readonly Color[] m_Pixels;

	[Token(Token = "0x6001C1A")]
	[Address(RVA = "0x773C00", Offset = "0x772A00", Length = "0x6B3")]
	public void ApplySettings(UnityEngine.Rendering.PostProcessing.ColorGrading cg)
	{
	}

	[Token(Token = "0x6001C1B")]
	[Address(RVA = "0x7742C0", Offset = "0x7730C0", Length = "0xB58")]
	public void ApplySettings(MaterialPropertyBlock properties)
	{
	}

	[Token(Token = "0x6001C1C")]
	[Address(RVA = "0x774E20", Offset = "0x773C20", Length = "0x516")]
	private Texture2D GetCurveTexture(bool hdr)
	{
		return null;
	}

	[Token(Token = "0x6001C1D")]
	[Address(RVA = "0x775340", Offset = "0x774140", Length = "0x1050")]
	public ColorGradingSettings()
	{
	}
}

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200029C")]
public class DebugViewModeManager : MonoBehaviour
{
	[Token(Token = "0x400177C")]
	[FieldOffset(Offset = "0x20")]
	private DebugViewMode m_CurrentMode;

	[Token(Token = "0x400177D")]
	private static DebugViewMode s_LastMode;

	[Header("Diffuse Only")]
	[Token(Token = "0x400177E")]
	[FieldOffset(Offset = "0x28")]
	private Shader m_DiffuseOnlyShader;

	[Header("Lighting Only")]
	[Token(Token = "0x400177F")]
	[FieldOffset(Offset = "0x30")]
	private Shader m_LightingOnlyShader;

	[Token(Token = "0x4001780")]
	[FieldOffset(Offset = "0x38")]
	private CameraEffects.SSAOMode m_LastSSAOMode;

	[Header("Texel Density")]
	[Token(Token = "0x4001781")]
	[FieldOffset(Offset = "0x40")]
	private Shader m_TexelDensityShader;

	[Token(Token = "0x4001782")]
	public const float DEFAULT_TEXEL_DENSITY_TARGET = 256f;

	[Token(Token = "0x4001783")]
	private static float s_TexelDensityTarget;

	[Token(Token = "0x4001784")]
	private static readonly int s_TargetShaderID;

	[Token(Token = "0x600164B")]
	[Address(RVA = "0x4571E0", Offset = "0x455FE0", Length = "0x4")]
	public DebugViewMode GetMode()
	{
		return default(DebugViewMode);
	}

	[Token(Token = "0x600164C")]
	[Address(RVA = "0x6B6750", Offset = "0x6B5550", Length = "0xAF")]
	public void SetMode(DebugViewMode mode)
	{
	}

	[Token(Token = "0x600164D")]
	[Address(RVA = "0x6B6800", Offset = "0x6B5600", Length = "0x38")]
	private void ToggleMode(DebugViewMode mode, bool isEnabled)
	{
	}

	[Token(Token = "0x600164E")]
	[Address(RVA = "0x6B6840", Offset = "0x6B5640", Length = "0x86")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600164F")]
	[Address(RVA = "0x6B68D0", Offset = "0x6B56D0", Length = "0x70")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001650")]
	[Address(RVA = "0x6B6940", Offset = "0x6B5740", Length = "0x1DC")]
	private void ToggleDiffuseOnly(bool isOn)
	{
	}

	[Token(Token = "0x6001651")]
	[Address(RVA = "0x6B6B20", Offset = "0x6B5920", Length = "0x187")]
	private void ToggleLightingOnly(bool isOn)
	{
	}

	[Token(Token = "0x6001652")]
	[Address(RVA = "0x6B6CB0", Offset = "0x6B5AB0", Length = "0xBC")]
	public static void SetTexelDensityTarget(float target)
	{
	}

	[Token(Token = "0x6001653")]
	[Address(RVA = "0x6B6D70", Offset = "0x6B5B70", Length = "0x55")]
	public static float GetTexelDensityTarget()
	{
		return 0f;
	}

	[Token(Token = "0x6001654")]
	[Address(RVA = "0x6B6DD0", Offset = "0x6B5BD0", Length = "0x394")]
	private void ToggleTexelDensity(bool isOn)
	{
	}

	[Token(Token = "0x6001655")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public DebugViewModeManager()
	{
	}
}

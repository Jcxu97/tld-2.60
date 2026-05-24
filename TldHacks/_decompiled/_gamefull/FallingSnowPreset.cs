using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20002FC")]
public class FallingSnowPreset
{
	[Token(Token = "0x20002FD")]
	public enum Type
	{
		[Token(Token = "0x4001A63")]
		Light,
		[Token(Token = "0x4001A64")]
		Heavy,
		[Token(Token = "0x4001A65")]
		Blizzard,
		[Token(Token = "0x4001A66")]
		None,
		[Token(Token = "0x4001A67")]
		Undefined
	}

	[Token(Token = "0x4001A56")]
	[FieldOffset(Offset = "0x10")]
	private Type m_Type;

	[Token(Token = "0x4001A57")]
	[FieldOffset(Offset = "0x14")]
	private float m_MaxParticles;

	[Token(Token = "0x4001A58")]
	[FieldOffset(Offset = "0x18")]
	private float m_EmissionRate;

	[Token(Token = "0x4001A59")]
	[FieldOffset(Offset = "0x1C")]
	private float m_StartLifetime;

	[Token(Token = "0x4001A5A")]
	[FieldOffset(Offset = "0x20")]
	private float m_GravityModifier;

	[Token(Token = "0x4001A5B")]
	[FieldOffset(Offset = "0x24")]
	private float m_RendererSpeedScale;

	[Token(Token = "0x4001A5C")]
	[FieldOffset(Offset = "0x28")]
	public float m_TurbulenceScalar;

	[Token(Token = "0x4001A5D")]
	[FieldOffset(Offset = "0x2C")]
	public float m_FlurryScalar;

	[Token(Token = "0x4001A5E")]
	public const float BLIZZARD_MAX_PARTICLES = 4000f;

	[Token(Token = "0x4001A5F")]
	public const float HEAVY_SNOW_MAX_PARTICLES = 3000f;

	[Token(Token = "0x4001A60")]
	public const float LIGHT_SNOW_MAX_PARTICLES_MIN = 750f;

	[Token(Token = "0x4001A61")]
	public const float LIGHT_SNOW_MAX_PARTICLES_MAX = 1500f;

	[Token(Token = "0x600189B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FallingSnowPreset()
	{
	}

	[Token(Token = "0x600189C")]
	[Address(RVA = "0x6F4880", Offset = "0x6F3680", Length = "0x162")]
	public FallingSnowPreset(Type type)
	{
	}

	[Token(Token = "0x600189D")]
	[Address(RVA = "0x6F49F0", Offset = "0x6F37F0", Length = "0x1B3")]
	public void SetBlended(FallingSnowPreset a, FallingSnowPreset b, float blend)
	{
	}

	[Token(Token = "0x600189E")]
	[Address(RVA = "0x6F4BB0", Offset = "0x6F39B0", Length = "0x496")]
	public void Apply(ParticleSystem ps, ParticleSystemRenderer lpr)
	{
	}

	[Token(Token = "0x600189F")]
	[Address(RVA = "0x6F5050", Offset = "0x6F3E50", Length = "0xB8")]
	private float GetAdjustedMaxFallingParticlesCount(Type type)
	{
		return 0f;
	}

	[Token(Token = "0x60018A0")]
	[Address(RVA = "0x6F5110", Offset = "0x6F3F10", Length = "0x85")]
	private float GetMaxFallingParticlesCount(Type type)
	{
		return 0f;
	}
}

using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "The Long Dark/Vfx/Electrostatic Material Properties")]
[Token(Token = "0x20002E9")]
public class ElectrostaticMaterialProperties : ActivatedMaterialProperties
{
	[Token(Token = "0x4001990")]
	[FieldOffset(Offset = "0x18")]
	public Texture2D m_NoiseTexture;

	[Token(Token = "0x4001991")]
	[FieldOffset(Offset = "0x20")]
	public Vector4 m_NoiseTextureOffset;

	[Token(Token = "0x4001992")]
	[FieldOffset(Offset = "0x30")]
	public float m_Power;

	[Token(Token = "0x4001993")]
	[FieldOffset(Offset = "0x34")]
	public float m_Strength;

	[Token(Token = "0x4001994")]
	[FieldOffset(Offset = "0x38")]
	public Color m_PrimaryColor;

	[Token(Token = "0x4001995")]
	[FieldOffset(Offset = "0x48")]
	public Color m_SecondaryColor;

	[Token(Token = "0x4001996")]
	[FieldOffset(Offset = "0x58")]
	public float m_Gain;

	[Token(Token = "0x4001997")]
	[FieldOffset(Offset = "0x5C")]
	public Vector2 m_Speed;

	[Token(Token = "0x4001998")]
	private static readonly int s_NoiseTextureShaderID;

	[Token(Token = "0x4001999")]
	private static readonly int s_NoiseTextureOffsetShaderID;

	[Token(Token = "0x400199A")]
	private static readonly int s_PowerShaderID;

	[Token(Token = "0x400199B")]
	private static readonly int s_StrengthShaderID;

	[Token(Token = "0x400199C")]
	private static readonly int s_PrimaryColorShaderID;

	[Token(Token = "0x400199D")]
	private static readonly int s_SecondaryColorShaderID;

	[Token(Token = "0x400199E")]
	private static readonly int s_GainShaderID;

	[Token(Token = "0x400199F")]
	private static readonly int s_SpeedShaderID;

	[Token(Token = "0x170001F5")]
	public override string ActivationKeyword
	{
		[Token(Token = "0x6001847")]
		[Address(RVA = "0x6E4A20", Offset = "0x6E3820", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001848")]
	[Address(RVA = "0x6E4A60", Offset = "0x6E3860", Length = "0x3A3")]
	public override void UpdateMaterial(Material mat, bool isActive)
	{
	}

	[Token(Token = "0x6001849")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public ElectrostaticMaterialProperties()
	{
	}
}

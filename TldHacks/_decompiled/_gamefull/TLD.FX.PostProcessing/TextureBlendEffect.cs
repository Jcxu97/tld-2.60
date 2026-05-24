using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace TLD.FX.PostProcessing;

[Serializable]
[PostProcess(typeof(TextureBlendEffectRenderer), PostProcessEvent.AfterStack, "Hinterland/Texture Blend Effect", false)]
[Token(Token = "0x20013DB")]
public sealed class TextureBlendEffect : PostProcessEffectSettings
{
	[Range(1f, 3f)]
	[Token(Token = "0x4009177")]
	[FieldOffset(Offset = "0x30")]
	public IntParameter m_LayerCount;

	[Token(Token = "0x4009178")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter m_Layer1Strength;

	[Token(Token = "0x4009179")]
	[FieldOffset(Offset = "0x40")]
	public Vector2Parameter m_Layer1Tiling;

	[Token(Token = "0x400917A")]
	[FieldOffset(Offset = "0x48")]
	public TextureParameter m_Layer1Texture;

	[Token(Token = "0x400917B")]
	[FieldOffset(Offset = "0x50")]
	public TextureBlendModeParameter m_Layer1BlendMode;

	[Token(Token = "0x400917C")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter m_Layer2Strength;

	[Token(Token = "0x400917D")]
	[FieldOffset(Offset = "0x60")]
	public Vector2Parameter m_Layer2Tiling;

	[Token(Token = "0x400917E")]
	[FieldOffset(Offset = "0x68")]
	public TextureParameter m_Layer2Texture;

	[Token(Token = "0x400917F")]
	[FieldOffset(Offset = "0x70")]
	public TextureBlendModeParameter m_Layer2BlendMode;

	[Token(Token = "0x4009180")]
	[FieldOffset(Offset = "0x78")]
	public FloatParameter m_Layer3Strength;

	[Token(Token = "0x4009181")]
	[FieldOffset(Offset = "0x80")]
	public Vector2Parameter m_Layer3Tiling;

	[Token(Token = "0x4009182")]
	[FieldOffset(Offset = "0x88")]
	public TextureParameter m_Layer3Texture;

	[Token(Token = "0x4009183")]
	[FieldOffset(Offset = "0x90")]
	public TextureBlendModeParameter m_Layer3BlendMode;

	[Token(Token = "0x6007EB3")]
	[Address(RVA = "0x11E42D0", Offset = "0x11E30D0", Length = "0x7FA")]
	public TextureBlendEffect()
	{
	}
}

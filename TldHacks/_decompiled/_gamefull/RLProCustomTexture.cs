using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_CustomTexture_Renderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Custom Texture", false)]
[Token(Token = "0x2000AB6")]
public sealed class RLProCustomTexture : PostProcessEffectSettings
{
	[Tooltip("Your custom texture.")]
	[Token(Token = "0x40068AF")]
	[FieldOffset(Offset = "0x30")]
	public TextureParameter texture;

	[Range(0f, 1f)]
	[Tooltip("Fade parameter.")]
	[Token(Token = "0x40068B0")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter fade;

	[Token(Token = "0x6005C7A")]
	[Address(RVA = "0xF44A80", Offset = "0xF43880", Length = "0x164")]
	public RLProCustomTexture()
	{
	}
}

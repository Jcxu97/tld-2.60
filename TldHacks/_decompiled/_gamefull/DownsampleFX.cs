using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x2000382")]
public class DownsampleFX : MonoBehaviour
{
	[Token(Token = "0x2000383")]
	private enum Resolution
	{
		[Token(Token = "0x4001F5F")]
		_1080p = 1080,
		[Token(Token = "0x4001F60")]
		_720p = 720,
		[Token(Token = "0x4001F61")]
		_480p = 480,
		[Token(Token = "0x4001F62")]
		_240p = 240,
		[Token(Token = "0x4001F63")]
		_135p = 135
	}

	[Token(Token = "0x4001F4B")]
	private static Dictionary<Resolution, int> s_ShaderRenderTextureIds;

	[SerializeField]
	[Token(Token = "0x4001F4C")]
	[FieldOffset(Offset = "0x20")]
	private Resolution m_Resolution;

	[SerializeField]
	[Token(Token = "0x4001F4D")]
	[FieldOffset(Offset = "0x24")]
	private CameraEvent m_RenderOrder;

	[SerializeField]
	[Token(Token = "0x4001F4E")]
	[FieldOffset(Offset = "0x28")]
	private Shader m_EffectShader;

	[SerializeField]
	[Token(Token = "0x4001F4F")]
	[FieldOffset(Offset = "0x30")]
	private Shader m_BlitShader;

	[SerializeField]
	[Token(Token = "0x4001F50")]
	[FieldOffset(Offset = "0x38")]
	private Shader m_BlurShader;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4001F51")]
	[FieldOffset(Offset = "0x40")]
	private float m_Alpha;

	[SerializeField]
	[Range(0f, 4f)]
	[Token(Token = "0x4001F52")]
	[FieldOffset(Offset = "0x44")]
	private int m_BlurIterations;

	[SerializeField]
	[Range(0f, 10f)]
	[Token(Token = "0x4001F53")]
	[FieldOffset(Offset = "0x48")]
	private float m_BlurSize;

	[SerializeField]
	[Token(Token = "0x4001F54")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_UseWeaponViewCamera;

	[Token(Token = "0x4001F55")]
	[FieldOffset(Offset = "0x50")]
	private List<Renderer> m_ParticleRenderers;

	[Token(Token = "0x4001F56")]
	[FieldOffset(Offset = "0x58")]
	private CommandBuffer m_CommandBuffer;

	[Token(Token = "0x4001F57")]
	[FieldOffset(Offset = "0x60")]
	private Camera m_Camera;

	[Token(Token = "0x4001F58")]
	[FieldOffset(Offset = "0x68")]
	private Material m_DefaultEffectMaterial;

	[Token(Token = "0x4001F59")]
	[FieldOffset(Offset = "0x70")]
	private Material m_DownsampledEffectMaterial;

	[Token(Token = "0x4001F5A")]
	[FieldOffset(Offset = "0x78")]
	private Material m_BlitMaterial;

	[Token(Token = "0x4001F5B")]
	[FieldOffset(Offset = "0x80")]
	private Material m_BlurMaterial;

	[Token(Token = "0x4001F5C")]
	[FieldOffset(Offset = "0x88")]
	private bool m_Initialized;

	[Token(Token = "0x4001F5D")]
	[FieldOffset(Offset = "0x8C")]
	private CameraEvent m_LastRenderOrder;

	[Token(Token = "0x6001C2B")]
	[Address(RVA = "0x7787A0", Offset = "0x7775A0", Length = "0x7")]
	private void Start()
	{
	}

	[Token(Token = "0x6001C2C")]
	[Address(RVA = "0x7787B0", Offset = "0x7775B0", Length = "0x11")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001C2D")]
	[Address(RVA = "0x7787D0", Offset = "0x7775D0", Length = "0x7")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001C2E")]
	[Address(RVA = "0x7787E0", Offset = "0x7775E0", Length = "0x2B8")]
	private void DetachCommandBuffer()
	{
	}

	[Token(Token = "0x6001C2F")]
	[Address(RVA = "0x778AA0", Offset = "0x7778A0", Length = "0x389")]
	private void ReattachCommandBuffer()
	{
	}

	[Token(Token = "0x6001C30")]
	[Address(RVA = "0x778E30", Offset = "0x777C30", Length = "0x621")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6001C31")]
	[Address(RVA = "0x779460", Offset = "0x778260", Length = "0x10DF")]
	private void RebuildCommandBuffer()
	{
	}

	[Token(Token = "0x6001C32")]
	[Address(RVA = "0x77A540", Offset = "0x779340", Length = "0x163")]
	private void TryToFindParticleRenderers()
	{
	}

	[Token(Token = "0x6001C33")]
	[Address(RVA = "0x77A6B0", Offset = "0x7794B0", Length = "0xA0")]
	public void RegisterParticleSystem(ParticleSystem particleSystem)
	{
	}

	[Token(Token = "0x6001C34")]
	[Address(RVA = "0x77A760", Offset = "0x779560", Length = "0x64")]
	public void ClearParticleRenderers()
	{
	}

	[Token(Token = "0x6001C35")]
	[Address(RVA = "0x77A7D0", Offset = "0x7795D0", Length = "0x104")]
	public DownsampleFX()
	{
	}
}

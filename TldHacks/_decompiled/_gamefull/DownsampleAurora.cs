using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x2000380")]
public class DownsampleAurora : MonoBehaviour
{
	[Token(Token = "0x2000381")]
	private enum Resolution
	{
		[Token(Token = "0x4001F46")]
		_1080p = 1080,
		[Token(Token = "0x4001F47")]
		_720p = 720,
		[Token(Token = "0x4001F48")]
		_480p = 480,
		[Token(Token = "0x4001F49")]
		_240p = 240,
		[Token(Token = "0x4001F4A")]
		_135p = 135
	}

	[SerializeField]
	[Token(Token = "0x4001F34")]
	[FieldOffset(Offset = "0x20")]
	private Resolution m_Resolution;

	[SerializeField]
	[Token(Token = "0x4001F35")]
	[FieldOffset(Offset = "0x24")]
	private CameraEvent m_RenderOrder;

	[SerializeField]
	[Token(Token = "0x4001F36")]
	[FieldOffset(Offset = "0x28")]
	private Shader m_EffectShader;

	[SerializeField]
	[Token(Token = "0x4001F37")]
	[FieldOffset(Offset = "0x30")]
	private Shader m_DefaultShader;

	[SerializeField]
	[Token(Token = "0x4001F38")]
	[FieldOffset(Offset = "0x38")]
	private Shader m_BlitShader;

	[SerializeField]
	[Token(Token = "0x4001F39")]
	[FieldOffset(Offset = "0x40")]
	private Shader m_BlurShader;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4001F3A")]
	[FieldOffset(Offset = "0x48")]
	private float m_Alpha;

	[SerializeField]
	[Range(0f, 4f)]
	[Token(Token = "0x4001F3B")]
	[FieldOffset(Offset = "0x4C")]
	private int m_BlurIterations;

	[SerializeField]
	[Range(0f, 10f)]
	[Token(Token = "0x4001F3C")]
	[FieldOffset(Offset = "0x50")]
	private float m_BlurSize;

	[Token(Token = "0x4001F3D")]
	[FieldOffset(Offset = "0x58")]
	private List<SkinnedMeshRenderer> m_SkinnedMeshRenderers;

	[Token(Token = "0x4001F3E")]
	[FieldOffset(Offset = "0x60")]
	private CommandBuffer m_CommandBuffer;

	[Token(Token = "0x4001F3F")]
	[FieldOffset(Offset = "0x68")]
	private Camera m_Camera;

	[Token(Token = "0x4001F40")]
	[FieldOffset(Offset = "0x70")]
	private Material m_BlitMaterial;

	[Token(Token = "0x4001F41")]
	[FieldOffset(Offset = "0x78")]
	private Material m_BlurMaterial;

	[Token(Token = "0x4001F42")]
	[FieldOffset(Offset = "0x80")]
	private bool m_Initialized;

	[Token(Token = "0x4001F43")]
	[FieldOffset(Offset = "0x81")]
	private bool m_CommandBufferNeedsUpdate;

	[Token(Token = "0x4001F44")]
	[FieldOffset(Offset = "0x84")]
	private CameraEvent m_LastRenderOrder;

	[Token(Token = "0x6001C1E")]
	[Address(RVA = "0x7763A0", Offset = "0x7751A0", Length = "0x7")]
	private void Start()
	{
	}

	[Token(Token = "0x6001C1F")]
	[Address(RVA = "0x7763B0", Offset = "0x7751B0", Length = "0x11")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001C20")]
	[Address(RVA = "0x7763D0", Offset = "0x7751D0", Length = "0x7")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001C21")]
	[Address(RVA = "0x7763E0", Offset = "0x7751E0", Length = "0xD6")]
	private void Update()
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6001C22")]
	[Address(RVA = "0x7764C0", Offset = "0x7752C0", Length = "0x2E4")]
	public void Debug_ToggleEnable()
	{
	}

	[Token(Token = "0x6001C23")]
	[Address(RVA = "0x7767B0", Offset = "0x7755B0", Length = "0x34D")]
	public void RegisterAurora(GameObject auroraGO)
	{
	}

	[Token(Token = "0x6001C24")]
	[Address(RVA = "0x776B00", Offset = "0x775900", Length = "0x1EA")]
	public void UnRegisterAurora(GameObject auroraGO)
	{
	}

	[Token(Token = "0x6001C25")]
	[Address(RVA = "0x776CF0", Offset = "0x775AF0", Length = "0x146")]
	private void DetachCommandBuffer()
	{
	}

	[Token(Token = "0x6001C26")]
	[Address(RVA = "0x776E40", Offset = "0x775C40", Length = "0x175")]
	private void ReattachCommandBuffer()
	{
	}

	[Token(Token = "0x6001C27")]
	[Address(RVA = "0x776FC0", Offset = "0x775DC0", Length = "0xDF")]
	private bool IsCommandBufferActive()
	{
		return false;
	}

	[Token(Token = "0x6001C28")]
	[Address(RVA = "0x7770A0", Offset = "0x775EA0", Length = "0x57F")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6001C29")]
	[Address(RVA = "0x777620", Offset = "0x776420", Length = "0x1063")]
	private void RebuildCommandBuffer()
	{
	}

	[Token(Token = "0x6001C2A")]
	[Address(RVA = "0x778690", Offset = "0x777490", Length = "0x106")]
	public DownsampleAurora()
	{
	}
}

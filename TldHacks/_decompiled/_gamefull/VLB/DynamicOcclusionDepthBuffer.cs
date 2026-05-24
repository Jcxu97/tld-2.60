using Cpp2ILInjected;
using UnityEngine;

namespace VLB;

[ExecuteInEditMode]
[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/")]
[Token(Token = "0x2000BC0")]
public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
{
	[Token(Token = "0x40078CE")]
	[FieldOffset(Offset = "0x48")]
	public LayerMask layerMask;

	[Token(Token = "0x40078CF")]
	[FieldOffset(Offset = "0x4C")]
	public bool useOcclusionCulling;

	[Token(Token = "0x40078D0")]
	[FieldOffset(Offset = "0x50")]
	public int depthMapResolution;

	[Token(Token = "0x40078D1")]
	[FieldOffset(Offset = "0x54")]
	public float fadeDistanceToSurface;

	[Token(Token = "0x40078D2")]
	[FieldOffset(Offset = "0x58")]
	private Camera m_DepthCamera;

	[Token(Token = "0x40078D3")]
	[FieldOffset(Offset = "0x60")]
	private bool m_NeedToUpdateOcclusionNextFrame;

	[Token(Token = "0x6005D54")]
	[Address(RVA = "0xF617F0", Offset = "0xF605F0", Length = "0x31")]
	protected override string GetShaderKeyword()
	{
		return null;
	}

	[Token(Token = "0x6005D55")]
	[Address(RVA = "0x901E60", Offset = "0x900C60", Length = "0x6")]
	protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
	{
		return default(MaterialManager.DynamicOcclusion);
	}

	[Token(Token = "0x6005D56")]
	[Address(RVA = "0xF61830", Offset = "0xF60630", Length = "0xA3")]
	private void ProcessOcclusionInternal()
	{
	}

	[Token(Token = "0x6005D57")]
	[Address(RVA = "0xF618E0", Offset = "0xF606E0", Length = "0x36")]
	protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
	{
		return false;
	}

	[Token(Token = "0x6005D58")]
	[Address(RVA = "0xF61920", Offset = "0xF60720", Length = "0x10A")]
	private void Update()
	{
	}

	[Token(Token = "0x6005D59")]
	[Address(RVA = "0xF61A30", Offset = "0xF60830", Length = "0x494")]
	private void UpdateDepthCameraPropertiesAccordingToBeam()
	{
	}

	[Token(Token = "0x6005D5A")]
	[Address(RVA = "0xF61ED0", Offset = "0xF60CD0", Length = "0x55")]
	public bool HasLayerMaskIssues()
	{
		return false;
	}

	[Token(Token = "0x6005D5B")]
	[Address(RVA = "0xF61F30", Offset = "0xF60D30", Length = "0x75")]
	protected override void OnValidateProperties()
	{
	}

	[Token(Token = "0x6005D5C")]
	[Address(RVA = "0xF61FB0", Offset = "0xF60DB0", Length = "0x454")]
	private void InstantiateOrActivateDepthCamera()
	{
	}

	[Token(Token = "0x6005D5D")]
	[Address(RVA = "0xF62410", Offset = "0xF61210", Length = "0x7")]
	protected override void OnEnablePostValidate()
	{
	}

	[Token(Token = "0x6005D5E")]
	[Address(RVA = "0xF62420", Offset = "0xF61220", Length = "0xFB")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6005D5F")]
	[Address(RVA = "0xF61050", Offset = "0xF5FE50", Length = "0xC6")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6005D60")]
	[Address(RVA = "0xF62520", Offset = "0xF61320", Length = "0x66")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6005D61")]
	[Address(RVA = "0xF62590", Offset = "0xF61390", Length = "0x2E1")]
	private void DestroyDepthCamera()
	{
	}

	[Token(Token = "0x6005D62")]
	[Address(RVA = "0xF62880", Offset = "0xF61680", Length = "0x15A")]
	protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
	{
	}

	[Token(Token = "0x6005D63")]
	[Address(RVA = "0xF629E0", Offset = "0xF617E0", Length = "0xE4")]
	public DynamicOcclusionDepthBuffer()
	{
	}
}

using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB;

[Token(Token = "0x2000BE7")]
public static class SRPHelper
{
	[Token(Token = "0x2000BE8")]
	public enum RenderPipeline
	{
		[Token(Token = "0x4007990")]
		Undefined,
		[Token(Token = "0x4007991")]
		BuiltIn,
		[Token(Token = "0x4007992")]
		URP,
		[Token(Token = "0x4007993")]
		LWRP,
		[Token(Token = "0x4007994")]
		HDRP
	}

	[Token(Token = "0x400798E")]
	private static RenderPipeline m_RenderPipelineCached;

	[Token(Token = "0x170003E8")]
	public static RenderPipeline renderPipelineType
	{
		[Token(Token = "0x6005DC5")]
		[Address(RVA = "0xF6A6E0", Offset = "0xF694E0", Length = "0x6B")]
		get
		{
			return default(RenderPipeline);
		}
	}

	[Token(Token = "0x6005DC6")]
	[Address(RVA = "0xF6A750", Offset = "0xF69550", Length = "0x1C6")]
	private static RenderPipeline ComputeRenderPipeline()
	{
		return default(RenderPipeline);
	}

	[Token(Token = "0x6005DC7")]
	[Address(RVA = "0xF6A920", Offset = "0xF69720", Length = "0x176")]
	public static bool IsUsingCustomRenderPipeline()
	{
		return false;
	}

	[Token(Token = "0x6005DC8")]
	[Address(RVA = "0xF6AAA0", Offset = "0xF698A0", Length = "0x69")]
	public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}

	[Token(Token = "0x6005DC9")]
	[Address(RVA = "0xF6AB10", Offset = "0xF69910", Length = "0x5F")]
	public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}
}

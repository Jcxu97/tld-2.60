using Cpp2ILInjected;
using UnityEngine;

namespace VLB;

[Token(Token = "0x2000BB7")]
public static class BatchingHelper
{
	[Token(Token = "0x4007844")]
	public const bool isGpuInstancingSupported = true;

	[Token(Token = "0x170003BA")]
	public static bool forceEnableDepthBlend
	{
		[Token(Token = "0x6005CEE")]
		[Address(RVA = "0xF59880", Offset = "0xF58680", Length = "0xC0")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6005CEF")]
	[Address(RVA = "0xF59950", Offset = "0xF58750", Length = "0x19")]
	public static bool IsGpuInstancingEnabled(Material material)
	{
		return false;
	}

	[Token(Token = "0x6005CF0")]
	[Address(RVA = "0xF59970", Offset = "0xF58770", Length = "0x1A")]
	public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
	{
	}

	[Token(Token = "0x6005CF1")]
	[Address(RVA = "0xF59990", Offset = "0xF58790", Length = "0x8D1")]
	public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
	{
		return false;
	}

	[Token(Token = "0x6005CF2")]
	[Address(RVA = "0xF5A270", Offset = "0xF59070", Length = "0x293")]
	public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
	{
		return false;
	}

	[Token(Token = "0x6005CF3")]
	[Address(RVA = "0xF5A510", Offset = "0xF59310", Length = "0x17E")]
	private static void AppendErrorMessage(ref string message, string toAppend)
	{
	}
}

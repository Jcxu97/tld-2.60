using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[Token(Token = "0x20008E1")]
internal struct JobVisUtils
{
	[Token(Token = "0x20008E2")]
	public enum PlaneTestResult
	{
		[Token(Token = "0x4005D05")]
		Front,
		[Token(Token = "0x4005D06")]
		Back,
		[Token(Token = "0x4005D07")]
		Intersect
	}

	[Token(Token = "0x20008E3")]
	public enum FrustumPlanesId
	{
		[Token(Token = "0x4005D09")]
		Left,
		[Token(Token = "0x4005D0A")]
		Right,
		[Token(Token = "0x4005D0B")]
		Bottom,
		[Token(Token = "0x4005D0C")]
		Top,
		[Token(Token = "0x4005D0D")]
		Near,
		[Token(Token = "0x4005D0E")]
		Far,
		[Token(Token = "0x4005D0F")]
		None
	}

	[Token(Token = "0x20008E4")]
	public enum FrustumPointsId
	{
		[Token(Token = "0x4005D11")]
		FarBottomLeft,
		[Token(Token = "0x4005D12")]
		FarTopLeft,
		[Token(Token = "0x4005D13")]
		FarTopRight,
		[Token(Token = "0x4005D14")]
		FarBottomRight,
		[Token(Token = "0x4005D15")]
		NearBottomLeft,
		[Token(Token = "0x4005D16")]
		NearTopLeft,
		[Token(Token = "0x4005D17")]
		NearTopRight,
		[Token(Token = "0x4005D18")]
		NearBottomRight
	}

	[Token(Token = "0x4005D02")]
	private static readonly FrustumPointsId[,,] frustumCornersTable;

	[Token(Token = "0x4005D03")]
	private static readonly FrustumPlanesId[,] frustumNeighborTable;

	[Token(Token = "0x60051A7")]
	[Address(RVA = "0xE2FA20", Offset = "0xE2E820", Length = "0x110")]
	public static bool FrustrumDotJob(float4 pointPos, float4 camPos, float4 camDir)
	{
		return false;
	}

	[Token(Token = "0x60051A8")]
	[Address(RVA = "0xE2FB30", Offset = "0xE2E930", Length = "0xB5")]
	public static bool FrustumCamera(Bounds bounds, ref NativeArray<Plane> frustumPlanes, bool testShadows, ref NativeArray<Plane> lightPlanes, int lightPlanesCount)
	{
		return false;
	}

	[Token(Token = "0x60051A9")]
	[Address(RVA = "0xE2FBF0", Offset = "0xE2E9F0", Length = "0xB1")]
	private static FrustumPointsId GetCorner(FrustumPlanesId _fpPlanea, FrustumPlanesId _fpPlaneab, int index)
	{
		return default(FrustumPointsId);
	}

	[Token(Token = "0x60051AA")]
	[Address(RVA = "0xE2FCB0", Offset = "0xE2EAB0", Length = "0x94")]
	private static FrustumPlanesId GetNeighbor(FrustumPlanesId _fpPlane, int index)
	{
		return default(FrustumPlanesId);
	}

	[Token(Token = "0x60051AB")]
	[Address(RVA = "0xE2FD50", Offset = "0xE2EB50", Length = "0xBC")]
	private static PlaneTestResult TestPlaneAABB(ref Bounds bounds, ref Plane plane)
	{
		return default(PlaneTestResult);
	}

	[Token(Token = "0x60051AC")]
	[Address(RVA = "0xE2FE10", Offset = "0xE2EC10", Length = "0x173")]
	private static bool TestPlanesAABBInternal(ref NativeArray<Plane> planes, int planesCount, ref Bounds bounds)
	{
		return false;
	}

	[Token(Token = "0x60051AD")]
	[Address(RVA = "0xE2FF90", Offset = "0xE2ED90", Length = "0x446")]
	public static int UpdateDirectionalLightCullingPlanes(Vector3 lightDirection, Plane[] frustumPlanes, ref Plane[] lightPlanes, Vector3[] corners)
	{
		return 0;
	}
}

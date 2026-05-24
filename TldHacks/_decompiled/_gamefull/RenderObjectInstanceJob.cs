using Cpp2ILInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[BurstCompile(FloatPrecision = FloatPrecision.Medium, FloatMode = FloatMode.Fast)]
[Token(Token = "0x20008EF")]
public struct RenderObjectInstanceJob : IJobFor
{
	[ReadOnly]
	[Token(Token = "0x4005D94")]
	[FieldOffset(Offset = "0x0")]
	public float4 m_CameraPosition;

	[ReadOnly]
	[Token(Token = "0x4005D95")]
	[FieldOffset(Offset = "0x10")]
	public float4 m_ViewDirection;

	[ReadOnly]
	[Token(Token = "0x4005D96")]
	[FieldOffset(Offset = "0x20")]
	public float m_Lod1Near;

	[ReadOnly]
	[Token(Token = "0x4005D97")]
	[FieldOffset(Offset = "0x24")]
	public float m_Lod1Far;

	[ReadOnly]
	[Token(Token = "0x4005D98")]
	[FieldOffset(Offset = "0x28")]
	public float m_Lod2Near;

	[ReadOnly]
	[Token(Token = "0x4005D99")]
	[FieldOffset(Offset = "0x2C")]
	public float m_Lod2Far;

	[ReadOnly]
	[Token(Token = "0x4005D9A")]
	[FieldOffset(Offset = "0x30")]
	public float m_CullFar;

	[ReadOnly]
	[Token(Token = "0x4005D9B")]
	[FieldOffset(Offset = "0x34")]
	public bool m_NoLod0Cull;

	[ReadOnly]
	[Token(Token = "0x4005D9C")]
	[FieldOffset(Offset = "0x35")]
	public bool m_UseCameraFrustum;

	[ReadOnly]
	[Token(Token = "0x4005D9D")]
	[FieldOffset(Offset = "0x38")]
	public int m_JobLightPlanesCount;

	[ReadOnly]
	[Token(Token = "0x4005D9E")]
	[FieldOffset(Offset = "0x40")]
	public NativeArray<Plane> m_JobCameraPlanes;

	[ReadOnly]
	[Token(Token = "0x4005D9F")]
	[FieldOffset(Offset = "0x50")]
	public NativeArray<Plane> m_JobLightPlanes;

	[ReadOnly]
	[Token(Token = "0x4005DA0")]
	[FieldOffset(Offset = "0x60")]
	public NativeArray<int> m_BatchObjectCounts;

	[ReadOnly]
	[Token(Token = "0x4005DA1")]
	[FieldOffset(Offset = "0x70")]
	public NativeArray<int> m_BatchStartIndexes;

	[ReadOnly]
	[Token(Token = "0x4005DA2")]
	[FieldOffset(Offset = "0x80")]
	public NativeArray<int> m_BatchLodMasks;

	[ReadOnly]
	[Token(Token = "0x4005DA3")]
	[FieldOffset(Offset = "0x90")]
	public NativeArray<bool> m_BatchCastsShadows;

	[NativeDisableContainerSafetyRestriction]
	[Token(Token = "0x4005DA4")]
	[FieldOffset(Offset = "0xA0")]
	public NativeArray<int> m_BatchVisibleCounts;

	[ReadOnly]
	[Token(Token = "0x4005DA5")]
	[FieldOffset(Offset = "0xB0")]
	public NativeArray<float4> m_ObjectPositions;

	[ReadOnly]
	[Token(Token = "0x4005DA6")]
	[FieldOffset(Offset = "0xC0")]
	public NativeArray<Bounds> m_ObjectBounds;

	[NativeDisableContainerSafetyRestriction]
	[Token(Token = "0x4005DA7")]
	[FieldOffset(Offset = "0xD0")]
	public NativeArray<int> m_ObjectVisibleIndexes;

	[Token(Token = "0x60051FF")]
	[Address(RVA = "0xE3A0D0", Offset = "0xE38ED0", Length = "0x314")]
	public void Execute(int index)
	{
	}
}

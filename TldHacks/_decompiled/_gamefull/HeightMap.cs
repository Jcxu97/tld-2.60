using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using TLD.WeatherParticle;
using Unity.Collections;
using UnityEngine;

[Token(Token = "0x20002FE")]
public class HeightMap : ScriptableObject
{
	[Token(Token = "0x4001A68")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector3 m_MinBounds;

	[Token(Token = "0x4001A69")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public Vector3 m_MaxBounds;

	[Token(Token = "0x4001A6A")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public int m_Spacing;

	[Token(Token = "0x4001A6B")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float[] m_Heights;

	[NonSerialized]
	[Token(Token = "0x4001A6C")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Vector3 m_ActiveMinBounds;

	[NonSerialized]
	[Token(Token = "0x4001A6D")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public Vector3 m_ActiveMaxBounds;

	[Token(Token = "0x4001A6E")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private Bounds m_Bounds;

	[NonSerialized]
	[Token(Token = "0x4001A6F")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public int m_Stride;

	[Token(Token = "0x4001A70")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	private float m_SpacingScalar;

	[Token(Token = "0x4001A71")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private NativeArray<float> m_HeightsNativeArray;

	[Token(Token = "0x4001A72")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	private GCHandle m_GCHandle;

	[Token(Token = "0x170001F7")]
	public float Width
	{
		[Token(Token = "0x60018A1")]
		[Address(RVA = "0x6F51A0", Offset = "0x6F3FA0", Length = "0x16")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x170001F8")]
	public float Height
	{
		[Token(Token = "0x60018A2")]
		[Address(RVA = "0x6F51C0", Offset = "0x6F3FC0", Length = "0x1E")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x60018A3")]
	[Address(RVA = "0x6F51E0", Offset = "0x6F3FE0", Length = "0x336")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60018A4")]
	[Address(RVA = "0x6F5520", Offset = "0x6F4320", Length = "0xEA")]
	public float GetHeight(Vector3 p)
	{
		return 0f;
	}

	[Token(Token = "0x60018A5")]
	[Address(RVA = "0x6F5610", Offset = "0x6F4410", Length = "0x89")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60018A6")]
	[Address(RVA = "0x6F56A0", Offset = "0x6F44A0", Length = "0xB")]
	public NativeArray<float> GetHeightsNativeArray()
	{
		return default(NativeArray<float>);
	}

	[Token(Token = "0x60018A7")]
	[Address(RVA = "0x6F56B0", Offset = "0x6F44B0", Length = "0x41")]
	public ParticleCollisionHeightMapInfo GetInfo()
	{
		return default(ParticleCollisionHeightMapInfo);
	}

	[Token(Token = "0x60018A8")]
	[Address(RVA = "0x6F5610", Offset = "0x6F4410", Length = "0x89")]
	private void DisposeHeightsNativeArray()
	{
	}

	[Token(Token = "0x60018A9")]
	[Address(RVA = "0x6F5700", Offset = "0x6F4500", Length = "0x86")]
	private void AllocateHeightsNativeArray()
	{
	}

	[Token(Token = "0x60018AA")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public HeightMap()
	{
	}
}

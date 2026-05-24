using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000407")]
public class TravoisStampingManager : MonoBehaviour
{
	[Token(Token = "0x4002476")]
	[FieldOffset(Offset = "0x20")]
	public Material m_StampingBlitMaterial;

	[Token(Token = "0x4002477")]
	[FieldOffset(Offset = "0x28")]
	public float m_StampingAreaWorldSizeLow;

	[Token(Token = "0x4002478")]
	[FieldOffset(Offset = "0x2C")]
	public int m_StampingTextureResolutionLow;

	[Token(Token = "0x4002479")]
	[FieldOffset(Offset = "0x30")]
	public float m_StampingAreaWorldSizeMedium;

	[Token(Token = "0x400247A")]
	[FieldOffset(Offset = "0x34")]
	public int m_StampingTextureResolutionMedium;

	[Token(Token = "0x400247B")]
	[FieldOffset(Offset = "0x38")]
	public float m_StampingAreaWorldSizeHigh;

	[Token(Token = "0x400247C")]
	[FieldOffset(Offset = "0x3C")]
	public int m_StampingTextureResolutionHigh;

	[Token(Token = "0x400247D")]
	[FieldOffset(Offset = "0x40")]
	public float m_StampingAreaWorldSizeUltra;

	[Token(Token = "0x400247E")]
	[FieldOffset(Offset = "0x44")]
	public int m_StampingTextureResolutionUltra;

	[Token(Token = "0x400247F")]
	[FieldOffset(Offset = "0x48")]
	public float m_StampingAreaWorldSizeXboxOne;

	[Token(Token = "0x4002480")]
	[FieldOffset(Offset = "0x4C")]
	public int m_StampingTextureResolutionXboxOne;

	[Token(Token = "0x4002481")]
	[FieldOffset(Offset = "0x50")]
	public float m_StampingAreaWorldSizePS4;

	[Token(Token = "0x4002482")]
	[FieldOffset(Offset = "0x54")]
	public int m_StampingTextureResolutionPS4;

	[Token(Token = "0x4002483")]
	[FieldOffset(Offset = "0x58")]
	public float m_StampingAreaWorldSizeSwitch;

	[Token(Token = "0x4002484")]
	[FieldOffset(Offset = "0x5C")]
	public int m_StampingTextureResolutionSwitch;

	[Token(Token = "0x4002485")]
	[FieldOffset(Offset = "0x60")]
	public float m_StampingAreaWorldSizeSwitchBoost;

	[Token(Token = "0x4002486")]
	[FieldOffset(Offset = "0x64")]
	public int m_StampingTextureResolutionSwitchBoost;

	[Min(0.1f)]
	[Token(Token = "0x4002487")]
	[FieldOffset(Offset = "0x68")]
	public float m_DefaultStampRadius;

	[Token(Token = "0x4002488")]
	[FieldOffset(Offset = "0x6C")]
	public float m_DistanceBetweenSideStamps;

	[Token(Token = "0x4002489")]
	[FieldOffset(Offset = "0x70")]
	public float m_DistanceFromPlayer;

	[Token(Token = "0x400248A")]
	[FieldOffset(Offset = "0x74")]
	public float m_LocalSnowDifferenceMultiplier;

	[Token(Token = "0x400248B")]
	[FieldOffset(Offset = "0x78")]
	public float m_StampingVerticalDistanceCutoff;

	[Token(Token = "0x400248C")]
	[FieldOffset(Offset = "0x80")]
	private RenderTexture m_StampingTarget0;

	[Token(Token = "0x400248D")]
	[FieldOffset(Offset = "0x88")]
	private RenderTexture m_StampingTarget1;

	[Token(Token = "0x400248E")]
	[FieldOffset(Offset = "0x90")]
	private readonly int m_StampingSourceTextureID;

	[Token(Token = "0x400248F")]
	[FieldOffset(Offset = "0x94")]
	private readonly int m_StampingTargetTextureID;

	[Token(Token = "0x4002490")]
	[FieldOffset(Offset = "0x98")]
	private readonly int m_StampingBufferID;

	[Token(Token = "0x4002491")]
	[FieldOffset(Offset = "0x9C")]
	private readonly int m_StampingBufferCountID;

	[Token(Token = "0x4002492")]
	[FieldOffset(Offset = "0xA0")]
	private readonly int m_StampingWorldOffsetID;

	[Token(Token = "0x4002493")]
	[FieldOffset(Offset = "0xA4")]
	private readonly int m_StampingWorldPreviousOffsetID;

	[Token(Token = "0x4002494")]
	[FieldOffset(Offset = "0xA8")]
	private readonly int m_StampingWorldUVScaleID;

	[Token(Token = "0x4002495")]
	[FieldOffset(Offset = "0xAC")]
	private readonly int m_StampingVerticalDistanceCutoffID;

	[Token(Token = "0x4002496")]
	[FieldOffset(Offset = "0xB0")]
	private readonly int m_StampingClearTargetsID;

	[Token(Token = "0x4002497")]
	[FieldOffset(Offset = "0xB4")]
	private readonly int m_LocalSnowDepthDifference;

	[Token(Token = "0x4002498")]
	[FieldOffset(Offset = "0xB8")]
	private readonly int m_StampingEnabledID;

	[Token(Token = "0x4002499")]
	[FieldOffset(Offset = "0xC0")]
	private ComputeBuffer m_StampingBuffer;

	[Token(Token = "0x400249A")]
	[FieldOffset(Offset = "0xC8")]
	private readonly List<Vector4> m_StampingData;

	[Token(Token = "0x400249B")]
	[FieldOffset(Offset = "0xD0")]
	private Vector3 m_StampingWorldPreviousOffset;

	[Token(Token = "0x400249C")]
	[FieldOffset(Offset = "0xDC")]
	private bool m_ClearTargetsThisFrame;

	[Token(Token = "0x400249D")]
	[FieldOffset(Offset = "0xE0")]
	private float m_PreviousSnowDepth;

	[Token(Token = "0x400249E")]
	[FieldOffset(Offset = "0xE4")]
	private float m_StampingAreaWorldSize;

	[Token(Token = "0x400249F")]
	[FieldOffset(Offset = "0xE8")]
	private int m_StampingTextureResolution;

	[Token(Token = "0x40024A0")]
	private static TravoisStampingGlobalData m_GlobalData;

	[Token(Token = "0x6001EAE")]
	[Address(RVA = "0x7C8C20", Offset = "0x7C7A20", Length = "0x48C")]
	private void UpdateQualityLevel()
	{
	}

	[Token(Token = "0x6001EAF")]
	[Address(RVA = "0x7C90D0", Offset = "0x7C7ED0", Length = "0x282")]
	public void AfterGlobalDeserialize()
	{
	}

	[Token(Token = "0x6001EB0")]
	[Address(RVA = "0x7C9360", Offset = "0x7C8160", Length = "0x2B6")]
	private void StoreGlobalData()
	{
	}

	[Token(Token = "0x6001EB1")]
	[Address(RVA = "0x7C9620", Offset = "0x7C8420", Length = "0x188")]
	private void LoadGlobalData()
	{
	}

	[Token(Token = "0x6001EB2")]
	[Address(RVA = "0x7C97B0", Offset = "0x7C85B0", Length = "0x1D2")]
	private void Start()
	{
	}

	[Token(Token = "0x6001EB3")]
	[Address(RVA = "0x7C9990", Offset = "0x7C8790", Length = "0x68")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001EB4")]
	[Address(RVA = "0x7C9A00", Offset = "0x7C8800", Length = "0x885")]
	private void Update()
	{
	}

	[Token(Token = "0x6001EB5")]
	[Address(RVA = "0x7CA290", Offset = "0x7C9090", Length = "0x102")]
	public void StampTravoisTrail(Vector3 position, float radius)
	{
	}

	[Token(Token = "0x6001EB6")]
	[Address(RVA = "0x7CA3A0", Offset = "0x7C91A0", Length = "0x358")]
	public TravoisStampingManager()
	{
	}
}

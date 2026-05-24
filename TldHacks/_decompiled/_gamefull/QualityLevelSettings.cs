using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20007BF")]
public class QualityLevelSettings
{
	[Token(Token = "0x4005355")]
	[FieldOffset(Offset = "0x10")]
	public bool m_ShadowsEnabled;

	[Token(Token = "0x4005356")]
	[FieldOffset(Offset = "0x14")]
	public QualityShadows m_ShadowQuality;

	[Token(Token = "0x4005357")]
	[FieldOffset(Offset = "0x18")]
	public ShadowResolution m_ShadowResolution;

	[Token(Token = "0x4005358")]
	[FieldOffset(Offset = "0x1C")]
	public QualityPostFx m_PostFxQuality;

	[Token(Token = "0x4005359")]
	[FieldOffset(Offset = "0x20")]
	public QualityAntiAliasing m_AntiAliasingQuality;

	[Token(Token = "0x400535A")]
	[FieldOffset(Offset = "0x24")]
	public QualityMotionBlur m_MotionBlurQuality;

	[Token(Token = "0x400535B")]
	[FieldOffset(Offset = "0x28")]
	public QualityFootprints m_FootprintsQuality;

	[Token(Token = "0x400535C")]
	[FieldOffset(Offset = "0x2C")]
	public QualitySSAO m_SSAO;

	[Token(Token = "0x400535D")]
	[FieldOffset(Offset = "0x30")]
	public QualityAnisotropy m_Anisotropy;

	[Token(Token = "0x400535E")]
	[FieldOffset(Offset = "0x34")]
	public QualityLodBias m_LodBiasQuality;

	[Token(Token = "0x400535F")]
	[FieldOffset(Offset = "0x38")]
	public QualityTerrainLod m_TerrainLodQuality;

	[Token(Token = "0x4005360")]
	[FieldOffset(Offset = "0x3C")]
	public bool m_AmbientEffectsEnabled;

	[Token(Token = "0x4005361")]
	[FieldOffset(Offset = "0x3D")]
	public bool m_AdditionalShadowsStructuresEnabled;

	[Token(Token = "0x4005362")]
	[FieldOffset(Offset = "0x3E")]
	public bool m_AdditionalShadowsTerrainEnabled;

	[Token(Token = "0x4005363")]
	[FieldOffset(Offset = "0x3F")]
	public bool m_TerrainBlendingEnabled;

	[Token(Token = "0x4005364")]
	[FieldOffset(Offset = "0x40")]
	public int m_MasterTextureLimit;

	[Token(Token = "0x4005365")]
	[FieldOffset(Offset = "0x44")]
	public bool m_TextureStreamingEnabled;

	[Token(Token = "0x4005366")]
	[FieldOffset(Offset = "0x48")]
	public int m_TextureStreamingBudget;

	[Range(0.5f, 2f)]
	[Token(Token = "0x4005367")]
	[FieldOffset(Offset = "0x4C")]
	public float m_RockDrawDistance;

	[Range(0.5f, 2f)]
	[Token(Token = "0x4005368")]
	[FieldOffset(Offset = "0x50")]
	public float m_SceneDrawDistance;

	[Range(20f, 250f)]
	[Token(Token = "0x4005369")]
	[FieldOffset(Offset = "0x54")]
	public float m_ShadowDrawDistance;

	[Range(0.5f, 2f)]
	[Token(Token = "0x400536A")]
	[FieldOffset(Offset = "0x58")]
	public float m_TreeDrawDistance;

	[Range(20f, 250f)]
	[Token(Token = "0x400536B")]
	[FieldOffset(Offset = "0x5C")]
	public float m_GroundDetailsDrawDistance;

	[Range(0f, 100f)]
	[Token(Token = "0x400536C")]
	[FieldOffset(Offset = "0x60")]
	public float m_GroundDetailsDensity;

	[Token(Token = "0x600493A")]
	[Address(RVA = "0xD16830", Offset = "0xD15630", Length = "0xF")]
	public QualityLevelSettings()
	{
	}
}

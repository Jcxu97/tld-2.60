using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Scenes;
using UnityEngine;

namespace TLD.Gameplay.Challenges.DarkWalker;

[CreateAssetMenu(menuName = "The Long Dark/Gameplay/Challenges/Toxic Fog Config")]
[Token(Token = "0x20014A8")]
public class ToxicFogConfig : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20014A9")]
	public class SceneSetTunables
	{
		[Token(Token = "0x4009593")]
		[FieldOffset(Offset = "0x10")]
		public SceneSet m_SceneSet;

		[Range(0f, 600f)]
		[Token(Token = "0x4009594")]
		[FieldOffset(Offset = "0x18")]
		public float m_TimeToFillUpToMaximumMinutes;

		[Token(Token = "0x60082E8")]
		[Address(RVA = "0x123FC10", Offset = "0x123EA10", Length = "0x8")]
		public SceneSetTunables()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20014AA")]
	public class IndicatorLevels
	{
		[Range(0f, 1f)]
		[Token(Token = "0x4009595")]
		[FieldOffset(Offset = "0x10")]
		public float m_Level1;

		[Range(0f, 1f)]
		[Token(Token = "0x4009596")]
		[FieldOffset(Offset = "0x14")]
		public float m_Level2;

		[Range(0f, 1f)]
		[Token(Token = "0x4009597")]
		[FieldOffset(Offset = "0x18")]
		public float m_Level3;

		[Token(Token = "0x60082E9")]
		[Address(RVA = "0x123FC20", Offset = "0x123EA20", Length = "0x16")]
		public IndicatorLevels()
		{
		}
	}

	[Header("Gameplay Default Tweakables")]
	[Range(0f, 600f)]
	[Token(Token = "0x4009589")]
	[FieldOffset(Offset = "0x18")]
	public float m_TimeToFillUpToMaximumMinutes;

	[Tooltip("Scales how fast the accelerated time applies to the toxic fog accumulation. Values above 1 speed up the accumulation, values below slow it down, while passing time.")]
	[Range(0.01f, 10f)]
	[Token(Token = "0x400958A")]
	[FieldOffset(Offset = "0x1C")]
	public float m_TimePassingScalar;

	[Token(Token = "0x400958B")]
	[FieldOffset(Offset = "0x20")]
	public List<SceneSetTunables> m_SceneTunables;

	[Range(0f, 1f)]
	[Token(Token = "0x400958C")]
	[FieldOffset(Offset = "0x28")]
	public float m_FogScaleToRuinFood;

	[Range(0f, 1f)]
	[Token(Token = "0x400958D")]
	[FieldOffset(Offset = "0x2C")]
	public float m_FogScaleToKillAllWildlife;

	[Range(0f, 1f)]
	[Token(Token = "0x400958E")]
	[FieldOffset(Offset = "0x30")]
	public float m_FogScaleToReduceCondition;

	[Range(0f, 1f)]
	[Token(Token = "0x400958F")]
	[FieldOffset(Offset = "0x34")]
	public float m_FogReductionOnDispelFogGlyph;

	[Header("Visual Fog")]
	[Range(0.0001f, 1000f)]
	[Token(Token = "0x4009590")]
	[FieldOffset(Offset = "0x38")]
	public float m_MinimumFogScale;

	[Range(0.1f, 1000f)]
	[Token(Token = "0x4009591")]
	[FieldOffset(Offset = "0x3C")]
	public float m_MaximumFogScale;

	[Token(Token = "0x4009592")]
	[FieldOffset(Offset = "0x40")]
	public IndicatorLevels m_ToxicFogIndicatorTunables;

	[Token(Token = "0x60082E6")]
	[Address(RVA = "0x123FBB0", Offset = "0x123E9B0", Length = "0x14")]
	public float GetAdjustedFogScale(float fogScale)
	{
		return 0f;
	}

	[Token(Token = "0x60082E7")]
	[Address(RVA = "0x123FBD0", Offset = "0x123E9D0", Length = "0x3F")]
	public ToxicFogConfig()
	{
	}
}

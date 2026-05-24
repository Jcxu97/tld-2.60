using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000309")]
public class LodBiasLocal : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200030A")]
	public struct SceneDefinition
	{
		[Tooltip("The scenes where to apply the local LOD bias.")]
		[Token(Token = "0x4001AA1")]
		[FieldOffset(Offset = "0x0")]
		public List<string> m_ScenesList;

		[Tooltip("Multiplier... Smaller values will push LODs out further, larger values will pull LODs in closer.")]
		[Range(0.1f, 5f)]
		[Token(Token = "0x4001AA2")]
		[FieldOffset(Offset = "0x8")]
		public float m_LodMultiplier;
	}

	[Token(Token = "0x200030B")]
	public enum QualityLimits
	{
		[Token(Token = "0x4001AA4")]
		All,
		[Token(Token = "0x4001AA5")]
		Desktops,
		[Token(Token = "0x4001AA6")]
		Consoles
	}

	[Token(Token = "0x4001A9B")]
	[FieldOffset(Offset = "0x20")]
	public QualityLimits m_QualityLimits;

	[Tooltip("Multiplier... Smaller values will push LODs out further, larger values will pull LODs in closer.")]
	[Range(0.1f, 5f)]
	[Token(Token = "0x4001A9C")]
	[FieldOffset(Offset = "0x24")]
	public float m_LodMultiplier;

	[Tooltip("The scenes where to apply the local LOD bias.")]
	[Token(Token = "0x4001A9D")]
	[FieldOffset(Offset = "0x28")]
	public string[] m_Scenes;

	[Tooltip("Define different LOD biases for different scenes.")]
	[Token(Token = "0x4001A9E")]
	[FieldOffset(Offset = "0x30")]
	public List<SceneDefinition> m_SceneDefs;

	[Tooltip("If \"true\", the multiplier will only affect the culling distance. If \"false\", all LOD values will be changed.")]
	[Token(Token = "0x4001A9F")]
	[FieldOffset(Offset = "0x38")]
	public bool m_CullingOnly;

	[Token(Token = "0x4001AA0")]
	[FieldOffset(Offset = "0x40")]
	private LODGroup m_LodGroup;

	[Token(Token = "0x60018E3")]
	[Address(RVA = "0x6F78F0", Offset = "0x6F66F0", Length = "0x2E")]
	private void Start()
	{
	}

	[Token(Token = "0x60018E4")]
	[Address(RVA = "0x6F7920", Offset = "0x6F6720", Length = "0xFC5")]
	private void SetBias()
	{
	}

	[Token(Token = "0x60018E5")]
	[Address(RVA = "0x6F88F0", Offset = "0x6F76F0", Length = "0x4E")]
	public LodBiasLocal()
	{
	}
}

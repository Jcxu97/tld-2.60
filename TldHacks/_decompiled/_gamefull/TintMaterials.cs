using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A3C")]
public class TintMaterials : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000A3D")]
	private class Tint
	{
		[Token(Token = "0x40066AA")]
		[FieldOffset(Offset = "0x10")]
		public Color m_RedMask;

		[Token(Token = "0x40066AB")]
		[FieldOffset(Offset = "0x20")]
		public Color m_GreenMask;

		[Token(Token = "0x40066AC")]
		[FieldOffset(Offset = "0x30")]
		public Color m_BlueMask;

		[HideInInspector]
		[Token(Token = "0x40066AD")]
		[FieldOffset(Offset = "0x40")]
		public bool m_DefaultsAssigned;

		[Token(Token = "0x6005939")]
		[Address(RVA = "0xEF4040", Offset = "0xEF2E40", Length = "0x18")]
		public void AssignDefaults()
		{
		}

		[Token(Token = "0x600593A")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public Tint()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x40066A1")]
	[FieldOffset(Offset = "0x20")]
	private Tint[] m_Tints;

	[Tooltip("Use -1 to choose a random tint")]
	[SerializeField]
	[Token(Token = "0x40066A2")]
	[FieldOffset(Offset = "0x28")]
	private int m_IndexToUse;

	[SerializeField]
	[Token(Token = "0x40066A3")]
	[FieldOffset(Offset = "0x30")]
	private string m_TagFilter;

	[Token(Token = "0x40066A4")]
	[FieldOffset(Offset = "0x38")]
	private MaterialPropertyBlock m_PropertyBlock;

	[Token(Token = "0x40066A5")]
	[FieldOffset(Offset = "0x40")]
	private readonly int m_TintColorRPropertyID;

	[Token(Token = "0x40066A6")]
	[FieldOffset(Offset = "0x44")]
	private readonly int m_TintColorGPropertyID;

	[Token(Token = "0x40066A7")]
	[FieldOffset(Offset = "0x48")]
	private readonly int m_TintColorBPropertyID;

	[Token(Token = "0x40066A8")]
	private static readonly List<TintMaterials> s_Instances;

	[Token(Token = "0x40066A9")]
	private static readonly TintMaterialsSaveData s_SaveData;

	[Token(Token = "0x600592E")]
	[Address(RVA = "0xEF2C60", Offset = "0xEF1A60", Length = "0x20E")]
	private void Awake()
	{
	}

	[Token(Token = "0x600592F")]
	[Address(RVA = "0xEF2E70", Offset = "0xEF1C70", Length = "0x7C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005930")]
	[Address(RVA = "0xEF2EF0", Offset = "0xEF1CF0", Length = "0x5B")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6005931")]
	[Address(RVA = "0xEF2F50", Offset = "0xEF1D50", Length = "0x4AC")]
	private void UpdateTint()
	{
	}

	[Token(Token = "0x6005932")]
	[Address(RVA = "0xEF3400", Offset = "0xEF2200", Length = "0x1B0")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6005933")]
	[Address(RVA = "0xEF35C0", Offset = "0xEF23C0", Length = "0x2E")]
	public void Deserialize(TintMaterialsSaveData proxy)
	{
	}

	[Token(Token = "0x6005934")]
	[Address(RVA = "0xEF35F0", Offset = "0xEF23F0", Length = "0x93")]
	public static void ResetInstances()
	{
	}

	[Token(Token = "0x6005935")]
	[Address(RVA = "0xEF3690", Offset = "0xEF2490", Length = "0x465")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6005936")]
	[Address(RVA = "0xEF3B00", Offset = "0xEF2900", Length = "0x2FE")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6005937")]
	[Address(RVA = "0xEF3E00", Offset = "0xEF2C00", Length = "0xC7")]
	public TintMaterials()
	{
	}
}

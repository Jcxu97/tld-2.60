using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using UnityEngine;

namespace TLD.Player;

[Token(Token = "0x200144C")]
public class Nutrition : MonoBehaviour
{
	[Token(Token = "0x40093A7")]
	private static Nutrition s_Instance;

	[Token(Token = "0x40093A9")]
	[FieldOffset(Offset = "0x28")]
	private readonly List<NutrientDefinition> m_Nutrients;

	[Token(Token = "0x40093AA")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<float> m_Amounts;

	[Token(Token = "0x40093AB")]
	[FieldOffset(Offset = "0x38")]
	private readonly List<int> m_LossPerDay;

	[Token(Token = "0x40093AC")]
	[FieldOffset(Offset = "0x40")]
	private readonly List<float> m_LossPerSecond;

	[Token(Token = "0x40093AD")]
	private const float DAY_IN_SECONDS = 86400f;

	[Token(Token = "0x17000B2D")]
	public static Nutrition Instance
	{
		[Token(Token = "0x6008145")]
		[Address(RVA = "0x121A0B0", Offset = "0x1218EB0", Length = "0x3B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B2E")]
	[field: Token(Token = "0x40093A8")]
	[field: FieldOffset(Offset = "0x20")]
	public bool IsInitialized
	{
		[Token(Token = "0x6008146")]
		[Address(RVA = "0x4D3E60", Offset = "0x4D2C60", Length = "0x5")]
		get;
		[Token(Token = "0x6008147")]
		[Address(RVA = "0x4D3E50", Offset = "0x4D2C50", Length = "0x4")]
		set;
	}

	[Token(Token = "0x6008148")]
	[Address(RVA = "0x121A0F0", Offset = "0x1218EF0", Length = "0x126")]
	public bool HasNutritionSettings()
	{
		return false;
	}

	[Token(Token = "0x6008149")]
	[Address(RVA = "0x121A220", Offset = "0x1219020", Length = "0xF6")]
	public void SetValue(NutrientDefinition nutrient, float amount)
	{
	}

	[Token(Token = "0x600814A")]
	[Address(RVA = "0x121A320", Offset = "0x1219120", Length = "0x1E1")]
	public void IncrementValue(NutrientDefinition nutrient, float increment)
	{
	}

	[Token(Token = "0x600814B")]
	[Address(RVA = "0x121A510", Offset = "0x1219310", Length = "0xD0")]
	public float GetValue(NutrientDefinition nutrient)
	{
		return 0f;
	}

	[Token(Token = "0x600814C")]
	[Address(RVA = "0x121A5F0", Offset = "0x12193F0", Length = "0xF9")]
	public float GetMaxValue(NutrientDefinition nutrient)
	{
		return 0f;
	}

	[Token(Token = "0x600814D")]
	[Address(RVA = "0x121A6F0", Offset = "0x12194F0", Length = "0x120")]
	public void SetOverrideLossRate(NutrientDefinition nutrient, int lossPerDay)
	{
	}

	[Token(Token = "0x600814E")]
	[Address(RVA = "0x121A820", Offset = "0x1219620", Length = "0x182")]
	public void RemoveOverrideLossRate(NutrientDefinition nutrient)
	{
	}

	[Token(Token = "0x600814F")]
	[Address(RVA = "0x121A9B0", Offset = "0x12197B0", Length = "0x20D")]
	public NutritionSaveDataGlobal Serialize()
	{
		return null;
	}

	[Token(Token = "0x6008150")]
	[Address(RVA = "0x121ABC0", Offset = "0x12199C0", Length = "0x537")]
	public void Deserialize(NutritionSaveDataGlobal proxy)
	{
	}

	[Token(Token = "0x6008151")]
	[Address(RVA = "0x121B100", Offset = "0x1219F00", Length = "0xB6")]
	private void ResetLists()
	{
	}

	[Token(Token = "0x6008152")]
	[Address(RVA = "0x121B1C0", Offset = "0x1219FC0", Length = "0x272")]
	private void StartTrackingNutrient(NutrientDefinition nutrient, float initialAmount)
	{
	}

	[Token(Token = "0x6008153")]
	[Address(RVA = "0x121B440", Offset = "0x121A240", Length = "0x15D")]
	private void Update()
	{
	}

	[Token(Token = "0x6008154")]
	[Address(RVA = "0x121B5A0", Offset = "0x121A3A0", Length = "0x97")]
	private void Awake()
	{
	}

	[Token(Token = "0x6008155")]
	[Address(RVA = "0x121B640", Offset = "0x121A440", Length = "0x96")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6008156")]
	[Address(RVA = "0x121B6E0", Offset = "0x121A4E0", Length = "0x213")]
	private void UpdateLossPerDay()
	{
	}

	[Token(Token = "0x6008157")]
	[Address(RVA = "0x121B900", Offset = "0x121A700", Length = "0x3B7")]
	public NutrientSettings GetNutrientSettings()
	{
		return null;
	}

	[Token(Token = "0x6008158")]
	[Address(RVA = "0x121BCC0", Offset = "0x121AAC0", Length = "0x28F")]
	public Nutrition()
	{
	}
}

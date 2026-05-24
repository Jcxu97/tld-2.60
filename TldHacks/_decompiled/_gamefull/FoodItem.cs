using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x2000491")]
public class FoodItem : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000492")]
	public class Nutrient
	{
		[Token(Token = "0x40029D2")]
		[FieldOffset(Offset = "0x10")]
		public AssetReferenceNutrientDefinition m_Nutrient;

		[Token(Token = "0x40029D3")]
		[FieldOffset(Offset = "0x18")]
		public int m_Amount;

		[Token(Token = "0x40029D4")]
		[FieldOffset(Offset = "0x20")]
		private AsyncOperationHandle<NutrientDefinition> m_LoadOp;

		[Token(Token = "0x17000223")]
		public NutrientDefinition NutrientDefinition
		{
			[Token(Token = "0x6002287")]
			[Address(RVA = "0x836650", Offset = "0x835450", Length = "0x176")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002288")]
		[Address(RVA = "0x8367D0", Offset = "0x8355D0", Length = "0x73")]
		public int GetConsumedAmount(float normalizedMass)
		{
			return 0;
		}

		[Token(Token = "0x6002289")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public Nutrient()
		{
		}
	}

	[Header("Decay")]
	[Token(Token = "0x40029A9")]
	[FieldOffset(Offset = "0x20")]
	public float m_DailyHPDecayInside;

	[Token(Token = "0x40029AA")]
	[FieldOffset(Offset = "0x24")]
	public float m_DailyHPDecayOutside;

	[Header("Calories")]
	[Token(Token = "0x40029AB")]
	[FieldOffset(Offset = "0x28")]
	public float m_CaloriesRemaining;

	[Token(Token = "0x40029AC")]
	[FieldOffset(Offset = "0x2C")]
	public float m_CaloriesTotal;

	[Header("Eating")]
	[Tooltip("Setting this to true will make a food item only be consumed if the progress bar fills completely, no partial consumption allowed")]
	[Token(Token = "0x40029AD")]
	[FieldOffset(Offset = "0x30")]
	public bool m_MustConsumeAll;

	[Token(Token = "0x40029AE")]
	[FieldOffset(Offset = "0x34")]
	public float m_TimeToEatSeconds;

	[Token(Token = "0x40029AF")]
	[FieldOffset(Offset = "0x38")]
	public float m_TimeToOpenAndEatSeconds;

	[Token(Token = "0x40029B0")]
	[FieldOffset(Offset = "0x3C")]
	public float m_ChanceFoodPoisoning;

	[Tooltip("Low Condition means <20%")]
	[Token(Token = "0x40029B1")]
	[FieldOffset(Offset = "0x40")]
	public float m_ChanceFoodPoisoningLowCondition;

	[Tooltip("Ruined means 0%")]
	[Token(Token = "0x40029B2")]
	[FieldOffset(Offset = "0x44")]
	public float m_ChanceFoodPoisoningRuined;

	[Tooltip("The chance of parasites increases based on how many units you've eaten")]
	[Token(Token = "0x40029B3")]
	[FieldOffset(Offset = "0x48")]
	public float[] m_ParasiteRiskPercentIncrease;

	[SerializeField]
	[HideInInspector]
	[Token(Token = "0x40029B4")]
	[FieldOffset(Offset = "0x50")]
	private List<Nutrient> m_Nutrients;

	[Header("Audio")]
	[Token(Token = "0x40029B5")]
	[FieldOffset(Offset = "0x58")]
	public string m_EatingAudio;

	[Token(Token = "0x40029B6")]
	[FieldOffset(Offset = "0x60")]
	public string m_OpenAndEatingAudio;

	[Header("Properties")]
	[Token(Token = "0x40029B7")]
	[FieldOffset(Offset = "0x68")]
	public bool m_IsDrink;

	[Token(Token = "0x40029B8")]
	[FieldOffset(Offset = "0x69")]
	public bool m_IsMeat;

	[Token(Token = "0x40029B9")]
	[FieldOffset(Offset = "0x6A")]
	public bool m_IsFish;

	[Token(Token = "0x40029BA")]
	[FieldOffset(Offset = "0x6B")]
	public bool m_IsRawMeat;

	[Token(Token = "0x40029BB")]
	[FieldOffset(Offset = "0x6C")]
	public bool m_IsNatural;

	[Token(Token = "0x40029BC")]
	[FieldOffset(Offset = "0x6D")]
	public bool m_IsFat;

	[Header("Cooking")]
	[Token(Token = "0x40029BD")]
	[FieldOffset(Offset = "0x6E")]
	public bool m_StayHeatedUntilInteraction;

	[Token(Token = "0x40029BE")]
	[FieldOffset(Offset = "0x6F")]
	public bool m_HeatedWhenCooked;

	[Range(0f, 100f)]
	[Token(Token = "0x40029BF")]
	[FieldOffset(Offset = "0x70")]
	public float m_PercentHeatLossPerMinuteIndoors;

	[Range(0f, 100f)]
	[Token(Token = "0x40029C0")]
	[FieldOffset(Offset = "0x74")]
	public float m_PercentHeatLossPerMinuteOutdoors;

	[Header("Misc")]
	[Token(Token = "0x40029C1")]
	[FieldOffset(Offset = "0x78")]
	public float m_ReduceThirst;

	[Token(Token = "0x40029C2")]
	[FieldOffset(Offset = "0x7C")]
	public bool m_Packaged;

	[Token(Token = "0x40029C3")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_GearPrefabHarvestAfterFinishEatingNormal;

	[Token(Token = "0x40029C4")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_GearPrefabHarvestAfterFinishEatingSmashed;

	[HideInInspector]
	[Token(Token = "0x40029C5")]
	[FieldOffset(Offset = "0x90")]
	public bool m_Opened;

	[HideInInspector]
	[Token(Token = "0x40029C6")]
	[FieldOffset(Offset = "0x91")]
	public bool m_GearRequiredToOpen;

	[HideInInspector]
	[Token(Token = "0x40029C7")]
	[FieldOffset(Offset = "0x92")]
	public bool m_OpenedWithCanOpener;

	[HideInInspector]
	[Token(Token = "0x40029C8")]
	[FieldOffset(Offset = "0x93")]
	public bool m_OpenedWithKnife;

	[HideInInspector]
	[Token(Token = "0x40029C9")]
	[FieldOffset(Offset = "0x94")]
	public bool m_OpenedWithHatchet;

	[HideInInspector]
	[Token(Token = "0x40029CA")]
	[FieldOffset(Offset = "0x98")]
	public float m_HeatPercent;

	[HideInInspector]
	[Token(Token = "0x40029CB")]
	[FieldOffset(Offset = "0x9C")]
	public bool m_ReturnToCookingAfterOpen;

	[HideInInspector]
	[Token(Token = "0x40029CC")]
	[FieldOffset(Offset = "0xA0")]
	public int m_NumTimesHeatedUp;

	[HideInInspector]
	[Token(Token = "0x40029CD")]
	[FieldOffset(Offset = "0xA4")]
	public GearMeatTypeEnum m_MeatType;

	[Token(Token = "0x40029CE")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_HarvestedByPlayer;

	[Token(Token = "0x40029CF")]
	[FieldOffset(Offset = "0xB0")]
	private GearItem m_GearItem;

	[Token(Token = "0x40029D0")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_PreventHeatLoss;

	[Token(Token = "0x40029D1")]
	private static FoodItemSaveDataProxy m_FoodItemSaveDataProxy;

	[Token(Token = "0x6002275")]
	[Address(RVA = "0x835110", Offset = "0x833F10", Length = "0x94")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002276")]
	[Address(RVA = "0x8351B0", Offset = "0x833FB0", Length = "0x13F")]
	public void UpdateHeatPercent(float gameMinutes)
	{
	}

	[Token(Token = "0x6002277")]
	[Address(RVA = "0x8352F0", Offset = "0x8340F0", Length = "0x8")]
	public bool IsPreventHeatLossEnabled()
	{
		return false;
	}

	[Token(Token = "0x6002278")]
	[Address(RVA = "0x7A86D0", Offset = "0x7A74D0", Length = "0x7")]
	public void SetPreventHeatLoss(bool shouldPrevent)
	{
	}

	[Token(Token = "0x6002279")]
	[Address(RVA = "0x835300", Offset = "0x834100", Length = "0x22B")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600227A")]
	[Address(RVA = "0x835530", Offset = "0x834330", Length = "0x16C")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600227B")]
	[Address(RVA = "0x8356A0", Offset = "0x8344A0", Length = "0x12")]
	public bool IsHot()
	{
		return false;
	}

	[Token(Token = "0x600227C")]
	[Address(RVA = "0x8356C0", Offset = "0x8344C0", Length = "0xD0")]
	public string GetTemperatureTextForInspectMode()
	{
		return null;
	}

	[Token(Token = "0x600227D")]
	[Address(RVA = "0x835790", Offset = "0x834590", Length = "0xD0")]
	public string GetTemperatureTextPostfix()
	{
		return null;
	}

	[Token(Token = "0x600227E")]
	[Address(RVA = "0x835860", Offset = "0x834660", Length = "0x8")]
	public void MarkAsHarvested()
	{
	}

	[Token(Token = "0x600227F")]
	[Address(RVA = "0x835870", Offset = "0x834670", Length = "0x8")]
	public bool WasHarvested()
	{
		return false;
	}

	[Token(Token = "0x6002280")]
	[Address(RVA = "0x835880", Offset = "0x834680", Length = "0xD6")]
	public void CopyHarvestedState(FoodItem fi)
	{
	}

	[Token(Token = "0x6002281")]
	[Address(RVA = "0x835960", Offset = "0x834760", Length = "0x133")]
	public float GetDailyHPDecay()
	{
		return 0f;
	}

	[Token(Token = "0x6002282")]
	[Address(RVA = "0x835AA0", Offset = "0x8348A0", Length = "0x3A2")]
	public void ApplyNutrition(float fractionOfBaseMass)
	{
	}

	[Token(Token = "0x6002283")]
	[Address(RVA = "0x835E50", Offset = "0x834C50", Length = "0x2B7")]
	public string GetVitaminCAmountString(float fractionOfBaseMass)
	{
		return null;
	}

	[Token(Token = "0x6002284")]
	[Address(RVA = "0x836110", Offset = "0x834F10", Length = "0x481")]
	public void DoGearHarvestAfterFinishEating()
	{
	}

	[Token(Token = "0x6002285")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FoodItem()
	{
	}
}

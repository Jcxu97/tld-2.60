using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000472")]
public class ClothingItem : MonoBehaviour
{
	[Header("Wearing")]
	[Token(Token = "0x400280E")]
	[FieldOffset(Offset = "0x20")]
	public ClothingRegion m_Region;

	[Token(Token = "0x400280F")]
	[FieldOffset(Offset = "0x24")]
	public ClothingLayer m_MinLayer;

	[Token(Token = "0x4002810")]
	[FieldOffset(Offset = "0x28")]
	public ClothingLayer m_MaxLayer;

	[Token(Token = "0x4002811")]
	[FieldOffset(Offset = "0x2C")]
	public bool m_IgnorePaperdollMasking;

	[Header("Decay")]
	[Token(Token = "0x4002812")]
	[FieldOffset(Offset = "0x30")]
	public float m_DailyHPDecayWhenWornOutside;

	[Token(Token = "0x4002813")]
	[FieldOffset(Offset = "0x34")]
	public float m_DailyHPDecayWhenWornInside;

	[Header("Properties")]
	[Token(Token = "0x4002814")]
	[FieldOffset(Offset = "0x38")]
	public float m_Warmth;

	[Token(Token = "0x4002815")]
	[FieldOffset(Offset = "0x3C")]
	public float m_WarmthWhenWet;

	[Token(Token = "0x4002816")]
	[FieldOffset(Offset = "0x40")]
	public float m_Windproof;

	[Token(Token = "0x4002817")]
	[FieldOffset(Offset = "0x44")]
	public float m_Toughness;

	[Token(Token = "0x4002818")]
	[FieldOffset(Offset = "0x48")]
	public float m_SprintBarReductionPercent;

	[Tooltip("0 represents getting wet at an unmodified rate. 1 represents not getting wet at all")]
	[Range(0f, 1f)]
	[Token(Token = "0x4002819")]
	[FieldOffset(Offset = "0x4C")]
	public float m_Waterproofness;

	[Tooltip("Note that there can be up to 200% worth of drying to be done, 100 for frozen and 100 for wet")]
	[Token(Token = "0x400281A")]
	[FieldOffset(Offset = "0x50")]
	public float m_DryPercentPerHour;

	[Token(Token = "0x400281B")]
	[FieldOffset(Offset = "0x54")]
	public float m_DryPercentPerHourNoFire;

	[Token(Token = "0x400281C")]
	[FieldOffset(Offset = "0x58")]
	public float m_FreezePercentPerHour;

	[Token(Token = "0x400281D")]
	[FieldOffset(Offset = "0x5C")]
	public float m_DryBonusWhenNotWorn;

	[Token(Token = "0x400281E")]
	[FieldOffset(Offset = "0x60")]
	public string m_PaperDollTextureName;

	[Token(Token = "0x400281F")]
	[FieldOffset(Offset = "0x68")]
	public string m_PaperDollBlendmapName;

	[Tooltip("Does not apply to Unknown")]
	[Token(Token = "0x4002820")]
	[FieldOffset(Offset = "0x70")]
	public DamageReason m_PreventAllDamageFromSource;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4002821")]
	[FieldOffset(Offset = "0x78")]
	private Switch m_MaterialSwitch;

	[SerializeField]
	[Token(Token = "0x4002822")]
	[FieldOffset(Offset = "0x80")]
	private AK.Wwise.Event m_EquipAudioEvent;

	[SerializeField]
	[Token(Token = "0x4002823")]
	[FieldOffset(Offset = "0x88")]
	private AK.Wwise.Event m_UnequipAudioEvent;

	[Tooltip("First person clothing")]
	[Token(Token = "0x4002824")]
	[FieldOffset(Offset = "0x90")]
	public AssetReferenceFirstPersonClothing m_FirstPersonPrefabMale;

	[Token(Token = "0x4002825")]
	[FieldOffset(Offset = "0x98")]
	public AssetReferenceFirstPersonClothing m_FirstPersonPrefabFemale;

	[Token(Token = "0x4002826")]
	[FieldOffset(Offset = "0xA0")]
	private float m_PercentWet;

	[Token(Token = "0x4002827")]
	[FieldOffset(Offset = "0xA4")]
	private float m_PercentFrozen;

	[Token(Token = "0x4002828")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_DroppedIndoors;

	[Token(Token = "0x4002829")]
	[FieldOffset(Offset = "0xAC")]
	private ClothingLayer m_EquippedLayer;

	[Token(Token = "0x400282A")]
	[FieldOffset(Offset = "0xB0")]
	private GearItem m_GearItem;

	[Token(Token = "0x400282B")]
	private static readonly ClothingItemSaveDataProxy m_ClothingItemSaveDataProxy;

	[Token(Token = "0x17000220")]
	public Switch MaterialAudioSwitch
	{
		[Token(Token = "0x600214D")]
		[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600214E")]
	[Address(RVA = "0x80ECF0", Offset = "0x80DAF0", Length = "0x96")]
	private void Awake()
	{
	}

	[Token(Token = "0x600214F")]
	[Address(RVA = "0x80ED90", Offset = "0x80DB90", Length = "0x123")]
	public void Update()
	{
	}

	[Token(Token = "0x6002150")]
	[Address(RVA = "0x80EEC0", Offset = "0x80DCC0", Length = "0x45D")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002151")]
	[Address(RVA = "0x80F320", Offset = "0x80E120", Length = "0x1B3")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002152")]
	[Address(RVA = "0x80F4E0", Offset = "0x80E2E0", Length = "0x65")]
	public bool IsWearing()
	{
		return false;
	}

	[Token(Token = "0x6002153")]
	[Address(RVA = "0x80F550", Offset = "0x80E350", Length = "0x73")]
	public void PutOn(ClothingLayer layerToPutOn = ClothingLayer.NumLayers)
	{
	}

	[Token(Token = "0x6002154")]
	[Address(RVA = "0x80F5D0", Offset = "0x80E3D0", Length = "0x65")]
	public void TakeOff()
	{
	}

	[Token(Token = "0x6002155")]
	[Address(RVA = "0x80F640", Offset = "0x80E440", Length = "0x10")]
	public bool IsProtectedFromDamageReason(DamageReason reason)
	{
		return false;
	}

	[Token(Token = "0x6002156")]
	[Address(RVA = "0x80F650", Offset = "0x80E450", Length = "0x27")]
	public bool IsDry()
	{
		return false;
	}

	[Token(Token = "0x6002157")]
	[Address(RVA = "0x80F680", Offset = "0x80E480", Length = "0xC")]
	public void SetFullyWet()
	{
	}

	[Token(Token = "0x6002158")]
	[Address(RVA = "0x80F690", Offset = "0x80E490", Length = "0xB")]
	public void SetFullyUnfrozen()
	{
	}

	[Token(Token = "0x6002159")]
	[Address(RVA = "0x80F6A0", Offset = "0x80E4A0", Length = "0xD5")]
	public void MaybeGetWetOnGround(float deltaTODHours)
	{
	}

	[Token(Token = "0x600215A")]
	[Address(RVA = "0x80F780", Offset = "0x80E580", Length = "0x76")]
	public void IncreaseWetnessPercent(float wetnessPercentIncrease)
	{
	}

	[Token(Token = "0x600215B")]
	[Address(RVA = "0x80F800", Offset = "0x80E600", Length = "0xD5")]
	public void Dry(float amountToDry)
	{
	}

	[Token(Token = "0x600215C")]
	[Address(RVA = "0x80F8E0", Offset = "0x80E6E0", Length = "0x42")]
	public void Freeze(float amountToFreeze)
	{
	}

	[Token(Token = "0x600215D")]
	[Address(RVA = "0x80F930", Offset = "0x80E730", Length = "0x1EA")]
	public string GetWetnessString()
	{
		return null;
	}

	[Token(Token = "0x600215E")]
	[Address(RVA = "0x80FB20", Offset = "0x80E920", Length = "0x5B")]
	public void PlayEquipAudio()
	{
	}

	[Token(Token = "0x600215F")]
	[Address(RVA = "0x80FB80", Offset = "0x80E980", Length = "0x5B")]
	public void PlayUnequipAudio()
	{
	}

	[Token(Token = "0x6002160")]
	[Address(RVA = "0x80FBE0", Offset = "0x80E9E0", Length = "0xF7")]
	private static void PlayAudioEventWithFallback(AK.Wwise.Event audioEvent, uint fallback)
	{
	}

	[Token(Token = "0x6002161")]
	[Address(RVA = "0x80FCE0", Offset = "0x80EAE0", Length = "0x145")]
	public string GetWetnessOnlyString()
	{
		return null;
	}

	[Token(Token = "0x6002162")]
	[Address(RVA = "0x80FE30", Offset = "0x80EC30", Length = "0x145")]
	public string GetFrozenOnlyString()
	{
		return null;
	}

	[Token(Token = "0x6002163")]
	[Address(RVA = "0x80FF80", Offset = "0x80ED80", Length = "0xD3")]
	public float GetWeightModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6002164")]
	[Address(RVA = "0x810060", Offset = "0x80EE60", Length = "0x5D")]
	public float GetWeightModifierNoWornBonus()
	{
		return 0f;
	}

	[Token(Token = "0x6002165")]
	[Address(RVA = "0x8100C0", Offset = "0x80EEC0", Length = "0x26")]
	public float GetWetnessDebuffNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x6002166")]
	[Address(RVA = "0x8100F0", Offset = "0x80EEF0", Length = "0x11")]
	public float GetWetnessNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x6002167")]
	[Address(RVA = "0x810110", Offset = "0x80EF10", Length = "0x11")]
	public float GetFrozenNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x6002168")]
	[Address(RVA = "0x810130", Offset = "0x80EF30", Length = "0x1B3")]
	public float GetWarmth()
	{
		return 0f;
	}

	[Token(Token = "0x6002169")]
	[Address(RVA = "0x8102F0", Offset = "0x80F0F0", Length = "0x162")]
	public float GetWindproof()
	{
		return 0f;
	}

	[Token(Token = "0x600216A")]
	[Address(RVA = "0x810460", Offset = "0x80F260", Length = "0x64")]
	public void Dropped()
	{
	}

	[Token(Token = "0x600216B")]
	[Address(RVA = "0x8104D0", Offset = "0x80F2D0", Length = "0x51")]
	public void PickedUp()
	{
	}

	[Token(Token = "0x600216C")]
	[Address(RVA = "0x810530", Offset = "0x80F330", Length = "0x71")]
	public void OnFirstInspect()
	{
	}

	[Token(Token = "0x600216D")]
	[Address(RVA = "0x8105B0", Offset = "0x80F3B0", Length = "0x678")]
	public string GetWarmthAndWindchillBonusString()
	{
		return null;
	}

	[Token(Token = "0x600216E")]
	[Address(RVA = "0x6A2BE0", Offset = "0x6A19E0", Length = "0x7")]
	public ClothingLayer GetEquippedLayer()
	{
		return default(ClothingLayer);
	}

	[Token(Token = "0x600216F")]
	[Address(RVA = "0x810C30", Offset = "0x80FA30", Length = "0x7")]
	public void SetEquippedLayer(ClothingLayer layer)
	{
	}

	[Token(Token = "0x6002170")]
	[Address(RVA = "0x810C40", Offset = "0x80FA40", Length = "0x18A")]
	public bool IsOutermostItemInClothingRegion()
	{
		return false;
	}

	[Token(Token = "0x6002171")]
	[Address(RVA = "0x810DD0", Offset = "0x80FBD0", Length = "0x11A")]
	private void DoDryOrFreeze(float numHoursDelta, bool nearFireOverride = false)
	{
	}

	[Token(Token = "0x6002172")]
	[Address(RVA = "0x810EF0", Offset = "0x80FCF0", Length = "0x14F")]
	private bool IsNearFire()
	{
		return false;
	}

	[Token(Token = "0x6002173")]
	[Address(RVA = "0x811040", Offset = "0x80FE40", Length = "0x171")]
	public float GetDailyHPDecay()
	{
		return 0f;
	}

	[Token(Token = "0x6002174")]
	[Address(RVA = "0x8111C0", Offset = "0x80FFC0", Length = "0x5F")]
	public ClothingItem()
	{
	}
}

using Cpp2ILInjected;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x20005B2")]
public class SnowShelter : MonoBehaviour
{
	[Header("Display Names")]
	[Token(Token = "0x40034A0")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayNameRuined;

	[Token(Token = "0x40034A1")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDisplayExitName;

	[Header("Build")]
	[Token(Token = "0x40034A2")]
	[FieldOffset(Offset = "0x30")]
	public int m_MinutesToBuild;

	[Token(Token = "0x40034A3")]
	[FieldOffset(Offset = "0x38")]
	public GearItem m_SticksPrefab;

	[Token(Token = "0x40034A4")]
	[FieldOffset(Offset = "0x40")]
	public GearItem m_ClothPrefab;

	[Token(Token = "0x40034A5")]
	[FieldOffset(Offset = "0x48")]
	public int m_NumSticksToBuild;

	[Token(Token = "0x40034A6")]
	[FieldOffset(Offset = "0x4C")]
	public int m_NumClothToBuild;

	[Header("Repair")]
	[Token(Token = "0x40034A7")]
	[FieldOffset(Offset = "0x50")]
	public int m_MinutesForFullRepair;

	[Token(Token = "0x40034A8")]
	[FieldOffset(Offset = "0x54")]
	public int m_StickConditionPercentRepair;

	[Token(Token = "0x40034A9")]
	[FieldOffset(Offset = "0x58")]
	public int m_ClothConditionPercentRepair;

	[Header("Dismantle")]
	[Token(Token = "0x40034AA")]
	[FieldOffset(Offset = "0x5C")]
	public bool m_AllowDismantle;

	[Token(Token = "0x40034AB")]
	[FieldOffset(Offset = "0x60")]
	public int m_MinutesToDismantle;

	[Token(Token = "0x40034AC")]
	[FieldOffset(Offset = "0x64")]
	public int m_NumSticksFromDismantle;

	[Token(Token = "0x40034AD")]
	[FieldOffset(Offset = "0x68")]
	public int m_NumClothFromDismantle;

	[Header("Rigging")]
	[Token(Token = "0x40034AE")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_ExitPoint;

	[Token(Token = "0x40034AF")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_CameraDummy;

	[Token(Token = "0x40034B0")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_NormalMesh;

	[Token(Token = "0x40034B1")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_RuinedMesh;

	[Token(Token = "0x40034B2")]
	[FieldOffset(Offset = "0x90")]
	public SnowImprintCustom m_GroundImprint;

	[Token(Token = "0x40034B3")]
	[FieldOffset(Offset = "0x98")]
	public Bed m_Bed;

	[Header("Decay")]
	[Token(Token = "0x40034B4")]
	[FieldOffset(Offset = "0xA0")]
	public float m_MaxHP;

	[Token(Token = "0x40034B5")]
	[FieldOffset(Offset = "0xA4")]
	public float m_DailyDecayHP;

	[Token(Token = "0x40034B6")]
	[FieldOffset(Offset = "0xA8")]
	public float m_BlizzardHourlyDecayHP;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40034B7")]
	[FieldOffset(Offset = "0xB0")]
	private PanelReference<Panel_SnowShelterInteract> m_InteractPanel;

	[HideInInspector]
	[Token(Token = "0x40034B8")]
	[FieldOffset(Offset = "0xB8")]
	public NavMeshObstacle m_NavmeshCut;

	[Token(Token = "0x40034B9")]
	[FieldOffset(Offset = "0xC0")]
	private float m_CurrentHP;

	[Token(Token = "0x40034BA")]
	[FieldOffset(Offset = "0xC4")]
	private bool m_Ruined;

	[Token(Token = "0x40034BB")]
	[FieldOffset(Offset = "0xC8")]
	private float m_HoursRuined;

	[Token(Token = "0x40034BC")]
	[FieldOffset(Offset = "0xCC")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x40034BD")]
	private static SnowShelterDataProxy m_SnowShelterDataProxy;

	[Token(Token = "0x6002C10")]
	[Address(RVA = "0x92CC60", Offset = "0x92BA60", Length = "0x307")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002C11")]
	[Address(RVA = "0x92CF70", Offset = "0x92BD70", Length = "0x10C")]
	private void Start()
	{
	}

	[Token(Token = "0x6002C12")]
	[Address(RVA = "0x92D080", Offset = "0x92BE80", Length = "0x151")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002C13")]
	[Address(RVA = "0x92D1E0", Offset = "0x92BFE0", Length = "0x618")]
	private void Update()
	{
	}

	[Token(Token = "0x6002C14")]
	[Address(RVA = "0x92D800", Offset = "0x92C600", Length = "0x188")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002C15")]
	[Address(RVA = "0x92D990", Offset = "0x92C790", Length = "0x256")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002C16")]
	[Address(RVA = "0x92DBF0", Offset = "0x92C9F0", Length = "0xCF")]
	public void BuildFinished()
	{
	}

	[Token(Token = "0x6002C17")]
	[Address(RVA = "0x92DCC0", Offset = "0x92CAC0", Length = "0x10B")]
	public void RepairFinished(int numSticksUsed, int numClothUsed)
	{
	}

	[Token(Token = "0x6002C18")]
	[Address(RVA = "0x92DDD0", Offset = "0x92CBD0", Length = "0x456")]
	public void DismantleFinished()
	{
	}

	[Token(Token = "0x6002C19")]
	[Address(RVA = "0x5579A0", Offset = "0x5567A0", Length = "0x8")]
	public bool IsRuined()
	{
		return false;
	}

	[Token(Token = "0x6002C1A")]
	[Address(RVA = "0x92E230", Offset = "0x92D030", Length = "0x2D")]
	public float GetNormalizedCondition()
	{
		return 0f;
	}

	[Token(Token = "0x6002C1B")]
	[Address(RVA = "0x92E260", Offset = "0x92D060", Length = "0x276")]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[Token(Token = "0x6002C1C")]
	[Address(RVA = "0x92E4E0", Offset = "0x92D2E0", Length = "0x245")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002C1D")]
	[Address(RVA = "0x92E730", Offset = "0x92D530", Length = "0xBF")]
	public int GetNumSticksToRepair()
	{
		return 0;
	}

	[Token(Token = "0x6002C1E")]
	[Address(RVA = "0x92E7F0", Offset = "0x92D5F0", Length = "0xCA")]
	public int GetNumClothToRepair()
	{
		return 0;
	}

	[Token(Token = "0x6002C1F")]
	[Address(RVA = "0x5579C0", Offset = "0x5567C0", Length = "0x9")]
	public float GetHoursRuined()
	{
		return 0f;
	}

	[Token(Token = "0x6002C20")]
	[Address(RVA = "0x92E8C0", Offset = "0x92D6C0", Length = "0x34")]
	public void OnExited()
	{
	}

	[Token(Token = "0x6002C21")]
	[Address(RVA = "0x92E900", Offset = "0x92D700", Length = "0x34")]
	public void OnEntered()
	{
	}

	[Token(Token = "0x6002C22")]
	[Address(RVA = "0x92E940", Offset = "0x92D740", Length = "0x47")]
	public SnowShelter()
	{
	}
}

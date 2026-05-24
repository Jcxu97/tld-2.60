using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000550")]
public class BreakDown : BaseInteraction
{
	[Token(Token = "0x2000551")]
	private class ColliderList
	{
		[Token(Token = "0x4003144")]
		[FieldOffset(Offset = "0x10")]
		public readonly Collider[] m_Colliders;

		[Token(Token = "0x60028EA")]
		[Address(RVA = "0x8D9CC0", Offset = "0x8D8AC0", Length = "0x87")]
		public ColliderList()
		{
		}
	}

	[Token(Token = "0x2000552")]
	private struct LayerInfo
	{
		[Token(Token = "0x4003145")]
		[FieldOffset(Offset = "0x0")]
		public GameObject m_GameObject;

		[Token(Token = "0x4003146")]
		[FieldOffset(Offset = "0x8")]
		public int m_Layer;
	}

	[Token(Token = "0x400312C")]
	public static List<BreakDown> m_BreakDownObjects;

	[Token(Token = "0x400312D")]
	public static bool m_CanBreakDownObjects;

	[Token(Token = "0x400312E")]
	[FieldOffset(Offset = "0x40")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x400312F")]
	[FieldOffset(Offset = "0x48")]
	public string m_BreakDownAudio;

	[SerializeField]
	[Token(Token = "0x4003130")]
	[FieldOffset(Offset = "0x50")]
	private bool m_EditModeDestroyOnly;

	[Token(Token = "0x4003131")]
	[FieldOffset(Offset = "0x51")]
	public bool m_AllowEditModePlacement;

	[Token(Token = "0x4003132")]
	[FieldOffset(Offset = "0x52")]
	public bool m_CorpseRemoval;

	[SerializeField]
	[Token(Token = "0x4003133")]
	[FieldOffset(Offset = "0x54")]
	private float m_TimeCostHours;

	[SerializeField]
	[Token(Token = "0x4003134")]
	[FieldOffset(Offset = "0x58")]
	private float m_EditModeDestroyTimeCostHours;

	[SerializeField]
	[Token(Token = "0x4003135")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_RequiresTool;

	[Token(Token = "0x4003136")]
	[FieldOffset(Offset = "0x5D")]
	public bool m_ForceToPlayersFeet;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003137")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_BreakDown> m_BreakDown;

	[HideInInspector]
	[Token(Token = "0x4003138")]
	[FieldOffset(Offset = "0x68")]
	public GameObject[] m_UsableTools;

	[HideInInspector]
	[Token(Token = "0x4003139")]
	[FieldOffset(Offset = "0x70")]
	public GameObject[] m_YieldObject;

	[HideInInspector]
	[Token(Token = "0x400313A")]
	[FieldOffset(Offset = "0x78")]
	public int[] m_YieldObjectUnits;

	[Token(Token = "0x400313B")]
	[FieldOffset(Offset = "0x80")]
	private readonly List<Renderer> m_RendererList;

	[Token(Token = "0x400313C")]
	[FieldOffset(Offset = "0x88")]
	private List<GameObject> m_FilteredUsableToolsList;

	[Token(Token = "0x400313D")]
	[FieldOffset(Offset = "0x90")]
	private bool m_PostLoadBreakdown;

	[Token(Token = "0x400313E")]
	[FieldOffset(Offset = "0x94")]
	private float m_CountdownToBreakdown;

	[Token(Token = "0x400313F")]
	[FieldOffset(Offset = "0x98")]
	private float m_CountdownToBreakdownTime;

	[Token(Token = "0x4003140")]
	[FieldOffset(Offset = "0xA0")]
	private List<LayerInfo> m_LayerInfos;

	[Token(Token = "0x4003141")]
	private static BreakDownSaveData m_BreakDownSaveData;

	[Token(Token = "0x4003142")]
	private static List<BreakDown> m_BreakDownItemsToSerialize;

	[Token(Token = "0x4003143")]
	private static RaycastHit[] s_RaycastHit;

	[Token(Token = "0x1700029F")]
	public override bool IsEnabled
	{
		[Token(Token = "0x60028C3")]
		[Address(RVA = "0x8D08E0", Offset = "0x8CF6E0", Length = "0xF5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170002A0")]
	public bool EditModeDestroyOnly
	{
		[Token(Token = "0x60028C4")]
		[Address(RVA = "0x8D09E0", Offset = "0x8CF7E0", Length = "0x77")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60028C5")]
	[Address(RVA = "0x8D0A60", Offset = "0x8CF860", Length = "0x10B")]
	private void Awake()
	{
	}

	[Token(Token = "0x60028C6")]
	[Address(RVA = "0x8D0B70", Offset = "0x8CF970", Length = "0x91C")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60028C7")]
	[Address(RVA = "0x8D1490", Offset = "0x8D0290", Length = "0x372")]
	public static void UpdateAll()
	{
	}

	[Token(Token = "0x60028C8")]
	[Address(RVA = "0x8D1810", Offset = "0x8D0610", Length = "0x154")]
	private void ManualUpdate()
	{
	}

	[Token(Token = "0x60028C9")]
	[Address(RVA = "0x8D1970", Offset = "0x8D0770", Length = "0x2E5")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60028CA")]
	[Address(RVA = "0x8D1C60", Offset = "0x8D0A60", Length = "0xB7")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60028CB")]
	[Address(RVA = "0x8D1D20", Offset = "0x8D0B20", Length = "0x6B3")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x60028CC")]
	[Address(RVA = "0x8D23E0", Offset = "0x8D11E0", Length = "0x285")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x60028CD")]
	[Address(RVA = "0x8D2670", Offset = "0x8D1470", Length = "0x93")]
	public static void StaticReset()
	{
	}

	[Token(Token = "0x60028CE")]
	[Address(RVA = "0x8D2710", Offset = "0x8D1510", Length = "0x1F")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x60028CF")]
	[Address(RVA = "0x8D2730", Offset = "0x8D1530", Length = "0xC1")]
	public void RefreshInteractionSetup()
	{
	}

	[Token(Token = "0x60028D0")]
	[Address(RVA = "0x8D2800", Offset = "0x8D1600", Length = "0x6BE")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x60028D1")]
	[Address(RVA = "0x8D2EC0", Offset = "0x8D1CC0", Length = "0x472")]
	public void DoBreakDown(bool spawnYieldObjects)
	{
	}

	[Token(Token = "0x60028D2")]
	[Address(RVA = "0x8D3340", Offset = "0x8D2140", Length = "0x34")]
	public List<GameObject> GetFilteredUsableTools()
	{
		return null;
	}

	[Token(Token = "0x60028D3")]
	[Address(RVA = "0x8D3380", Offset = "0x8D2180", Length = "0x44A")]
	private void InitializeFilteredUsableTools()
	{
	}

	[Token(Token = "0x60028D4")]
	[Address(RVA = "0x8D37D0", Offset = "0x8D25D0", Length = "0x196")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60028D5")]
	[Address(RVA = "0x8D3970", Offset = "0x8D2770", Length = "0x136")]
	public float GetTimeCostHours()
	{
		return 0f;
	}

	[Token(Token = "0x60028D6")]
	[Address(RVA = "0x8D3AB0", Offset = "0x8D28B0", Length = "0x69")]
	public bool RequiresTool()
	{
		return false;
	}

	[Token(Token = "0x60028D7")]
	[Address(RVA = "0x8D3B20", Offset = "0x8D2920", Length = "0x33E")]
	private static BreakDown FindBreakDownByPosition(BreakDownSaveData proxy)
	{
		return null;
	}

	[Token(Token = "0x60028D8")]
	[Address(RVA = "0x8D3E60", Offset = "0x8D2C60", Length = "0x12A")]
	private static BreakDown FindBreakDownByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x60028D9")]
	[Address(RVA = "0x8D3F90", Offset = "0x8D2D90", Length = "0x509")]
	private void SpawnYieldObjectsAndStickToGround()
	{
	}

	[Token(Token = "0x60028DA")]
	[Address(RVA = "0x8D44A0", Offset = "0x8D32A0", Length = "0x458")]
	private void SpawnYieldObjectsAndAddToInventory()
	{
	}

	[Token(Token = "0x60028DB")]
	[Address(RVA = "0x8D4900", Offset = "0x8D3700", Length = "0xCF")]
	public void ResetRenderList()
	{
	}

	[Token(Token = "0x60028DC")]
	[Address(RVA = "0x8D49D0", Offset = "0x8D37D0", Length = "0x2182")]
	public void StickSurfaceObjectsToGround(bool ignoreGearItems)
	{
	}

	[Token(Token = "0x60028DD")]
	[Address(RVA = "0x8D6B60", Offset = "0x8D5960", Length = "0x13F")]
	private static StickToGround GetStickToGroundInDirectParent(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60028DE")]
	[Address(RVA = "0x8D6CA0", Offset = "0x8D5AA0", Length = "0x58D")]
	private bool ProcessRaycastResults(GameObject targetObj, float objectTop, int numHits, out RaycastHit hitOut)
	{
		hitOut = default(RaycastHit);
		return false;
	}

	[Token(Token = "0x60028DF")]
	[Address(RVA = "0x8D7230", Offset = "0x8D6030", Length = "0x1A8")]
	private bool SphereCastForNearest(GameObject targetObj, Vector3 startPos, float radius, out RaycastHit hitOut)
	{
		hitOut = default(RaycastHit);
		return false;
	}

	[Token(Token = "0x60028E0")]
	[Address(RVA = "0x8D73E0", Offset = "0x8D61E0", Length = "0x1BD")]
	private bool RayCastForNearest(GameObject targetObj, Vector3 startPos, out RaycastHit hitOut)
	{
		hitOut = default(RaycastHit);
		return false;
	}

	[Token(Token = "0x60028E1")]
	[Address(RVA = "0x8D75A0", Offset = "0x8D63A0", Length = "0x1419")]
	private void StickToGround(GameObject go)
	{
	}

	[Token(Token = "0x60028E2")]
	[Address(RVA = "0x8D89C0", Offset = "0x8D77C0", Length = "0xE1")]
	private bool IsGround(GameObject go)
	{
		return false;
	}

	[Token(Token = "0x60028E3")]
	[Address(RVA = "0x8D8AB0", Offset = "0x8D78B0", Length = "0x42C")]
	private bool CanStickToGround(GameObject go)
	{
		return false;
	}

	[Token(Token = "0x60028E4")]
	[Address(RVA = "0x8D8EE0", Offset = "0x8D7CE0", Length = "0x82")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60028E5")]
	[Address(RVA = "0x8D8F70", Offset = "0x8D7D70", Length = "0x329")]
	private LayerInfo GetLayerInfo(Transform transform)
	{
		return default(LayerInfo);
	}

	[Token(Token = "0x60028E6")]
	[Address(RVA = "0x8D92A0", Offset = "0x8D80A0", Length = "0x426")]
	private void SaveLayerInfos(GameObject go)
	{
	}

	[Token(Token = "0x60028E7")]
	[Address(RVA = "0x8D96D0", Offset = "0x8D84D0", Length = "0x1BA")]
	private void RestoreLayerInfos(GameObject go)
	{
	}

	[Token(Token = "0x60028E8")]
	[Address(RVA = "0x8D9890", Offset = "0x8D8690", Length = "0x174")]
	public BreakDown()
	{
	}
}

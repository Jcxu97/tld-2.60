using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.BigCarry;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000546")]
public class Bed : MonoBehaviour
{
	[Token(Token = "0x4003099")]
	private const string VIS_POINT_NAME = "VisPoint";

	[SerializeField]
	[Token(Token = "0x400309A")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Rest> m_Rest;

	[Token(Token = "0x400309B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_BedRollMesh;

	[Token(Token = "0x400309C")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_BedRollPlacedMesh;

	[Range(0f, 100f)]
	[Token(Token = "0x400309D")]
	[FieldOffset(Offset = "0x38")]
	public float m_ConditionPercentGainPerHour;

	[Range(0f, 30f)]
	[Token(Token = "0x400309E")]
	[FieldOffset(Offset = "0x3C")]
	public float m_WarmthBonusCelsius;

	[Range(0f, 100f)]
	[Token(Token = "0x400309F")]
	[FieldOffset(Offset = "0x40")]
	public float m_UinterruptedRestPercentGainPerHour;

	[Range(0f, 100f)]
	[Token(Token = "0x40030A0")]
	[FieldOffset(Offset = "0x44")]
	public float m_PercentChanceReduceWolfAttackWhenSleeping;

	[Range(0f, 100f)]
	[Token(Token = "0x40030A1")]
	[FieldOffset(Offset = "0x48")]
	public float m_PercentChanceReduceBearAttackWhenSleeping;

	[Token(Token = "0x40030A2")]
	[FieldOffset(Offset = "0x50")]
	public string m_OpenAudio;

	[Token(Token = "0x40030A3")]
	[FieldOffset(Offset = "0x58")]
	public string m_CloseAudio;

	[Token(Token = "0x40030A4")]
	[FieldOffset(Offset = "0x60")]
	public Transform m_BodyPlacementTransform;

	[Header("Placement")]
	[SerializeField]
	[Token(Token = "0x40030A5")]
	[FieldOffset(Offset = "0x68")]
	private float m_VisCheckLength;

	[Token(Token = "0x40030A6")]
	[FieldOffset(Offset = "0x70")]
	private GearItem m_Bedroll;

	[Token(Token = "0x40030A7")]
	[FieldOffset(Offset = "0x78")]
	private BedRollState m_BedRollState;

	[Token(Token = "0x40030A8")]
	[FieldOffset(Offset = "0x80")]
	private string m_BodyGuid;

	[Token(Token = "0x40030A9")]
	[FieldOffset(Offset = "0x88")]
	private BodyBigCarryItem m_BodyItem;

	[Token(Token = "0x40030AB")]
	private static List<Bed> s_StaticBeds;

	[Token(Token = "0x40030AC")]
	private static List<Bed> s_BedsToLinkToBodies;

	[Token(Token = "0x40030AD")]
	private static BedSaveDataProxy m_BedSaveDataProxy;

	[Token(Token = "0x40030AE")]
	public static bool s_DebugPlacement;

	[Token(Token = "0x17000298")]
	[field: Token(Token = "0x40030AA")]
	[field: FieldOffset(Offset = "0x90")]
	public List<Transform> VisPoints
	{
		[Token(Token = "0x600285A")]
		[Address(RVA = "0x40DA00", Offset = "0x40C800", Length = "0x8")]
		get;
		[Token(Token = "0x600285B")]
		[Address(RVA = "0x40DA10", Offset = "0x40C810", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000299")]
	public float VisCheckLength
	{
		[Token(Token = "0x600285C")]
		[Address(RVA = "0x502590", Offset = "0x501390", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x600285D")]
	[Address(RVA = "0x8C5730", Offset = "0x8C4530", Length = "0x60B")]
	private void Awake()
	{
	}

	[Token(Token = "0x600285E")]
	[Address(RVA = "0x8C5D40", Offset = "0x8C4B40", Length = "0x82")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600285F")]
	[Address(RVA = "0x8C5DD0", Offset = "0x8C4BD0", Length = "0x2D8")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6002860")]
	[Address(RVA = "0x8C60B0", Offset = "0x8C4EB0", Length = "0x24F")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002861")]
	[Address(RVA = "0x8C6300", Offset = "0x8C5100", Length = "0x332")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6002862")]
	[Address(RVA = "0x8C6640", Offset = "0x8C5440", Length = "0x16A")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002863")]
	[Address(RVA = "0x8C67B0", Offset = "0x8C55B0", Length = "0x323")]
	public static void PostDeserialize()
	{
	}

	[Token(Token = "0x6002864")]
	[Address(RVA = "0x8C6AE0", Offset = "0x8C58E0", Length = "0x1AA")]
	public void Degrade(float hoursUsed)
	{
	}

	[Token(Token = "0x6002865")]
	[Address(RVA = "0x8C6C90", Offset = "0x8C5A90", Length = "0xEC")]
	public bool IsWornOut()
	{
		return false;
	}

	[Token(Token = "0x6002866")]
	[Address(RVA = "0x8C6D80", Offset = "0x8C5B80", Length = "0x124")]
	public float GetWarmthBonusCelsius()
	{
		return 0f;
	}

	[Token(Token = "0x6002867")]
	[Address(RVA = "0x8C6EB0", Offset = "0x8C5CB0", Length = "0x6C")]
	public void PlayOpenAudio()
	{
	}

	[Token(Token = "0x6002868")]
	[Address(RVA = "0x8C6F20", Offset = "0x8C5D20", Length = "0x6C")]
	public void PlayCloseAudio()
	{
	}

	[Token(Token = "0x6002869")]
	[Address(RVA = "0x8C6F90", Offset = "0x8C5D90", Length = "0x1BD")]
	public void SetState(BedRollState state)
	{
	}

	[Token(Token = "0x600286A")]
	[Address(RVA = "0x657EE0", Offset = "0x656CE0", Length = "0x4")]
	public BedRollState GetState()
	{
		return default(BedRollState);
	}

	[Token(Token = "0x600286B")]
	[Address(RVA = "0x8C7150", Offset = "0x8C5F50", Length = "0xCD")]
	public bool IsOccupied()
	{
		return false;
	}

	[Token(Token = "0x600286C")]
	[Address(RVA = "0x8C7220", Offset = "0x8C6020", Length = "0xF2")]
	public bool CanBodyBePlaced()
	{
		return false;
	}

	[Token(Token = "0x600286D")]
	[Address(RVA = "0x8C7320", Offset = "0x8C6120", Length = "0x4A9")]
	public void PlaceBody(BodyBigCarryItem bodyItem)
	{
	}

	[Token(Token = "0x600286E")]
	[Address(RVA = "0x8C77D0", Offset = "0x8C65D0", Length = "0x243")]
	public void RemoveBody(BodyBigCarryItem bodyItem)
	{
	}

	[Token(Token = "0x600286F")]
	[Address(RVA = "0x4C0240", Offset = "0x4BF040", Length = "0x8")]
	public BodyBigCarryItem GetOccupant()
	{
		return null;
	}

	[Token(Token = "0x6002870")]
	[Address(RVA = "0x8C7A20", Offset = "0x8C6820", Length = "0x12A")]
	private static Bed FindBedByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6002871")]
	[Address(RVA = "0x8C7B50", Offset = "0x8C6950", Length = "0x123")]
	public bool ShouldPerformBedInteraction()
	{
		return false;
	}

	[Token(Token = "0x6002872")]
	[Address(RVA = "0x8C7C80", Offset = "0x8C6A80", Length = "0x9C")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002873")]
	[Address(RVA = "0x8C7D20", Offset = "0x8C6B20", Length = "0x4A")]
	public Bed()
	{
	}
}

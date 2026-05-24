using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200055B")]
public class Campfire : FireplaceInteraction
{
	[SerializeField]
	[Token(Token = "0x4003165")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_Loading> m_Loading;

	[Token(Token = "0x4003166")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_PlacedMesh;

	[Token(Token = "0x4003167")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_LitMesh;

	[Token(Token = "0x4003168")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_BurntMesh;

	[Token(Token = "0x4003169")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_PlacementBlockColliderObj;

	[Token(Token = "0x400316A")]
	[FieldOffset(Offset = "0x98")]
	public Collider m_RockRingCollider;

	[Token(Token = "0x400316B")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_RockRingParent;

	[Token(Token = "0x400316C")]
	[FieldOffset(Offset = "0xA8")]
	public float m_RockOffsetFromGround;

	[Range(0.001f, 2f)]
	[Token(Token = "0x400316D")]
	[FieldOffset(Offset = "0xAC")]
	public float m_RockMaxValidOffsetFromGround;

	[Token(Token = "0x400316E")]
	[FieldOffset(Offset = "0xB0")]
	public string m_PlaceAudio;

	[Token(Token = "0x400316F")]
	[FieldOffset(Offset = "0xB8")]
	public bool m_BurnedOut;

	[HideInInspector]
	[Token(Token = "0x4003170")]
	[FieldOffset(Offset = "0xBC")]
	public CampfireState m_State;

	[Token(Token = "0x4003171")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_IsBeingPlaced;

	[Token(Token = "0x4003172")]
	[FieldOffset(Offset = "0xC8")]
	private Dictionary<Transform, Vector3> m_RockPositions;

	[Token(Token = "0x4003173")]
	[FieldOffset(Offset = "0xD0")]
	private Dictionary<string, GameObject> m_PlacePointRocks;

	[Token(Token = "0x4003174")]
	[FieldOffset(Offset = "0xD8")]
	private RaycastHit[] m_RockRaycastResults;

	[Token(Token = "0x4003175")]
	[FieldOffset(Offset = "0xE0")]
	private Vector3 m_LastPosition;

	[Token(Token = "0x4003176")]
	[FieldOffset(Offset = "0xEC")]
	private float m_LargestRockOffset;

	[Token(Token = "0x4003177")]
	[FieldOffset(Offset = "0xF0")]
	private bool m_ValidatePlacePoints;

	[Token(Token = "0x4003178")]
	private static CampfireSaveDataProxy m_CampfireSaveDataProxy;

	[Token(Token = "0x4003179")]
	private static List<Campfire> s_ActiveCampfires;

	[Token(Token = "0x400317A")]
	[FieldOffset(Offset = "0xF8")]
	private Dictionary<Transform, int> m_ColliderLayerByTransform;

	[Token(Token = "0x170002A4")]
	public static List<Campfire> ActiveCampfires
	{
		[Token(Token = "0x6002912")]
		[Address(RVA = "0x8DB940", Offset = "0x8DA740", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002913")]
	[Address(RVA = "0x8DB9A0", Offset = "0x8DA7A0", Length = "0x6D")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002914")]
	[Address(RVA = "0x8DBA10", Offset = "0x8DA810", Length = "0x7CF")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002915")]
	[Address(RVA = "0x8DC1E0", Offset = "0x8DAFE0", Length = "0xBE")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002916")]
	[Address(RVA = "0x8DC2A0", Offset = "0x8DB0A0", Length = "0x83")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002917")]
	[Address(RVA = "0x8DC330", Offset = "0x8DB130", Length = "0x12D3")]
	private void Update()
	{
	}

	[Token(Token = "0x6002918")]
	[Address(RVA = "0x8DD610", Offset = "0x8DC410", Length = "0x425")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002919")]
	[Address(RVA = "0x8DDA40", Offset = "0x8DC840", Length = "0x832")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600291A")]
	[Address(RVA = "0x8DE280", Offset = "0x8DD080", Length = "0x13")]
	public bool AreAnyRockOffsetsInvalid()
	{
		return false;
	}

	[Token(Token = "0x600291B")]
	[Address(RVA = "0x8DE2A0", Offset = "0x8DD0A0", Length = "0xDC")]
	public void SetState(CampfireState state)
	{
	}

	[Token(Token = "0x600291C")]
	[Address(RVA = "0x8DE380", Offset = "0x8DD180", Length = "0x1AA")]
	public override bool TooWindyToStart()
	{
		return false;
	}

	[Token(Token = "0x600291D")]
	[Address(RVA = "0x8DE530", Offset = "0x8DD330", Length = "0x5E7")]
	public void OnEnteredPlaceMesh()
	{
	}

	[Token(Token = "0x600291E")]
	[Address(RVA = "0x8DEB20", Offset = "0x8DD920", Length = "0x3C0")]
	public void OnExitedPlaceMesh()
	{
	}

	[Token(Token = "0x600291F")]
	[Address(RVA = "0x8DEEF0", Offset = "0x8DDCF0", Length = "0x10E")]
	public override void PerformFireplaceInteraction()
	{
	}

	[Token(Token = "0x6002920")]
	[Address(RVA = "0x8DF000", Offset = "0x8DDE00", Length = "0xFA")]
	public override string GetHoverText()
	{
		return null;
	}

	[Token(Token = "0x6002921")]
	[Address(RVA = "0x8DF100", Offset = "0x8DDF00", Length = "0x262")]
	public Campfire()
	{
	}
}

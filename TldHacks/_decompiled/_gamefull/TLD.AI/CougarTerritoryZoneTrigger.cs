using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.AI;

[RequireComponent(typeof(BoxCollider))]
[Token(Token = "0x2001505")]
public class CougarTerritoryZoneTrigger : MonoBehaviour
{
	[Tooltip("Defines the escalation level at which this zone becomes active")]
	[Range(1f, 20f)]
	[Token(Token = "0x400980B")]
	[FieldOffset(Offset = "0x20")]
	public int m_ThreatLevel;

	[Tooltip("Disabled other spawn regions within this distance when cougar is active in this region")]
	[SerializeField]
	[Token(Token = "0x400980C")]
	[FieldOffset(Offset = "0x24")]
	private float m_DisableSpawnRegionsInRange;

	[Tooltip("Reveal this much area of the map when cougar region active")]
	[SerializeField]
	[Token(Token = "0x400980D")]
	[FieldOffset(Offset = "0x28")]
	private float m_MapRevealRadius;

	[Tooltip("Defines the chance a carcass will be placed in the world")]
	[Range(0f, 100f)]
	[SerializeField]
	[Token(Token = "0x400980E")]
	[FieldOffset(Offset = "0x2C")]
	private float m_CarcassPlacementChance;

	[SerializeField]
	[Token(Token = "0x400980F")]
	[FieldOffset(Offset = "0x30")]
	private List<CarcassSite> m_CarcassPrefabs;

	[SerializeField]
	[Token(Token = "0x4009810")]
	[FieldOffset(Offset = "0x38")]
	private List<GameObject> m_CarcassLocations;

	[SerializeField]
	[Token(Token = "0x4009811")]
	[FieldOffset(Offset = "0x40")]
	private SpawnRegion m_SpawnRegion;

	[SerializeField]
	[Token(Token = "0x4009812")]
	[FieldOffset(Offset = "0x48")]
	private BoxCollider m_BoxCollider;

	[SerializeField]
	[Token(Token = "0x4009813")]
	[FieldOffset(Offset = "0x50")]
	private MapDetail m_MapDetail;

	[Tooltip("Optional enable tree scratches and other environmental effects in area")]
	[SerializeField]
	[Token(Token = "0x4009814")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_VisualsGameObject;

	[SerializeField]
	[Token(Token = "0x4009815")]
	[FieldOffset(Offset = "0x60")]
	private GameObject m_AudioGameObject;

	[Token(Token = "0x4009816")]
	[FieldOffset(Offset = "0x68")]
	private bool m_Initialized;

	[Token(Token = "0x60084F5")]
	[Address(RVA = "0x126D920", Offset = "0x126C720", Length = "0x3EF")]
	public void ActivateZone(bool enable)
	{
	}

	[Token(Token = "0x60084F6")]
	[Address(RVA = "0x126DD10", Offset = "0x126CB10", Length = "0x536")]
	public int Debug_MaybePlaceAllCarcasses()
	{
		return 0;
	}

	[Token(Token = "0x60084F7")]
	[Address(RVA = "0x126E250", Offset = "0x126D050", Length = "0x27A")]
	private void MaybePlaceCarcass()
	{
	}

	[Token(Token = "0x60084F8")]
	[Address(RVA = "0x126E4D0", Offset = "0x126D2D0", Length = "0x16E")]
	private void Start()
	{
	}

	[Token(Token = "0x60084F9")]
	[Address(RVA = "0x126E640", Offset = "0x126D440", Length = "0xB6")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60084FA")]
	[Address(RVA = "0x126E700", Offset = "0x126D500", Length = "0xA9")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x60084FB")]
	[Address(RVA = "0x126E7B0", Offset = "0x126D5B0", Length = "0xA9")]
	private void OnTriggerStay(Collider c)
	{
	}

	[Token(Token = "0x60084FC")]
	[Address(RVA = "0x126E860", Offset = "0x126D660", Length = "0x1DD")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x60084FD")]
	[Address(RVA = "0x126EA40", Offset = "0x126D840", Length = "0x7E")]
	private void MaybeDisableOtherSpawnRegionsInRange(bool enable)
	{
	}

	[Token(Token = "0x60084FE")]
	[Address(RVA = "0x126EAC0", Offset = "0x126D8C0", Length = "0x5F")]
	public CougarTerritoryZoneTrigger()
	{
	}
}

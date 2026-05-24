using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000433")]
public class MapDetail : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40025B8")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Map> m_Map;

	[Token(Token = "0x40025B9")]
	[FieldOffset(Offset = "0x28")]
	public MapIcon.MapIconType m_IconType;

	[Token(Token = "0x40025BA")]
	[FieldOffset(Offset = "0x30")]
	public string m_LocID;

	[Token(Token = "0x40025BB")]
	[FieldOffset(Offset = "0x38")]
	public string m_SpriteName;

	[Token(Token = "0x40025BC")]
	[FieldOffset(Offset = "0x40")]
	public bool m_RequiresInteraction;

	[Token(Token = "0x40025BD")]
	[FieldOffset(Offset = "0x48")]
	public List<Harvestable> m_HarvestablesSharingIcon;

	[Token(Token = "0x40025BE")]
	[FieldOffset(Offset = "0x50")]
	public bool m_RegisterOnAwake;

	[Token(Token = "0x40025BF")]
	[FieldOffset(Offset = "0x58")]
	public Harvestable[] m_HarvestablesForMapVisibility;

	[Tooltip("The raycast target defaults to the center of the renderer bounds. For things like the reishi stump, where most of the renderer is below the terrain, an offset is required")]
	[Token(Token = "0x40025C0")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 m_RaycastTargetOffset;

	[Token(Token = "0x40025C1")]
	[FieldOffset(Offset = "0x6C")]
	public bool m_ShowDirectionIcon;

	[Range(-180f, 180f)]
	[Tooltip("RIGHT = 180\nDOWN = 90\nLEFT = 0\nUP = -90")]
	[Token(Token = "0x40025C2")]
	[FieldOffset(Offset = "0x70")]
	public float m_DirectionIconAngleDegrees;

	[Token(Token = "0x40025C3")]
	[FieldOffset(Offset = "0x74")]
	public bool m_IsRemovedWithDelay;

	[Tooltip("Enable this if you want to use a different location for the map marker than the location of the gear item itself - set the position in the Target Position")]
	[Token(Token = "0x40025C4")]
	[FieldOffset(Offset = "0x75")]
	public bool m_RevealTargetPosition;

	[Token(Token = "0x40025C5")]
	[FieldOffset(Offset = "0x78")]
	public Vector3 m_TargetPosition;

	[Token(Token = "0x40025C6")]
	[FieldOffset(Offset = "0x84")]
	public float m_SurveyRadius;

	[HideInInspector]
	[Token(Token = "0x40025C7")]
	[FieldOffset(Offset = "0x88")]
	public bool m_IsUnlocked;

	[HideInInspector]
	[Token(Token = "0x40025C8")]
	[FieldOffset(Offset = "0x90")]
	public string m_CustomName;

	[HideInInspector]
	[Token(Token = "0x40025C9")]
	[FieldOffset(Offset = "0x98")]
	public bool m_IsDiscovered;

	[HideInInspector]
	[Token(Token = "0x40025CA")]
	[FieldOffset(Offset = "0x99")]
	public bool m_IsSurveyed;

	[Token(Token = "0x40025CB")]
	[FieldOffset(Offset = "0x9A")]
	private bool m_DidRegister;

	[Token(Token = "0x6001F93")]
	[Address(RVA = "0x7DDFC0", Offset = "0x7DCDC0", Length = "0x7")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001F94")]
	[Address(RVA = "0x7DDFD0", Offset = "0x7DCDD0", Length = "0xB5")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001F95")]
	[Address(RVA = "0x7DE090", Offset = "0x7DCE90", Length = "0x7")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001F96")]
	[Address(RVA = "0x7DE090", Offset = "0x7DCE90", Length = "0x7")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001F97")]
	[Address(RVA = "0x7DE0A0", Offset = "0x7DCEA0", Length = "0xE2")]
	public void UpdateCustomName(string newName)
	{
	}

	[Token(Token = "0x6001F98")]
	[Address(RVA = "0x7DE190", Offset = "0x7DCF90", Length = "0x2FD")]
	public void Register()
	{
	}

	[Token(Token = "0x6001F99")]
	[Address(RVA = "0x7DE490", Offset = "0x7DD290", Length = "0x11")]
	public void Lock()
	{
	}

	[Token(Token = "0x6001F9A")]
	[Address(RVA = "0x7DE4B0", Offset = "0x7DD2B0", Length = "0x1B")]
	public void DiscoverOnInteract()
	{
	}

	[Token(Token = "0x6001F9B")]
	[Address(RVA = "0x7DE4D0", Offset = "0x7DD2D0", Length = "0x8")]
	public void Surveyed()
	{
	}

	[Token(Token = "0x6001F9C")]
	[Address(RVA = "0x7DE4E0", Offset = "0x7DD2E0", Length = "0x11B")]
	public void Unlock(bool ignoreLogged = false)
	{
	}

	[Token(Token = "0x6001F9D")]
	[Address(RVA = "0x7DE600", Offset = "0x7DD400", Length = "0x134")]
	public void AddNoteMapMarker()
	{
	}

	[Token(Token = "0x6001F9E")]
	[Address(RVA = "0x7DE740", Offset = "0x7DD540", Length = "0xE6")]
	public void AddCougarLocation(float radius, bool show)
	{
	}

	[Token(Token = "0x6001F9F")]
	[Address(RVA = "0x7DE830", Offset = "0x7DD630", Length = "0x187")]
	private void SetupMapVisibility()
	{
	}

	[Token(Token = "0x6001FA0")]
	[Address(RVA = "0x7DE9C0", Offset = "0x7DD7C0", Length = "0x191")]
	private void UpdateMapVisibility()
	{
	}

	[Token(Token = "0x6001FA1")]
	[Address(RVA = "0x7DEB60", Offset = "0x7DD960", Length = "0xDB")]
	private void ShowOnMap(bool isShownOnMap)
	{
	}

	[Token(Token = "0x6001FA2")]
	[Address(RVA = "0x7DEC40", Offset = "0x7DDA40", Length = "0xFB")]
	public Vector3 GetWorldPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001FA3")]
	[Address(RVA = "0x7DED40", Offset = "0x7DDB40", Length = "0xC6")]
	public MapDetail()
	{
	}
}

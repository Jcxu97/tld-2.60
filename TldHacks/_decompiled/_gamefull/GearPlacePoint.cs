using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.GameplayTags;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20004A0")]
public class GearPlacePoint : MonoBehaviour
{
	[Token(Token = "0x20004A1")]
	public delegate void OnItemPlaced(GearItem gearItem);

	[SerializeField]
	[Token(Token = "0x4002ACB")]
	[FieldOffset(Offset = "0x20")]
	private List<GameplayTag> m_AllowedGear;

	[Token(Token = "0x4002ACC")]
	[FieldOffset(Offset = "0x28")]
	public bool m_AllowAllCookingItems;

	[Token(Token = "0x4002ACD")]
	[FieldOffset(Offset = "0x30")]
	public Fire m_FireToAttach;

	[Token(Token = "0x4002ACE")]
	[FieldOffset(Offset = "0x38")]
	public Switch m_CookingSurfaceSwitch;

	[Token(Token = "0x4002ACF")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 m_ColliderSize;

	[Token(Token = "0x4002AD0")]
	[FieldOffset(Offset = "0x4C")]
	public bool m_AddToHierarchy;

	[SerializeField]
	[Token(Token = "0x4002AD1")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_BodyHarvest> m_BodyHarvest;

	[NonSerialized]
	[HideInInspector]
	[Token(Token = "0x4002AD2")]
	[FieldOffset(Offset = "0x58")]
	public OnItemPlaced m_OnItemPlaced;

	[Token(Token = "0x4002AD3")]
	[FieldOffset(Offset = "0x60")]
	private float MIN_DIST_GEAR_PLACEMENT;

	[Token(Token = "0x4002AD4")]
	[FieldOffset(Offset = "0x68")]
	private GearItem m_PlacedGear;

	[Token(Token = "0x4002AD5")]
	[FieldOffset(Offset = "0x70")]
	private GameObject m_ColliderObject;

	[Token(Token = "0x4002AD6")]
	[FieldOffset(Offset = "0x78")]
	private int m_UpdateRefreshCounter;

	[Token(Token = "0x600234B")]
	[Address(RVA = "0x852DD0", Offset = "0x851BD0", Length = "0xF3")]
	private void Start()
	{
	}

	[Token(Token = "0x600234C")]
	[Address(RVA = "0x852ED0", Offset = "0x851CD0", Length = "0x252")]
	public void Update()
	{
	}

	[Token(Token = "0x600234D")]
	[Address(RVA = "0x65D9D0", Offset = "0x65C7D0", Length = "0x5")]
	public GearItem GetPlacedGear()
	{
		return null;
	}

	[Token(Token = "0x600234E")]
	[Address(RVA = "0x853130", Offset = "0x851F30", Length = "0x33")]
	public void RefreshPlacedGear()
	{
	}

	[Token(Token = "0x600234F")]
	[Address(RVA = "0x853170", Offset = "0x851F70", Length = "0x183")]
	public void ItemPlaced(GearItem previousPlacedItem, GearItem newPlacedItem)
	{
	}

	[Token(Token = "0x6002350")]
	[Address(RVA = "0x853300", Offset = "0x852100", Length = "0x275")]
	public void DropAndPlaceItem(GearItem newPlacedItem)
	{
	}

	[Token(Token = "0x6002351")]
	[Address(RVA = "0x853580", Offset = "0x852380", Length = "0x43E")]
	public void PlaceGear(GearItem gi, bool reposition)
	{
	}

	[Token(Token = "0x6002352")]
	[Address(RVA = "0x8539C0", Offset = "0x8527C0", Length = "0x1AB")]
	public bool IsAllowedGearItem(GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x6002353")]
	[Address(RVA = "0x853B70", Offset = "0x852970", Length = "0x379")]
	public static GearPlacePoint FindFirstEmptyPlacePoint(GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x6002354")]
	[Address(RVA = "0x853EF0", Offset = "0x852CF0", Length = "0x416")]
	public static GearPlacePoint FindTargetPlacePoint(GameObject parent, string name)
	{
		return null;
	}

	[Token(Token = "0x6002355")]
	[Address(RVA = "0x854310", Offset = "0x853110", Length = "0x369")]
	public static bool HasNonEmptyPlacePoint(GameObject parent)
	{
		return false;
	}

	[Token(Token = "0x6002356")]
	[Address(RVA = "0x854680", Offset = "0x853480", Length = "0xA9")]
	private void ResetPlacedGear()
	{
	}

	[Token(Token = "0x6002357")]
	[Address(RVA = "0x854730", Offset = "0x853530", Length = "0x504")]
	private void CheckGearStillPlaced()
	{
	}

	[Token(Token = "0x6002358")]
	[Address(RVA = "0x854C40", Offset = "0x853A40", Length = "0x7B4")]
	private GearItem FindGearAtPlacePoint()
	{
		return null;
	}

	[Token(Token = "0x6002359")]
	[Address(RVA = "0x855400", Offset = "0x854200", Length = "0x55C")]
	private void MaybeInstantiateDummyCookingPot()
	{
	}

	[Token(Token = "0x600235A")]
	[Address(RVA = "0x855960", Offset = "0x854760", Length = "0x534")]
	private void UpdateAttachedFire(GearItem placedGearOld, GearItem placedGearNew)
	{
	}

	[Token(Token = "0x600235B")]
	[Address(RVA = "0x855EA0", Offset = "0x854CA0", Length = "0x492")]
	private void AddDefaultCapsuleCollider()
	{
	}

	[Token(Token = "0x600235C")]
	[Address(RVA = "0x856340", Offset = "0x855140", Length = "0x213")]
	private void CheckForPlacedGearAfterLoad()
	{
	}

	[Token(Token = "0x600235D")]
	[Address(RVA = "0x856560", Offset = "0x855360", Length = "0x79")]
	public GearPlacePoint()
	{
	}
}

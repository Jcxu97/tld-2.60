using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.Gear;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Destroy Selected Player Items", 0)]
[Description("Will remove a filtered list of items from player's inventory or dropped on the ground in the scene.")]
[Category("TLD Actions/Player")]
[Token(Token = "0x200121A")]
public class Action_DestroySelectedPlayerItems : ActionTask
{
	[Token(Token = "0x200121B")]
	public enum VisibleClothingRegion
	{
		[Token(Token = "0x40089E2")]
		Face,
		[Token(Token = "0x40089E3")]
		Neck,
		[Token(Token = "0x40089E4")]
		Head,
		[Token(Token = "0x40089E5")]
		Hands,
		[Token(Token = "0x40089E6")]
		Chest,
		[Token(Token = "0x40089E7")]
		Legs,
		[Token(Token = "0x40089E8")]
		Feet,
		[Token(Token = "0x40089E9")]
		Accessory
	}

	[Token(Token = "0x200121C")]
	public enum VisibleClothingLayer
	{
		[Token(Token = "0x40089EB")]
		Base,
		[Token(Token = "0x40089EC")]
		Mid,
		[Token(Token = "0x40089ED")]
		Top,
		[Token(Token = "0x40089EE")]
		Top2
	}

	[Serializable]
	[Token(Token = "0x200121D")]
	public class ClothingRegionInfo
	{
		[Token(Token = "0x40089EF")]
		[FieldOffset(Offset = "0x10")]
		public VisibleClothingRegion region;

		[Token(Token = "0x40089F0")]
		[FieldOffset(Offset = "0x18")]
		public List<VisibleClothingLayer> destroyLayerList;

		[Token(Token = "0x600771A")]
		[Address(RVA = "0x1156800", Offset = "0x1155600", Length = "0x1D4")]
		public bool IsClothingLayerToDestroy(ClothingLayer cl)
		{
			return false;
		}

		[Token(Token = "0x600771B")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ClothingRegionInfo()
		{
		}
	}

	[Tooltip("Destroy items in the player's inventory")]
	[Token(Token = "0x40089DA")]
	[FieldOffset(Offset = "0x68")]
	public bool destroyInventoryItems;

	[Tooltip("Destroy narrative/collectibes when destroying inventory items")]
	[Token(Token = "0x40089DB")]
	[FieldOffset(Offset = "0x69")]
	public bool destroyNarrativeCollectibleItems;

	[Tooltip("Destroy player dropped items within a certain range of player")]
	[Token(Token = "0x40089DC")]
	[FieldOffset(Offset = "0x6A")]
	public bool destroyDroppedItemsInRange;

	[Tooltip("Destroy player dropped items within a container in a certain range of player")]
	[Token(Token = "0x40089DD")]
	[FieldOffset(Offset = "0x6B")]
	public bool includeDroppedInContainer;

	[Tooltip("Only destroy player dropped items within this range of player")]
	[Token(Token = "0x40089DE")]
	[FieldOffset(Offset = "0x6C")]
	public float dropRangeFromPlayer;

	[Token(Token = "0x40089DF")]
	[FieldOffset(Offset = "0x70")]
	public List<ClothingRegionInfo> wornClothingRegionDestroyList;

	[SerializeField]
	[Token(Token = "0x40089E0")]
	[FieldOffset(Offset = "0x78")]
	private GearType m_GearType;

	[Token(Token = "0x6007717")]
	[Address(RVA = "0x1155D40", Offset = "0x1154B40", Length = "0x159")]
	private ClothingRegionInfo GetClothingRegionDestroyInfo(ClothingRegion region)
	{
		return null;
	}

	[Token(Token = "0x6007718")]
	[Address(RVA = "0x1155EA0", Offset = "0x1154CA0", Length = "0x931")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007719")]
	[Address(RVA = "0x11567E0", Offset = "0x11555E0", Length = "0x17")]
	public Action_DestroySelectedPlayerItems()
	{
	}
}

using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000434")]
public class MapMarker
{
	[Token(Token = "0x40025CC")]
	[FieldOffset(Offset = "0x10")]
	public MapIcon.MapIconType m_IconType;

	[Token(Token = "0x40025CD")]
	[FieldOffset(Offset = "0x18")]
	public string m_LocID;

	[Token(Token = "0x40025CE")]
	[FieldOffset(Offset = "0x20")]
	public string m_SpriteName;

	[Token(Token = "0x40025CF")]
	[FieldOffset(Offset = "0x28")]
	public bool m_RequiresInteraction;

	[Token(Token = "0x40025D0")]
	[FieldOffset(Offset = "0x30")]
	public List<Harvestable> m_HarvestablesSharingIcon;

	[Token(Token = "0x40025D1")]
	[FieldOffset(Offset = "0x38")]
	public bool m_RegisterOnAwake;

	[Token(Token = "0x40025D2")]
	[FieldOffset(Offset = "0x40")]
	public Harvestable[] m_HarvestablesForMapVisibility;

	[Token(Token = "0x40025D3")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 m_RaycastTargetOffset;

	[Token(Token = "0x40025D4")]
	[FieldOffset(Offset = "0x54")]
	public bool m_ShowDirectionIcon;

	[Token(Token = "0x40025D5")]
	[FieldOffset(Offset = "0x58")]
	public float m_DirectionIconAngleDegrees;

	[Token(Token = "0x40025D6")]
	[FieldOffset(Offset = "0x5C")]
	public bool m_IsRemovedWithDelay;

	[Token(Token = "0x6001FA4")]
	[Address(RVA = "0x7DEE10", Offset = "0x7DDC10", Length = "0x8B")]
	public MapMarker()
	{
	}
}

using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000696")]
public class MapElementSaveData
{
	[Token(Token = "0x400449F")]
	[FieldOffset(Offset = "0x10")]
	public string m_SpriteName;

	[Token(Token = "0x40044A0")]
	[FieldOffset(Offset = "0x18")]
	public string m_LocationNameLocID;

	[Token(Token = "0x40044A1")]
	[FieldOffset(Offset = "0x20")]
	public string m_CustomName;

	[Token(Token = "0x40044A2")]
	[FieldOffset(Offset = "0x28")]
	public bool m_BigSprite;

	[Token(Token = "0x40044A3")]
	[FieldOffset(Offset = "0x29")]
	public bool m_IsDetail;

	[Token(Token = "0x40044A4")]
	[FieldOffset(Offset = "0x2A")]
	public bool m_IsArea;

	[Token(Token = "0x40044A5")]
	[FieldOffset(Offset = "0x2B")]
	public bool m_NameIsKnown;

	[Token(Token = "0x40044A6")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 m_PositionOnMap;

	[Token(Token = "0x40044A7")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 m_AreaSizeOnMap;

	[Token(Token = "0x40044A8")]
	[FieldOffset(Offset = "0x3C")]
	public float m_DirectionalAngle;

	[Token(Token = "0x40044A9")]
	[FieldOffset(Offset = "0x40")]
	public bool m_MergeWithNearbyLocationIcons;

	[Token(Token = "0x40044AA")]
	[FieldOffset(Offset = "0x48")]
	public List<string> m_ActiveMissionLocIDs;

	[Token(Token = "0x40044AB")]
	[FieldOffset(Offset = "0x50")]
	public List<string> m_ActiveMissionTimerIDs;

	[Token(Token = "0x40044AC")]
	[FieldOffset(Offset = "0x58")]
	public List<string> m_ActiveMissionIDs;

	[Token(Token = "0x40044AD")]
	[FieldOffset(Offset = "0x60")]
	public List<string> m_ActiveObjectiveIDs;

	[Token(Token = "0x40044AE")]
	[FieldOffset(Offset = "0x68")]
	public string m_Guid;

	[NonSerialized]
	[Token(Token = "0x40044AF")]
	[FieldOffset(Offset = "0x70")]
	public ClusterCell m_ClusterCell;

	[Token(Token = "0x6003822")]
	[Address(RVA = "0xAEBC00", Offset = "0xAEAA00", Length = "0x3CB")]
	public MapElementSaveData()
	{
	}
}

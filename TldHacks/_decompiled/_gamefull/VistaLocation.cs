using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200044A")]
public class VistaLocation : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200044B")]
	public class MapDetailPoint
	{
		[Token(Token = "0x40026FA")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 m_Position;

		[Token(Token = "0x40026FB")]
		[FieldOffset(Offset = "0x18")]
		public float m_Radius;

		[Token(Token = "0x6002069")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public MapDetailPoint()
		{
		}
	}

	[Token(Token = "0x40026EF")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocationName;

	[Token(Token = "0x40026F0")]
	[FieldOffset(Offset = "0x28")]
	public string m_MapRevealMaskPath;

	[Token(Token = "0x40026F1")]
	[FieldOffset(Offset = "0x30")]
	public bool m_IsAdditive;

	[Token(Token = "0x40026F2")]
	[FieldOffset(Offset = "0x34")]
	public Vector4 m_MaskOffsets;

	[Token(Token = "0x40026F3")]
	[FieldOffset(Offset = "0x48")]
	public List<MapDetailPoint> m_MapDetailPoints;

	[Token(Token = "0x40026F4")]
	[FieldOffset(Offset = "0x50")]
	public GearItem m_RequiredGearItem;

	[Header("Achievement")]
	[SerializeField]
	[Token(Token = "0x40026F5")]
	[FieldOffset(Offset = "0x58")]
	private bool m_TrackForAchievement;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40026F6")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x40026F7")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_Map> m_Map;

	[Token(Token = "0x40026F8")]
	[FieldOffset(Offset = "0x70")]
	private ObjectGuid m_ObjectGuid;

	[Token(Token = "0x40026F9")]
	private const string PLAYER_COMPARE_TAG = "Player";

	[Token(Token = "0x600205F")]
	[Address(RVA = "0x7F7650", Offset = "0x7F6450", Length = "0x10E")]
	public string GetGuid()
	{
		return null;
	}

	[Token(Token = "0x6002060")]
	[Address(RVA = "0x7F7760", Offset = "0x7F6560", Length = "0x175")]
	public void Surveyed()
	{
	}

	[Token(Token = "0x6002061")]
	[Address(RVA = "0x7F78E0", Offset = "0x7F66E0", Length = "0x1EF")]
	public bool HasRequiredGearItem()
	{
		return false;
	}

	[Token(Token = "0x6002062")]
	[Address(RVA = "0x7F7AD0", Offset = "0x7F68D0", Length = "0x1EF")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002063")]
	[Address(RVA = "0x7F7CC0", Offset = "0x7F6AC0", Length = "0xB1")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002064")]
	[Address(RVA = "0x7F7D80", Offset = "0x7F6B80", Length = "0x3E7")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002065")]
	[Address(RVA = "0x7F8170", Offset = "0x7F6F70", Length = "0x75")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6002066")]
	[Address(RVA = "0x7F81F0", Offset = "0x7F6FF0", Length = "0x1FA")]
	private void RemoveFromMap()
	{
	}

	[Token(Token = "0x6002067")]
	[Address(RVA = "0x7F83F0", Offset = "0x7F71F0", Length = "0x107")]
	private void MaybeHideNotification(Panel_Map map, Panel_HUD hud)
	{
	}

	[Token(Token = "0x6002068")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public VistaLocation()
	{
	}
}

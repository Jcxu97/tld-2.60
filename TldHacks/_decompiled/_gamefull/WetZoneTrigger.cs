using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20009D9")]
public class WetZoneTrigger : MonoBehaviour
{
	[Token(Token = "0x40063E4")]
	[FieldOffset(Offset = "0x20")]
	public List<ClothingRegion> m_ClothingRegionsToMakeWet;

	[Token(Token = "0x40063E5")]
	[FieldOffset(Offset = "0x28")]
	public bool m_OnlyOuterLayerGetWet;

	[Token(Token = "0x40063E6")]
	[FieldOffset(Offset = "0x2C")]
	public float m_WetnessIncreasePerHour;

	[Token(Token = "0x40063E7")]
	[FieldOffset(Offset = "0x30")]
	public bool m_InstantWetOnContact;

	[Token(Token = "0x40063E8")]
	[FieldOffset(Offset = "0x31")]
	public bool m_UnfreezeOnContact;

	[Token(Token = "0x40063E9")]
	[FieldOffset(Offset = "0x38")]
	public string m_LocIDToShowOnContact;

	[Token(Token = "0x40063EA")]
	[FieldOffset(Offset = "0x40")]
	public float m_DelaySeconds;

	[Token(Token = "0x40063EB")]
	[FieldOffset(Offset = "0x48")]
	public string m_LocIDToShowDuringDelay;

	[Token(Token = "0x40063EC")]
	[FieldOffset(Offset = "0x50")]
	public float m_ColdIncreaseOnWaterEntry;

	[Token(Token = "0x40063ED")]
	[FieldOffset(Offset = "0x54")]
	public float m_ColdIncreasePerHour;

	[Token(Token = "0x40063EE")]
	[FieldOffset(Offset = "0x58")]
	public bool m_SetLayerToTriggerIgnoreRaycast;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40063EF")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x40063F0")]
	[FieldOffset(Offset = "0x68")]
	private bool m_PlayerInTrigger;

	[Token(Token = "0x40063F1")]
	[FieldOffset(Offset = "0x69")]
	private bool m_ShowedContactLocID;

	[Token(Token = "0x40063F2")]
	[FieldOffset(Offset = "0x6C")]
	private float m_SecondsInTrigger;

	[Token(Token = "0x40063F3")]
	[FieldOffset(Offset = "0x70")]
	private int m_BrokenIceCount;

	[Token(Token = "0x40063F4")]
	[FieldOffset(Offset = "0x78")]
	private BreakableIce m_BreakableIce;

	[Token(Token = "0x60056D8")]
	[Address(RVA = "0xEC18B0", Offset = "0xEC06B0", Length = "0x107")]
	private void Start()
	{
	}

	[Token(Token = "0x60056D9")]
	[Address(RVA = "0xEC19C0", Offset = "0xEC07C0", Length = "0x3CE")]
	private void Update()
	{
	}

	[Token(Token = "0x60056DA")]
	[Address(RVA = "0xEC1D90", Offset = "0xEC0B90", Length = "0x9E")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60056DB")]
	[Address(RVA = "0xEC1E30", Offset = "0xEC0C30", Length = "0xC0")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60056DC")]
	[Address(RVA = "0xEC1F00", Offset = "0xEC0D00", Length = "0x325")]
	private void IncreaseWetness(float wetnessValue)
	{
	}

	[Token(Token = "0x60056DD")]
	[Address(RVA = "0xEC2230", Offset = "0xEC1030", Length = "0x12D")]
	private void ApplyFreezing()
	{
	}

	[Token(Token = "0x60056DE")]
	[Address(RVA = "0xEC2360", Offset = "0xEC1160", Length = "0x230")]
	private void BreakIce()
	{
	}

	[Token(Token = "0x60056DF")]
	[Address(RVA = "0xEC25A0", Offset = "0xEC13A0", Length = "0x47")]
	public WetZoneTrigger()
	{
	}
}

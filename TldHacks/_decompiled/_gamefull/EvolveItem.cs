using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000480")]
public class EvolveItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40028C6")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[Token(Token = "0x40028C7")]
	[FieldOffset(Offset = "0x28")]
	public GearItem m_GearItemToBecome;

	[Range(0f, 100f)]
	[Token(Token = "0x40028C8")]
	[FieldOffset(Offset = "0x30")]
	public int m_StartEvolvePercent;

	[Token(Token = "0x40028C9")]
	[FieldOffset(Offset = "0x34")]
	public float m_TimeToEvolveGameDays;

	[Token(Token = "0x40028CA")]
	[FieldOffset(Offset = "0x38")]
	public bool m_RequireIndoors;

	[HideInInspector]
	[Token(Token = "0x40028CB")]
	[FieldOffset(Offset = "0x39")]
	public bool m_ForceNoAutoEvolve;

	[Token(Token = "0x40028CC")]
	[FieldOffset(Offset = "0x3C")]
	private float m_TimeSpentEvolvingGameHours;

	[Token(Token = "0x40028CD")]
	[FieldOffset(Offset = "0x40")]
	private GearItem m_GearItem;

	[Token(Token = "0x40028CE")]
	[FieldOffset(Offset = "0x48")]
	private List<Collider> m_IndoorSpaceTriggerColliders;

	[Token(Token = "0x40028CF")]
	[FieldOffset(Offset = "0x50")]
	private int m_AutoEvolutionCheckCounter;

	[Token(Token = "0x40028D0")]
	[FieldOffset(Offset = "0x54")]
	private bool m_DoneAutoEvolutionCheck;

	[Token(Token = "0x40028D1")]
	private static EvolveItemSaveData m_EvolveItemSaveData;

	[Token(Token = "0x60021F3")]
	[Address(RVA = "0x823C60", Offset = "0x822A60", Length = "0x2A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60021F4")]
	[Address(RVA = "0x823F10", Offset = "0x822D10", Length = "0x1B6")]
	public void Update()
	{
	}

	[Token(Token = "0x60021F5")]
	[Address(RVA = "0x8240D0", Offset = "0x822ED0", Length = "0x17C")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60021F6")]
	[Address(RVA = "0x824250", Offset = "0x823050", Length = "0x12C")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60021F7")]
	[Address(RVA = "0x824380", Offset = "0x823180", Length = "0x17")]
	public float GetEvolveProgressValue()
	{
		return 0f;
	}

	[Token(Token = "0x60021F8")]
	[Address(RVA = "0x8243A0", Offset = "0x8231A0", Length = "0x17")]
	public void SetEvolveProgressValue(float progressVal)
	{
	}

	[Token(Token = "0x60021F9")]
	[Address(RVA = "0x8243C0", Offset = "0x8231C0", Length = "0x184")]
	public string GetEvolvedPercentString()
	{
		return null;
	}

	[Token(Token = "0x60021FA")]
	[Address(RVA = "0x824550", Offset = "0x823350", Length = "0xFA")]
	public string GetTimeToDryStringInventory()
	{
		return null;
	}

	[Token(Token = "0x60021FB")]
	[Address(RVA = "0x824650", Offset = "0x823450", Length = "0x61")]
	private bool CanEvolve()
	{
		return false;
	}

	[Token(Token = "0x60021FC")]
	[Address(RVA = "0x8246C0", Offset = "0x8234C0", Length = "0x65")]
	private bool CanAutoEvolve()
	{
		return false;
	}

	[Token(Token = "0x60021FD")]
	[Address(RVA = "0x824730", Offset = "0x823530", Length = "0x144")]
	private bool IsIndoorScene()
	{
		return false;
	}

	[Token(Token = "0x60021FE")]
	[Address(RVA = "0x824880", Offset = "0x823680", Length = "0x182")]
	private bool IsInspectingFromHarvest()
	{
		return false;
	}

	[Token(Token = "0x60021FF")]
	[Address(RVA = "0x824A10", Offset = "0x823810", Length = "0x258")]
	private bool ObjectInIndoorTrigger()
	{
		return false;
	}

	[Token(Token = "0x6002200")]
	[Address(RVA = "0x824C70", Offset = "0x823A70", Length = "0x6A1")]
	public void DoEvolution()
	{
	}

	[Token(Token = "0x6002201")]
	[Address(RVA = "0x825320", Offset = "0x824120", Length = "0x4A")]
	public EvolveItem()
	{
	}
}

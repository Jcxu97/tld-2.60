using Cpp2ILInjected;
using TLD.IntBackedUnit;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000501")]
public class WellFed : MonoBehaviour
{
	[Token(Token = "0x4002DCF")]
	[FieldOffset(Offset = "0x20")]
	public float m_HoursNotStarvingRequired;

	[Token(Token = "0x4002DD0")]
	[FieldOffset(Offset = "0x28")]
	public ItemWeight m_CarryCapacityBonus;

	[Token(Token = "0x4002DD1")]
	[FieldOffset(Offset = "0x30")]
	public float m_MaxConditionBonusPercent;

	[Token(Token = "0x4002DD2")]
	[FieldOffset(Offset = "0x38")]
	public string m_WellFedVO;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002DD3")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4002DD4")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4002DD5")]
	[FieldOffset(Offset = "0x50")]
	private bool m_Active;

	[Token(Token = "0x4002DD6")]
	[FieldOffset(Offset = "0x54")]
	private float m_ElapsedHoursNotStarving;

	[Token(Token = "0x4002DD7")]
	[FieldOffset(Offset = "0x58")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002DD8")]
	private static WellFedSaveDataProxy m_WellFedSaveDataProxy;

	[Token(Token = "0x60025ED")]
	[Address(RVA = "0x899E70", Offset = "0x898C70", Length = "0xF")]
	public void Start()
	{
	}

	[Token(Token = "0x60025EE")]
	[Address(RVA = "0x899E80", Offset = "0x898C80", Length = "0x1DC")]
	public void Update()
	{
	}

	[Token(Token = "0x60025EF")]
	[Address(RVA = "0x89A060", Offset = "0x898E60", Length = "0x100")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60025F0")]
	[Address(RVA = "0x89A170", Offset = "0x898F70", Length = "0xA1")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60025F1")]
	[Address(RVA = "0x89A220", Offset = "0x899020", Length = "0x1D5")]
	public void WellFedStart(string causeId, bool displayIcon, bool nofx = false)
	{
	}

	[Token(Token = "0x60025F2")]
	[Address(RVA = "0x89A400", Offset = "0x899200", Length = "0x194")]
	public void WellFedEnd(bool nofx = false)
	{
	}

	[Token(Token = "0x60025F3")]
	[Address(RVA = "0x6674B0", Offset = "0x6662B0", Length = "0x5")]
	public bool HasWellFed()
	{
		return false;
	}

	[Token(Token = "0x60025F4")]
	[Address(RVA = "0x89A5A0", Offset = "0x8993A0", Length = "0x5D")]
	public string GetCauseString()
	{
		return null;
	}

	[Token(Token = "0x60025F5")]
	[Address(RVA = "0x89A600", Offset = "0x899400", Length = "0x31")]
	public string GetCauseLocalizationId()
	{
		return null;
	}

	[Token(Token = "0x60025F6")]
	[Address(RVA = "0x89A640", Offset = "0x899440", Length = "0x2C")]
	private void UpdateWellFed()
	{
	}

	[Token(Token = "0x60025F7")]
	[Address(RVA = "0x89A670", Offset = "0x899470", Length = "0x136")]
	private void CheckForWellFed()
	{
	}

	[Token(Token = "0x60025F8")]
	[Address(RVA = "0x89A7B0", Offset = "0x8995B0", Length = "0xC6")]
	private bool CanAccumulateBuff()
	{
		return false;
	}

	[Token(Token = "0x60025F9")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public WellFed()
	{
	}
}

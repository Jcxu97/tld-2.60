using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000517")]
public class FoodPoisoning : MonoBehaviour
{
	[Token(Token = "0x4002EA6")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x4002EA7")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDescription;

	[Token(Token = "0x4002EA8")]
	[FieldOffset(Offset = "0x30")]
	public float m_DurationHoursMin;

	[Token(Token = "0x4002EA9")]
	[FieldOffset(Offset = "0x34")]
	public float m_DurationHoursMax;

	[Token(Token = "0x4002EAA")]
	[FieldOffset(Offset = "0x38")]
	public float m_HPDrainPerHour;

	[Token(Token = "0x4002EAB")]
	[FieldOffset(Offset = "0x3C")]
	public float m_FatigueIncreasePerHour;

	[Range(0f, 100f)]
	[Token(Token = "0x4002EAC")]
	[FieldOffset(Offset = "0x40")]
	public float m_StopDegradingConditionAtPercent;

	[Token(Token = "0x4002EAD")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_AntibioticsPrefab;

	[Token(Token = "0x4002EAE")]
	[FieldOffset(Offset = "0x50")]
	public float m_NumHoursRestForCure;

	[Header("Audio")]
	[Token(Token = "0x4002EAF")]
	[FieldOffset(Offset = "0x58")]
	public string m_FoodPoisoningVO;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002EB0")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4002EB1")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4002EB2")]
	[FieldOffset(Offset = "0x70")]
	private bool m_Active;

	[Token(Token = "0x4002EB3")]
	[FieldOffset(Offset = "0x74")]
	private float m_ElapsedHours;

	[Token(Token = "0x4002EB4")]
	[FieldOffset(Offset = "0x78")]
	private float m_DurationHours;

	[Token(Token = "0x4002EB5")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_AntibioticsTaken;

	[Token(Token = "0x4002EB6")]
	[FieldOffset(Offset = "0x80")]
	private float m_ElapsedRest;

	[Token(Token = "0x4002EB7")]
	[FieldOffset(Offset = "0x88")]
	private string m_CauseLocID;

	[Token(Token = "0x4002EB8")]
	[FieldOffset(Offset = "0x90")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002EB9")]
	private static FoodPoisoningSaveDataProxy m_FoodPoisoningSaveDataProxy;

	[Token(Token = "0x1700026E")]
	public string m_DisplayName
	{
		[Token(Token = "0x60026A7")]
		[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026F")]
	public string m_Description
	{
		[Token(Token = "0x60026A8")]
		[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60026A9")]
	[Address(RVA = "0x8A47C0", Offset = "0x8A35C0", Length = "0x15")]
	public void Start()
	{
	}

	[Token(Token = "0x60026AA")]
	[Address(RVA = "0x8A47E0", Offset = "0x8A35E0", Length = "0xB9")]
	public void Update()
	{
	}

	[Token(Token = "0x60026AB")]
	[Address(RVA = "0x8A48A0", Offset = "0x8A36A0", Length = "0x1D3")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60026AC")]
	[Address(RVA = "0x8A4A80", Offset = "0x8A3880", Length = "0x19B")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60026AD")]
	[Address(RVA = "0x8A4C20", Offset = "0x8A3A20", Length = "0x35A")]
	public void FoodPoisoningStart(string causeId, bool displayIcon, bool nofx = false)
	{
	}

	[Token(Token = "0x60026AE")]
	[Address(RVA = "0x8A4F80", Offset = "0x8A3D80", Length = "0x114")]
	public void FoodPoisoningEnd(bool nofx = false)
	{
	}

	[Token(Token = "0x60026AF")]
	[Address(RVA = "0x664EB0", Offset = "0x663CB0", Length = "0x5")]
	public bool HasFoodPoisoning()
	{
		return false;
	}

	[Token(Token = "0x60026B0")]
	[Address(RVA = "0x634890", Offset = "0x633690", Length = "0x5")]
	public bool HasTakenAntibiotics()
	{
		return false;
	}

	[Token(Token = "0x60026B1")]
	[Address(RVA = "0x8A50A0", Offset = "0x8A3EA0", Length = "0xE")]
	public float GetRestAmountRemaining()
	{
		return 0f;
	}

	[Token(Token = "0x60026B2")]
	[Address(RVA = "0x8A50B0", Offset = "0x8A3EB0", Length = "0x55")]
	public string GetCauseString()
	{
		return null;
	}

	[Token(Token = "0x60026B3")]
	[Address(RVA = "0x8A5110", Offset = "0x8A3F10", Length = "0xB")]
	public void TakeAntibiotics()
	{
	}

	[Token(Token = "0x60026B4")]
	[Address(RVA = "0x8A5120", Offset = "0x8A3F20", Length = "0x1D")]
	public void AddRest(float hours)
	{
	}

	[Token(Token = "0x60026B5")]
	[Address(RVA = "0x8A5140", Offset = "0x8A3F40", Length = "0x38A")]
	private void UpdateFoodPoisoning()
	{
	}

	[Token(Token = "0x60026B6")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FoodPoisoning()
	{
	}
}

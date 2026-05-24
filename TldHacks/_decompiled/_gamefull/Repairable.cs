using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;

[Token(Token = "0x20004CA")]
public class Repairable : MonoBehaviour, IRepairable
{
	[AutoComponent(ComponentRequirement.Required)]
	[SerializeField]
	[Token(Token = "0x4002C05")]
	[FieldOffset(Offset = "0x20")]
	private GearItem m_GearItem;

	[HideInInspector]
	[Token(Token = "0x4002C06")]
	[FieldOffset(Offset = "0x28")]
	public GearItem[] m_RequiredGear;

	[HideInInspector]
	[Token(Token = "0x4002C07")]
	[FieldOffset(Offset = "0x30")]
	public int[] m_RequiredGearUnits;

	[Token(Token = "0x4002C08")]
	[FieldOffset(Offset = "0x38")]
	public float m_ConditionIncrease;

	[Range(0f, 100f)]
	[Token(Token = "0x4002C09")]
	[FieldOffset(Offset = "0x3C")]
	public float m_RepairConditionCap;

	[Token(Token = "0x4002C0A")]
	[FieldOffset(Offset = "0x40")]
	public int m_DurationMinutes;

	[Token(Token = "0x4002C0B")]
	[FieldOffset(Offset = "0x48")]
	public string m_RepairAudio;

	[Token(Token = "0x4002C0C")]
	[FieldOffset(Offset = "0x50")]
	public ToolsItem[] m_RepairToolChoices;

	[Token(Token = "0x4002C0D")]
	[FieldOffset(Offset = "0x58")]
	public bool m_RequiresToolToRepair;

	[Token(Token = "0x4002C0E")]
	[FieldOffset(Offset = "0x59")]
	public bool m_NeverFail;

	[Token(Token = "0x4002C0F")]
	[FieldOffset(Offset = "0x60")]
	private List<ToolsItem> m_FilteredRepairToolChoices;

	[Token(Token = "0x600248E")]
	[Address(RVA = "0x86AA10", Offset = "0x869810", Length = "0x21D")]
	public void Start()
	{
	}

	[Token(Token = "0x600248F")]
	[Address(RVA = "0x86AC30", Offset = "0x869A30", Length = "0x7")]
	public GameObject GetGameObject()
	{
		return null;
	}

	[Token(Token = "0x6002490")]
	[Address(RVA = "0x86AC40", Offset = "0x869A40", Length = "0x1A")]
	public int GetNumMaterialsRequired()
	{
		return 0;
	}

	[Token(Token = "0x6002491")]
	[Address(RVA = "0x86AC60", Offset = "0x869A60", Length = "0x37")]
	public GearItem GetMaterialRequired(int index)
	{
		return null;
	}

	[Token(Token = "0x6002492")]
	[Address(RVA = "0x86ACA0", Offset = "0x869AA0", Length = "0x36")]
	public int GetRequiredGearUnits(int index)
	{
		return 0;
	}

	[Token(Token = "0x6002493")]
	[Address(RVA = "0x507940", Offset = "0x506740", Length = "0x4")]
	public int GetDurationMinutes()
	{
		return 0;
	}

	[Token(Token = "0x6002494")]
	[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
	public string GetRepairAudio()
	{
		return null;
	}

	[Token(Token = "0x6002495")]
	[Address(RVA = "0x86ACE0", Offset = "0x869AE0", Length = "0x52")]
	public int GetNumRepairToolChoices()
	{
		return 0;
	}

	[Token(Token = "0x6002496")]
	[Address(RVA = "0x86AD40", Offset = "0x869B40", Length = "0xA5")]
	public ToolsItem GetRepairToolChoice(int index)
	{
		return null;
	}

	[Token(Token = "0x6002497")]
	[Address(RVA = "0x86ADF0", Offset = "0x869BF0", Length = "0x2B")]
	public List<ToolsItem> GetFilteredRepairToolChoices()
	{
		return null;
	}

	[Token(Token = "0x6002498")]
	[Address(RVA = "0x86AE20", Offset = "0x869C20", Length = "0x4A3")]
	private void InitializeRepairToolChoices()
	{
	}

	[Token(Token = "0x6002499")]
	[Address(RVA = "0x67E850", Offset = "0x67D650", Length = "0x5")]
	public bool RequiresToolToRepair()
	{
		return false;
	}

	[Token(Token = "0x600249A")]
	[Address(RVA = "0x86B2D0", Offset = "0x86A0D0", Length = "0xFA")]
	public string GetDisplayName()
	{
		return null;
	}

	[Token(Token = "0x600249B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void OnRepairSuccessful()
	{
	}

	[Token(Token = "0x600249C")]
	[Address(RVA = "0x86B3D0", Offset = "0x86A1D0", Length = "0xFD")]
	public float GetChanceActionSuccess(ToolsItem toolsItem)
	{
		return 0f;
	}

	[Token(Token = "0x600249D")]
	[Address(RVA = "0x86B4D0", Offset = "0x86A2D0", Length = "0x6")]
	public float GetRepairConditionCap()
	{
		return 0f;
	}

	[Token(Token = "0x600249E")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool AlwaysSucceeds()
	{
		return false;
	}

	[Token(Token = "0x600249F")]
	[Address(RVA = "0x86B4E0", Offset = "0x86A2E0", Length = "0x24D")]
	public float GetChanceSuccessfullRepair()
	{
		return 0f;
	}

	[Token(Token = "0x60024A0")]
	[Address(RVA = "0x86B730", Offset = "0x86A530", Length = "0x2B9")]
	public string GetSkillStringValue()
	{
		return null;
	}

	[Token(Token = "0x60024A1")]
	[Address(RVA = "0x86B9F0", Offset = "0x86A7F0", Length = "0x334")]
	public float GetConditionIncreaseFromRepair()
	{
		return 0f;
	}

	[Token(Token = "0x60024A2")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool AffectsCondition()
	{
		return false;
	}

	[Token(Token = "0x60024A3")]
	[Address(RVA = "0x86BD30", Offset = "0x86AB30", Length = "0x4A")]
	public Repairable()
	{
	}
}

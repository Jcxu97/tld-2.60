using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000527")]
public class NPCAfflictions : MonoBehaviour
{
	[Token(Token = "0x2000528")]
	public enum UIOutlineType
	{
		[Token(Token = "0x4002F8B")]
		Female01,
		[Token(Token = "0x4002F8C")]
		Female02,
		[Token(Token = "0x4002F8D")]
		Male01,
		[Token(Token = "0x4002F8E")]
		Male02
	}

	[Token(Token = "0x2000529")]
	private enum ApproachSideSelected
	{
		[Token(Token = "0x4002F90")]
		None,
		[Token(Token = "0x4002F91")]
		SideLeft,
		[Token(Token = "0x4002F92")]
		SideRight
	}

	[Token(Token = "0x4002F75")]
	[FieldOffset(Offset = "0x20")]
	public UIOutlineType m_UIOutline;

	[Token(Token = "0x4002F76")]
	[FieldOffset(Offset = "0x28")]
	public List<NPCAffliction> m_Afflictions;

	[Token(Token = "0x4002F77")]
	[FieldOffset(Offset = "0x30")]
	public bool m_MustCureBeforeCarry;

	[Header("Left side animation")]
	[Token(Token = "0x4002F78")]
	[FieldOffset(Offset = "0x38")]
	public AnimatedInteraction m_DiagnoseIntroLeft;

	[Token(Token = "0x4002F79")]
	[FieldOffset(Offset = "0x40")]
	public AnimatedInteraction m_DiagnoseOutroLeft;

	[Header("Right side animation")]
	[Token(Token = "0x4002F7A")]
	[FieldOffset(Offset = "0x48")]
	public AnimatedInteraction m_DiagnoseIntroRight;

	[Token(Token = "0x4002F7B")]
	[FieldOffset(Offset = "0x50")]
	public AnimatedInteraction m_DiagnoseOutroRight;

	[Header("Animated Interaction parenting")]
	[Token(Token = "0x4002F7C")]
	[FieldOffset(Offset = "0x58")]
	public bool m_ReparentAnimatedInteractionsToNPCParent;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002F7D")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_Diagnosis> m_Diagnosis;

	[Token(Token = "0x4002F7E")]
	[FieldOffset(Offset = "0x68")]
	private NPC m_NPC;

	[Token(Token = "0x4002F7F")]
	[FieldOffset(Offset = "0x70")]
	private ApproachSideSelected m_ApproachSideSelected;

	[Token(Token = "0x4002F80")]
	[FieldOffset(Offset = "0x78")]
	private SyncNode m_SyncNodeLeft;

	[Token(Token = "0x4002F81")]
	[FieldOffset(Offset = "0x80")]
	private SyncNode m_SyncNodeRight;

	[Token(Token = "0x4002F82")]
	[FieldOffset(Offset = "0x88")]
	private Transform m_DiagnoseIntroLeftOriginalParent;

	[Token(Token = "0x4002F83")]
	[FieldOffset(Offset = "0x90")]
	private Transform m_DiagnoseIntroRightOriginalParent;

	[Token(Token = "0x4002F84")]
	[FieldOffset(Offset = "0x98")]
	private Transform m_DiagnoseOutroLeftOriginalParent;

	[Token(Token = "0x4002F85")]
	[FieldOffset(Offset = "0xA0")]
	private Transform m_DiagnoseOutroRightOriginalParent;

	[Token(Token = "0x4002F86")]
	[FieldOffset(Offset = "0xA8")]
	private Collider[] m_ResultColliders;

	[Token(Token = "0x4002F87")]
	private const int MAX_COLLIDERS_COUNT = 5;

	[Token(Token = "0x4002F88")]
	private const float m_CharacterRadius = 0.5f;

	[Token(Token = "0x4002F89")]
	private const float m_CharacterHeight = 1.75f;

	[Token(Token = "0x6002752")]
	[Address(RVA = "0x8AFCC0", Offset = "0x8AEAC0", Length = "0x6D3")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002753")]
	[Address(RVA = "0x8B03A0", Offset = "0x8AF1A0", Length = "0x109")]
	public void AfflictionDiagnosed(NPCAffliction affliction)
	{
	}

	[Token(Token = "0x6002754")]
	[Address(RVA = "0x8B04B0", Offset = "0x8AF2B0", Length = "0x22E")]
	public bool AreAllAfflictionTreated()
	{
		return false;
	}

	[Token(Token = "0x6002755")]
	[Address(RVA = "0x8B06E0", Offset = "0x8AF4E0", Length = "0x16E")]
	private NPCAffliction GetNPCAffliction(AfflictionType afflictionType)
	{
		return null;
	}

	[Token(Token = "0x6002756")]
	[Address(RVA = "0x8B0850", Offset = "0x8AF650", Length = "0x2F")]
	public void HealedAffliction(AfflictionType afflictionType)
	{
	}

	[Token(Token = "0x6002757")]
	[Address(RVA = "0x8B0880", Offset = "0x8AF680", Length = "0xE3")]
	public void HealedAffliction(NPCAffliction affliction)
	{
	}

	[Token(Token = "0x6002758")]
	[Address(RVA = "0x8B0970", Offset = "0x8AF770", Length = "0x8F")]
	private void RemoveAffliction(NPCAffliction affliction)
	{
	}

	[Token(Token = "0x6002759")]
	[Address(RVA = "0x8B0A00", Offset = "0x8AF800", Length = "0x20D")]
	public float GetTotalHitPointReduction()
	{
		return 0f;
	}

	[Token(Token = "0x600275A")]
	[Address(RVA = "0x8B0C10", Offset = "0x8AFA10", Length = "0x209")]
	public void StartDiagnosing()
	{
	}

	[Token(Token = "0x600275B")]
	[Address(RVA = "0x8B0E20", Offset = "0x8AFC20", Length = "0x1B1")]
	public void EndDiagnosing()
	{
	}

	[Token(Token = "0x600275C")]
	[Address(RVA = "0x8B0FE0", Offset = "0x8AFDE0", Length = "0x407")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600275D")]
	[Address(RVA = "0x8B13F0", Offset = "0x8B01F0", Length = "0x3C5")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600275E")]
	[Address(RVA = "0x8B17C0", Offset = "0x8B05C0", Length = "0x145")]
	public void AddAffliction(AfflictionType afflictionType, string causeLocId, AfflictionBodyArea location)
	{
	}

	[Token(Token = "0x600275F")]
	[Address(RVA = "0x8B1910", Offset = "0x8B0710", Length = "0x147")]
	public void AddAffliction(string afflictionName, string causeLocId, AfflictionBodyArea location)
	{
	}

	[Token(Token = "0x6002760")]
	[Address(RVA = "0x8B1A60", Offset = "0x8B0860", Length = "0x2F")]
	public void RemoveAffliction(AfflictionType afflictionType)
	{
	}

	[Token(Token = "0x6002761")]
	[Address(RVA = "0x8B1A90", Offset = "0x8B0890", Length = "0x183")]
	public void AddAffliction(AfflictionDefinition afflictionDefinition, string causeLocId, AfflictionBodyArea location)
	{
	}

	[Token(Token = "0x6002762")]
	[Address(RVA = "0x8B1C20", Offset = "0x8B0A20", Length = "0x5A")]
	private void OnDiagnoseOutroComplete()
	{
	}

	[Token(Token = "0x6002763")]
	[Address(RVA = "0x8B1C80", Offset = "0x8B0A80", Length = "0xAE")]
	private void OnDiagnoseIntroComplete()
	{
	}

	[Token(Token = "0x6002764")]
	[Address(RVA = "0x8B1D30", Offset = "0x8B0B30", Length = "0x1A")]
	private AnimatedInteraction GetSelectedIntro()
	{
		return null;
	}

	[Token(Token = "0x6002765")]
	[Address(RVA = "0x8B1D50", Offset = "0x8B0B50", Length = "0x1A")]
	private AnimatedInteraction GetSelectedOutro()
	{
		return null;
	}

	[Token(Token = "0x6002766")]
	[Address(RVA = "0x8B1D70", Offset = "0x8B0B70", Length = "0x9A6")]
	private void SelectApproachSide()
	{
	}

	[Token(Token = "0x6002767")]
	[Address(RVA = "0x8B2720", Offset = "0x8B1520", Length = "0x17")]
	private bool HasAfflictionType(AfflictionType afflictionType)
	{
		return false;
	}

	[Token(Token = "0x6002768")]
	[Address(RVA = "0x8B2740", Offset = "0x8B1540", Length = "0x1B")]
	public bool IsDehydrated()
	{
		return false;
	}

	[Token(Token = "0x6002769")]
	[Address(RVA = "0x8B2760", Offset = "0x8B1560", Length = "0x1B")]
	public bool HasDehydrationRisk()
	{
		return false;
	}

	[Token(Token = "0x600276A")]
	[Address(RVA = "0x8B2780", Offset = "0x8B1580", Length = "0x19")]
	public bool HasBloodLoss()
	{
		return false;
	}

	[Token(Token = "0x600276B")]
	[Address(RVA = "0x8B27A0", Offset = "0x8B15A0", Length = "0x1B")]
	public bool HasFrostbite()
	{
		return false;
	}

	[Token(Token = "0x600276C")]
	[Address(RVA = "0x8B27C0", Offset = "0x8B15C0", Length = "0x183")]
	public int GetBloodLossCount()
	{
		return 0;
	}

	[Token(Token = "0x600276D")]
	[Address(RVA = "0x8B2950", Offset = "0x8B1750", Length = "0x1B")]
	public bool HasHypothermia()
	{
		return false;
	}

	[Token(Token = "0x600276E")]
	[Address(RVA = "0x8B2970", Offset = "0x8B1770", Length = "0x5B")]
	public void AssignNpc(NPC npc)
	{
	}

	[Token(Token = "0x600276F")]
	[Address(RVA = "0x8B29D0", Offset = "0x8B17D0", Length = "0xA23")]
	private void MaybeReparentAnimatedInteractions()
	{
	}

	[Token(Token = "0x6002770")]
	[Address(RVA = "0x8B3400", Offset = "0x8B2200", Length = "0x16F")]
	public NPCAfflictions()
	{
	}
}

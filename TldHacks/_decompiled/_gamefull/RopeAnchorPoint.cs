using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Interactions;
using UnityEngine;

[Token(Token = "0x20005AD")]
public class RopeAnchorPoint : MonoBehaviour
{
	[Token(Token = "0x400347B")]
	[FieldOffset(Offset = "0x20")]
	public Rope m_Rope;

	[Token(Token = "0x400347C")]
	[FieldOffset(Offset = "0x28")]
	public Rope m_RopeShort;

	[Token(Token = "0x400347D")]
	[FieldOffset(Offset = "0x30")]
	public bool m_RopeDeployed;

	[Token(Token = "0x400347E")]
	[FieldOffset(Offset = "0x34")]
	public float m_ProgressBarDurationSeconds;

	[Token(Token = "0x400347F")]
	[FieldOffset(Offset = "0x38")]
	public string m_Audio_DeployRope;

	[Token(Token = "0x4003480")]
	[FieldOffset(Offset = "0x40")]
	public string m_Audio_TakeRope;

	[Token(Token = "0x4003481")]
	private static readonly List<RopeAnchorPoint> s_RopeAnchorPoints;

	[Token(Token = "0x4003482")]
	[FieldOffset(Offset = "0x48")]
	private RopeAnchorActionState m_ActionState;

	[Token(Token = "0x4003483")]
	[FieldOffset(Offset = "0x4C")]
	private float m_ActionTimerSeconds;

	[Token(Token = "0x4003484")]
	[FieldOffset(Offset = "0x50")]
	private float m_StoredDayLengthScale;

	[Token(Token = "0x4003485")]
	[FieldOffset(Offset = "0x54")]
	private bool m_TimeAccelerated;

	[Token(Token = "0x4003486")]
	[FieldOffset(Offset = "0x58")]
	private uint m_ActionAudioID;

	[Token(Token = "0x4003487")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4003488")]
	[FieldOffset(Offset = "0x5D")]
	private bool m_RopeSnapped;

	[Token(Token = "0x4003489")]
	[FieldOffset(Offset = "0x60")]
	private Panel_HUD m_HUD;

	[Token(Token = "0x400348A")]
	private static RopeAnchorPointSaveData m_RopeAnchorPointSaveData;

	[Token(Token = "0x6002BF3")]
	[Address(RVA = "0x9294D0", Offset = "0x9282D0", Length = "0x1B1")]
	private void Start()
	{
	}

	[Token(Token = "0x6002BF4")]
	[Address(RVA = "0x929690", Offset = "0x928490", Length = "0x82")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002BF5")]
	[Address(RVA = "0x929720", Offset = "0x928520", Length = "0x155")]
	private void Update()
	{
	}

	[Token(Token = "0x6002BF6")]
	[Address(RVA = "0x929880", Offset = "0x928680", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6002BF7")]
	[Address(RVA = "0x929920", Offset = "0x928720", Length = "0x197")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002BF8")]
	[Address(RVA = "0x929AC0", Offset = "0x9288C0", Length = "0xC6")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002BF9")]
	[Address(RVA = "0x929B90", Offset = "0x928990", Length = "0x54B")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6002BFA")]
	[Address(RVA = "0x92A0E0", Offset = "0x928EE0", Length = "0x1CA")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6002BFB")]
	[Address(RVA = "0x92A2B0", Offset = "0x9290B0", Length = "0x23E")]
	public static RopeAnchorPoint LookupAnchorPointFromRope(Rope r)
	{
		return null;
	}

	[Token(Token = "0x6002BFC")]
	[Address(RVA = "0x92A4F0", Offset = "0x9292F0", Length = "0xA8")]
	public void SnapRope()
	{
	}

	[Token(Token = "0x6002BFD")]
	[Address(RVA = "0x92A5A0", Offset = "0x9293A0", Length = "0x374")]
	private void SetRopeActiveState(bool state, bool isInteraction)
	{
	}

	[Token(Token = "0x6002BFE")]
	[Address(RVA = "0x92A920", Offset = "0x929720", Length = "0xE")]
	public void CancelAction()
	{
	}

	[Token(Token = "0x6002BFF")]
	[Address(RVA = "0x92A930", Offset = "0x929730", Length = "0x169")]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[Token(Token = "0x6002C00")]
	[Address(RVA = "0x92AAA0", Offset = "0x9298A0", Length = "0x14")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002C01")]
	[Address(RVA = "0x92AAC0", Offset = "0x9298C0", Length = "0x317")]
	private void ActionStarted(RopeAnchorActionState action)
	{
	}

	[Token(Token = "0x6002C02")]
	[Address(RVA = "0x92ADE0", Offset = "0x929BE0", Length = "0x427")]
	private void ActionFinished()
	{
	}

	[Token(Token = "0x6002C03")]
	[Address(RVA = "0x92B210", Offset = "0x92A010", Length = "0x117")]
	private static RopeAnchorPoint FindByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6002C04")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public RopeAnchorPoint()
	{
	}
}

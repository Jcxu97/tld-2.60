using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Events;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200075C")]
public class IceCrackingManager : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4004E82")]
	[FieldOffset(Offset = "0x20")]
	private IceCrackingEvent m_IceCrackingEvent;

	[HideInInspector]
	[Token(Token = "0x4004E83")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 m_EnteredWarningPosition;

	[Token(Token = "0x4004E84")]
	[FieldOffset(Offset = "0x34")]
	public float m_ConditionLossOnFallThrough;

	[Token(Token = "0x4004E85")]
	[FieldOffset(Offset = "0x38")]
	public float m_FadeOutSeconds;

	[Token(Token = "0x4004E86")]
	[FieldOffset(Offset = "0x3C")]
	public float m_StayFadedOutSeconds;

	[Token(Token = "0x4004E87")]
	[FieldOffset(Offset = "0x40")]
	public float m_FadeInSeconds;

	[Token(Token = "0x4004E88")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 m_FarDecalScale;

	[Token(Token = "0x4004E89")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 m_MediumDecalScale;

	[Token(Token = "0x4004E8A")]
	[FieldOffset(Offset = "0x5C")]
	public Vector3 m_CloseDecalScale;

	[Token(Token = "0x4004E8B")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 m_CritDecalScale;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4004E8C")]
	[FieldOffset(Offset = "0x78")]
	private PanelReference<Panel_HUD> m_HUD;

	[HideInInspector]
	[Token(Token = "0x4004E8D")]
	[FieldOffset(Offset = "0x80")]
	public float m_FellInRecentlyTimer;

	[HideInInspector]
	[Token(Token = "0x4004E8E")]
	[FieldOffset(Offset = "0x88")]
	public BreakableIce m_BreakableIce;

	[Token(Token = "0x4004E8F")]
	[FieldOffset(Offset = "0x90")]
	private float m_FadeInTimeSeconds;

	[Token(Token = "0x4004E90")]
	[FieldOffset(Offset = "0x94")]
	private float m_FadeOutTimeSeconds;

	[Token(Token = "0x4004E91")]
	[FieldOffset(Offset = "0x98")]
	private float m_CurrentVolume;

	[Token(Token = "0x4004E92")]
	[FieldOffset(Offset = "0x9C")]
	private int m_NumTriggersInside;

	[Token(Token = "0x4004E93")]
	[FieldOffset(Offset = "0xA0")]
	private int m_NumFallTriggersInside;

	[Token(Token = "0x4004E94")]
	[FieldOffset(Offset = "0xA4")]
	private uint m_IceCrackingSoundID;

	[Token(Token = "0x4004E95")]
	[FieldOffset(Offset = "0xA8")]
	private List<IceCrackingTrigger> m_IceFallTriggers;

	[Token(Token = "0x4004E96")]
	[FieldOffset(Offset = "0xB0")]
	private Vector3 m_LastSafeLocation;

	[Token(Token = "0x4004E97")]
	[FieldOffset(Offset = "0xBC")]
	private Vector3 m_RespawnLocation;

	[Token(Token = "0x4004E98")]
	[FieldOffset(Offset = "0xC8")]
	private float m_TrackLocationTimer;

	[Token(Token = "0x4004E99")]
	[FieldOffset(Offset = "0xCC")]
	private bool m_ShowingWeakIceLabel;

	[Token(Token = "0x4004E9A")]
	[FieldOffset(Offset = "0xD0")]
	private Collider[] m_RespawnColliders;

	[Token(Token = "0x4004E9B")]
	[FieldOffset(Offset = "0xD8")]
	private int m_AnimParameter_ShowThinIceIndicator;

	[Token(Token = "0x60043B0")]
	[Address(RVA = "0xC5E470", Offset = "0xC5D270", Length = "0xBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60043B1")]
	[Address(RVA = "0xC5E530", Offset = "0xC5D330", Length = "0x6B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60043B2")]
	[Address(RVA = "0xC5EBF0", Offset = "0xC5D9F0", Length = "0xA0")]
	public void EnterIceCrackingTrigger(string audioID, GameObject go, float fadeInSeconds)
	{
	}

	[Token(Token = "0x60043B3")]
	[Address(RVA = "0xC5EC90", Offset = "0xC5DA90", Length = "0x22")]
	public void ExitIceCrackingTrigger(float fadeOutSeconds)
	{
	}

	[Token(Token = "0x60043B4")]
	[Address(RVA = "0xC5ECC0", Offset = "0xC5DAC0", Length = "0x7")]
	public void EnterFallTrigger()
	{
	}

	[Token(Token = "0x60043B5")]
	[Address(RVA = "0xC5ECD0", Offset = "0xC5DAD0", Length = "0x7")]
	public void ExitFallTrigger()
	{
	}

	[Token(Token = "0x60043B6")]
	[Address(RVA = "0xC5ECE0", Offset = "0xC5DAE0", Length = "0xA")]
	public void ExitAllTriggers()
	{
	}

	[Token(Token = "0x60043B7")]
	[Address(RVA = "0xC5ECF0", Offset = "0xC5DAF0", Length = "0xB")]
	public bool IsInsideTrigger()
	{
		return false;
	}

	[Token(Token = "0x60043B8")]
	[Address(RVA = "0xC5ED00", Offset = "0xC5DB00", Length = "0xB")]
	public bool IsInsideFallTrigger()
	{
		return false;
	}

	[Token(Token = "0x60043B9")]
	[Address(RVA = "0xC5ED10", Offset = "0xC5DB10", Length = "0xC5")]
	public void Register(IceCrackingTrigger trigger)
	{
	}

	[Token(Token = "0x60043BA")]
	[Address(RVA = "0xC5EDE0", Offset = "0xC5DBE0", Length = "0x85")]
	public void Unregister(IceCrackingTrigger trigger)
	{
	}

	[Token(Token = "0x60043BB")]
	[Address(RVA = "0xC5EE70", Offset = "0xC5DC70", Length = "0x12")]
	public bool FellInRecently()
	{
		return false;
	}

	[Token(Token = "0x60043BC")]
	[Address(RVA = "0xC5EE90", Offset = "0xC5DC90", Length = "0x2C3")]
	public IceCrackingTrigger FindNearestFallTrigger(Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x60043BD")]
	[Address(RVA = "0xC5F160", Offset = "0xC5DF60", Length = "0x2E7")]
	public bool OverlapsFallTrigger(Collider c, float ignoreDistance)
	{
		return false;
	}

	[Token(Token = "0x60043BE")]
	[Address(RVA = "0xC5F450", Offset = "0xC5E250", Length = "0x4EB")]
	public float GetDistToClosestFallTrigger(Vector3 pos)
	{
		return 0f;
	}

	[Token(Token = "0x60043BF")]
	[Address(RVA = "0xC5F940", Offset = "0xC5E740", Length = "0x35B")]
	public Vector3 GetRespawnLocation()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60043C0")]
	[Address(RVA = "0xB69600", Offset = "0xB68400", Length = "0x52")]
	public void SetBreakableIce(BreakableIce bi)
	{
	}

	[Token(Token = "0x60043C1")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool DisableWeakIce()
	{
		return false;
	}

	[Token(Token = "0x60043C2")]
	[Address(RVA = "0xC5FCA0", Offset = "0xC5EAA0", Length = "0xA5")]
	private void UpdateHUDWarning()
	{
	}

	[Token(Token = "0x60043C3")]
	[Address(RVA = "0xC5FD50", Offset = "0xC5EB50", Length = "0x204")]
	private void UpdateTrackLocation()
	{
	}

	[Token(Token = "0x60043C4")]
	[Address(RVA = "0xC5FF60", Offset = "0xC5ED60", Length = "0xF6")]
	public IceCrackingManager()
	{
	}
}

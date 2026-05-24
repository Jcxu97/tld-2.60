using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.GameplayTags;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000507")]
public class CabinFever : MonoBehaviour
{
	[Token(Token = "0x4002E26")]
	[FieldOffset(Offset = "0x20")]
	public float m_NumHoursToExitRisk;

	[Token(Token = "0x4002E27")]
	[FieldOffset(Offset = "0x24")]
	public float m_NumHoursToEnterRisk;

	[Token(Token = "0x4002E28")]
	[FieldOffset(Offset = "0x28")]
	public float m_NumHoursRequiredIndoors;

	[Token(Token = "0x4002E29")]
	[FieldOffset(Offset = "0x2C")]
	public float m_NumHoursToCheck;

	[Token(Token = "0x4002E2A")]
	[FieldOffset(Offset = "0x30")]
	public float m_NumHoursToPreventIndoorRest;

	[Token(Token = "0x4002E2B")]
	[FieldOffset(Offset = "0x38")]
	public GameplayTag m_DisableTag;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002E2C")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4002E2D")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4002E2E")]
	[FieldOffset(Offset = "0x58")]
	private bool m_Active;

	[Token(Token = "0x4002E2F")]
	[FieldOffset(Offset = "0x59")]
	private bool m_RiskActive;

	[Token(Token = "0x4002E30")]
	[FieldOffset(Offset = "0x5C")]
	private float m_ElapsedHours;

	[Token(Token = "0x4002E31")]
	[FieldOffset(Offset = "0x60")]
	private float m_BuffCooldownRemainingHours;

	[Token(Token = "0x4002E32")]
	[FieldOffset(Offset = "0x68")]
	private readonly List<float> m_IndoorTimeTracked;

	[Token(Token = "0x4002E33")]
	[FieldOffset(Offset = "0x70")]
	private int m_HourLastFrame;

	[Token(Token = "0x4002E34")]
	[FieldOffset(Offset = "0x74")]
	private float m_HoursIndoorsExcludingLastHourCached;

	[Token(Token = "0x4002E35")]
	[FieldOffset(Offset = "0x78")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002E36")]
	private static CabinFeverSaveDataProxy m_CabinFeverSaveDataProxy;

	[Token(Token = "0x6002623")]
	[Address(RVA = "0x89CE20", Offset = "0x89BC20", Length = "0xF")]
	public void Start()
	{
	}

	[Token(Token = "0x6002624")]
	[Address(RVA = "0x89CE30", Offset = "0x89BC30", Length = "0x489")]
	public void Update()
	{
	}

	[Token(Token = "0x6002625")]
	[Address(RVA = "0x89D2C0", Offset = "0x89C0C0", Length = "0x1F2")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002626")]
	[Address(RVA = "0x89D4C0", Offset = "0x89C2C0", Length = "0x2D6")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002627")]
	[Address(RVA = "0x89D7A0", Offset = "0x89C5A0", Length = "0x398")]
	public void CabinFeverStart(bool displayIcon, bool nofx = false)
	{
	}

	[Token(Token = "0x6002628")]
	[Address(RVA = "0x89DB40", Offset = "0x89C940", Length = "0x4D")]
	public void ClearCabinFeverRisk()
	{
	}

	[Token(Token = "0x6002629")]
	[Address(RVA = "0x89DB90", Offset = "0x89C990", Length = "0x6D")]
	public void CabinFeverEnd()
	{
	}

	[Token(Token = "0x600262A")]
	[Address(RVA = "0x67E850", Offset = "0x67D650", Length = "0x5")]
	public bool HasCabinFever()
	{
		return false;
	}

	[Token(Token = "0x600262B")]
	[Address(RVA = "0x89DC00", Offset = "0x89CA00", Length = "0x5")]
	public bool HasCabinFeverRisk()
	{
		return false;
	}

	[Token(Token = "0x600262C")]
	[Address(RVA = "0x89DC10", Offset = "0x89CA10", Length = "0x67")]
	public int GetCurrentRisk()
	{
		return 0;
	}

	[Token(Token = "0x600262D")]
	[Address(RVA = "0x89DC80", Offset = "0x89CA80", Length = "0xB")]
	public float GetTimeAmountRemaining()
	{
		return 0f;
	}

	[Token(Token = "0x600262E")]
	[Address(RVA = "0x89DC90", Offset = "0x89CA90", Length = "0x93")]
	public float GetTimeIndoorsExcludingLastHour()
	{
		return 0f;
	}

	[Token(Token = "0x600262F")]
	[Address(RVA = "0x89DD30", Offset = "0x89CB30", Length = "0x91")]
	public float GetTimeIndoorsLastHour()
	{
		return 0f;
	}

	[Token(Token = "0x6002630")]
	[Address(RVA = "0x89DDD0", Offset = "0x89CBD0", Length = "0xB7")]
	public void AddTimeIndoorsLastHour(float amountToAdd)
	{
	}

	[Token(Token = "0x6002631")]
	[Address(RVA = "0x89DE90", Offset = "0x89CC90", Length = "0x213")]
	public float ApplyCabinFeverReductionBuff(float reductionInHours, float cooldownInHours)
	{
		return 0f;
	}

	[Token(Token = "0x6002632")]
	[Address(RVA = "0x89E0B0", Offset = "0x89CEB0", Length = "0x221")]
	private void UpdateCabinFever()
	{
	}

	[Token(Token = "0x6002633")]
	[Address(RVA = "0x89E2E0", Offset = "0x89D0E0", Length = "0x1F2")]
	private void CheckForCabinFever()
	{
	}

	[Token(Token = "0x6002634")]
	[Address(RVA = "0x89E4E0", Offset = "0x89D2E0", Length = "0x320")]
	private void UpdateCabinFeverTimeTracker()
	{
	}

	[Token(Token = "0x6002635")]
	[Address(RVA = "0x89E810", Offset = "0x89D610", Length = "0xB2")]
	public bool DisabledForGameMode(GameModeConfig gameMode)
	{
		return false;
	}

	[Token(Token = "0x6002636")]
	[Address(RVA = "0x89E8D0", Offset = "0x89D6D0", Length = "0xEA")]
	public CabinFever()
	{
	}
}

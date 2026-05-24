using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20001DA")]
public class EmergencyStim : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400107A")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x400107B")]
	[FieldOffset(Offset = "0x28")]
	private EmergencyStimParams m_EmergencyStimParams;

	[Token(Token = "0x400107C")]
	[FieldOffset(Offset = "0x30")]
	private float m_LastStimPulseTime;

	[Token(Token = "0x60010EE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Start()
	{
	}

	[Token(Token = "0x60010EF")]
	[Address(RVA = "0x634A90", Offset = "0x633890", Length = "0x8D")]
	public void Update()
	{
	}

	[Token(Token = "0x60010F0")]
	[Address(RVA = "0x634B20", Offset = "0x633920", Length = "0x88")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60010F1")]
	[Address(RVA = "0x634BB0", Offset = "0x6339B0", Length = "0xCC")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60010F2")]
	[Address(RVA = "0x634C80", Offset = "0x633A80", Length = "0x89")]
	public bool GetEmergencyStimActive()
	{
		return false;
	}

	[Token(Token = "0x60010F3")]
	[Address(RVA = "0x634D10", Offset = "0x633B10", Length = "0x15")]
	public bool CanUseEmergencyStim()
	{
		return false;
	}

	[Token(Token = "0x60010F4")]
	[Address(RVA = "0x634D30", Offset = "0x633B30", Length = "0x2EE")]
	public void ApplyEmergencyStim(EmergencyStimItem emergencyStim)
	{
	}

	[Token(Token = "0x60010F5")]
	[Address(RVA = "0x635020", Offset = "0x633E20", Length = "0x114")]
	public float GetTimeRemainingNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x60010F6")]
	[Address(RVA = "0x635140", Offset = "0x633F40", Length = "0x87")]
	public float GetActiveHoursRemaining()
	{
		return 0f;
	}

	[Token(Token = "0x60010F7")]
	[Address(RVA = "0x6351D0", Offset = "0x633FD0", Length = "0x28C")]
	private void MaybeUpdateEmergencyStimEffects()
	{
	}

	[Token(Token = "0x60010F8")]
	[Address(RVA = "0x635460", Offset = "0x634260", Length = "0x195")]
	private void ApplyEmergencyStimExitEffects()
	{
	}

	[Token(Token = "0x60010F9")]
	[Address(RVA = "0x635600", Offset = "0x634400", Length = "0xFF")]
	public void ResetEmergencyStim()
	{
	}

	[Token(Token = "0x60010FA")]
	[Address(RVA = "0x635700", Offset = "0x634500", Length = "0xD4")]
	public EmergencyStim()
	{
	}
}

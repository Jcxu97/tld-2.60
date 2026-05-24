using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009EE")]
public class AfflictionTriggerVolume : MonoBehaviour
{
	[Token(Token = "0x20009EF")]
	public delegate void AfflictionTriggerEvent(AfflictionType afflictionType);

	[Token(Token = "0x4006523")]
	[FieldOffset(Offset = "0x20")]
	public AfflictionType m_AfflictionType;

	[Token(Token = "0x4006524")]
	[FieldOffset(Offset = "0x24")]
	public bool m_StopAfflictionOnExit;

	[Token(Token = "0x4006525")]
	[FieldOffset(Offset = "0x25")]
	public bool m_BlockSuffocating;

	[Token(Token = "0x4006526")]
	[FieldOffset(Offset = "0x28")]
	public SuffocatingSettings m_SuffocatingSettingsPrefab;

	[Token(Token = "0x4006527")]
	public static AfflictionTriggerEvent DisableEvent;

	[Token(Token = "0x4006528")]
	public static AfflictionTriggerEvent EnterEvent;

	[Token(Token = "0x4006529")]
	public static AfflictionTriggerEvent ExitEvent;

	[Token(Token = "0x600578A")]
	[Address(RVA = "0xED5E50", Offset = "0xED4C50", Length = "0xB9")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600578B")]
	[Address(RVA = "0xED5F10", Offset = "0xED4D10", Length = "0x110")]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[Token(Token = "0x600578C")]
	[Address(RVA = "0xED6030", Offset = "0xED4E30", Length = "0x116")]
	private void OnTriggerExit(Collider collider)
	{
	}

	[Token(Token = "0x600578D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AfflictionTriggerVolume()
	{
	}
}

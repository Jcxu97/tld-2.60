using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000962")]
public class SteamPipeExhaust : MonoBehaviour
{
	[Tooltip("How much output steam flow is the pipe producing connected to this exhaust. An arbitrary value. Could be litres or percent.")]
	[Range(0f, 100f)]
	[Token(Token = "0x40061A1")]
	[FieldOffset(Offset = "0x20")]
	public float m_EffectActiveFlowThreshold;

	[Tooltip("The exhaust trigger. In this case, connected to a damage trigger for burns and a wetness trigger for clothing on player.")]
	[Token(Token = "0x40061A2")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_EffectTrigger;

	[Tooltip("The exhaust trigger when the exhaust is disabled (inactive).")]
	[Token(Token = "0x40061A3")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_InactiveTrigger;

	[Tooltip("The initial state of the exhaust trigger. Will change with the state of the connected steam pipe source below.")]
	[Token(Token = "0x40061A4")]
	[FieldOffset(Offset = "0x38")]
	public bool m_IsActive;

	[Tooltip("The out flow pipe this exhaust is connected to. You can have multiple exhausts attached to any pipe.")]
	[Token(Token = "0x40061A5")]
	[FieldOffset(Offset = "0x40")]
	public SteamPipe m_SteamPipeSource;

	[Token(Token = "0x60054D6")]
	[Address(RVA = "0xE90050", Offset = "0xE8EE50", Length = "0x1BC")]
	private void Start()
	{
	}

	[Token(Token = "0x60054D7")]
	[Address(RVA = "0xE90210", Offset = "0xE8F010", Length = "0x11B")]
	private void SetActive(bool active)
	{
	}

	[Token(Token = "0x60054D8")]
	[Address(RVA = "0xE90330", Offset = "0xE8F130", Length = "0x288")]
	private void Update()
	{
	}

	[Token(Token = "0x60054D9")]
	[Address(RVA = "0xA1E430", Offset = "0xA1D230", Length = "0x4A")]
	public SteamPipeExhaust()
	{
	}
}

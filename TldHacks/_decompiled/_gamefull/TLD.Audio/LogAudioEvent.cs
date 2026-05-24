using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Logging;
using UnityEngine;

namespace TLD.Audio;

[Token(Token = "0x20014EA")]
public class LogAudioEvent : MonoBehaviour
{
	[Token(Token = "0x4009746")]
	private static readonly LogFilter s_LogFilter;

	[SerializeField]
	[Token(Token = "0x4009747")]
	[FieldOffset(Offset = "0x20")]
	private AkTriggerBase[] m_TriggersToLog;

	[Token(Token = "0x4009748")]
	[FieldOffset(Offset = "0x28")]
	private readonly Dictionary<AkTriggerBase, AkTriggerBase.Trigger> m_RegisteredCallbacks;

	[Token(Token = "0x6008417")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void OnAudioEvent(AkEventCallbackMsg message)
	{
	}

	[Token(Token = "0x6008418")]
	[Address(RVA = "0x1258CF0", Offset = "0x1257AF0", Length = "0x25F")]
	private void Awake()
	{
	}

	[Token(Token = "0x6008419")]
	[Address(RVA = "0x1258F50", Offset = "0x1257D50", Length = "0x34B")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600841A")]
	[Address(RVA = "0x12592A0", Offset = "0x12580A0", Length = "0xE3")]
	public LogAudioEvent()
	{
	}
}

using Cpp2ILInjected;
using UnityEngine;

namespace InteractiveObjects;

[Token(Token = "0x200131C")]
public class TransmitterSwitchInteraction : OpenClose
{
	[Header("Transmitter Switch")]
	[Token(Token = "0x4008D53")]
	[FieldOffset(Offset = "0x148")]
	public LocalizedString m_LocalizedCantOpenHandle;

	[SerializeField]
	[Token(Token = "0x4008D54")]
	[FieldOffset(Offset = "0x150")]
	private Transmitter m_Transmitter;

	[Token(Token = "0x6007A83")]
	[Address(RVA = "0x1193F30", Offset = "0x1192D30", Length = "0x9E")]
	public override bool PerformHold()
	{
		return false;
	}

	[Token(Token = "0x6007A84")]
	[Address(RVA = "0x1193FD0", Offset = "0x1192DD0", Length = "0x148")]
	public TransmitterSwitchInteraction()
	{
	}
}

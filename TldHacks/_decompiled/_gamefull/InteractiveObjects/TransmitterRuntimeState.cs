using System.Collections.Generic;
using Cpp2ILInjected;

namespace InteractiveObjects;

[Token(Token = "0x200132A")]
public class TransmitterRuntimeState
{
	[Token(Token = "0x4008D8F")]
	[FieldOffset(Offset = "0x10")]
	public bool m_IsFixed;

	[Token(Token = "0x4008D90")]
	[FieldOffset(Offset = "0x11")]
	public bool m_IsOpen;

	[Token(Token = "0x4008D91")]
	[FieldOffset(Offset = "0x12")]
	public bool m_IsDiscovered;

	[Token(Token = "0x4008D92")]
	[FieldOffset(Offset = "0x18")]
	public readonly List<RepairableItemSaveState> m_RepairableItems;

	[Token(Token = "0x17000A44")]
	public bool IsActive
	{
		[Token(Token = "0x6007AE2")]
		[Address(RVA = "0x1199A40", Offset = "0x1198840", Length = "0x5D")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007AE3")]
	[Address(RVA = "0x1199AA0", Offset = "0x11988A0", Length = "0xE")]
	public bool CanSendSignal()
	{
		return false;
	}

	[Token(Token = "0x6007AE4")]
	[Address(RVA = "0x1199AB0", Offset = "0x11988B0", Length = "0x212")]
	public RepairableItemSaveState GetRepairableStateForGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6007AE5")]
	[Address(RVA = "0x1199CD0", Offset = "0x1198AD0", Length = "0xAD")]
	public TransmitterRuntimeState()
	{
	}
}

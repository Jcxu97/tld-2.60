using System.Collections.Generic;
using Cpp2ILInjected;

namespace TLD.Gameplay;

[Token(Token = "0x200147B")]
public class LifeAfterDeathState
{
	[Token(Token = "0x40094B0")]
	[FieldOffset(Offset = "0x10")]
	public bool m_SystemEnabled;

	[Token(Token = "0x40094B1")]
	[FieldOffset(Offset = "0x14")]
	public int m_LivesUsed;

	[Token(Token = "0x40094B2")]
	[FieldOffset(Offset = "0x18")]
	public string m_LastRegion;

	[Token(Token = "0x40094B3")]
	[FieldOffset(Offset = "0x20")]
	public bool m_PerformingRespawn;

	[Token(Token = "0x40094B4")]
	[FieldOffset(Offset = "0x28")]
	public RecoveryCampState m_RecoveryCampState;

	[Token(Token = "0x40094B5")]
	[FieldOffset(Offset = "0x30")]
	public List<string> m_PreviousRecoveryCamps;

	[Token(Token = "0x40094B6")]
	[FieldOffset(Offset = "0x38")]
	public readonly List<RecoveryCampState.RecoveryItem> m_RuinedTravoisItems;

	[Token(Token = "0x40094B7")]
	[FieldOffset(Offset = "0x40")]
	public readonly List<RecoveryCampState.RecoveryDecorationItem> m_RuinedTravoisDecorationItems;

	[Token(Token = "0x600823D")]
	[Address(RVA = "0x122DA30", Offset = "0x122C830", Length = "0x3AE")]
	public LifeAfterDeathState()
	{
	}
}

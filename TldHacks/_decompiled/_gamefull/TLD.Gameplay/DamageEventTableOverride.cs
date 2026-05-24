using System;
using Cpp2ILInjected;
using TLD.GameplayTags;

namespace TLD.Gameplay;

[Serializable]
[Token(Token = "0x2001477")]
public struct DamageEventTableOverride
{
	[Token(Token = "0x4009462")]
	[FieldOffset(Offset = "0x0")]
	public GameplayTag m_AITag;

	[Token(Token = "0x4009463")]
	[FieldOffset(Offset = "0x10")]
	public DamageEventTable m_Table;
}

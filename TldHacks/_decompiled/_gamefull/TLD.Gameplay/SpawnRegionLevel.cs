using System;
using Cpp2ILInjected;
using TLD.Gameplay.Tunable;
using TLD.GameplayTags;

namespace TLD.Gameplay;

[Serializable]
[Token(Token = "0x2001476")]
public struct SpawnRegionLevel
{
	[Token(Token = "0x4009460")]
	[FieldOffset(Offset = "0x0")]
	public GameplayTag m_AITag;

	[Token(Token = "0x4009461")]
	[FieldOffset(Offset = "0x10")]
	public CustomTunableNLMHV m_SpawnLevel;
}

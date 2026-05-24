using System.ComponentModel;
using Cpp2ILInjected;

namespace TLD.Gameplay;

[Token(Token = "0x2001458")]
public class BeachcombingManagerSaveData
{
	[Token(Token = "0x40093C5")]
	private const float DEFAULT_TIME_SINCE_LAST = -1000f;

	[DefaultValue(-1000f)]
	[Token(Token = "0x40093C6")]
	[FieldOffset(Offset = "0x10")]
	public float m_TimeAtLastBlizzard;

	[Token(Token = "0x40093C7")]
	[FieldOffset(Offset = "0x14")]
	public bool m_BlizzardFullyActive;

	[Token(Token = "0x40093C8")]
	[FieldOffset(Offset = "0x18")]
	public int m_CurrentBlizzardID;

	[Token(Token = "0x600817E")]
	[Address(RVA = "0x121DC60", Offset = "0x121CA60", Length = "0x8")]
	public BeachcombingManagerSaveData()
	{
	}
}

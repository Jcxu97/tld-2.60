using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x200087E")]
public class UnlockablePrefabSaveData
{
	[Token(Token = "0x40057C3")]
	[FieldOffset(Offset = "0x10")]
	public NPC_UnlockablePrefabInfo m_UnlockablePrefab;

	[Token(Token = "0x40057C4")]
	[FieldOffset(Offset = "0x18")]
	public bool m_Unlocked;

	[Token(Token = "0x40057C5")]
	[FieldOffset(Offset = "0x20")]
	public string m_UnlockablePrefabName;

	[Token(Token = "0x6004DB5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public UnlockablePrefabSaveData()
	{
	}
}

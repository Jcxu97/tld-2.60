using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000879")]
public class NeedPrefabSaveData
{
	[Token(Token = "0x40057AE")]
	[FieldOffset(Offset = "0x10")]
	public NPC_NeedPrefabInfo m_NeedPrefab;

	[Token(Token = "0x40057AF")]
	[FieldOffset(Offset = "0x18")]
	public bool m_HasBeenCompleted;

	[Token(Token = "0x40057B0")]
	[FieldOffset(Offset = "0x1C")]
	public float m_CompletedTimeHoursPlayed;

	[Token(Token = "0x40057B1")]
	[FieldOffset(Offset = "0x20")]
	public string m_NeedPrefabName;

	[Token(Token = "0x6004D98")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public NeedPrefabSaveData()
	{
	}
}

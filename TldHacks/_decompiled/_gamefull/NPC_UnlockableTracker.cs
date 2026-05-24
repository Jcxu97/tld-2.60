using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200087F")]
public class NPC_UnlockableTracker : MonoBehaviour
{
	[Token(Token = "0x40057C6")]
	[FieldOffset(Offset = "0x20")]
	public string m_NPCTrustID;

	[Token(Token = "0x40057C7")]
	[FieldOffset(Offset = "0x28")]
	public NPC_UnlockablePrefab[] m_DefaultUnlockables;

	[HideInInspector]
	[Token(Token = "0x40057C8")]
	[FieldOffset(Offset = "0x30")]
	public List<UnlockablePrefabSaveData> m_UnlockablePrefabsActive;

	[Token(Token = "0x40057C9")]
	private static UnlockableTrackerSaveData m_UnlockableTrackerSaveData;

	[Token(Token = "0x6004DB6")]
	[Address(RVA = "0xD90330", Offset = "0xD8F130", Length = "0xAD")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004DB7")]
	[Address(RVA = "0xD903E0", Offset = "0xD8F1E0", Length = "0x1DE")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004DB8")]
	[Address(RVA = "0xD905C0", Offset = "0xD8F3C0", Length = "0x161")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004DB9")]
	[Address(RVA = "0xD90730", Offset = "0xD8F530", Length = "0x18D")]
	public void UnlockUnlockable(string name)
	{
	}

	[Token(Token = "0x6004DBA")]
	[Address(RVA = "0xD908C0", Offset = "0xD8F6C0", Length = "0x3B1")]
	public void AddUnlockable(NPC_UnlockablePrefab unlockableToAdd)
	{
	}

	[Token(Token = "0x6004DBB")]
	[Address(RVA = "0xD90C80", Offset = "0xD8FA80", Length = "0x16F")]
	public NPC_UnlockableTracker()
	{
	}
}

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005A2")]
public struct PendingSpawnData
{
	[Token(Token = "0x40033FA")]
	[FieldOffset(Offset = "0x0")]
	public Vector3 m_Position;

	[Token(Token = "0x40033FB")]
	[FieldOffset(Offset = "0xC")]
	public Quaternion m_Rotation;

	[Token(Token = "0x40033FC")]
	[FieldOffset(Offset = "0x20")]
	public string m_PrefabName;

	[Token(Token = "0x40033FD")]
	[FieldOffset(Offset = "0x28")]
	public bool m_UnlockedForDetailMap;
}

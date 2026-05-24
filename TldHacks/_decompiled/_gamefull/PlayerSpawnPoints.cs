using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008C4")]
public class PlayerSpawnPoints : MonoBehaviour
{
	[Token(Token = "0x4005B64")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> m_SpawnPoints;

	[Token(Token = "0x600507E")]
	[Address(RVA = "0xE078C0", Offset = "0xE066C0", Length = "0x186")]
	public void Start()
	{
	}

	[Token(Token = "0x600507F")]
	[Address(RVA = "0xE07A50", Offset = "0xE06850", Length = "0xB6")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005080")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PlayerSpawnPoints()
	{
	}
}

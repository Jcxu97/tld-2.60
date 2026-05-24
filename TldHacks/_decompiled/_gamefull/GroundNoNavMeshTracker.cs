using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A11")]
public class GroundNoNavMeshTracker : MonoBehaviour
{
	[Token(Token = "0x4006607")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> m_GroundNoNavMeshObjects;

	[Token(Token = "0x6005861")]
	[Address(RVA = "0xEE7480", Offset = "0xEE6280", Length = "0xE3")]
	public GroundNoNavMeshTracker()
	{
	}
}

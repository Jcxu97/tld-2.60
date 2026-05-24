using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001A9")]
public class SyncNodesInfo : MonoBehaviour
{
	[Token(Token = "0x4000F05")]
	[FieldOffset(Offset = "0x20")]
	public List<SyncNode> m_SyncNodes;

	[Token(Token = "0x6000F97")]
	[Address(RVA = "0x618110", Offset = "0x616F10", Length = "0x455")]
	public GameObject GetBestNode()
	{
		return null;
	}

	[Token(Token = "0x6000F98")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SyncNodesInfo()
	{
	}
}

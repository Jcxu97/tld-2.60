using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004B8")]
public struct LootTableItem
{
	[Token(Token = "0x4002B7A")]
	[FieldOffset(Offset = "0x0")]
	public int m_Weight;

	[Token(Token = "0x4002B7B")]
	[FieldOffset(Offset = "0x8")]
	public GameObject m_Prefab;
}

using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(order = 10002)]
[Token(Token = "0x20001C8")]
public class AuroraScreenPrefabPool : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x4000F8B")]
	[FieldOffset(Offset = "0x18")]
	private List<GameObject> m_Prefabs;

	[Token(Token = "0x4000F8C")]
	[FieldOffset(Offset = "0x20")]
	private List<GameObject> m_PrefabsTemp;

	[Token(Token = "0x600105C")]
	[Address(RVA = "0x626780", Offset = "0x625580", Length = "0xC8E")]
	public GameObject InstantiateRandomPrefabForScreen(AuroraScreenDisplay screen)
	{
		return null;
	}

	[Token(Token = "0x600105D")]
	[Address(RVA = "0x627410", Offset = "0x626210", Length = "0xB6")]
	public AuroraScreenPrefabPool()
	{
	}
}

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004CD")]
public class RNode : MonoBehaviour
{
	[HideInInspector]
	[Token(Token = "0x4002C19")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] m_SpawnPrefabs;

	[HideInInspector]
	[Token(Token = "0x4002C1A")]
	[FieldOffset(Offset = "0x28")]
	public int[] m_SpawnWeights;

	[HideInInspector]
	[Token(Token = "0x4002C1B")]
	[FieldOffset(Offset = "0x30")]
	public int m_PreviewPrefabIndex;

	[HideInInspector]
	[Token(Token = "0x4002C1C")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_PreviewPrefab;

	[Token(Token = "0x60024B7")]
	[Address(RVA = "0x86CAC0", Offset = "0x86B8C0", Length = "0x1191")]
	private void Start()
	{
	}

	[Token(Token = "0x60024B8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Update()
	{
	}

	[Token(Token = "0x60024B9")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public RNode()
	{
	}
}

using Cpp2ILInjected;
using NodeCanvas.Framework;
using UnityEngine;

[RequireComponent(typeof(Blackboard))]
[Token(Token = "0x2000163")]
public class BlackboardSpawner : MonoBehaviour
{
	[Token(Token = "0x4000D10")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Prefab;

	[Token(Token = "0x4000D11")]
	[FieldOffset(Offset = "0x28")]
	public bool m_EnableBehaviourTree;

	[Token(Token = "0x6000DE6")]
	[Address(RVA = "0x5E1320", Offset = "0x5E0120", Length = "0x25D")]
	public void Start()
	{
	}

	[Token(Token = "0x6000DE7")]
	[Address(RVA = "0x5E1580", Offset = "0x5E0380", Length = "0x53F")]
	private GameObject SpawnInstance()
	{
		return null;
	}

	[Token(Token = "0x6000DE8")]
	[Address(RVA = "0x5E1AC0", Offset = "0x5E08C0", Length = "0x58D")]
	private void MaybeCopyBlackboardVariables(GameObject instance)
	{
	}

	[Token(Token = "0x6000DE9")]
	[Address(RVA = "0x5E2050", Offset = "0x5E0E50", Length = "0x198")]
	private void MaybeEnableBehaviourTree(GameObject instance)
	{
	}

	[Token(Token = "0x6000DEA")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BlackboardSpawner()
	{
	}
}

using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x200044E")]
public class AlternateTools : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002703")]
	[FieldOffset(Offset = "0x20")]
	private AssetReferenceGearItem[] m_AlternateTools;

	[Token(Token = "0x4002704")]
	[FieldOffset(Offset = "0x28")]
	private AsyncOperationHandle<IList<GameObject>> m_AsyncOperationHandle;

	[Token(Token = "0x6002076")]
	[Address(RVA = "0x7F8840", Offset = "0x7F7640", Length = "0x14F")]
	public IList<GameObject> GetAlternateTools()
	{
		return null;
	}

	[Token(Token = "0x6002077")]
	[Address(RVA = "0x7F8990", Offset = "0x7F7790", Length = "0xF0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002078")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AlternateTools()
	{
	}
}

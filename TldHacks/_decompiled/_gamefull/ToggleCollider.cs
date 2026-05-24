using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A3F")]
public class ToggleCollider : MonoBehaviour
{
	[Token(Token = "0x40066B0")]
	[FieldOffset(Offset = "0x20")]
	public bool enableCollider;

	[Token(Token = "0x40066B1")]
	[FieldOffset(Offset = "0x28")]
	public List<Collider> allColliders;

	[Token(Token = "0x600593E")]
	[Address(RVA = "0xEF4060", Offset = "0xEF2E60", Length = "0x599")]
	private void Start()
	{
	}

	[Token(Token = "0x600593F")]
	[Address(RVA = "0xEF4600", Offset = "0xEF3400", Length = "0x159")]
	private List<Collider> RemoveDuplicates(List<Collider> oldList)
	{
		return null;
	}

	[Token(Token = "0x6005940")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ToggleCollider()
	{
	}
}

using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Placement;

[Token(Token = "0x200137B")]
public abstract class PlacementTag : MonoBehaviour
{
	[Token(Token = "0x6007C71")]
	public abstract MeshLocationCategory TryFindPositionForObject(GameObject objectToPlace, RaycastHit hitInFrontOfPlayer, out Vector3 position, out Quaternion rotation);

	[Token(Token = "0x6007C72")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	protected PlacementTag()
	{
	}
}

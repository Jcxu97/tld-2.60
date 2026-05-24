using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Placement;
using UnityEngine;

[Token(Token = "0x2000888")]
public class DecorationPointsPlacementTag : PlacementTag
{
	[Token(Token = "0x6004DE0")]
	[Address(RVA = "0xD96750", Offset = "0xD95550", Length = "0x872")]
	public override MeshLocationCategory TryFindPositionForObject(GameObject objectToPlace, RaycastHit hitInFrontOfPlayer, out Vector3 position, out Quaternion rotation)
	{
		position = default(Vector3);
		rotation = default(Quaternion);
		return default(MeshLocationCategory);
	}

	[Token(Token = "0x6004DE1")]
	[Address(RVA = "0xD96FD0", Offset = "0xD95DD0", Length = "0x32E")]
	private DecorationPlacePoint FindClosestPoint(List<DecorationPlacePoint> points, Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x6004DE2")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public DecorationPointsPlacementTag()
	{
	}
}

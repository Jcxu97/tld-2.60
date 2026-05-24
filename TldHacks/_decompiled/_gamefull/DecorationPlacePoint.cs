using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000887")]
public class DecorationPlacePoint : MonoBehaviour
{
	[Tooltip("Authorized prefabs")]
	[Token(Token = "0x4005804")]
	[FieldOffset(Offset = "0x20")]
	public List<DecorationPointsPlacementTag> m_AuthorizedDecorationPrefabs;

	[Token(Token = "0x4005805")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_PlacementPoint;

	[Token(Token = "0x4005806")]
	[FieldOffset(Offset = "0x30")]
	public BoxCollider m_BoxCollider;

	[Token(Token = "0x6004DDB")]
	[Address(RVA = "0xD958A0", Offset = "0xD946A0", Length = "0x2F1")]
	private bool IsAuthorizedPrefab(GameObject testedObject)
	{
		return false;
	}

	[Token(Token = "0x6004DDC")]
	[Address(RVA = "0xD95BA0", Offset = "0xD949A0", Length = "0x61D")]
	public DecorationItem GetOverlappingDecoration(GameObject ignoredParent, DecorationItem ignoredDecoration)
	{
		return null;
	}

	[Token(Token = "0x6004DDD")]
	[Address(RVA = "0xD961C0", Offset = "0xD94FC0", Length = "0x357")]
	public MeshLocationCategory TryFindPosition(GameObject objectToPlace, out Vector3 position, out Quaternion rotation)
	{
		position = default(Vector3);
		rotation = default(Quaternion);
		return default(MeshLocationCategory);
	}

	[Token(Token = "0x6004DDE")]
	[Address(RVA = "0xD96520", Offset = "0xD95320", Length = "0x225")]
	private static DecorationItem GetOwnerDecoration(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6004DDF")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public DecorationPlacePoint()
	{
	}
}

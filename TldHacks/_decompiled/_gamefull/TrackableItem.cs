using Cpp2ILInjected;
using InteractiveObjects;
using InteractiveObjects.Custom_Interactions;
using TLD.Scenes.ObjectReferences;
using UnityEngine;

[RequireComponent(typeof(TrackableItemInteraction))]
[Token(Token = "0x20005BE")]
public class TrackableItem : MonoBehaviour, ITrackable
{
	[Token(Token = "0x400350D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_CoveredObjectRoot;

	[Token(Token = "0x400350E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_UncoveredObjectRoot;

	[SerializeField]
	[SceneObjectReferenceOwner("Assets/ScriptableObjects/InteractiveObjects/TrackableItems/TrackableItemData")]
	[Token(Token = "0x400350F")]
	[FieldOffset(Offset = "0x30")]
	private TrackableItemData m_SceneObject;

	[Token(Token = "0x4003510")]
	[FieldOffset(Offset = "0x38")]
	private TrackableItemInteraction m_ItemInteraction;

	[Token(Token = "0x4003511")]
	[FieldOffset(Offset = "0x40")]
	private Collider m_CacheCollider;

	[Token(Token = "0x6002C68")]
	[Address(RVA = "0x935550", Offset = "0x934350", Length = "0x4A9")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002C69")]
	[Address(RVA = "0x935A00", Offset = "0x934800", Length = "0x7")]
	private void Start()
	{
	}

	[Token(Token = "0x6002C6A")]
	[Address(RVA = "0x935A10", Offset = "0x934810", Length = "0x49")]
	public bool CanTrack()
	{
		return false;
	}

	[Token(Token = "0x6002C6B")]
	[Address(RVA = "0x935A60", Offset = "0x934860", Length = "0x21D")]
	public bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6002C6C")]
	[Address(RVA = "0x935C80", Offset = "0x934A80", Length = "0x7")]
	public Transform GetTransform()
	{
		return null;
	}

	[Token(Token = "0x6002C6D")]
	[Address(RVA = "0x935C90", Offset = "0x934A90", Length = "0xE9")]
	public TrackableItemType GetItemType()
	{
		return null;
	}

	[Token(Token = "0x6002C6E")]
	[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
	public TrackableItemData GetItemData()
	{
		return null;
	}

	[Token(Token = "0x6002C6F")]
	[Address(RVA = "0x935D80", Offset = "0x934B80", Length = "0x1EE")]
	private TrackableItemSaveData GetRuntimeState()
	{
		return null;
	}

	[Token(Token = "0x6002C70")]
	[Address(RVA = "0x935F70", Offset = "0x934D70", Length = "0x1E")]
	private bool GetItemUncovered()
	{
		return false;
	}

	[Token(Token = "0x6002C71")]
	[Address(RVA = "0x935F90", Offset = "0x934D90", Length = "0xCD")]
	private void SetItemUncovered(bool isUncovered)
	{
	}

	[Token(Token = "0x6002C72")]
	[Address(RVA = "0x936060", Offset = "0x934E60", Length = "0x30A")]
	private void MaybeUpdateCoveredState()
	{
	}

	[Token(Token = "0x6002C73")]
	[Address(RVA = "0x936370", Offset = "0x935170", Length = "0x481")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002C74")]
	[Address(RVA = "0x936800", Offset = "0x935600", Length = "0xA9")]
	private void RevealOnMap()
	{
	}

	[Token(Token = "0x6002C75")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TrackableItem()
	{
	}
}

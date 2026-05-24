using Cpp2ILInjected;
using UnityEngine;

namespace InteractiveObjects;

[Token(Token = "0x200131D")]
public class FakeTrackableItem : MonoBehaviour, ITrackable
{
	[Header("Fake Cache Setting")]
	[Tooltip("Fake caches are invisible game objects placed near the exit/enter point of the scene, they only reflect the status of a real cache in another scene that is not reachable yetDon't use it if the real cache is not within the max range")]
	[Token(Token = "0x4008D55")]
	[FieldOffset(Offset = "0x20")]
	public float m_EstimateDistanceToRealCache;

	[Tooltip("Scene object data of the real trackable item that this fake item is representing for")]
	[Token(Token = "0x4008D56")]
	[FieldOffset(Offset = "0x28")]
	public TrackableItemData m_SceneObject;

	[Token(Token = "0x6007A85")]
	[Address(RVA = "0x1194120", Offset = "0x1192F20", Length = "0xF0")]
	public void Awake()
	{
	}

	[Token(Token = "0x6007A86")]
	[Address(RVA = "0x1194220", Offset = "0x1193020", Length = "0x32")]
	public bool CanTrack()
	{
		return false;
	}

	[Token(Token = "0x6007A87")]
	[Address(RVA = "0x1194260", Offset = "0x1193060", Length = "0x2E5")]
	public bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6007A88")]
	[Address(RVA = "0x935C80", Offset = "0x934A80", Length = "0x7")]
	public Transform GetTransform()
	{
		return null;
	}

	[Token(Token = "0x6007A89")]
	[Address(RVA = "0x1194550", Offset = "0x1193350", Length = "0xE9")]
	public TrackableItemType GetItemType()
	{
		return null;
	}

	[Token(Token = "0x6007A8A")]
	[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
	public TrackableItemData GetItemData()
	{
		return null;
	}

	[Token(Token = "0x6007A8B")]
	[Address(RVA = "0x5042F0", Offset = "0x5030F0", Length = "0x6")]
	public float GetEstimatedDistance()
	{
		return 0f;
	}

	[Token(Token = "0x6007A8C")]
	[Address(RVA = "0x1194640", Offset = "0x1193440", Length = "0x1EE")]
	private TrackableItemSaveData GetRuntimeState()
	{
		return null;
	}

	[Token(Token = "0x6007A8D")]
	[Address(RVA = "0x1194830", Offset = "0x1193630", Length = "0xE2")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007A8E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FakeTrackableItem()
	{
	}
}

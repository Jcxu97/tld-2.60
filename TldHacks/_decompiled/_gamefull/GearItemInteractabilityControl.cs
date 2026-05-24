using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000584")]
public class GearItemInteractabilityControl : MonoBehaviour
{
	[Tooltip("Control whether discovered gear items are interactive on start/initialization. All subsequent interactability changes must be done through the SetInteractive method on this component.")]
	[SerializeField]
	[Token(Token = "0x40032C7")]
	[FieldOffset(Offset = "0x20")]
	private bool m_InteractiveOnStart;

	[Tooltip("If this is enabled, player interaction will treat the gear item as being completely non-existant in the scene, otherwise if disabled, the gear item's colliders will still be treated as valid raycast targets, blocking interactions with other objects.")]
	[SerializeField]
	[Token(Token = "0x40032C8")]
	[FieldOffset(Offset = "0x21")]
	private bool m_InvisibleToRaycasts;

	[SerializeField]
	[Token(Token = "0x40032C9")]
	[FieldOffset(Offset = "0x28")]
	private Transform m_AttachmentTransform;

	[Token(Token = "0x40032CA")]
	[FieldOffset(Offset = "0x30")]
	private bool m_CurrentInteractive;

	[Token(Token = "0x40032CB")]
	[FieldOffset(Offset = "0x38")]
	private readonly List<GearItem> m_TrackedItems;

	[Token(Token = "0x40032CC")]
	[FieldOffset(Offset = "0x40")]
	private readonly List<string> m_CollectedItems;

	[Token(Token = "0x40032CD")]
	private static readonly List<GearItemInteractabilityControl> s_Instances;

	[Token(Token = "0x6002A79")]
	[Address(RVA = "0x9026C0", Offset = "0x9014C0", Length = "0x4DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002A7A")]
	[Address(RVA = "0x902BA0", Offset = "0x9019A0", Length = "0x1BB")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002A7B")]
	[Address(RVA = "0x902D60", Offset = "0x901B60", Length = "0x170")]
	private void OnPrefabSpawnCompleted(List<GameObject> gameObjects)
	{
	}

	[Token(Token = "0x6002A7C")]
	[Address(RVA = "0x902EE0", Offset = "0x901CE0", Length = "0x230")]
	public void SetInteractive(bool interactive)
	{
	}

	[Token(Token = "0x6002A7D")]
	[Address(RVA = "0x903120", Offset = "0x901F20", Length = "0x21A")]
	private void TrackGearItem(GearItem gearItem)
	{
	}

	[Token(Token = "0x6002A7E")]
	[Address(RVA = "0x903340", Offset = "0x902140", Length = "0x103")]
	private void StopTrackingItem(GearItem gearItem)
	{
	}

	[Token(Token = "0x6002A7F")]
	[Address(RVA = "0x903450", Offset = "0x902250", Length = "0x4C5")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6002A80")]
	[Address(RVA = "0x903920", Offset = "0x902720", Length = "0x2EF")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6002A81")]
	[Address(RVA = "0x903C10", Offset = "0x902A10", Length = "0x4EB")]
	private GearItemInteractabilityControlSaveData Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002A82")]
	[Address(RVA = "0x904100", Offset = "0x902F00", Length = "0x84A")]
	private void Deserialize(GearItemInteractabilityControlSaveData saveData)
	{
	}

	[Token(Token = "0x6002A83")]
	[Address(RVA = "0x904950", Offset = "0x903750", Length = "0xFB")]
	private void DisableCollectedNarrativeItems()
	{
	}

	[Token(Token = "0x6002A84")]
	[Address(RVA = "0x904A50", Offset = "0x903850", Length = "0x18D")]
	private bool ItemWithTheSameGuidAlreadyTracked(string guid)
	{
		return false;
	}

	[Token(Token = "0x6002A85")]
	[Address(RVA = "0x904BE0", Offset = "0x9039E0", Length = "0x207")]
	private bool HasBeenCollected(GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x6002A86")]
	[Address(RVA = "0x904DF0", Offset = "0x903BF0", Length = "0x18F")]
	public GearItemInteractabilityControl()
	{
	}
}

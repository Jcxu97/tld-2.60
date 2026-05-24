using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000826")]
public class MissionObjectIdentifier : MonoBehaviour
{
	[Tooltip("Name for object. Must be UNIQUE!")]
	[Token(Token = "0x40055A5")]
	[FieldOffset(Offset = "0x20")]
	public string m_Id;

	[Token(Token = "0x40055A6")]
	[FieldOffset(Offset = "0x28")]
	public MissionObjectClass m_ObjectClass;

	[Tooltip("Tags representing active scope for objects. Use semi-colon to separate.")]
	[Token(Token = "0x40055A7")]
	[FieldOffset(Offset = "0x30")]
	public string m_ActivityTags;

	[Tooltip("For GearItems - should the object be destroyed after the mission ends?")]
	[Token(Token = "0x40055A8")]
	[FieldOffset(Offset = "0x38")]
	public bool m_DestroyAfterMission;

	[Tooltip("For BaseAI - turn on to stop save/load by BaseAiManager, useful for AI that are placed in scenes and turned on/off by FSM")]
	[Token(Token = "0x40055A9")]
	[FieldOffset(Offset = "0x39")]
	public bool m_BaseAiOnlySerializeIfActive;

	[Tooltip("For items that should only have one in the world at a time, like Bear Spear in Ep2")]
	[Token(Token = "0x40055AA")]
	[FieldOffset(Offset = "0x3A")]
	public bool m_IsUnique;

	[HideInInspector]
	[Token(Token = "0x40055AB")]
	[FieldOffset(Offset = "0x3C")]
	public int m_NumTags;

	[HideInInspector]
	[Token(Token = "0x40055AC")]
	[FieldOffset(Offset = "0x40")]
	public bool m_SkipSaveManagedItemTest;

	[Token(Token = "0x40055AD")]
	[FieldOffset(Offset = "0x41")]
	private bool m_SkipUnregister;

	[Token(Token = "0x40055AE")]
	private static MissionObjectIdentifierSaveProxy m_MissionObjectIdentifierSaveProxy;

	[Token(Token = "0x40055AF")]
	[FieldOffset(Offset = "0x42")]
	private bool m_IsBlankId;

	[Token(Token = "0x6004BA6")]
	[Address(RVA = "0xD58DA0", Offset = "0xD57BA0", Length = "0x95B")]
	private void Start()
	{
	}

	[Token(Token = "0x6004BA7")]
	[Address(RVA = "0xD59700", Offset = "0xD58500", Length = "0x135")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004BA8")]
	[Address(RVA = "0xD59840", Offset = "0xD58640", Length = "0x570")]
	public static MissionObjectIdentifier AddMissionComponentForSaveManagedItem(GameObject smObject, string missionObjectSerialized)
	{
		return null;
	}

	[Token(Token = "0x6004BA9")]
	[Address(RVA = "0xD59DC0", Offset = "0xD58BC0", Length = "0x1E6")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004BAA")]
	[Address(RVA = "0xD59FB0", Offset = "0xD58DB0", Length = "0x151")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004BAB")]
	[Address(RVA = "0xD5A110", Offset = "0xD58F10", Length = "0x218")]
	public bool HasAnyTag(string[] tags)
	{
		return false;
	}

	[Token(Token = "0x6004BAC")]
	[Address(RVA = "0xD5A330", Offset = "0xD59130", Length = "0x5")]
	public bool IsBlankId()
	{
		return false;
	}

	[Token(Token = "0x6004BAD")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MissionObjectIdentifier()
	{
	}
}

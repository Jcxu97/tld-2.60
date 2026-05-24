using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004C3")]
public class NarrativeCollectibleItem : MonoBehaviour
{
	[Token(Token = "0x20004C4")]
	public enum CollectibleType
	{
		[Token(Token = "0x4002BBF")]
		Story,
		[Token(Token = "0x4002BC0")]
		Note,
		[Token(Token = "0x4002BC1")]
		Matchbook,
		[Token(Token = "0x4002BC2")]
		Postcard,
		[Token(Token = "0x4002BC3")]
		Recipe
	}

	[Token(Token = "0x4002BB8")]
	[FieldOffset(Offset = "0x20")]
	public CollectibleType m_Type;

	[Token(Token = "0x4002BB9")]
	[FieldOffset(Offset = "0x28")]
	public string m_NarrativeTextLocID;

	[Token(Token = "0x4002BBA")]
	[FieldOffset(Offset = "0x30")]
	public int m_JournalEntryNumber;

	[Token(Token = "0x4002BBB")]
	[FieldOffset(Offset = "0x34")]
	public NGUIText.Alignment m_TextAlignment;

	[Tooltip("Some items like weapons, should be equipped. The InspectGear needs to ignore this component when dealing with equippable gear.")]
	[Token(Token = "0x4002BBC")]
	[FieldOffset(Offset = "0x38")]
	public bool m_ShowDuringInspect;

	[Token(Token = "0x4002BBD")]
	[FieldOffset(Offset = "0x40")]
	public LocalizedString m_HudMessageOnPickup;

	[Token(Token = "0x600244D")]
	[Address(RVA = "0x865AF0", Offset = "0x8648F0", Length = "0x74")]
	public void MaybeShowHudMessage()
	{
	}

	[Token(Token = "0x600244E")]
	[Address(RVA = "0x865B70", Offset = "0x864970", Length = "0xE6")]
	public bool IsMementoItem()
	{
		return false;
	}

	[Token(Token = "0x600244F")]
	[Address(RVA = "0x865C60", Offset = "0x864A60", Length = "0x85")]
	public static bool IsActiveMemento(GameObject gameObject, out NarrativeCollectibleItem collectibleItem)
	{
		collectibleItem = null;
		return false;
	}

	[Token(Token = "0x6002450")]
	[Address(RVA = "0x865CF0", Offset = "0x864AF0", Length = "0x76")]
	public static bool IsActiveNarrativeItem(GameObject gameObject, out NarrativeCollectibleItem collectibleItem)
	{
		collectibleItem = null;
		return false;
	}

	[Token(Token = "0x6002451")]
	[Address(RVA = "0x865D70", Offset = "0x864B70", Length = "0x4E")]
	public NarrativeCollectibleItem()
	{
	}
}

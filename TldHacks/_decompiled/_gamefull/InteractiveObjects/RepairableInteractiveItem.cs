using System;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Interactions;
using UnityEngine;

namespace InteractiveObjects;

[Token(Token = "0x2001320")]
public class RepairableInteractiveItem : AnimatedTimedHoldInteraction
{
	[Serializable]
	[Token(Token = "0x2001321")]
	public class RequiredGearItem
	{
		[Token(Token = "0x4008D62")]
		[FieldOffset(Offset = "0x10")]
		public GearItem m_Item;

		[Token(Token = "0x4008D63")]
		[FieldOffset(Offset = "0x18")]
		public int m_Count;

		[Token(Token = "0x6007AA5")]
		[Address(RVA = "0x1195710", Offset = "0x1194510", Length = "0x8")]
		public RequiredGearItem()
		{
		}
	}

	[HideInInspector]
	[Token(Token = "0x4008D59")]
	[FieldOffset(Offset = "0x90")]
	public RequiredGearItem[] m_RequiredGearItems;

	[Token(Token = "0x4008D5A")]
	[FieldOffset(Offset = "0x98")]
	public LocalizedString m_ItemDisplayName;

	[Token(Token = "0x4008D5B")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_FixedGameobject;

	[Token(Token = "0x4008D5C")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_BrokenGameobject;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4008D5F")]
	[FieldOffset(Offset = "0xC0")]
	private AK.Wwise.Event m_HoldStartAudioEvent;

	[SerializeField]
	[Token(Token = "0x4008D60")]
	[FieldOffset(Offset = "0xC8")]
	private AK.Wwise.Event m_HoldCancelAudioEvent;

	[SerializeField]
	[Token(Token = "0x4008D61")]
	[FieldOffset(Offset = "0xD0")]
	private AK.Wwise.Event m_HoldEndAudioEvent;

	[Token(Token = "0x17000A34")]
	[field: Token(Token = "0x4008D5E")]
	[field: FieldOffset(Offset = "0xB8")]
	public bool IsRepaired
	{
		[Token(Token = "0x6007A98")]
		[Address(RVA = "0x8352F0", Offset = "0x8340F0", Length = "0x8")]
		get;
		[Token(Token = "0x6007A99")]
		[Address(RVA = "0x7A86D0", Offset = "0x7A74D0", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x1400003C")]
	public event Action<RepairableInteractiveItem> ItemRepaired
	{
		[CompilerGenerated]
		[Token(Token = "0x6007A96")]
		[Address(RVA = "0x1194920", Offset = "0x1193720", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007A97")]
		[Address(RVA = "0x1194A90", Offset = "0x1193890", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x6007A9A")]
	[Address(RVA = "0x1194C00", Offset = "0x1193A00", Length = "0x8A")]
	public void Deserialize(RepairableItemSaveState repairableItemSaveState)
	{
	}

	[Token(Token = "0x6007A9B")]
	[Address(RVA = "0x1194C90", Offset = "0x1193A90", Length = "0x1F")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x6007A9C")]
	[Address(RVA = "0x1194CB0", Offset = "0x1193AB0", Length = "0xAB")]
	public override bool PerformHold()
	{
		return false;
	}

	[Token(Token = "0x6007A9D")]
	[Address(RVA = "0x1194D60", Offset = "0x1193B60", Length = "0x4D")]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[Token(Token = "0x6007A9E")]
	[Address(RVA = "0x1194DB0", Offset = "0x1193BB0", Length = "0x8D")]
	public override void CancelHold()
	{
	}

	[Token(Token = "0x6007A9F")]
	[Address(RVA = "0x1194E40", Offset = "0x1193C40", Length = "0x23")]
	protected override void OnAnimatedInteractionBegin()
	{
	}

	[Token(Token = "0x6007AA0")]
	[Address(RVA = "0x1194E70", Offset = "0x1193C70", Length = "0x1C9")]
	protected override void OnAnimatedInteractionEnd()
	{
	}

	[Token(Token = "0x6007AA1")]
	[Address(RVA = "0x1195040", Offset = "0x1193E40", Length = "0x131")]
	private void RemoveRequiredGearsFromInventory()
	{
	}

	[Token(Token = "0x6007AA2")]
	[Address(RVA = "0x1195180", Offset = "0x1193F80", Length = "0x263")]
	private bool HasRequiredGears()
	{
		return false;
	}

	[Token(Token = "0x6007AA3")]
	[Address(RVA = "0x11953F0", Offset = "0x11941F0", Length = "0x27E")]
	private void UpdateText()
	{
	}

	[Token(Token = "0x6007AA4")]
	[Address(RVA = "0x1195670", Offset = "0x1194470", Length = "0x95")]
	public RepairableInteractiveItem()
	{
	}
}

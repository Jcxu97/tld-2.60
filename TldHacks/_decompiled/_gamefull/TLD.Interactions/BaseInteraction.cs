using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

namespace TLD.Interactions;

[Token(Token = "0x200139E")]
public abstract class BaseInteraction : MonoBehaviour, IInteraction
{
	[Token(Token = "0x4008FE8")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_DefaultHoverText;

	[Token(Token = "0x4008FE9")]
	[FieldOffset(Offset = "0x28")]
	public List<InteractionEventEntry> m_EventEntries;

	[Token(Token = "0x4008FEB")]
	[FieldOffset(Offset = "0x38")]
	private bool m_CanInteract;

	[Token(Token = "0x17000A9E")]
	[field: Token(Token = "0x4008FEA")]
	[field: FieldOffset(Offset = "0x30")]
	public string HoverText
	{
		[Token(Token = "0x6007D47")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get;
		[Token(Token = "0x6007D48")]
		[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
		set;
	}

	[Token(Token = "0x17000A9F")]
	public virtual bool IsEnabled
	{
		[Token(Token = "0x6007D49")]
		[Address(RVA = "0x8EC8D0", Offset = "0x8EB6D0", Length = "0x98")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000AA0")]
	public virtual bool CanInteract
	{
		[Token(Token = "0x6007D4A")]
		[Address(RVA = "0x11C6560", Offset = "0x11C5360", Length = "0x30")]
		get
		{
			return false;
		}
		[Token(Token = "0x6007D4B")]
		[Address(RVA = "0x8BE410", Offset = "0x8BD210", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x6007D4C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6007D4D")]
	[Address(RVA = "0x11C6590", Offset = "0x11C5390", Length = "0xCD")]
	public virtual void InitializeInteraction()
	{
	}

	[Token(Token = "0x6007D4E")]
	[Address(RVA = "0x11C6660", Offset = "0x11C5460", Length = "0x61")]
	public void UpdateInteraction()
	{
	}

	[Token(Token = "0x6007D4F")]
	[Address(RVA = "0x11C66D0", Offset = "0x11C54D0", Length = "0xC")]
	public virtual void UpdateInteraction(float deltaTime)
	{
	}

	[Token(Token = "0x6007D50")]
	public abstract bool PerformInteraction();

	[Token(Token = "0x6007D51")]
	[Address(RVA = "0x11C66E0", Offset = "0x11C54E0", Length = "0xC")]
	public virtual void HideInteraction()
	{
	}

	[Token(Token = "0x6007D52")]
	[Address(RVA = "0x86AC30", Offset = "0x869A30", Length = "0x7")]
	public GameObject GetInteractiveObject()
	{
		return null;
	}

	[Token(Token = "0x6007D53")]
	[Address(RVA = "0x11C66F0", Offset = "0x11C54F0", Length = "0x2AD")]
	public void TriggerEvent(InteractionEventType eventType)
	{
	}

	[Token(Token = "0x6007D54")]
	[Address(RVA = "0x11C69A0", Offset = "0x11C57A0", Length = "0x70")]
	public void AddEventCallback(InteractionEventType eventType, UnityAction<BaseInteraction> eventCallback)
	{
	}

	[Token(Token = "0x6007D55")]
	[Address(RVA = "0x11C6A20", Offset = "0x11C5820", Length = "0x1EB")]
	private bool TryFindEventForEventType(InteractionEventType eventType, out InteractionEvent interactionEvent)
	{
		interactionEvent = null;
		return false;
	}

	[Token(Token = "0x6007D56")]
	[Address(RVA = "0x11C6C10", Offset = "0x11C5A10", Length = "0x204")]
	private InteractionEvent FindOrAddEventForEventType(InteractionEventType eventType)
	{
		return null;
	}

	[Token(Token = "0x6007D57")]
	[Address(RVA = "0x11C6E20", Offset = "0x11C5C20", Length = "0x173")]
	protected BaseInteraction()
	{
	}
}

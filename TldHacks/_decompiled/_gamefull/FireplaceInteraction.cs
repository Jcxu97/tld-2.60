using System;
using Cpp2ILInjected;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200056E")]
public abstract class FireplaceInteraction : BaseInteraction, ITorchLightInteraction
{
	[SerializeField]
	[Token(Token = "0x400321C")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	[SerializeField]
	[Token(Token = "0x400321D")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_FeedFire> m_FeedFire;

	[SerializeField]
	[Token(Token = "0x400321E")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_FireStart> m_FireStart;

	[SerializeField]
	[Token(Token = "0x400321F")]
	[FieldOffset(Offset = "0x58")]
	private CookingSlot[] m_CookingSlots;

	[Token(Token = "0x170002B8")]
	[field: Token(Token = "0x4003220")]
	[field: FieldOffset(Offset = "0x60")]
	public Fire Fire
	{
		[Token(Token = "0x60029D2")]
		[Address(RVA = "0x6E2FE0", Offset = "0x6E1DE0", Length = "0x5")]
		get;
		[Token(Token = "0x60029D3")]
		[Address(RVA = "0x8F4D50", Offset = "0x8F3B50", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170002B9")]
	[field: Token(Token = "0x4003221")]
	[field: FieldOffset(Offset = "0x68")]
	public Forge Forge
	{
		[Token(Token = "0x60029D4")]
		[Address(RVA = "0x65D9D0", Offset = "0x65C7D0", Length = "0x5")]
		get;
		[Token(Token = "0x60029D5")]
		[Address(RVA = "0x8F4DB0", Offset = "0x8F3BB0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x60029D6")]
	[Address(RVA = "0x8F4E10", Offset = "0x8F3C10", Length = "0x1AC")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60029D7")]
	[Address(RVA = "0x8F4FC0", Offset = "0x8F3DC0", Length = "0x88")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x60029D8")]
	[Address(RVA = "0x8F5050", Offset = "0x8F3E50", Length = "0x7E")]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[Token(Token = "0x60029D9")]
	public abstract void PerformFireplaceInteraction();

	[Token(Token = "0x60029DA")]
	public abstract bool TooWindyToStart();

	[Token(Token = "0x60029DB")]
	[Address(RVA = "0x8F50D0", Offset = "0x8F3ED0", Length = "0x21")]
	public bool CanLightTorch()
	{
		return false;
	}

	[Token(Token = "0x60029DC")]
	[Address(RVA = "0x8F5100", Offset = "0x8F3F00", Length = "0xE8")]
	protected void AttemptToStartFire(float delaySeconds = 0f, Action onDone = null)
	{
	}

	[Token(Token = "0x60029DD")]
	[Address(RVA = "0x8F51F0", Offset = "0x8F3FF0", Length = "0x9D")]
	protected void AttemptToFeedFire(float delaySeconds = 0f, Action onDone = null)
	{
	}

	[Token(Token = "0x60029DE")]
	[Address(RVA = "0x8F5290", Offset = "0x8F4090", Length = "0x351")]
	public virtual string GetHoverText()
	{
		return null;
	}

	[Token(Token = "0x60029DF")]
	[Address(RVA = "0x8EC770", Offset = "0x8EB570", Length = "0x7")]
	protected FireplaceInteraction()
	{
	}
}

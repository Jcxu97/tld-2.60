using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TLD.Interactions;
using UnityEngine;

namespace InteractiveObjects.Custom_Interactions;

[RequireComponent(typeof(TrackableItem))]
[Token(Token = "0x200132C")]
public class TrackableItemInteraction : AnimatedTimedHoldInteraction
{
	[Token(Token = "0x4008D99")]
	[FieldOffset(Offset = "0x98")]
	private TrackableItem m_ItemComponent;

	[Token(Token = "0x4008D9A")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_IsUncovered;

	[Token(Token = "0x4008D9B")]
	[FieldOffset(Offset = "0xA1")]
	private bool m_HasShortwaveRadio;

	[Token(Token = "0x17000A46")]
	public override bool CanInteract
	{
		[Token(Token = "0x6007AF4")]
		[Address(RVA = "0x119AF20", Offset = "0x1199D20", Length = "0x84")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1400003E")]
	public event Action<bool> m_OnCacheUncovered
	{
		[CompilerGenerated]
		[Token(Token = "0x6007AF2")]
		[Address(RVA = "0x119AC40", Offset = "0x1199A40", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007AF3")]
		[Address(RVA = "0x119ADB0", Offset = "0x1199BB0", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x6007AF5")]
	[Address(RVA = "0x119AFB0", Offset = "0x1199DB0", Length = "0x8D")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007AF6")]
	[Address(RVA = "0x119B040", Offset = "0x1199E40", Length = "0x24E")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x6007AF7")]
	[Address(RVA = "0x119B290", Offset = "0x119A090", Length = "0x29")]
	protected override void OnAnimatedInteractionEnd()
	{
	}

	[Token(Token = "0x6007AF8")]
	[Address(RVA = "0x8F4D40", Offset = "0x8F3B40", Length = "0x7")]
	public TrackableItemInteraction()
	{
	}
}

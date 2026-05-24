using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(Container))]
[Token(Token = "0x200056D")]
public class ContainerInteraction : LockedInteraction
{
	[Token(Token = "0x4003219")]
	[FieldOffset(Offset = "0x80")]
	private Container m_Container;

	[Token(Token = "0x400321A")]
	[FieldOffset(Offset = "0x88")]
	private bool m_IsOpeningContainer;

	[Token(Token = "0x400321B")]
	[FieldOffset(Offset = "0x89")]
	private bool m_IsSafeCracking;

	[Token(Token = "0x170002B4")]
	public override bool CanCancel
	{
		[Token(Token = "0x60029C3")]
		[Address(RVA = "0x8F3F50", Offset = "0x8F2D50", Length = "0x20")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170002B5")]
	public override bool CanInteract
	{
		[Token(Token = "0x60029C4")]
		[Address(RVA = "0x8F3F70", Offset = "0x8F2D70", Length = "0x65")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170002B6")]
	public override bool IsActive
	{
		[Token(Token = "0x60029C5")]
		[Address(RVA = "0x8F3FE0", Offset = "0x8F2DE0", Length = "0x17")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170002B7")]
	public override bool IsEnabled
	{
		[Token(Token = "0x60029C6")]
		[Address(RVA = "0x8F4000", Offset = "0x8F2E00", Length = "0xF5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60029C7")]
	[Address(RVA = "0x8F4100", Offset = "0x8F2F00", Length = "0x9C")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60029C8")]
	[Address(RVA = "0x8F41A0", Offset = "0x8F2FA0", Length = "0xA1")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x60029C9")]
	[Address(RVA = "0x8F4250", Offset = "0x8F3050", Length = "0x36A")]
	public override bool PerformHold()
	{
		return false;
	}

	[Token(Token = "0x60029CA")]
	[Address(RVA = "0x8F45C0", Offset = "0x8F33C0", Length = "0xAF")]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[Token(Token = "0x60029CB")]
	[Address(RVA = "0x8F4670", Offset = "0x8F3470", Length = "0x92")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x60029CC")]
	[Address(RVA = "0x8F4710", Offset = "0x8F3510", Length = "0x1D")]
	private void OnDoneSafeCracking(bool safeOpened)
	{
	}

	[Token(Token = "0x60029CD")]
	[Address(RVA = "0x8F4730", Offset = "0x8F3530", Length = "0x165")]
	public override void CancelHold()
	{
	}

	[Token(Token = "0x60029CE")]
	[Address(RVA = "0x8F48A0", Offset = "0x8F36A0", Length = "0x1D")]
	protected override void EndHold()
	{
	}

	[Token(Token = "0x60029CF")]
	[Address(RVA = "0x8F48C0", Offset = "0x8F36C0", Length = "0x30F")]
	private string GetHoverText()
	{
		return null;
	}

	[Token(Token = "0x60029D0")]
	[Address(RVA = "0x8F4BD0", Offset = "0x8F39D0", Length = "0x164")]
	private string GetInteractiveActionText()
	{
		return null;
	}

	[Token(Token = "0x60029D1")]
	[Address(RVA = "0x8F4D40", Offset = "0x8F3B40", Length = "0x7")]
	public ContainerInteraction()
	{
	}
}

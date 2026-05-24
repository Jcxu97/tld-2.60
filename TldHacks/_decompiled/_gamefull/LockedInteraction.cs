using Cpp2ILInjected;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000571")]
public class LockedInteraction : TimedHoldInteraction
{
	[SerializeField]
	[Token(Token = "0x4003224")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4003226")]
	[FieldOffset(Offset = "0x78")]
	private bool m_IsForcingLock;

	[Token(Token = "0x4003227")]
	[FieldOffset(Offset = "0x7C")]
	private float m_LockTimer;

	[Token(Token = "0x170002BB")]
	[field: Token(Token = "0x4003225")]
	[field: FieldOffset(Offset = "0x70")]
	public Lock Lock
	{
		[Token(Token = "0x60029E8")]
		[Address(RVA = "0x502690", Offset = "0x501490", Length = "0x5")]
		get;
		[Token(Token = "0x60029E9")]
		[Address(RVA = "0x5026A0", Offset = "0x5014A0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170002BC")]
	public override bool IsActive
	{
		[Token(Token = "0x60029EA")]
		[Address(RVA = "0x8F5A40", Offset = "0x8F4840", Length = "0xD")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60029EB")]
	[Address(RVA = "0x8F5A50", Offset = "0x8F4850", Length = "0x8C")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60029EC")]
	[Address(RVA = "0x8F5AE0", Offset = "0x8F48E0", Length = "0xEF")]
	protected bool IsLocked()
	{
		return false;
	}

	[Token(Token = "0x60029ED")]
	[Address(RVA = "0x8F5BD0", Offset = "0x8F49D0", Length = "0x43D")]
	protected void PerformLockInteraction()
	{
	}

	[Token(Token = "0x60029EE")]
	[Address(RVA = "0x8F6010", Offset = "0x8F4E10", Length = "0x86")]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[Token(Token = "0x60029EF")]
	[Address(RVA = "0x8F60A0", Offset = "0x8F4EA0", Length = "0x13C")]
	public override void CancelHold()
	{
	}

	[Token(Token = "0x60029F0")]
	[Address(RVA = "0x8F61E0", Offset = "0x8F4FE0", Length = "0x86")]
	private void OnAnimatedInteractionComplete()
	{
	}

	[Token(Token = "0x60029F1")]
	[Address(RVA = "0x8F6270", Offset = "0x8F5070", Length = "0xB7")]
	private void FinishForceLock(bool complete)
	{
	}

	[Token(Token = "0x60029F2")]
	[Address(RVA = "0x8F4D40", Offset = "0x8F3B40", Length = "0x7")]
	public LockedInteraction()
	{
	}
}

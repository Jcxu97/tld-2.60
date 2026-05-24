using Cpp2ILInjected;

namespace TLD.Interactions;

[Token(Token = "0x200139D")]
public abstract class BaseHoldInteraction : BaseInteraction, IHoldInteraction, IInteraction
{
	[Token(Token = "0x4008FE5")]
	[FieldOffset(Offset = "0x40")]
	public LocalizedString m_DefaultHoldText;

	[Token(Token = "0x4008FE7")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsHoldActive;

	[Token(Token = "0x17000A99")]
	[field: Token(Token = "0x4008FE6")]
	[field: FieldOffset(Offset = "0x48")]
	public string HoldText
	{
		[Token(Token = "0x6007D38")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get;
		[Token(Token = "0x6007D39")]
		[Address(RVA = "0x4D0B60", Offset = "0x4CF960", Length = "0x52")]
		set;
	}

	[Token(Token = "0x17000A9A")]
	public virtual bool IsActive
	{
		[Token(Token = "0x6007D3A")]
		[Address(RVA = "0x6674B0", Offset = "0x6662B0", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000A9B")]
	public abstract float NormalizedProgress
	{
		[Token(Token = "0x6007D3B")]
		get;
	}

	[Token(Token = "0x17000A9C")]
	public virtual bool CanCancel
	{
		[Token(Token = "0x6007D3C")]
		[Address(RVA = "0x11C6330", Offset = "0x11C5130", Length = "0x14")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000A9D")]
	public override bool CanInteract
	{
		[Token(Token = "0x6007D3D")]
		[Address(RVA = "0x11C6350", Offset = "0x11C5150", Length = "0x4F")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007D3E")]
	[Address(RVA = "0x11C63A0", Offset = "0x11C51A0", Length = "0x3F")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6007D3F")]
	public abstract bool PerformHold();

	[Token(Token = "0x6007D40")]
	[Address(RVA = "0x11C63E0", Offset = "0x11C51E0", Length = "0x10")]
	protected virtual void BeginHold()
	{
	}

	[Token(Token = "0x6007D41")]
	[Address(RVA = "0x11C63F0", Offset = "0x11C51F0", Length = "0x44")]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[Token(Token = "0x6007D42")]
	protected abstract void UpdateHoldInteraction(float deltaTime);

	[Token(Token = "0x6007D43")]
	[Address(RVA = "0x11C6440", Offset = "0x11C5240", Length = "0x17")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x6007D44")]
	[Address(RVA = "0x11C6460", Offset = "0x11C5260", Length = "0x4E")]
	public virtual void CancelHold()
	{
	}

	[Token(Token = "0x6007D45")]
	[Address(RVA = "0x11C64B0", Offset = "0x11C52B0", Length = "0x10")]
	protected virtual void EndHold()
	{
	}

	[Token(Token = "0x6007D46")]
	[Address(RVA = "0x11C64C0", Offset = "0x11C52C0", Length = "0x95")]
	protected BaseHoldInteraction()
	{
	}
}

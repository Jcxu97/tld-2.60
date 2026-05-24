using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Interactions;

[Token(Token = "0x20013A5")]
public class SimpleInteraction : BaseInteraction
{
	[SerializeField]
	[Token(Token = "0x4008FFA")]
	[FieldOffset(Offset = "0x40")]
	private bool m_EnableInSafehouseEditMode;

	[Token(Token = "0x17000AA8")]
	public override bool IsEnabled
	{
		[Token(Token = "0x6007D69")]
		[Address(RVA = "0x11C7020", Offset = "0x11C5E20", Length = "0x1AE")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007D6A")]
	[Address(RVA = "0x11C71D0", Offset = "0x11C5FD0", Length = "0x3F")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x6007D6B")]
	[Address(RVA = "0x11C7020", Offset = "0x11C5E20", Length = "0x1AE")]
	private bool IsEnabledInternal()
	{
		return false;
	}

	[Token(Token = "0x6007D6C")]
	[Address(RVA = "0x8EC770", Offset = "0x8EB570", Length = "0x7")]
	public SimpleInteraction()
	{
	}
}

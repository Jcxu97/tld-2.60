using Cpp2ILInjected;
using Rewired.UI;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI;

[Token(Token = "0x2000C29")]
public class PlayerPointerEventData : PointerEventData
{
	[Token(Token = "0x17000658")]
	[field: Token(Token = "0x4007C1A")]
	[field: FieldOffset(Offset = "0x180")]
	public int playerId
	{
		[Token(Token = "0x6006217")]
		[Address(RVA = "0xDD18E0", Offset = "0xDD06E0", Length = "0x7")]
		get;
		[Token(Token = "0x6006218")]
		[Address(RVA = "0xFB3290", Offset = "0xFB2090", Length = "0x7")]
		set;
	}

	[Token(Token = "0x17000659")]
	[field: Token(Token = "0x4007C1B")]
	[field: FieldOffset(Offset = "0x184")]
	public int inputSourceIndex
	{
		[Token(Token = "0x6006219")]
		[Address(RVA = "0xFB32A0", Offset = "0xFB20A0", Length = "0x7")]
		get;
		[Token(Token = "0x600621A")]
		[Address(RVA = "0xFB32B0", Offset = "0xFB20B0", Length = "0x7")]
		set;
	}

	[Token(Token = "0x1700065A")]
	[field: Token(Token = "0x4007C1C")]
	[field: FieldOffset(Offset = "0x188")]
	public IMouseInputSource mouseSource
	{
		[Token(Token = "0x600621B")]
		[Address(RVA = "0xFB32C0", Offset = "0xFB20C0", Length = "0x8")]
		get;
		[Token(Token = "0x600621C")]
		[Address(RVA = "0xFB32D0", Offset = "0xFB20D0", Length = "0x52")]
		set;
	}

	[Token(Token = "0x1700065B")]
	[field: Token(Token = "0x4007C1D")]
	[field: FieldOffset(Offset = "0x190")]
	public ITouchInputSource touchSource
	{
		[Token(Token = "0x600621D")]
		[Address(RVA = "0xFB3330", Offset = "0xFB2130", Length = "0x8")]
		get;
		[Token(Token = "0x600621E")]
		[Address(RVA = "0xFB3340", Offset = "0xFB2140", Length = "0x52")]
		set;
	}

	[Token(Token = "0x1700065C")]
	[field: Token(Token = "0x4007C1E")]
	[field: FieldOffset(Offset = "0x198")]
	public PointerEventType sourceType
	{
		[Token(Token = "0x600621F")]
		[Address(RVA = "0xFB33A0", Offset = "0xFB21A0", Length = "0x7")]
		get;
		[Token(Token = "0x6006220")]
		[Address(RVA = "0xFB33B0", Offset = "0xFB21B0", Length = "0x7")]
		set;
	}

	[Token(Token = "0x1700065D")]
	[field: Token(Token = "0x4007C1F")]
	[field: FieldOffset(Offset = "0x19C")]
	public int buttonIndex
	{
		[Token(Token = "0x6006221")]
		[Address(RVA = "0x9BB210", Offset = "0x9BA010", Length = "0x7")]
		get;
		[Token(Token = "0x6006222")]
		[Address(RVA = "0xFB33C0", Offset = "0xFB21C0", Length = "0x7")]
		set;
	}

	[Token(Token = "0x6006223")]
	[Address(RVA = "0xFB33D0", Offset = "0xFB21D0", Length = "0x2C")]
	public PlayerPointerEventData(EventSystem eventSystem)
		: base(null)
	{
	}

	[Token(Token = "0x6006224")]
	[Address(RVA = "0xFB3400", Offset = "0xFB2200", Length = "0x476")]
	public override string ToString()
	{
		return null;
	}
}

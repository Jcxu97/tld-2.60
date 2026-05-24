using Cpp2ILInjected;

namespace TLD.Interactions;

[Token(Token = "0x20013A6")]
public class TimedHoldInteraction : BaseHoldInteraction
{
	[Token(Token = "0x4008FFB")]
	[FieldOffset(Offset = "0x58")]
	public float m_DefaultHoldTime;

	[Token(Token = "0x4008FFD")]
	[FieldOffset(Offset = "0x60")]
	private float m_Timer;

	[Token(Token = "0x17000AA9")]
	[field: Token(Token = "0x4008FFC")]
	[field: FieldOffset(Offset = "0x5C")]
	public float HoldTime
	{
		[Token(Token = "0x6007D6D")]
		[Address(RVA = "0x502520", Offset = "0x501320", Length = "0x6")]
		get;
		[Token(Token = "0x6007D6E")]
		[Address(RVA = "0x502530", Offset = "0x501330", Length = "0x6")]
		set;
	}

	[Token(Token = "0x17000AAA")]
	public override float NormalizedProgress
	{
		[Token(Token = "0x6007D6F")]
		[Address(RVA = "0x11C7210", Offset = "0x11C6010", Length = "0xB")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x6007D70")]
	[Address(RVA = "0x11C7220", Offset = "0x11C6020", Length = "0xCC")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x6007D71")]
	[Address(RVA = "0x11C72F0", Offset = "0x11C60F0", Length = "0x6C")]
	public override bool PerformHold()
	{
		return false;
	}

	[Token(Token = "0x6007D72")]
	[Address(RVA = "0x11C7360", Offset = "0x11C6160", Length = "0xC7")]
	protected override void BeginHold()
	{
	}

	[Token(Token = "0x6007D73")]
	[Address(RVA = "0x11C7430", Offset = "0x11C6230", Length = "0x54")]
	protected override void UpdateHoldInteraction(float deltaTime)
	{
	}

	[Token(Token = "0x6007D74")]
	[Address(RVA = "0x11C7490", Offset = "0x11C6290", Length = "0x9D")]
	protected override void EndHold()
	{
	}

	[Token(Token = "0x6007D75")]
	[Address(RVA = "0x11C64C0", Offset = "0x11C52C0", Length = "0x95")]
	public TimedHoldInteraction()
	{
	}
}

using Cpp2ILInjected;

[Token(Token = "0x20005C2")]
public class WoodStove : FireplaceInteraction
{
	[Token(Token = "0x4003529")]
	[FieldOffset(Offset = "0x70")]
	public string m_StoveOpenSound;

	[Token(Token = "0x400352A")]
	[FieldOffset(Offset = "0x78")]
	public string m_StoveCloseSound;

	[Token(Token = "0x400352B")]
	[FieldOffset(Offset = "0x80")]
	private bool m_Open;

	[Token(Token = "0x400352C")]
	[FieldOffset(Offset = "0x81")]
	private bool m_ClosePending;

	[Token(Token = "0x400352D")]
	[FieldOffset(Offset = "0x88")]
	private ObjectAnim m_ObjectAnim;

	[Token(Token = "0x6002C87")]
	[Address(RVA = "0x9378D0", Offset = "0x9366D0", Length = "0x1CB")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002C88")]
	[Address(RVA = "0x937AA0", Offset = "0x9368A0", Length = "0x11")]
	private void Update()
	{
	}

	[Token(Token = "0x6002C89")]
	[Address(RVA = "0x937AC0", Offset = "0x9368C0", Length = "0x1E7")]
	public bool Open()
	{
		return false;
	}

	[Token(Token = "0x6002C8A")]
	[Address(RVA = "0x937CB0", Offset = "0x936AB0", Length = "0x1FF")]
	public void Close()
	{
	}

	[Token(Token = "0x6002C8B")]
	[Address(RVA = "0x937EB0", Offset = "0x936CB0", Length = "0x1BA")]
	public override void PerformFireplaceInteraction()
	{
	}

	[Token(Token = "0x6002C8C")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool TooWindyToStart()
	{
		return false;
	}

	[Token(Token = "0x6002C8D")]
	[Address(RVA = "0x8EC770", Offset = "0x8EB570", Length = "0x7")]
	public WoodStove()
	{
	}
}

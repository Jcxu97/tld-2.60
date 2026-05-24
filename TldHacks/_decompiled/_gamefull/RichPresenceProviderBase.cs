using Cpp2ILInjected;

[Token(Token = "0x200090A")]
public abstract class RichPresenceProviderBase : IRichPresenceProvider
{
	[Token(Token = "0x4005E6D")]
	[FieldOffset(Offset = "0x10")]
	protected PresenceType m_CurrentPresence;

	[Token(Token = "0x4005E6E")]
	[FieldOffset(Offset = "0x14")]
	private bool m_PresenceHasChanged;

	[Token(Token = "0x6005278")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void Initialize()
	{
	}

	[Token(Token = "0x6005279")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void Shutdown()
	{
	}

	[Token(Token = "0x600527A")]
	[Address(RVA = "0xE49A20", Offset = "0xE48820", Length = "0xD")]
	public void SetPresence(PresenceType presenceType)
	{
	}

	[Token(Token = "0x600527B")]
	[Address(RVA = "0xE49A30", Offset = "0xE48830", Length = "0x84")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x600527C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void SetLocalizationKeys(RichPresenceLocInfo[] locKeys)
	{
	}

	[Token(Token = "0x600527D")]
	protected abstract bool IsUserSignedOn();

	[Token(Token = "0x600527E")]
	protected abstract void ChangePresence();

	[Token(Token = "0x600527F")]
	[Address(RVA = "0xE49AC0", Offset = "0xE488C0", Length = "0x28C")]
	protected void UpdateRichPresence()
	{
	}

	[Token(Token = "0x6005280")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected RichPresenceProviderBase()
	{
	}
}

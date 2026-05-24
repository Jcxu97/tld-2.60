using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000908")]
public abstract class RichPresenceLocalizedProviderBase : RichPresenceProviderBase
{
	[Token(Token = "0x2000909")]
	private class PresenceEqualityComparer : IEqualityComparer<PresenceType>
	{
		[Token(Token = "0x6005275")]
		[Address(RVA = "0x5DC750", Offset = "0x5DB550", Length = "0x7")]
		public bool Equals(PresenceType x, PresenceType y)
		{
			return false;
		}

		[Token(Token = "0x6005276")]
		[Address(RVA = "0x5DC760", Offset = "0x5DB560", Length = "0x3")]
		public int GetHashCode(PresenceType x)
		{
			return 0;
		}

		[Token(Token = "0x6005277")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public PresenceEqualityComparer()
		{
		}
	}

	[Token(Token = "0x4005E6C")]
	[FieldOffset(Offset = "0x18")]
	protected Dictionary<PresenceType, string> m_PresenceLocKeys;

	[Token(Token = "0x6005272")]
	[Address(RVA = "0xE496E0", Offset = "0xE484E0", Length = "0x1FA")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6005273")]
	[Address(RVA = "0xE498E0", Offset = "0xE486E0", Length = "0x135")]
	public override void SetLocalizationKeys(RichPresenceLocInfo[] locKeys)
	{
	}

	[Token(Token = "0x6005274")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected RichPresenceLocalizedProviderBase()
	{
	}
}

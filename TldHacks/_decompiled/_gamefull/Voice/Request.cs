using System;
using System.Diagnostics;
using Cpp2ILInjected;

namespace Voice;

[Token(Token = "0x2001330")]
public class Request
{
	[Token(Token = "0x4008DA8")]
	[FieldOffset(Offset = "0x10")]
	public Action m_CompletionCallback;

	[Token(Token = "0x4008DA9")]
	[FieldOffset(Offset = "0x18")]
	public uint m_EventID;

	[Token(Token = "0x4008DAA")]
	[FieldOffset(Offset = "0x1C")]
	public uint m_Options;

	[Token(Token = "0x4008DAB")]
	[FieldOffset(Offset = "0x20")]
	public Priority m_Priority;

	[Token(Token = "0x4008DAC")]
	[FieldOffset(Offset = "0x24")]
	public float m_Timeout;

	[Token(Token = "0x6007B02")]
	[Address(RVA = "0x119B400", Offset = "0x119A200", Length = "0x83")]
	public void Copy(Request other)
	{
	}

	[Token(Token = "0x6007B03")]
	[Address(RVA = "0x119B490", Offset = "0x119A290", Length = "0xB")]
	public bool IsOptionSet(uint option)
	{
		return false;
	}

	[Token(Token = "0x6007B04")]
	[Address(RVA = "0x119B4A0", Offset = "0x119A2A0", Length = "0x8")]
	public bool IsValid()
	{
		return false;
	}

	[Token(Token = "0x6007B05")]
	[Address(RVA = "0x119B4B0", Offset = "0x119A2B0", Length = "0xB")]
	public string GetEventName()
	{
		return null;
	}

	[Token(Token = "0x6007B06")]
	[Address(RVA = "0x119B4C0", Offset = "0x119A2C0", Length = "0x53")]
	public TimeSpan GetTimestamp()
	{
		return default(TimeSpan);
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6007B07")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void SetEventName(string name)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6007B08")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void SetTimestamp()
	{
	}

	[Token(Token = "0x6007B09")]
	[Address(RVA = "0x119B520", Offset = "0x119A320", Length = "0xF")]
	public virtual void Reset()
	{
	}

	[Token(Token = "0x6007B0A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Request()
	{
	}
}

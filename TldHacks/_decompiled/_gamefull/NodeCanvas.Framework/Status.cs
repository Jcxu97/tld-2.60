using Cpp2ILInjected;

namespace NodeCanvas.Framework;

[Token(Token = "0x2001069")]
public enum Status
{
	[Token(Token = "0x4008576")]
	Failure,
	[Token(Token = "0x4008577")]
	Success,
	[Token(Token = "0x4008578")]
	Running,
	[Token(Token = "0x4008579")]
	Resting,
	[Token(Token = "0x400857A")]
	Error,
	[Token(Token = "0x400857B")]
	Optional
}

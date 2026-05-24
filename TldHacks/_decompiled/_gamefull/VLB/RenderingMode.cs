using Cpp2ILInjected;

namespace VLB;

[Token(Token = "0x2000BCC")]
public enum RenderingMode
{
	[Token(Token = "0x400790B")]
	MultiPass,
	[Token(Token = "0x400790C")]
	SinglePass,
	[Token(Token = "0x400790D")]
	GPUInstancing,
	[Token(Token = "0x400790E")]
	SRPBatcher
}

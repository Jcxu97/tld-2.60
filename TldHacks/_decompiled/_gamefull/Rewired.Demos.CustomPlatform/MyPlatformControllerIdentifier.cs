using Cpp2ILInjected;

namespace Rewired.Demos.CustomPlatform;

[Token(Token = "0x2000C6B")]
public struct MyPlatformControllerIdentifier
{
	[Token(Token = "0x4007D96")]
	[FieldOffset(Offset = "0x0")]
	public ushort vendorId;

	[Token(Token = "0x4007D97")]
	[FieldOffset(Offset = "0x2")]
	public ushort productId;
}

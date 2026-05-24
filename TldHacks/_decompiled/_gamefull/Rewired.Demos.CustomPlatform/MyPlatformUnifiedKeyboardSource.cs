using Cpp2ILInjected;
using Rewired.Platforms.Custom;

namespace Rewired.Demos.CustomPlatform;

[Token(Token = "0x2000C72")]
public class MyPlatformUnifiedKeyboardSource : CustomPlatformUnifiedKeyboardSource
{
	[Token(Token = "0x4007DA0")]
	private static readonly KeyboardKeyCode[] keyCodes;

	[Token(Token = "0x600645F")]
	[Address(RVA = "0xFE54F0", Offset = "0xFE42F0", Length = "0x4D3")]
	protected override void OnInitialize()
	{
	}

	[Token(Token = "0x6006460")]
	[Address(RVA = "0xFE59D0", Offset = "0xFE47D0", Length = "0x2BA")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6006461")]
	[Address(RVA = "0xFE5C90", Offset = "0xFE4A90", Length = "0x77")]
	public MyPlatformUnifiedKeyboardSource()
	{
	}
}

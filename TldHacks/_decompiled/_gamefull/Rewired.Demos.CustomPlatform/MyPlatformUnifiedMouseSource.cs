using Cpp2ILInjected;
using Rewired.Platforms.Custom;
using UnityEngine;

namespace Rewired.Demos.CustomPlatform;

[Token(Token = "0x2000C73")]
public class MyPlatformUnifiedMouseSource : CustomPlatformUnifiedMouseSource
{
	[Token(Token = "0x170006BE")]
	public override Vector2 mousePosition
	{
		[Token(Token = "0x6006463")]
		[Address(RVA = "0xFE5F10", Offset = "0xFE4D10", Length = "0x69")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x6006464")]
	[Address(RVA = "0xFE5F80", Offset = "0xFE4D80", Length = "0x46D")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6006465")]
	[Address(RVA = "0xFE63F0", Offset = "0xFE51F0", Length = "0x10")]
	public MyPlatformUnifiedMouseSource()
	{
	}
}

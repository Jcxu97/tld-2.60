using Cpp2ILInjected;
using Rewired.Platforms.Custom;
using UnityEngine;

namespace Rewired.Demos.CustomPlatform;

[Token(Token = "0x2000C67")]
public sealed class CustomPlatformManager : MonoBehaviour, ICustomPlatformInitializer
{
	[Token(Token = "0x4007D92")]
	[FieldOffset(Offset = "0x20")]
	public CustomPlatformHardwareJoystickMapProvider mapProvider;

	[Token(Token = "0x6006435")]
	[Address(RVA = "0xFE3320", Offset = "0xFE2120", Length = "0x281")]
	public CustomPlatformInitOptions GetCustomPlatformInitOptions()
	{
		return null;
	}

	[Token(Token = "0x6006436")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CustomPlatformManager()
	{
	}
}

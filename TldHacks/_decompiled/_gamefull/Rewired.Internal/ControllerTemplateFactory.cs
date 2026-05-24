using System;
using Cpp2ILInjected;

namespace Rewired.Internal;

[Token(Token = "0x2000C28")]
public static class ControllerTemplateFactory
{
	[Token(Token = "0x4007C18")]
	private static readonly Type[] _defaultTemplateTypes;

	[Token(Token = "0x4007C19")]
	private static readonly Type[] _defaultTemplateInterfaceTypes;

	[Token(Token = "0x17000656")]
	public static Type[] templateTypes
	{
		[Token(Token = "0x6006213")]
		[Address(RVA = "0xFB23C0", Offset = "0xFB11C0", Length = "0x53")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000657")]
	public static Type[] templateInterfaceTypes
	{
		[Token(Token = "0x6006214")]
		[Address(RVA = "0xFB2420", Offset = "0xFB1220", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006215")]
	[Address(RVA = "0xFB2480", Offset = "0xFB1280", Length = "0x5F2")]
	public static IControllerTemplate Create(Guid typeGuid, object payload)
	{
		return null;
	}
}

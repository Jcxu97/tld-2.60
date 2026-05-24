using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000025")]
public class EventParamMappings
{
	[Token(Token = "0x4000221")]
	public static Dictionary<iTweenEvent.TweenType, Dictionary<string, Type>> mappings;

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x883C00", Offset = "0x882A00", Length = "0xF5A1")]
	static EventParamMappings()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public EventParamMappings()
	{
	}
}

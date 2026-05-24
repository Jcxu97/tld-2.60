using Cpp2ILInjected;
using MissionTypes;
using UnityEngine;

[Token(Token = "0x200085D")]
public class MissionUtils
{
	[Token(Token = "0x6004CEF")]
	[Address(RVA = "0xD7EEE0", Offset = "0xD7DCE0", Length = "0x677")]
	public static void PostObjectEvent(GameObject obj, MissionObjectEvent eventType)
	{
	}

	[Token(Token = "0x6004CF0")]
	[Address(RVA = "0xD7F560", Offset = "0xD7E360", Length = "0x2A7")]
	public static void PostAfflictionEvent(GameObject obj, AfflictionType afflictionType, AfflictionEventType eventType)
	{
	}

	[Token(Token = "0x6004CF1")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public MissionUtils()
	{
	}
}

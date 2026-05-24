using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x20014A1")]
public static class DisableForCurrentModeExtensions
{
	[Token(Token = "0x60082D7")]
	[Address(RVA = "0x123E990", Offset = "0x123D790", Length = "0x26B")]
	public static bool ShouldDisableForCurrentMode(this GameObject gameObject)
	{
		return false;
	}

	[Token(Token = "0x60082D8")]
	[Address(RVA = "0x123EC00", Offset = "0x123DA00", Length = "0x269")]
	public static bool ShouldDisableForCurrentModeRecursive(this GameObject gameObject, bool includeInactive)
	{
		return false;
	}

	[Token(Token = "0x60082D9")]
	[Address(RVA = "0x123EE70", Offset = "0x123DC70", Length = "0x293")]
	public static bool ShouldDisableForCurrentMode(this GearItemData gearItemData)
	{
		return false;
	}
}

using System;
using Cpp2ILInjected;

namespace TLD.Gameplay.Tunable;

[Serializable]
[Token(Token = "0x20014BD")]
public class CustomTunableLookup_DayNightMultiplier : CustomTunableLookup<CustomTunableDayNightMultiplier, float>
{
	[Token(Token = "0x60082F6")]
	[Address(RVA = "0x123FF50", Offset = "0x123ED50", Length = "0x64")]
	public CustomTunableLookup_DayNightMultiplier()
	{
	}
}

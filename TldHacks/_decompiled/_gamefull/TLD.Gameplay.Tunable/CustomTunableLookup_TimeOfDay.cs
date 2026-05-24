using System;
using Cpp2ILInjected;

namespace TLD.Gameplay.Tunable;

[Serializable]
[Token(Token = "0x20014BE")]
public class CustomTunableLookup_TimeOfDay : CustomTunableLookup<CustomTunableTimeOfDay, float>
{
	[Token(Token = "0x60082F7")]
	[Address(RVA = "0x123FFC0", Offset = "0x123EDC0", Length = "0x64")]
	public CustomTunableLookup_TimeOfDay()
	{
	}
}

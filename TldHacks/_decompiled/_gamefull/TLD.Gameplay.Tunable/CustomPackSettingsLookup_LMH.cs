using System;
using Cpp2ILInjected;
using TLD.AI;

namespace TLD.Gameplay.Tunable;

[Serializable]
[Token(Token = "0x20014B7")]
public class CustomPackSettingsLookup_LMH : CustomTunableLookup<CustomTunableLMH, PackSettings>
{
	[Token(Token = "0x60082F0")]
	[Address(RVA = "0x123FCB0", Offset = "0x123EAB0", Length = "0x64")]
	public CustomPackSettingsLookup_LMH()
	{
	}
}

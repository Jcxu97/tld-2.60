using System;
using Cpp2ILInjected;

namespace TLD.Gameplay.Tunable;

[Serializable]
[Token(Token = "0x20014C1")]
public class CustomTunableLookup_ProportionalMaxItems : CustomTunableLookup<CustomTunableNLH, CustomTunableLookup_NLMH>
{
	[Token(Token = "0x60082FA")]
	[Address(RVA = "0x1240110", Offset = "0x123EF10", Length = "0x64")]
	public CustomTunableLookup_ProportionalMaxItems()
	{
	}
}

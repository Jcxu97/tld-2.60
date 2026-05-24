using System;
using Cpp2ILInjected;

namespace TLD.Gameplay.Tunable;

[Serializable]
[Token(Token = "0x20014BC")]
public class CustomTunableLookup_NLMHV : CustomTunableLookup<CustomTunableNLMHV, float>
{
	[Token(Token = "0x60082F5")]
	[Address(RVA = "0x123FEE0", Offset = "0x123ECE0", Length = "0x64")]
	public CustomTunableLookup_NLMHV()
	{
	}
}

using System;
using Cpp2ILInjected;

namespace TLD.Gameplay.Tunable;

[Serializable]
[Token(Token = "0x20014BB")]
public class CustomTunableLookup_NLMH : CustomTunableLookup<CustomTunableNLMH, float>
{
	[Token(Token = "0x60082F4")]
	[Address(RVA = "0x123FE70", Offset = "0x123EC70", Length = "0x64")]
	public CustomTunableLookup_NLMH()
	{
	}
}

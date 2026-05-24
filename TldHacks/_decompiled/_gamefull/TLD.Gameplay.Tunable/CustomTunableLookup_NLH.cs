using System;
using Cpp2ILInjected;

namespace TLD.Gameplay.Tunable;

[Serializable]
[Token(Token = "0x20014B8")]
public class CustomTunableLookup_NLH : CustomTunableLookup<CustomTunableNLH, float>
{
	[Token(Token = "0x60082F1")]
	[Address(RVA = "0x123FD20", Offset = "0x123EB20", Length = "0x64")]
	public CustomTunableLookup_NLH()
	{
	}
}

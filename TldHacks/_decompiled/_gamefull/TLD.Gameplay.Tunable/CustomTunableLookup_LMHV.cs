using System;
using Cpp2ILInjected;

namespace TLD.Gameplay.Tunable;

[Serializable]
[Token(Token = "0x20014BA")]
public class CustomTunableLookup_LMHV : CustomTunableLookup<CustomTunableLMHV, float>
{
	[Token(Token = "0x60082F3")]
	[Address(RVA = "0x123FE00", Offset = "0x123EC00", Length = "0x64")]
	public CustomTunableLookup_LMHV()
	{
	}
}

using System;
using Cpp2ILInjected;

namespace TLD.Gameplay.Tunable;

[Serializable]
[Token(Token = "0x20014B6")]
public class CustomTunableLookup_LMH : CustomTunableLookup<CustomTunableLMH, float>
{
	[Token(Token = "0x60082EF")]
	[Address(RVA = "0x123FC40", Offset = "0x123EA40", Length = "0x64")]
	public CustomTunableLookup_LMH()
	{
	}
}

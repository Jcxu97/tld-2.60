using System;
using Cpp2ILInjected;

namespace TLD.Gameplay.Tunable;

[Serializable]
[Token(Token = "0x20014BF")]
public class CustomTunableLookup_Distance : CustomTunableLookup<CustomTunableDistance, float>
{
	[Token(Token = "0x60082F8")]
	[Address(RVA = "0x1240030", Offset = "0x123EE30", Length = "0x64")]
	public CustomTunableLookup_Distance()
	{
	}
}

using System;
using Cpp2ILInjected;

namespace TLD.Gameplay.Tunable;

[Serializable]
[Token(Token = "0x20014B9")]
public class CustomTunableLookup_OMH : CustomTunableLookup<CustomTunableOMH, float>
{
	[Token(Token = "0x60082F2")]
	[Address(RVA = "0x123FD90", Offset = "0x123EB90", Length = "0x64")]
	public CustomTunableLookup_OMH()
	{
	}
}

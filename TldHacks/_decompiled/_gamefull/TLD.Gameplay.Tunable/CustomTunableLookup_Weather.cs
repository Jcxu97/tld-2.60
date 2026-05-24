using System;
using Cpp2ILInjected;

namespace TLD.Gameplay.Tunable;

[Serializable]
[Token(Token = "0x20014C0")]
public class CustomTunableLookup_Weather : CustomTunableLookup<CustomTunableWeather, float>
{
	[Token(Token = "0x60082F9")]
	[Address(RVA = "0x12400A0", Offset = "0x123EEA0", Length = "0x64")]
	public CustomTunableLookup_Weather()
	{
	}
}

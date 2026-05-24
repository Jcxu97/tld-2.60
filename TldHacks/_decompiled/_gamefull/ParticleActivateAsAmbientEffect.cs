using Cpp2ILInjected;

[Token(Token = "0x20003DF")]
public class ParticleActivateAsAmbientEffect : ParticleActivateBase
{
	[Token(Token = "0x6001E0B")]
	[Address(RVA = "0x7B2DA0", Offset = "0x7B1BA0", Length = "0xB2")]
	public override bool CanBeActive()
	{
		return false;
	}

	[Token(Token = "0x6001E0C")]
	[Address(RVA = "0x7B2E60", Offset = "0x7B1C60", Length = "0x47")]
	public ParticleActivateAsAmbientEffect()
	{
	}
}

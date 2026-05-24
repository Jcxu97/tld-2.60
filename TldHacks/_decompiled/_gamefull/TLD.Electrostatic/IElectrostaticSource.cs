using Cpp2ILInjected;

namespace TLD.Electrostatic;

[Token(Token = "0x20013E0")]
public interface IElectrostaticSource
{
	[Token(Token = "0x6007ED0")]
	float GetElectroStaticActive();

	[Token(Token = "0x6007ED1")]
	float GetElectrostaticStrength();
}

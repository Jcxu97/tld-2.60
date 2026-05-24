using Cpp2ILInjected;

namespace NodeCanvas.Framework;

[Token(Token = "0x2001060")]
public interface ISubParametersContainer
{
	[Token(Token = "0x6006F02")]
	BBParameter[] GetSubParameters();
}

using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x2000BF9")]
public interface IFlightPedalsTemplate : IControllerTemplate
{
	[Token(Token = "0x170004F1")]
	IControllerTemplateAxis leftPedal
	{
		[Token(Token = "0x6005F3F")]
		get;
	}

	[Token(Token = "0x170004F2")]
	IControllerTemplateAxis rightPedal
	{
		[Token(Token = "0x6005F40")]
		get;
	}

	[Token(Token = "0x170004F3")]
	IControllerTemplateAxis slide
	{
		[Token(Token = "0x6005F41")]
		get;
	}
}

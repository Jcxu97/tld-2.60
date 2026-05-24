using Cpp2ILInjected;

namespace NodeCanvas.Framework;

[Token(Token = "0x200105C")]
public interface IGraphAssignable
{
	[Token(Token = "0x170007B4")]
	Graph nestedGraph
	{
		[Token(Token = "0x6006EFC")]
		get;
		[Token(Token = "0x6006EFD")]
		set;
	}

	[Token(Token = "0x6006EFE")]
	Graph[] GetInstances();
}

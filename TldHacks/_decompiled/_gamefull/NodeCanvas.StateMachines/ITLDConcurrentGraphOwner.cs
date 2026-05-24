using Cpp2ILInjected;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

[Token(Token = "0x20010BC")]
public interface ITLDConcurrentGraphOwner
{
	[Token(Token = "0x600717F")]
	void RegisterConcurrentGraph(string id, GraphOwner graphOwner);

	[Token(Token = "0x6007180")]
	void RemoveConcurrentGraph(string id);
}

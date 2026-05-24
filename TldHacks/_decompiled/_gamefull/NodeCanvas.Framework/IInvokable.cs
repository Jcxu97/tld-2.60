using System;
using Cpp2ILInjected;

namespace NodeCanvas.Framework;

[Token(Token = "0x200105B")]
public interface IInvokable
{
	[Token(Token = "0x6006EF9")]
	string GetInvocationID();

	[Token(Token = "0x6006EFA")]
	object Invoke(params object[] args);

	[Token(Token = "0x6006EFB")]
	void InvokeAsync(Action<object> callback, params object[] args);
}

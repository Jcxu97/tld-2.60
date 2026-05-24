using System.Reflection;
using Cpp2ILInjected;

namespace NodeCanvas.Framework.Internal;

[Token(Token = "0x20010B0")]
public abstract class ReflectedFunctionWrapper : ReflectedWrapper
{
	[Token(Token = "0x600713A")]
	[Address(RVA = "0x10D0BE0", Offset = "0x10CF9E0", Length = "0x7F7")]
	public new static ReflectedFunctionWrapper Create(MethodInfo method, IBlackboard bb)
	{
		return null;
	}

	[Token(Token = "0x600713B")]
	public abstract object Call();

	[Token(Token = "0x600713C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected ReflectedFunctionWrapper()
	{
	}
}

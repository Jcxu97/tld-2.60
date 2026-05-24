using System.Reflection;
using Cpp2ILInjected;

namespace NodeCanvas.Framework.Internal;

[Token(Token = "0x20010AE")]
public abstract class ReflectedActionWrapper : ReflectedWrapper
{
	[Token(Token = "0x6007134")]
	[Address(RVA = "0x10D0360", Offset = "0x10CF160", Length = "0x7D3")]
	public new static ReflectedActionWrapper Create(MethodInfo method, IBlackboard bb)
	{
		return null;
	}

	[Token(Token = "0x6007135")]
	public abstract void Call();

	[Token(Token = "0x6007136")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected ReflectedActionWrapper()
	{
	}
}

using System.Reflection;
using Cpp2ILInjected;

namespace NodeCanvas.Framework;

[Token(Token = "0x2001062")]
public interface IReflectedWrapper
{
	[Token(Token = "0x6006F04")]
	MemberInfo GetMemberInfo();
}

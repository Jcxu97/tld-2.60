using Cpp2ILInjected;

namespace NodeCanvas.Framework;

[Token(Token = "0x200105D")]
public interface ITaskAssignable
{
	[Token(Token = "0x170007B5")]
	Task task
	{
		[Token(Token = "0x6006EFF")]
		get;
		[Token(Token = "0x6006F00")]
		set;
	}
}
[Token(Token = "0x200105E")]
public interface ITaskAssignable<T> : ITaskAssignable where T : Task
{
}

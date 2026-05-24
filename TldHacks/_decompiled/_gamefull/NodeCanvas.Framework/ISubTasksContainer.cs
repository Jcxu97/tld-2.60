using Cpp2ILInjected;

namespace NodeCanvas.Framework;

[Token(Token = "0x200105F")]
public interface ISubTasksContainer
{
	[Token(Token = "0x6006F01")]
	Task[] GetSubTasks();
}

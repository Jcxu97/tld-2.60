using Cpp2ILInjected;

namespace NodeCanvas.StateMachines;

[Token(Token = "0x20010CF")]
public interface IState
{
	[Token(Token = "0x1700085B")]
	string name
	{
		[Token(Token = "0x600720D")]
		get;
	}

	[Token(Token = "0x1700085C")]
	string tag
	{
		[Token(Token = "0x600720E")]
		get;
	}

	[Token(Token = "0x1700085D")]
	float elapsedTime
	{
		[Token(Token = "0x600720F")]
		get;
	}

	[Token(Token = "0x1700085E")]
	FSM FSM
	{
		[Token(Token = "0x6007210")]
		get;
	}

	[Token(Token = "0x6007211")]
	FSMConnection[] GetTransitions();

	[Token(Token = "0x6007212")]
	bool CheckTransitions();

	[Token(Token = "0x6007213")]
	void Finish(bool success);
}

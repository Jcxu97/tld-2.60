using Cpp2ILInjected;

namespace ParadoxNotion.Serialization;

[Token(Token = "0x2000D81")]
public interface IMissingRecoverable
{
	[Token(Token = "0x17000733")]
	string missingType
	{
		[Token(Token = "0x6006962")]
		get;
		[Token(Token = "0x6006963")]
		set;
	}

	[Token(Token = "0x17000734")]
	string recoveryState
	{
		[Token(Token = "0x6006964")]
		get;
		[Token(Token = "0x6006965")]
		set;
	}
}

using Cpp2ILInjected;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Framework;

[Token(Token = "0x2001076")]
public interface ITaskSystem
{
	[Token(Token = "0x170007E3")]
	Component agent
	{
		[Token(Token = "0x6006FB6")]
		get;
	}

	[Token(Token = "0x170007E4")]
	IBlackboard blackboard
	{
		[Token(Token = "0x6006FB7")]
		get;
	}

	[Token(Token = "0x170007E5")]
	float elapsedTime
	{
		[Token(Token = "0x6006FB8")]
		get;
	}

	[Token(Token = "0x170007E6")]
	Object contextObject
	{
		[Token(Token = "0x6006FB9")]
		get;
	}

	[Token(Token = "0x6006FBA")]
	void SendTaskOwnerDefaults();

	[Token(Token = "0x6006FBB")]
	void SendEvent(EventData eventData, object sender);

	[Token(Token = "0x6006FBC")]
	void RecordUndo(string name);
}

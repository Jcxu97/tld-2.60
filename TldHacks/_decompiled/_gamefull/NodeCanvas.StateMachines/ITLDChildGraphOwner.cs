using Cpp2ILInjected;
using UnityEngine;

namespace NodeCanvas.StateMachines;

[Token(Token = "0x20010BE")]
public interface ITLDChildGraphOwner
{
	[Token(Token = "0x1700083B")]
	GameObject childGraphPrefab
	{
		[Token(Token = "0x6007183")]
		get;
		[Token(Token = "0x6007184")]
		set;
	}
}

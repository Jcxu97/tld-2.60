using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x2001498")]
public abstract class ScriptableAction : ScriptableObject
{
	[Token(Token = "0x60082B9")]
	public abstract void ExecuteAction();

	[Token(Token = "0x60082BA")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	protected ScriptableAction()
	{
	}
}

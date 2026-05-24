using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("GameObject")]
[Token(Token = "0x200117A")]
public class HasComponent<T> : ConditionTask<Transform> where T : Component
{
	[Token(Token = "0x60074FD")]
	[Address(RVA = "0x295CA50", Offset = "0x295B850", Length = "0x166")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074FE")]
	[Address(RVA = "0x295CBC0", Offset = "0x295B9C0", Length = "0x44")]
	public HasComponent()
	{
	}
}

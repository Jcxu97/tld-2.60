using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("GameObject")]
[Token(Token = "0x200117B")]
public class IsActive : ConditionTask<Transform>
{
	[Token(Token = "0x60074FF")]
	[Address(RVA = "0x1108470", Offset = "0x1107270", Length = "0x112")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007500")]
	[Address(RVA = "0x1108590", Offset = "0x1107390", Length = "0x44")]
	public IsActive()
	{
	}
}

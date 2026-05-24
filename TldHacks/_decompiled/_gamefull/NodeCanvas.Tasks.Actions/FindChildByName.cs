using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Description("Find a transform child by name within the agent's transform")]
[Token(Token = "0x20012C0")]
public class FindChildByName : ActionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008BC9")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> childName;

	[BlackboardOnly]
	[Token(Token = "0x4008BCA")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<Transform> saveAs;

	[Token(Token = "0x170009EC")]
	protected override string info
	{
		[Token(Token = "0x6007913")]
		[Address(RVA = "0x1175FC0", Offset = "0x1174DC0", Length = "0xE6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007914")]
	[Address(RVA = "0x11760B0", Offset = "0x1174EB0", Length = "0x206")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007915")]
	[Address(RVA = "0x11762C0", Offset = "0x11750C0", Length = "0x44")]
	public FindChildByName()
	{
	}
}

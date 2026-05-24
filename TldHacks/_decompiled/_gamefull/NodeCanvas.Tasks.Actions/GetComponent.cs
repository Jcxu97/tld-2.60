using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Token(Token = "0x20012C9")]
public class GetComponent<T> : ActionTask<Transform> where T : Component
{
	[BlackboardOnly]
	[Token(Token = "0x4008BDD")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> saveAs;

	[Token(Token = "0x170009F0")]
	protected override string info
	{
		[Token(Token = "0x600792C")]
		[Address(RVA = "0x2954180", Offset = "0x2952F80", Length = "0x12C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600792D")]
	[Address(RVA = "0x29542B0", Offset = "0x29530B0", Length = "0x191")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600792E")]
	[Address(RVA = "0x2954450", Offset = "0x2953250", Length = "0x44")]
	public GetComponent()
	{
	}
}

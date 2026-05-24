using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Obsolete("Use Get Property instead")]
[Category("GameObject")]
[Token(Token = "0x20012CB")]
public class GetGameObjectPosition : ActionTask<Transform>
{
	[BlackboardOnly]
	[Token(Token = "0x4008BE0")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<Vector3> saveAs;

	[Token(Token = "0x170009F2")]
	protected override string info
	{
		[Token(Token = "0x6007932")]
		[Address(RVA = "0x1177B30", Offset = "0x1176930", Length = "0xE5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007933")]
	[Address(RVA = "0x1177C20", Offset = "0x1176A20", Length = "0x16D")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007934")]
	[Address(RVA = "0x1177D90", Offset = "0x1176B90", Length = "0x44")]
	public GetGameObjectPosition()
	{
	}
}

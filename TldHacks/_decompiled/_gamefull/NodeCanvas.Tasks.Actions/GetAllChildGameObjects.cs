using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Token(Token = "0x20012C7")]
public class GetAllChildGameObjects : ActionTask<Transform>
{
	[BlackboardOnly]
	[Token(Token = "0x4008BD9")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<List<GameObject>> saveAs;

	[Token(Token = "0x4008BDA")]
	[FieldOffset(Offset = "0x70")]
	public bool recursive;

	[Token(Token = "0x170009EF")]
	protected override string info
	{
		[Token(Token = "0x6007925")]
		[Address(RVA = "0x1176C10", Offset = "0x1175A10", Length = "0x124")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007926")]
	[Address(RVA = "0x1176D40", Offset = "0x1175B40", Length = "0x5B0")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007927")]
	[Address(RVA = "0x1177300", Offset = "0x1176100", Length = "0x33D")]
	private List<Transform> Get(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6007928")]
	[Address(RVA = "0x1177640", Offset = "0x1176440", Length = "0x44")]
	public GetAllChildGameObjects()
	{
	}
}

using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Token(Token = "0x20012C6")]
public class FindWithTag : ActionTask
{
	[RequiredField]
	[TagField]
	[Token(Token = "0x4008BD7")]
	[FieldOffset(Offset = "0x68")]
	public string searchTag;

	[BlackboardOnly]
	[Token(Token = "0x4008BD8")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<GameObject> saveAs;

	[Token(Token = "0x170009EE")]
	protected override string info
	{
		[Token(Token = "0x6007922")]
		[Address(RVA = "0x1176A60", Offset = "0x1175860", Length = "0xA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007923")]
	[Address(RVA = "0x1176B00", Offset = "0x1175900", Length = "0x70")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007924")]
	[Address(RVA = "0x1176B80", Offset = "0x1175980", Length = "0x8E")]
	public FindWithTag()
	{
	}
}

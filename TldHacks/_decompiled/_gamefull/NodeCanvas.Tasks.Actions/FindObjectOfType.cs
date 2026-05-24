using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Description("Note that this is very slow")]
[Token(Token = "0x20012C2")]
public class FindObjectOfType<T> : ActionTask where T : Component
{
	[BlackboardOnly]
	[Token(Token = "0x4008BCF")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> saveComponentAs;

	[BlackboardOnly]
	[Token(Token = "0x4008BD0")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<GameObject> saveGameObjectAs;

	[Token(Token = "0x6007918")]
	[Address(RVA = "0x2934C20", Offset = "0x2933A20", Length = "0x15C")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007919")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public FindObjectOfType()
	{
	}
}

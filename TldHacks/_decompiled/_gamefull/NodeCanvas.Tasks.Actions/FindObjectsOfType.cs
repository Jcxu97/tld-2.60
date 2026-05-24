using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Description("Note that this is very slow")]
[Token(Token = "0x20012C3")]
public class FindObjectsOfType<T> : ActionTask where T : Component
{
	[BlackboardOnly]
	[Token(Token = "0x4008BD1")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<List<GameObject>> saveGameObjects;

	[BlackboardOnly]
	[Token(Token = "0x4008BD2")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<List<T>> saveComponents;

	[Token(Token = "0x600791A")]
	[Address(RVA = "0x2934D80", Offset = "0x2933B80", Length = "0x371")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600791B")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public FindObjectsOfType()
	{
	}
}

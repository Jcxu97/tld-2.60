using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Hide Objective", 0)]
[Category("TLD Mission UI")]
[Token(Token = "0x200123B")]
public class Action_HideObjective : ActionTask
{
	[SerializeField]
	[Token(Token = "0x4008A67")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x6007782")]
	[Address(RVA = "0x115D9D0", Offset = "0x115C7D0", Length = "0x78")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007783")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_HideObjective()
	{
	}
}

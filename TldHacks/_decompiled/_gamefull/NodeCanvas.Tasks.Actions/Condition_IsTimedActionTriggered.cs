using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Timed Action Popup Triggered", 0)]
[Category("TLD Mission UI")]
[Token(Token = "0x200124F")]
public class Condition_IsTimedActionTriggered : ConditionTask
{
	[SerializeField]
	[Token(Token = "0x4008A9D")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x60077B3")]
	[Address(RVA = "0x1161590", Offset = "0x1160390", Length = "0x130")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60077B4")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_IsTimedActionTriggered()
	{
	}
}

using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Show Side Credits", 0)]
[Category("TLD Credits")]
[Token(Token = "0x2001249")]
public class Action_ShowSideCredits : ActionTask
{
	[Token(Token = "0x4008A85")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> messageTop;

	[Token(Token = "0x4008A86")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> messageCenter;

	[Token(Token = "0x4008A87")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<string> messageBottom;

	[Token(Token = "0x4008A88")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> waitDuration;

	[SerializeField]
	[Token(Token = "0x4008A89")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x60077A5")]
	[Address(RVA = "0x1160640", Offset = "0x115F440", Length = "0x147")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077A6")]
	[Address(RVA = "0x1160790", Offset = "0x115F590", Length = "0x378")]
	public Action_ShowSideCredits()
	{
	}
}

using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Show Center Credit", 0)]
[Category("TLD Credits")]
[Token(Token = "0x2001248")]
public class Action_ShowCenterCredit : ActionTask
{
	[Token(Token = "0x4008A80")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> message;

	[Token(Token = "0x4008A81")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> messageIsLocID;

	[Token(Token = "0x4008A82")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> tweenDuration;

	[Token(Token = "0x4008A83")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> waitDuration;

	[SerializeField]
	[Token(Token = "0x4008A84")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x60077A3")]
	[Address(RVA = "0x1160100", Offset = "0x115EF00", Length = "0x19E")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077A4")]
	[Address(RVA = "0x11602A0", Offset = "0x115F0A0", Length = "0x398")]
	public Action_ShowCenterCredit()
	{
	}
}

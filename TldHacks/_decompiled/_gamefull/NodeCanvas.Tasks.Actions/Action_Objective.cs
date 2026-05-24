using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Update Objective", 0)]
[Category("TLD Mission UI")]
[Token(Token = "0x200123A")]
public class Action_Objective : ActionTask
{
	[Token(Token = "0x4008A62")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> locID;

	[Token(Token = "0x4008A63")]
	[FieldOffset(Offset = "0x70")]
	public Color textColor;

	[Token(Token = "0x4008A64")]
	[FieldOffset(Offset = "0x80")]
	public bool allowSkipFirstTime;

	[Token(Token = "0x4008A65")]
	[FieldOffset(Offset = "0x81")]
	public bool keepAlive;

	[SerializeField]
	[Token(Token = "0x4008A66")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x600777E")]
	[Address(RVA = "0x115D750", Offset = "0x115C550", Length = "0x3B")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600777F")]
	[Address(RVA = "0x115D790", Offset = "0x115C590", Length = "0x7")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007780")]
	[Address(RVA = "0x115D7A0", Offset = "0x115C5A0", Length = "0xF6")]
	private void DoWork()
	{
	}

	[Token(Token = "0x6007781")]
	[Address(RVA = "0x115D8A0", Offset = "0x115C6A0", Length = "0x128")]
	public Action_Objective()
	{
	}
}

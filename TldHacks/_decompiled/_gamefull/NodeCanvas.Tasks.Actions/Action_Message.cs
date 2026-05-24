using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Debug Message", 0)]
[Category("TLD Debug")]
[Token(Token = "0x20011D8")]
public class Action_Message : ActionTask
{
	[Token(Token = "0x4008925")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> text;

	[Token(Token = "0x4008926")]
	[FieldOffset(Offset = "0x70")]
	public Color textColor;

	[Token(Token = "0x4008927")]
	[FieldOffset(Offset = "0x80")]
	public float waitTime;

	[Token(Token = "0x4008928")]
	[FieldOffset(Offset = "0x84")]
	public bool scopeToState;

	[Token(Token = "0x4008929")]
	[FieldOffset(Offset = "0x88")]
	public CompactStatus finishStatus;

	[SerializeField]
	[Token(Token = "0x400892A")]
	[FieldOffset(Offset = "0x90")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x17000966")]
	protected override string info
	{
		[Token(Token = "0x6007662")]
		[Address(RVA = "0x1146520", Offset = "0x1145320", Length = "0xA7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007663")]
	[Address(RVA = "0x11465D0", Offset = "0x11453D0", Length = "0x578")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007664")]
	[Address(RVA = "0x1146B50", Offset = "0x1145950", Length = "0x4B")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007665")]
	[Address(RVA = "0x1146BA0", Offset = "0x11459A0", Length = "0xC3")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x6007666")]
	[Address(RVA = "0x1146C70", Offset = "0x1145A70", Length = "0x13F")]
	public Action_Message()
	{
	}
}

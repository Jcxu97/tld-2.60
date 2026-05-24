using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Start Timed Action Popup", 0)]
[Category("TLD Mission UI")]
[Token(Token = "0x200124E")]
public class Action_TimedActionPopup : ActionTask
{
	[Token(Token = "0x4008A98")]
	[FieldOffset(Offset = "0x68")]
	public InputManager.InputAction Action;

	[Token(Token = "0x4008A99")]
	[FieldOffset(Offset = "0x6C")]
	public float DisplayTime;

	[Token(Token = "0x4008A9A")]
	[FieldOffset(Offset = "0x70")]
	public float HoldTime;

	[Token(Token = "0x4008A9B")]
	[FieldOffset(Offset = "0x78")]
	public string PromptKey;

	[SerializeField]
	[Token(Token = "0x4008A9C")]
	[FieldOffset(Offset = "0x80")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x17000995")]
	protected override string info
	{
		[Token(Token = "0x60077B1")]
		[Address(RVA = "0x11613D0", Offset = "0x11601D0", Length = "0x1BF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077B0")]
	[Address(RVA = "0x11610F0", Offset = "0x115FEF0", Length = "0x2DB")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077B2")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_TimedActionPopup()
	{
	}
}

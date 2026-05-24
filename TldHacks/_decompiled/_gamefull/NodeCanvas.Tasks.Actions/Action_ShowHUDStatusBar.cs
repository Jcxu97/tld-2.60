using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Show HUD Status Bar", 0)]
[Category("TLD Mission UI")]
[Token(Token = "0x200124B")]
public class Action_ShowHUDStatusBar : ActionTask
{
	[Token(Token = "0x4008A8B")]
	[FieldOffset(Offset = "0x68")]
	public StatusBar.StatusBarType statusBarType;

	[Token(Token = "0x4008A8C")]
	[FieldOffset(Offset = "0x6C")]
	public float secondsToFadeIn;

	[Token(Token = "0x4008A8D")]
	[FieldOffset(Offset = "0x70")]
	public float secondsToShow;

	[Token(Token = "0x4008A8E")]
	[FieldOffset(Offset = "0x74")]
	public float secondsToFadeOut;

	[SerializeField]
	[Token(Token = "0x4008A8F")]
	[FieldOffset(Offset = "0x78")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x17000993")]
	protected override string info
	{
		[Token(Token = "0x60077AB")]
		[Address(RVA = "0x1160DD0", Offset = "0x115FBD0", Length = "0x7A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077AA")]
	[Address(RVA = "0x1160BE0", Offset = "0x115F9E0", Length = "0x1E2")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077AC")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ShowHUDStatusBar()
	{
	}
}

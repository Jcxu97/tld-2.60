using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Toggle Location Discovery Text", 0)]
[Category("TLD Mission UI")]
[Token(Token = "0x200123C")]
public class Action_ToggleDiscoveryText : ActionTask
{
	[Token(Token = "0x4008A68")]
	[FieldOffset(Offset = "0x68")]
	public bool enableDiscoveryText;

	[SerializeField]
	[Token(Token = "0x4008A69")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x1700098E")]
	protected override string info
	{
		[Token(Token = "0x6007785")]
		[Address(RVA = "0x115DAD0", Offset = "0x115C8D0", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007784")]
	[Address(RVA = "0x115DA50", Offset = "0x115C850", Length = "0x78")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007786")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ToggleDiscoveryText()
	{
	}
}

using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Radial Menu", 0)]
[Description("Disables/Enables the Radial Menu")]
[Category("TLD Actions/Utils")]
[Token(Token = "0x200126C")]
public class Action_RadialMenu : ActionTask
{
	[Token(Token = "0x200126D")]
	public enum RadialMenuState
	{
		[Token(Token = "0x4008AEF")]
		Enable,
		[Token(Token = "0x4008AF0")]
		Disable
	}

	[Token(Token = "0x4008AEC")]
	[FieldOffset(Offset = "0x68")]
	public RadialMenuState radialMenuState;

	[SerializeField]
	[Token(Token = "0x4008AED")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[Token(Token = "0x170009A9")]
	protected override string info
	{
		[Token(Token = "0x6007803")]
		[Address(RVA = "0x1168900", Offset = "0x1167700", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007804")]
	[Address(RVA = "0x1168960", Offset = "0x1167760", Length = "0x7B")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007805")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_RadialMenu()
	{
	}
}

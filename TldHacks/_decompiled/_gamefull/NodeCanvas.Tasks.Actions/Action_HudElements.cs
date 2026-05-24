using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Hud Elements", 0)]
[Description("Toggles showing or hiding hud elements")]
[Category("TLD Actions/Utils")]
[Token(Token = "0x200126E")]
public class Action_HudElements : ActionTask
{
	[Token(Token = "0x200126F")]
	public enum HudElementsState
	{
		[Token(Token = "0x4008AF5")]
		Show,
		[Token(Token = "0x4008AF6")]
		Hide
	}

	[Token(Token = "0x4008AF1")]
	[FieldOffset(Offset = "0x68")]
	public HudElementsState hudElementsState;

	[Token(Token = "0x4008AF2")]
	[FieldOffset(Offset = "0x6C")]
	public bool hideReticle;

	[SerializeField]
	[Token(Token = "0x4008AF3")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x170009AA")]
	protected override string info
	{
		[Token(Token = "0x6007806")]
		[Address(RVA = "0x11689E0", Offset = "0x11677E0", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007807")]
	[Address(RVA = "0x1168A40", Offset = "0x1167840", Length = "0x8F")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007808")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_HudElements()
	{
	}
}

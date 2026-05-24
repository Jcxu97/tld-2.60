using Cpp2ILInjected;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

[Token(Token = "0x20011E4")]
public class Action_SetInteractiveLightsourceState : ActionTask
{
	[Token(Token = "0x4008943")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> interactiveLightsourceMissionId;

	[Token(Token = "0x4008944")]
	[FieldOffset(Offset = "0x70")]
	public bool m_TurnOn;

	[Token(Token = "0x1700096B")]
	protected override string info
	{
		[Token(Token = "0x6007686")]
		[Address(RVA = "0x11495F0", Offset = "0x11483F0", Length = "0x6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007687")]
	[Address(RVA = "0x1149660", Offset = "0x1148460", Length = "0x15D")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007688")]
	[Address(RVA = "0x11497C0", Offset = "0x11485C0", Length = "0x151")]
	private void SetLightsourceState()
	{
	}

	[Token(Token = "0x6007689")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetInteractiveLightsourceState()
	{
	}
}

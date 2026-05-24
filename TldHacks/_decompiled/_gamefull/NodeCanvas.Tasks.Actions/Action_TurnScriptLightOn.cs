using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Turn Script Light On", 0)]
[Description("Turns lights on.")]
[Category("TLD Actions/Light")]
[Token(Token = "0x20011E2")]
public class Action_TurnScriptLightOn : ActionTask
{
	[Token(Token = "0x400893E")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> scriptLightMissionId;

	[Token(Token = "0x17000969")]
	protected override string info
	{
		[Token(Token = "0x600767C")]
		[Address(RVA = "0x1148CD0", Offset = "0x1147AD0", Length = "0x84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600767D")]
	[Address(RVA = "0x1148D60", Offset = "0x1147B60", Length = "0x155")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600767E")]
	[Address(RVA = "0x1148EC0", Offset = "0x1147CC0", Length = "0x13F")]
	private void TurnScriptLightOn()
	{
	}

	[Token(Token = "0x600767F")]
	[Address(RVA = "0x1149000", Offset = "0x1147E00", Length = "0x1F0")]
	public static ScriptLight GetScriptLight(string moi)
	{
		return null;
	}

	[Token(Token = "0x6007680")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_TurnScriptLightOn()
	{
	}
}

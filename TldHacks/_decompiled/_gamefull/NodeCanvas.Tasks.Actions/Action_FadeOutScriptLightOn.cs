using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Fade Out Script Light", 0)]
[Description("Turns lights on.")]
[Category("TLD Actions/Light")]
[Token(Token = "0x20011E3")]
public class Action_FadeOutScriptLightOn : ActionTask
{
	[Token(Token = "0x400893F")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> scriptLightMissionId;

	[Token(Token = "0x4008940")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> fadeoutDurationSeconds;

	[Token(Token = "0x4008941")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> waitForComplete;

	[Token(Token = "0x4008942")]
	[FieldOffset(Offset = "0x80")]
	private ScriptLight m_ScriptLight;

	[Token(Token = "0x1700096A")]
	protected override string info
	{
		[Token(Token = "0x6007681")]
		[Address(RVA = "0x1149200", Offset = "0x1148000", Length = "0x6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007682")]
	[Address(RVA = "0x1149270", Offset = "0x1148070", Length = "0x6A")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007683")]
	[Address(RVA = "0x11492E0", Offset = "0x11480E0", Length = "0x1D0")]
	private void StartScriptLightFadeOut()
	{
	}

	[Token(Token = "0x6007684")]
	[Address(RVA = "0x11494C0", Offset = "0x11482C0", Length = "0x124")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007685")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_FadeOutScriptLightOn()
	{
	}
}

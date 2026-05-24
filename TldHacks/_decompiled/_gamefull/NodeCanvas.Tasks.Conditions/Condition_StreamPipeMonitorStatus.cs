using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Name("Steam Pipe Monitor Status", 0)]
[Token(Token = "0x2001129")]
public class Condition_StreamPipeMonitorStatus : ConditionTask
{
	[Token(Token = "0x400877E")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> checkForMissionObjectId;

	[Token(Token = "0x400877F")]
	[FieldOffset(Offset = "0x70")]
	public float flowValueThreshold;

	[Token(Token = "0x4008780")]
	[FieldOffset(Offset = "0x78")]
	public string sceneValidation;

	[Token(Token = "0x4008781")]
	[FieldOffset(Offset = "0x80")]
	private SteamPipe m_SteamPipe;

	[Token(Token = "0x4008782")]
	[FieldOffset(Offset = "0x88")]
	private bool m_LogValidationError;

	[Token(Token = "0x6007400")]
	[Address(RVA = "0x10F6FC0", Offset = "0x10F5DC0", Length = "0x122")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6007401")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void LogValidationError(string message)
	{
	}

	[Token(Token = "0x6007402")]
	[Address(RVA = "0x10F70F0", Offset = "0x10F5EF0", Length = "0x2CD")]
	private void InitializeSteamPipe()
	{
	}

	[Token(Token = "0x6007403")]
	[Address(RVA = "0x10F73C0", Offset = "0x10F61C0", Length = "0xFA")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007404")]
	[Address(RVA = "0x10F74C0", Offset = "0x10F62C0", Length = "0x192")]
	public Condition_StreamPipeMonitorStatus()
	{
	}
}

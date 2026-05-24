using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Utility")]
[Description("Display a UI label on the agent's position if seconds to run is not 0 and also logs the message")]
[Token(Token = "0x2001301")]
public class DebugLogText : ActionTask<Transform>
{
	[Token(Token = "0x2001302")]
	public enum LogMode
	{
		[Token(Token = "0x4008CB3")]
		Log,
		[Token(Token = "0x4008CB4")]
		Warning,
		[Token(Token = "0x4008CB5")]
		Error
	}

	[Token(Token = "0x2001303")]
	public enum VerboseMode
	{
		[Token(Token = "0x4008CB7")]
		LogAndDisplayLabel,
		[Token(Token = "0x4008CB8")]
		LogOnly,
		[Token(Token = "0x4008CB9")]
		DisplayLabelOnly
	}

	[RequiredField]
	[Token(Token = "0x4008CAB")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> log;

	[Token(Token = "0x4008CAC")]
	[FieldOffset(Offset = "0x70")]
	public float labelYOffset;

	[Token(Token = "0x4008CAD")]
	[FieldOffset(Offset = "0x74")]
	public float secondsToRun;

	[Token(Token = "0x4008CAE")]
	[FieldOffset(Offset = "0x78")]
	public VerboseMode verboseMode;

	[Token(Token = "0x4008CAF")]
	[FieldOffset(Offset = "0x7C")]
	public LogMode logMode;

	[Token(Token = "0x4008CB0")]
	[FieldOffset(Offset = "0x80")]
	public CompactStatus finishStatus;

	[Token(Token = "0x4008CB1")]
	[FieldOffset(Offset = "0x88")]
	private Texture2D _tex;

	[Token(Token = "0x17000A21")]
	protected override string info
	{
		[Token(Token = "0x6007A0E")]
		[Address(RVA = "0x118CD50", Offset = "0x118BB50", Length = "0xE2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A22")]
	private Texture2D tex
	{
		[Token(Token = "0x6007A11")]
		[Address(RVA = "0x118D160", Offset = "0x118BF60", Length = "0x198")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A0F")]
	[Address(RVA = "0x118CE40", Offset = "0x118BC40", Length = "0x2DD")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007A10")]
	[Address(RVA = "0x118D120", Offset = "0x118BF20", Length = "0x36")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007A12")]
	[Address(RVA = "0x118D300", Offset = "0x118C100", Length = "0x77C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6007A13")]
	[Address(RVA = "0x118DA80", Offset = "0x118C880", Length = "0xC8")]
	public DebugLogText()
	{
	}
}

using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Start Timer", 0)]
[Category("TLD Actions")]
[Token(Token = "0x2001237")]
public class Action_StartTimer : ActionTask
{
	[Token(Token = "0x4008A54")]
	[FieldOffset(Offset = "0x68")]
	public string id;

	[Token(Token = "0x4008A55")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> bbID;

	[Token(Token = "0x4008A56")]
	[FieldOffset(Offset = "0x78")]
	public bool isRealtime;

	[Token(Token = "0x4008A57")]
	[FieldOffset(Offset = "0x79")]
	public bool isCountdown;

	[Token(Token = "0x4008A58")]
	[FieldOffset(Offset = "0x7A")]
	public bool showOnHUD;

	[Token(Token = "0x4008A59")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> durationHrs;

	[Token(Token = "0x4008A5A")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<string> eventOnExpire;

	[Token(Token = "0x4008A5B")]
	[FieldOffset(Offset = "0x90")]
	public bool removeOnExpire;

	[Token(Token = "0x4008A5C")]
	[FieldOffset(Offset = "0x91")]
	public bool scopeToState;

	[Token(Token = "0x4008A5D")]
	[FieldOffset(Offset = "0x92")]
	public bool accountsLoadingTime;

	[Token(Token = "0x17000988")]
	private string realId
	{
		[Token(Token = "0x600776F")]
		[Address(RVA = "0x115CBF0", Offset = "0x115B9F0", Length = "0x73")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007770")]
		[Address(RVA = "0x115CC70", Offset = "0x115BA70", Length = "0x128")]
		set
		{
		}
	}

	[Token(Token = "0x17000989")]
	protected override string info
	{
		[Token(Token = "0x6007771")]
		[Address(RVA = "0x115CDA0", Offset = "0x115BBA0", Length = "0xA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007772")]
	[Address(RVA = "0x115CE40", Offset = "0x115BC40", Length = "0x207")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007773")]
	[Address(RVA = "0x115D050", Offset = "0x115BE50", Length = "0x9C")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x6007774")]
	[Address(RVA = "0x115D0F0", Offset = "0x115BEF0", Length = "0x217")]
	public Action_StartTimer()
	{
	}
}

using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Show HUD Message", 0)]
[Category("TLD Mission UI")]
[Token(Token = "0x200124C")]
public class Action_ShowHUDMessage : ActionTask
{
	[Token(Token = "0x200124D")]
	public enum MessageShowType
	{
		[Token(Token = "0x4008A95")]
		Normal,
		[Token(Token = "0x4008A96")]
		IgnoreOverlay,
		[Token(Token = "0x4008A97")]
		FadeIn
	}

	[Token(Token = "0x4008A90")]
	[FieldOffset(Offset = "0x68")]
	public bool HighPriority;

	[Token(Token = "0x4008A91")]
	[FieldOffset(Offset = "0x6C")]
	public float FadeInSeconds;

	[Token(Token = "0x4008A92")]
	[FieldOffset(Offset = "0x70")]
	public MessageShowType MessageType;

	[Token(Token = "0x4008A93")]
	[FieldOffset(Offset = "0x78")]
	public string StringKey;

	[Token(Token = "0x17000994")]
	protected override string info
	{
		[Token(Token = "0x60077AE")]
		[Address(RVA = "0x1160FC0", Offset = "0x115FDC0", Length = "0x12A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077AD")]
	[Address(RVA = "0x1160E50", Offset = "0x115FC50", Length = "0x160")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077AF")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ShowHUDMessage()
	{
	}
}

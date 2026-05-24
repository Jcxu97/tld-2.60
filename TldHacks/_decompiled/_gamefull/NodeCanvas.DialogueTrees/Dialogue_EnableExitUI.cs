using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Name("Enable Exit UI", 0)]
[Description("Enabled/Disable Exit UI. (Override)")]
[Token(Token = "0x20010DC")]
public class Dialogue_EnableExitUI : DTNode
{
	[Token(Token = "0x400869B")]
	[FieldOffset(Offset = "0x88")]
	public bool enableExitUI;

	[Token(Token = "0x1700087C")]
	public override string name
	{
		[Token(Token = "0x600727F")]
		[Address(RVA = "0x10E0950", Offset = "0x10DF750", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007280")]
	[Address(RVA = "0x10E09B0", Offset = "0x10DF7B0", Length = "0x185")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x6007281")]
	[Address(RVA = "0x10E0B40", Offset = "0x10DF940", Length = "0x7")]
	public Dialogue_EnableExitUI()
	{
	}
}

using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Block Non Critical Voice Over", 0)]
[Description("Block all non-critical voice over triggers for a specific amount of time. This does NOT cause the script to wait.")]
[Category("TLD Actions/Audio")]
[Token(Token = "0x20011C2")]
public class Action_BlockNonCriticalVoiceOver : ActionTask
{
	[Range(0f, 60f)]
	[Token(Token = "0x40088E9")]
	[FieldOffset(Offset = "0x68")]
	public float duration;

	[Token(Token = "0x1700095F")]
	protected override string info
	{
		[Token(Token = "0x6007621")]
		[Address(RVA = "0x1118730", Offset = "0x1117530", Length = "0x7D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007622")]
	[Address(RVA = "0x11187B0", Offset = "0x11175B0", Length = "0x1C9")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007623")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_BlockNonCriticalVoiceOver()
	{
	}
}

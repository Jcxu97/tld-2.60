using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Visibility", 0)]
[Category("GameObject")]
[Token(Token = "0x20012CF")]
public class SetObjectActive : ActionTask<Transform>
{
	[Token(Token = "0x20012D0")]
	public enum SetActiveMode
	{
		[Token(Token = "0x4008BEA")]
		Deactivate,
		[Token(Token = "0x4008BEB")]
		Activate,
		[Token(Token = "0x4008BEC")]
		Toggle
	}

	[Token(Token = "0x4008BE8")]
	[FieldOffset(Offset = "0x68")]
	public SetActiveMode setTo;

	[Token(Token = "0x170009F6")]
	protected override string info
	{
		[Token(Token = "0x6007940")]
		[Address(RVA = "0x1178730", Offset = "0x1177530", Length = "0xF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007941")]
	[Address(RVA = "0x1178830", Offset = "0x1177630", Length = "0x139")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007942")]
	[Address(RVA = "0x1178970", Offset = "0x1177770", Length = "0x52")]
	public SetObjectActive()
	{
	}
}

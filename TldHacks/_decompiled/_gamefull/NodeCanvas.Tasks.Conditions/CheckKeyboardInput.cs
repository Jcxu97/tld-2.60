using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("Input")]
[Token(Token = "0x200117E")]
public class CheckKeyboardInput : ConditionTask
{
	[Token(Token = "0x4008831")]
	[FieldOffset(Offset = "0x68")]
	public PressTypes pressType;

	[Token(Token = "0x4008832")]
	[FieldOffset(Offset = "0x6C")]
	public KeyCode key;

	[Token(Token = "0x1700092A")]
	protected override string info
	{
		[Token(Token = "0x6007508")]
		[Address(RVA = "0x1109170", Offset = "0x1107F70", Length = "0xC2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007509")]
	[Address(RVA = "0x1109240", Offset = "0x1108040", Length = "0xBD")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600750A")]
	[Address(RVA = "0x1109300", Offset = "0x1108100", Length = "0xF")]
	public CheckKeyboardInput()
	{
	}
}

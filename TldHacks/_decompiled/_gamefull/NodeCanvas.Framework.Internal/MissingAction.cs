using Cpp2ILInjected;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Framework.Internal;

[DoNotList]
[Description("Please resolve the MissingTask issue by either replacing the task or importing the missing task type in the project")]
[Token(Token = "0x20010B2")]
public class MissingAction : ActionTask, IMissingRecoverable
{
	[SerializeField]
	[Token(Token = "0x4008630")]
	[FieldOffset(Offset = "0x68")]
	private string _missingType;

	[SerializeField]
	[Token(Token = "0x4008631")]
	[FieldOffset(Offset = "0x70")]
	private string _recoveryState;

	[Token(Token = "0x1700082A")]
	string IMissingRecoverable.missingType
	{
		[Token(Token = "0x6007140")]
		[Address(RVA = "0x65D9D0", Offset = "0x65C7D0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007141")]
		[Address(RVA = "0x8F4DB0", Offset = "0x8F3BB0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x1700082B")]
	string IMissingRecoverable.recoveryState
	{
		[Token(Token = "0x6007142")]
		[Address(RVA = "0x502690", Offset = "0x501490", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007143")]
		[Address(RVA = "0x5026A0", Offset = "0x5014A0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x1700082C")]
	protected override string info
	{
		[Token(Token = "0x6007144")]
		[Address(RVA = "0x10D1480", Offset = "0x10D0280", Length = "0x11E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007145")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public MissingAction()
	{
	}
}

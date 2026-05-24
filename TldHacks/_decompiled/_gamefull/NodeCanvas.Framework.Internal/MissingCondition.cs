using Cpp2ILInjected;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Framework.Internal;

[DoNotList]
[Description("Please resolve the MissingTask issue by either replacing the task or importing the missing task type in the project")]
[Token(Token = "0x20010B3")]
public class MissingCondition : ConditionTask, IMissingRecoverable
{
	[SerializeField]
	[Token(Token = "0x4008632")]
	[FieldOffset(Offset = "0x68")]
	private string _missingType;

	[SerializeField]
	[Token(Token = "0x4008633")]
	[FieldOffset(Offset = "0x70")]
	private string _recoveryState;

	[Token(Token = "0x1700082D")]
	string IMissingRecoverable.missingType
	{
		[Token(Token = "0x6007146")]
		[Address(RVA = "0x65D9D0", Offset = "0x65C7D0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007147")]
		[Address(RVA = "0x8F4DB0", Offset = "0x8F3BB0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x1700082E")]
	string IMissingRecoverable.recoveryState
	{
		[Token(Token = "0x6007148")]
		[Address(RVA = "0x502690", Offset = "0x501490", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007149")]
		[Address(RVA = "0x5026A0", Offset = "0x5014A0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x1700082F")]
	protected override string info
	{
		[Token(Token = "0x600714A")]
		[Address(RVA = "0x10D15A0", Offset = "0x10D03A0", Length = "0x11E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600714B")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public MissingCondition()
	{
	}
}

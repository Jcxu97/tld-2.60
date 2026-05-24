using Cpp2ILInjected;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Framework.Internal;

[DoNotList]
[Token(Token = "0x200108F")]
public sealed class MissingConnection : Connection, IMissingRecoverable
{
	[SerializeField]
	[Token(Token = "0x40085E8")]
	[FieldOffset(Offset = "0x28")]
	private string _missingType;

	[SerializeField]
	[Token(Token = "0x40085E9")]
	[FieldOffset(Offset = "0x30")]
	private string _recoveryState;

	[Token(Token = "0x1700081F")]
	string IMissingRecoverable.missingType
	{
		[Token(Token = "0x60070AB")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60070AC")]
		[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000820")]
	string IMissingRecoverable.recoveryState
	{
		[Token(Token = "0x60070AD")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60070AE")]
		[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x60070AF")]
	[Address(RVA = "0x10AED30", Offset = "0x10ADB30", Length = "0x8")]
	public MissingConnection()
	{
	}
}

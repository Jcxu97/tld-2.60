using Cpp2ILInjected;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Framework.Internal;

[Token(Token = "0x20010BB")]
public class MissingVariableType : Variable<object>, IMissingRecoverable
{
	[SerializeField]
	[Token(Token = "0x400863E")]
	[FieldOffset(Offset = "0x58")]
	private string _missingType;

	[SerializeField]
	[Token(Token = "0x400863F")]
	[FieldOffset(Offset = "0x60")]
	private string _recoveryState;

	[Token(Token = "0x17000839")]
	public string missingType
	{
		[Token(Token = "0x600717A")]
		[Address(RVA = "0x6BCD40", Offset = "0x6BBB40", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600717B")]
		[Address(RVA = "0x95D320", Offset = "0x95C120", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x1700083A")]
	public string recoveryState
	{
		[Token(Token = "0x600717C")]
		[Address(RVA = "0x6E2FE0", Offset = "0x6E1DE0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600717D")]
		[Address(RVA = "0x8F4D50", Offset = "0x8F3B50", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x600717E")]
	[Address(RVA = "0x10D3C30", Offset = "0x10D2A30", Length = "0x2A")]
	public MissingVariableType()
	{
	}
}

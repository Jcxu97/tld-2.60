using Cpp2ILInjected;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Framework.Internal;

[Token(Token = "0x20010BA")]
public class MissingBBParameterType : BBParameter<object>, IMissingRecoverable
{
	[SerializeField]
	[Token(Token = "0x400863C")]
	[FieldOffset(Offset = "0x48")]
	private string _missingType;

	[SerializeField]
	[Token(Token = "0x400863D")]
	[FieldOffset(Offset = "0x50")]
	private string _recoveryState;

	[Token(Token = "0x17000837")]
	string IMissingRecoverable.missingType
	{
		[Token(Token = "0x6007175")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007176")]
		[Address(RVA = "0x4D0B60", Offset = "0x4CF960", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000838")]
	string IMissingRecoverable.recoveryState
	{
		[Token(Token = "0x6007177")]
		[Address(RVA = "0x669640", Offset = "0x668440", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007178")]
		[Address(RVA = "0x6339B0", Offset = "0x6327B0", Length = "0xED7")]
		set
		{
		}
	}

	[Token(Token = "0x6007179")]
	[Address(RVA = "0x10D3BC0", Offset = "0x10D29C0", Length = "0x64")]
	public MissingBBParameterType()
	{
	}
}

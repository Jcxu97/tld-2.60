using System;
using Cpp2ILInjected;
using ParadoxNotion.Serialization.FullSerializer;

namespace ParadoxNotion.Serialization;

[Token(Token = "0x2000D7D")]
public class fsRecoveryProcessor<TCanProcess, TMissing> : fsObjectProcessor where TMissing : TCanProcess, IMissingRecoverable
{
	[Token(Token = "0x4008407")]
	private const string FIELD_NAME_TYPE = "_missingType";

	[Token(Token = "0x4008408")]
	private const string FIELD_NAME_STATE = "_recoveryState";

	[Token(Token = "0x6006951")]
	[Address(RVA = "0x22FDFB0", Offset = "0x22FCDB0", Length = "0xC7")]
	public override bool CanProcess(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006952")]
	[Address(RVA = "0x22FE080", Offset = "0x22FCE80", Length = "0x8CB")]
	public override void OnBeforeDeserialize(Type storageType, ref fsData data)
	{
	}

	[Token(Token = "0x6006953")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public override void OnAfterDeserialize(Type storageType, object instance)
	{
	}

	[Token(Token = "0x6006954")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public fsRecoveryProcessor()
	{
	}
}

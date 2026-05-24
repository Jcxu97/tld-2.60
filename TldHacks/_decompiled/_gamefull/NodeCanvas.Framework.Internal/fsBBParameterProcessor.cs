using System;
using Cpp2ILInjected;
using ParadoxNotion.Serialization;
using ParadoxNotion.Serialization.FullSerializer;

namespace NodeCanvas.Framework.Internal;

[Token(Token = "0x20010B9")]
public class fsBBParameterProcessor : fsRecoveryProcessor<BBParameter, MissingBBParameterType>
{
	[Token(Token = "0x6007173")]
	[Address(RVA = "0x10D3820", Offset = "0x10D2620", Length = "0x36E")]
	public override void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data)
	{
	}

	[Token(Token = "0x6007174")]
	[Address(RVA = "0x10D3B90", Offset = "0x10D2990", Length = "0x2A")]
	public fsBBParameterProcessor()
	{
	}
}

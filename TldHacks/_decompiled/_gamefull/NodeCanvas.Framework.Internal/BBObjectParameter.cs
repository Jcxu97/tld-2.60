using System;
using Cpp2ILInjected;
using UnityEngine;

namespace NodeCanvas.Framework.Internal;

[Serializable]
[Token(Token = "0x20010B5")]
public class BBObjectParameter : BBParameter<object>
{
	[SerializeField]
	[Token(Token = "0x4008634")]
	[FieldOffset(Offset = "0x48")]
	private Type _type;

	[Token(Token = "0x17000832")]
	public override Type varType
	{
		[Token(Token = "0x6007151")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007152")]
	[Address(RVA = "0x10D1960", Offset = "0x10D0760", Length = "0xCD")]
	public BBObjectParameter()
	{
	}

	[Token(Token = "0x6007153")]
	[Address(RVA = "0x10D1A30", Offset = "0x10D0830", Length = "0x7F")]
	public BBObjectParameter(Type t)
	{
	}

	[Token(Token = "0x6007154")]
	[Address(RVA = "0x10D1AB0", Offset = "0x10D08B0", Length = "0x1E7")]
	public void SetType(Type t)
	{
	}
}

using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer;

[Token(Token = "0x2000D93")]
public abstract class fsConverter : fsBaseConverter
{
	[Token(Token = "0x60069C0")]
	public abstract bool CanProcess(Type type);

	[Token(Token = "0x60069C1")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected fsConverter()
	{
	}
}

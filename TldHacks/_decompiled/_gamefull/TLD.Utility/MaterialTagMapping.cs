using System;
using Cpp2ILInjected;

namespace TLD.Utility;

[Serializable]
[Token(Token = "0x2001349")]
public struct MaterialTagMapping<T>
{
	[Token(Token = "0x4008E2A")]
	[FieldOffset(Offset = "0x0")]
	public string m_Tag;

	[Token(Token = "0x4008E2B")]
	[FieldOffset(Offset = "0x0")]
	public T m_Value;
}

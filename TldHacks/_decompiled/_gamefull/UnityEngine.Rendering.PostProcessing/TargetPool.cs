using System.Collections.Generic;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000D00")]
internal class TargetPool
{
	[Token(Token = "0x4008104")]
	[FieldOffset(Offset = "0x10")]
	private readonly List<int> m_Pool;

	[Token(Token = "0x4008105")]
	[FieldOffset(Offset = "0x18")]
	private int m_Current;

	[Token(Token = "0x60066E8")]
	[Address(RVA = "0x1033EC0", Offset = "0x1032CC0", Length = "0xBE")]
	internal TargetPool()
	{
	}

	[Token(Token = "0x60066E9")]
	[Address(RVA = "0x1033F80", Offset = "0x1032D80", Length = "0x1D")]
	internal int Get()
	{
		return 0;
	}

	[Token(Token = "0x60066EA")]
	[Address(RVA = "0x1033FA0", Offset = "0x1032DA0", Length = "0x1EB")]
	private int Get(int i)
	{
		return 0;
	}

	[Token(Token = "0x60066EB")]
	[Address(RVA = "0xD2C520", Offset = "0xD2B320", Length = "0x8")]
	internal void Reset()
	{
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000A01")]
public static class EnumExtensions
{
	[Token(Token = "0x2000A02")]
	public struct EnumFlagIterator<T> : IEnumerator<T>, IEnumerator, IDisposable, IEnumerable<T>, IEnumerable where T : Enum
	{
		[Token(Token = "0x400659F")]
		[FieldOffset(Offset = "0x0")]
		private T m_EnumFlag;

		[Token(Token = "0x40065A0")]
		[FieldOffset(Offset = "0x0")]
		private T[] m_EnumArray;

		[Token(Token = "0x40065A1")]
		[FieldOffset(Offset = "0x0")]
		private int m_Index;

		[Token(Token = "0x17000390")]
		public object Current
		{
			[Token(Token = "0x600582D")]
			[Address(RVA = "0x2716D70", Offset = "0x2715B70", Length = "0x59")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000391")]
		T IEnumerator<T>.Current
		{
			[Token(Token = "0x600582E")]
			[Address(RVA = "0x2716DD0", Offset = "0x2715BD0", Length = "0x2A")]
			get
			{
				return default(T);
			}
		}

		[Token(Token = "0x600582A")]
		[Address(RVA = "0x2716AD0", Offset = "0x27158D0", Length = "0x244")]
		public EnumFlagIterator(T enumFlag)
		{
			m_EnumFlag = default(T);
			m_EnumArray = null;
			m_Index = 0;
		}

		[Token(Token = "0x600582B")]
		[Address(RVA = "0x2716D20", Offset = "0x2715B20", Length = "0x46")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600582C")]
		[Address(RVA = "0x2716D20", Offset = "0x2715B20", Length = "0x46")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600582F")]
		[Address(RVA = "0x2716E00", Offset = "0x2715C00", Length = "0x52")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005830")]
		[Address(RVA = "0x2716E60", Offset = "0x2715C60", Length = "0x105")]
		public bool MoveNext()
		{
			return false;
		}

		[Token(Token = "0x6005831")]
		[Address(RVA = "0x8CFCF0", Offset = "0x8CEAF0", Length = "0x8")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x6005827")]
	[Address(RVA = "0x18BBB20", Offset = "0x18BA920", Length = "0x1E1")]
	public static bool HasFlag<T>(this T var, T flags) where T : struct, IConvertible
	{
		return false;
	}

	[Token(Token = "0x6005828")]
	[Address(RVA = "0x18BB7D0", Offset = "0x18BA5D0", Length = "0x16B")]
	public static bool HasAnyFlag<T>(this T var, T flags) where T : struct, IConvertible
	{
		return false;
	}

	[Token(Token = "0x6005829")]
	[Address(RVA = "0x18BB630", Offset = "0x18BA430", Length = "0x74")]
	public static IEnumerable<T> GetFlags<T>(this T enumFlag) where T : Enum
	{
		return null;
	}
}

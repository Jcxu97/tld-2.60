using Cpp2ILInjected;

namespace TLD.Collections.Generic;

[Token(Token = "0x2001344")]
public class RingBuffer<T>
{
	[Token(Token = "0x4008E13")]
	[FieldOffset(Offset = "0x0")]
	private readonly T[] m_Entries;

	[Token(Token = "0x4008E14")]
	[FieldOffset(Offset = "0x0")]
	private int m_Count;

	[Token(Token = "0x4008E15")]
	[FieldOffset(Offset = "0x0")]
	private int m_Start;

	[Token(Token = "0x17000A4C")]
	public int Count
	{
		[Token(Token = "0x6007B68")]
		[Address(RVA = "0x40E0D0", Offset = "0x40CED0", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000A4D")]
	public int Capacity
	{
		[Token(Token = "0x6007B69")]
		[Address(RVA = "0x7494C0", Offset = "0x7482C0", Length = "0x1A")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000A4E")]
	public T this[int index]
	{
		[Token(Token = "0x6007B6A")]
		[Address(RVA = "0x1FCB910", Offset = "0x1FCA710", Length = "0xF9")]
		get
		{
			return default(T);
		}
	}

	[Token(Token = "0x6007B67")]
	[Address(RVA = "0x1FCB820", Offset = "0x1FCA620", Length = "0xE8")]
	public RingBuffer(int capacity)
	{
	}

	[Token(Token = "0x6007B6B")]
	[Address(RVA = "0x1FCBA10", Offset = "0x1FCA810", Length = "0x26E")]
	public void Add(T item)
	{
	}
}

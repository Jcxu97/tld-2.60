using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer;

[Token(Token = "0x2000D9E")]
public struct fsResult
{
	[Token(Token = "0x400844D")]
	private static readonly string[] EmptyStringArray;

	[Token(Token = "0x400844E")]
	[FieldOffset(Offset = "0x0")]
	private bool _success;

	[Token(Token = "0x400844F")]
	[FieldOffset(Offset = "0x8")]
	private List<string> _messages;

	[Token(Token = "0x4008450")]
	public static fsResult Success;

	[Token(Token = "0x17000746")]
	public bool Failed
	{
		[Token(Token = "0x6006A1E")]
		[Address(RVA = "0x10800C0", Offset = "0x107EEC0", Length = "0x7")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000747")]
	public bool Succeeded
	{
		[Token(Token = "0x6006A1F")]
		[Address(RVA = "0x10800D0", Offset = "0x107EED0", Length = "0x4")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000748")]
	public bool HasWarnings
	{
		[Token(Token = "0x6006A20")]
		[Address(RVA = "0x10800E0", Offset = "0x107EEE0", Length = "0x4C")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000749")]
	public Exception AsException
	{
		[Token(Token = "0x6006A23")]
		[Address(RVA = "0x10802B0", Offset = "0x107F0B0", Length = "0x132")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700074A")]
	public IEnumerable<string> RawMessages
	{
		[Token(Token = "0x6006A24")]
		[Address(RVA = "0x10803F0", Offset = "0x107F1F0", Length = "0x62")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700074B")]
	public string FormattedMessages
	{
		[Token(Token = "0x6006A25")]
		[Address(RVA = "0x1080460", Offset = "0x107F260", Length = "0x1D3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006A18")]
	[Address(RVA = "0x107FA10", Offset = "0x107E810", Length = "0x139")]
	public static fsResult Warn(string warning)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006A19")]
	[Address(RVA = "0x107FB50", Offset = "0x107E950", Length = "0x12A")]
	public static fsResult Fail(string warning)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006A1A")]
	[Address(RVA = "0x107FC80", Offset = "0x107EA80", Length = "0x133")]
	public void AddMessage(string message)
	{
	}

	[Token(Token = "0x6006A1B")]
	[Address(RVA = "0x107FDC0", Offset = "0x107EBC0", Length = "0x113")]
	public void AddMessages(fsResult result)
	{
	}

	[Token(Token = "0x6006A1C")]
	[Address(RVA = "0x107FEE0", Offset = "0x107ECE0", Length = "0x146")]
	private fsResult Merge(fsResult other)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006A1D")]
	[Address(RVA = "0x1080030", Offset = "0x107EE30", Length = "0x84")]
	public static fsResult operator +(fsResult a, fsResult b)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006A21")]
	[Address(RVA = "0x1080130", Offset = "0x107EF30", Length = "0x97")]
	public fsResult AssertSuccess()
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006A22")]
	[Address(RVA = "0x10801D0", Offset = "0x107EFD0", Length = "0xDA")]
	public fsResult AssertSuccessWithoutWarnings()
	{
		return default(fsResult);
	}
}

using System.Collections.Generic;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer;

[Token(Token = "0x2000D95")]
public sealed class fsData
{
	[Token(Token = "0x4008443")]
	[FieldOffset(Offset = "0x10")]
	private object _value;

	[Token(Token = "0x4008444")]
	public static readonly fsData True;

	[Token(Token = "0x4008445")]
	public static readonly fsData False;

	[Token(Token = "0x4008446")]
	public static readonly fsData Null;

	[Token(Token = "0x17000736")]
	public fsDataType Type
	{
		[Token(Token = "0x60069C2")]
		[Address(RVA = "0x1079090", Offset = "0x1077E90", Length = "0x18D")]
		get
		{
			return default(fsDataType);
		}
	}

	[Token(Token = "0x17000737")]
	public bool IsNull
	{
		[Token(Token = "0x60069CF")]
		[Address(RVA = "0x1079900", Offset = "0x1078700", Length = "0x9")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000738")]
	public bool IsDouble
	{
		[Token(Token = "0x60069D0")]
		[Address(RVA = "0x1079910", Offset = "0x1078710", Length = "0x20")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000739")]
	public bool IsInt64
	{
		[Token(Token = "0x60069D1")]
		[Address(RVA = "0x1079930", Offset = "0x1078730", Length = "0x20")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700073A")]
	public bool IsBool
	{
		[Token(Token = "0x60069D2")]
		[Address(RVA = "0x1079950", Offset = "0x1078750", Length = "0x20")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700073B")]
	public bool IsString
	{
		[Token(Token = "0x60069D3")]
		[Address(RVA = "0x1079970", Offset = "0x1078770", Length = "0x20")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700073C")]
	public bool IsDictionary
	{
		[Token(Token = "0x60069D4")]
		[Address(RVA = "0x1079990", Offset = "0x1078790", Length = "0x83")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700073D")]
	public bool IsList
	{
		[Token(Token = "0x60069D5")]
		[Address(RVA = "0x1079A20", Offset = "0x1078820", Length = "0x83")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700073E")]
	public double AsDouble
	{
		[Token(Token = "0x60069D6")]
		[Address(RVA = "0x1079AB0", Offset = "0x10788B0", Length = "0x3E")]
		get
		{
			return 0.0;
		}
	}

	[Token(Token = "0x1700073F")]
	public long AsInt64
	{
		[Token(Token = "0x60069D7")]
		[Address(RVA = "0x1079AF0", Offset = "0x10788F0", Length = "0x3E")]
		get
		{
			return 0L;
		}
	}

	[Token(Token = "0x17000740")]
	public bool AsBool
	{
		[Token(Token = "0x60069D8")]
		[Address(RVA = "0x1079B30", Offset = "0x1078930", Length = "0x3E")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000741")]
	public string AsString
	{
		[Token(Token = "0x60069D9")]
		[Address(RVA = "0x1079B70", Offset = "0x1078970", Length = "0x3E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000742")]
	public Dictionary<string, fsData> AsDictionary
	{
		[Token(Token = "0x60069DA")]
		[Address(RVA = "0x1079BB0", Offset = "0x10789B0", Length = "0x3E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000743")]
	public List<fsData> AsList
	{
		[Token(Token = "0x60069DB")]
		[Address(RVA = "0x1079BF0", Offset = "0x10789F0", Length = "0x3E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60069C3")]
	[Address(RVA = "0x1079220", Offset = "0x1078020", Length = "0x52")]
	public fsData()
	{
	}

	[Token(Token = "0x60069C4")]
	[Address(RVA = "0x1079280", Offset = "0x1078080", Length = "0x67")]
	public fsData(bool boolean)
	{
	}

	[Token(Token = "0x60069C5")]
	[Address(RVA = "0x10792F0", Offset = "0x10780F0", Length = "0x69")]
	public fsData(double f)
	{
	}

	[Token(Token = "0x60069C6")]
	[Address(RVA = "0x1079360", Offset = "0x1078160", Length = "0x67")]
	public fsData(long i)
	{
	}

	[Token(Token = "0x60069C7")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public fsData(string str)
	{
	}

	[Token(Token = "0x60069C8")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public fsData(Dictionary<string, fsData> dict)
	{
	}

	[Token(Token = "0x60069C9")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public fsData(List<fsData> list)
	{
	}

	[Token(Token = "0x60069CA")]
	[Address(RVA = "0x10793D0", Offset = "0x10781D0", Length = "0x13F")]
	public static fsData CreateDictionary()
	{
		return null;
	}

	[Token(Token = "0x60069CB")]
	[Address(RVA = "0x1079510", Offset = "0x1078310", Length = "0xCA")]
	public static fsData CreateList()
	{
		return null;
	}

	[Token(Token = "0x60069CC")]
	[Address(RVA = "0x10795E0", Offset = "0x10783E0", Length = "0xDF")]
	public static fsData CreateList(int capacity)
	{
		return null;
	}

	[Token(Token = "0x60069CD")]
	[Address(RVA = "0x10796C0", Offset = "0x10784C0", Length = "0x131")]
	internal void BecomeDictionary()
	{
	}

	[Token(Token = "0x60069CE")]
	[Address(RVA = "0x1079800", Offset = "0x1078600", Length = "0xF2")]
	internal fsData Clone()
	{
		return null;
	}

	[Token(Token = "0x60069DC")]
	[Address(RVA = "0x1A607D0", Offset = "0x1A5F5D0", Length = "0x26E")]
	private T Cast<T>()
	{
		return default(T);
	}

	[Token(Token = "0x60069DD")]
	[Address(RVA = "0x1079C30", Offset = "0x1078A30", Length = "0x7")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60069DE")]
	[Address(RVA = "0x1079C40", Offset = "0x1078A40", Length = "0x5B")]
	public override bool Equals(object obj)
	{
		return false;
	}

	[Token(Token = "0x60069DF")]
	[Address(RVA = "0x1079CA0", Offset = "0x1078AA0", Length = "0x5F8")]
	public bool Equals(fsData other)
	{
		return false;
	}

	[Token(Token = "0x60069E0")]
	[Address(RVA = "0x107A2C0", Offset = "0x10790C0", Length = "0x11F")]
	public static bool operator ==(fsData a, fsData b)
	{
		return false;
	}

	[Token(Token = "0x60069E1")]
	[Address(RVA = "0x107A3E0", Offset = "0x10791E0", Length = "0x64")]
	public static bool operator !=(fsData a, fsData b)
	{
		return false;
	}

	[Token(Token = "0x60069E2")]
	[Address(RVA = "0x107A450", Offset = "0x1079250", Length = "0x2A")]
	public override int GetHashCode()
	{
		return 0;
	}
}

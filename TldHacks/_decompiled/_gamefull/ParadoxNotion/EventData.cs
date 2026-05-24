using Cpp2ILInjected;

namespace ParadoxNotion;

[Token(Token = "0x2000D58")]
public class EventData
{
	[Token(Token = "0x17000727")]
	[field: Token(Token = "0x400838E")]
	[field: FieldOffset(Offset = "0x10")]
	public string name
	{
		[Token(Token = "0x600680F")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get;
		[Token(Token = "0x6006810")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000728")]
	public object value
	{
		[Token(Token = "0x6006811")]
		[Address(RVA = "0x105EE30", Offset = "0x105DC30", Length = "0x14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006812")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	protected virtual object GetValue()
	{
		return null;
	}

	[Token(Token = "0x6006813")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public EventData(string name)
	{
	}
}
[Token(Token = "0x2000D59")]
public class EventData<T> : EventData
{
	[Token(Token = "0x17000729")]
	public new T value
	{
		[Token(Token = "0x6006814")]
		[Address(RVA = "0xC880B0", Offset = "0xC86EB0", Length = "0x5")]
		get;
		[Token(Token = "0x6006815")]
		[Address(RVA = "0xF79F70", Offset = "0xF78D70", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x6006816")]
	[Address(RVA = "0x1B347C0", Offset = "0x1B335C0", Length = "0x2A")]
	protected override object GetValue()
	{
		return null;
	}

	[Token(Token = "0x6006817")]
	[Address(RVA = "0x291FD30", Offset = "0x291EB30", Length = "0x5B")]
	public EventData(string name, T value)
		: base(null)
	{
	}
}

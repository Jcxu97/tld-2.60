using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer;

[Token(Token = "0x2000D94")]
public enum fsDataType
{
	[Token(Token = "0x400843C")]
	Array,
	[Token(Token = "0x400843D")]
	Object,
	[Token(Token = "0x400843E")]
	Double,
	[Token(Token = "0x400843F")]
	Int64,
	[Token(Token = "0x4008440")]
	Boolean,
	[Token(Token = "0x4008441")]
	String,
	[Token(Token = "0x4008442")]
	Null
}

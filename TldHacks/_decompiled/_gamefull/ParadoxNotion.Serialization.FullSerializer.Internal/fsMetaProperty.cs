using System;
using System.Reflection;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

[Token(Token = "0x2000DB1")]
public class fsMetaProperty
{
	[Token(Token = "0x4008472")]
	[FieldOffset(Offset = "0x10")]
	private FieldInfo _fieldInfo;

	[Token(Token = "0x1700074E")]
	[field: Token(Token = "0x4008473")]
	[field: FieldOffset(Offset = "0x18")]
	public Type StorageType
	{
		[Token(Token = "0x6006AA3")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get;
		[Token(Token = "0x6006AA4")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x1700074F")]
	[field: Token(Token = "0x4008474")]
	[field: FieldOffset(Offset = "0x20")]
	public string JsonName
	{
		[Token(Token = "0x6006AA5")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get;
		[Token(Token = "0x6006AA6")]
		[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000750")]
	public string MemberName
	{
		[Token(Token = "0x6006AA7")]
		[Address(RVA = "0x108DEB0", Offset = "0x108CCB0", Length = "0x2A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006AA8")]
	[Address(RVA = "0x108DEE0", Offset = "0x108CCE0", Length = "0x1E4")]
	internal fsMetaProperty(fsConfig config, FieldInfo field)
	{
	}

	[Token(Token = "0x6006AA9")]
	[Address(RVA = "0x108E0D0", Offset = "0x108CED0", Length = "0x1E")]
	public void Write(object context, object value)
	{
	}

	[Token(Token = "0x6006AAA")]
	[Address(RVA = "0x108E0F0", Offset = "0x108CEF0", Length = "0x2A")]
	public object Read(object context)
	{
		return null;
	}
}

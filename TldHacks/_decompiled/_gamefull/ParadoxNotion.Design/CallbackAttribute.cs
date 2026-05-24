using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.Field)]
[Token(Token = "0x2000DC9")]
public class CallbackAttribute : DrawerAttribute
{
	[Token(Token = "0x4008481")]
	[FieldOffset(Offset = "0x10")]
	public readonly string methodName;

	[Token(Token = "0x17000754")]
	public override int priority
	{
		[Token(Token = "0x6006AE1")]
		[Address(RVA = "0x901E60", Offset = "0x900C60", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6006AE2")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public CallbackAttribute(string methodName)
	{
	}
}

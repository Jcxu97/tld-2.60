using System;
using Cpp2ILInjected;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
[Token(Token = "0x2000A09")]
public class FolderPathAttribute : PropertyAttribute
{
	[Token(Token = "0x6005838")]
	[Address(RVA = "0x4A6140", Offset = "0x4A4F40", Length = "0x5")]
	public FolderPathAttribute()
	{
	}
}

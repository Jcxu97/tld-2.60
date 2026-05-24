using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Utility;

[AttributeUsage(AttributeTargets.Field)]
[Token(Token = "0x2001346")]
public class EditorReadOnlyAttribute : PropertyAttribute
{
	[Token(Token = "0x6007B6F")]
	[Address(RVA = "0x4A6140", Offset = "0x4A4F40", Length = "0x5")]
	public EditorReadOnlyAttribute()
	{
	}
}

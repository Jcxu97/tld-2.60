using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.UI;

[AttributeUsage(AttributeTargets.Field)]
[Token(Token = "0x2001391")]
public class PanelReferenceSourceAttribute : PropertyAttribute
{
	[Token(Token = "0x6007CFE")]
	[Address(RVA = "0x4A6140", Offset = "0x4A4F40", Length = "0x5")]
	public PanelReferenceSourceAttribute()
	{
	}
}

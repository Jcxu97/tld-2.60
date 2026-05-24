using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Delegate)]
[Token(Token = "0x2000DBB")]
public class SpoofAOTAttribute : Attribute
{
	[Token(Token = "0x6006ACF")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SpoofAOTAttribute()
	{
	}
}

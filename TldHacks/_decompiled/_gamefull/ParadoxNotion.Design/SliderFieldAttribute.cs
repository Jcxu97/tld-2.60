using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Design;

[AttributeUsage(AttributeTargets.Field)]
[Token(Token = "0x2000DD0")]
public class SliderFieldAttribute : DrawerAttribute
{
	[Token(Token = "0x4008485")]
	[FieldOffset(Offset = "0x10")]
	public readonly float min;

	[Token(Token = "0x4008486")]
	[FieldOffset(Offset = "0x14")]
	public readonly float max;

	[Token(Token = "0x6006AEB")]
	[Address(RVA = "0xEEC480", Offset = "0xEEB280", Length = "0xB")]
	public SliderFieldAttribute(float min, float max)
	{
	}

	[Token(Token = "0x6006AEC")]
	[Address(RVA = "0x1094F20", Offset = "0x1093D20", Length = "0x1A")]
	public SliderFieldAttribute(int min, int max)
	{
	}
}

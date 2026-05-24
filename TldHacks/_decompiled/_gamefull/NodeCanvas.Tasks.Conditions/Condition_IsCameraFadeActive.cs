using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Description("Returns true if the Camera Fade is active.")]
[Name("Camera Is Fading", 0)]
[Token(Token = "0x2001153")]
public class Condition_IsCameraFadeActive : ConditionTask
{
	[Token(Token = "0x2001154")]
	public enum FadeOptions
	{
		[Token(Token = "0x40087D5")]
		Any,
		[Token(Token = "0x40087D6")]
		In,
		[Token(Token = "0x40087D7")]
		Out
	}

	[Token(Token = "0x40087D3")]
	[FieldOffset(Offset = "0x68")]
	public FadeOptions FadeType;

	[Token(Token = "0x17000909")]
	protected override string info
	{
		[Token(Token = "0x6007483")]
		[Address(RVA = "0x1100BA0", Offset = "0x10FF9A0", Length = "0x7A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007484")]
	[Address(RVA = "0x1100C20", Offset = "0x10FFA20", Length = "0xA4")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007485")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_IsCameraFadeActive()
	{
	}
}

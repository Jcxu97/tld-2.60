using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Description("Check if a named mission object is currently loaded (i.e. available for lookup).")]
[Name("Object Is Loaded", 0)]
[Token(Token = "0x2001148")]
public class Condition_ObjectIsLoaded : ConditionTask
{
	[Token(Token = "0x40087B6")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> objectName;

	[Token(Token = "0x17000900")]
	protected override string info
	{
		[Token(Token = "0x6007464")]
		[Address(RVA = "0x10FD300", Offset = "0x10FC100", Length = "0x6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007465")]
	[Address(RVA = "0x10FD370", Offset = "0x10FC170", Length = "0x1D9")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007466")]
	[Address(RVA = "0x10FD550", Offset = "0x10FC350", Length = "0x128")]
	public Condition_ObjectIsLoaded()
	{
	}
}

using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Blackboard/Dictionaries")]
[Token(Token = "0x2001171")]
public class TryGetValue<T> : ConditionTask
{
	[RequiredField]
	[BlackboardOnly]
	[Token(Token = "0x400880F")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<Dictionary<string, T>> targetDictionary;

	[RequiredField]
	[Token(Token = "0x4008810")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<string> key;

	[BlackboardOnly]
	[Token(Token = "0x4008811")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> saveValueAs;

	[Token(Token = "0x17000920")]
	protected override string info
	{
		[Token(Token = "0x60074DE")]
		[Address(RVA = "0x20F7E90", Offset = "0x20F6C90", Length = "0x95")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074DF")]
	[Address(RVA = "0x20F7F30", Offset = "0x20F6D30", Length = "0x128")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074E0")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public TryGetValue()
	{
	}
}

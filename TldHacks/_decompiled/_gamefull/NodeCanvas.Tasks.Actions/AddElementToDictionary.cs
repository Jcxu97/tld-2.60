using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard/Dictionaries")]
[Token(Token = "0x2001290")]
public class AddElementToDictionary<T> : ActionTask
{
	[BlackboardOnly]
	[RequiredField]
	[Token(Token = "0x4008B55")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<Dictionary<string, T>> dictionary;

	[Token(Token = "0x4008B56")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<string> key;

	[Token(Token = "0x4008B57")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> value;

	[Token(Token = "0x170009C4")]
	protected override string info
	{
		[Token(Token = "0x600787F")]
		[Address(RVA = "0x250DF60", Offset = "0x250CD60", Length = "0x95")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007880")]
	[Address(RVA = "0x250E000", Offset = "0x250CE00", Length = "0x12C")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007881")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public AddElementToDictionary()
	{
	}
}

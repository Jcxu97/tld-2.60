using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard/Dictionaries")]
[Token(Token = "0x2001291")]
public class GetDictionaryElement<T> : ActionTask
{
	[BlackboardOnly]
	[RequiredField]
	[Token(Token = "0x4008B58")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<Dictionary<string, T>> dictionary;

	[Token(Token = "0x4008B59")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<string> key;

	[BlackboardOnly]
	[Token(Token = "0x4008B5A")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> saveAs;

	[Token(Token = "0x170009C5")]
	protected override string info
	{
		[Token(Token = "0x6007882")]
		[Address(RVA = "0x29544A0", Offset = "0x29532A0", Length = "0x95")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007883")]
	[Address(RVA = "0x2954540", Offset = "0x2953340", Length = "0xFE")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007884")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public GetDictionaryElement()
	{
	}
}

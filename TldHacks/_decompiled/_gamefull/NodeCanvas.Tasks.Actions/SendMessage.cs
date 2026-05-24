using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Script Control/Common")]
[Description("SendMessage to the agent, optionaly with an argument")]
[Token(Token = "0x20012EF")]
public class SendMessage : ActionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008C7F")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> methodName;

	[Token(Token = "0x17000A00")]
	protected override string info
	{
		[Token(Token = "0x600799F")]
		[Address(RVA = "0x1185790", Offset = "0x1184590", Length = "0x84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60079A0")]
	[Address(RVA = "0x1185820", Offset = "0x1184620", Length = "0xE4")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60079A1")]
	[Address(RVA = "0x1185910", Offset = "0x1184710", Length = "0x44")]
	public SendMessage()
	{
	}
}
[Category("✫ Script Control/Common")]
[Description("SendMessage to the agent, optionaly with an argument")]
[Token(Token = "0x20012F0")]
public class SendMessage<T> : ActionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008C80")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<string> methodName;

	[Token(Token = "0x4008C81")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> argument;

	[Token(Token = "0x17000A01")]
	protected override string info
	{
		[Token(Token = "0x60079A2")]
		[Address(RVA = "0x1FDC750", Offset = "0x1FDB550", Length = "0xAB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60079A3")]
	[Address(RVA = "0x1FDC800", Offset = "0x1FDB600", Length = "0x1A4")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60079A4")]
	[Address(RVA = "0x1FDC9B0", Offset = "0x1FDB7B0", Length = "0x44")]
	public SendMessage()
	{
	}
}

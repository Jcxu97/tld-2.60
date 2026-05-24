using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Utility")]
[Description("Send a Graph Event to multiple gameobjects which should have a GraphOwner component attached.")]
[Token(Token = "0x200130C")]
public class SendEventToObjects : ActionTask
{
	[RequiredField]
	[Token(Token = "0x4008CCF")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<List<GameObject>> targetObjects;

	[RequiredField]
	[Token(Token = "0x4008CD0")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> eventName;

	[Token(Token = "0x17000A29")]
	protected override string info
	{
		[Token(Token = "0x6007A2E")]
		[Address(RVA = "0x118ED10", Offset = "0x118DB10", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A2F")]
	[Address(RVA = "0x118EDA0", Offset = "0x118DBA0", Length = "0x372")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007A30")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public SendEventToObjects()
	{
	}
}
[Category("✫ Utility")]
[Description("Send a Graph Event to multiple gameobjects which should have a GraphOwner component attached.")]
[Token(Token = "0x200130D")]
public class SendEventToObjects<T> : ActionTask
{
	[RequiredField]
	[Token(Token = "0x4008CD1")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<List<GameObject>> targetObjects;

	[RequiredField]
	[Token(Token = "0x4008CD2")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<string> eventName;

	[Token(Token = "0x4008CD3")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> eventValue;

	[Token(Token = "0x17000A2A")]
	protected override string info
	{
		[Token(Token = "0x6007A31")]
		[Address(RVA = "0x1FD0C60", Offset = "0x1FCFA60", Length = "0x95")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A32")]
	[Address(RVA = "0x1FD0D00", Offset = "0x1FCFB00", Length = "0x324")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007A33")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public SendEventToObjects()
	{
	}
}

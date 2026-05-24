using System;
using Cpp2ILInjected;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
[Token(Token = "0x200108D")]
public class TaskAgent : BBParameter<UnityEngine.Object>
{
	[Token(Token = "0x1700081D")]
	public new UnityEngine.Object value
	{
		[Token(Token = "0x60070A3")]
		[Address(RVA = "0x10CEF50", Offset = "0x10CDD50", Length = "0x1ED")]
		get
		{
			return null;
		}
		[Token(Token = "0x60070A4")]
		[Address(RVA = "0x4D0B00", Offset = "0x4CF900", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x1700081E")]
	protected override object objectValue
	{
		[Token(Token = "0x60070A5")]
		[Address(RVA = "0x10CF140", Offset = "0x10CDF40", Length = "0x7")]
		get
		{
			return null;
		}
		[Token(Token = "0x60070A6")]
		[Address(RVA = "0x10CF150", Offset = "0x10CDF50", Length = "0xB4")]
		set
		{
		}
	}

	[Token(Token = "0x60070A7")]
	[Address(RVA = "0x10CF210", Offset = "0x10CE010", Length = "0x64")]
	public TaskAgent()
	{
	}
}

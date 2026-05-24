using System;
using Cpp2ILInjected;
using UnityEngine;

namespace NodeCanvas.Framework.Internal;

[Serializable]
[Token(Token = "0x20010B4")]
public class TaskAgentParameter : BBParameter<UnityEngine.Object>
{
	[Token(Token = "0x17000830")]
	public new UnityEngine.Object value
	{
		[Token(Token = "0x600714C")]
		[Address(RVA = "0x10D16C0", Offset = "0x10D04C0", Length = "0x150")]
		get
		{
			return null;
		}
		[Token(Token = "0x600714D")]
		[Address(RVA = "0x4D0B00", Offset = "0x4CF900", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000831")]
	protected override object objectValue
	{
		[Token(Token = "0x600714E")]
		[Address(RVA = "0x10D1820", Offset = "0x10D0620", Length = "0x7")]
		get
		{
			return null;
		}
		[Token(Token = "0x600714F")]
		[Address(RVA = "0x10D1830", Offset = "0x10D0630", Length = "0xB4")]
		set
		{
		}
	}

	[Token(Token = "0x6007150")]
	[Address(RVA = "0x10D18F0", Offset = "0x10D06F0", Length = "0x64")]
	public TaskAgentParameter()
	{
	}
}

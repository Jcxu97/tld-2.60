using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200085E")]
public class WaitForFullFSMUpdate : CustomYieldInstruction
{
	[Token(Token = "0x40056D5")]
	[FieldOffset(Offset = "0x10")]
	private int m_WaitForFrames;

	[Token(Token = "0x1700035A")]
	public override bool keepWaiting
	{
		[Token(Token = "0x6004CF2")]
		[Address(RVA = "0xD7F810", Offset = "0xD7E610", Length = "0x12")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6004CF3")]
	[Address(RVA = "0xD7F830", Offset = "0xD7E630", Length = "0xB3")]
	public WaitForFullFSMUpdate()
	{
	}
}

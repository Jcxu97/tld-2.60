using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;

[Token(Token = "0x20002A3")]
public class JumpLoadThread
{
	[Token(Token = "0x40017A2")]
	[FieldOffset(Offset = "0x10")]
	private JumpLoadCompleteDelegate m_OnComplete;

	[Token(Token = "0x40017A3")]
	[FieldOffset(Offset = "0x18")]
	private List<JumpData> m_JumpList;

	[Token(Token = "0x40017A4")]
	[FieldOffset(Offset = "0x20")]
	private Thread m_Thread;

	[Token(Token = "0x40017A5")]
	[FieldOffset(Offset = "0x28")]
	private bool m_Cancel;

	[Token(Token = "0x6001686")]
	[Address(RVA = "0x6BA4F0", Offset = "0x6B92F0", Length = "0x342")]
	public JumpLoadThread(JumpLoadCompleteDelegate onComplete)
	{
	}

	[Token(Token = "0x6001687")]
	[Address(RVA = "0x6BA840", Offset = "0x6B9640", Length = "0x21")]
	public void Start()
	{
	}

	[Token(Token = "0x6001688")]
	[Address(RVA = "0x6BA870", Offset = "0x6B9670", Length = "0xD1")]
	public void Stop()
	{
	}

	[Token(Token = "0x6001689")]
	[Address(RVA = "0x6BA950", Offset = "0x6B9750", Length = "0x2C9")]
	private void ExecuteSingleThreaded()
	{
	}
}

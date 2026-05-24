using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Utility")]
[Token(Token = "0x2001311")]
public class Wait : ActionTask
{
	[Token(Token = "0x4008CDC")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<float> waitTime;

	[Token(Token = "0x4008CDD")]
	[FieldOffset(Offset = "0x70")]
	public CompactStatus finishStatus;

	[Token(Token = "0x17000A2E")]
	protected override string info
	{
		[Token(Token = "0x6007A3F")]
		[Address(RVA = "0x11904B0", Offset = "0x118F2B0", Length = "0x84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A40")]
	[Address(RVA = "0x1190540", Offset = "0x118F340", Length = "0x78")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007A41")]
	[Address(RVA = "0x11905C0", Offset = "0x118F3C0", Length = "0x9C")]
	public Wait()
	{
	}
}

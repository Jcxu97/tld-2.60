using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Utility")]
[Description("Send a graph event. If global is true, all graph owners in scene will receive this event. Use along with the 'Check Event' Condition")]
[Token(Token = "0x200130A")]
public class SendEvent : ActionTask<GraphOwner>
{
	[RequiredField]
	[Token(Token = "0x4008CC8")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> eventName;

	[Token(Token = "0x4008CC9")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> delay;

	[Token(Token = "0x4008CCA")]
	[FieldOffset(Offset = "0x78")]
	public bool sendGlobal;

	[Token(Token = "0x17000A27")]
	protected override string info
	{
		[Token(Token = "0x6007A28")]
		[Address(RVA = "0x118E900", Offset = "0x118D700", Length = "0x1D6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A29")]
	[Address(RVA = "0x118EAE0", Offset = "0x118D8E0", Length = "0x1D4")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007A2A")]
	[Address(RVA = "0x118ECC0", Offset = "0x118DAC0", Length = "0x44")]
	public SendEvent()
	{
	}
}
[Category("✫ Utility")]
[Description("Send a graph event with T value. If global is true, all graph owners in scene will receive this event. Use along with the 'Check Event' Condition")]
[Token(Token = "0x200130B")]
public class SendEvent<T> : ActionTask<GraphOwner>
{
	[RequiredField]
	[Token(Token = "0x4008CCB")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<string> eventName;

	[Token(Token = "0x4008CCC")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> eventValue;

	[Token(Token = "0x4008CCD")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<float> delay;

	[Token(Token = "0x4008CCE")]
	[FieldOffset(Offset = "0x0")]
	public bool sendGlobal;

	[Token(Token = "0x17000A28")]
	protected override string info
	{
		[Token(Token = "0x6007A2B")]
		[Address(RVA = "0x1FD5E50", Offset = "0x1FD4C50", Length = "0x29B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A2C")]
	[Address(RVA = "0x1FD60F0", Offset = "0x1FD4EF0", Length = "0x21B")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007A2D")]
	[Address(RVA = "0x1FD6310", Offset = "0x1FD5110", Length = "0x44")]
	public SendEvent()
	{
	}
}

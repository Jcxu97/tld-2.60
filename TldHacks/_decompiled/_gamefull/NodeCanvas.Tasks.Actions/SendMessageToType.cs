using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Script Control/Common")]
[Description("Send a Unity message to all game objects with a component of the specified type.\nNotice: This is slow and should not be called per-fame.")]
[Token(Token = "0x20012F1")]
public class SendMessageToType<T> : ActionTask where T : Component
{
	[RequiredField]
	[Token(Token = "0x4008C82")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<string> message;

	[BlackboardOnly]
	[Token(Token = "0x4008C83")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<object> argument;

	[Token(Token = "0x17000A02")]
	protected override string info
	{
		[Token(Token = "0x60079A5")]
		[Address(RVA = "0x1FDC410", Offset = "0x1FDB210", Length = "0x129")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60079A6")]
	[Address(RVA = "0x1FDC540", Offset = "0x1FDB340", Length = "0x205")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60079A7")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public SendMessageToType()
	{
	}
}

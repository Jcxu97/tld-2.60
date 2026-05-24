using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Token(Token = "0x20012BC")]
public class CreatePrimitive : ActionTask
{
	[Token(Token = "0x4008BBF")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> objectName;

	[Token(Token = "0x4008BC0")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<Vector3> position;

	[Token(Token = "0x4008BC1")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<Vector3> rotation;

	[Token(Token = "0x4008BC2")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<PrimitiveType> type;

	[BlackboardOnly]
	[Token(Token = "0x4008BC3")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<GameObject> saveAs;

	[Token(Token = "0x6007908")]
	[Address(RVA = "0x1175440", Offset = "0x1174240", Length = "0x225")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007909")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public CreatePrimitive()
	{
	}
}

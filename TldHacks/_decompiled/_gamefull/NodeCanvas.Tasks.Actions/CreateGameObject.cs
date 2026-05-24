using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Token(Token = "0x20012BB")]
public class CreateGameObject : ActionTask
{
	[Token(Token = "0x4008BBB")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> objectName;

	[Token(Token = "0x4008BBC")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<Vector3> position;

	[Token(Token = "0x4008BBD")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<Vector3> rotation;

	[BlackboardOnly]
	[Token(Token = "0x4008BBE")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<GameObject> saveAs;

	[Token(Token = "0x6007906")]
	[Address(RVA = "0x11751F0", Offset = "0x1173FF0", Length = "0x245")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007907")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public CreateGameObject()
	{
	}
}

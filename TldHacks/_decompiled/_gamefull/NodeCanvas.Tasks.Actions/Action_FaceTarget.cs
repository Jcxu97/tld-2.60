using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("TLD Conditions/Player")]
[Description("Rotates gameobject to face target")]
[Name("FaceTarget", 0)]
[Token(Token = "0x20011B1")]
public class Action_FaceTarget : ActionTask
{
	[Token(Token = "0x40088B8")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> target;

	[Token(Token = "0x40088B9")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> rotationDegreesPerSecond;

	[Token(Token = "0x40088BA")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<string> turnAngleParameterName;

	[Token(Token = "0x60075EB")]
	[Address(RVA = "0x1113E60", Offset = "0x1112C60", Length = "0xC05")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60075EC")]
	[Address(RVA = "0x1114A70", Offset = "0x1113870", Length = "0xE5")]
	private float GetTurnSpeed(Vector3 previousHeading, Vector3 currentHeading)
	{
		return 0f;
	}

	[Token(Token = "0x60075ED")]
	[Address(RVA = "0x1114B60", Offset = "0x1113960", Length = "0x95")]
	public Action_FaceTarget()
	{
	}
}

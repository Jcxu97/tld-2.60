using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Name("Target Within Distance", 0)]
[Category("GameObject")]
[Token(Token = "0x2001176")]
public class CheckDistanceToGameObject : ConditionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x400881D")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> checkTarget;

	[Token(Token = "0x400881E")]
	[FieldOffset(Offset = "0x70")]
	public CompareMethod checkType;

	[Token(Token = "0x400881F")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> distance;

	[SliderField(0f, 0.1f)]
	[Token(Token = "0x4008820")]
	[FieldOffset(Offset = "0x80")]
	public float floatingPoint;

	[Token(Token = "0x17000925")]
	protected override string info
	{
		[Token(Token = "0x60074EE")]
		[Address(RVA = "0x11063C0", Offset = "0x11051C0", Length = "0x131")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074EF")]
	[Address(RVA = "0x1106500", Offset = "0x1105300", Length = "0x32E")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074F0")]
	[Address(RVA = "0x1106830", Offset = "0x1105630", Length = "0x29D")]
	public override void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60074F1")]
	[Address(RVA = "0x1106AD0", Offset = "0x11058D0", Length = "0xB1")]
	public CheckDistanceToGameObject()
	{
	}
}

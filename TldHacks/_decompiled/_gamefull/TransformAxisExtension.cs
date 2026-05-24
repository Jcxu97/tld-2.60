using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001AC")]
public static class TransformAxisExtension
{
	[Token(Token = "0x6000F9C")]
	[Address(RVA = "0x618840", Offset = "0x617640", Length = "0x210")]
	public static float GetLocalTransformValue(this TransformAxis axis, Transform transform)
	{
		return 0f;
	}

	[Token(Token = "0x6000F9D")]
	[Address(RVA = "0x618A80", Offset = "0x617880", Length = "0xF")]
	public static float GetLocalValueFromAxis(this Transform transform, TransformAxis axis)
	{
		return 0f;
	}
}

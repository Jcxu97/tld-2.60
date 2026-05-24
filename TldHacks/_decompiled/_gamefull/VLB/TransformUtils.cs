using Cpp2ILInjected;
using UnityEngine;

namespace VLB;

[Token(Token = "0x2000BE9")]
public static class TransformUtils
{
	[Token(Token = "0x2000BEA")]
	public class Packed
	{
		[Token(Token = "0x4007995")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x4007996")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x4007997")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 lossyScale;

		[Token(Token = "0x6005DCC")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public Packed()
		{
		}
	}

	[Token(Token = "0x6005DCA")]
	[Address(RVA = "0xF6AB70", Offset = "0xF69970", Length = "0x239")]
	public static Packed GetWorldPacked(this Transform self)
	{
		return null;
	}

	[Token(Token = "0x6005DCB")]
	[Address(RVA = "0xF6ADB0", Offset = "0xF69BB0", Length = "0x2D5")]
	public static bool IsSame(this Transform self, Packed packed)
	{
		return false;
	}
}

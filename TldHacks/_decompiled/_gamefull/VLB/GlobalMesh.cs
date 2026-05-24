using Cpp2ILInjected;
using UnityEngine;

namespace VLB;

[Token(Token = "0x2000BD2")]
public static class GlobalMesh
{
	[Token(Token = "0x4007927")]
	private static Mesh ms_Mesh;

	[Token(Token = "0x4007928")]
	private static bool ms_DoubleSided;

	[Token(Token = "0x6005D87")]
	[Address(RVA = "0xF65D30", Offset = "0xF64B30", Length = "0x497")]
	public static Mesh Get()
	{
		return null;
	}

	[Token(Token = "0x6005D88")]
	[Address(RVA = "0xF661D0", Offset = "0xF64FD0", Length = "0x1B7")]
	public static void Destroy()
	{
	}
}

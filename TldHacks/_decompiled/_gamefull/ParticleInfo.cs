using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003EB")]
public struct ParticleInfo
{
	[Token(Token = "0x400230E")]
	[FieldOffset(Offset = "0x0")]
	public ParticleSystem partSys;

	[Token(Token = "0x400230F")]
	[FieldOffset(Offset = "0x8")]
	public float origSize;
}

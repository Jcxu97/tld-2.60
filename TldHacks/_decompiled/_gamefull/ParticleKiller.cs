using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A24")]
public class ParticleKiller : MonoBehaviour
{
	[Token(Token = "0x400664C")]
	[FieldOffset(Offset = "0x20")]
	public bool m_KillsFallingSnow;

	[Token(Token = "0x400664D")]
	[FieldOffset(Offset = "0x21")]
	public bool m_KillsBlowingSnow;

	[Token(Token = "0x60058EA")]
	[Address(RVA = "0xEED6B0", Offset = "0xEEC4B0", Length = "0x49")]
	public ParticleKiller()
	{
	}
}

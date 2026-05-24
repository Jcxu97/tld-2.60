using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001F5")]
public class SuffocatingSettings : MonoBehaviour
{
	[Token(Token = "0x40011BB")]
	[FieldOffset(Offset = "0x20")]
	public float m_SuffocatingDelayTimerSeconds;

	[Token(Token = "0x40011BC")]
	[FieldOffset(Offset = "0x24")]
	public float m_SuffocatingTimerSeconds;

	[Token(Token = "0x60011E2")]
	[Address(RVA = "0x644820", Offset = "0x643620", Length = "0x51")]
	public SuffocatingSettings()
	{
	}
}

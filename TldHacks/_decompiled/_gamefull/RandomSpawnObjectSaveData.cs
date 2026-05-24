using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007C3")]
public class RandomSpawnObjectSaveData
{
	[Token(Token = "0x400539F")]
	[FieldOffset(Offset = "0x10")]
	public string m_PDID;

	[Token(Token = "0x40053A0")]
	[FieldOffset(Offset = "0x18")]
	public string m_ObjectName;

	[Token(Token = "0x40053A1")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 m_Position;

	[Token(Token = "0x40053A2")]
	[FieldOffset(Offset = "0x2C")]
	public float m_ElapsedHoursAtLastReroll;

	[Token(Token = "0x6004976")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public RandomSpawnObjectSaveData()
	{
	}
}

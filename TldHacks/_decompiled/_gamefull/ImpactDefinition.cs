using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(fileName = "ImpactDefinition", menuName = "Gameplay/Impact Definition", order = 10003)]
[Token(Token = "0x2000898")]
public class ImpactDefinition : ScriptableObject
{
	[Token(Token = "0x4005895")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 m_PlayerDirection;

	[Token(Token = "0x4005896")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 m_CameraDirection;

	[Token(Token = "0x4005897")]
	[FieldOffset(Offset = "0x30")]
	public float m_PlayerIntensity;

	[Token(Token = "0x4005898")]
	[FieldOffset(Offset = "0x34")]
	public float m_CameraIntensity;

	[Token(Token = "0x4005899")]
	[FieldOffset(Offset = "0x38")]
	public string m_AudioVO;

	[Token(Token = "0x6004E64")]
	[Address(RVA = "0xDA59D0", Offset = "0xDA47D0", Length = "0x397")]
	public void Apply()
	{
	}

	[Token(Token = "0x6004E65")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public ImpactDefinition()
	{
	}
}

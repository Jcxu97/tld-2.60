using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000386")]
public class EmissiveTextureFadeFire : MonoBehaviour
{
	[Token(Token = "0x4001F7F")]
	[FieldOffset(Offset = "0x20")]
	public Fire m_SourceFire;

	[Token(Token = "0x4001F80")]
	[FieldOffset(Offset = "0x28")]
	public bool m_StartOff;

	[Token(Token = "0x4001F81")]
	[FieldOffset(Offset = "0x29")]
	public bool m_UseFireIgnitionFirst;

	[Token(Token = "0x4001F82")]
	[FieldOffset(Offset = "0x2A")]
	public bool m_AutoSwitchAfterIngnition;

	[Token(Token = "0x4001F83")]
	[FieldOffset(Offset = "0x2C")]
	public float m_FullOnMinutes;

	[Token(Token = "0x4001F84")]
	[FieldOffset(Offset = "0x30")]
	public float m_FullOffMinutes;

	[Token(Token = "0x4001F85")]
	[FieldOffset(Offset = "0x34")]
	private float m_MaxTimeSec;

	[Token(Token = "0x4001F86")]
	[FieldOffset(Offset = "0x38")]
	private float m_MinTimeSec;

	[Token(Token = "0x4001F87")]
	[FieldOffset(Offset = "0x3C")]
	private float m_IgnitionDuration;

	[Token(Token = "0x4001F88")]
	[FieldOffset(Offset = "0x40")]
	private float m_FireTime;

	[Token(Token = "0x4001F89")]
	[FieldOffset(Offset = "0x44")]
	private float m_FadeTimeNormalized;

	[Token(Token = "0x4001F8A")]
	[FieldOffset(Offset = "0x48")]
	private float m_FadeTimeDifference;

	[Token(Token = "0x4001F8B")]
	[FieldOffset(Offset = "0x4C")]
	private float m_FadeTimeStep;

	[Token(Token = "0x4001F8C")]
	[FieldOffset(Offset = "0x50")]
	private Material m_ThisMaterial;

	[Token(Token = "0x4001F8D")]
	[FieldOffset(Offset = "0x58")]
	private int m_ThisEmissiveID;

	[Token(Token = "0x6001C48")]
	[Address(RVA = "0x77C8E0", Offset = "0x77B6E0", Length = "0xF4")]
	private void Start()
	{
	}

	[Token(Token = "0x6001C49")]
	[Address(RVA = "0x77C9E0", Offset = "0x77B7E0", Length = "0x1A0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001C4A")]
	[Address(RVA = "0x77CB90", Offset = "0x77B990", Length = "0x9A")]
	public void SetNewMaxTime(float newMax)
	{
	}

	[Token(Token = "0x6001C4B")]
	[Address(RVA = "0x77CC30", Offset = "0x77BA30", Length = "0x50")]
	public EmissiveTextureFadeFire()
	{
	}
}

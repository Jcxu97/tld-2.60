using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000481")]
public class FireStarterItem : MonoBehaviour
{
	[Token(Token = "0x40028D2")]
	[FieldOffset(Offset = "0x20")]
	public float m_SecondsToIgniteTinder;

	[Token(Token = "0x40028D3")]
	[FieldOffset(Offset = "0x24")]
	public float m_SecondsToIgniteTorch;

	[Token(Token = "0x40028D4")]
	[FieldOffset(Offset = "0x28")]
	public float m_FireStartSkillModifier;

	[Token(Token = "0x40028D5")]
	[FieldOffset(Offset = "0x2C")]
	public float m_FireStartDurationModifier;

	[Token(Token = "0x40028D6")]
	[FieldOffset(Offset = "0x30")]
	public float m_ConditionDegradeOnUse;

	[Token(Token = "0x40028D7")]
	[FieldOffset(Offset = "0x34")]
	public bool m_ConsumeOnUse;

	[Token(Token = "0x40028D8")]
	[FieldOffset(Offset = "0x35")]
	public bool m_RequiresSunLight;

	[Token(Token = "0x40028D9")]
	[FieldOffset(Offset = "0x36")]
	public bool m_IsAccelerant;

	[Token(Token = "0x40028DA")]
	[FieldOffset(Offset = "0x38")]
	public string m_OnUseSoundEvent;

	[Token(Token = "0x6002203")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Start()
	{
	}

	[Token(Token = "0x6002204")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FireStarterItem()
	{
	}
}

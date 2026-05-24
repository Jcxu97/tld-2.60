using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000288")]
public class MajorBruisingEvent : MinorBruisingEvent
{
	[Header("Insulated Flask")]
	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x400170F")]
	[FieldOffset(Offset = "0x60")]
	private float m_FlaskDamageChance;

	[SerializeField]
	[Min(0f)]
	[Token(Token = "0x4001710")]
	[FieldOffset(Offset = "0x64")]
	private float m_FlaskDamage;

	[Token(Token = "0x60015F4")]
	[Address(RVA = "0x6ADB60", Offset = "0x6AC960", Length = "0x20")]
	public override void OnExecute(BaseAi instigator)
	{
	}

	[Token(Token = "0x60015F5")]
	[Address(RVA = "0x6ADB80", Offset = "0x6AC980", Length = "0x4DF")]
	private void MaybeApplyFlaskDamage()
	{
	}

	[Token(Token = "0x60015F6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public MajorBruisingEvent()
	{
	}
}

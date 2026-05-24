using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000283")]
public abstract class StruggleDamageEvent
{
	[Token(Token = "0x4001703")]
	[FieldOffset(Offset = "0x10")]
	public int m_PercentChance;

	[Token(Token = "0x4001704")]
	[FieldOffset(Offset = "0x14")]
	public int m_MaxExecutionCount;

	[Token(Token = "0x4001705")]
	[FieldOffset(Offset = "0x18")]
	public int m_MaxShowing;

	[Token(Token = "0x4001706")]
	[FieldOffset(Offset = "0x20")]
	public StruggleDamageEventUISettings m_UISettings;

	[HideInInspector]
	[Token(Token = "0x4001707")]
	[FieldOffset(Offset = "0x28")]
	public string m_IconName;

	[HideInInspector]
	[Token(Token = "0x4001708")]
	[FieldOffset(Offset = "0x30")]
	public string m_DamageEventName;

	[HideInInspector]
	[Token(Token = "0x4001709")]
	[FieldOffset(Offset = "0x38")]
	public string m_DamageEventType;

	[HideInInspector]
	[Token(Token = "0x400170A")]
	[FieldOffset(Offset = "0x40")]
	public Color m_TintColor;

	[Token(Token = "0x400170B")]
	[FieldOffset(Offset = "0x50")]
	private int m_ExecutionCount;

	[Token(Token = "0x400170C")]
	[FieldOffset(Offset = "0x54")]
	private int m_ShowingCount;

	[Token(Token = "0x60015DD")]
	[Address(RVA = "0x6ACF00", Offset = "0x6ABD00", Length = "0x7")]
	public void Reset()
	{
	}

	[Token(Token = "0x60015DE")]
	[Address(RVA = "0x6ACF10", Offset = "0x6ABD10", Length = "0x122")]
	public void Execute(BaseAi instigator)
	{
	}

	[Token(Token = "0x60015DF")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	protected virtual bool CanExecute()
	{
		return false;
	}

	[Token(Token = "0x60015E0")]
	public abstract void OnExecute(BaseAi instigator);

	[Token(Token = "0x60015E1")]
	public abstract bool IsLocationAvailable();

	[Token(Token = "0x60015E2")]
	[Address(RVA = "0x40E0B0", Offset = "0x40CEB0", Length = "0x4")]
	public int GetMaxExecutions()
	{
		return 0;
	}

	[Token(Token = "0x60015E3")]
	[Address(RVA = "0x6AD040", Offset = "0x6ABE40", Length = "0x4E")]
	public int GetChance()
	{
		return 0;
	}

	[Token(Token = "0x60015E4")]
	[Address(RVA = "0x6AD090", Offset = "0x6ABE90", Length = "0x43B")]
	protected void ApplyDamage(float damage, BaseAi instigator)
	{
	}

	[Token(Token = "0x60015E5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected StruggleDamageEvent()
	{
	}
}

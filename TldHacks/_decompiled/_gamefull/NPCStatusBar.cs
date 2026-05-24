using Cpp2ILInjected;

[Token(Token = "0x2000267")]
public class NPCStatusBar : StatusBar
{
	[Token(Token = "0x40015FB")]
	[FieldOffset(Offset = "0x118")]
	private NPC m_NPCComponent;

	[Token(Token = "0x60014FB")]
	[Address(RVA = "0x699680", Offset = "0x698480", Length = "0x52")]
	public void AttachNPC(NPC npc)
	{
	}

	[Token(Token = "0x60014FC")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool ShouldBeHidden()
	{
		return false;
	}

	[Token(Token = "0x60014FD")]
	[Address(RVA = "0x6996E0", Offset = "0x6984E0", Length = "0x1DA")]
	protected override FillValues GetFillValuesThirst()
	{
		return default(FillValues);
	}

	[Token(Token = "0x60014FE")]
	[Address(RVA = "0x6998C0", Offset = "0x6986C0", Length = "0x19")]
	protected override FillValues GetFillValuesHunger()
	{
		return default(FillValues);
	}

	[Token(Token = "0x60014FF")]
	[Address(RVA = "0x6998E0", Offset = "0x6986E0", Length = "0x1DA")]
	protected override FillValues GetFillValuesCold()
	{
		return default(FillValues);
	}

	[Token(Token = "0x6001500")]
	[Address(RVA = "0x6998C0", Offset = "0x6986C0", Length = "0x19")]
	protected override FillValues GetFillValuesFatigue()
	{
		return default(FillValues);
	}

	[Token(Token = "0x6001501")]
	[Address(RVA = "0x699AC0", Offset = "0x6988C0", Length = "0x1FF")]
	protected override FillValues GetFillValuesCondition()
	{
		return default(FillValues);
	}

	[Token(Token = "0x6001502")]
	[Address(RVA = "0x699CC0", Offset = "0x698AC0", Length = "0x24A")]
	protected override float GetRateOfChangeThirst()
	{
		return 0f;
	}

	[Token(Token = "0x6001503")]
	[Address(RVA = "0x699F10", Offset = "0x698D10", Length = "0x4")]
	protected override float GetRateOfChangeHunger()
	{
		return 0f;
	}

	[Token(Token = "0x6001504")]
	[Address(RVA = "0x699F20", Offset = "0x698D20", Length = "0x36F")]
	protected override float GetRateOfChangeCold()
	{
		return 0f;
	}

	[Token(Token = "0x6001505")]
	[Address(RVA = "0x699F10", Offset = "0x698D10", Length = "0x4")]
	protected override float GetRateOfChangeFatigue()
	{
		return 0f;
	}

	[Token(Token = "0x6001506")]
	[Address(RVA = "0x69A290", Offset = "0x699090", Length = "0x1B")]
	protected override bool IsBuffActive()
	{
		return false;
	}

	[Token(Token = "0x6001507")]
	[Address(RVA = "0x69A2B0", Offset = "0x6990B0", Length = "0x169")]
	protected override bool IsDebuffActive()
	{
		return false;
	}

	[Token(Token = "0x6001508")]
	[Address(RVA = "0x69A420", Offset = "0x699220", Length = "0x58")]
	public NPCStatusBar()
	{
	}
}

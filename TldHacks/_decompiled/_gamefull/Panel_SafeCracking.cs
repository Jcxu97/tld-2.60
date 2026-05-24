using Cpp2ILInjected;
using TLD.UI;
using UnityEngine;

[Token(Token = "0x20006B7")]
public class Panel_SafeCracking : Panel_AutoReferenced
{
	[Token(Token = "0x400479E")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x400479F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_OpenButtonObject;

	[Token(Token = "0x40047A0")]
	[FieldOffset(Offset = "0x40")]
	public GameObject[] m_Tumblers;

	[Token(Token = "0x40047A1")]
	[FieldOffset(Offset = "0x48")]
	public UISprite[] m_TumblerStatuses;

	[Token(Token = "0x40047A2")]
	[FieldOffset(Offset = "0x50")]
	public Color m_LockedSpriteColor;

	[Token(Token = "0x40047A3")]
	[FieldOffset(Offset = "0x60")]
	public Color m_UnlockedSpriteColor;

	[Header("Button Prompts")]
	[SerializeField]
	[Token(Token = "0x40047A4")]
	[FieldOffset(Offset = "0x70")]
	private UIGrid m_ButtonPromptGrid;

	[SerializeField]
	[Token(Token = "0x40047A5")]
	[FieldOffset(Offset = "0x78")]
	private ButtonPrompt[] m_ButtonPrompts;

	[Token(Token = "0x40047A6")]
	[FieldOffset(Offset = "0x80")]
	private SafeCracking m_CurrentSafe;

	[Token(Token = "0x40047A7")]
	[FieldOffset(Offset = "0x88")]
	private bool m_OpenSafe;

	[Token(Token = "0x40047A8")]
	[FieldOffset(Offset = "0x89")]
	private bool m_LastGamepadActive;

	[Token(Token = "0x6003ADD")]
	[Address(RVA = "0x67CA50", Offset = "0x67B850", Length = "0x44")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003ADE")]
	[Address(RVA = "0xB516F0", Offset = "0xB504F0", Length = "0x391")]
	private void Update()
	{
	}

	[Token(Token = "0x6003ADF")]
	[Address(RVA = "0xB51A90", Offset = "0xB50890", Length = "0x3F5")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003AE0")]
	[Address(RVA = "0xB51E90", Offset = "0xB50C90", Length = "0x52")]
	public void SetCurrentSafe(SafeCracking safe)
	{
	}

	[Token(Token = "0x6003AE1")]
	[Address(RVA = "0xB51EF0", Offset = "0xB50CF0", Length = "0x136")]
	public bool IsCurrentSafe(SafeCracking safe)
	{
		return false;
	}

	[Token(Token = "0x6003AE2")]
	[Address(RVA = "0xB52030", Offset = "0xB50E30", Length = "0x110")]
	public void EnableOpenSafeButton(bool enable)
	{
	}

	[Token(Token = "0x6003AE3")]
	[Address(RVA = "0xB52140", Offset = "0xB50F40", Length = "0x68")]
	public void OnDone()
	{
	}

	[Token(Token = "0x6003AE4")]
	[Address(RVA = "0xB521B0", Offset = "0xB50FB0", Length = "0x68")]
	public void OnOpen()
	{
	}

	[Token(Token = "0x6003AE5")]
	[Address(RVA = "0xB52220", Offset = "0xB51020", Length = "0x11B")]
	public void SetNumTumblersActive(int numTumblers)
	{
	}

	[Token(Token = "0x6003AE6")]
	[Address(RVA = "0xB52340", Offset = "0xB51140", Length = "0xEF")]
	public void SetTumblerStatus(int tumblerIndex, bool unlocked)
	{
	}

	[Token(Token = "0x6003AE7")]
	[Address(RVA = "0xB52430", Offset = "0xB51230", Length = "0x197")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003AE8")]
	[Address(RVA = "0xB525D0", Offset = "0xB513D0", Length = "0x302")]
	private void RefreshButtonPrompt()
	{
	}

	[Token(Token = "0x6003AE9")]
	[Address(RVA = "0xB528E0", Offset = "0xB516E0", Length = "0xC3")]
	public Panel_SafeCracking()
	{
	}
}

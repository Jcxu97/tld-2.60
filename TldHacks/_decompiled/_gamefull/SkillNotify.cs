using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200093C")]
public class SkillNotify : MonoBehaviour
{
	[Token(Token = "0x4006034")]
	[FieldOffset(Offset = "0x20")]
	public float m_FadeTimeSeconds;

	[Header("Skill Increase")]
	[Token(Token = "0x4006035")]
	[FieldOffset(Offset = "0x24")]
	public float m_SkillIncreaseDisplayTimeSeconds;

	[Header("Skill Level Up")]
	[Token(Token = "0x4006036")]
	[FieldOffset(Offset = "0x28")]
	public float m_SkillLevelUpDisplayTimeSeconds;

	[Token(Token = "0x4006037")]
	[FieldOffset(Offset = "0x30")]
	public string m_SkillLevelUpAudio;

	[Token(Token = "0x4006038")]
	[FieldOffset(Offset = "0x38")]
	public float m_SkillLevelUpDelaySeconds;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4006039")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x400603A")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_PauseMenu> m_PauseMenu;

	[Token(Token = "0x400603B")]
	[FieldOffset(Offset = "0x50")]
	private float m_SkillIncreaseElapsedDisplayTimeSeconds;

	[Token(Token = "0x400603C")]
	[FieldOffset(Offset = "0x54")]
	private float m_SkillIncreaseAlpha;

	[Token(Token = "0x400603D")]
	[FieldOffset(Offset = "0x58")]
	private float m_SkillLevelUpElapsedDisplayTimeSeconds;

	[Token(Token = "0x400603E")]
	[FieldOffset(Offset = "0x5C")]
	private float m_SkillLevelUpAlpha;

	[Token(Token = "0x400603F")]
	[FieldOffset(Offset = "0x60")]
	private float m_SkillLevelUpDisplayTimeGate;

	[Token(Token = "0x4006040")]
	[FieldOffset(Offset = "0x64")]
	private bool m_SkillLevelUpPending;

	[Token(Token = "0x60053E5")]
	[Address(RVA = "0xE77CE0", Offset = "0xE76AE0", Length = "0xB5")]
	public void Start()
	{
	}

	[Token(Token = "0x60053E6")]
	[Address(RVA = "0xE77DA0", Offset = "0xE76BA0", Length = "0x3B1")]
	public void Update()
	{
	}

	[Token(Token = "0x60053E7")]
	[Address(RVA = "0xE78160", Offset = "0xE76F60", Length = "0x111")]
	public void MaybeShowPointIncrease(string spriteName)
	{
	}

	[Token(Token = "0x60053E8")]
	[Address(RVA = "0xE78280", Offset = "0xE77080", Length = "0x1A8")]
	public void MaybeShowLevelUp(string spriteName, string header, string footer, int tier)
	{
	}

	[Token(Token = "0x60053E9")]
	[Address(RVA = "0xE78430", Offset = "0xE77230", Length = "0x1C0")]
	private void UpdateSkillIncreaseAlpha(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60053EA")]
	[Address(RVA = "0xE78600", Offset = "0xE77400", Length = "0x1C0")]
	private void UpdateSkillLevelUpAlpha(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60053EB")]
	[Address(RVA = "0xE787D0", Offset = "0xE775D0", Length = "0x104")]
	private bool ShouldHideSkillLevelUpIcon()
	{
		return false;
	}

	[Token(Token = "0x60053EC")]
	[Address(RVA = "0xE788E0", Offset = "0xE776E0", Length = "0xBE")]
	private bool ShouldHideSkillIncreaseIcon()
	{
		return false;
	}

	[Token(Token = "0x60053ED")]
	[Address(RVA = "0xE789A0", Offset = "0xE777A0", Length = "0xE7")]
	private bool TryToDisplaySkillLevelUp(Panel_HUD hud)
	{
		return false;
	}

	[Token(Token = "0x60053EE")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SkillNotify()
	{
	}
}

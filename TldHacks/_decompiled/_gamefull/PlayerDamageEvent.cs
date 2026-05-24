using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000270")]
public class PlayerDamageEvent : MonoBehaviour
{
	[Token(Token = "0x400163A")]
	private static Panel_HUD s_HUD;

	[Token(Token = "0x400163B")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_Icon;

	[Token(Token = "0x400163C")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_Background;

	[Token(Token = "0x400163D")]
	[FieldOffset(Offset = "0x30")]
	public UISprite m_Backpiece;

	[Token(Token = "0x400163E")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_DamageType;

	[Token(Token = "0x400163F")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_DamageName;

	[Token(Token = "0x4001640")]
	[FieldOffset(Offset = "0x48")]
	public float m_DisplayTime;

	[Token(Token = "0x4001641")]
	[FieldOffset(Offset = "0x4C")]
	public float m_FadeOutTime;

	[Token(Token = "0x4001642")]
	[FieldOffset(Offset = "0x50")]
	public float m_TimeActive;

	[Token(Token = "0x4001643")]
	[FieldOffset(Offset = "0x54")]
	public bool m_FadeOut;

	[Token(Token = "0x4001644")]
	[FieldOffset(Offset = "0x55")]
	public bool m_TintIcon;

	[Token(Token = "0x4001645")]
	[FieldOffset(Offset = "0x56")]
	public bool m_TintDamageType;

	[Token(Token = "0x4001646")]
	[FieldOffset(Offset = "0x57")]
	public bool m_TintDamageName;

	[Token(Token = "0x4001647")]
	[FieldOffset(Offset = "0x58")]
	public bool m_TintBG;

	[Token(Token = "0x4001648")]
	[FieldOffset(Offset = "0x5C")]
	public Color m_BGColorRed;

	[Token(Token = "0x4001649")]
	[FieldOffset(Offset = "0x6C")]
	public Color m_BGColorOrange;

	[Token(Token = "0x400164A")]
	[FieldOffset(Offset = "0x7C")]
	public Color m_BGColorGreen;

	[Token(Token = "0x400164B")]
	[FieldOffset(Offset = "0x8C")]
	public Color m_BGColorWhite;

	[Token(Token = "0x6001552")]
	[Address(RVA = "0x69CF70", Offset = "0x69BD70", Length = "0xAE")]
	public void SetAlpha(float amount)
	{
	}

	[Token(Token = "0x6001553")]
	[Address(RVA = "0x69D020", Offset = "0x69BE20", Length = "0x257")]
	public PlayerDamageEventProxy ToProxy()
	{
		return null;
	}

	[Token(Token = "0x6001554")]
	[Address(RVA = "0x69D280", Offset = "0x69C080", Length = "0x92")]
	public void FromProxy(PlayerDamageEventProxy proxy)
	{
	}

	[Token(Token = "0x6001555")]
	[Address(RVA = "0x69D320", Offset = "0x69C120", Length = "0x22E")]
	private static bool HasHUD()
	{
		return false;
	}

	[Token(Token = "0x6001556")]
	[Address(RVA = "0x69D550", Offset = "0x69C350", Length = "0x57D")]
	public static void SpawnDamageEvent(string damageEventName, string damageEventType, string iconName, Color tint, bool fadeout, float displayTime, float fadeoutTime)
	{
	}

	[Token(Token = "0x6001557")]
	[Address(RVA = "0x69DAD0", Offset = "0x69C8D0", Length = "0x16E")]
	public static void SpawnAfflictionEvent(string damageEventName, string damageEventType, string iconName, Color tint)
	{
	}

	[Token(Token = "0x6001558")]
	[Address(RVA = "0x69DC40", Offset = "0x69CA40", Length = "0x216")]
	private static Color TintToBGColor(PlayerDamageEvent damageEvent, Color tint)
	{
		return default(Color);
	}

	[Token(Token = "0x6001559")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PlayerDamageEvent()
	{
	}
}

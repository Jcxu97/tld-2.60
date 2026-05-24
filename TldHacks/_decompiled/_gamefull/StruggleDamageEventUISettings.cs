using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "The Long Dark/Gameplay/Struggle/Event UI Settings")]
[Token(Token = "0x200028C")]
public class StruggleDamageEventUISettings : ScriptableObject
{
	[Token(Token = "0x4001714")]
	[FieldOffset(Offset = "0x18")]
	public string m_IconName;

	[Token(Token = "0x4001715")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_DamageEventName;

	[Token(Token = "0x4001716")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_DamageEventType;

	[Token(Token = "0x4001717")]
	[FieldOffset(Offset = "0x30")]
	public Color m_TintColor;

	[Token(Token = "0x60015FE")]
	[Address(RVA = "0x6AE6B0", Offset = "0x6AD4B0", Length = "0x12")]
	public StruggleDamageEventUISettings()
	{
	}
}

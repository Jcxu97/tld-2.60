using Cpp2ILInjected;
using UnityEngine;

namespace TLD.UI;

[CreateAssetMenu(menuName = "The Long Dark/UI/Badge UI Settings")]
[Token(Token = "0x200138A")]
public class BadgeUISettings : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x4008F9A")]
	[FieldOffset(Offset = "0x18")]
	private Color m_ColorHeaderLocked;

	[SerializeField]
	[Token(Token = "0x4008F9B")]
	[FieldOffset(Offset = "0x28")]
	private Color m_ColorHeaderUnlocked;

	[SerializeField]
	[Token(Token = "0x4008F9C")]
	[FieldOffset(Offset = "0x38")]
	private Color m_ColorDescriptionLocked;

	[SerializeField]
	[Token(Token = "0x4008F9D")]
	[FieldOffset(Offset = "0x48")]
	private Color m_ColorDescriptionUnlocked;

	[Token(Token = "0x6007CD4")]
	[Address(RVA = "0x11C01B0", Offset = "0x11BEFB0", Length = "0x18")]
	public Color GetHeaderColor(bool unlocked)
	{
		return default(Color);
	}

	[Token(Token = "0x6007CD5")]
	[Address(RVA = "0x11C01D0", Offset = "0x11BEFD0", Length = "0x18")]
	public Color GetDescriptionColor(bool unlocked)
	{
		return default(Color);
	}

	[Token(Token = "0x6007CD6")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public BadgeUISettings()
	{
	}
}

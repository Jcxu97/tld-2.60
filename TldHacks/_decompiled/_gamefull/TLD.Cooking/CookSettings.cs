using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Cooking;

[CreateAssetMenu(menuName = "The Long Dark/Gameplay/Cook Settings")]
[Token(Token = "0x20013F2")]
public class CookSettings : ScriptableObject
{
	[Header("General")]
	[Token(Token = "0x40091E4")]
	[FieldOffset(Offset = "0x18")]
	public float m_MinutesToBoilWaterPerLiter;

	[Token(Token = "0x40091E5")]
	[FieldOffset(Offset = "0x1C")]
	public float m_MinutesToMeltSnowPerLiter;

	[Token(Token = "0x40091E6")]
	[FieldOffset(Offset = "0x20")]
	public float m_MinutesToPurifyPerLiter;

	[Token(Token = "0x40091E7")]
	[FieldOffset(Offset = "0x24")]
	public float m_MinutesReadyTimeBoilingWater;

	[Token(Token = "0x40091E8")]
	[FieldOffset(Offset = "0x28")]
	public float m_MinutesGraceTimeInterruptedCooking;

	[Header("Audio")]
	[Token(Token = "0x40091E9")]
	[FieldOffset(Offset = "0x30")]
	public AK.Wwise.Event m_MeltAndBoilAudio;

	[Token(Token = "0x40091EA")]
	[FieldOffset(Offset = "0x38")]
	public AK.Wwise.Event m_PutSnowInPotAudio;

	[Token(Token = "0x40091EB")]
	[FieldOffset(Offset = "0x40")]
	public AK.Wwise.Event m_PutWaterInPotAudio;

	[Header("Hover Text")]
	[Token(Token = "0x40091EC")]
	[FieldOffset(Offset = "0x48")]
	public Color m_CookingHoverTextColor;

	[Token(Token = "0x40091ED")]
	[FieldOffset(Offset = "0x58")]
	public Color m_ReadyHoverTextColor;

	[Token(Token = "0x40091EE")]
	[FieldOffset(Offset = "0x68")]
	public Color m_RuinedHoverTextColor;

	[Token(Token = "0x6007F2A")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public CookSettings()
	{
	}
}

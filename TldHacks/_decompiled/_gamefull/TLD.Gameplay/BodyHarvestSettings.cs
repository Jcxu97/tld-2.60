using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Gameplay/Body Harvest/Settings")]
[Token(Token = "0x200149D")]
public class BodyHarvestSettings : ScriptableObject
{
	[Header("Harvest")]
	[Token(Token = "0x400956D")]
	[FieldOffset(Offset = "0x18")]
	public float m_HarvestTimeSeconds;

	[Token(Token = "0x400956E")]
	[FieldOffset(Offset = "0x20")]
	public string m_RequiredQuarterToolLocID;

	[Token(Token = "0x400956F")]
	[FieldOffset(Offset = "0x28")]
	public int m_HarvestMeatMinutesPerKG;

	[Token(Token = "0x4009570")]
	[FieldOffset(Offset = "0x2C")]
	public int m_HarvestFrozenMeatMinutesPerKG;

	[Token(Token = "0x4009571")]
	[FieldOffset(Offset = "0x30")]
	public int m_HarvestHideMinutesPerUnit;

	[Token(Token = "0x4009572")]
	[FieldOffset(Offset = "0x34")]
	public int m_HarvestGutMinutesPerUnit;

	[Header("Initial Barehanded Harvest Loss")]
	[Token(Token = "0x4009573")]
	[FieldOffset(Offset = "0x38")]
	public int m_MinInitialBarehandedHarvestPercentLoss;

	[Token(Token = "0x4009574")]
	[FieldOffset(Offset = "0x3C")]
	public int m_MaxInitialBarehandedHarvestPercentLoss;

	[Header("UI")]
	[Token(Token = "0x4009575")]
	[FieldOffset(Offset = "0x40")]
	public string m_NoToolSpriteName;

	[Token(Token = "0x4009576")]
	[FieldOffset(Offset = "0x48")]
	public Color m_NoToolSpriteColor;

	[Token(Token = "0x4009577")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 m_NoToolSpriteSize;

	[Token(Token = "0x4009578")]
	[FieldOffset(Offset = "0x64")]
	public Color m_HighConditionColor;

	[Token(Token = "0x4009579")]
	[FieldOffset(Offset = "0x78")]
	public string m_IconAccelerateTime;

	[Token(Token = "0x60082CE")]
	[Address(RVA = "0x123E5E0", Offset = "0x123D3E0", Length = "0x90")]
	public BodyHarvestSettings()
	{
	}
}

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200033E")]
public class Feat_CelestialNavigator : Feat
{
	[Range(0f, 100f)]
	[SerializeField]
	[Token(Token = "0x4001D04")]
	[FieldOffset(Offset = "0x68")]
	private float m_WalkingSpeedBoostPercent;

	[Token(Token = "0x4001D05")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_Unlocked;

	[Token(Token = "0x6001A95")]
	[Address(RVA = "0x752390", Offset = "0x751190", Length = "0x5E")]
	public float GetWalkingSpeedBoost()
	{
		return 0f;
	}

	[Token(Token = "0x6001A96")]
	[Address(RVA = "0x7523F0", Offset = "0x7511F0", Length = "0x5")]
	public override bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6001A97")]
	[Address(RVA = "0x752400", Offset = "0x751200", Length = "0x30")]
	public override float GetNormalizedProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6001A98")]
	[Address(RVA = "0x752430", Offset = "0x751230", Length = "0x6D")]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[Token(Token = "0x6001A99")]
	[Address(RVA = "0x7524A0", Offset = "0x7512A0", Length = "0xA0")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001A9A")]
	[Address(RVA = "0x752540", Offset = "0x751340", Length = "0x78")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001A9B")]
	[Address(RVA = "0x7525C0", Offset = "0x7513C0", Length = "0x8C")]
	public void ValidateSaveData(string text)
	{
	}

	[Token(Token = "0x6001A9C")]
	[Address(RVA = "0x752650", Offset = "0x751450", Length = "0x5A")]
	public void Unlock()
	{
	}

	[Token(Token = "0x6001A9D")]
	[Address(RVA = "0x7526B0", Offset = "0x7514B0", Length = "0x4A")]
	public Feat_CelestialNavigator()
	{
	}
}

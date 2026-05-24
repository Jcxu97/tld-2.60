using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200034B")]
public class Feat_SettledMind : Feat
{
	[Range(0f, 100f)]
	[SerializeField]
	[Token(Token = "0x4001D30")]
	[FieldOffset(Offset = "0x68")]
	private float m_ReadSpeedBoostPercent;

	[Token(Token = "0x4001D31")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_Unlocked;

	[Token(Token = "0x6001AFC")]
	[Address(RVA = "0x7567C0", Offset = "0x7555C0", Length = "0x48")]
	public float GetReadSpeedBoostPercent()
	{
		return 0f;
	}

	[Token(Token = "0x6001AFD")]
	[Address(RVA = "0x7523F0", Offset = "0x7511F0", Length = "0x5")]
	public override bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6001AFE")]
	[Address(RVA = "0x752400", Offset = "0x751200", Length = "0x30")]
	public override float GetNormalizedProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6001AFF")]
	[Address(RVA = "0x752430", Offset = "0x751230", Length = "0x6D")]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[Token(Token = "0x6001B00")]
	[Address(RVA = "0x756810", Offset = "0x755610", Length = "0xA0")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001B01")]
	[Address(RVA = "0x7568B0", Offset = "0x7556B0", Length = "0x78")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001B02")]
	[Address(RVA = "0x756930", Offset = "0x755730", Length = "0x8C")]
	public void ValidateSaveData(string text)
	{
	}

	[Token(Token = "0x6001B03")]
	[Address(RVA = "0x752650", Offset = "0x751450", Length = "0x5A")]
	public void Unlock()
	{
	}

	[Token(Token = "0x6001B04")]
	[Address(RVA = "0x7569C0", Offset = "0x7557C0", Length = "0x4A")]
	public Feat_SettledMind()
	{
	}
}

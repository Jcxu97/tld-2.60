using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000346")]
public class Feat_FireMaster : Feat
{
	[Header("Tuning")]
	[Range(1f, 2000f)]
	[Token(Token = "0x4001D1A")]
	[FieldOffset(Offset = "0x68")]
	public int m_NumFiresRequired;

	[Range(1f, 5f)]
	[Token(Token = "0x4001D1B")]
	[FieldOffset(Offset = "0x6C")]
	public int m_DefaultFireStartingSkillLevel;

	[Token(Token = "0x4001D1C")]
	private static int m_NumFiresStarted;

	[Token(Token = "0x4001D1D")]
	private static Feat_FireMasterSaveData m_Feat_FireMasterSaveData;

	[Token(Token = "0x6001ACB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6001ACC")]
	[Address(RVA = "0x754720", Offset = "0x753520", Length = "0xE4")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001ACD")]
	[Address(RVA = "0x754810", Offset = "0x753610", Length = "0xB6")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001ACE")]
	[Address(RVA = "0x7548D0", Offset = "0x7536D0", Length = "0xBA")]
	public void ValidateSaveData(string text)
	{
	}

	[Token(Token = "0x6001ACF")]
	[Address(RVA = "0x754990", Offset = "0x753790", Length = "0x27")]
	public int GetDefaultFireStartingSkillLevel()
	{
		return 0;
	}

	[Token(Token = "0x6001AD0")]
	[Address(RVA = "0x7549C0", Offset = "0x7537C0", Length = "0xEB")]
	public void IncrementFiresStarted(int count)
	{
	}

	[Token(Token = "0x6001AD1")]
	[Address(RVA = "0x754AB0", Offset = "0x7538B0", Length = "0xEF")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x6001AD2")]
	[Address(RVA = "0x754BA0", Offset = "0x7539A0", Length = "0xB2")]
	public override string GetShortDescription()
	{
		return null;
	}

	[Token(Token = "0x6001AD3")]
	[Address(RVA = "0x754C60", Offset = "0x753A60", Length = "0xB2")]
	public override string GetBonusDescription()
	{
		return null;
	}

	[Token(Token = "0x6001AD4")]
	[Address(RVA = "0x754D20", Offset = "0x753B20", Length = "0x5B")]
	public override bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6001AD5")]
	[Address(RVA = "0x754D80", Offset = "0x753B80", Length = "0x8A")]
	public override float GetNormalizedProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6001AD6")]
	[Address(RVA = "0x754E10", Offset = "0x753C10", Length = "0x178")]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[Token(Token = "0x6001AD7")]
	[Address(RVA = "0x754F90", Offset = "0x753D90", Length = "0x147")]
	public void MaybeUpdateFireStartingSkillLevel()
	{
	}

	[Token(Token = "0x6001AD8")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Feat_FireMaster()
	{
	}
}

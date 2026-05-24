using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000349")]
public class Feat_MasterHunter : Feat
{
	[Header("Reward Settings")]
	[Tooltip("Ai detection ranges are scaled by this percentage")]
	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x4001D25")]
	[FieldOffset(Offset = "0x68")]
	private float m_AiSightRangeScale;

	[Tooltip("Ai detection ranges are scaled by this percentage")]
	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x4001D26")]
	[FieldOffset(Offset = "0x6C")]
	private float m_AiSmellRangeScale;

	[Tooltip("Ai detection ranges are scaled by this percentage")]
	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x4001D27")]
	[FieldOffset(Offset = "0x70")]
	private float m_AiSoundRangeScale;

	[Token(Token = "0x4001D28")]
	[FieldOffset(Offset = "0x74")]
	private bool m_Unlocked;

	[Token(Token = "0x4001D29")]
	[FieldOffset(Offset = "0x78")]
	private float m_SightScale;

	[Token(Token = "0x4001D2A")]
	[FieldOffset(Offset = "0x7C")]
	private float m_SmellScale;

	[Token(Token = "0x4001D2B")]
	[FieldOffset(Offset = "0x80")]
	private float m_SoundScale;

	[Token(Token = "0x6001AE9")]
	[Address(RVA = "0x755F60", Offset = "0x754D60", Length = "0x36")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001AEA")]
	[Address(RVA = "0x755FA0", Offset = "0x754DA0", Length = "0x2D")]
	public float GetSightRangeScale()
	{
		return 0f;
	}

	[Token(Token = "0x6001AEB")]
	[Address(RVA = "0x755FD0", Offset = "0x754DD0", Length = "0x2D")]
	public float GetSmellRangeScale()
	{
		return 0f;
	}

	[Token(Token = "0x6001AEC")]
	[Address(RVA = "0x756000", Offset = "0x754E00", Length = "0x30")]
	public float GetSoundRangeScale()
	{
		return 0f;
	}

	[Token(Token = "0x6001AED")]
	[Address(RVA = "0x756030", Offset = "0x754E30", Length = "0x5")]
	public override bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6001AEE")]
	[Address(RVA = "0x752400", Offset = "0x751200", Length = "0x30")]
	public override float GetNormalizedProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6001AEF")]
	[Address(RVA = "0x756040", Offset = "0x754E40", Length = "0x6D")]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[Token(Token = "0x6001AF0")]
	[Address(RVA = "0x7560B0", Offset = "0x754EB0", Length = "0xA0")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001AF1")]
	[Address(RVA = "0x756150", Offset = "0x754F50", Length = "0x78")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001AF2")]
	[Address(RVA = "0x7561D0", Offset = "0x754FD0", Length = "0x8C")]
	public void ValidateSaveData(string text)
	{
	}

	[Token(Token = "0x6001AF3")]
	[Address(RVA = "0x756260", Offset = "0x755060", Length = "0x5A")]
	public void Unlock()
	{
	}

	[Token(Token = "0x6001AF4")]
	[Address(RVA = "0x7562C0", Offset = "0x7550C0", Length = "0x58")]
	public Feat_MasterHunter()
	{
	}
}
